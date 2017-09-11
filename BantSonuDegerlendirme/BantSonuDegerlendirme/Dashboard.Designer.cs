namespace BantSonuDegerlendirme
{
    partial class Dashboard
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
            this.btnOpenNewErrorForm = new System.Windows.Forms.Button();
            this.btnDtGridRefresh = new System.Windows.Forms.Button();
            this.lstErrorDataList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOpenNewErrorForm
            // 
            this.btnOpenNewErrorForm.Location = new System.Drawing.Point(12, 301);
            this.btnOpenNewErrorForm.Name = "btnOpenNewErrorForm";
            this.btnOpenNewErrorForm.Size = new System.Drawing.Size(100, 23);
            this.btnOpenNewErrorForm.TabIndex = 0;
            this.btnOpenNewErrorForm.Text = "Yeni Hata Ekle";
            this.btnOpenNewErrorForm.UseVisualStyleBackColor = true;
            this.btnOpenNewErrorForm.Click += new System.EventHandler(this.btnOpenNewErrorForm_Click);
            // 
            // btnDtGridRefresh
            // 
            this.btnDtGridRefresh.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDtGridRefresh.Location = new System.Drawing.Point(565, 301);
            this.btnDtGridRefresh.Name = "btnDtGridRefresh";
            this.btnDtGridRefresh.Size = new System.Drawing.Size(94, 23);
            this.btnDtGridRefresh.TabIndex = 2;
            this.btnDtGridRefresh.Text = "Tabloyu Yenile";
            this.btnDtGridRefresh.UseVisualStyleBackColor = true;
            this.btnDtGridRefresh.Click += new System.EventHandler(this.btnDtGridRefresh_Click);
            // 
            // lstErrorDataList
            // 
            this.lstErrorDataList.FormattingEnabled = true;
            this.lstErrorDataList.Location = new System.Drawing.Point(12, 12);
            this.lstErrorDataList.Name = "lstErrorDataList";
            this.lstErrorDataList.Size = new System.Drawing.Size(647, 277);
            this.lstErrorDataList.TabIndex = 3;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 336);
            this.Controls.Add(this.lstErrorDataList);
            this.Controls.Add(this.btnDtGridRefresh);
            this.Controls.Add(this.btnOpenNewErrorForm);
            this.Name = "Dashboard";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenNewErrorForm;
        private System.Windows.Forms.Button btnDtGridRefresh;
        private System.Windows.Forms.ListBox lstErrorDataList;
    }
}