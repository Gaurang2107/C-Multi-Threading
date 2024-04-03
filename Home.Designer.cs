namespace lab_8_c_
{
    partial class Home
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
            txtNumber = new TextBox();
            btnGenerate = new Button();
            lbFibonacci = new ListBox();
            SuspendLayout();
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(168, 73);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(125, 27);
            txtNumber.TabIndex = 0;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(299, 73);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(94, 29);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // lbFibonacci
            // 
            lbFibonacci.FormattingEnabled = true;
            lbFibonacci.Location = new Point(168, 118);
            lbFibonacci.Name = "lbFibonacci";
            lbFibonacci.ScrollAlwaysVisible = true;
            lbFibonacci.Size = new Size(225, 224);
            lbFibonacci.TabIndex = 2;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbFibonacci);
            Controls.Add(btnGenerate);
            Controls.Add(txtNumber);
            Name = "Home";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumber;
        private Button btnGenerate;
        private ListBox lbFibonacci;
    }
}
