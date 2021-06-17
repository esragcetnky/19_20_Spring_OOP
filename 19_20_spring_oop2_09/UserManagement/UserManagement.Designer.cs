namespace _19_20_spring_oop2_09
{
    partial class UserManagement
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
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.comboBoxUserRoles = new System.Windows.Forms.ComboBox();
            this.changeRole = new System.Windows.Forms.Button();
            this.newlist = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.ItemHeight = 16;
            this.listBoxUsers.Location = new System.Drawing.Point(70, 77);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(246, 324);
            this.listBoxUsers.TabIndex = 0;
            // 
            // searchBox
            // 
            this.searchBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.searchBox.Location = new System.Drawing.Point(152, 46);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.searchBox.Size = new System.Drawing.Size(164, 24);
            this.searchBox.TabIndex = 2;
            this.searchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.searchLabel.Location = new System.Drawing.Point(66, 47);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(55, 19);
            this.searchLabel.TabIndex = 3;
            this.searchLabel.Text = "Search";
            // 
            // comboBoxUserRoles
            // 
            this.comboBoxUserRoles.FormattingEnabled = true;
            this.comboBoxUserRoles.Location = new System.Drawing.Point(345, 189);
            this.comboBoxUserRoles.Name = "comboBoxUserRoles";
            this.comboBoxUserRoles.Size = new System.Drawing.Size(127, 24);
            this.comboBoxUserRoles.TabIndex = 8;
            // 
            // changeRole
            // 
            this.changeRole.Location = new System.Drawing.Point(360, 228);
            this.changeRole.Name = "changeRole";
            this.changeRole.Size = new System.Drawing.Size(91, 31);
            this.changeRole.TabIndex = 9;
            this.changeRole.Text = "Change";
            this.changeRole.UseVisualStyleBackColor = true;
            this.changeRole.Click += new System.EventHandler(this.changeRole_Click);
            // 
            // newlist
            // 
            this.newlist.FormattingEnabled = true;
            this.newlist.ItemHeight = 16;
            this.newlist.Location = new System.Drawing.Point(500, 77);
            this.newlist.Name = "newlist";
            this.newlist.Size = new System.Drawing.Size(246, 324);
            this.newlist.TabIndex = 10;
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newlist);
            this.Controls.Add(this.changeRole);
            this.Controls.Add(this.comboBoxUserRoles);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.listBoxUsers);
            this.Name = "UserManagement";
            this.Size = new System.Drawing.Size(800, 416);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.ComboBox comboBoxUserRoles;
        private System.Windows.Forms.Button changeRole;
        private System.Windows.Forms.ListBox newlist;
    }
}
