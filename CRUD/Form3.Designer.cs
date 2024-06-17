namespace CRUD
{
    partial class Form3
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
            label1 = new Label();
            DescriptionTextBox = new TextBox();
            CostOfServicesTextBox = new TextBox();
            label2 = new Label();
            FirstNameTextBox = new TextBox();
            label3 = new Label();
            LastNameTextBox = new TextBox();
            label4 = new Label();
            ClientTypeComboBox = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            AdditionalServicesComboBox = new ComboBox();
            Save_Button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 21);
            label1.Name = "label1";
            label1.Size = new Size(240, 20);
            label1.TabIndex = 0;
            label1.Text = "Description of the chosen hairstyle:";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(54, 44);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(237, 27);
            DescriptionTextBox.TabIndex = 1;
            // 
            // CostOfServicesTextBox
            // 
            CostOfServicesTextBox.Location = new Point(54, 196);
            CostOfServicesTextBox.Name = "CostOfServicesTextBox";
            CostOfServicesTextBox.Size = new Size(149, 27);
            CostOfServicesTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 173);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 2;
            label2.Text = "Cost of services:";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(54, 335);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(149, 27);
            FirstNameTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 312);
            label3.Name = "label3";
            label3.Size = new Size(174, 20);
            label3.TabIndex = 4;
            label3.Text = "First name of hairdresser:";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(54, 407);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(149, 27);
            LastNameTextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 384);
            label4.Name = "label4";
            label4.Size = new Size(173, 20);
            label4.TabIndex = 6;
            label4.Text = "Last name of hairdresser:";
            // 
            // ClientTypeComboBox
            // 
            ClientTypeComboBox.FormattingEnabled = true;
            ClientTypeComboBox.Location = new Point(54, 116);
            ClientTypeComboBox.Name = "ClientTypeComboBox";
            ClientTypeComboBox.Size = new Size(237, 28);
            ClientTypeComboBox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 93);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 9;
            label5.Text = "Client type:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 241);
            label6.Name = "label6";
            label6.Size = new Size(226, 20);
            label6.TabIndex = 10;
            label6.Text = "Are additional services required?";
            // 
            // AdditionalServicesComboBox
            // 
            AdditionalServicesComboBox.FormattingEnabled = true;
            AdditionalServicesComboBox.Location = new Point(51, 264);
            AdditionalServicesComboBox.Name = "AdditionalServicesComboBox";
            AdditionalServicesComboBox.Size = new Size(152, 28);
            AdditionalServicesComboBox.TabIndex = 11;
            // 
            // Save_Button
            // 
            Save_Button.Location = new Point(54, 463);
            Save_Button.Name = "Save_Button";
            Save_Button.Size = new Size(149, 29);
            Save_Button.TabIndex = 12;
            Save_Button.Text = "Save";
            Save_Button.UseVisualStyleBackColor = true;
            Save_Button.Click += Save_Button_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 504);
            Controls.Add(Save_Button);
            Controls.Add(AdditionalServicesComboBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(ClientTypeComboBox);
            Controls.Add(LastNameTextBox);
            Controls.Add(label4);
            Controls.Add(FirstNameTextBox);
            Controls.Add(label3);
            Controls.Add(CostOfServicesTextBox);
            Controls.Add(label2);
            Controls.Add(DescriptionTextBox);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            FormClosing += Form3_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox DescriptionTextBox;
        private TextBox CostOfServicesTextBox;
        private Label label2;
        private TextBox FirstNameTextBox;
        private Label label3;
        private TextBox LastNameTextBox;
        private Label label4;
        private ComboBox ClientTypeComboBox;
        private Label label5;
        private Label label6;
        private ComboBox AdditionalServicesComboBox;
        private Button Save_Button;
    }
}