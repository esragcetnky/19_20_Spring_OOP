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
namespace _19_20_spring_oop2_09.NotesFolder
{
    public partial class Notes : UserControl
    {
        internal static DataTable table;
        string path ;
        public Notes(string username)
        {
            InitializeComponent();
            table = new DataTable();
            path = username + "_Notes";
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Notes", typeof(string));
            Classes.CsvToArray.csvToarray(path);
            dataGridView1.DataSource = table;
            dataGridView1.Columns["Notes"].Width=141;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Boolean a = false;
            Boolean b = false;
            Boolean c = false;
            int index=0;
            foreach (Char item in titleTextBox.Text.ToCharArray())
            {
                if (item != ' ')
                {
                    b = true;
                }
            }
            foreach (Char item in messageBox.Text.ToCharArray())
            {
                if (item != ' ')
                {
                    c = true;
                }
            }
            foreach (DataRow row in table.Rows)
            {
                if (titleTextBox.Text == row.ItemArray[0].ToString())
                {
                    a = true;
                    index = (int)table.Rows.IndexOf(row);
                }
            }
            if (a == true)
            {
                if (MessageBox.Show("Do you want to save changes?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                    List<string> lines = new List<string>();
                    using (StreamReader reader = new StreamReader(Classes.GetPath.getPath(path)))
                    {
                        String line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line.Contains(","))
                            {
                                String[] split = line.Split(',');
                                if (split[0] == table.Rows[index].ItemArray[0].ToString())
                                {
                                    split[1] = messageBox.Text;
                                    line = String.Join(",", split);
                                    table.Rows[index]["Notes"] = messageBox.Text;
                                    titleTextBox.Clear();
                                    messageBox.Clear();
                                }
                            }
                            lines.Add(line);
                        }
                    }
                    using (StreamWriter writer = new StreamWriter(Classes.GetPath.getPath(path), false))
                    {
                        foreach (String line in lines)
                            writer.WriteLine(line);
                    }
                    

                }
                else {
                    MessageBox.Show("Changes are not saved");
                    titleTextBox.Clear();
                    messageBox.Clear();
                }
            }
            else if (b == false||c==false)
            {
                MessageBox.Show("Please enter the title and notes to save!!!!");
            }
            else{
                table.Rows.Add(titleTextBox.Text, messageBox.Text);
                StringWriter csv = new StringWriter();
                //textbox'daki girdileri dosyaya yazar.
                csv.WriteLine(string.Format("{0},{1}", titleTextBox.Text, messageBox.Text));
                File.AppendAllText(Classes.GetPath.getPath(path), csv.ToString());
            }
        }
        private void NewButton_Click(object sender, EventArgs e)
        {
            titleTextBox.Clear();
            messageBox.Clear();
        }
        private void Read_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {

                int index = dataGridView1.CurrentCell.RowIndex;
                titleTextBox.Text = table.Rows[index].ItemArray[0].ToString();
                messageBox.Text = table.Rows[index].ItemArray[1].ToString();

            }
            else
            {
                MessageBox.Show("Please select a note!");
            }
            
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                if (titleTextBox.Text == table.Rows[index].ItemArray[0].ToString())
                {
                    titleTextBox.Clear();
                    messageBox.Clear();
                }
                List<string> lines = new List<string>();
                using (StreamReader reader = new StreamReader(Classes.GetPath.getPath(path)))
                {
                    String line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains(","))
                        {
                            String[] split = line.Split(',');
                            if (split[0] != table.Rows[index].ItemArray[0].ToString())
                            {
                                lines.Add(line);

                            }
                        }
                    }
                }
                using (StreamWriter writer = new StreamWriter(Classes.GetPath.getPath(path), false))
                {
                    foreach (String line in lines)
                        writer.WriteLine(line);
                }

                table.Rows[index].Delete();
            }
            else{
                MessageBox.Show("Please select a note!");
            }

        }
    }
}
