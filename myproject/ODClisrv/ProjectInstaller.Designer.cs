﻿namespace ODClisrv
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ODClisrvProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.ODClisrvInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // ODClisrvProcessInstaller
            // 
            this.ODClisrvProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.ODClisrvProcessInstaller.Password = null;
            this.ODClisrvProcessInstaller.Username = null;
            // 
            // ODClisrvInstaller
            // 
            this.ODClisrvInstaller.DelayedAutoStart = true;
            this.ODClisrvInstaller.Description = "ODClient自动维护服务";
            this.ODClisrvInstaller.ServiceName = "ODClisrv";
            this.ODClisrvInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.ODClisrvProcessInstaller,
            this.ODClisrvInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller ODClisrvProcessInstaller;
        private System.ServiceProcess.ServiceInstaller ODClisrvInstaller;
    }
}