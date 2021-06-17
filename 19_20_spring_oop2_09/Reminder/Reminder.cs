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
using System.Timers;
using _19_20_spring_oop2_09.Forms;

namespace _19_20_spring_oop2_09.Reminder
{
    public partial class Reminder : UserControl
    {
        string log_username;
        string path;
        private List<System.Windows.Forms.Timer> timers = new List<System.Windows.Forms.Timer>();
        public Reminder(string username)
        {
            InitializeComponent();
            log_username = username;
            dateTimePicker2.ShowUpDown = true;
            path = log_username + "_reminder";
            LoadRecords(path);
            dateTimePicker1.MinDate=DateTime.Now;
            dateTimePicker2.MinDate=DateTime.Now;
            dateTimePicker2.Value = DateTime.Now.AddSeconds(15);
        }
       public void SetTimer(DateTime date,DateTime hours,string summary)
        {
            int seconds;
            DateTime time = new DateTime(date.Year, date.Month, date.Day, hours.Hour, hours.Minute, hours.Second);
            TimeSpan t = (time - DateTime.Now);
            double dseconds = t.TotalSeconds;
            seconds = Convert.ToInt32(dseconds);
           int c = timers.Count;
            System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
            timers.Add(myTimer);
            myTimer.Dispose();
            timers[c].Interval = Convert.ToInt32(seconds*1000);
            timers[c].Tick += (s, args) => timers_Tick(summary,c);
            timers[c].Enabled = true;
            timers[c].Start();  
        }
        private void timers_Tick(string summary,int index)
        {
            timers[index].Stop();
            MessageBox.Show("Reminder due " + DateTime.Now.ToShortDateString()+ " "+DateTime.Now.ToLongTimeString()+": "+summary);  
        }
        public void LoadRecords(string path)
        {
            string Date, Time, Summary, Description, Type;
            using (var reader = new StreamReader(Classes.GetPath.getPath(path)))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    Date = values[0];
                    DateTime date = Convert.ToDateTime(values[0]);
                    Time = values[1];
                    DateTime time = Convert.ToDateTime(values[1]);
                    DateTime complete = new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second);
                    Summary = values[2];
                    Description = values[3];
                    Type = values[4];
                    string[] row = { Date, Time, Summary, Description, Type };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);

                    if (complete > DateTime.Now)
                    {
                        SetTimer(date, time, Summary);
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] row = { dateTimePicker1.Text, dateTimePicker2.Text, textBox1.Text, textBox2.Text, radioButton2.Text };
            var item = new ListViewItem(row);
            bool flag = false;
            foreach (ListViewItem itm in listView1.Items)
            {
                if (itm.SubItems[0].Text == item.SubItems[0].Text && itm.SubItems[1].Text == item.SubItems[1].Text && itm.SubItems[2].Text == item.SubItems[2].Text
                    && itm.SubItems[3].Text == item.SubItems[3].Text && itm.SubItems[4].Text == item.SubItems[4].Text)
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                MessageBox.Show("Cannot add already existing reminder. Please enter the new values and try again.");
                listView1.SelectedItems.Clear();
                textBox1.Clear();
                textBox2.Clear();
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
            else
            {
                DateTime time = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, dateTimePicker2.Value.Hour, dateTimePicker2.Value.Minute, dateTimePicker2.Value.Second);
                if (time < DateTime.Now)
                {
                    MessageBox.Show("Invalid Date/Time. Entered time/date must be at least one second after the present moment.");
                }
                else if (textBox1.Text == "")
                {
                    MessageBox.Show("Summary field required. Please enter summary of the reminder in order to save it.");
                }
                else
                {
                    SetTimer(dateTimePicker1.Value, dateTimePicker2.Value, textBox1.Text);
                    StringWriter csv = new StringWriter();
                    if (radioButton1.Checked)
                    {
                        csv.WriteLine(string.Format("{0},{1},{2},{3},{4}", dateTimePicker1.Text, dateTimePicker2.Text, textBox1.Text, textBox2.Text, radioButton1.Text));
                        row[0] = dateTimePicker1.Text;
                        row[1] = dateTimePicker2.Text;
                        row[2] = textBox1.Text;
                        row[3] = textBox2.Text;
                        row[4] = radioButton1.Text;
                    }
                    else
                    {
                        csv.WriteLine(string.Format("{0},{1},{2},{3},{4}", dateTimePicker1.Text, dateTimePicker2.Text, textBox1.Text, textBox2.Text, radioButton2.Text));
                        row[0] = dateTimePicker1.Text;
                        row[1] = dateTimePicker2.Text;
                        row[2] = textBox1.Text;
                        row[3] = textBox2.Text;
                        row[4] = radioButton2.Text;
                    }
                    File.AppendAllText(Classes.GetPath.getPath(path), csv.ToString());
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                }
            }  
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string d = listView1.SelectedItems[0].SubItems[0].Text;
                string t = listView1.SelectedItems[0].SubItems[1].Text;
                DateTime date = Convert.ToDateTime(d);
                DateTime time = Convert.ToDateTime(t);
                DateTime complete = new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second);
                if (complete < DateTime.Now)
                {
                    dateTimePicker1.Enabled = false;
                    dateTimePicker2.Enabled = false;
                    textBox1.Text = listView1.SelectedItems[0].SubItems[2].Text;
                    textBox2.Text = listView1.SelectedItems[0].SubItems[3].Text;
                    if (listView1.SelectedItems[0].SubItems[3].Text == "Meeting")
                        radioButton1.Checked = true;
                    else
                        radioButton2.Checked = true;

                    button4.Show();
                }
                else if (listView1.SelectedItems.Count > 0)
                {
                    DateTime datee= Convert.ToDateTime(listView1.SelectedItems[0].SubItems[0].Text);
                    DateTime timee= Convert.ToDateTime(listView1.SelectedItems[0].SubItems[1].Text);
                    DateTime c= new DateTime(datee.Year, datee.Month, datee.Day, timee.Hour, timee.Minute, timee.Second);
                    dateTimePicker1.Value = Convert.ToDateTime(c);
                    dateTimePicker2.Value = Convert.ToDateTime(c);
                    textBox1.Text = listView1.SelectedItems[0].SubItems[2].Text;
                    textBox2.Text = listView1.SelectedItems[0].SubItems[3].Text;
                    if (listView1.SelectedItems[0].SubItems[3].Text == "Meeting")
                        radioButton1.Checked = true;
                    else
                        radioButton2.Checked = true;
                    button4.Show();
                }
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
                       && listView1.SelectedItems[0].SubItems[3].Text == lines[3] && listView1.SelectedItems[0].SubItems[4].Text == lines[4])
                    {
                        rows = rows.Where(w => w != rows[rowIndex]).ToArray();
                        ListViewItem itm = listView1.SelectedItems[0];
                        listView1.Items[itm.Index].Remove();
                        File.WriteAllLines(Classes.GetPath.getPath(path), rows);
                        timers.Clear();
                        listView1.Items.Clear();
                        LoadRecords(path);
                        break;
                    }
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            if (listView1.SelectedItems.Count > 0)
            {
                var rows = File.ReadAllLines(Classes.GetPath.getPath(path));
                for (int rowIndex = 0; rowIndex != rows.Length; rowIndex++)
                {
                    string[] lines = rows[rowIndex].Split(',');
                    if (listView1.SelectedItems[0].SubItems[0].Text == lines[0] && listView1.SelectedItems[0].SubItems[1].Text == lines[1] && listView1.SelectedItems[0].SubItems[2].Text == lines[2]
                           && listView1.SelectedItems[0].SubItems[3].Text == lines[3] && listView1.SelectedItems[0].SubItems[4].Text == lines[4])
                    {
                        lines[0] = dateTimePicker1.Text;
                        listView1.SelectedItems[0].SubItems[0].Text = dateTimePicker1.Text;
                        lines[1] = dateTimePicker2.Text;
                        listView1.SelectedItems[0].SubItems[1].Text = dateTimePicker2.Text;
                        lines[2] = textBox1.Text;
                        listView1.SelectedItems[0].SubItems[2].Text = textBox1.Text;
                        lines[3] = textBox2.Text;
                        listView1.SelectedItems[0].SubItems[3].Text = textBox2.Text;
                        lines[4] = radioButton1.Checked == true ? radioButton1.Text : radioButton2.Text;
                        listView1.SelectedItems[0].SubItems[4].Text = radioButton1.Checked == true ? radioButton1.Text : radioButton2.Text;
                        rows[rowIndex] = string.Join(",", lines);
                        break;
                    }
                }
                File.WriteAllLines(Classes.GetPath.getPath(path), rows);
                timers.Clear();
                listView1.Items.Clear();
                LoadRecords(path);
            }
            button4.Hide();
        }
        
    }
}
