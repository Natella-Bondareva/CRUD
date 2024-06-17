namespace CRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddElem_Button = new Button();
            Edit_Button = new Button();
            Save_Button = new Button();
            Import_Button = new Button();
            BarbershopsListBox = new ListBox();
            Delete_Button = new Button();
            SuspendLayout();
            // 
            // AddElem_Button
            // 
            AddElem_Button.Location = new Point(21, 468);
            AddElem_Button.Name = "AddElem_Button";
            AddElem_Button.Size = new Size(94, 29);
            AddElem_Button.TabIndex = 0;
            AddElem_Button.Text = "Add";
            AddElem_Button.UseVisualStyleBackColor = true;
            AddElem_Button.Click += AddElem_Button_Click;
            // 
            // Edit_Button
            // 
            Edit_Button.Location = new Point(255, 468);
            Edit_Button.Name = "Edit_Button";
            Edit_Button.Size = new Size(94, 29);
            Edit_Button.TabIndex = 1;
            Edit_Button.Text = "Edit";
            Edit_Button.UseVisualStyleBackColor = true;
            Edit_Button.Click += Edit_Button_Click;
            // 
            // Save_Button
            // 
            Save_Button.Location = new Point(464, 468);
            Save_Button.Name = "Save_Button";
            Save_Button.Size = new Size(94, 29);
            Save_Button.TabIndex = 2;
            Save_Button.Text = "Save";
            Save_Button.UseVisualStyleBackColor = true;
            Save_Button.Click += Save_Button_Click;
            // 
            // Import_Button
            // 
            Import_Button.Location = new Point(582, 468);
            Import_Button.Name = "Import_Button";
            Import_Button.Size = new Size(94, 29);
            Import_Button.TabIndex = 3;
            Import_Button.Text = "Import";
            Import_Button.UseVisualStyleBackColor = true;
            Import_Button.Click += Import_Button_Click;
            // 
            // BarbershopsListBox
            // 
            BarbershopsListBox.FormattingEnabled = true;
            BarbershopsListBox.Location = new Point(53, 37);
            BarbershopsListBox.Name = "BarbershopsListBox";
            BarbershopsListBox.Size = new Size(593, 384);
            BarbershopsListBox.TabIndex = 4;
            // 
            // Delete_Button
            // 
            Delete_Button.Location = new Point(140, 468);
            Delete_Button.Name = "Delete_Button";
            Delete_Button.Size = new Size(94, 29);
            Delete_Button.TabIndex = 5;
            Delete_Button.Text = "Delete";
            Delete_Button.UseVisualStyleBackColor = true;
            Delete_Button.Click += Delete_Button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 522);
            Controls.Add(Delete_Button);
            Controls.Add(BarbershopsListBox);
            Controls.Add(Import_Button);
            Controls.Add(Save_Button);
            Controls.Add(Edit_Button);
            Controls.Add(AddElem_Button);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button AddElem_Button;
        private Button Edit_Button;
        private Button Save_Button;
        private Button Import_Button;
        private ListBox BarbershopsListBox;
        private Button Delete_Button;
    }
}
