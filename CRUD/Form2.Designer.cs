namespace CRUD
{
    partial class Form2
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
            IDTextBox = new TextBox();
            dateTimePicker = new DateTimePicker();
            HairdosListBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            helpProvider1 = new HelpProvider();
            AddElem_Button = new Button();
            Delete_Button = new Button();
            Save_Button = new Button();
            Edit_Button = new Button();
            SuspendLayout();
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(53, 83);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(125, 27);
            IDTextBox.TabIndex = 0;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(53, 159);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(197, 27);
            dateTimePicker.TabIndex = 1;
            // 
            // HairdosListBox
            // 
            HairdosListBox.FormattingEnabled = true;
            HairdosListBox.Location = new Point(12, 236);
            HairdosListBox.Name = "HairdosListBox";
            HairdosListBox.Size = new Size(670, 144);
            HairdosListBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 60);
            label1.Name = "label1";
            helpProvider1.SetShowHelp(label1, true);
            label1.Size = new Size(107, 20);
            label1.TabIndex = 3;
            label1.Text = "Barbershop ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 136);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 4;
            label2.Text = "Data:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 213);
            label3.Name = "label3";
            label3.Size = new Size(178, 20);
            label3.TabIndex = 5;
            label3.Text = "Hairdos with hairdressers:";
            // 
            // helpProvider1
            // 
            helpProvider1.HelpNamespace = "\"Help\"";
            // 
            // AddElem_Button
            // 
            AddElem_Button.Location = new Point(53, 455);
            AddElem_Button.Name = "AddElem_Button";
            AddElem_Button.Size = new Size(94, 29);
            AddElem_Button.TabIndex = 6;
            AddElem_Button.Text = "Add";
            AddElem_Button.UseVisualStyleBackColor = true;
            AddElem_Button.Click += AddElem_Button_Click;
            // 
            // Delete_Button
            // 
            Delete_Button.Location = new Point(175, 455);
            Delete_Button.Name = "Delete_Button";
            Delete_Button.Size = new Size(94, 29);
            Delete_Button.TabIndex = 9;
            Delete_Button.Text = "Delete";
            Delete_Button.UseVisualStyleBackColor = true;
            Delete_Button.Click += Delete_Button_Click;
            // 
            // Save_Button
            // 
            Save_Button.Location = new Point(499, 455);
            Save_Button.Name = "Save_Button";
            Save_Button.Size = new Size(94, 29);
            Save_Button.TabIndex = 8;
            Save_Button.Text = "Save";
            Save_Button.UseVisualStyleBackColor = true;
            Save_Button.Click += Save_Button_Click;
            // 
            // Edit_Button
            // 
            Edit_Button.Location = new Point(290, 455);
            Edit_Button.Name = "Edit_Button";
            Edit_Button.Size = new Size(94, 29);
            Edit_Button.TabIndex = 7;
            Edit_Button.Text = "Edit";
            Edit_Button.UseVisualStyleBackColor = true;
            Edit_Button.Click += Edit_Button_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 513);
            Controls.Add(Delete_Button);
            Controls.Add(Save_Button);
            Controls.Add(Edit_Button);
            Controls.Add(AddElem_Button);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(HairdosListBox);
            Controls.Add(dateTimePicker);
            Controls.Add(IDTextBox);
            Name = "Form2";
            Text = "Form2";
            FormClosing += Form2_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox IDTextBox;
        private DateTimePicker dateTimePicker;
        private ListBox HairdosListBox;
        private Label label1;
        private HelpProvider helpProvider1;
        private Label label2;
        private Label label3;
        private Button AddElem_Button;
        private Button Delete_Button;
        private Button Save_Button;
        private Button Edit_Button;
    }
}