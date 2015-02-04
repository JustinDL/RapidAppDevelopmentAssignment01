namespace Assignment01
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
            this.LeftGroupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Mem128GB = new System.Windows.Forms.RadioButton();
            this.Mem64GB = new System.Windows.Forms.RadioButton();
            this.Mem16GB = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.colourGold = new System.Windows.Forms.RadioButton();
            this.colourSilver = new System.Windows.Forms.RadioButton();
            this.colourBlack = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Model5Select = new System.Windows.Forms.RadioButton();
            this.Model6Select = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ScreenProtectCheck = new System.Windows.Forms.CheckBox();
            this.LeatherCaseCheck = new System.Windows.Forms.CheckBox();
            this.ProtectionPlanCheck = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalBox = new System.Windows.Forms.TextBox();
            this.TradeInBox = new System.Windows.Forms.TextBox();
            this.TaxBox = new System.Windows.Forms.TextBox();
            this.SubtotalBox = new System.Windows.Forms.TextBox();
            this.AccPriceBox = new System.Windows.Forms.TextBox();
            this.BasePriceBox = new System.Windows.Forms.TextBox();
            this.CalcButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.LeftGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftGroupBox
            // 
            this.LeftGroupBox.Controls.Add(this.pictureBox1);
            this.LeftGroupBox.Controls.Add(this.groupBox3);
            this.LeftGroupBox.Controls.Add(this.groupBox2);
            this.LeftGroupBox.Controls.Add(this.groupBox1);
            this.LeftGroupBox.Location = new System.Drawing.Point(12, 12);
            this.LeftGroupBox.Name = "LeftGroupBox";
            this.LeftGroupBox.Size = new System.Drawing.Size(419, 435);
            this.LeftGroupBox.TabIndex = 0;
            this.LeftGroupBox.TabStop = false;
            this.LeftGroupBox.Text = "IPhone Selection";
            this.LeftGroupBox.Enter += new System.EventHandler(this.LeftGroupBox_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(229, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Mem128GB);
            this.groupBox3.Controls.Add(this.Mem64GB);
            this.groupBox3.Controls.Add(this.Mem16GB);
            this.groupBox3.Location = new System.Drawing.Point(22, 292);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 129);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Memory";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // Mem128GB
            // 
            this.Mem128GB.AutoSize = true;
            this.Mem128GB.Location = new System.Drawing.Point(7, 87);
            this.Mem128GB.Name = "Mem128GB";
            this.Mem128GB.Size = new System.Drawing.Size(85, 24);
            this.Mem128GB.TabIndex = 2;
            this.Mem128GB.TabStop = true;
            this.Mem128GB.Text = "128GB";
            this.Mem128GB.UseVisualStyleBackColor = true;
            this.Mem128GB.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // Mem64GB
            // 
            this.Mem64GB.AutoSize = true;
            this.Mem64GB.Location = new System.Drawing.Point(7, 57);
            this.Mem64GB.Name = "Mem64GB";
            this.Mem64GB.Size = new System.Drawing.Size(76, 24);
            this.Mem64GB.TabIndex = 1;
            this.Mem64GB.TabStop = true;
            this.Mem64GB.Text = "64GB";
            this.Mem64GB.UseVisualStyleBackColor = true;
            this.Mem64GB.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // Mem16GB
            // 
            this.Mem16GB.AutoSize = true;
            this.Mem16GB.Location = new System.Drawing.Point(6, 25);
            this.Mem16GB.Name = "Mem16GB";
            this.Mem16GB.Size = new System.Drawing.Size(76, 24);
            this.Mem16GB.TabIndex = 0;
            this.Mem16GB.TabStop = true;
            this.Mem16GB.Text = "16GB";
            this.Mem16GB.UseVisualStyleBackColor = true;
            this.Mem16GB.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.colourGold);
            this.groupBox2.Controls.Add(this.colourSilver);
            this.groupBox2.Controls.Add(this.colourBlack);
            this.groupBox2.Location = new System.Drawing.Point(22, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 137);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colour";
            // 
            // colourGold
            // 
            this.colourGold.AutoSize = true;
            this.colourGold.Location = new System.Drawing.Point(6, 92);
            this.colourGold.Name = "colourGold";
            this.colourGold.Size = new System.Drawing.Size(68, 24);
            this.colourGold.TabIndex = 2;
            this.colourGold.TabStop = true;
            this.colourGold.Text = "Gold";
            this.colourGold.UseVisualStyleBackColor = true;
            this.colourGold.CheckedChanged += new System.EventHandler(this.colourGold_CheckedChanged);
            // 
            // colourSilver
            // 
            this.colourSilver.AutoSize = true;
            this.colourSilver.Location = new System.Drawing.Point(6, 62);
            this.colourSilver.Name = "colourSilver";
            this.colourSilver.Size = new System.Drawing.Size(72, 24);
            this.colourSilver.TabIndex = 1;
            this.colourSilver.TabStop = true;
            this.colourSilver.Text = "Silver";
            this.colourSilver.UseVisualStyleBackColor = true;
            this.colourSilver.CheckedChanged += new System.EventHandler(this.colourSilver_CheckedChanged);
            // 
            // colourBlack
            // 
            this.colourBlack.AutoSize = true;
            this.colourBlack.Location = new System.Drawing.Point(6, 32);
            this.colourBlack.Name = "colourBlack";
            this.colourBlack.Size = new System.Drawing.Size(73, 24);
            this.colourBlack.TabIndex = 0;
            this.colourBlack.TabStop = true;
            this.colourBlack.Text = "Black";
            this.colourBlack.UseVisualStyleBackColor = true;
            this.colourBlack.CheckedChanged += new System.EventHandler(this.colourBlack_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Model5Select);
            this.groupBox1.Controls.Add(this.Model6Select);
            this.groupBox1.Location = new System.Drawing.Point(22, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Model";
            // 
            // Model5Select
            // 
            this.Model5Select.AutoSize = true;
            this.Model5Select.Location = new System.Drawing.Point(6, 57);
            this.Model5Select.Name = "Model5Select";
            this.Model5Select.Size = new System.Drawing.Size(106, 24);
            this.Model5Select.TabIndex = 4;
            this.Model5Select.TabStop = true;
            this.Model5Select.Text = "IPhone 5s";
            this.Model5Select.UseVisualStyleBackColor = true;
            this.Model5Select.CheckedChanged += new System.EventHandler(this.Model5Select_CheckedChanged_1);
            // 
            // Model6Select
            // 
            this.Model6Select.AutoSize = true;
            this.Model6Select.Location = new System.Drawing.Point(6, 25);
            this.Model6Select.Name = "Model6Select";
            this.Model6Select.Size = new System.Drawing.Size(98, 24);
            this.Model6Select.TabIndex = 2;
            this.Model6Select.TabStop = true;
            this.Model6Select.Text = "IPhone 6";
            this.Model6Select.UseVisualStyleBackColor = true;
            this.Model6Select.CheckedChanged += new System.EventHandler(this.Model6Select_CheckedChanged_1);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ScreenProtectCheck);
            this.groupBox4.Controls.Add(this.LeatherCaseCheck);
            this.groupBox4.Controls.Add(this.ProtectionPlanCheck);
            this.groupBox4.Location = new System.Drawing.Point(438, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(282, 123);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Accessories";
            // 
            // ScreenProtectCheck
            // 
            this.ScreenProtectCheck.AutoSize = true;
            this.ScreenProtectCheck.Location = new System.Drawing.Point(7, 88);
            this.ScreenProtectCheck.Name = "ScreenProtectCheck";
            this.ScreenProtectCheck.Size = new System.Drawing.Size(155, 24);
            this.ScreenProtectCheck.TabIndex = 2;
            this.ScreenProtectCheck.Text = "Screen Protector";
            this.ScreenProtectCheck.UseVisualStyleBackColor = true;
            this.ScreenProtectCheck.CheckedChanged += new System.EventHandler(this.ScreenProtectCheck_CheckedChanged);
            // 
            // LeatherCaseCheck
            // 
            this.LeatherCaseCheck.AutoSize = true;
            this.LeatherCaseCheck.Location = new System.Drawing.Point(7, 57);
            this.LeatherCaseCheck.Name = "LeatherCaseCheck";
            this.LeatherCaseCheck.Size = new System.Drawing.Size(131, 24);
            this.LeatherCaseCheck.TabIndex = 1;
            this.LeatherCaseCheck.Text = "Leather Case";
            this.LeatherCaseCheck.UseVisualStyleBackColor = true;
            this.LeatherCaseCheck.CheckedChanged += new System.EventHandler(this.LeatherCaseCheck_CheckedChanged);
            // 
            // ProtectionPlanCheck
            // 
            this.ProtectionPlanCheck.AutoSize = true;
            this.ProtectionPlanCheck.Location = new System.Drawing.Point(7, 26);
            this.ProtectionPlanCheck.Name = "ProtectionPlanCheck";
            this.ProtectionPlanCheck.Size = new System.Drawing.Size(225, 24);
            this.ProtectionPlanCheck.TabIndex = 0;
            this.ProtectionPlanCheck.Text = "Apple Care Protection Plan";
            this.ProtectionPlanCheck.UseVisualStyleBackColor = true;
            this.ProtectionPlanCheck.CheckedChanged += new System.EventHandler(this.ProtectionPlanCheck_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.TotalBox);
            this.groupBox5.Controls.Add(this.TradeInBox);
            this.groupBox5.Controls.Add(this.TaxBox);
            this.groupBox5.Controls.Add(this.SubtotalBox);
            this.groupBox5.Controls.Add(this.AccPriceBox);
            this.groupBox5.Controls.Add(this.BasePriceBox);
            this.groupBox5.Location = new System.Drawing.Point(438, 142);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(282, 258);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "(Less) Trade In:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tax:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Subtotal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Accessories:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Base Price:";
            // 
            // TotalBox
            // 
            this.TotalBox.Enabled = false;
            this.TotalBox.Location = new System.Drawing.Point(176, 217);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.Size = new System.Drawing.Size(100, 26);
            this.TotalBox.TabIndex = 5;
            this.TotalBox.Text = "0.00";
            this.TotalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TotalBox.TextChanged += new System.EventHandler(this.TotalBox_TextChanged);
            // 
            // TradeInBox
            // 
            this.TradeInBox.Location = new System.Drawing.Point(176, 169);
            this.TradeInBox.Name = "TradeInBox";
            this.TradeInBox.Size = new System.Drawing.Size(100, 26);
            this.TradeInBox.TabIndex = 4;
            this.TradeInBox.Text = "0.00";
            this.TradeInBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TradeInBox.TextChanged += new System.EventHandler(this.TradeInBox_TextChanged);
            // 
            // TaxBox
            // 
            this.TaxBox.Enabled = false;
            this.TaxBox.Location = new System.Drawing.Point(176, 137);
            this.TaxBox.Name = "TaxBox";
            this.TaxBox.Size = new System.Drawing.Size(100, 26);
            this.TaxBox.TabIndex = 3;
            this.TaxBox.Text = "0.00";
            this.TaxBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TaxBox.TextChanged += new System.EventHandler(this.TaxBox_TextChanged);
            // 
            // SubtotalBox
            // 
            this.SubtotalBox.Enabled = false;
            this.SubtotalBox.Location = new System.Drawing.Point(176, 105);
            this.SubtotalBox.Name = "SubtotalBox";
            this.SubtotalBox.Size = new System.Drawing.Size(100, 26);
            this.SubtotalBox.TabIndex = 2;
            this.SubtotalBox.Text = "0.00";
            this.SubtotalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SubtotalBox.TextChanged += new System.EventHandler(this.SubtotalBox_TextChanged);
            // 
            // AccPriceBox
            // 
            this.AccPriceBox.Enabled = false;
            this.AccPriceBox.Location = new System.Drawing.Point(176, 59);
            this.AccPriceBox.Name = "AccPriceBox";
            this.AccPriceBox.Size = new System.Drawing.Size(100, 26);
            this.AccPriceBox.TabIndex = 1;
            this.AccPriceBox.Text = "0.00";
            this.AccPriceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AccPriceBox.TextChanged += new System.EventHandler(this.AccPriceBox_TextChanged);
            // 
            // BasePriceBox
            // 
            this.BasePriceBox.Enabled = false;
            this.BasePriceBox.Location = new System.Drawing.Point(176, 26);
            this.BasePriceBox.Name = "BasePriceBox";
            this.BasePriceBox.Size = new System.Drawing.Size(100, 26);
            this.BasePriceBox.TabIndex = 0;
            this.BasePriceBox.Text = "0.00";
            this.BasePriceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BasePriceBox.TextChanged += new System.EventHandler(this.BasePriceBox_TextChanged);
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(455, 406);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(92, 40);
            this.CalcButton.TabIndex = 3;
            this.CalcButton.Text = "&Calculate";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Location = new System.Drawing.Point(553, 405);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(80, 42);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(639, 405);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(81, 41);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.CalcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearButton;
            this.ClientSize = new System.Drawing.Size(732, 466);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.LeftGroupBox);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Justin Lucas IPhone Selection Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LeftGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LeftGroupBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox ScreenProtectCheck;
        private System.Windows.Forms.CheckBox LeatherCaseCheck;
        private System.Windows.Forms.CheckBox ProtectionPlanCheck;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TotalBox;
        private System.Windows.Forms.TextBox TradeInBox;
        private System.Windows.Forms.TextBox TaxBox;
        private System.Windows.Forms.TextBox SubtotalBox;
        private System.Windows.Forms.TextBox AccPriceBox;
        private System.Windows.Forms.TextBox BasePriceBox;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.RadioButton Model5Select;
        private System.Windows.Forms.RadioButton Model6Select;
        private System.Windows.Forms.RadioButton Mem128GB;
        private System.Windows.Forms.RadioButton Mem64GB;
        private System.Windows.Forms.RadioButton Mem16GB;
        private System.Windows.Forms.RadioButton colourGold;
        private System.Windows.Forms.RadioButton colourSilver;
        private System.Windows.Forms.RadioButton colourBlack;
    }
}

