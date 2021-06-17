namespace _19_20_spring_oop2_09.SalaryCalculator
{
    partial class SalaryCalculator
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button button1;
            System.Windows.Forms.Button button2;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.deneyim = new System.Windows.Forms.ComboBox();
            this.location = new System.Windows.Forms.ComboBox();
            this.degreeLevel = new System.Windows.Forms.ComboBox();
            this.ForLan = new System.Windows.Forms.ComboBox();
            this.FamSta = new System.Windows.Forms.ComboBox();
            this.ManDuty = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.firstchild = new System.Windows.Forms.ComboBox();
            this.secondchild = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.children = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.deneme = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(373, 351);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(109, 37);
            button1.TabIndex = 13;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(571, 351);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(109, 37);
            button2.TabIndex = 16;
            button2.Text = "Save Salary";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Years in Field/Career: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label2.Location = new System.Drawing.Point(95, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label3.Location = new System.Drawing.Point(64, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Degree Level: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label4.Location = new System.Drawing.Point(31, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Foreign Language:  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label5.Location = new System.Drawing.Point(47, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Managerial duty: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label6.Location = new System.Drawing.Point(60, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Family Status:  ";
            // 
            // deneyim
            // 
            this.deneyim.FormattingEnabled = true;
            this.deneyim.Items.AddRange(new object[] {
            "Entry Level",
            "2-4",
            "5-9",
            "10-14",
            "15-20",
            "Over 20"});
            this.deneyim.Location = new System.Drawing.Point(180, 40);
            this.deneyim.Name = "deneyim";
            this.deneyim.Size = new System.Drawing.Size(302, 24);
            this.deneyim.TabIndex = 6;
            // 
            // location
            // 
            this.location.FormattingEnabled = true;
            this.location.Items.AddRange(new object[] {
            "İstanbul",
            "Ankara",
            "İzmir",
            "Kocaeli,Sakarya,Düzce,Bolu,Yalova",
            "Edirne,Kırklareli,Tekirdağ",
            "Trabzon,Ordu,Giresun,Rize,Artvin,Gümüşhane",
            "Bursa,Eskişehir,Bilecik",
            "Aydın,Denizli,Muğla",
            "Adana,Mersin",
            "Balıkesir,Çanakkale",
            "Antalya,Isparta,Burdur",
            "Diğer İller"});
            this.location.Location = new System.Drawing.Point(180, 70);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(302, 24);
            this.location.TabIndex = 7;
            // 
            // degreeLevel
            // 
            this.degreeLevel.FormattingEnabled = true;
            this.degreeLevel.Items.AddRange(new object[] {
            "Master in related domain ",
            "Ph.D in related domain",
            "Assoc. Prof. in related domain",
            "Master in unrelated domain",
            "Ph.D/Assoc. Prof. in unrelated domain",
            "None"});
            this.degreeLevel.Location = new System.Drawing.Point(180, 100);
            this.degreeLevel.Name = "degreeLevel";
            this.degreeLevel.Size = new System.Drawing.Size(302, 24);
            this.degreeLevel.TabIndex = 8;
            // 
            // ForLan
            // 
            this.ForLan.FormattingEnabled = true;
            this.ForLan.Items.AddRange(new object[] {
            "English language certificate",
            "Graduation from school with English edu.",
            "Other language with certificate(for every lang.)",
            "None"});
            this.ForLan.Location = new System.Drawing.Point(180, 130);
            this.ForLan.Name = "ForLan";
            this.ForLan.Size = new System.Drawing.Size(302, 24);
            this.ForLan.TabIndex = 9;
            // 
            // FamSta
            // 
            this.FamSta.FormattingEnabled = true;
            this.FamSta.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Married and only support "});
            this.FamSta.Location = new System.Drawing.Point(180, 190);
            this.FamSta.Name = "FamSta";
            this.FamSta.Size = new System.Drawing.Size(302, 24);
            this.FamSta.TabIndex = 10;
            // 
            // ManDuty
            // 
            this.ManDuty.FormattingEnabled = true;
            this.ManDuty.Items.AddRange(new object[] {
            "CTO",
            "IT Manager(Max 5 IT staff)",
            "IT Manager(Over 5 IT staff)",
            "Project Manager",
            "Director/Project Manager",
            "Team Leader/Group Manager",
            "None"});
            this.ManDuty.Location = new System.Drawing.Point(180, 160);
            this.ManDuty.Name = "ManDuty";
            this.ManDuty.Size = new System.Drawing.Size(302, 24);
            this.ManDuty.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(179, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(311, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Minimum Wage (2020) :  5000  TRY";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(385, 227);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 17;
            // 
            // firstchild
            // 
            this.firstchild.FormattingEnabled = true;
            this.firstchild.Items.AddRange(new object[] {
            "0-6 year old",
            "7-18 year old",
            "Over 18 (provided that s/he is a college student)"});
            this.firstchild.Location = new System.Drawing.Point(137, 210);
            this.firstchild.Name = "firstchild";
            this.firstchild.Size = new System.Drawing.Size(232, 24);
            this.firstchild.TabIndex = 18;
            // 
            // secondchild
            // 
            this.secondchild.FormattingEnabled = true;
            this.secondchild.Items.AddRange(new object[] {
            "0-6 year old",
            "7-18 year old",
            "Over 18 (provided that s/he is a college student)"});
            this.secondchild.Location = new System.Drawing.Point(137, 240);
            this.secondchild.Name = "secondchild";
            this.secondchild.Size = new System.Drawing.Size(232, 24);
            this.secondchild.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label10.Location = new System.Drawing.Point(60, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 19);
            this.label10.TabIndex = 20;
            this.label10.Text = "First Child:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label11.Location = new System.Drawing.Point(45, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 19);
            this.label11.TabIndex = 21;
            this.label11.Text = "Second Child:";
            // 
            // children
            // 
            this.children.FormattingEnabled = true;
            this.children.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.children.Location = new System.Drawing.Point(180, 220);
            this.children.Name = "children";
            this.children.Size = new System.Drawing.Size(121, 24);
            this.children.TabIndex = 14;
            this.children.SelectedValueChanged += new System.EventHandler(this.Children_SelectedValueChanged1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label8.Location = new System.Drawing.Point(47, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Have Children? ";
            // 
            // deneme
            // 
            this.deneme.Location = new System.Drawing.Point(521, 314);
            this.deneme.Name = "deneme";
            this.deneme.ReadOnly = true;
            this.deneme.Size = new System.Drawing.Size(212, 22);
            this.deneme.TabIndex = 17;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // SalaryCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deneme);
            this.Controls.Add(button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.children);
            this.Controls.Add(button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ManDuty);
            this.Controls.Add(this.FamSta);
            this.Controls.Add(this.ForLan);
            this.Controls.Add(this.degreeLevel);
            this.Controls.Add(this.location);
            this.Controls.Add(this.deneyim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SalaryCalculator";
            this.Size = new System.Drawing.Size(776, 407);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
        


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox deneyim;
        private System.Windows.Forms.ComboBox location;
        private System.Windows.Forms.ComboBox degreeLevel;
        private System.Windows.Forms.ComboBox ForLan;
        private System.Windows.Forms.ComboBox FamSta;
        private System.Windows.Forms.ComboBox ManDuty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox firstchild;
        private System.Windows.Forms.ComboBox secondchild;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox children;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox deneme;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
