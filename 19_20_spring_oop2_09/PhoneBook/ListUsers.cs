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

namespace _19_20_spring_oop2_09.PhoneBook
{
    public partial class ListUsers : UserControl
    {
        string log_username;
        string path;
        public ListUsers(string username)
        {
            InitializeComponent();
            log_username = username;
            path = log_username + "_" + "phonebook";
            loadFileRecords(path);
        }
        //Kontaktlari listeye yukleme funksyonu
        public void loadFileRecords(string path)
        {
            string Name, Surname, Adress, Email, Phone, Desc;
            using (var reader = new StreamReader(Classes.GetPath.getPath(path)))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    Name = values[0];
                    Surname = values[1];
                    Adress = values[2];
                    Email = values[3];
                    Phone = values[4];
                    Desc = values[5];
                    string[] row = { Name, Surname, Adress, Email, Phone, Desc };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                }
            }
        }
        //edit buttonu
        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string Name, Surname, Adress, Email, Phone, Desc;
                string s = listView1.SelectedItems[0].SubItems[0].Text;
                Name = listView1.SelectedItems[0].SubItems[0].Text;
                Surname = listView1.SelectedItems[0].SubItems[1].Text;
                Adress = listView1.SelectedItems[0].SubItems[2].Text;
                Email = listView1.SelectedItems[0].SubItems[3].Text;
                Phone = listView1.SelectedItems[0].SubItems[4].Text;
                Desc = listView1.SelectedItems[0].SubItems[5].Text;
                //Phonebooka geri donus
                PhoneBook.CreateUser cu = new PhoneBook.CreateUser(Name, Surname, Adress, Email, Phone, Desc, log_username);
                cu.Dock = DockStyle.Fill;
                this.Controls.Clear();
                this.Controls.Add(cu);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var rows = File.ReadAllLines(Classes.GetPath.getPath(path));
                for (int rowIndex = 0; rowIndex != rows.Length; rowIndex++)
                {
                    string[] lines = rows[rowIndex].Split(',');
                    if (listView1.SelectedItems[0].SubItems[0].Text == lines[0] && listView1.SelectedItems[0].SubItems[1].Text == lines[1] && listView1.SelectedItems[0].SubItems[2].Text == lines[2]
                       && listView1.SelectedItems[0].SubItems[3].Text == lines[3] && listView1.SelectedItems[0].SubItems[4].Text == lines[4] && listView1.SelectedItems[0].SubItems[5].Text == lines[5])
                    {
                        rows = rows.Where(w => w != rows[rowIndex]).ToArray();
                        ListViewItem itm = listView1.SelectedItems[0];
                        listView1.Items[itm.Index].Remove();
                        break;
                    }
                }
                File.WriteAllLines(Classes.GetPath.getPath(path), rows);

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PhoneBook.CreateUser cu = new PhoneBook.CreateUser(log_username);
            cu.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(cu);
        }
    }
}

