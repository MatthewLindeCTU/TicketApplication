namespace TicketApplication
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtAge = new TextBox();
            txtDistance = new TextBox();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            btnCalculate = new Button();
            btnExit = new Button();
            btnReset = new Button();
            cmbCategory = new ComboBox();
            lbOutput = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 85);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 126);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 1;
            label2.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 164);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 2;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 206);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 3;
            label4.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 247);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 4;
            label5.Text = "Distance";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(128, 23);
            label6.Name = "label6";
            label6.Size = new Size(129, 20);
            label6.TabIndex = 5;
            label6.Text = "Ticket Application";
            // 
            // txtName
            // 
            txtName.Location = new Point(194, 82);
            txtName.Name = "txtName";
            txtName.Size = new Size(147, 27);
            txtName.TabIndex = 6;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(194, 161);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(147, 27);
            txtAge.TabIndex = 7;
            // 
            // txtDistance
            // 
            txtDistance.Location = new Point(194, 244);
            txtDistance.Name = "txtDistance";
            txtDistance.Size = new Size(147, 27);
            txtDistance.TabIndex = 8;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(194, 124);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(63, 24);
            rbMale.TabIndex = 9;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(263, 124);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(78, 24);
            rbFemale.TabIndex = 10;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(45, 321);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 11;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(247, 321);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 12;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(145, 321);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 13;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "One - R20 per km", "Two - R35 per km", "Three - R50 per km" });
            cmbCategory.Location = new Point(190, 203);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(151, 28);
            cmbCategory.TabIndex = 14;
            // 
            // lbOutput
            // 
            lbOutput.FormattingEnabled = true;
            lbOutput.Location = new Point(403, 80);
            lbOutput.Name = "lbOutput";
            lbOutput.Size = new Size(245, 264);
            lbOutput.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbOutput);
            Controls.Add(cmbCategory);
            Controls.Add(btnReset);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(rbFemale);
            Controls.Add(rbMale);
            Controls.Add(txtDistance);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtDistance;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private Button btnCalculate;
        private Button btnExit;
        private Button btnReset;
        private ComboBox cmbCategory;
        private ListBox lbOutput;
    }
}
