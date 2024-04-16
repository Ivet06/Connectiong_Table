namespace ConnectingTables
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
            lblName = new Label();
            lblNameBg = new Label();
            btn = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lblZaglavie = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Lucida Calligraphy", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(78, 124);
            lblName.Name = "lblName";
            lblName.Size = new Size(62, 21);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblNameBg
            // 
            lblNameBg.AutoSize = true;
            lblNameBg.Font = new Font("Lucida Calligraphy", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNameBg.Location = new Point(258, 124);
            lblNameBg.Name = "lblNameBg";
            lblNameBg.Size = new Size(92, 21);
            lblNameBg.TabIndex = 1;
            lblNameBg.Text = "Name BG";
            // 
            // btn
            // 
            btn.Font = new Font("Lucida Calligraphy", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn.Location = new Point(78, 257);
            btn.Name = "btn";
            btn.Size = new Size(242, 72);
            btn.TabIndex = 2;
            btn.Text = "Insert Into rod";
            btn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(43, 148);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(228, 148);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(146, 23);
            textBox2.TabIndex = 4;
            // 
            // lblZaglavie
            // 
            lblZaglavie.AutoSize = true;
            lblZaglavie.Font = new Font("Lucida Calligraphy", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblZaglavie.Location = new Point(43, 40);
            lblZaglavie.Name = "lblZaglavie";
            lblZaglavie.Size = new Size(328, 41);
            lblZaglavie.TabIndex = 5;
            lblZaglavie.Text = "Connecting Table";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 405);
            Controls.Add(lblZaglavie);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btn);
            Controls.Add(lblNameBg);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "ConnectingTable";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblNameBg;
        private Button btn;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblZaglavie;
    }
}
