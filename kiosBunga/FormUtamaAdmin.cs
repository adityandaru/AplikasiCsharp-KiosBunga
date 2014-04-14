/*
 * Created by SharpDevelop.
 * User: This
 * Date: 11/7/2013
 * Time: 10:52 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace kiosBunga
{
	/// <summary>
	/// Description of FormUtamaAdmin.
	/// </summary>
	public partial class FormUtamaAdmin : Form
	{
		public string namaLogin;
		private DataSet ds;
		
		
		public FormUtamaAdmin()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void FormUtamaAdminLoad(object sender, EventArgs e)
		{
			try {
				tmp = 0;
				kosong1 = "";
				kosong2 = "";
				kosong3 = "";
				kosong4 = "";
				kosong5 = "";
				
				textBox1_userLogin.Text = namaLogin;
			
				button7_Cari.Enabled = false;				
				button9_BungaSimpan.Enabled=false;
				
				
				button6_Cetak.Enabled=true;
				button7_Hapus.Enabled=false;				
				button8_Rubah.Enabled=false;
				button3_RubahUser.Enabled = false;
				button4_HapusUser.Enabled = false;
				button1_SimpanUser.Enabled = true;
				
				
				
				button2_CariUser.Enabled = true;
				button5_CetakUser.Enabled = true;
				textBox1_KodeBunga.Focus();
				textBox1_KodeBunga.Clear();
				textBox1_NamaBunga.Clear();
				textBox3_StokBunga.Clear();
				textBox2_HargaPokok.Clear();
				textBox4_HargaJual.Clear();
				textBox2_User.Clear();
				textBox2_Telepon.Clear();
				textBox1_Password.Clear();
				textBox1_KodeUser.Clear();
				textBox2_User.Clear();
				textBox3_NamaUser.Clear();
				
				textBox1_KodeBunga.Enabled=true;
				textBox1_NamaBunga.Enabled = true;
				textBox3_StokBunga.Enabled = true;
				textBox2_HargaPokok.Enabled = true;
				textBox4_HargaJual.Enabled = true;
				textBox2_User.Enabled=true;
				textBox3_NamaUser.Enabled=true;
				textBox2_Telepon.Enabled=true;
				textBox1_Password.Enabled=true;
				textBox1_KodeUser.Enabled=true;
				textBox1_PendapatanPerBulan.Clear();
				
				ds = Koneksi.InstanceKoneksi().GetDataStokBunga("");
				dataGridView2.DataSource = ds.Tables[0];
				dataGridView2.AllowUserToAddRows = false;
				dataGridView2.ReadOnly = true;
				dataGridView2.Columns[0].HeaderText = "Kode";
				dataGridView2.Columns[0].Width = 70;
				dataGridView2.Columns[1].HeaderText = "Nama Bunga";
				dataGridView2.Columns[1].Width = 145;
				dataGridView2.Columns[2].HeaderText = "Jumlah";
				dataGridView2.Columns[2].Width = 70;
				dataGridView2.Columns[3].HeaderText = "Harga Pokok";
				dataGridView2.Columns[3].Width = 100;
				dataGridView2.Columns[4].HeaderText = "Harga Jual";
				dataGridView2.Columns[4].Width = 90;		
				
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
			
			
		}
		
		void FormUtamaAdminFormClosed(object sender, FormClosedEventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}
		
		
		#region Validasi
		private int tmp =0;		
		private string kosong1 = "";string kosong2 = ""; string kosong3 = ""; string kosong4 = ""; string kosong5="";
		void cekbuttonSimmpan (string satu, int text){
			
			if (satu.Equals("tambah")) 	tmp = tmp+text;
			if (satu.Equals("kurang")) tmp = tmp-text;
//			else tmp = tmp -text;
			if (tmp == 15) button9_BungaSimpan.Enabled = true;
			else button9_BungaSimpan.Enabled = false;
			//MessageBox.Show("list " +tmp.ToString());
		}
		void TextBox1_KodeBungaKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
				e.Handled = true;
			}else{
			
				string a="";
				int text=1;
				if(textBox1_KodeBunga.Text.Length >=0) {
					button7_Cari.Enabled = true;
					a="tambah"+kosong1;					
					cekbuttonSimmpan(a,text);
					kosong1 = "1";
				}
				if(e.KeyChar == (char)Keys.Back){
					if (textBox1_KodeBunga.Text.Length <=1){
						button7_Cari.Enabled = false;
						a = "kurang";
						kosong1="";
						cekbuttonSimmpan(a,text);
					}
				}			
				
			}
		}		
		void TextBox1_NamaBungaKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) {
				e.Handled = true;
			}else{
				string a="";
				int text=2;
				if(textBox1_NamaBunga.Text.Length >=0) {
					a="tambah"+kosong2;					
					cekbuttonSimmpan(a,text);
					kosong2 = "2";
				}
				if(e.KeyChar == (char)Keys.Back){
					if (textBox1_NamaBunga.Text.Length <=1){
						a = "kurang";
						kosong2="";
						cekbuttonSimmpan(a,text);
					}
				}
				
			}
		}
		void TextBox3_StokBungaKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
				e.Handled = true;
			}else{
				string a="";
				int text=3;
				if(textBox3_StokBunga.Text.Length >=0) 	{
					a="tambah"+kosong3;					
					cekbuttonSimmpan(a,text);
					kosong3 = "3";
				}
				if(e.KeyChar == (char)Keys.Back){
					if (textBox3_StokBunga.Text.Length <=1){
						a = "kurang";
						kosong3="";
						cekbuttonSimmpan(a,text);
					}
				}
			}
		}
		void TextBox2_HargaPokokKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
				e.Handled = true;
			}else{
				string a="";
				int text=4;
				if(textBox2_HargaPokok.Text.Length >=0) {
					a="tambah"+kosong4;					
					cekbuttonSimmpan(a,text);
					kosong4 = "4";
				}
				if(e.KeyChar == (char)Keys.Back){
					if (textBox2_HargaPokok.Text.Length <=1){
						a = "kurang";
						kosong4="";
						cekbuttonSimmpan(a,text);
					}
				}
			}
		}		
		void TextBox4_HargaJualKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
				e.Handled = true;
			}else{
				string a="";
				int text=5;
				if(textBox4_HargaJual.Text.Length >=0)  {
					a="tambah"+kosong5;					
					cekbuttonSimmpan(a,text);
					kosong5 = "5";
				}
				if(e.KeyChar == (char)Keys.Back){
					if (textBox4_HargaJual.Text.Length <=1){
						a = "kurang";
						kosong5="";
						cekbuttonSimmpan(a,text);
					}
				}
			}
		}
		#endregion
			
		#region SimpanDataBunga
		void Button9_BungaSimpanClick(object sender, EventArgs e)
		{
			try {
				textBox1_KodeBunga.Focus();
				if (textBox1_KodeBunga.Text!="" && textBox1_NamaBunga.Text !="" && textBox3_StokBunga.Text!="" && textBox2_HargaPokok.Text !="" && textBox4_HargaJual.Text !="") {					
					int ExecuteNonQuery;
					ds =  Koneksi.InstanceKoneksi().GetDataStokBunga("where id_bunga = "+textBox1_KodeBunga.Text);
					if (ds.Tables[0].Rows.Count > 0) {
						MessageBox.Show("Kode Bunga Sudah Ada Bro !!!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
					}else{
						ExecuteNonQuery = Koneksi.InstanceKoneksi().InsertDataBUNGA(textBox1_KodeBunga.Text,textBox1_NamaBunga.Text,textBox3_StokBunga.Text,textBox2_HargaPokok.Text,textBox4_HargaJual.Text);
						if (ExecuteNonQuery == 1) {
							MessageBox.Show("Insert Data Sukses Bro...","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
						}else{
							MessageBox.Show("Gagal Insert Data Bro !!!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
						}
						
					}
					FormUtamaAdminLoad(null,null);
					textBox1_KodeBunga.Focus();
				}
//				else{
//					if (textBox1_KodeBunga.Text !="") {
//						if (textBox1_NamaBunga.Text !="") {
//							if (textBox3_StokBunga.Text !="") {
//								if (textBox2_HargaPokok.Text !="") {
//									if (textBox4_HargaJual.Text != "") {
//										MessageBox.Show("sumua data lengkap");
//									}else{
//										MessageBox.Show("Harga Jual Masih Kosong");
//										textBox4_HargaJual.Focus();
//									}
//								}else{
//									MessageBox.Show("Harga Pokok Masih Kosong");
//									textBox2_HargaPokok.Focus();
//								}
//							}else{
//								MessageBox.Show("Stok Masih Kosong");
//								textBox3_StokBunga.Focus();
//							}
//						}else{
//							MessageBox.Show("Nama Masih Kosong");
//							textBox1_NamaBunga.Focus();
//						}
//					}else{
//						MessageBox.Show("ID Masih Kosong");
//						textBox1_KodeBunga.Focus();
//					}
//				}
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
			
		}
		#endregion		
		#region CariDataBunga
		void Button7_CariClick(object sender, EventArgs e)
		{
			try {
				if (textBox1_KodeBunga.Text !="") {
					string dmn = "where id_bunga = "+textBox1_KodeBunga.Text;
					ds = Koneksi.InstanceKoneksi().GetDataStokBunga(dmn);
					if (ds.Tables[0].Rows.Count > 0) {
						foreach(DataRow kolom in ds.Tables[0].Rows){
							textBox1_NamaBunga.Text = kolom["nama_bunga"].ToString();
							textBox3_StokBunga.Text = kolom["jumlah"].ToString();
							textBox2_HargaPokok.Text = kolom["harga_pokok"].ToString();
							textBox4_HargaJual.Text = kolom["harga_jual"].ToString();
						}
						textBox1_KodeBunga.Enabled = false;
						textBox1_NamaBunga.Enabled = true;
						textBox3_StokBunga.Enabled = true;
						textBox2_HargaPokok.Enabled=true;
						textBox4_HargaJual.Enabled = true;
						button7_Cari.Enabled = false;
						button9_BungaSimpan.Enabled = false;
						button7_Hapus.Enabled=true;
						button8_Rubah.Enabled=true;
						button6_Refresh.Enabled=true;						
					}
					else{
						MessageBox.Show("Data Tidak Ada !!!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
					}								
				dataGridView2.DataSource = ds.Tables[0];
					
				}else{
					MessageBox.Show("ID Bunga Belum Diisi");
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
			
		}
		#endregion
		#region Refresh
		void Button6_RefreshClick(object sender, EventArgs e)
		{
			FormUtamaAdminLoad(null,null);
		}
		#endregion
		#region Rubah
		void Button8_RubahClick(object sender, EventArgs e)
		{
			textBox1_NamaBunga.Focus();
				try {				
				if (textBox1_KodeBunga.Text!="" && textBox1_NamaBunga.Text !="" && textBox3_StokBunga.Text!="" && textBox2_HargaPokok.Text !="" && textBox4_HargaJual.Text !="") {					
					if (MessageBox.Show("Anda Yakin Mengrubah Data ini ?? ","Warning ",MessageBoxButtons.YesNo ) == DialogResult.Yes) {
					int ExecuteNonQuery;
					int convkodeBunga = int.Parse(textBox1_KodeBunga.Text);
					int convStokBunga = int.Parse(textBox3_StokBunga.Text);
					int convHargaPokok= int.Parse(textBox2_HargaPokok.Text);
					int convHargaJual = int.Parse(textBox4_HargaJual.Text);
						ExecuteNonQuery = Koneksi.InstanceKoneksi().UpdateDataBUNGA(convkodeBunga,textBox1_NamaBunga.Text,convStokBunga,convHargaPokok,convHargaJual);
						if (ExecuteNonQuery == 1) {
							MessageBox.Show("Rubah Data Sukses Bro...","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
						}else{
							MessageBox.Show("Gagal Rubah Data Bro !!!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
						}	
					}
					FormUtamaAdminLoad(null,null);
					textBox1_KodeBunga.Focus();
				}else{
					if (textBox1_KodeBunga.Text !="") {
						if (textBox1_NamaBunga.Text !="") {
							if (textBox3_StokBunga.Text !="") {
								if (textBox2_HargaPokok.Text !="") {
									if (textBox4_HargaJual.Text != "") {
										MessageBox.Show("sumua data lengkap");
									}else{
										MessageBox.Show("Harga Jual Masih Kosong");
										textBox4_HargaJual.Focus();
									}
								}else{
									MessageBox.Show("Harga Pokok Masih Kosong");
									textBox2_HargaPokok.Focus();
								}
							}else{
								MessageBox.Show("Stok Masih Kosong");
								textBox3_StokBunga.Focus();
							}
						}else{
							MessageBox.Show("Nama Masih Kosong");
							textBox1_NamaBunga.Focus();
						}
					}else{
						MessageBox.Show("ID Masih Kosong");
						textBox1_KodeBunga.Focus();
					}
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		#endregion
		#region Hapus
		void Button7_HapusClick(object sender, EventArgs e)
		{
			textBox1_NamaBunga.Focus();
				try {				
				if (textBox1_KodeBunga.Text!="" && textBox1_NamaBunga.Text !="" && textBox3_StokBunga.Text!="" && textBox2_HargaPokok.Text !="" && textBox4_HargaJual.Text !="") {					
					if (MessageBox.Show("Anda Yakin Menghapus Data ini ?? ","Warning ",MessageBoxButtons.YesNo ) == DialogResult.Yes) {
					int ExecuteNonQuery;
						ExecuteNonQuery = Koneksi.InstanceKoneksi().DeleteDataBunga(textBox1_KodeBunga.Text);
						if (ExecuteNonQuery == 1) {
							MessageBox.Show("Rubah Data Sukses Bro...","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
						}else{
							MessageBox.Show("Gagal Rubah Data Bro !!!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
						}
					}
					FormUtamaAdminLoad(null,null);
					textBox1_KodeBunga.Focus();
				}else{
					if (textBox1_KodeBunga.Text !="") {
						if (textBox1_NamaBunga.Text !="") {
							if (textBox3_StokBunga.Text !="") {
								if (textBox2_HargaPokok.Text !="") {
									if (textBox4_HargaJual.Text != "") {
										MessageBox.Show("sumua data lengkap");
									}else{
										MessageBox.Show("Harga Jual Masih Kosong");
										textBox4_HargaJual.Focus();
									}
								}else{
									MessageBox.Show("Harga Pokok Masih Kosong");
									textBox2_HargaPokok.Focus();
								}
							}else{
								MessageBox.Show("Stok Masih Kosong");
								textBox3_StokBunga.Focus();
							}
						}else{
							MessageBox.Show("Nama Masih Kosong");
							textBox1_NamaBunga.Focus();
						}
					}else{
						MessageBox.Show("ID Masih Kosong");
						textBox1_KodeBunga.Focus();
					}
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		#endregion
				
		void Button11_penghasilanClick(object sender, EventArgs e)
		{
			string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
			string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
			MessageBox.Show(date1.ToString());
			if (date1 !="" && date2 != "") {
				int dd1 = int.Parse(dateTimePicker1.Value.ToString("dd"));
				int dd2 = int.Parse(dateTimePicker2.Value.ToString("dd"));				
				if (dd1<=dd2) {				
					string dmn = "where tanggal between '"+date1+"' and '"+date2+"'";
				//	MessageBox.Show(dmn.ToString());
					ds = Koneksi.InstanceKoneksi().TotalPendapatanPerBulan(dmn);
					if (ds.Tables[0].Rows.Count > 0) {
						foreach(DataRow kolom in ds.Tables[0].Rows){
							textBox1_PendapatanPerBulan.Text = kolom["total"].ToString();
						}
						ds.Clear();
						ds = Koneksi.InstanceKoneksi().GetDataPembelianSebulan(dmn);
						dataGridView2.DataSource = ds.Tables[0];
						dataGridView2.AllowUserToAddRows = false;
						dataGridView2.ReadOnly = true;
						dataGridView2.Columns[0].Visible=false;
						dataGridView2.Columns[1].HeaderText = "Nama Bunga";
						dataGridView2.Columns[1].Width = 100;
						dataGridView2.Columns[2].HeaderText = "Harga Bunga";
						dataGridView2.Columns[2].Width = 100;
						dataGridView2.Columns[3].HeaderText = "Jumlah";
						dataGridView2.Columns[3].Width = 55;
						dataGridView2.Columns[4].HeaderText = "Tanggal Jual";
						dataGridView2.Columns[4].Width = 100;
						dataGridView2.Columns[5].HeaderText = "Nama Pembeli";
						dataGridView2.Columns[5].Width = 100;						
					}else{
						MessageBox.Show("Data Tidak Ada !!!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
					}	
				}else{
					MessageBox.Show("Tanggal Awal Harus lebih besar samadengan dari Tanggal akhir");
				}
			}else{
				MessageBox.Show("Tanggal Belum Diisi");
			}
		}		
		void Button2_CariUserClick(object sender, EventArgs e)
		{
			try {
				if (textBox1_KodeUser.Text !="") {
					string dmn = "where id_user = "+textBox1_KodeUser.Text;
					ds = Koneksi.InstanceKoneksi().GetDataLogin(dmn);
					if (ds.Tables[0].Rows.Count > 0) {
						foreach(DataRow kolom in ds.Tables[0].Rows){
							textBox1_KodeUser.Text = kolom["id_user"].ToString();
							textBox2_User.Text = kolom["user"].ToString();
							comboBox1.Text = kolom["status"].ToString();
							string tmp= kolom["no_hp"].ToString();
							textBox2_Telepon.Text = tmp.Substring(3,tmp.Length-3);	
							textBox3_NamaUser.Text = kolom["nama"].ToString();
						}
						textBox1_Password.Clear();
						textBox1_KodeUser.Enabled = false;
						textBox1_Password.Enabled = true;
						textBox2_User.Enabled = true;
						textBox2_Telepon.Enabled=true;
						textBox3_NamaUser.Enabled = true;
						button3_RubahUser.Enabled = true;
						button1_SimpanUser.Enabled = false;
						button4_HapusUser.Enabled=true;
						button2_CariUser.Enabled=false;
						button6_Refressh.Enabled=true;						
					}
					else{
						MessageBox.Show("Data Tidak Ada !!!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
					}								
				dataGridView2.DataSource = ds.Tables[0];
					
				}else{
					MessageBox.Show("ID Bunga Belum Diisi");
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		
		void Button6_RefresshClick(object sender, EventArgs e)
		{
			try {
				
				FormUtamaAdminLoad(null,null);
				if (ds != null) {
					ds = null;
					dataGridView2.Columns.Clear();
				}
				ds = Koneksi.InstanceKoneksi().GetDataLogin("");
				dataGridView2.DataSource = ds.Tables[0];
				dataGridView2.AllowUserToAddRows = false;
				dataGridView2.ReadOnly = true;
				dataGridView2.Columns[0].HeaderText = "Kode";
				dataGridView2.Columns[0].Width = 90;
				dataGridView2.Columns[1].HeaderText = "Username";
				dataGridView2.Columns[1].Width = 90;
				dataGridView2.Columns[2].HeaderText = "Password";
				dataGridView2.Columns[2].Width = 90;
				dataGridView2.Columns[3].HeaderText = "Status";
				dataGridView2.Columns[3].Width = 90;
				dataGridView2.Columns[4].HeaderText = "Hanphone";
				dataGridView2.Columns[4].Width = 90;
				dataGridView2.Columns[5].HeaderText = "Nama";
				dataGridView2.Columns[5].Width = 90;
				
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
			
		}
		
		void Button3_RubahUserClick(object sender, EventArgs e)
		{
			textBox2_User.Focus();
			try {				
				if (textBox2_User.Text!="" && textBox1_Password.Text !="" && textBox3_NamaUser.Text!="" && textBox2_Telepon.Text !="" && comboBox1.Text !="" ) {					
					if (MessageBox.Show("Anda Yakin Mengrubah Data ini ?? ","Warning ",MessageBoxButtons.YesNo ) == DialogResult.Yes) {
					int ExecuteNonQuery;
					int convkodeUser = int.Parse(textBox1_KodeUser.Text);					
					ExecuteNonQuery = Koneksi.InstanceKoneksi().UpdatePaswordLoginAdmin(convkodeUser,textBox2_User.Text,textBox1_Password.Text,textBox3_NamaUser.Text,comboBox1.Text, ("+62"+textBox2_Telepon.Text));
						if (ExecuteNonQuery == 1) {
							MessageBox.Show("Rubah Data Sukses Bro...","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
						}else{
							MessageBox.Show("Gagal Rubah Data Bro !!!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
						}	
					}
					FormUtamaAdminLoad(null,null);
					textBox1_KodeUser.Focus();
				}else{
					if (textBox1_KodeUser.Text !="") {
						if (textBox2_User.Text !="") {
							if (textBox1_Password.Text !="") {
								if (comboBox1.Text !="") {
									if (textBox2_Telepon.Text != "") {
										if (textBox3_NamaUser.Text != "") {
											MessageBox.Show("sumua data lengkap");
										}else{
											MessageBox.Show("Nama Masih Kosong");
											textBox4_HargaJual.Focus();
										}										
									}else{
										MessageBox.Show("Telepon Masih Kosong");
										textBox4_HargaJual.Focus();
									}
								}else{
									MessageBox.Show("Status Masih Kosong");
									textBox2_HargaPokok.Focus();
								}
							}else{
								MessageBox.Show("password Kosong");
								textBox3_StokBunga.Focus();
							}
						}else{
							MessageBox.Show("username Masih Kosong");
							textBox1_NamaBunga.Focus();
						}
					}else{
						MessageBox.Show("kode Masih Kosong");
						textBox1_KodeBunga.Focus();
					}
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}	
		}
		
		
		void Button4_HapusUserClick(object sender, EventArgs e)
		{
			textBox2_User.Focus();
			try {				
				if (textBox2_User.Text!=""  && textBox3_NamaUser.Text!="" && textBox2_Telepon.Text !="" && comboBox1.Text !="" ) {					
					if (MessageBox.Show("Anda Yakin Menghapus Data ini ?? ","Warning ",MessageBoxButtons.YesNo ) == DialogResult.Yes) {
					int ExecuteNonQuery;
					int convkodeUser = int.Parse(textBox1_KodeUser.Text);					
					ExecuteNonQuery = Koneksi.InstanceKoneksi().DeletesUserLogin(convkodeUser);
						if (ExecuteNonQuery == 1) {
							MessageBox.Show("Hapus Data Sukses Bro...","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
						}else{
							MessageBox.Show("Gagal Hapus Data Bro !!!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
						}	
					}
					FormUtamaAdminLoad(null,null);
					textBox1_KodeUser.Focus();
				}else{
					if (textBox1_KodeUser.Text !="") {
						if (textBox2_User.Text !="") {							
								if (comboBox1.Text !="") {
									if (textBox2_Telepon.Text != "") {
										if (textBox3_NamaUser.Text != "") {
											MessageBox.Show("sumua data lengkap");
										}else{
											MessageBox.Show("Nama Masih Kosong");
											textBox4_HargaJual.Focus();
										}										
									}else{
										MessageBox.Show("Telepon Masih Kosong");
										textBox4_HargaJual.Focus();
									}
								}else{
									MessageBox.Show("Status Masih Kosong");
									textBox2_HargaPokok.Focus();
								}
							
						}else{
							MessageBox.Show("username Masih Kosong");
							textBox1_NamaBunga.Focus();
						}
					}else{
						MessageBox.Show("kode Masih Kosong");
						textBox1_KodeBunga.Focus();
					}
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}	
		}
		
	
		
		void Button1_SimpanUserClick(object sender, EventArgs e)
		{
			textBox2_User.Focus();
			try {				
				if (textBox1_KodeUser.Text != "" && textBox2_User.Text!="" && textBox1_Password.Text !="" && textBox3_NamaUser.Text!="" && textBox2_Telepon.Text !="" && comboBox1.Text !="" ) {					
					
					int ExecuteNonQuery;
					int convkodeUser = int.Parse(textBox1_KodeUser.Text);					
					ExecuteNonQuery = Koneksi.InstanceKoneksi().InsertPaswordLogin(convkodeUser,textBox2_User.Text,textBox1_Password.Text,textBox3_NamaUser.Text,comboBox1.Text, ("+62"+textBox2_Telepon.Text));
						if (ExecuteNonQuery == 1) {
							MessageBox.Show("Simpan Data Sukses Bro...","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
						}else{
							MessageBox.Show("Gagal Simpan Data Bro !!!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
						}	
					
					FormUtamaAdminLoad(null,null);
					textBox1_KodeUser.Focus();
				}else{
					if (textBox1_KodeUser.Text !="") {
						if (textBox2_User.Text !="") {
							if (textBox1_Password.Text !="") {
								if (comboBox1.Text !="") {
									if (textBox2_Telepon.Text != "") {
										if (textBox3_NamaUser.Text != "") {
											MessageBox.Show("sumua data lengkap");
										}else{
											MessageBox.Show("Nama Masih Kosong");
											textBox3_NamaUser.Focus();
										}										
									}else{
										MessageBox.Show("Telepon Masih Kosong");
										textBox2_Telepon.Focus();
									}
								}else{
									MessageBox.Show("Status Masih Kosong");									
								}
							}else{
								MessageBox.Show("password Kosong");
								textBox1_Password.Focus();
							}
						}else{
							MessageBox.Show("username Masih Kosong");
							textBox2_User.Focus();
						}
					}else{
						MessageBox.Show("kode Masih Kosong");
						textBox1_KodeUser.Focus();
					}
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}	
		}
		
		void Button1_refreshPenjualanClick(object sender, EventArgs e)
		{
			try {				
				FormUtamaAdminLoad(null,null);
				if (ds != null) {
					ds = null;
					dataGridView2.Columns.Clear();
				}
				
				ds = Koneksi.InstanceKoneksi().GetDataPembelianSebulan("");
				dataGridView2.DataSource = ds.Tables[0];
				dataGridView2.AllowUserToAddRows = false;
				dataGridView2.ReadOnly = true;
				dataGridView2.Columns[0].Visible=false;
				dataGridView2.Columns[1].HeaderText = "Nama Bunga";
				dataGridView2.Columns[1].Width = 100;
				dataGridView2.Columns[2].HeaderText = "Harga Bunga";
				dataGridView2.Columns[2].Width = 100;
				dataGridView2.Columns[3].HeaderText = "Jumlah";
				dataGridView2.Columns[3].Width = 55;
				dataGridView2.Columns[4].HeaderText = "Tanggal Jual";
				dataGridView2.Columns[4].Width = 100;
				dataGridView2.Columns[5].HeaderText = "Nama Pembeli";
				dataGridView2.Columns[5].Width = 100;
				
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		
		
	}
}
