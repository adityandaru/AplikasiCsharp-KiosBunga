/*
 * Created by SharpDevelop.
 * User: This
 * Date: 11/10/2013
 * Time: 1:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace kiosBunga
{
	partial class FormDataPelangan
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
			this.textBox1_Nama = new System.Windows.Forms.TextBox();
			this.textBox2_NomerHp = new System.Windows.Forms.TextBox();
			this.textBox3_Alamat = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox4_ID = new System.Windows.Forms.TextBox();
			this.dataGridView1_FormDataPelanggan = new System.Windows.Forms.DataGridView();
			this.button14 = new System.Windows.Forms.Button();
			this.button15 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.button5 = new System.Windows.Forms.Button();
			this.button3_Pilih = new System.Windows.Forms.Button();
			this.button1_Simpan = new System.Windows.Forms.Button();
			this.button2_Refresh = new System.Windows.Forms.Button();
			this.textBox1_Awal62 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1_FormDataPelanggan)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1_Nama
			// 
			this.textBox1_Nama.Location = new System.Drawing.Point(99, 36);
			this.textBox1_Nama.Name = "textBox1_Nama";
			this.textBox1_Nama.Size = new System.Drawing.Size(209, 20);
			this.textBox1_Nama.TabIndex = 3;
			this.textBox1_Nama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_NamaKeyPress);
			// 
			// textBox2_NomerHp
			// 
			this.textBox2_NomerHp.Location = new System.Drawing.Point(136, 62);
			this.textBox2_NomerHp.MaxLength = 11;
			this.textBox2_NomerHp.Name = "textBox2_NomerHp";
			this.textBox2_NomerHp.Size = new System.Drawing.Size(172, 20);
			this.textBox2_NomerHp.TabIndex = 4;
			this.textBox2_NomerHp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2_NomerHpKeyPress);
			// 
			// textBox3_Alamat
			// 
			this.textBox3_Alamat.Location = new System.Drawing.Point(99, 88);
			this.textBox3_Alamat.Multiline = true;
			this.textBox3_Alamat.Name = "textBox3_Alamat";
			this.textBox3_Alamat.Size = new System.Drawing.Size(330, 83);
			this.textBox3_Alamat.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Nama";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Nomer Hp";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Alamat";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 14);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "ID";
			// 
			// textBox4_ID
			// 
			this.textBox4_ID.Location = new System.Drawing.Point(99, 11);
			this.textBox4_ID.Name = "textBox4_ID";
			this.textBox4_ID.Size = new System.Drawing.Size(125, 20);
			this.textBox4_ID.TabIndex = 1;
			this.textBox4_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox4_IDKeyDown);
			this.textBox4_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox4_IDKeyPress);
			// 
			// dataGridView1_FormDataPelanggan
			// 
			this.dataGridView1_FormDataPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1_FormDataPelanggan.Location = new System.Drawing.Point(8, 226);
			this.dataGridView1_FormDataPelanggan.Name = "dataGridView1_FormDataPelanggan";
			this.dataGridView1_FormDataPelanggan.Size = new System.Drawing.Size(421, 109);
			this.dataGridView1_FormDataPelanggan.TabIndex = 9;
			this.dataGridView1_FormDataPelanggan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_FormDataPelangganCellClick);
			// 
			// button14
			// 
			this.button14.Location = new System.Drawing.Point(341, 17);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(184, 59);
			this.button14.TabIndex = 28;
			this.button14.Text = "Refresh";
			this.button14.UseVisualStyleBackColor = true;
			// 
			// button15
			// 
			this.button15.Location = new System.Drawing.Point(246, 10);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(75, 24);
			this.button15.TabIndex = 26;
			this.button15.Text = "Cari";
			this.button15.UseVisualStyleBackColor = true;
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(374, 197);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(75, 32);
			this.button8.TabIndex = 25;
			this.button8.Text = "Cetak";
			this.button8.UseVisualStyleBackColor = true;
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(283, 197);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(75, 32);
			this.button9.TabIndex = 24;
			this.button9.Text = "Hapus";
			this.button9.UseVisualStyleBackColor = true;
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(193, 197);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(75, 32);
			this.button7.TabIndex = 23;
			this.button7.Text = "Rubah";
			this.button7.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(102, 197);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 32);
			this.button6.TabIndex = 22;
			this.button6.Text = "Simpan";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// textBox5
			// 
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox5.Location = new System.Drawing.Point(111, 13);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(125, 20);
			this.textBox5.TabIndex = 21;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(20, 17);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(85, 23);
			this.label14.TabIndex = 20;
			this.label14.Text = "ID";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(20, 94);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(85, 23);
			this.label15.TabIndex = 19;
			this.label15.Text = "Alamat";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(20, 68);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(85, 23);
			this.label16.TabIndex = 18;
			this.label16.Text = "Nomer Hp";
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(20, 42);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(85, 23);
			this.label17.TabIndex = 17;
			this.label17.Text = "Nama";
			// 
			// textBox6
			// 
			this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox6.Location = new System.Drawing.Point(111, 91);
			this.textBox6.Multiline = true;
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(414, 89);
			this.textBox6.TabIndex = 16;
			// 
			// textBox7
			// 
			this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox7.Location = new System.Drawing.Point(111, 65);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(209, 20);
			this.textBox7.TabIndex = 15;
			// 
			// textBox8
			// 
			this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox8.Location = new System.Drawing.Point(111, 39);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(209, 20);
			this.textBox8.TabIndex = 14;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(233, 8);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 2;
			this.button5.Text = "Cari";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button3_Pilih
			// 
			this.button3_Pilih.Location = new System.Drawing.Point(51, 186);
			this.button3_Pilih.Name = "button3_Pilih";
			this.button3_Pilih.Size = new System.Drawing.Size(100, 30);
			this.button3_Pilih.TabIndex = 6;
			this.button3_Pilih.Text = "Pilih";
			this.button3_Pilih.UseVisualStyleBackColor = true;
			this.button3_Pilih.Click += new System.EventHandler(this.Button3_PilihClick);
			// 
			// button1_Simpan
			// 
			this.button1_Simpan.Location = new System.Drawing.Point(170, 186);
			this.button1_Simpan.Name = "button1_Simpan";
			this.button1_Simpan.Size = new System.Drawing.Size(100, 30);
			this.button1_Simpan.TabIndex = 7;
			this.button1_Simpan.Text = "Simpan";
			this.button1_Simpan.UseVisualStyleBackColor = true;
			this.button1_Simpan.Click += new System.EventHandler(this.Button1_SimpanClick);
			// 
			// button2_Refresh
			// 
			this.button2_Refresh.Location = new System.Drawing.Point(290, 186);
			this.button2_Refresh.Name = "button2_Refresh";
			this.button2_Refresh.Size = new System.Drawing.Size(100, 30);
			this.button2_Refresh.TabIndex = 8;
			this.button2_Refresh.Text = "Refresh";
			this.button2_Refresh.UseVisualStyleBackColor = true;
			this.button2_Refresh.Click += new System.EventHandler(this.Button2_RefreshClick);
			// 
			// textBox1_Awal62
			// 
			this.textBox1_Awal62.Location = new System.Drawing.Point(99, 62);
			this.textBox1_Awal62.Name = "textBox1_Awal62";
			this.textBox1_Awal62.ReadOnly = true;
			this.textBox1_Awal62.Size = new System.Drawing.Size(31, 20);
			this.textBox1_Awal62.TabIndex = 10;
			this.textBox1_Awal62.Text = "+62";
			// 
			// FormDataPelangan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(440, 347);
			this.Controls.Add(this.textBox1_Awal62);
			this.Controls.Add(this.button2_Refresh);
			this.Controls.Add(this.button1_Simpan);
			this.Controls.Add(this.button3_Pilih);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.dataGridView1_FormDataPelanggan);
			this.Controls.Add(this.textBox4_ID);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox3_Alamat);
			this.Controls.Add(this.textBox2_NomerHp);
			this.Controls.Add(this.textBox1_Nama);
			this.Name = "FormDataPelangan";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.TopMost = true;
			this.Load += new System.EventHandler(this.FormDataPelanganLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1_FormDataPelanggan)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridView dataGridView1_FormDataPelanggan;
		private System.Windows.Forms.TextBox textBox1_Awal62;
		private System.Windows.Forms.Button button1_Simpan;
		private System.Windows.Forms.TextBox textBox1_Nama;
		private System.Windows.Forms.TextBox textBox2_NomerHp;
		private System.Windows.Forms.TextBox textBox3_Alamat;
		private System.Windows.Forms.TextBox textBox4_ID;
		private System.Windows.Forms.Button button2_Refresh;
		private System.Windows.Forms.Button button3_Pilih;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		
		
	}
}
