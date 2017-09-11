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
            this.lstErrorDataList = new System.Windows.Forms.ListBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenNewErrorForm
            // 
            this.btnOpenNewErrorForm.Location = new System.Drawing.Point(559, 301);
            this.btnOpenNewErrorForm.Name = "btnOpenNewErrorForm";
            this.btnOpenNewErrorForm.Size = new System.Drawing.Size(100, 23);
            this.btnOpenNewErrorForm.TabIndex = 0;
            this.btnOpenNewErrorForm.Text = "Yeni Hata Ekle";
            this.btnOpenNewErrorForm.UseVisualStyleBackColor = true;
            this.btnOpenNewErrorForm.Click += new System.EventHandler(this.btnOpenNewErrorForm_Click);
            // 
            // lstErrorDataList
            // 
            this.lstErrorDataList.FormattingEnabled = true;
            this.lstErrorDataList.Location = new System.Drawing.Point(12, 12);
            this.lstErrorDataList.Name = "lstErrorDataList";
            this.lstErrorDataList.Size = new System.Drawing.Size(647, 277);
            this.lstErrorDataList.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 301);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Çıkış Yap";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 336);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lstErrorDataList);
            this.Controls.Add(this.btnOpenNewErrorForm);
            this.Name = "Dashboard";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenNewErrorForm;
        private System.Windows.Forms.ListBox lstErrorDataList;
        private System.Windows.Forms.Button btnLogout;
    }
}