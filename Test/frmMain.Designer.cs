namespace Test
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtChinese = new System.Windows.Forms.TextBox();
            this.cmdPinyinNumber = new System.Windows.Forms.Button();
            this.cmdPinyinMark = new System.Windows.Forms.Button();
            this.txtPinyin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdTranslate = new System.Windows.Forms.Button();
            this.txtVietnamese = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chinese";
            // 
            // txtChinese
            // 
            this.txtChinese.Location = new System.Drawing.Point(70, 18);
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(101, 20);
            this.txtChinese.TabIndex = 1;
            this.txtChinese.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdPinyinNumber
            // 
            this.cmdPinyinNumber.Location = new System.Drawing.Point(15, 44);
            this.cmdPinyinNumber.Name = "cmdPinyinNumber";
            this.cmdPinyinNumber.Size = new System.Drawing.Size(75, 23);
            this.cmdPinyinNumber.TabIndex = 2;
            this.cmdPinyinNumber.Text = "Number";
            this.cmdPinyinNumber.UseVisualStyleBackColor = true;
            this.cmdPinyinNumber.Click += new System.EventHandler(this.cmdPinyinNumber_Click);
            // 
            // cmdPinyinMark
            // 
            this.cmdPinyinMark.Location = new System.Drawing.Point(96, 44);
            this.cmdPinyinMark.Name = "cmdPinyinMark";
            this.cmdPinyinMark.Size = new System.Drawing.Size(75, 23);
            this.cmdPinyinMark.TabIndex = 3;
            this.cmdPinyinMark.Text = "Mark";
            this.cmdPinyinMark.UseVisualStyleBackColor = true;
            this.cmdPinyinMark.Click += new System.EventHandler(this.cmdPinyinMark_Click);
            // 
            // txtPinyin
            // 
            this.txtPinyin.Location = new System.Drawing.Point(70, 73);
            this.txtPinyin.Name = "txtPinyin";
            this.txtPinyin.Size = new System.Drawing.Size(101, 20);
            this.txtPinyin.TabIndex = 4;
            this.txtPinyin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pinyin";
            // 
            // cmdTranslate
            // 
            this.cmdTranslate.Location = new System.Drawing.Point(15, 99);
            this.cmdTranslate.Name = "cmdTranslate";
            this.cmdTranslate.Size = new System.Drawing.Size(75, 23);
            this.cmdTranslate.TabIndex = 6;
            this.cmdTranslate.Text = "Translate";
            this.cmdTranslate.UseVisualStyleBackColor = true;
            this.cmdTranslate.Click += new System.EventHandler(this.cmdTranslate_Click);
            // 
            // txtVietnamese
            // 
            this.txtVietnamese.Location = new System.Drawing.Point(70, 128);
            this.txtVietnamese.Name = "txtVietnamese";
            this.txtVietnamese.Size = new System.Drawing.Size(101, 20);
            this.txtVietnamese.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vietnam";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 168);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVietnamese);
            this.Controls.Add(this.cmdTranslate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPinyin);
            this.Controls.Add(this.cmdPinyinMark);
            this.Controls.Add(this.cmdPinyinNumber);
            this.Controls.Add(this.txtChinese);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChinese;
        private System.Windows.Forms.Button cmdPinyinNumber;
        private System.Windows.Forms.Button cmdPinyinMark;
        private System.Windows.Forms.TextBox txtPinyin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdTranslate;
        private System.Windows.Forms.TextBox txtVietnamese;
        private System.Windows.Forms.Label label3;
    }
}

