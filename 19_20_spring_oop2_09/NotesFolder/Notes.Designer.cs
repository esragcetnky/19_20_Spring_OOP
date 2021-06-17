namespace _19_20_spring_oop2_09.NotesFolder
{
    partial class Notes
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
            this.saveNote = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Read = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
           
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // saveNote
            // 
            this.saveNote.Location = new System.Drawing.Point(243, 356);
            this.saveNote.Name = "saveNote";
            this.saveNote.Size = new System.Drawing.Size(67, 30);
            this.saveNote.TabIndex = 11;
            this.saveNote.Text = "Save";
            this.saveNote.UseVisualStyleBackColor = true;
            this.saveNote.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(316, 356);
            this.Delete.Name = "Delete";
            this.Delete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Delete.Size = new System.Drawing.Size(67, 30);
            this.Delete.TabIndex = 12;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label1.Location = new System.Drawing.Point(47, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Notes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(409, 34);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(325, 317);
            this.dataGridView1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.label2.Location = new System.Drawing.Point(49, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.label3.Location = new System.Drawing.Point(49, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Note:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(124, 73);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(259, 22);
            this.titleTextBox.TabIndex = 7;
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(124, 122);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(259, 229);
            this.messageBox.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Read
            // 
            this.Read.Location = new System.Drawing.Point(162, 356);
            this.Read.Name = "Read";
            this.Read.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Read.Size = new System.Drawing.Size(75, 30);
            this.Read.TabIndex = 10;
            this.Read.Text = "Read";
            this.Read.UseVisualStyleBackColor = true;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(81, 356);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(75, 30);
            this.NewButton.TabIndex = 9;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(406, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 36);
            this.label4.TabIndex = 14;
            this.label4.Text = "**To see the whole text, first select a note then press \'Read\' button!";
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.Read);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.saveNote);
            this.Name = "Notes";
            this.Size = new System.Drawing.Size(776, 407);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saveNote;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Label label4;
    }
}
