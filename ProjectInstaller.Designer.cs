namespace loginswitcher
{
    partial class ProjectInstaller
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.serviceProcessInstallerloginswitcher = new System.ServiceProcess.ServiceProcessInstaller();
            this.loginswitcher = new System.ServiceProcess.ServiceInstaller();
            // 
            // serviceProcessInstallerloginswitcher
            // 
            this.serviceProcessInstallerloginswitcher.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.serviceProcessInstallerloginswitcher.Password = null;
            this.serviceProcessInstallerloginswitcher.Username = null;
            // 
            // loginswitcher
            // 
            this.loginswitcher.ServiceName = "LoginRotator";
            this.loginswitcher.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.serviceProcessInstallerloginswitcher,
            this.loginswitcher});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller serviceProcessInstallerloginswitcher;
        private System.ServiceProcess.ServiceInstaller loginswitcher;
    }
}