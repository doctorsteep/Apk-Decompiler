/*
 * Создано в SharpDevelop.
 * Пользователь: Admin
 * Дата: 11.07.2020
 * Время: 2:51
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace Apk_Decompiler
{
	partial class HomeForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripMenuItem decompileApkFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
		private System.Windows.Forms.ToolStripMenuItem devToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gitHubOpenSourceToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem apkToolToolStripMenuItem;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.decompileApkFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
			this.devToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gitHubOpenSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.apkToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.listView2 = new System.Windows.Forms.ListView();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripDropDownButton1,
			this.toolStripSeparator1,
			this.toolStripDropDownButton2});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
			this.toolStrip1.Size = new System.Drawing.Size(624, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.BackColor = System.Drawing.Color.Transparent;
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.decompileApkFileToolStripMenuItem});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.ShowDropDownArrow = false;
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(40, 22);
			this.toolStripDropDownButton1.Text = "Файл";
			// 
			// decompileApkFileToolStripMenuItem
			// 
			this.decompileApkFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("decompileApkFileToolStripMenuItem.Image")));
			this.decompileApkFileToolStripMenuItem.Name = "decompileApkFileToolStripMenuItem";
			this.decompileApkFileToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
			this.decompileApkFileToolStripMenuItem.Text = "Декомпилировать .apk файл";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripDropDownButton2
			// 
			this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.devToolStripMenuItem,
			this.gitHubOpenSourceToolStripMenuItem,
			this.apkToolToolStripMenuItem});
			this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
			this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
			this.toolStripDropDownButton2.ShowDropDownArrow = false;
			this.toolStripDropDownButton2.Size = new System.Drawing.Size(86, 22);
			this.toolStripDropDownButton2.Text = "О программе";
			// 
			// devToolStripMenuItem
			// 
			this.devToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("devToolStripMenuItem.Image")));
			this.devToolStripMenuItem.Name = "devToolStripMenuItem";
			this.devToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			this.devToolStripMenuItem.Text = "Разработчик";
			// 
			// gitHubOpenSourceToolStripMenuItem
			// 
			this.gitHubOpenSourceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gitHubOpenSourceToolStripMenuItem.Image")));
			this.gitHubOpenSourceToolStripMenuItem.Name = "gitHubOpenSourceToolStripMenuItem";
			this.gitHubOpenSourceToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			this.gitHubOpenSourceToolStripMenuItem.Text = "GitHub Open Source";
			// 
			// apkToolToolStripMenuItem
			// 
			this.apkToolToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("apkToolToolStripMenuItem.Image")));
			this.apkToolToolStripMenuItem.Name = "apkToolToolStripMenuItem";
			this.apkToolToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			this.apkToolToolStripMenuItem.Text = "ApkTool";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(13, 38);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(599, 92);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.groupBox1);
			this.flowLayoutPanel1.Controls.Add(this.groupBox2);
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 178);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(599, 252);
			this.flowLayoutPanel1.TabIndex = 2;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.listView1);
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(290, 252);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			this.groupBox1.Enter += new System.EventHandler(this.GroupBox1Enter);
			// 
			// listView1
			// 
			this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
			this.listView1.AutoArrange = false;
			this.listView1.Location = new System.Drawing.Point(7, 20);
			this.listView1.Name = "listView1";
			this.listView1.ShowItemToolTips = true;
			this.listView1.Size = new System.Drawing.Size(278, 226);
			this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.SmallIcon;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.listView2);
			this.groupBox2.Location = new System.Drawing.Point(290, 0);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(308, 252);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "groupBox2";
			// 
			// listView2
			// 
			this.listView2.Alignment = System.Windows.Forms.ListViewAlignment.Left;
			this.listView2.AutoArrange = false;
			this.listView2.Location = new System.Drawing.Point(7, 20);
			this.listView2.Name = "listView2";
			this.listView2.ShowItemToolTips = true;
			this.listView2.Size = new System.Drawing.Size(295, 226);
			this.listView2.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.listView2.TabIndex = 0;
			this.listView2.UseCompatibleStateImageBehavior = false;
			this.listView2.View = System.Windows.Forms.View.SmallIcon;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(469, 143);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(143, 26);
			this.button1.TabIndex = 3;
			this.button1.Text = "Загрузить ресурсы";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(320, 143);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(143, 26);
			this.button2.TabIndex = 4;
			this.button2.Text = "Обновить списки";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// HomeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(624, 442);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.toolStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "HomeForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Apk Decompiler";
			this.Load += new System.EventHandler(this.HomeFormLoad);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
