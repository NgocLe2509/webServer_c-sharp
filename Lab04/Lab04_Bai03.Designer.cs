namespace Lab04
{
    partial class Lab04_Bai03
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
            this.cbbSearch = new System.Windows.Forms.ComboBox();
            this.btnViewSource = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnCanGoBack = new System.Windows.Forms.Button();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbSearch
            // 
            this.cbbSearch.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSearch.FormattingEnabled = true;
            this.cbbSearch.Location = new System.Drawing.Point(129, 10);
            this.cbbSearch.Name = "cbbSearch";
            this.cbbSearch.Size = new System.Drawing.Size(687, 25);
            this.cbbSearch.TabIndex = 0;
            this.cbbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbSearch_KeyPress);
            // 
            // btnViewSource
            // 
            this.btnViewSource.BackColor = System.Drawing.SystemColors.Window;
            this.btnViewSource.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSource.ForeColor = System.Drawing.Color.Black;
            this.btnViewSource.Location = new System.Drawing.Point(845, 4);
            this.btnViewSource.Name = "btnViewSource";
            this.btnViewSource.Size = new System.Drawing.Size(140, 33);
            this.btnViewSource.TabIndex = 31;
            this.btnViewSource.Text = "View Source";
            this.btnViewSource.UseVisualStyleBackColor = false;
            this.btnViewSource.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.SystemColors.Window;
            this.btnDownload.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.ForeColor = System.Drawing.Color.Black;
            this.btnDownload.Location = new System.Drawing.Point(991, 4);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(122, 33);
            this.btnDownload.TabIndex = 32;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(15, 62);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1358, 643);
            this.webBrowser.TabIndex = 33;
            this.webBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser_Navigated);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.White;
            this.btnGoBack.Location = new System.Drawing.Point(15, 6);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(28, 31);
            this.btnGoBack.TabIndex = 34;
            this.btnGoBack.Text = "<";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnCanGoBack
            // 
            this.btnCanGoBack.BackColor = System.Drawing.Color.White;
            this.btnCanGoBack.Location = new System.Drawing.Point(49, 6);
            this.btnCanGoBack.Name = "btnCanGoBack";
            this.btnCanGoBack.Size = new System.Drawing.Size(27, 31);
            this.btnCanGoBack.TabIndex = 35;
            this.btnCanGoBack.Text = ">";
            this.btnCanGoBack.UseVisualStyleBackColor = false;
            this.btnCanGoBack.Click += new System.EventHandler(this.btnCanGoBack_Click);
            // 
            // picRefresh
            // 
            this.picRefresh.Image = global::Lab04.Properties.Resources.Capture;
            this.picRefresh.Location = new System.Drawing.Point(82, 4);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(31, 27);
            this.picRefresh.TabIndex = 36;
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picResearch_Click);
            // 
            // Lab04_Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1374, 706);
            this.Controls.Add(this.picRefresh);
            this.Controls.Add(this.btnCanGoBack);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnViewSource);
            this.Controls.Add(this.cbbSearch);
            this.Name = "Lab04_Bai03";
            this.Text = "Lab04_Bai03";
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbSearch;
        private System.Windows.Forms.Button btnViewSource;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnCanGoBack;
        private System.Windows.Forms.PictureBox picRefresh;
    }
}