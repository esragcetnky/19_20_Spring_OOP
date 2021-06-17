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

namespace _19_20_spring_oop2_09.SalaryCalculator
{
    public partial class SalaryCalculator : UserControl
    {
        double salary;
        string username;
        public SalaryCalculator(string log_username)
        {
            username = log_username;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {                      
            deneme.Text = calculate().ToString();            
        }
        private double calculate()
        {
            double katsayı = 0;
            katsayı += Deneyim_SelectedIndexChanged() + Location_SelectedIndexChanged();
            katsayı += DegreeLevel_SelectedIndexChanged() + ForLan_SelectedIndexChanged();
            katsayı += ManDuty_SelectedIndexChanged() + FamSta_SelectedIndexChanged();
            double minimum_wage = 5000;
            double salary = minimum_wage * (katsayı + 1);
            return salary;
        }
        private double Deneyim_SelectedIndexChanged()      
        {
            if(deneyim.SelectedIndex == 0|| deneyim.SelectedItem == null) { return 0; }
            else if (deneyim.SelectedIndex == 1){return 0.60; }
            else if (deneyim.SelectedIndex == 2){ return 1; }
            else if (deneyim.SelectedIndex == 3){ return 1.20; }
            else if (deneyim.SelectedIndex == 4){ return 1.35; }
            else { return 1.50; }
        }
        private double Location_SelectedIndexChanged()
        {
            if (location.SelectedIndex== 0) { return 0.15; }
            else if (location.SelectedIndex == 1|| deneyim.SelectedIndex == 2) { return 0.1; }
            else if (location.SelectedIndex == 3|| deneyim.SelectedIndex == 4) { return 0.05; }
            else if (location.SelectedIndex == 11|| location.SelectedItem == null) { return 0; }
            else { return  0.03; }
        }
        private double DegreeLevel_SelectedIndexChanged()
        {
            if (degreeLevel.SelectedIndex == 0) { return 0.10; }
            else if (degreeLevel.SelectedIndex == 1) { return 0.30; }
            else if (degreeLevel.SelectedIndex == 2) { return 0.35; }
            else if (degreeLevel.SelectedIndex == 3) { return 0.05; }
            else if (degreeLevel.SelectedIndex == 4) { return 0.15; }
            else { return 0; }
        }
        private double ForLan_SelectedIndexChanged()
        {
            if (ForLan.SelectedIndex == 0) { return 0.2; }
            else if (ForLan.SelectedIndex == 1) { return 0.2; }
            else if (ForLan.SelectedIndex == 2) { return 0.05; }
            else { return 0; }
        }
        private double FamSta_SelectedIndexChanged()
        {
            double a=0;
            if (FamSta.SelectedIndex == 2) { a += 0.20; }
            if (children.SelectedIndex == 1 || children.SelectedIndex ==2)
            {
                if (firstchild.SelectedIndex == 0) { a += 0.20; }
                else if (firstchild.SelectedIndex == 1) { a += 0.30; }
                else if (firstchild.SelectedIndex == 2) { a += 0.40; }
                if (secondchild.SelectedIndex == 0) { a += 0.20; }
                else if (secondchild.SelectedIndex == 1) { a += 0.30; }
                else if (secondchild.SelectedIndex == 2) { a += 0.40; }
            }
            return a;            
        }            
        private double ManDuty_SelectedIndexChanged()
        {
            if (ManDuty.SelectedIndex == 0) { return 1; }
            else if (ManDuty.SelectedIndex == 1) { return 0.4; }
            else if (ManDuty.SelectedIndex == 2) { return 0.6; }
            else if (ManDuty.SelectedIndex == 3) { return 0.75; }
            else if (ManDuty.SelectedIndex == 4) { return 0.85; }
            else if (ManDuty.SelectedIndex == 5) { return 0.5; }
            else { return 0; }
        }
        private void Children_SelectedValueChanged1(object sender, System.EventArgs e)
        {
            if (children.SelectedIndex == 1)
            {
                this.Controls.Remove(this.label11);
                this.Controls.Remove(this.secondchild);
                this.Controls.Add(this.firstchild);
                this.Controls.Add(this.label10);
            }
            else if (children.SelectedIndex == 2)
            {
                this.Controls.Add(this.firstchild);
                this.Controls.Add(this.label10);
                this.Controls.Add(this.label11);
                this.Controls.Add(this.secondchild);
            }
            else
            {
                this.Controls.Remove(this.label11);
                this.Controls.Remove(this.secondchild);
                this.Controls.Remove(this.label10);
                this.Controls.Remove(this.firstchild);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            salary=calculate();
            try {
                List<string> lines = new List<string>();
                using (StreamReader reader = new StreamReader(Classes.GetPath.getPath("UserInformation")))
                {
                    String line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains(","))
                        {
                            String[] split = line.Split(',');
                            if (split[0] == username)
                            {
                                split[7] = salary.ToString();
                                line = String.Join(",", split);
                            }
                        }
                        lines.Add(line);
                    }
                }
                using (StreamWriter writer = new StreamWriter(Classes.GetPath.getPath("UserInformation"), false))
                {
                    foreach (String line in lines)
                        writer.WriteLine(line);
                }
                MessageBox.Show("Success");
            }
            catch
            {
                MessageBox.Show("Failed");
            }
            
        }
    }
}
