namespace sinemaotomasyonu
{
    partial class formbiletal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formbiletal));
            adsoyad = new GroupBox();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            maskedTextBox1 = new MaskedTextBox();
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            groupBox3 = new GroupBox();
            comboBox2 = new ComboBox();
            BTNX = new Button();
            panel1 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            adsoyad.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // adsoyad
            // 
            adsoyad.Controls.Add(textBox1);
            adsoyad.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            adsoyad.Location = new Point(10, 9);
            adsoyad.Margin = new Padding(3, 2, 3, 2);
            adsoyad.Name = "adsoyad";
            adsoyad.Padding = new Padding(3, 2, 3, 2);
            adsoyad.Size = new Size(248, 54);
            adsoyad.TabIndex = 0;
            adsoyad.TabStop = false;
            adsoyad.Text = "Ad Soyad:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(5, 20);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(10, 80);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(248, 52);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Telefon No:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(5, 20);
            maskedTextBox1.Margin = new Padding(3, 2, 3, 2);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(227, 27);
            maskedTextBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(10, 149);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(248, 66);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Film Seçimi:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Shrek", "Dağ 2", "La La Land", "Interstellar" });
            comboBox1.Location = new Point(5, 26);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(227, 27);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox3.Location = new Point(10, 238);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(248, 58);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Seans Seçimi:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Seans 1 - 13:00", "Seans 2 - 15:00", "Seans 3 -17:00" });
            comboBox2.Location = new Point(5, 26);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(227, 27);
            comboBox2.TabIndex = 0;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // BTNX
            // 
            BTNX.Location = new Point(1004, 9);
            BTNX.Margin = new Padding(3, 2, 3, 2);
            BTNX.Name = "BTNX";
            BTNX.Size = new Size(37, 29);
            BTNX.TabIndex = 4;
            BTNX.Text = "X";
            BTNX.UseVisualStyleBackColor = true;
            BTNX.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.Location = new Point(329, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(654, 286);
            panel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(895, 446);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(105, 50);
            button1.TabIndex = 7;
            button1.Text = "Ödeme Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 36);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 115);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(25, 8);
            label1.Name = "label1";
            label1.Size = new Size(61, 22);
            label1.TabIndex = 2;
            label1.Text = "BÜFE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(215, 36);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            label2.Click += label2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(192, 74);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(100, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Patlamış mısır";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(192, 96);
            checkBox2.Margin = new Padding(3, 2, 3, 2);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(49, 19);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "Kola";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(192, 118);
            checkBox3.Margin = new Padding(3, 2, 3, 2);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(39, 19);
            checkBox3.TabIndex = 6;
            checkBox3.Text = "Su";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(215, 44);
            label3.Name = "label3";
            label3.Size = new Size(72, 19);
            label3.TabIndex = 7;
            label3.Text = "ÜRÜNLER";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(361, 44);
            label4.Name = "label4";
            label4.Size = new Size(68, 19);
            label4.TabIndex = 8;
            label4.Text = "FİYATLAR";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(367, 74);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 9;
            label5.Text = "75 TL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(367, 97);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 10;
            label6.Text = "45 TL";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(367, 122);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 11;
            label7.Text = "25 TL";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MintCream;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(checkBox3);
            panel2.Controls.Add(checkBox2);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(16, 325);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(452, 172);
            panel2.TabIndex = 6;
            panel2.Paint += panel2_Paint;
            // 
            // formbiletal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(1051, 529);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(BTNX);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(adsoyad);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "formbiletal";
            Text = "formbiletal";
            Load += formbiletal_Load;
            adsoyad.ResumeLayout(false);
            adsoyad.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox adsoyad;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private MaskedTextBox maskedTextBox1;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private GroupBox groupBox3;
        private ComboBox comboBox2;
        private Button BTNX;
        private Panel panel1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel2;
    }
}