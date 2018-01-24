namespace First_Windows_Project
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbC = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbN = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.tbS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.rbF = new System.Windows.Forms.RadioButton();
            this.cbCash = new System.Windows.Forms.CheckBox();
            this.cbCard = new System.Windows.Forms.CheckBox();
            this.cbWallet = new System.Windows.Forms.CheckBox();
            this.bt = new System.Windows.Forms.Button();
            this.btE = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Customer Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "City";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "State";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Country";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cbC
            // 
            this.cbC.FormattingEnabled = true;
            this.cbC.Items.AddRange(new object[] {
            "India",
            "Pakistan",
            "Germany",
            "France",
            "Italy",
            "Brazil",
            "Russia",
            "Others"});
            this.cbC.Location = new System.Drawing.Point(110, 159);
            this.cbC.Name = "cbC";
            this.cbC.Size = new System.Drawing.Size(150, 21);
            this.cbC.TabIndex = 5;
            this.cbC.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(315, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(110, 47);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(150, 20);
            this.tbN.TabIndex = 7;
            this.tbN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(110, 84);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(150, 20);
            this.tbC.TabIndex = 8;
            this.tbC.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbS
            // 
            this.tbS.Location = new System.Drawing.Point(110, 120);
            this.tbS.Name = "tbS";
            this.tbS.Size = new System.Drawing.Size(150, 20);
            this.tbS.TabIndex = 9;
            this.tbS.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Gender";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Payment Method";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Location = new System.Drawing.Point(110, 203);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(48, 17);
            this.rbM.TabIndex = 12;
            this.rbM.TabStop = true;
            this.rbM.Text = "Male";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // rbF
            // 
            this.rbF.AutoSize = true;
            this.rbF.Location = new System.Drawing.Point(201, 203);
            this.rbF.Name = "rbF";
            this.rbF.Size = new System.Drawing.Size(59, 17);
            this.rbF.TabIndex = 13;
            this.rbF.TabStop = true;
            this.rbF.Text = "Female";
            this.rbF.UseVisualStyleBackColor = true;
            // 
            // cbCash
            // 
            this.cbCash.AutoSize = true;
            this.cbCash.Location = new System.Drawing.Point(175, 243);
            this.cbCash.Name = "cbCash";
            this.cbCash.Size = new System.Drawing.Size(50, 17);
            this.cbCash.TabIndex = 14;
            this.cbCash.Text = "Cash";
            this.cbCash.UseVisualStyleBackColor = true;
            this.cbCash.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbCard
            // 
            this.cbCard.AutoSize = true;
            this.cbCard.Location = new System.Drawing.Point(254, 243);
            this.cbCard.Name = "cbCard";
            this.cbCard.Size = new System.Drawing.Size(48, 17);
            this.cbCard.TabIndex = 15;
            this.cbCard.Text = "Card";
            this.cbCard.UseVisualStyleBackColor = true;
            this.cbCard.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cbWallet
            // 
            this.cbWallet.AutoSize = true;
            this.cbWallet.Location = new System.Drawing.Point(334, 243);
            this.cbWallet.Name = "cbWallet";
            this.cbWallet.Size = new System.Drawing.Size(56, 17);
            this.cbWallet.TabIndex = 16;
            this.cbWallet.Text = "Wallet";
            this.cbWallet.UseVisualStyleBackColor = true;
            this.cbWallet.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // bt
            // 
            this.bt.Location = new System.Drawing.Point(110, 275);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(75, 23);
            this.bt.TabIndex = 17;
            this.bt.Text = "Register";
            this.bt.UseVisualStyleBackColor = true;
            this.bt.Click += new System.EventHandler(this.bt_Click);
            // 
            // btE
            // 
            this.btE.Location = new System.Drawing.Point(333, 275);
            this.btE.Name = "btE";
            this.btE.Size = new System.Drawing.Size(75, 23);
            this.btE.TabIndex = 18;
            this.btE.Text = "Exit";
            this.btE.UseVisualStyleBackColor = true;
            this.btE.Click += new System.EventHandler(this.btE_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 322);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btE);
            this.Controls.Add(this.bt);
            this.Controls.Add(this.cbWallet);
            this.Controls.Add(this.cbCard);
            this.Controls.Add(this.cbCash);
            this.Controls.Add(this.rbF);
            this.Controls.Add(this.rbM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbS);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Customer Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.TextBox tbS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.RadioButton rbF;
        private System.Windows.Forms.CheckBox cbCash;
        private System.Windows.Forms.CheckBox cbCard;
        private System.Windows.Forms.CheckBox cbWallet;
        private System.Windows.Forms.Button bt;
        private System.Windows.Forms.Button btE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

