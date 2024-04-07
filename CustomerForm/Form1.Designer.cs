namespace CustomerForm
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
            label1 = new Label();
            label2 = new Label();
            FirstNameText = new TextBox();
            LastNameText = new TextBox();
            label3 = new Label();
            label4 = new Label();
            EmailText = new TextBox();
            PhoneNumberText = new TextBox();
            ButtonText = new Button();
            CustomerFormGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)CustomerFormGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1435, 71);
            label1.Name = "label1";
            label1.Size = new Size(160, 38);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1435, 135);
            label2.Name = "label2";
            label2.Size = new Size(155, 38);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // FirstNameText
            // 
            FirstNameText.Location = new Point(1684, 78);
            FirstNameText.Name = "FirstNameText";
            FirstNameText.Size = new Size(337, 31);
            FirstNameText.TabIndex = 2;
            // 
            // LastNameText
            // 
            LastNameText.Location = new Point(1684, 143);
            LastNameText.Name = "LastNameText";
            LastNameText.Size = new Size(337, 31);
            LastNameText.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1435, 210);
            label3.Name = "label3";
            label3.Size = new Size(89, 38);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1435, 281);
            label4.Name = "label4";
            label4.Size = new Size(216, 38);
            label4.TabIndex = 5;
            label4.Text = "Phone Number";
            // 
            // EmailText
            // 
            EmailText.Location = new Point(1684, 218);
            EmailText.Name = "EmailText";
            EmailText.Size = new Size(335, 31);
            EmailText.TabIndex = 6;
            // 
            // PhoneNumberText
            // 
            PhoneNumberText.Location = new Point(1684, 289);
            PhoneNumberText.Name = "PhoneNumberText";
            PhoneNumberText.Size = new Size(335, 31);
            PhoneNumberText.TabIndex = 7;
            // 
            // ButtonText
            // 
            ButtonText.BackColor = SystemColors.GradientActiveCaption;
            ButtonText.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonText.Location = new Point(1720, 381);
            ButtonText.Name = "ButtonText";
            ButtonText.Size = new Size(274, 58);
            ButtonText.TabIndex = 8;
            ButtonText.Text = "Submit";
            ButtonText.UseVisualStyleBackColor = false;
            ButtonText.Click += button1_Click;
            // 
            // CustomerFormGrid
            // 
            CustomerFormGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerFormGrid.Location = new Point(85, 78);
            CustomerFormGrid.Name = "CustomerFormGrid";
            CustomerFormGrid.RowHeadersWidth = 62;
            CustomerFormGrid.RowTemplate.Height = 33;
            CustomerFormGrid.Size = new Size(1315, 688);
            CustomerFormGrid.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2088, 833);
            Controls.Add(CustomerFormGrid);
            Controls.Add(ButtonText);
            Controls.Add(PhoneNumberText);
            Controls.Add(EmailText);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(LastNameText);
            Controls.Add(FirstNameText);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)CustomerFormGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox FirstNameText;
        private TextBox LastNameText;
        private Label label3;
        private Label label4;
        private TextBox EmailText;
        private TextBox PhoneNumberText;
        private Button ButtonText;
        private DataGridView CustomerFormGrid;
    }
}
