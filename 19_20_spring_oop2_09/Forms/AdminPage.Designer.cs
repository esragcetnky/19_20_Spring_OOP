namespace _19_20_spring_oop2_09.Forms
{
    partial class AdminPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remindersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adminUserManagement = new _19_20_spring_oop2_09.UserManagement();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.userManagementToolStripMenuItem,
            this.phoneBookToolStripMenuItem,
            this.notesToolStripMenuItem,
            this.personalInformationToolStripMenuItem,
            this.salaryCalculatorToolStripMenuItem,
            this.remindersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(658, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click1);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.userManagementToolStripMenuItem.Text = "User Management";
            this.userManagementToolStripMenuItem.Click += new System.EventHandler(this.UserManagementToolStripMenuItem_Click1);
            // 
            // phoneBookToolStripMenuItem
            // 
            this.phoneBookToolStripMenuItem.Name = "phoneBookToolStripMenuItem";
            this.phoneBookToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.phoneBookToolStripMenuItem.Text = "Phone Book";
            this.phoneBookToolStripMenuItem.Click += new System.EventHandler(this.phoneBookToolStripMenuItem_Click);
            // 
            // notesToolStripMenuItem
            // 
            this.notesToolStripMenuItem.Name = "notesToolStripMenuItem";
            this.notesToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.notesToolStripMenuItem.Text = "Notes";
            this.notesToolStripMenuItem.Click += new System.EventHandler(this.notesToolStripMenuItem_Click_1);
            // 
            // personalInformationToolStripMenuItem
            // 
            this.personalInformationToolStripMenuItem.Name = "personalInformationToolStripMenuItem";
            this.personalInformationToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.personalInformationToolStripMenuItem.Text = "Personal Information";
            this.personalInformationToolStripMenuItem.Click += new System.EventHandler(this.personalInformationToolStripMenuItem_Click);
            // 
            // salaryCalculatorToolStripMenuItem
            // 
            this.salaryCalculatorToolStripMenuItem.Name = "salaryCalculatorToolStripMenuItem";
            this.salaryCalculatorToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.salaryCalculatorToolStripMenuItem.Text = "Salary Calculator";
            this.salaryCalculatorToolStripMenuItem.Click += new System.EventHandler(this.salaryCalculatorToolStripMenuItem_Click);
            // 
            // remindersToolStripMenuItem
            // 
            this.remindersToolStripMenuItem.Name = "remindersToolStripMenuItem";
            this.remindersToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.remindersToolStripMenuItem.Text = "Reminders";
            this.remindersToolStripMenuItem.Click += new System.EventHandler(this.remindersToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 30F);
            this.Title.Location = new System.Drawing.Point(9, 53);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(167, 46);
            this.Title.TabIndex = 1;
            this.Title.Text = "Welcome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label1.Location = new System.Drawing.Point(13, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please choose your preferred process from menubar above";
            // 
            // adminUserManagement
            // 
            this.adminUserManagement.Location = new System.Drawing.Point(0, 31);
            this.adminUserManagement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adminUserManagement.Name = "adminUserManagement";
            this.adminUserManagement.Size = new System.Drawing.Size(800, 407);
            this.adminUserManagement.TabIndex = 1;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 407);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminPage";
            this.Text = "Admin Page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminPage_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.FormClosing += AdminPage_FormClosing;
            this.PerformLayout();

        }

        
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryCalculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remindersToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private UserManagement adminUserManagement;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
    }
}