namespace RoboDog
{
    partial class CambiaColore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiaColore));
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RedSelection = new System.Windows.Forms.HScrollBar();
            this.GreenSelection = new System.Windows.Forms.HScrollBar();
            this.BlueSelection = new System.Windows.Forms.HScrollBar();
            this.BrightnessSelection = new System.Windows.Forms.HScrollBar();
            this.SelectedColor = new System.Windows.Forms.PictureBox();
            this.picOriginal = new System.Windows.Forms.PictureBox();
            this.picToned = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chckBxCriniera = new System.Windows.Forms.CheckBox();
            this.chckBxOrecchie = new System.Windows.Forms.CheckBox();
            this.chckBxCoda = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picToned)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Brightness";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Blue";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Green";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Red";
            // 
            // RedSelection
            // 
            this.RedSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RedSelection.Location = new System.Drawing.Point(84, 15);
            this.RedSelection.Maximum = 264;
            this.RedSelection.Name = "RedSelection";
            this.RedSelection.Size = new System.Drawing.Size(361, 18);
            this.RedSelection.TabIndex = 19;
            this.RedSelection.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrColorComponent_Scroll);
            // 
            // GreenSelection
            // 
            this.GreenSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GreenSelection.Location = new System.Drawing.Point(84, 41);
            this.GreenSelection.Maximum = 264;
            this.GreenSelection.Name = "GreenSelection";
            this.GreenSelection.Size = new System.Drawing.Size(361, 18);
            this.GreenSelection.TabIndex = 20;
            this.GreenSelection.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrColorComponent_Scroll);
            // 
            // BlueSelection
            // 
            this.BlueSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BlueSelection.Location = new System.Drawing.Point(84, 69);
            this.BlueSelection.Maximum = 264;
            this.BlueSelection.Name = "BlueSelection";
            this.BlueSelection.Size = new System.Drawing.Size(361, 18);
            this.BlueSelection.TabIndex = 21;
            this.BlueSelection.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrColorComponent_Scroll);
            // 
            // BrightnessSelection
            // 
            this.BrightnessSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BrightnessSelection.Location = new System.Drawing.Point(84, 96);
            this.BrightnessSelection.Maximum = 264;
            this.BrightnessSelection.Name = "BrightnessSelection";
            this.BrightnessSelection.Size = new System.Drawing.Size(361, 18);
            this.BrightnessSelection.TabIndex = 22;
            this.BrightnessSelection.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrColorComponent_Scroll);
            // 
            // SelectedColor
            // 
            this.SelectedColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectedColor.Location = new System.Drawing.Point(471, 15);
            this.SelectedColor.Name = "SelectedColor";
            this.SelectedColor.Size = new System.Drawing.Size(100, 99);
            this.SelectedColor.TabIndex = 29;
            this.SelectedColor.TabStop = false;
            this.SelectedColor.Click += new System.EventHandler(this.SelectedColor_Click);
            // 
            // picOriginal
            // 
            this.picOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picOriginal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picOriginal.Location = new System.Drawing.Point(2, 17);
            this.picOriginal.Name = "picOriginal";
            this.picOriginal.Size = new System.Drawing.Size(507, 298);
            this.picOriginal.TabIndex = 24;
            this.picOriginal.TabStop = false;
            // 
            // picToned
            // 
            this.picToned.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picToned.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picToned.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picToned.Location = new System.Drawing.Point(7, 16);
            this.picToned.Name = "picToned";
            this.picToned.Size = new System.Drawing.Size(507, 298);
            this.picToned.TabIndex = 23;
            this.picToned.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(869, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 113);
            this.button1.TabIndex = 30;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.picOriginal);
            this.groupBox1.Location = new System.Drawing.Point(6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 321);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Before";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.picToned);
            this.groupBox2.Location = new System.Drawing.Point(529, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 321);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "After";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.BrightnessSelection);
            this.groupBox3.Controls.Add(this.BlueSelection);
            this.groupBox3.Controls.Add(this.GreenSelection);
            this.groupBox3.Controls.Add(this.SelectedColor);
            this.groupBox3.Controls.Add(this.RedSelection);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(254, 332);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(583, 128);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Color";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.chckBxCriniera);
            this.groupBox4.Controls.Add(this.chckBxOrecchie);
            this.groupBox4.Controls.Add(this.chckBxCoda);
            this.groupBox4.Location = new System.Drawing.Point(12, 332);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(236, 128);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Character";
            // 
            // chckBxCriniera
            // 
            this.chckBxCriniera.AutoSize = true;
            this.chckBxCriniera.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckBxCriniera.Location = new System.Drawing.Point(6, 91);
            this.chckBxCriniera.Name = "chckBxCriniera";
            this.chckBxCriniera.Size = new System.Drawing.Size(85, 29);
            this.chckBxCriniera.TabIndex = 2;
            this.chckBxCriniera.Text = "Mane";
            this.chckBxCriniera.UseVisualStyleBackColor = true;
            this.chckBxCriniera.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chckBxOrecchie
            // 
            this.chckBxOrecchie.AutoSize = true;
            this.chckBxOrecchie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckBxOrecchie.Location = new System.Drawing.Point(6, 58);
            this.chckBxOrecchie.Name = "chckBxOrecchie";
            this.chckBxOrecchie.Size = new System.Drawing.Size(127, 29);
            this.chckBxOrecchie.TabIndex = 1;
            this.chckBxOrecchie.Text = "Long ears";
            this.chckBxOrecchie.UseVisualStyleBackColor = true;
            this.chckBxOrecchie.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chckBxCoda
            // 
            this.chckBxCoda.AutoSize = true;
            this.chckBxCoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckBxCoda.Location = new System.Drawing.Point(6, 23);
            this.chckBxCoda.Name = "chckBxCoda";
            this.chckBxCoda.Size = new System.Drawing.Size(113, 29);
            this.chckBxCoda.TabIndex = 0;
            this.chckBxCoda.Text = "Long tail";
            this.chckBxCoda.UseVisualStyleBackColor = true;
            this.chckBxCoda.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CambiaColore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1051, 465);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1067, 504);
            this.Name = "CambiaColore";
            this.Text = "Change color";
            this.Load += new System.EventHandler(this.CambiaColore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SelectedColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picToned)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SelectedColor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.HScrollBar RedSelection;
        private System.Windows.Forms.HScrollBar GreenSelection;
        private System.Windows.Forms.HScrollBar BlueSelection;
        private System.Windows.Forms.HScrollBar BrightnessSelection;
        private System.Windows.Forms.PictureBox picOriginal;
        private System.Windows.Forms.PictureBox picToned;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chckBxOrecchie;
        private System.Windows.Forms.CheckBox chckBxCoda;
        private System.Windows.Forms.CheckBox chckBxCriniera;
    }
}