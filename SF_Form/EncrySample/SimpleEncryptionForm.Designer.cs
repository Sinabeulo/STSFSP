namespace SF_Form.EncrySample
{
    partial class SimpleEncryptionForm
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
            this.tb_EnKey = new System.Windows.Forms.TextBox();
            this.tb_DecKey = new System.Windows.Forms.TextBox();
            this.tb_Plain = new System.Windows.Forms.TextBox();
            this.tb_Encry = new System.Windows.Forms.TextBox();
            this.btn_Encry = new System.Windows.Forms.Button();
            this.btn_Decry = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_Type1 = new System.Windows.Forms.RadioButton();
            this.rb_Type2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_Type3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // tb_EnKey
            // 
            this.tb_EnKey.Location = new System.Drawing.Point(187, 13);
            this.tb_EnKey.Name = "tb_EnKey";
            this.tb_EnKey.Size = new System.Drawing.Size(310, 25);
            this.tb_EnKey.TabIndex = 0;
            // 
            // tb_DecKey
            // 
            this.tb_DecKey.Location = new System.Drawing.Point(584, 12);
            this.tb_DecKey.Name = "tb_DecKey";
            this.tb_DecKey.Size = new System.Drawing.Size(310, 25);
            this.tb_DecKey.TabIndex = 1;
            // 
            // tb_Plain
            // 
            this.tb_Plain.Location = new System.Drawing.Point(187, 44);
            this.tb_Plain.Multiline = true;
            this.tb_Plain.Name = "tb_Plain";
            this.tb_Plain.Size = new System.Drawing.Size(310, 395);
            this.tb_Plain.TabIndex = 2;
            // 
            // tb_Encry
            // 
            this.tb_Encry.Location = new System.Drawing.Point(584, 43);
            this.tb_Encry.Multiline = true;
            this.tb_Encry.Name = "tb_Encry";
            this.tb_Encry.Size = new System.Drawing.Size(310, 395);
            this.tb_Encry.TabIndex = 3;
            // 
            // btn_Encry
            // 
            this.btn_Encry.Location = new System.Drawing.Point(12, 14);
            this.btn_Encry.Name = "btn_Encry";
            this.btn_Encry.Size = new System.Drawing.Size(75, 23);
            this.btn_Encry.TabIndex = 4;
            this.btn_Encry.Text = "Encry";
            this.btn_Encry.UseVisualStyleBackColor = true;
            this.btn_Encry.Click += new System.EventHandler(this.btn_Encry_Click);
            // 
            // btn_Decry
            // 
            this.btn_Decry.Location = new System.Drawing.Point(12, 43);
            this.btn_Decry.Name = "btn_Decry";
            this.btn_Decry.Size = new System.Drawing.Size(75, 23);
            this.btn_Decry.TabIndex = 5;
            this.btn_Decry.Text = "Decry";
            this.btn_Decry.UseVisualStyleBackColor = true;
            this.btn_Decry.Click += new System.EventHandler(this.btn_Decry_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Key";
            // 
            // rb_Type1
            // 
            this.rb_Type1.AutoSize = true;
            this.rb_Type1.Location = new System.Drawing.Point(12, 72);
            this.rb_Type1.Name = "rb_Type1";
            this.rb_Type1.Size = new System.Drawing.Size(108, 19);
            this.rb_Type1.TabIndex = 7;
            this.rb_Type1.TabStop = true;
            this.rb_Type1.Text = "SimpleEncry";
            this.rb_Type1.UseVisualStyleBackColor = true;
            // 
            // rb_Type2
            // 
            this.rb_Type2.AutoSize = true;
            this.rb_Type2.Location = new System.Drawing.Point(12, 97);
            this.rb_Type2.Name = "rb_Type2";
            this.rb_Type2.Size = new System.Drawing.Size(80, 19);
            this.rb_Type2.TabIndex = 8;
            this.rb_Type2.TabStop = true;
            this.rb_Type2.Text = "AES128";
            this.rb_Type2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "PlainText";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(510, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "EncryText";
            // 
            // rb_Type3
            // 
            this.rb_Type3.AutoSize = true;
            this.rb_Type3.Location = new System.Drawing.Point(12, 122);
            this.rb_Type3.Name = "rb_Type3";
            this.rb_Type3.Size = new System.Drawing.Size(80, 19);
            this.rb_Type3.TabIndex = 13;
            this.rb_Type3.TabStop = true;
            this.rb_Type3.Text = "AES256";
            this.rb_Type3.UseVisualStyleBackColor = true;
            // 
            // SimpleEncryptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 450);
            this.Controls.Add(this.rb_Type3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rb_Type2);
            this.Controls.Add(this.rb_Type1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Decry);
            this.Controls.Add(this.btn_Encry);
            this.Controls.Add(this.tb_Encry);
            this.Controls.Add(this.tb_Plain);
            this.Controls.Add(this.tb_DecKey);
            this.Controls.Add(this.tb_EnKey);
            this.Name = "SimpleEncryptionForm";
            this.Text = "SimpleEncryptionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_EnKey;
        private System.Windows.Forms.TextBox tb_DecKey;
        private System.Windows.Forms.TextBox tb_Plain;
        private System.Windows.Forms.TextBox tb_Encry;
        private System.Windows.Forms.Button btn_Encry;
        private System.Windows.Forms.Button btn_Decry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_Type1;
        private System.Windows.Forms.RadioButton rb_Type2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_Type3;
    }
}