using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace _19_20_spring_oop2_09.PhoneBook
{
    public partial class CreateUser : UserControl
    {
        //Edit olarak kullandigimizda ilk cagrdimizda Contact'in adi-file erismek icin kullanilir
        string e_Name;
        string log_username;
        string path;
        //create user constructor.
        public CreateUser(string username)
        {
            InitializeComponent();
            log_username = username;
            path = log_username + "_" + "phonebook";
            button2.Hide();
        }
        // Bu user control edit icin kullandigimizda CreateUser bu constructoru cagriyor
        public CreateUser(string Name, string Surname, string Adress, string Email, string Phone, string Desc, string username)
        {
           
            e_Name = Name;
            textBox1.Text = Name;
            textBox2.Text = Surname;
            textBox3.Text = Adress;
            maskedTextBox1.Text = Phone;
            textBox4.Text = Email;
            textBox6.Text = Desc;
            button1.Hide();
        }
        //Add contact kismida Save buttonu
        private void button1_Click(object sender, EventArgs e)
        {
            int counter = maskedTextBox1.Text.Count(Char.IsWhiteSpace);
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && counter == 3 && maskedTextBox1.Text.Length == 15 && textBox4.Text.Length > 0 && textBox6.Text.Length > 0)
            {
                try
                {
                    StringWriter csv = new StringWriter();
                    csv.WriteLine(string.Format("{0},{1},{2},{3},{4},{5}", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, maskedTextBox1.Text, textBox6.Text));
                    File.AppendAllText(Classes.GetPath.getPath(path), csv.ToString());
                    MessageBox.Show(" Succes.");
                    //Phonebooka geri donus
                    PhoneBook.ListUsers lu = new PhoneBook.ListUsers(log_username);
                    lu.Dock = DockStyle.Fill;
                    this.Controls.Clear();
                    this.Controls.Add(lu);
                }
                catch
                {
                    MessageBox.Show(" Path/File Writer error");
                }
            }
            else
            {
                if (textBox1.Text.Length == 0)
                    MessageBox.Show("You didn't entered a name. Name field is required");
                else if (textBox2.Text.Length == 0)
                    MessageBox.Show("Surname field is empty. Please enter a valid surname.");
                else if (textBox3.Text.Length == 0)
                    MessageBox.Show("You left the adress field blank. Please enter the adress.");
                else if (textBox4.Text.Length == 0)
                    MessageBox.Show("You left the e-mail field empty. Please enter a valid descr.");
                else if (counter > 3 || maskedTextBox1.Text.Length != 15)
                    MessageBox.Show("The entered phone number is not valid. Please enter a valid phone number.");
                else if (textBox6.Text.Length == 0)
                    MessageBox.Show("You left the description field empty. Please enter a valid description.");
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            string errMessage;
            if (!validEmail(textBox4.Text, out errMessage))
            {
                e.Cancel = true;
                MessageBox.Show(errMessage);
                textBox4.Select(0, textBox4.Text.Length);
            }
        }
        public bool validEmail(string email, out string errorMessage)
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^([\w]+)@([\w]+)\.([\w]+)$");
            if (email.Length == 0)
            {
                errorMessage = "A valid e-mail adress is required";
                return false;
            }
            if (rEmail.IsMatch(email))
            {
                errorMessage = "";
                return true;
            }
            errorMessage = "E-mail must be in valid format.For example: email@example.com";
            return false;
        }
        //edit buttonu
        private void button2_Click(object sender, EventArgs e)
        {
            var rows = File.ReadAllLines(Classes.GetPath.getPath(path));
            for (int rowIndex = 0; rowIndex != rows.Length; rowIndex++)
            {
                string[] lines = rows[rowIndex].Split(',');
                if (String.Equals(e_Name, lines[0]))
                {
                    lines[0] = textBox1.Text;
                    lines[1] = textBox2.Text;
                    lines[2] = textBox3.Text;
                    lines[3] = textBox4.Text;
                    lines[4] = maskedTextBox1.Text;
                    lines[5] = textBox6.Text;
                    rows[rowIndex] = string.Join(",", lines);
                    MessageBox.Show("Contact edited succesfully.");
                    break;
                }
            }
            File.WriteAllLines(Classes.GetPath.getPath(path), rows);
            //phonebooka geri donus
            PhoneBook.ListUsers lu = new PhoneBook.ListUsers(log_username);
            lu.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(lu);
        }
    }
}
