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

namespace _19_20_spring_oop2_09
{
    public partial class UserManagement : UserControl
    {
        List<Classes.User> listcollection = new List<Classes.User>();
        string[] type = { "Admin", "User", "Part-time User" };
        public UserManagement()
        {
            InitializeComponent();
            listcollection.Clear();
            foreach (Classes.User item in Forms.Login.arrayUser)
            {
                listcollection.Add(item);
                listBoxUsers.Items.Add(string.Format("{0} | {1}", item.getName(), item.getUserType()));
                searchBox.CharacterCasing = CharacterCasing.Lower;
            }
            foreach (string item in type)
            {
                if (item.StartsWith(comboBoxUserRoles.Text))
                {
                    comboBoxUserRoles.Items.Add(item);
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchBox.Text) == false)
            {
                listBoxUsers.Items.Clear();
                foreach (Classes.User item in listcollection)
                {
                    if (item.getName().StartsWith(searchBox.Text))
                    {
                        listBoxUsers.Items.Add(string.Format("{0}|{1}", item.getName(), item.getUserType()));
                    }
                }
            }
            else if (searchBox.Text == "")
            {
                listBoxUsers.Items.Clear();
                foreach (Classes.User item in listcollection)
                {
                    listBoxUsers.Items.Add(string.Format("{0} | {1}", item.getName(), item.getUserType()));
                }
            }
        }
        private void changeRole_Click(object sender, EventArgs e)
        {
            newlist.Items.Clear();
            string selecteditem = listBoxUsers.GetItemText(listBoxUsers.SelectedItem);
            string name = selecteditem.Split(' ')[0];
            string role = " ";
            foreach (Classes.User item in listcollection)
            {
                if (item.getName() == name)
                {
                    role = item.getUserType();
                }
            }
            if (comboBoxUserRoles.SelectedItem == null)
            {
                MessageBox.Show("Please choose a user role!!");
            }
            else if (listBoxUsers.SelectedItem == null)
            {
                MessageBox.Show("Please choose a user!!");
            }
            else
            {
                if (role == comboBoxUserRoles.SelectedItem.ToString())
                {
                    MessageBox.Show("There is no change!!");
                }
                else
                {
                    try
                    {
                        foreach (Classes.User item in Forms.Login.arrayUser)
                        {
                            List<string> lines = new List<string>();
                            using (StreamReader reader = new StreamReader(Classes.GetPath.getPath("UserManagement")))
                            {
                                String line;
                                while ((line = reader.ReadLine()) != null)
                                {
                                    if (line.Contains(","))
                                    {
                                        String[] split = line.Split(',');
                                        if (split[0] == name && item.getName() == name)
                                        {
                                            split[1] = comboBoxUserRoles.SelectedItem.ToString();
                                            line = String.Join(",", split);
                                            item.setUserType(comboBoxUserRoles.SelectedItem.ToString());
                                        }
                                    }
                                    lines.Add(line);
                                }
                            }
                            using (StreamWriter writer = new StreamWriter(Classes.GetPath.getPath("UserManagement"), false))
                            {
                                foreach (String line in lines)
                                    writer.WriteLine(line);
                            }
                        }
                        foreach (Classes.User item in Forms.Login.arrayUser)
                        {
                            newlist.Items.Add(string.Format("{0} | {1}", item.getName(), item.getUserType()));
                        }
                    }

                    catch
                    {
                        MessageBox.Show("User Role isn't changed!!");
                    }

                }
            }
        }
        private void TextBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)System.Windows.Forms.Keys.Space);
        }
    }
}
