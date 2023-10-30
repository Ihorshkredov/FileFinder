namespace FileFinder
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
            button1 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            panel1 = new Panel();
            panel2 = new Panel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnBrowseLog = new Button();
            btnBrowseSn = new Button();
            progressBar1 = new ProgressBar();
            txtBoxDestination = new TextBox();
            btnBrowseDestination = new Button();
            btnHelp = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(378, 450);
            button1.Name = "button1";
            button1.Size = new Size(243, 49);
            button1.TabIndex = 0;
            button1.Text = "FIND";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(94, 15);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(77, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "BY NAME";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(195, 15);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(99, 19);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "STRING in File";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Location = new Point(27, 278);
            panel1.Name = "panel1";
            panel1.Size = new Size(828, 135);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(checkBox2);
            panel2.Location = new Point(27, 168);
            panel2.Name = "panel2";
            panel2.Size = new Size(854, 104);
            panel2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(121, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(699, 23);
            textBox1.TabIndex = 5;
            textBox1.Text = "Choose folder with logs";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            textBox2.Location = new Point(121, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(699, 23);
            textBox2.TabIndex = 7;
            textBox2.Text = "Choose SN.txt";
            // 
            // btnBrowseLog
            // 
            btnBrowseLog.Location = new Point(826, 16);
            btnBrowseLog.Name = "btnBrowseLog";
            btnBrowseLog.Size = new Size(94, 32);
            btnBrowseLog.TabIndex = 8;
            btnBrowseLog.Text = "Browse ";
            btnBrowseLog.UseVisualStyleBackColor = true;
            btnBrowseLog.Click += btnBrowseLog_Click;
            // 
            // btnBrowseSn
            // 
            btnBrowseSn.Location = new Point(829, 68);
            btnBrowseSn.Name = "btnBrowseSn";
            btnBrowseSn.Size = new Size(91, 34);
            btnBrowseSn.TabIndex = 9;
            btnBrowseSn.Text = "Browse";
            btnBrowseSn.UseVisualStyleBackColor = true;
            btnBrowseSn.Click += btnBrowseSn_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(30, 521);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(941, 23);
            progressBar1.TabIndex = 10;
            // 
            // txtBoxDestination
            // 
            txtBoxDestination.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtBoxDestination.Location = new Point(121, 131);
            txtBoxDestination.Name = "txtBoxDestination";
            txtBoxDestination.Size = new Size(699, 23);
            txtBoxDestination.TabIndex = 11;
            txtBoxDestination.Text = "Choose destination folder";
            // 
            // btnBrowseDestination
            // 
            btnBrowseDestination.Location = new Point(829, 124);
            btnBrowseDestination.Name = "btnBrowseDestination";
            btnBrowseDestination.Size = new Size(87, 34);
            btnBrowseDestination.TabIndex = 12;
            btnBrowseDestination.Text = "Browse";
            btnBrowseDestination.UseVisualStyleBackColor = true;
            btnBrowseDestination.Click += btnBrowseDestination_Click;
            // 
            // btnHelp
            // 
            btnHelp.BackColor = SystemColors.GradientActiveCaption;
            btnHelp.Location = new Point(12, 16);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(82, 32);
            btnHelp.TabIndex = 13;
            btnHelp.Text = "HELP";
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += btnHelp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 650);
            Controls.Add(btnHelp);
            Controls.Add(btnBrowseDestination);
            Controls.Add(txtBoxDestination);
            Controls.Add(progressBar1);
            Controls.Add(btnBrowseSn);
            Controls.Add(btnBrowseLog);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            HelpButton = true;
            Name = "Form1";
            Text = "LOG Finder";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnBrowseLog;
        private Button btnBrowseSn;
        private ProgressBar progressBar1;
        private TextBox txtBoxDestination;
        private Button btnBrowseDestination;
        private Button btnHelp;
    }
}