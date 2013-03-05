namespace WinformsHostingWPFApp
{
    partial class MainLauncher
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
            this.wpfAppPanel = new System.Windows.Forms.Panel();
            this.btnLaunchWpfApp = new System.Windows.Forms.Button();
            this.grpBoxWPFOperations = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // wpfAppPanel
            // 
            this.wpfAppPanel.Location = new System.Drawing.Point(130, 12);
            this.wpfAppPanel.Name = "wpfAppPanel";
            this.wpfAppPanel.Size = new System.Drawing.Size(401, 272);
            this.wpfAppPanel.TabIndex = 0;
            // 
            // btnLaunchWpfApp
            // 
            this.btnLaunchWpfApp.Location = new System.Drawing.Point(24, 38);
            this.btnLaunchWpfApp.Name = "btnLaunchWpfApp";
            this.btnLaunchWpfApp.Size = new System.Drawing.Size(75, 23);
            this.btnLaunchWpfApp.TabIndex = 1;
            this.btnLaunchWpfApp.Text = "LaunchWPF";
            this.btnLaunchWpfApp.UseVisualStyleBackColor = true;
            this.btnLaunchWpfApp.Click += new System.EventHandler(OnWpfAppLaunch); 
            // 
            // grpBoxWPFOperations
            // 
            this.grpBoxWPFOperations.Location = new System.Drawing.Point(12, 12);
            this.grpBoxWPFOperations.Name = "grpBoxWPFOperations";
            this.grpBoxWPFOperations.Size = new System.Drawing.Size(112, 272);
            this.grpBoxWPFOperations.TabIndex = 0;
            this.grpBoxWPFOperations.TabStop = false;
            this.grpBoxWPFOperations.Text = "Operations";
            // 
            // MainLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 296);
            this.Controls.Add(this.btnLaunchWpfApp);
            this.Controls.Add(this.wpfAppPanel);
            this.Controls.Add(this.grpBoxWPFOperations);
            this.Name = "MainLauncher";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        void OnWpfAppLaunch(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel wpfAppPanel;
        private System.Windows.Forms.Button btnLaunchWpfApp;
        private System.Windows.Forms.GroupBox grpBoxWPFOperations;
    }
}

