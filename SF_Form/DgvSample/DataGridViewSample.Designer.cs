namespace SF_Form.DgvSample
{
    partial class DataGridViewSample
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
            this.btn_Add_Detail = new System.Windows.Forms.Button();
            this.btn_Add_Master = new System.Windows.Forms.Button();
            this.DGV_Detail = new System.Windows.Forms.DataGridView();
            this.DGV_Master = new System.Windows.Forms.DataGridView();
            this.btn_Other = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Master)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Add_Detail
            // 
            this.btn_Add_Detail.Location = new System.Drawing.Point(25, 99);
            this.btn_Add_Detail.Name = "btn_Add_Detail";
            this.btn_Add_Detail.Size = new System.Drawing.Size(126, 23);
            this.btn_Add_Detail.TabIndex = 7;
            this.btn_Add_Detail.Text = "Add Detail";
            this.btn_Add_Detail.UseVisualStyleBackColor = true;
            this.btn_Add_Detail.Click += new System.EventHandler(this.btn_Add_Detail_Click);
            // 
            // btn_Add_Master
            // 
            this.btn_Add_Master.Location = new System.Drawing.Point(25, 60);
            this.btn_Add_Master.Name = "btn_Add_Master";
            this.btn_Add_Master.Size = new System.Drawing.Size(126, 23);
            this.btn_Add_Master.TabIndex = 6;
            this.btn_Add_Master.Text = "Add Master";
            this.btn_Add_Master.UseVisualStyleBackColor = true;
            this.btn_Add_Master.Click += new System.EventHandler(this.btn_Add_Master_Click);
            // 
            // DGV_Detail
            // 
            this.DGV_Detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Detail.Location = new System.Drawing.Point(492, 60);
            this.DGV_Detail.Name = "DGV_Detail";
            this.DGV_Detail.RowTemplate.Height = 27;
            this.DGV_Detail.Size = new System.Drawing.Size(283, 331);
            this.DGV_Detail.TabIndex = 5;
            // 
            // DGV_Master
            // 
            this.DGV_Master.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Master.Location = new System.Drawing.Point(185, 60);
            this.DGV_Master.Name = "DGV_Master";
            this.DGV_Master.RowTemplate.Height = 27;
            this.DGV_Master.Size = new System.Drawing.Size(301, 331);
            this.DGV_Master.TabIndex = 4;
            // 
            // btn_Other
            // 
            this.btn_Other.Location = new System.Drawing.Point(25, 137);
            this.btn_Other.Name = "btn_Other";
            this.btn_Other.Size = new System.Drawing.Size(126, 23);
            this.btn_Other.TabIndex = 8;
            this.btn_Other.Text = "OtherForm";
            this.btn_Other.UseVisualStyleBackColor = true;
            this.btn_Other.Click += new System.EventHandler(this.btn_Other_Click);
            // 
            // DataGridViewSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Other);
            this.Controls.Add(this.btn_Add_Detail);
            this.Controls.Add(this.btn_Add_Master);
            this.Controls.Add(this.DGV_Detail);
            this.Controls.Add(this.DGV_Master);
            this.Name = "DataGridViewSample";
            this.Text = "DataGridViewSample";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataGridViewSample_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Master)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Add_Detail;
        private System.Windows.Forms.Button btn_Add_Master;
        private System.Windows.Forms.DataGridView DGV_Detail;
        private System.Windows.Forms.DataGridView DGV_Master;
        private System.Windows.Forms.Button btn_Other;
    }
}