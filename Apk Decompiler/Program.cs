/*
 * Создано в SharpDevelop.
 * Пользователь: Admin
 * Дата: 11.07.2020
 * Время: 2:45
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Windows.Forms;
using System.Threading;

namespace Apk_Decompiler
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Thread muthread;
			muthread = new Thread(new ThreadStart(ThreadLoop));
			muthread.Start();
			Thread.Sleep(5000);
			Application.Run(new HomeForm(muthread));
		}
		public static void ThreadLoop() {
			Application.Run(new MainForm());
		}
	}
}
