/*
 * Создано в SharpDevelop.
 * Пользователь: Admin
 * Дата: 11.07.2020
 * Время: 6:27
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Windows;

namespace Apk_Decompiler
{
	/// <summary>
	/// Description of DownloadResources.
	/// </summary>
	public partial class DownloadResources : Form
	{
		public DownloadResources()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

			
			this.comboBox1.Items.Add("https://bitbucket.org/iBotPeaches/apktool/downloads/apktool_2.4.1.jar");
			this.comboBox1.Items.Add("https://bitbucket.org/iBotPeaches/apktool/downloads/apktool_2.4.0.jar");
			this.comboBox1.Items.Add("https://bitbucket.org/iBotPeaches/apktool/downloads/apktool_2.3.4.jar");
			this.comboBox1.Items.Add("https://bitbucket.org/iBotPeaches/apktool/downloads/apktool_2.3.3.jar");
			this.comboBox1.Items.Add("https://bitbucket.org/iBotPeaches/apktool/downloads/apktool_2.3.2.jar");
			this.comboBox1.Items.Add("https://bitbucket.org/iBotPeaches/apktool/downloads/apktool_2.3.1.jar");
			this.comboBox1.Items.Add("https://bitbucket.org/iBotPeaches/apktool/downloads/apktool_2.3.0.jar");
			this.comboBox1.Items.Add("https://bitbucket.org/iBotPeaches/apktool/downloads/apktool_2.2.4.jar");
			this.comboBox1.Items.Add("https://bitbucket.org/iBotPeaches/apktool/downloads/apktool_2.2.3.jar");
			this.comboBox1.Items.Add("https://bitbucket.org/iBotPeaches/apktool/downloads/apktool_2.2.2.jar");
			this.comboBox1.Items.Add("https://bitbucket.org/iBotPeaches/apktool/downloads/apktool_2.2.1.jar");
			this.comboBox1.Items.Add("https://bitbucket.org/iBotPeaches/apktool/downloads/apktool_2.2.0.jar");
			this.comboBox1.Items.Add("https://bitbucket.org/iBotPeaches/apktool/downloads/apktool_2.1.1.jar");
			this.comboBox1.Items.Add("https://bitbucket.org/iBotPeaches/apktool/downloads/apktool_2.1.0.jar");
			this.comboBox1.Items.Add("https://bitbucket.org/iBotPeaches/apktool/downloads/apktool_2.0.3.jar");
			this.comboBox1.Items.Add("https://bitbucket.org/iBotPeaches/apktool/downloads/apktool_2.0.2.jar");
			this.comboBox1.Items.Add("https://bitbucket.org/iBotPeaches/apktool/downloads/apktool_2.0.1.jar");
			this.comboBox1.Items.Add("https://bitbucket.org/iBotPeaches/apktool/downloads/apktool_2.0.0.jar");
			this.comboBox1.Items.Add("https://lopper.fun/apktool/apktool_2.4.1.jar");
			this.comboBox1.Items.Add("https://lopper.fun/apktool/apktool_2.3.4.jar");
			this.comboBox1.SelectedIndex = 0;
			
			this.comboBox2.Items.Add("https://lopper.fun/apktool/apktool.bat");
			this.comboBox2.SelectedIndex = 0;
			
			this.button1.Click += new System.EventHandler(runDownloadJar);
			this.button2.Click += new System.EventHandler(runDownloadBat);
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private void runDownloadJar(object sender, EventArgs e) {
			if (System.IO.File.Exists(HomeForm.pathHome + @"\" + System.IO.Path.GetFileName(this.comboBox1.SelectedItem.ToString()))) {
				MessageBox.Show("Такой файл уже есть, перезаписать незовзможно, удалите своими руками!", "Ой!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else {
				if (this.comboBox2.SelectedItem.ToString().Equals("")) {
					MessageBox.Show("Выберите ссылку для загрузки!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				} else {
					using (WebClient wc = new WebClient()) {
				        wc.DownloadProgressChanged += wc_DownloadProgressChangedJar;
				        wc.DownloadFile(this.comboBox1.SelectedItem.ToString(), HomeForm.pathHome +  @"\" + System.IO.Path.GetFileName(this.comboBox1.SelectedItem.ToString()));
				    }
//					FileDownloader.DownloadFile(this.comboBox1.SelectedItem.ToString(), HomeForm.pathHome + HomeForm.pathApktoolJar, 99999);
				}
			}
			
//			WebClient webClient = new WebClient();
//			webClient.DownloadFile(this.comboBox1.SelectedItem.ToString(), HomeForm.pathHome + HomeForm.pathApktoolJar);
		}
		void wc_DownloadProgressChangedJar(object sender, DownloadProgressChangedEventArgs e) {
		    this.progressBar1.Value = e.ProgressPercentage;
		}
		
		private void runDownloadBat(object sender, EventArgs e) {
			if (System.IO.File.Exists(HomeForm.pathHome + HomeForm.pathApktoolBat)) {
				MessageBox.Show("Такой файл уже есть, перезаписать незовзможно, удалите своими руками!", "Ой!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else {
				if (this.comboBox2.SelectedItem.ToString().Equals("")) {
					MessageBox.Show("Выберите ссылку для загрузки!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				} else {
					using (WebClient wc = new WebClient()) {
				        wc.DownloadProgressChanged += wc_DownloadProgressChangedBat;
				        wc.DownloadFile(this.comboBox2.SelectedItem.ToString(), HomeForm.pathHome + HomeForm.pathApktoolBat);
				    }
//					FileDownloader.DownloadFile(this.comboBox2.SelectedItem.ToString(), HomeForm.pathHome + HomeForm.pathApktoolBat, 99988);
				}
			}
//			WebClient webClient = new WebClient();
//			webClient.DownloadFile(this.comboBox2.SelectedItem.ToString(), HomeForm.pathHome + HomeForm.pathApktoolBat);
		}
		void wc_DownloadProgressChangedBat(object sender, DownloadProgressChangedEventArgs e) {
		    this.progressBar2.Value = e.ProgressPercentage;
		}
	}
}
