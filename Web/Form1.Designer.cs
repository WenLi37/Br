namespace Web {
	partial class Main_Form {
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
			this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
			this.chromiumHostControl1 = new CefSharp.WinForms.Host.ChromiumHostControl();
			this.SuspendLayout();
			// 
			// chromiumWebBrowser1
			// 
			resources.ApplyResources(this.chromiumWebBrowser1, "chromiumWebBrowser1");
			this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
			this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
			// 
			// chromiumHostControl1
			// 
			resources.ApplyResources(this.chromiumHostControl1, "chromiumHostControl1");
			this.chromiumHostControl1.Name = "chromiumHostControl1";
			this.chromiumHostControl1.Click += new System.EventHandler(this.chromiumHostControl1_Click);
			// 
			// Main_Form
			// 
			resources.ApplyResources(this, "$this");
			this.AllowDrop = true;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.chromiumHostControl1);
			this.Controls.Add(this.chromiumWebBrowser1);
			this.DoubleBuffered = true;
			this.Name = "Main_Form";
			this.Load += new System.EventHandler(this.Main_Form_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
		private CefSharp.WinForms.Host.ChromiumHostControl chromiumHostControl1;
	}
}

