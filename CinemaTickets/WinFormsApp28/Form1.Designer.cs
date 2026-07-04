namespace WinFormsApp28
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
            textNom = new TextBox();
            label2 = new Label();
            textCF = new TextBox();
            label6 = new Label();
            numericQuantite = new NumericUpDown();
            TotalBtn = new Button();
            buttonRecap = new Button();
            groupBox1 = new GroupBox();
            LabelRecap9 = new Label();
            label9 = new Label();
            LabelTotal = new Label();
            label7 = new Label();
            groupBox2 = new GroupBox();
            label3 = new Label();
            radioDrama = new RadioButton();
            radioAnimation = new RadioButton();
            radioAction = new RadioButton();
            groupBox3 = new GroupBox();
            radioVIP = new RadioButton();
            radioIMAX = new RadioButton();
            radioStandard = new RadioButton();
            label4 = new Label();
            groupBox4 = new GroupBox();
            checkChocolah = new CheckBox();
            checkBoisson = new CheckBox();
            label5 = new Label();
            checkPopCorn = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numericQuantite).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.LavenderBlush;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 0;
            label1.Text = "Nom du client";
            // 
            // textNom
            // 
            textNom.BackColor = Color.FromArgb(255, 192, 255);
            textNom.BorderStyle = BorderStyle.FixedSingle;
            textNom.Location = new Point(185, 23);
            textNom.Name = "textNom";
            textNom.Size = new Size(214, 32);
            textNom.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(156, 25);
            label2.TabIndex = 2;
            label2.Text = "Numero de CF";
            // 
            // textCF
            // 
            textCF.BackColor = Color.FromArgb(255, 192, 255);
            textCF.BorderStyle = BorderStyle.FixedSingle;
            textCF.Location = new Point(185, 80);
            textCF.Name = "textCF";
            textCF.Size = new Size(214, 32);
            textCF.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.MediumVioletRed;
            label6.Location = new Point(524, 227);
            label6.Name = "label6";
            label6.Size = new Size(108, 25);
            label6.TabIndex = 16;
            label6.Text = "Quantite";
            // 
            // numericQuantite
            // 
            numericQuantite.BackColor = Color.FromArgb(255, 192, 255);
            numericQuantite.BorderStyle = BorderStyle.FixedSingle;
            numericQuantite.Location = new Point(644, 225);
            numericQuantite.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericQuantite.Name = "numericQuantite";
            numericQuantite.Size = new Size(143, 32);
            numericQuantite.TabIndex = 17;
            numericQuantite.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // TotalBtn
            // 
            TotalBtn.BackColor = Color.FromArgb(255, 192, 255);
            TotalBtn.FlatStyle = FlatStyle.Popup;
            TotalBtn.ForeColor = Color.MediumVioletRed;
            TotalBtn.Location = new Point(577, 279);
            TotalBtn.Name = "TotalBtn";
            TotalBtn.Size = new Size(184, 34);
            TotalBtn.TabIndex = 18;
            TotalBtn.Text = "TOTAL";
            TotalBtn.UseVisualStyleBackColor = false;
            TotalBtn.Click += TotalBtn_Click;
            // 
            // buttonRecap
            // 
            buttonRecap.BackColor = Color.FromArgb(255, 192, 255);
            buttonRecap.FlatStyle = FlatStyle.Popup;
            buttonRecap.ForeColor = Color.MediumVioletRed;
            buttonRecap.Location = new Point(577, 347);
            buttonRecap.Name = "buttonRecap";
            buttonRecap.Size = new Size(184, 34);
            buttonRecap.TabIndex = 19;
            buttonRecap.Text = "RECAPITULATIF";
            buttonRecap.UseVisualStyleBackColor = false;
            buttonRecap.Click += buttonRecap_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Pink;
            groupBox1.Controls.Add(LabelRecap9);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(LabelTotal);
            groupBox1.Controls.Add(label7);
            groupBox1.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.MediumVioletRed;
            groupBox1.Location = new Point(432, 397);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(471, 335);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resultat";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // LabelRecap9
            // 
            LabelRecap9.AutoSize = true;
            LabelRecap9.Location = new Point(31, 116);
            LabelRecap9.Name = "LabelRecap9";
            LabelRecap9.Size = new Size(0, 25);
            LabelRecap9.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 91);
            label9.Name = "label9";
            label9.Size = new Size(169, 25);
            label9.TabIndex = 2;
            label9.Text = "Recapitulatif :";
            // 
            // LabelTotal
            // 
            LabelTotal.AutoSize = true;
            LabelTotal.Location = new Point(164, 47);
            LabelTotal.Name = "LabelTotal";
            LabelTotal.Size = new Size(47, 25);
            LabelTotal.TabIndex = 1;
            LabelTotal.Text = ". . .";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 45);
            label7.Name = "label7";
            label7.Size = new Size(136, 25);
            label7.TabIndex = 0;
            label7.Text = "Prix Total :";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Plum;
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(radioDrama);
            groupBox2.Controls.Add(radioAnimation);
            groupBox2.Controls.Add(radioAction);
            groupBox2.Location = new Point(30, 149);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(385, 205);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MediumVioletRed;
            label3.Location = new Point(6, 28);
            label3.Name = "label3";
            label3.Size = new Size(324, 25);
            label3.TabIndex = 12;
            label3.Text = "Choix du Film(Prix de base)";
            // 
            // radioDrama
            // 
            radioDrama.AutoSize = true;
            radioDrama.Location = new Point(22, 159);
            radioDrama.Name = "radioDrama";
            radioDrama.Size = new Size(335, 29);
            radioDrama.TabIndex = 11;
            radioDrama.TabStop = true;
            radioDrama.Text = "Documentaire/Drame(35 DH)";
            radioDrama.UseVisualStyleBackColor = true;
            // 
            // radioAnimation
            // 
            radioAnimation.AutoSize = true;
            radioAnimation.Location = new Point(22, 114);
            radioAnimation.Name = "radioAnimation";
            radioAnimation.Size = new Size(296, 29);
            radioAnimation.TabIndex = 10;
            radioAnimation.TabStop = true;
            radioAnimation.Text = "Animation/Enfant(40 DH)";
            radioAnimation.UseVisualStyleBackColor = true;
            // 
            // radioAction
            // 
            radioAction.AutoSize = true;
            radioAction.Location = new Point(22, 69);
            radioAction.Name = "radioAction";
            radioAction.Size = new Size(308, 29);
            radioAction.TabIndex = 9;
            radioAction.TabStop = true;
            radioAction.Text = "Action/Blockbuster(60 DH)";
            radioAction.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Violet;
            groupBox3.Controls.Add(radioVIP);
            groupBox3.Controls.Add(radioIMAX);
            groupBox3.Controls.Add(radioStandard);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(30, 382);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(385, 196);
            groupBox3.TabIndex = 22;
            groupBox3.TabStop = false;
            // 
            // radioVIP
            // 
            radioVIP.AutoSize = true;
            radioVIP.Location = new Point(26, 149);
            radioVIP.Name = "radioVIP";
            radioVIP.Size = new Size(349, 29);
            radioVIP.TabIndex = 15;
            radioVIP.TabStop = true;
            radioVIP.Text = "VIP(Sieges Premium)(+45 DH)";
            radioVIP.UseVisualStyleBackColor = true;
            // 
            // radioIMAX
            // 
            radioIMAX.AutoSize = true;
            radioIMAX.Location = new Point(26, 104);
            radioIMAX.Name = "radioIMAX";
            radioIMAX.Size = new Size(224, 29);
            radioIMAX.TabIndex = 14;
            radioIMAX.TabStop = true;
            radioIMAX.Text = "3D/IMAX(+20 DH)";
            radioIMAX.UseVisualStyleBackColor = true;
            // 
            // radioStandard
            // 
            radioStandard.AutoSize = true;
            radioStandard.Location = new Point(26, 64);
            radioStandard.Name = "radioStandard";
            radioStandard.Size = new Size(213, 29);
            radioStandard.TabIndex = 13;
            radioStandard.TabStop = true;
            radioStandard.Text = "Standard(+0 DH)";
            radioStandard.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MediumVioletRed;
            label4.Location = new Point(10, 23);
            label4.Name = "label4";
            label4.Size = new Size(161, 25);
            label4.TabIndex = 12;
            label4.Text = "Type de Salle";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Orchid;
            groupBox4.Controls.Add(checkChocolah);
            groupBox4.Controls.Add(checkBoisson);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(checkPopCorn);
            groupBox4.Location = new Point(502, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(300, 205);
            groupBox4.TabIndex = 23;
            groupBox4.TabStop = false;
            // 
            // checkChocolah
            // 
            checkChocolah.AutoSize = true;
            checkChocolah.Location = new Point(44, 141);
            checkChocolah.Name = "checkChocolah";
            checkChocolah.Size = new Size(206, 29);
            checkChocolah.TabIndex = 19;
            checkChocolah.Text = "Chocolat(10 DH)";
            checkChocolah.UseVisualStyleBackColor = true;
            // 
            // checkBoisson
            // 
            checkBoisson.AutoSize = true;
            checkBoisson.Location = new Point(44, 106);
            checkBoisson.Name = "checkBoisson";
            checkBoisson.Size = new Size(196, 29);
            checkBoisson.TabIndex = 18;
            checkBoisson.Text = "Boisson(15 DH)";
            checkBoisson.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.MediumVioletRed;
            label5.Location = new Point(22, 34);
            label5.Name = "label5";
            label5.Size = new Size(257, 25);
            label5.TabIndex = 17;
            label5.Text = "Supplements(Snacks)";
            // 
            // checkPopCorn
            // 
            checkPopCorn.AutoSize = true;
            checkPopCorn.Location = new Point(44, 71);
            checkPopCorn.Name = "checkPopCorn";
            checkPopCorn.Size = new Size(215, 29);
            checkPopCorn.TabIndex = 16;
            checkPopCorn.Text = "Pop-corn (25 DH)";
            checkPopCorn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.HotPink;
            ClientSize = new Size(915, 744);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(buttonRecap);
            Controls.Add(TotalBtn);
            Controls.Add(numericQuantite);
            Controls.Add(label6);
            Controls.Add(textCF);
            Controls.Add(label2);
            Controls.Add(textNom);
            Controls.Add(label1);
            Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.LavenderBlush;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericQuantite).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textNom;
        private Label label2;
        private TextBox textCF;
        private Label label6;
        private NumericUpDown numericQuantite;
        private Button TotalBtn;
        private Button buttonRecap;
        private GroupBox groupBox1;
        private Label label9;
        private Label LabelTotal;
        private Label label7;
        private Label LabelRecap9;
        private GroupBox groupBox2;
        private Label label3;
        private RadioButton radioDrama;
        private RadioButton radioAnimation;
        private RadioButton radioAction;
        private GroupBox groupBox3;
        private RadioButton radioVIP;
        private RadioButton radioIMAX;
        private RadioButton radioStandard;
        private Label label4;
        private GroupBox groupBox4;
        private CheckBox checkChocolah;
        private CheckBox checkBoisson;
        private Label label5;
        private CheckBox checkPopCorn;
    }
}
