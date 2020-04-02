namespace SF_Form.DgvSample
{
    partial class OtherForm
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
            this.btn_Add_DetailB = new System.Windows.Forms.Button();
            this.btn_Add_MasterB = new System.Windows.Forms.Button();
            this.DGV_DetailB = new System.Windows.Forms.DataGridView();
            this.DGV_MasterB = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DetailB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_MasterB)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Add_DetailB
            // 
            this.btn_Add_DetailB.Location = new System.Drawing.Point(25, 99);
            this.btn_Add_DetailB.Name = "btn_Add_DetailB";
            this.btn_Add_DetailB.Size = new System.Drawing.Size(126, 23);
            this.btn_Add_DetailB.TabIndex = 7;
            this.btn_Add_DetailB.Text = "Add Detail";
            this.btn_Add_DetailB.UseVisualStyleBackColor = true;
            this.btn_Add_DetailB.Click += new System.EventHandler(this.btn_Add_DetailB_Click);
            // 
            // btn_Add_MasterB
            // 
            this.btn_Add_MasterB.Location = new System.Drawing.Point(25, 60);
            this.btn_Add_MasterB.Name = "btn_Add_MasterB";
            this.btn_Add_MasterB.Size = new System.Drawing.Size(126, 23);
            this.btn_Add_MasterB.TabIndex = 6;
            this.btn_Add_MasterB.Text = "Add Master";
            this.btn_Add_MasterB.UseVisualStyleBackColor = true;
            this.btn_Add_MasterB.Click += new System.EventHandler(this.btn_Add_MasterB_Click);
            // 
            // DGV_DetailB
            // 
            this.DGV_DetailB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DetailB.Location = new System.Drawing.Point(492, 60);
            this.DGV_DetailB.Name = "DGV_DetailB";
            this.DGV_DetailB.RowTemplate.Height = 27;
            this.DGV_DetailB.Size = new System.Drawing.Size(283, 331);
            this.DGV_DetailB.TabIndex = 5;
            // 
            // DGV_MasterB
            // 
            this.DGV_MasterB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_MasterB.Location = new System.Drawing.Point(185, 60);
            this.DGV_MasterB.Name = "DGV_MasterB";
            this.DGV_MasterB.RowTemplate.Height = 27;
            this.DGV_MasterB.Size = new System.Drawing.Size(301, 331);
            this.DGV_MasterB.TabIndex = 4;
            // 
            // OtherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Add_DetailB);
            this.Controls.Add(this.btn_Add_MasterB);
            this.Controls.Add(this.DGV_DetailB);
            this.Controls.Add(this.DGV_MasterB);
            this.Name = "OtherForm";
            this.Text = "OtherForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OtherForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DetailB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_MasterB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Add_DetailB;
        private System.Windows.Forms.Button btn_Add_MasterB;
        private System.Windows.Forms.DataGridView DGV_DetailB;
        private System.Windows.Forms.DataGridView DGV_MasterB;
    }
}