/*
 * Created by SharpDevelop.
 * User: This
 * Date: 11/10/2013
 * Time: 6:24 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace kiosBunga
{
	partial class FormStokBunga
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridView1_StokBunga = new System.Windows.Forms.DataGridView();
			this.textBox1_Nama = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1_Cari = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.button1_Pilih = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1_StokBunga)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1_StokBunga
			// 
			this.dataGridView1_StokBunga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1_StokBunga.Location = new System.Drawing.Point(2, 0);
			this.dataGridView1_StokBunga.Name = "dataGridView1_StokBunga";
			this.dataGridView1_StokBunga.Size = new System.Drawing.Size(597, 173);
			this.dataGridView1_StokBunga.TabIndex = 1;
			this.dataGridView1_StokBunga.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_StokBungaCellClick);
			// 
			// textBox1_Nama
			// 
			this.textBox1_Nama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1_Nama.Location = new System.Drawing.Point(77, 28);
			this.textBox1_Nama.Name = "textBox1_Nama";
			this.textBox1_Nama.Size = new System.Drawing.Size(160, 20);
			this.textBox1_Nama.TabIndex = 5;
			this.textBox1_Nama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1_NamaKeyDown);
			this.textBox1_Nama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_NamaKeyPress);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(10, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Nama Bunga";
			// 
			// button1_Cari
			// 
			this.button1_Cari.Location = new System.Drawing.Point(243, 27);
			this.button1_Cari.Name = "button1_Cari";
			this.button1_Cari.Size = new System.Drawing.Size(75, 23);
			this.button1_Cari.TabIndex = 3;
			this.button1_Cari.Text = "Cari";
			this.button1_Cari.UseVisualStyleBackColor = true;
			this.button1_Cari.Click += new System.EventHandler(this.Button1_CariClick);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Location = new System.Drawing.Point(12, 179);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(422, 125);
			this.tabControl1.TabIndex = 8;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.button1_Pilih);
			this.tabPage1.Controls.Add(this.textBox1_Nama);
			this.tabPage1.Controls.Add(this.button1_Cari);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(414, 99);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Cari Berdasarkan Nama";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// button1_Pilih
			// 
			this.button1_Pilih.Location = new System.Drawing.Point(324, 27);
			this.button1_Pilih.Name = "button1_Pilih";
			this.button1_Pilih.Size = new System.Drawing.Size(75, 23);
			this.button1_Pilih.TabIndex = 6;
			this.button1_Pilih.Text = "Pilih";
			this.button1_Pilih.UseVisualStyleBackColor = true;
			this.button1_Pilih.Click += new System.EventHandler(this.Button1_PilihClick);
			// 
			// FormStokBunga
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(601, 316);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.dataGridView1_StokBunga);
			this.MaximizeBox = false;
			this.Name = "FormStokBunga";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.TopMost = true;
			this.Load += new System.EventHandler(this.FormStokBungaLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1_StokBunga)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button1_Pilih;
		private System.Windows.Forms.DataGridView dataGridView1_StokBunga;
		private System.Windows.Forms.TextBox textBox1_Nama;
		private System.Windows.Forms.Button button1_Cari;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Label label1;
		
		
	}
}
