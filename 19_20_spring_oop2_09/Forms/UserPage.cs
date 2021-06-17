using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _19_20_spring_oop2_09.Forms
{
    public partial class UserPage : Form
    {
        string log_username;
        string log_password;
        public UserPage(string username,string password)
        {
            //form'un design özellikleri
            Height = 400;
            Width = 600;
            Text = "User Page";
            InitializeComponent();
            log_username = username;
        }
        //log out fonk.
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _19_20_spring_oop2_09.Properties.Settings.Default.UserName = null;
            _19_20_spring_oop2_09.Properties.Settings.Default.Password = null;
            _19_20_spring_oop2_09.Properties.Settings.Default.Save();
            Application.Exit();
        }
        //save file fonk.
        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PSV dosyası|*.psv";
            save.OverwritePrompt = true;
            save.CreatePrompt = true;

            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Kayit = new StreamWriter(save.FileName);

                foreach (Classes.User item in Login.arrayUser)
                {
                    Kayit.WriteLine("{0},{1}", item.getName(), item.getUserType());
                }
                Kayit.Close();
            }
        }
        private void UserPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        //Phonebook Open
        private void phoneBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhoneBook.ListUsers lu = new PhoneBook.ListUsers(log_username);
            lu.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(menuStrip1);
            this.Controls.Add(lu);
        }
        private void notesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotesFolder.Notes notesPages = new NotesFolder.Notes(log_username);
            notesPages.Location = new System.Drawing.Point(12, 31);
            notesPages.Name = "notesPages";
            notesPages.Size = new System.Drawing.Size(776, 407);
            notesPages.TabIndex = 0;
            this.Controls.Clear();
            this.Controls.Add(menuStrip1);
            Controls.Add(notesPages);
        }
        private void personalInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personal_Information.pInfo pInformation = new Personal_Information.pInfo(log_username, log_password);
            pInformation.Location = new System.Drawing.Point(12, 31);
            pInformation.Name = "Personal Information";
            pInformation.Size = new System.Drawing.Size(776, 407);
            pInformation.TabIndex = 0;
            this.Controls.Clear();
            this.Controls.Add(menuStrip1);
            Controls.Add(pInformation);
        }
        private void salaryCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalaryCalculator.SalaryCalculator Scalculator = new SalaryCalculator.SalaryCalculator(log_username);
            Scalculator.Location = new System.Drawing.Point(12, 31);
            Scalculator.Name = "notesPages";
            Scalculator.Size = new System.Drawing.Size(776, 407);
            Scalculator.TabIndex = 0;
            this.Controls.Clear();
            this.Controls.Add(menuStrip1);
            Controls.Add(Scalculator);
        }
        private void remindersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reminder.Reminder reminder = new Reminder.Reminder(log_username);
            reminder.Location = new System.Drawing.Point(12, 31);
            reminder.Name = "Reminder";
            reminder.Size = new System.Drawing.Size(776, 407);
            reminder.TabIndex = 0;
            this.Controls.Clear();
            this.Controls.Add(menuStrip1);
            Controls.Add(reminder);
        }
        private void UserPage_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing)
                return;
            if (MessageBox.Show("Are you sure you want to close the form?", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
            else
            {
                e.Cancel = false;
            }
        }
    }
}
