/*
 * Created by SharpDevelop.
 * User: This
 * Date: 11/7/2013
 * Time: 10:52 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace kiosBunga
{
	partial class FormUtamaAdmin
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1_userLogin = new System.Windows.Forms.TextBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button7_Cari = new System.Windows.Forms.Button();
			this.button6_Refresh = new System.Windows.Forms.Button();
			this.textBox1_KodeBunga = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox4_HargaJual = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.button6_Cetak = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.button7_Hapus = new System.Windows.Forms.Button();
			this.textBox1_NamaBunga = new System.Windows.Forms.TextBox();
			this.button8_Rubah = new System.Windows.Forms.Button();
			this.textBox2_HargaPokok = new System.Windows.Forms.TextBox();
			this.button9_BungaSimpan = new System.Windows.Forms.Button();
			this.textBox3_StokBunga = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.textBox1_Awal62 = new System.Windows.Forms.TextBox();
			this.textBox3_NamaUser = new System.Windows.Forms.TextBox();
			this.textBox2_Telepon = new System.Windows.Forms.TextBox();
			this.textBox1_KodeUser = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.button6_Refressh = new System.Windows.Forms.Button();
			this.button5_CetakUser = new System.Windows.Forms.Button();
			this.button4_HapusUser = new System.Windows.Forms.Button();
			this.button3_RubahUser = new System.Windows.Forms.Button();
			this.button2_CariUser = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1_SimpanUser = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1_Password = new System.Windows.Forms.TextBox();
			this.textBox2_User = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.button1_refreshPenjualan = new System.Windows.Forms.Button();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.button11_penghasilan = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.textBox1_PendapatanPerBulan = new System.Windows.Forms.TextBox();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(151, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Selamat Datang. Bapak / Ibu";
			// 
			// textBox1_userLogin
			// 
			this.textBox1_userLogin.BackColor = System.Drawing.SystemColors.Control;
			this.textBox1_userLogin.CausesValidation = false;
			this.textBox1_userLogin.Cursor = System.Windows.Forms.Cursors.Default;
			this.textBox1_userLogin.Location = new System.Drawing.Point(164, 6);
			this.textBox1_userLogin.Name = "textBox1_userLogin";
			this.textBox1_userLogin.ReadOnly = true;
			this.textBox1_userLogin.Size = new System.Drawing.Size(364, 20);
			this.textBox1_userLogin.TabIndex = 90;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(13, 35);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(516, 221);
			this.tabControl1.TabIndex = 2;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(508, 195);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Bunga";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button7_Cari);
			this.groupBox1.Controls.Add(this.button6_Refresh);
			this.groupBox1.Controls.Add(this.textBox1_KodeBunga);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.textBox4_HargaJual);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.button6_Cetak);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.button7_Hapus);
			this.groupBox1.Controls.Add(this.textBox1_NamaBunga);
			this.groupBox1.Controls.Add(this.button8_Rubah);
			this.groupBox1.Controls.Add(this.textBox2_HargaPokok);
			this.groupBox1.Controls.Add(this.button9_BungaSimpan);
			this.groupBox1.Controls.Add(this.textBox3_StokBunga);
			this.groupBox1.Location = new System.Drawing.Point(6, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(496, 180);
			this.groupBox1.TabIndex = 91;
			this.groupBox1.TabStop = false;
			// 
			// button7_Cari
			// 
			this.button7_Cari.Location = new System.Drawing.Point(260, 84);
			this.button7_Cari.Name = "button7_Cari";
			this.button7_Cari.Size = new System.Drawing.Size(104, 32);
			this.button7_Cari.TabIndex = 22;
			this.button7_Cari.Text = "Cari";
			this.button7_Cari.UseVisualStyleBackColor = true;
			this.button7_Cari.Click += new System.EventHandler(this.Button7_CariClick);
			// 
			// button6_Refresh
			// 
			this.button6_Refresh.Location = new System.Drawing.Point(370, 84);
			this.button6_Refresh.Name = "button6_Refresh";
			this.button6_Refresh.Size = new System.Drawing.Size(104, 32);
			this.button6_Refresh.TabIndex = 21;
			this.button6_Refresh.Text = "Refresh";
			this.button6_Refresh.UseVisualStyleBackColor = true;
			this.button6_Refresh.Click += new System.EventHandler(this.Button6_RefreshClick);
			// 
			// textBox1_KodeBunga
			// 
			this.textBox1_KodeBunga.Location = new System.Drawing.Point(112, 16);
			this.textBox1_KodeBunga.Name = "textBox1_KodeBunga";
			this.textBox1_KodeBunga.Size = new System.Drawing.Size(130, 20);
			this.textBox1_KodeBunga.TabIndex = 1;
			this.textBox1_KodeBunga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KodeBungaKeyPress);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(15, 19);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(88, 23);
			this.label9.TabIndex = 19;
			this.label9.Text = "Kode Bunga";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(251, 45);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(72, 23);
			this.label8.TabIndex = 18;
			this.label8.Text = "Harga Jual";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(15, 71);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 23);
			this.label7.TabIndex = 2;
			this.label7.Text = "Stok Bunga";
			// 
			// textBox4_HargaJual
			// 
			this.textBox4_HargaJual.Location = new System.Drawing.Point(336, 42);
			this.textBox4_HargaJual.Name = "textBox4_HargaJual";
			this.textBox4_HargaJual.Size = new System.Drawing.Size(130, 20);
			this.textBox4_HargaJual.TabIndex = 17;
			this.textBox4_HargaJual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox4_HargaJualKeyPress);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(15, 45);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 23);
			this.label5.TabIndex = 0;
			this.label5.Text = "Nama Bunga";
			// 
			// button6_Cetak
			// 
			this.button6_Cetak.Location = new System.Drawing.Point(370, 135);
			this.button6_Cetak.Name = "button6_Cetak";
			this.button6_Cetak.Size = new System.Drawing.Size(113, 38);
			this.button6_Cetak.TabIndex = 15;
			this.button6_Cetak.Text = "Cetak";
			this.button6_Cetak.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(251, 19);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(79, 23);
			this.label6.TabIndex = 1;
			this.label6.Text = "Harga Pokok";
			// 
			// button7_Hapus
			// 
			this.button7_Hapus.Location = new System.Drawing.Point(251, 135);
			this.button7_Hapus.Name = "button7_Hapus";
			this.button7_Hapus.Size = new System.Drawing.Size(113, 38);
			this.button7_Hapus.TabIndex = 14;
			this.button7_Hapus.Text = "Hapus";
			this.button7_Hapus.UseVisualStyleBackColor = true;
			this.button7_Hapus.Click += new System.EventHandler(this.Button7_HapusClick);
			// 
			// textBox1_NamaBunga
			// 
			this.textBox1_NamaBunga.Location = new System.Drawing.Point(112, 42);
			this.textBox1_NamaBunga.Name = "textBox1_NamaBunga";
			this.textBox1_NamaBunga.Size = new System.Drawing.Size(130, 20);
			this.textBox1_NamaBunga.TabIndex = 3;
			this.textBox1_NamaBunga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_NamaBungaKeyPress);
			// 
			// button8_Rubah
			// 
			this.button8_Rubah.Location = new System.Drawing.Point(132, 135);
			this.button8_Rubah.Name = "button8_Rubah";
			this.button8_Rubah.Size = new System.Drawing.Size(113, 38);
			this.button8_Rubah.TabIndex = 13;
			this.button8_Rubah.Text = "Rubah";
			this.button8_Rubah.UseVisualStyleBackColor = true;
			this.button8_Rubah.Click += new System.EventHandler(this.Button8_RubahClick);
			// 
			// textBox2_HargaPokok
			// 
			this.textBox2_HargaPokok.Location = new System.Drawing.Point(336, 16);
			this.textBox2_HargaPokok.Name = "textBox2_HargaPokok";
			this.textBox2_HargaPokok.Size = new System.Drawing.Size(130, 20);
			this.textBox2_HargaPokok.TabIndex = 4;
			this.textBox2_HargaPokok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2_HargaPokokKeyPress);
			// 
			// button9_BungaSimpan
			// 
			this.button9_BungaSimpan.Location = new System.Drawing.Point(13, 135);
			this.button9_BungaSimpan.Name = "button9_BungaSimpan";
			this.button9_BungaSimpan.Size = new System.Drawing.Size(113, 38);
			this.button9_BungaSimpan.TabIndex = 12;
			this.button9_BungaSimpan.Text = "Simpan";
			this.button9_BungaSimpan.UseVisualStyleBackColor = true;
			this.button9_BungaSimpan.Click += new System.EventHandler(this.Button9_BungaSimpanClick);
			// 
			// textBox3_StokBunga
			// 
			this.textBox3_StokBunga.Location = new System.Drawing.Point(112, 68);
			this.textBox3_StokBunga.Name = "textBox3_StokBunga";
			this.textBox3_StokBunga.Size = new System.Drawing.Size(130, 20);
			this.textBox3_StokBunga.TabIndex = 5;
			this.textBox3_StokBunga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox3_StokBungaKeyPress);
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage2.Controls.Add(this.textBox1_Awal62);
			this.tabPage2.Controls.Add(this.textBox3_NamaUser);
			this.tabPage2.Controls.Add(this.textBox2_Telepon);
			this.tabPage2.Controls.Add(this.textBox1_KodeUser);
			this.tabPage2.Controls.Add(this.label14);
			this.tabPage2.Controls.Add(this.label13);
			this.tabPage2.Controls.Add(this.label12);
			this.tabPage2.Controls.Add(this.button6_Refressh);
			this.tabPage2.Controls.Add(this.button5_CetakUser);
			this.tabPage2.Controls.Add(this.button4_HapusUser);
			this.tabPage2.Controls.Add(this.button3_RubahUser);
			this.tabPage2.Controls.Add(this.button2_CariUser);
			this.tabPage2.Controls.Add(this.comboBox1);
			this.tabPage2.Controls.Add(this.button1_SimpanUser);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.textBox1_Password);
			this.tabPage2.Controls.Add(this.textBox2_User);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(508, 195);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Tambah UserLogin";
			// 
			// textBox1_Awal62
			// 
			this.textBox1_Awal62.Location = new System.Drawing.Point(231, 57);
			this.textBox1_Awal62.Name = "textBox1_Awal62";
			this.textBox1_Awal62.ReadOnly = true;
			this.textBox1_Awal62.Size = new System.Drawing.Size(31, 20);
			this.textBox1_Awal62.TabIndex = 54;
			this.textBox1_Awal62.Text = "+62";
			// 
			// textBox3_NamaUser
			// 
			this.textBox3_NamaUser.Location = new System.Drawing.Point(260, 87);
			this.textBox3_NamaUser.Name = "textBox3_NamaUser";
			this.textBox3_NamaUser.Size = new System.Drawing.Size(100, 20);
			this.textBox3_NamaUser.TabIndex = 28;
			// 
			// textBox2_Telepon
			// 
			this.textBox2_Telepon.Location = new System.Drawing.Point(260, 57);
			this.textBox2_Telepon.Name = "textBox2_Telepon";
			this.textBox2_Telepon.Size = new System.Drawing.Size(100, 20);
			this.textBox2_Telepon.TabIndex = 27;
			// 
			// textBox1_KodeUser
			// 
			this.textBox1_KodeUser.Location = new System.Drawing.Point(260, 29);
			this.textBox1_KodeUser.Name = "textBox1_KodeUser";
			this.textBox1_KodeUser.Size = new System.Drawing.Size(100, 20);
			this.textBox1_KodeUser.TabIndex = 26;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(185, 85);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(56, 23);
			this.label14.TabIndex = 25;
			this.label14.Text = "Nama";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(182, 59);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(48, 23);
			this.label13.TabIndex = 24;
			this.label13.Text = "Telepon";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(185, 31);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(47, 23);
			this.label12.TabIndex = 23;
			this.label12.Text = "Kode";
			// 
			// button6_Refressh
			// 
			this.button6_Refressh.Location = new System.Drawing.Point(387, 72);
			this.button6_Refressh.Name = "button6_Refressh";
			this.button6_Refressh.Size = new System.Drawing.Size(98, 35);
			this.button6_Refressh.TabIndex = 22;
			this.button6_Refressh.Text = "Refresh";
			this.button6_Refressh.UseVisualStyleBackColor = true;
			this.button6_Refressh.Click += new System.EventHandler(this.Button6_RefresshClick);
			// 
			// button5_CetakUser
			// 
			this.button5_CetakUser.Location = new System.Drawing.Point(372, 147);
			this.button5_CetakUser.Name = "button5_CetakUser";
			this.button5_CetakUser.Size = new System.Drawing.Size(113, 38);
			this.button5_CetakUser.TabIndex = 11;
			this.button5_CetakUser.Text = "Cetak";
			this.button5_CetakUser.UseVisualStyleBackColor = true;
			// 
			// button4_HapusUser
			// 
			this.button4_HapusUser.Location = new System.Drawing.Point(253, 147);
			this.button4_HapusUser.Name = "button4_HapusUser";
			this.button4_HapusUser.Size = new System.Drawing.Size(113, 38);
			this.button4_HapusUser.TabIndex = 10;
			this.button4_HapusUser.Text = "Hapus";
			this.button4_HapusUser.UseVisualStyleBackColor = true;
			this.button4_HapusUser.Click += new System.EventHandler(this.Button4_HapusUserClick);
			// 
			// button3_RubahUser
			// 
			this.button3_RubahUser.Location = new System.Drawing.Point(134, 147);
			this.button3_RubahUser.Name = "button3_RubahUser";
			this.button3_RubahUser.Size = new System.Drawing.Size(113, 38);
			this.button3_RubahUser.TabIndex = 9;
			this.button3_RubahUser.Text = "Rubah";
			this.button3_RubahUser.UseVisualStyleBackColor = true;
			this.button3_RubahUser.Click += new System.EventHandler(this.Button3_RubahUserClick);
			// 
			// button2_CariUser
			// 
			this.button2_CariUser.Location = new System.Drawing.Point(387, 28);
			this.button2_CariUser.Name = "button2_CariUser";
			this.button2_CariUser.Size = new System.Drawing.Size(98, 38);
			this.button2_CariUser.TabIndex = 8;
			this.button2_CariUser.Text = "Cari";
			this.button2_CariUser.UseVisualStyleBackColor = true;
			this.button2_CariUser.Click += new System.EventHandler(this.Button2_CariUserClick);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"Karyawan",
									"Administrator"});
			this.comboBox1.Location = new System.Drawing.Point(79, 89);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(100, 21);
			this.comboBox1.TabIndex = 7;
			this.comboBox1.Text = "Karyawan";
			// 
			// button1_SimpanUser
			// 
			this.button1_SimpanUser.Location = new System.Drawing.Point(15, 147);
			this.button1_SimpanUser.Name = "button1_SimpanUser";
			this.button1_SimpanUser.Size = new System.Drawing.Size(113, 38);
			this.button1_SimpanUser.TabIndex = 6;
			this.button1_SimpanUser.Text = "Simpan";
			this.button1_SimpanUser.UseVisualStyleBackColor = true;
			this.button1_SimpanUser.Click += new System.EventHandler(this.Button1_SimpanUserClick);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(10, 87);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Status";
			// 
			// textBox1_Password
			// 
			this.textBox1_Password.Location = new System.Drawing.Point(79, 58);
			this.textBox1_Password.Name = "textBox1_Password";
			this.textBox1_Password.Size = new System.Drawing.Size(100, 20);
			this.textBox1_Password.TabIndex = 2;
			// 
			// textBox2_User
			// 
			this.textBox2_User.Location = new System.Drawing.Point(79, 29);
			this.textBox2_User.Name = "textBox2_User";
			this.textBox2_User.Size = new System.Drawing.Size(100, 20);
			this.textBox2_User.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(10, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 23);
			this.label3.TabIndex = 1;
			this.label3.Text = "Password";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(10, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Username";
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage3.Controls.Add(this.groupBox2);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(508, 195);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Laporan";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label16);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.button1_refreshPenjualan);
			this.groupBox2.Controls.Add(this.dateTimePicker2);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.button11_penghasilan);
			this.groupBox2.Controls.Add(this.dateTimePicker1);
			this.groupBox2.Controls.Add(this.textBox1_PendapatanPerBulan);
			this.groupBox2.Location = new System.Drawing.Point(15, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(469, 186);
			this.groupBox2.TabIndex = 14;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Jumlah Pendapatan";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(24, 68);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(52, 23);
			this.label16.TabIndex = 19;
			this.label16.Text = "Sampai";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(26, 39);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(50, 23);
			this.label15.TabIndex = 18;
			this.label15.Text = "Dari";
			// 
			// button1_refreshPenjualan
			// 
			this.button1_refreshPenjualan.Location = new System.Drawing.Point(309, 56);
			this.button1_refreshPenjualan.Name = "button1_refreshPenjualan";
			this.button1_refreshPenjualan.Size = new System.Drawing.Size(130, 34);
			this.button1_refreshPenjualan.TabIndex = 17;
			this.button1_refreshPenjualan.Text = "Refresh";
			this.button1_refreshPenjualan.UseVisualStyleBackColor = true;
			this.button1_refreshPenjualan.Click += new System.EventHandler(this.Button1_refreshPenjualanClick);
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(84, 70);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker2.TabIndex = 16;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(46, 143);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(26, 23);
			this.label11.TabIndex = 15;
			this.label11.Text = "Rp:";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(51, 116);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(195, 23);
			this.label10.TabIndex = 14;
			this.label10.Text = "Total Pendapatan PerBulan";
			// 
			// button11_penghasilan
			// 
			this.button11_penghasilan.Location = new System.Drawing.Point(308, 121);
			this.button11_penghasilan.Name = "button11_penghasilan";
			this.button11_penghasilan.Size = new System.Drawing.Size(131, 41);
			this.button11_penghasilan.TabIndex = 8;
			this.button11_penghasilan.Text = "Penghasilan";
			this.button11_penghasilan.UseVisualStyleBackColor = true;
			this.button11_penghasilan.Click += new System.EventHandler(this.Button11_penghasilanClick);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(84, 36);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 12;
			// 
			// textBox1_PendapatanPerBulan
			// 
			this.textBox1_PendapatanPerBulan.Location = new System.Drawing.Point(71, 142);
			this.textBox1_PendapatanPerBulan.Name = "textBox1_PendapatanPerBulan";
			this.textBox1_PendapatanPerBulan.Size = new System.Drawing.Size(175, 20);
			this.textBox1_PendapatanPerBulan.TabIndex = 13;
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(12, 258);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(516, 155);
			this.dataGridView2.TabIndex = 6;
			// 
			// FormUtamaAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(544, 425);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.textBox1_userLogin);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.Name = "FormUtamaAdmin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Control Panel Admin Kios Bunga";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.FormUtamaAdminLoad);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUtamaAdminFormClosed);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1_refreshPenjualan;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.TextBox textBox1_Awal62;
		private System.Windows.Forms.TextBox textBox1_KodeUser;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox textBox2_Telepon;
		private System.Windows.Forms.TextBox textBox3_NamaUser;
		private System.Windows.Forms.Button button5_CetakUser;
		private System.Windows.Forms.Button button4_HapusUser;
		private System.Windows.Forms.Button button3_RubahUser;
		private System.Windows.Forms.Button button2_CariUser;
		private System.Windows.Forms.Button button1_SimpanUser;
		private System.Windows.Forms.Button button6_Refressh;
		private System.Windows.Forms.TextBox textBox1_PendapatanPerBulan;
		private System.Windows.Forms.Button button11_penghasilan;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Button button6_Refresh;
		private System.Windows.Forms.Button button7_Cari;
		private System.Windows.Forms.Button button6_Cetak;
		private System.Windows.Forms.Button button7_Hapus;
		private System.Windows.Forms.Button button8_Rubah;
		private System.Windows.Forms.Button button9_BungaSimpan;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox1_KodeBunga;
		private System.Windows.Forms.TextBox textBox4_HargaJual;
		private System.Windows.Forms.TextBox textBox3_StokBunga;
		private System.Windows.Forms.TextBox textBox2_HargaPokok;
		private System.Windows.Forms.TextBox textBox1_NamaBunga;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox2_User;
		private System.Windows.Forms.TextBox textBox1_Password;
		private System.Windows.Forms.TextBox textBox1_userLogin;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Label label1;
		
		
		
		
		
		
		
	}
}
