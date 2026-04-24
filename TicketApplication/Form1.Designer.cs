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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(45, 85);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(45, 126);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 1;
            label2.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(45, 164);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 2;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(45, 209);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 3;
            label4.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(45, 262);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 4;
            label5.Text = "Distance";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(224, 20);
            label6.Name = "label6";
            label6.Size = new Size(215, 26);
            label6.TabIndex = 5;
            label6.Text = "Ticket Application";
            // 
            // txtName
            // 
            txtName.Location = new Point(134, 82);
            txtName.Name = "txtName";
            txtName.Size = new Size(180, 27);
            txtName.TabIndex = 6;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(134, 161);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(180, 27);
            txtAge.TabIndex = 7;
            // 
            // txtDistance
            // 
            txtDistance.Location = new Point(134, 259);
            txtDistance.Name = "txtDistance";
            txtDistance.Size = new Size(180, 27);
            txtDistance.TabIndex = 8;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.BackColor = Color.Transparent;
            rbMale.ForeColor = Color.White;
            rbMale.Location = new Point(134, 124);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(84, 24);
            rbMale.TabIndex = 9;
            rbMale.TabStop = true;
            rbMale.Text = "♂️Male";
            rbMale.UseVisualStyleBackColor = false;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.BackColor = Color.Transparent;
            rbFemale.ForeColor = Color.White;
            rbFemale.Location = new Point(215, 124);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(99, 24);
            rbFemale.TabIndex = 10;
            rbFemale.TabStop = true;
            rbFemale.Text = "♀️Female";
            rbFemale.UseVisualStyleBackColor = false;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.FromArgb(255, 192, 128);
            btnCalculate.Location = new Point(134, 321);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 11;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 128, 128);
            btnExit.Location = new Point(461, 321);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 12;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(255, 255, 128);
            btnReset.Location = new Point(293, 321);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 13;
            btnReset.Text = "Clear";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "One - R20 per km", "Two - R35 per km", "Three - R50 per km" });
            cmbCategory.Location = new Point(134, 206);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(180, 28);
            cmbCategory.TabIndex = 14;
            // 
            // lbOutput
            // 
            lbOutput.FormattingEnabled = true;
            lbOutput.Location = new Point(346, 82);
            lbOutput.Name = "lbOutput";
            lbOutput.Size = new Size(209, 204);
            lbOutput.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(623, 390);
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
            Load += Form1_Load;
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
