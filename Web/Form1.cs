using CefSharp;
using CefSharp.WinForms;
using System;
using System.Windows.Forms;


namespace Web {
	public partial class Main_Form : Form {
		Web.Properties.Settings settings = new Web.Properties.Settings();
		public ChromiumWebBrowser CWB;
		public void InitBrowser() {
			Cef.Initialize(new CefSettings());
			CWB = new ChromiumWebBrowser("baidu.com");
			this.Controls.Add(CWB);
			CWB.Dock = DockStyle.Fill;
		}


		public Main_Form() {
			InitBrowser();
			InitializeComponent();
		}

		private void chromiumHostControl1_Click(object sender, EventArgs e) {

		}

		private void Main_Form_Load(object sender, EventArgs e) {
		}
	}
}
