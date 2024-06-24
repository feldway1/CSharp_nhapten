namespace CSharp_nhapten
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
            this.grbcolor = new System.Windows.Forms.GroupBox();
            this.rdbBlack = new System.Windows.Forms.RadioButton();
            this.rdbBlue = new System.Windows.Forms.RadioButton();
            this.rdbGreen = new System.Windows.Forms.RadioButton();
            this.rdbRed = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnhapten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.lbllaptrinh = new System.Windows.Forms.Label();
            this.ckbBold = new System.Windows.Forms.CheckBox();
            this.ckbItalic = new System.Windows.Forms.CheckBox();
            this.ckbUnderLine = new System.Windows.Forms.CheckBox();
            this.Font = new System.Windows.Forms.GroupBox();
            this.grbcolor.SuspendLayout();
            this.Font.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbcolor
            // 
            this.grbcolor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grbcolor.Controls.Add(this.rdbBlack);
            this.grbcolor.Controls.Add(this.rdbBlue);
            this.grbcolor.Controls.Add(this.rdbGreen);
            this.grbcolor.Controls.Add(this.rdbRed);
            this.grbcolor.Location = new System.Drawing.Point(50, 96);
            this.grbcolor.Margin = new System.Windows.Forms.Padding(4);
            this.grbcolor.Name = "grbcolor";
            this.grbcolor.Padding = new System.Windows.Forms.Padding(4);
            this.grbcolor.Size = new System.Drawing.Size(174, 248);
            this.grbcolor.TabIndex = 0;
            this.grbcolor.TabStop = false;
            this.grbcolor.Text = "Color";
            this.grbcolor.Enter += new System.EventHandler(this.grbcolor_Enter);
            // 
            // rdbBlack
            // 
            this.rdbBlack.AutoSize = true;
            this.rdbBlack.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBlack.Location = new System.Drawing.Point(10, 187);
            this.rdbBlack.Margin = new System.Windows.Forms.Padding(4);
            this.rdbBlack.Name = "rdbBlack";
            this.rdbBlack.Size = new System.Drawing.Size(71, 23);
            this.rdbBlack.TabIndex = 3;
            this.rdbBlack.Text = "Black";
            this.rdbBlack.UseVisualStyleBackColor = true;
            this.rdbBlack.CheckedChanged += new System.EventHandler(this.rdbRed_CheckedChanged);
            // 
            // rdbBlue
            // 
            this.rdbBlue.AutoSize = true;
            this.rdbBlue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBlue.ForeColor = System.Drawing.Color.Blue;
            this.rdbBlue.Location = new System.Drawing.Point(10, 130);
            this.rdbBlue.Margin = new System.Windows.Forms.Padding(4);
            this.rdbBlue.Name = "rdbBlue";
            this.rdbBlue.Size = new System.Drawing.Size(63, 23);
            this.rdbBlue.TabIndex = 2;
            this.rdbBlue.Text = "Blue";
            this.rdbBlue.UseVisualStyleBackColor = true;
            this.rdbBlue.CheckedChanged += new System.EventHandler(this.rdbRed_CheckedChanged);
            // 
            // rdbGreen
            // 
            this.rdbGreen.AutoSize = true;
            this.rdbGreen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGreen.ForeColor = System.Drawing.Color.Green;
            this.rdbGreen.Location = new System.Drawing.Point(10, 79);
            this.rdbGreen.Margin = new System.Windows.Forms.Padding(4);
            this.rdbGreen.Name = "rdbGreen";
            this.rdbGreen.Size = new System.Drawing.Size(76, 23);
            this.rdbGreen.TabIndex = 1;
            this.rdbGreen.Text = "Green";
            this.rdbGreen.UseVisualStyleBackColor = true;
            this.rdbGreen.CheckedChanged += new System.EventHandler(this.rdbRed_CheckedChanged);
            // 
            // rdbRed
            // 
            this.rdbRed.AutoSize = true;
            this.rdbRed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRed.ForeColor = System.Drawing.Color.Red;
            this.rdbRed.Location = new System.Drawing.Point(10, 29);
            this.rdbRed.Margin = new System.Windows.Forms.Padding(4);
            this.rdbRed.Name = "rdbRed";
            this.rdbRed.Size = new System.Drawing.Size(59, 23);
            this.rdbRed.TabIndex = 0;
            this.rdbRed.Text = "Red";
            this.rdbRed.UseVisualStyleBackColor = true;
            this.rdbRed.CheckedChanged += new System.EventHandler(this.rdbRed_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(57, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập Tên ";
            // 
            // txtnhapten
            // 
            this.txtnhapten.Location = new System.Drawing.Point(173, 29);
            this.txtnhapten.Margin = new System.Windows.Forms.Padding(4);
            this.txtnhapten.Name = "txtnhapten";
            this.txtnhapten.Size = new System.Drawing.Size(274, 27);
            this.txtnhapten.TabIndex = 3;
            this.txtnhapten.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(46, 386);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lập Trình Bởi:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(335, 480);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(112, 34);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // lbllaptrinh
            // 
            this.lbllaptrinh.AutoSize = true;
            this.lbllaptrinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbllaptrinh.Location = new System.Drawing.Point(60, 433);
            this.lbllaptrinh.Name = "lbllaptrinh";
            this.lbllaptrinh.Size = new System.Drawing.Size(276, 21);
            this.lbllaptrinh.TabIndex = 7;
            this.lbllaptrinh.Text = "                                                     ";
            // 
            // ckbBold
            // 
            this.ckbBold.AutoSize = true;
            this.ckbBold.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbBold.Location = new System.Drawing.Point(30, 30);
            this.ckbBold.Margin = new System.Windows.Forms.Padding(4);
            this.ckbBold.Name = "ckbBold";
            this.ckbBold.Size = new System.Drawing.Size(120, 23);
            this.ckbBold.TabIndex = 0;
            this.ckbBold.Text = "Đậm / Bold";
            this.ckbBold.UseVisualStyleBackColor = true;
            this.ckbBold.CheckedChanged += new System.EventHandler(this.ckbBold_CheckedChanged);
            // 
            // ckbItalic
            // 
            this.ckbItalic.AutoSize = true;
            this.ckbItalic.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbItalic.Location = new System.Drawing.Point(30, 106);
            this.ckbItalic.Margin = new System.Windows.Forms.Padding(4);
            this.ckbItalic.Name = "ckbItalic";
            this.ckbItalic.Size = new System.Drawing.Size(137, 23);
            this.ckbItalic.TabIndex = 1;
            this.ckbItalic.Text = "Nghiêng / Italic";
            this.ckbItalic.UseVisualStyleBackColor = true;
            this.ckbItalic.CheckedChanged += new System.EventHandler(this.ckbBold_CheckedChanged);
            // 
            // ckbUnderLine
            // 
            this.ckbUnderLine.AutoSize = true;
            this.ckbUnderLine.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbUnderLine.Location = new System.Drawing.Point(30, 187);
            this.ckbUnderLine.Margin = new System.Windows.Forms.Padding(4);
            this.ckbUnderLine.Name = "ckbUnderLine";
            this.ckbUnderLine.Size = new System.Drawing.Size(109, 23);
            this.ckbUnderLine.TabIndex = 2;
            this.ckbUnderLine.Text = "Gạch Chân ";
            this.ckbUnderLine.UseVisualStyleBackColor = true;
            this.ckbUnderLine.CheckedChanged += new System.EventHandler(this.ckbBold_CheckedChanged);
            // 
            // Font
            // 
            this.Font.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Font.Controls.Add(this.ckbBold);
            this.Font.Controls.Add(this.ckbUnderLine);
            this.Font.Controls.Add(this.ckbItalic);
            this.Font.Location = new System.Drawing.Point(273, 96);
            this.Font.Name = "Font";
            this.Font.Size = new System.Drawing.Size(200, 248);
            this.Font.TabIndex = 8;
            this.Font.TabStop = false;
            this.Font.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(891, 558);
            this.Controls.Add(this.Font);
            this.Controls.Add(this.lbllaptrinh);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnhapten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbcolor);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Định Dạng (Formater)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbcolor.ResumeLayout(false);
            this.grbcolor.PerformLayout();
            this.Font.ResumeLayout(false);
            this.Font.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbcolor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnhapten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.RadioButton rdbBlack;
        private System.Windows.Forms.RadioButton rdbBlue;
        private System.Windows.Forms.RadioButton rdbGreen;
        private System.Windows.Forms.RadioButton rdbRed;
        private System.Windows.Forms.Label lbllaptrinh;
        private System.Windows.Forms.CheckBox ckbBold;
        private System.Windows.Forms.CheckBox ckbItalic;
        private System.Windows.Forms.CheckBox ckbUnderLine;
        private System.Windows.Forms.GroupBox Font;
    }
}

