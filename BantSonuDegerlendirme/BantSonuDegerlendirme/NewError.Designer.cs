namespace BantSonuDegerlendirme
{
    partial class NewError
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
            this.cmbErrorList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewError = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReturnDashboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbErrorList
            // 
            this.cmbErrorList.FormattingEnabled = true;
            this.cmbErrorList.Location = new System.Drawing.Point(83, 12);
            this.cmbErrorList.Name = "cmbErrorList";
            this.cmbErrorList.Size = new System.Drawing.Size(189, 21);
            this.cmbErrorList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hata Seçin";
            // 
            // btnNewError
            // 
            this.btnNewError.Location = new System.Drawing.Point(197, 78);
            this.btnNewError.Name = "btnNewError";
            this.btnNewError.Size = new System.Drawing.Size(75, 23);
            this.btnNewError.TabIndex = 3;
            this.btnNewError.Text = "Ekle";
            this.btnNewError.UseVisualStyleBackColor = true;
            this.btnNewError.Click += new System.EventHandler(this.btnNewError_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(83, 39);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(189, 20);
            this.txtDescription.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Saat Girin";
            // 
            // btnReturnDashboard
            // 
            this.btnReturnDashboard.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnReturnDashboard.Location = new System.Drawing.Point(12, 78);
            this.btnReturnDashboard.Name = "btnReturnDashboard";
            this.btnReturnDashboard.Size = new System.Drawing.Size(101, 23);
            this.btnReturnDashboard.TabIndex = 6;
            this.btnReturnDashboard.Text = "Anasayfaya Dön";
            this.btnReturnDashboard.UseVisualStyleBackColor = true;
            this.btnReturnDashboard.Click += new System.EventHandler(this.btnReturnDashboard_Click);
            // 
            // NewError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 113);
            this.Controls.Add(this.btnReturnDashboard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnNewError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbErrorList);
            this.Name = "NewError";
            this.Text = "Yeni Hata Ekle";
            this.Load += new System.EventHandler(this.NewError_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbErrorList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewError;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReturnDashboard;
    }
}