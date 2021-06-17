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
using _19_20_spring_oop2_09.Classes;
using System.Net;
using System.Net.Mail;

namespace _19_20_spring_oop2_09.Personal_Information
{
    public partial class pInfo : UserControl
    {
        string log_username;
        string log_password;
        public pInfo(string username, string password)
        {
            log_username = username;
            log_password = password;           
            InitializeComponent();
            LoadInfo();
        }
        private void LoadInfo()
        {
            if (GetPath.pathExists(log_username + "_pic"))
            {
                pictureBox1.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(GetPath.getPath(log_username + "_pic"))));
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

            string[] rows = File.ReadAllLines(GetPath.getPath("UserInformation"));
            for (int i = 0; i < rows.Count(); i++)
            {
                //defname,defsurname,defemail,defphone,defadress
                string[] lines = rows[i].Split(',');
                if (lines[0] == log_username)
                {
                    if (lines[2] != "defname")
                        textBox1.Text = lines[2];
                    if (lines[3] != "defsurname")
                        textBox2.Text = lines[3];
                    textBox3.Text = log_password;
                    if (lines[4] != "defemail")
                        textBox4.Text = lines[4];
                    if (lines[5] != "defphone")
                        textBox5.Text = lines[5];
                    if (lines[6] != "defadress")
                        textBox6.Text = lines[6];
                    if (lines[7] != "defsalary")
                        textBox7.Text = lines[7];
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox4.Text.Length>0 && Extension.IsValidEmail(textBox4.Text)) || textBox4.Text.Length==0)
            {
                string[] rows = File.ReadAllLines(GetPath.getPath("UserInformation"));
                for (int i = 0; i < rows.Count(); i++)
                {
                    string[] lines = rows[i].Split(',');
                    if (lines[0] == log_username)
                    {
                        lines[1] = ComputeSha256Hash_.ComputeSha256Hash(textBox3.Text);
                        lines[2] = textBox1.Text;
                        lines[3] = textBox2.Text;
                        lines[4] = textBox4.Text;
                        lines[5] = textBox5.Text;
                        lines[6] = textBox6.Text;
                        lines[7] = textBox7.Text;
                        rows[i] = string.Join(",", lines);
                        MessageBox.Show("Succes");
                    }
                }
                File.WriteAllLines(GetPath.getPath("UserInformation"), rows);
            }
            else
                MessageBox.Show("Invalid email. Please enter a valid email. Example:email@email.com");

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog1.Title = "Please select an image to set as your profile picture";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                byte[] imageArray = System.IO.File.ReadAllBytes(openFileDialog1.FileName);
                string base64ImageRepresentation = Convert.ToBase64String(imageArray);
                File.WriteAllBytes(GetPath.getPath(log_username + "_pic"), imageArray);
                //Encrypt the selected file. I'll do this later. :)
            }
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
    public static class Extension
    {
        public static bool IsValidEmail(this string email)
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(email);
        }
    }
}

