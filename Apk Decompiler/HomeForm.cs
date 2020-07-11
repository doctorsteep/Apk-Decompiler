/*
 * Создано в SharpDevelop.
 * Пользователь: Admin
 * Дата: 11.07.2020
 * Время: 2:51
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Apk_Decompiler
{
	/// <summary>
	/// Description of HomeForm.
	/// </summary>
	public partial class HomeForm : Form
	{
		public static string apktoolLastVersion = @"2.4.1";
		public static string pathHome = @"C:\Apk Decompiler";
		public static string pathApktoolJar = @"\apktool_" + apktoolLastVersion + @".jar";
		public static string pathApktoolBat = @"\apktool.bat";
		private string defauldDecompileFile = @"\AndroidManifest.xml";
		
		public HomeForm(Thread aplashscreen)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			Directory.CreateDirectory(pathHome);
			InitializeComponent();
			
			if (!System.IO.File.Exists(HomeForm.pathHome + HomeForm.pathApktoolBat)) {
				
			}
			
			this.button1.Click += new System.EventHandler(downloadResources);
			
			aplashscreen.Abort();
			
			DisplayApk(pathHome);
			DisplayDecompiled(pathHome);
			
			this.apkToolToolStripMenuItem.Text = "ApkTool";
			
			
			
			this.devToolStripMenuItem.Click += new System.EventHandler(aboutDeveloper);
			this.gitHubOpenSourceToolStripMenuItem.Click += new System.EventHandler(aboutGitHub);
			this.apkToolToolStripMenuItem.Click += new System.EventHandler(aboutApkTool);
			this.decompileApkFileToolStripMenuItem.Click += new System.EventHandler(openDecompile);
			this.button2.Click += new System.EventHandler(updatingLists);
			
			this.groupBox1.Text = "Список всех .apk файлов";
			this.groupBox2.Text = "Список декомпилированных файлов";
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private void updatingLists(object sub, EventArgs e) {
			DisplayApk(pathHome);
			DisplayDecompiled(pathHome);
		}
		
		private void downloadResources(object sub, EventArgs e) {
			new DownloadResources().Show();
		}
		
		private void openDecompile(object sub, EventArgs e) {
			new DecompileAPK().Show();
		}
		
		private void aboutDeveloper(object sub, EventArgs e) {
			System.Diagnostics.Process.Start("https://t.me/doctorsteep_group_en");
		}
		
		private void aboutGitHub(object sub, EventArgs e) {
			System.Diagnostics.Process.Start("https://github.com/doctorsteep/Apk-Decompiler");
		}
		
		private void aboutApkTool(object sub, EventArgs e) {
			System.Diagnostics.Process.Start("https://ibotpeaches.github.io/Apktool");
		}
		
		public void DisplayApk(string path) {
			this.listView1.Items.Clear();
			string[] files = System.IO.Directory.GetFiles(path);
			for (int x = 0; x < files.Length; x++) {
				if (System.IO.File.Exists(files[x]) && files[x].EndsWith(".apk")) {
					ListViewItem items = new ListViewItem(System.IO.Path.GetFileName(files[x]));
					items.SubItems.Add(files[x]);
					this.listView1.Items.Add(items);
				}
			}
		}
		
		public void DisplayDecompiled(string path) {
			this.listView2.Items.Clear();
			string[] files2 = System.IO.Directory.GetDirectories(path);
			for (int x = 0; x < files2.Length; x++) {
				if (System.IO.Directory.Exists(files2[x])) {
					if (System.IO.File.Exists(files2[x] + defauldDecompileFile)) {
						ListViewItem items = new ListViewItem(files2[x]);
						items.SubItems.Add(files2[x]);
						this.listView2.Items.Add(items);
					}
				}
			}
		}
		void HomeFormLoad(object sender, EventArgs e)
		{
	
		}
		void GroupBox1Enter(object sender, EventArgs e)
		{
	
		}
	}
}
