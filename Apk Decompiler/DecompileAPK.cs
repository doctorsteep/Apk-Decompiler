/*
 * Создано в SharpDevelop.
 * Пользователь: Admin
 * Дата: 11.07.2020
 * Время: 5:41
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Apk_Decompiler
{
	/// <summary>
	/// Description of DecompileAPK.
	/// </summary>
	public partial class DecompileAPK : Form
	{
		private string resultNoExt = HomeForm.pathHome;
		
		public DecompileAPK()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			if (!System.IO.File.Exists(HomeForm.pathHome + HomeForm.pathApktoolBat)) {
				MessageBox.Show("Отсутствует инициализационный .bat файл! Возмоно вы забыли его скачать или скопировать в папку", "Ошибка!",  MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
			DisplayApk(HomeForm.pathHome);
			this.label1.Text = HomeForm.pathHome;
			this.comboBox1.SelectedIndex = 0;
			this.button3.Visible = false;
			this.button1.Click += new System.EventHandler(runDecompiling);
			this.button2.Click += new System.EventHandler(refreshApkFiles);
			this.button3.Click += new System.EventHandler(openPathDecompiled);
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private void openExplorerPath(object sub, EventHandler e) {
			
		}
		
		private void refreshApkFiles(object sender, EventArgs e) {
			DisplayApk(HomeForm.pathHome);
		}
		
		public void DisplayApk(string path) {
			this.comboBox1.Items.Clear();
			string[] files = System.IO.Directory.GetFiles(path);
			for (int x = 0; x < files.Length; x++) {
				if (System.IO.File.Exists(files[x]) && files[x].EndsWith(".apk")) {
					this.comboBox1.Items.Add(System.IO.Path.GetFileName(files[x]));
				}
			}
		}
		
		private void runDecompiling(object sender, EventArgs e) {
			if (!System.IO.File.Exists(HomeForm.pathHome + HomeForm.pathApktoolBat)) {
				MessageBox.Show("Не удалось найти исполнительный .bat файл!", "Ошибка!",  MessageBoxButtons.OK, MessageBoxIcon.Error);
			} else {
				try {
					string selectItemAPK = this.comboBox1.SelectedItem.ToString();
					string noExt = selectItemAPK.Replace(".apk", "");
					resultNoExt = HomeForm.pathHome + @"\" + noExt;
					string resultPathAPK = HomeForm.pathHome + @"\" + selectItemAPK;
					this.label1.Text = resultNoExt;
					button3.Visible = true;
					//MessageBox.Show(resultPathAPK);
					string cmdText = @"/k echo Maked by. ApkTool and DoctorSteep && cd " + HomeForm.pathHome + " && apktool d " + selectItemAPK;
					Process.Start("cmd.exe", cmdText);
				} catch (Exception ex) {
					MessageBox.Show("Что-то пошло не так, не удалось получить .apk файл!\n" + ex.ToString(), "Ошибка!",  MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		
		private void openPathDecompiled(object sender, EventArgs e) {
			Process.Start("explorer.exe", resultNoExt);
		}
	}
}
