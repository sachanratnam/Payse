namespace Payse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.PnlTitleBar = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.PnlSideBar = new System.Windows.Forms.Panel();
            this.PnlButtonBar = new System.Windows.Forms.Panel();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.PnlMain = new System.Windows.Forms.Panel();
            this.ucHome1 = new Payse.UcHome();
            this.ucSettings1 = new Payse.UcSettings();
            this.ucAbout1 = new Payse.UcAbout();
            this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PnlTitleBar.SuspendLayout();
            this.PnlSideBar.SuspendLayout();
            this.PnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTitleBar
            // 
            this.PnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.PnlTitleBar.Controls.Add(this.LblTitle);
            this.PnlTitleBar.Controls.Add(this.BtnMinimize);
            this.PnlTitleBar.Controls.Add(this.BtnClose);
            this.PnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.PnlTitleBar.Name = "PnlTitleBar";
            this.PnlTitleBar.Size = new System.Drawing.Size(600, 50);
            this.PnlTitleBar.TabIndex = 0;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(31, 6);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(99, 36);
            this.LblTitle.TabIndex = 6;
            this.LblTitle.Text = "Payse";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinimize.ForeColor = System.Drawing.Color.White;
            this.BtnMinimize.Image = global::Payse.Properties.Resources.min;
            this.BtnMinimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnMinimize.Location = new System.Drawing.Point(500, 0);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(50, 50);
            this.BtnMinimize.TabIndex = 5;
            this.BtnMinimize.UseVisualStyleBackColor = true;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Image = global::Payse.Properties.Resources.close;
            this.BtnClose.Location = new System.Drawing.Point(550, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(50, 50);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // PnlSideBar
            // 
            this.PnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.PnlSideBar.Controls.Add(this.PnlButtonBar);
            this.PnlSideBar.Controls.Add(this.BtnAbout);
            this.PnlSideBar.Controls.Add(this.BtnSettings);
            this.PnlSideBar.Controls.Add(this.BtnHome);
            this.PnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlSideBar.Location = new System.Drawing.Point(0, 50);
            this.PnlSideBar.Name = "PnlSideBar";
            this.PnlSideBar.Size = new System.Drawing.Size(160, 350);
            this.PnlSideBar.TabIndex = 0;
            // 
            // PnlButtonBar
            // 
            this.PnlButtonBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.PnlButtonBar.Location = new System.Drawing.Point(0, 21);
            this.PnlButtonBar.Name = "PnlButtonBar";
            this.PnlButtonBar.Size = new System.Drawing.Size(10, 50);
            this.PnlButtonBar.TabIndex = 3;
            // 
            // BtnAbout
            // 
            this.BtnAbout.FlatAppearance.BorderSize = 0;
            this.BtnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbout.ForeColor = System.Drawing.Color.White;
            this.BtnAbout.Location = new System.Drawing.Point(0, 121);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(160, 50);
            this.BtnAbout.TabIndex = 2;
            this.BtnAbout.Text = "ABOUT";
            this.BtnAbout.UseVisualStyleBackColor = true;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // BtnSettings
            // 
            this.BtnSettings.FlatAppearance.BorderSize = 0;
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSettings.ForeColor = System.Drawing.Color.White;
            this.BtnSettings.Location = new System.Drawing.Point(0, 71);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(160, 50);
            this.BtnSettings.TabIndex = 1;
            this.BtnSettings.Text = "SETTINGS";
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.ForeColor = System.Drawing.Color.White;
            this.BtnHome.Location = new System.Drawing.Point(0, 21);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(160, 50);
            this.BtnHome.TabIndex = 0;
            this.BtnHome.Text = "HOME";
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // PnlMain
            // 
            this.PnlMain.Controls.Add(this.ucHome1);
            this.PnlMain.Controls.Add(this.ucSettings1);
            this.PnlMain.Controls.Add(this.ucAbout1);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlMain.Location = new System.Drawing.Point(160, 50);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(440, 350);
            this.PnlMain.TabIndex = 1;
            // 
            // ucHome1
            // 
            this.ucHome1.BackColor = System.Drawing.Color.White;
            this.ucHome1.Location = new System.Drawing.Point(0, 0);
            this.ucHome1.Name = "ucHome1";
            this.ucHome1.Size = new System.Drawing.Size(440, 350);
            this.ucHome1.TabIndex = 2;
            // 
            // ucSettings1
            // 
            this.ucSettings1.BackColor = System.Drawing.Color.White;
            this.ucSettings1.Location = new System.Drawing.Point(0, 0);
            this.ucSettings1.Name = "ucSettings1";
            this.ucSettings1.Size = new System.Drawing.Size(440, 350);
            this.ucSettings1.TabIndex = 1;
            // 
            // ucAbout1
            // 
            this.ucAbout1.BackColor = System.Drawing.Color.White;
            this.ucAbout1.Location = new System.Drawing.Point(0, 0);
            this.ucAbout1.Name = "ucAbout1";
            this.ucAbout1.Size = new System.Drawing.Size(440, 350);
            this.ucAbout1.TabIndex = 0;
            // 
            // BackgroundWorker1
            // 
            this.BackgroundWorker1.WorkerSupportsCancellation = true;
            this.BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.BackgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.PnlSideBar);
            this.Controls.Add(this.PnlMain);
            this.Controls.Add(this.PnlTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.Text = "Payse";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.PnlTitleBar.ResumeLayout(false);
            this.PnlTitleBar.PerformLayout();
            this.PnlSideBar.ResumeLayout(false);
            this.PnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTitleBar;
        private System.Windows.Forms.Panel PnlSideBar;
        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button BtnAbout;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Panel PnlButtonBar;
        private UcHome ucHome1;
        private UcSettings ucSettings1;
        private UcAbout ucAbout1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnMinimize;
        private System.ComponentModel.BackgroundWorker BackgroundWorker1;
        private System.Windows.Forms.Label LblTitle;
    }
}

