namespace Trees
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
            lblNaimenovanie = new Label();
            lblOtdel = new Label();
            lblClass = new Label();
            lblRazred = new Label();
            lblFamily = new Label();
            lblRod = new Label();
            lblType = new Label();
            lblSelected = new Label();
            lblOpisanie = new Label();
            lblAddImage = new Label();
            txtOpisanie = new TextBox();
            comboBoxOtdel = new ComboBox();
            comboBoxClass = new ComboBox();
            comboBoxRazred = new ComboBox();
            comboBoxFamily = new ComboBox();
            comboBoxRod = new ComboBox();
            comboBoxType = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            txtNaimenovanie = new TextBox();
            txtSelected = new TextBox();
            txtAddImage = new TextBox();
            txtLatitude = new TextBox();
            txtLongitude = new TextBox();
            lblLatitude = new Label();
            lblLongitude = new Label();
            pictureBoxImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            SuspendLayout();
            // 
            // lblNaimenovanie
            // 
            lblNaimenovanie.AutoSize = true;
            lblNaimenovanie.Font = new Font("Segoe Script", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            lblNaimenovanie.Location = new Point(26, 9);
            lblNaimenovanie.Name = "lblNaimenovanie";
            lblNaimenovanie.Size = new Size(254, 44);
            lblNaimenovanie.TabIndex = 0;
            lblNaimenovanie.Text = "Наименование: ";
            // 
            // lblOtdel
            // 
            lblOtdel.AutoSize = true;
            lblOtdel.Font = new Font("Segoe Script", 11.25F, FontStyle.Bold);
            lblOtdel.Location = new Point(52, 112);
            lblOtdel.Name = "lblOtdel";
            lblOtdel.Size = new Size(55, 25);
            lblOtdel.TabIndex = 1;
            lblOtdel.Text = "Otdel";
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Font = new Font("Segoe Script", 11.25F, FontStyle.Bold);
            lblClass.Location = new Point(52, 178);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(52, 25);
            lblClass.TabIndex = 2;
            lblClass.Text = "Class";
            // 
            // lblRazred
            // 
            lblRazred.AutoSize = true;
            lblRazred.Font = new Font("Segoe Script", 11.25F, FontStyle.Bold);
            lblRazred.Location = new Point(41, 248);
            lblRazred.Name = "lblRazred";
            lblRazred.Size = new Size(70, 25);
            lblRazred.TabIndex = 3;
            lblRazred.Text = "Razred";
            // 
            // lblFamily
            // 
            lblFamily.AutoSize = true;
            lblFamily.Font = new Font("Segoe Script", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblFamily.Location = new Point(198, 112);
            lblFamily.Name = "lblFamily";
            lblFamily.Size = new Size(67, 25);
            lblFamily.TabIndex = 4;
            lblFamily.Text = "Family";
            // 
            // lblRod
            // 
            lblRod.AutoSize = true;
            lblRod.Font = new Font("Segoe Script", 11.25F, FontStyle.Bold);
            lblRod.Location = new Point(220, 178);
            lblRod.Name = "lblRod";
            lblRod.Size = new Size(45, 25);
            lblRod.TabIndex = 5;
            lblRod.Text = "Rod";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe Script", 11.25F, FontStyle.Bold);
            lblType.Location = new Point(215, 248);
            lblType.Name = "lblType";
            lblType.Size = new Size(50, 25);
            lblType.TabIndex = 6;
            lblType.Text = "Type";
            // 
            // lblSelected
            // 
            lblSelected.AutoSize = true;
            lblSelected.Font = new Font("Segoe Script", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 204);
            lblSelected.Location = new Point(323, 26);
            lblSelected.Name = "lblSelected";
            lblSelected.Size = new Size(85, 20);
            lblSelected.TabIndex = 7;
            lblSelected.Text = "Selected ID";
            // 
            // lblOpisanie
            // 
            lblOpisanie.AutoSize = true;
            lblOpisanie.Font = new Font("Segoe Script", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 204);
            lblOpisanie.Location = new Point(472, 26);
            lblOpisanie.Name = "lblOpisanie";
            lblOpisanie.Size = new Size(194, 20);
            lblOpisanie.TabIndex = 8;
            lblOpisanie.Text = "Описание (информация)";
            // 
            // lblAddImage
            // 
            lblAddImage.AutoSize = true;
            lblAddImage.Font = new Font("Segoe Script", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 204);
            lblAddImage.Location = new Point(41, 381);
            lblAddImage.Name = "lblAddImage";
            lblAddImage.Size = new Size(117, 20);
            lblAddImage.TabIndex = 9;
            lblAddImage.Text = "Add Image URL";
            // 
            // txtOpisanie
            // 
            txtOpisanie.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtOpisanie.Location = new Point(497, 52);
            txtOpisanie.Multiline = true;
            txtOpisanie.Name = "txtOpisanie";
            txtOpisanie.ScrollBars = ScrollBars.Both;
            txtOpisanie.Size = new Size(155, 267);
            txtOpisanie.TabIndex = 10;
            // 
            // comboBoxOtdel
            // 
            comboBoxOtdel.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxOtdel.FormattingEnabled = true;
            comboBoxOtdel.Location = new Point(16, 136);
            comboBoxOtdel.Name = "comboBoxOtdel";
            comboBoxOtdel.Size = new Size(121, 27);
            comboBoxOtdel.TabIndex = 11;
            // 
            // comboBoxClass
            // 
            comboBoxClass.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Location = new Point(16, 206);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(121, 27);
            comboBoxClass.TabIndex = 12;
            // 
            // comboBoxRazred
            // 
            comboBoxRazred.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxRazred.FormattingEnabled = true;
            comboBoxRazred.Location = new Point(16, 276);
            comboBoxRazred.Name = "comboBoxRazred";
            comboBoxRazred.Size = new Size(121, 27);
            comboBoxRazred.TabIndex = 13;
            // 
            // comboBoxFamily
            // 
            comboBoxFamily.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxFamily.FormattingEnabled = true;
            comboBoxFamily.Location = new Point(179, 136);
            comboBoxFamily.Name = "comboBoxFamily";
            comboBoxFamily.Size = new Size(121, 27);
            comboBoxFamily.TabIndex = 14;
            // 
            // comboBoxRod
            // 
            comboBoxRod.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxRod.FormattingEnabled = true;
            comboBoxRod.Location = new Point(179, 206);
            comboBoxRod.Name = "comboBoxRod";
            comboBoxRod.Size = new Size(121, 27);
            comboBoxRod.TabIndex = 15;
            // 
            // comboBoxType
            // 
            comboBoxType.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(179, 276);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(121, 27);
            comboBoxType.TabIndex = 16;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAdd.ForeColor = Color.Navy;
            btnAdd.Location = new Point(323, 136);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(145, 38);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "ADD new TREE";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.White;
            btnUpdate.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnUpdate.ForeColor = Color.Red;
            btnUpdate.Location = new Point(323, 206);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(145, 46);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "UPDATE selected\r\nTREE";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // txtNaimenovanie
            // 
            txtNaimenovanie.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtNaimenovanie.Location = new Point(41, 52);
            txtNaimenovanie.Name = "txtNaimenovanie";
            txtNaimenovanie.Size = new Size(212, 27);
            txtNaimenovanie.TabIndex = 19;
            // 
            // txtSelected
            // 
            txtSelected.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtSelected.Location = new Point(323, 52);
            txtSelected.Name = "txtSelected";
            txtSelected.Size = new Size(85, 27);
            txtSelected.TabIndex = 20;
            txtSelected.Visible = false;
            // 
            // txtAddImage
            // 
            txtAddImage.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtAddImage.Location = new Point(16, 404);
            txtAddImage.Name = "txtAddImage";
            txtAddImage.Size = new Size(157, 27);
            txtAddImage.TabIndex = 22;
            // 
            // txtLatitude
            // 
            txtLatitude.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtLatitude.Location = new Point(534, 366);
            txtLatitude.Name = "txtLatitude";
            txtLatitude.Size = new Size(98, 27);
            txtLatitude.TabIndex = 23;
            txtLatitude.Visible = false;
            // 
            // txtLongitude
            // 
            txtLongitude.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtLongitude.Location = new Point(534, 449);
            txtLongitude.Name = "txtLongitude";
            txtLongitude.Size = new Size(98, 27);
            txtLongitude.TabIndex = 24;
            txtLongitude.Visible = false;
            // 
            // lblLatitude
            // 
            lblLatitude.AutoSize = true;
            lblLatitude.Font = new Font("Segoe Script", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 204);
            lblLatitude.Location = new Point(543, 344);
            lblLatitude.Name = "lblLatitude";
            lblLatitude.Size = new Size(71, 20);
            lblLatitude.TabIndex = 25;
            lblLatitude.Text = "Latitude";
            // 
            // lblLongitude
            // 
            lblLongitude.AutoSize = true;
            lblLongitude.Font = new Font("Segoe Script", 9F, FontStyle.Underline, GraphicsUnit.Point, 204);
            lblLongitude.Location = new Point(543, 427);
            lblLongitude.Name = "lblLongitude";
            lblLongitude.Size = new Size(74, 19);
            lblLongitude.TabIndex = 26;
            lblLongitude.Text = "Longitude";
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.Image = (Image)resources.GetObject("pictureBoxImage.Image");
            pictureBoxImage.Location = new Point(188, 326);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(299, 171);
            pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImage.TabIndex = 21;
            pictureBoxImage.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(717, 509);
            Controls.Add(lblLongitude);
            Controls.Add(lblLatitude);
            Controls.Add(txtLongitude);
            Controls.Add(txtLatitude);
            Controls.Add(txtAddImage);
            Controls.Add(pictureBoxImage);
            Controls.Add(txtSelected);
            Controls.Add(txtNaimenovanie);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(comboBoxType);
            Controls.Add(comboBoxRod);
            Controls.Add(comboBoxFamily);
            Controls.Add(comboBoxRazred);
            Controls.Add(comboBoxClass);
            Controls.Add(comboBoxOtdel);
            Controls.Add(txtOpisanie);
            Controls.Add(lblAddImage);
            Controls.Add(lblOpisanie);
            Controls.Add(lblSelected);
            Controls.Add(lblType);
            Controls.Add(lblRod);
            Controls.Add(lblFamily);
            Controls.Add(lblRazred);
            Controls.Add(lblClass);
            Controls.Add(lblOtdel);
            Controls.Add(lblNaimenovanie);
            Name = "Form1";
            Text = "Trees";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNaimenovanie;
        private Label lblOtdel;
        private Label lblClass;
        private Label lblRazred;
        private Label lblFamily;
        private Label lblRod;
        private Label lblType;
        private Label lblSelected;
        private Label lblOpisanie;
        private Label lblAddImage;
        private TextBox txtOpisanie;
        private ComboBox comboBoxOtdel;
        private ComboBox comboBoxClass;
        private ComboBox comboBoxRazred;
        private ComboBox comboBoxFamily;
        private ComboBox comboBoxRod;
        private ComboBox comboBoxType;
        private Button btnAdd;
        private Button btnUpdate;
        private TextBox txtNaimenovanie;
        private TextBox txtSelected;
        private TextBox txtAddImage;
        private TextBox txtLatitude;
        private TextBox txtLongitude;
        private Label lblLatitude;
        private Label lblLongitude;
        private PictureBox pictureBoxImage;
    }
}
