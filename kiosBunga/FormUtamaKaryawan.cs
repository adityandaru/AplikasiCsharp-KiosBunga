/*
 * Created by SharpDevelop.
 * User: This
 * Date: 11/8/2013
 * Time: 12:16 AM
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
	/// Description of FormUtamaKaryawan.
	/// </summary>
	public partial class FormUtamaKaryawan : Form
	{
		public string namaLogin, userLogin, passLogin, id;
		private DataSet ds;		
		//private int idPesanan;
		public string PembeliDrDataPelanggan;
		public string day =DateTime.Now.Day.ToString();
		public string month = DateTime.Now.Month.ToString();
		public string year=DateTime.Now.Year.ToString();
		public string jam = DateTime.Now.Hour.ToString();
		
		public FormUtamaKaryawan()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		#region LOADFORM
		void FormUtamaKaryawanFormClosed(object sender, FormClosedEventArgs e)
		{					
			System.Windows.Forms.Application.Exit();
		}
		void FormUtamaKaryawanLoad(object sender, EventArgs e)
		{
			
			label12_TanggalNow.Text = (day+"-"+month+"-"+year).ToString();
			label9_NamaKaryawan.Text = namaLogin.ToLowerInvariant();
			label42_Diskon.Text = "";
			label42_TulisDiskon.Text = "";		
			textBox4_ID.Clear();
			textBox4_ID.Enabled = true;
			textBox7_Harga.Enabled = false;
			textBox1_NamaBunga.Enabled = false;
			textBox4_ID.Focus();	
			textBox12_NamaPembeli.Clear();
			textBox12_NamaPembeli.Enabled=false;
			radioButton1_COD.Checked = false;
			radioButton2_KIRIM.Checked = false;
			textBox5_TotalBayar.Clear();
			textBox6_UangPembeli.Clear();
			textBox8_Kembalian.Clear();
			textBox7_Harga.Clear();
			textBox1_NamaBunga.Clear();
			textBox2_QTY.Clear();
			button4_Total.Enabled =false;
			button2_Bayar.Enabled = false;	
			textBox9_DefaultUser.Text = userLogin.ToLowerInvariant();
			button7_RubahDataPembeli.Enabled = false;
			button8_CetaknDataPembeli.Enabled = false;
			button9_HapusDataPembeli.Enabled=false;
			button6_SimpanDataPembeli.Enabled = true;
			button2_CariPembeli.Enabled = false;
			button3.Enabled = true;
			button1_ADD_Pesan.Enabled = true;
			textBox2_QTY.Enabled= true;
			textBox6_UangPembeli.Enabled =false;
			tabPage2.Enabled = true;
			tabPage3.Enabled = true;
		}
		#endregion
		#region  VALIDASI
		void TextBox4KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
				e.Handled = true;
			}
		}
		void TextBox4_IDKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
				e.Handled = true;
			}
		}
		void TextBox2KeyPress(object sender, KeyPressEventArgs e)
		{
			
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) ) {
				
				e.Handled = true;
				}
			
		}
		void TextBox6_UangPembeliKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
				e.Handled = true;
			}
		}
		void TextBox12_NamaPembeliKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) {
				e.Handled = true;
			}
		}
		void TextBox1KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) {
				e.Handled = true;
			}
		}
		void TextBox1_IDKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
				e.Handled = true;
			}else{
				if(textBox1_ID.Text.Length >=0) {
					button2_CariPembeli.Enabled = true;
					
				}
				if(e.KeyChar == (char)Keys.Back){
					if (textBox1_ID.Text.Length <=1){
						button2_CariPembeli.Enabled = false;
					}
				}		
			}		
			
		}
		void TextBox1_NamaKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) {
				e.Handled = true;
			}
		}
			
		void TextBox2_NomerHpKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
				e.Handled = true;
			}	
		}
		#endregion
		#region  TAB MANAJEMEN
		#region  ID LIHAT BUNGA
		void Button3Click(object sender, EventArgs e)
		{
			FormStokBunga fsb = new FormStokBunga();
			fsb.fuk = this;
			fsb.Show();
		}
		#endregion		
		#region LIHAT DATA PELANGGAN
		void RadioButton2_KIRIMMouseCaptureChanged(object sender, EventArgs e)
		{
			FormDataPelangan formDataPelangan = new FormDataPelangan();
			formDataPelangan.fuk = this;
			formDataPelangan.ShowDialog();
		}
		#endregion
		#region ENTER ID BUNGA
		void TextBox4_IDKeyDown(object sender, KeyEventArgs e)
		{
			if (textBox4_ID.Text != "" && e.KeyCode == Keys.Return) {
				string dmn = "where id_bunga = "+textBox4_ID.Text;
				ds = Koneksi.InstanceKoneksi().GetDataStokBunga(dmn);
				if (ds.Tables[0].Rows.Count > 0 ) {
					foreach(DataRow kolom in ds.Tables[0].Rows){
						textBox1_NamaBunga.Text = kolom["nama_bunga"].ToString();
						textBox7_Harga.Text  = kolom["harga_jual"].ToString();							
					}
					textBox2_QTY.Focus();
				}else{
					MessageBox.Show("kode salah");
					textBox4_ID.Clear();
					textBox4_ID.Focus();
				}
				ds.Clear();
			}
		}
		#endregion
		#region REMOVE ROW DATAGRIDVIEW
		void DataGridView1_UtamaKaryawanCellClick(object sender, DataGridViewCellEventArgs e)
		{
			int kolombatal;
			try {
				kolombatal = dataGridView1_UtamaKaryawan.CurrentCell.RowIndex; 
				MessageBox.Show(kolombatal.ToString());
				if (dataGridView1_UtamaKaryawan.CurrentCell.ColumnIndex == 7) {
					dataGridView1_UtamaKaryawan.Rows.RemoveAt(kolombatal);	
					if (kolombatal==0) {
							button2_Bayar.Enabled = false;
							button4_Total.Enabled = false;
							textBox6_UangPembeli.Clear();
							textBox5_TotalBayar.Clear();
							textBox8_Kembalian.Clear();
					}
				}
				
			} catch (Exception) {
				MessageBox.Show("hehehe, Data masih kosong broo !!!");
			}
		}
		#endregion
		#region  ADD PESAN
		void Button1_ADD_PesanClick(object sender, EventArgs e)
		{
			try {
				
				
				if (textBox4_ID.Text !="" && textBox1_NamaBunga.Text != "" && textBox7_Harga.Text != "" &&  textBox2_QTY.Text != "" ) {
					int qty = int.Parse(textBox2_QTY.Text);
					if (qty == 0) {
					MessageBox.Show("Jumlah Barang Harus Lebih Dari 1 ");
					}else{
					
					ds = Koneksi.InstanceKoneksi().GetDataStokBunga("where id_bunga = "+textBox4_ID.Text);					
					string Qty="";
					string harga_pokok = "";
					if (ds.Tables[0].Rows.Count > 0 ) {
						foreach(DataRow kolom in ds.Tables[0].Rows){
							Qty = kolom["jumlah"].ToString();
							harga_pokok=kolom["harga_pokok"].ToString();
						}						
						int conQty = int.Parse(Qty);
						int hargaPokok = int.Parse(harga_pokok);
						if ( conQty >= qty) {							
							int harga = int.Parse(textBox7_Harga.Text);							
							int total = (harga*qty);
							ds.Clear();
							
							dataGridView1_UtamaKaryawan.ColumnCount=7;
							dataGridView1_UtamaKaryawan.AllowUserToAddRows = false; // remove the null line
				            dataGridView1_UtamaKaryawan.ReadOnly = true;
				            dataGridView1_UtamaKaryawan.Columns[0].Visible = false;
				            dataGridView1_UtamaKaryawan.Columns[1].HeaderText = "NAMA \nBUNGA";
				            dataGridView1_UtamaKaryawan.Columns[1].Width = 160; 
				            dataGridView1_UtamaKaryawan.Columns[2].HeaderText = "QTY";
				            dataGridView1_UtamaKaryawan.Columns[2].Width = 50; 
				            dataGridView1_UtamaKaryawan.Columns[3].HeaderText = "HARGA";
				            dataGridView1_UtamaKaryawan.Columns[3].Width = 100; 
							dataGridView1_UtamaKaryawan.Columns[4].HeaderText = "TOTAL";
				            dataGridView1_UtamaKaryawan.Columns[4].Width = 100; 				           
				            dataGridView1_UtamaKaryawan.Columns[5].Visible = false;
				            dataGridView1_UtamaKaryawan.Columns[6].Visible = false;
							DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
				            dataGridView1_UtamaKaryawan.Columns.Add(btn);
				            btn.HeaderText = "BATAL";
				            btn.Width = 110;
				            btn.Text = "Batal Pesanan";
				            btn.Name = "batal";
				            btn.UseColumnTextForButtonValue = true;
							
							int banyakData = dataGridView1_UtamaKaryawan.Rows.Count;
							
							dataGridView1_UtamaKaryawan.Rows.Insert(banyakData,1);
							dataGridView1_UtamaKaryawan[0,banyakData].Value = textBox4_ID.Text;
							dataGridView1_UtamaKaryawan[1,banyakData].Value = textBox1_NamaBunga.Text;
							dataGridView1_UtamaKaryawan[2,banyakData].Value = qty;
							dataGridView1_UtamaKaryawan[3,banyakData].Value = harga;	
							dataGridView1_UtamaKaryawan[4,banyakData].Value = total;	
							dataGridView1_UtamaKaryawan[5,banyakData].Value = hargaPokok;
							dataGridView1_UtamaKaryawan[6,banyakData].Value = conQty;
							if (banyakData>=0) {						
								button2_Bayar.Enabled = true;
								button4_Total.Enabled = true;
								textBox6_UangPembeli.Enabled = true;
							}	
							textBox1_ID.Focus();
							textBox4_ID.Clear();
							textBox1_NamaBunga.Clear();
							textBox7_Harga.Clear();
							textBox2_QTY.Clear();
							textBox4_ID.Enabled = true;
							textBox6_UangPembeli.Enabled = false;
							textBox6_UangPembeli.Clear();
							textBox5_TotalBayar.Clear();
							tabPage3.Enabled = false;
							tabPage2.Enabled = false;
						}else{
							MessageBox.Show("Stok Bunga Tidak Mencukupi\nStok Bunga Tinggal "+Qty);
							textBox2_QTY.Focus();
						}
						
					}else{
						MessageBox.Show("Kode Bunga Salah");
					}
					}
					
				}else{
					MessageBox.Show("Data Kurang Bro !!!");
				}
				
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		#endregion		
		#region  TOTAL
		void Button4Click(object sender, EventArgs e)
		{
			try {
				if (radioButton1_COD.Checked == true || radioButton2_KIRIM.Checked==true) {
					if (textBox12_NamaPembeli.Text !="") {
						int total=0;
						int banyak = dataGridView1_UtamaKaryawan.Rows.Count;
						for (int i = 0; i<banyak; i++) {
						total += Convert.ToInt32(dataGridView1_UtamaKaryawan[3,i].Value);
						}
						if (radioButton2_KIRIM.Checked == true) {
							double diskon = 2.5;
							double totalDiskon =(total - ((diskon * total)/100));							
							label42_TulisDiskon.Text = diskon.ToString();
							label42_Diskon.Text = "Diskon";							
							textBox5_TotalBayar.Text = Convert.ToString(totalDiskon);
						}else{
							textBox5_TotalBayar.Text = Convert.ToString(total);	
						}					
						textBox6_UangPembeli.Enabled = true;
						button4_Total.Enabled = false;
					}else{
						MessageBox.Show("NAMA PEMBELI MASIH KOSONG");
					}
					
				}else{
					MessageBox.Show("PILIH COD OR KIRIM");
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		#endregion
		#region  BAYAR
		void Button2_BayarClick(object sender, EventArgs e)
		{
			try {
				if (textBox12_NamaPembeli.Text !="") {
					if (textBox5_TotalBayar.Text !="") {
						if (textBox6_UangPembeli.Text != "") {
							int totalBayar = int.Parse(textBox5_TotalBayar.Text);
							int uangPembeli = int.Parse(textBox6_UangPembeli.Text);			
							int Kembalian = (uangPembeli-totalBayar);
                            int idmax = 0;
							if (Kembalian <0) {
								MessageBox.Show("Tambah Lagi Dong Uang Pembayaran nya \nMasih Kurang Nih !!!","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
								textBox6_UangPembeli.Focus();
							}else{
								string tanggalSekarang = (year+"-"+month+"-"+day).ToString();
								int banyakData = dataGridView1_UtamaKaryawan.Rows.Count;
								int ExecuteNonQueryCount =0;				
								
								ds = Koneksi.InstanceKoneksi().selectHeaderMax();
							
								if (ds.Tables[0].Rows.Count > 0 ) {
									foreach(DataRow kolom in ds.Tables[0].Rows){										
											try {
												int tmp = Convert.ToInt32(kolom["id"]);
												idmax = tmp + 1;
											} catch (Exception) {
												idmax = 1;
											}
									}									
								}
								
								int _count = Koneksi.InstanceKoneksi().InsertHeader(idmax,namaLogin,tanggalSekarang);
								
								for (int i=0; i<banyakData; i++) {
								//	MessageBox.Show(i.ToString());
									string insertNamaBunga	 = dataGridView1_UtamaKaryawan[1,i].Value.ToString();
									int insertQty		 	 = Convert.ToInt32(dataGridView1_UtamaKaryawan[2,i].Value.ToString());
									int insertHarga 		 = Convert.ToInt32(dataGridView1_UtamaKaryawan[3,i].Value.ToString());
									int insertID 		 	 = Convert.ToInt32(dataGridView1_UtamaKaryawan[0,i].Value.ToString());
									int insertHargaPokok     = Convert.ToInt32(dataGridView1_UtamaKaryawan[5,i].Value.ToString());
									int insertConQty    	 = Convert.ToInt32(dataGridView1_UtamaKaryawan[6,i].Value.ToString());
									
									int updateQty 		 	 = insertConQty-insertQty;
									int ExecuteNonQuery1 = Koneksi.InstanceKoneksi().UpdateDataBUNGA(insertID,insertNamaBunga,updateQty,insertHargaPokok,insertHarga);
									int ExecuteNonQuery = Koneksi.InstanceKoneksi().InsertDataTransaksi(idmax,insertNamaBunga,insertHarga,insertQty,tanggalSekarang,textBox12_NamaPembeli.Text);
									ExecuteNonQueryCount+=ExecuteNonQuery;
								}							
								textBox8_Kembalian.Text = Kembalian.ToString();
								button2_Bayar.Enabled = false;								
								if ((ExecuteNonQueryCount+_count) == (banyakData+1) ) {
										MessageBox.Show("Simpan Transaksi Sukses Bro...","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                        
								}else{
										MessageBox.Show("Gagal Simpan Transaksi Bro !!!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
								}	
							}
						}else{
							MessageBox.Show("Harus Di Isi Uang Pembayaran Bro");
							textBox6_UangPembeli.Focus();
						}					
					}else{
						MessageBox.Show("Harus Di Total Dulu Bro");
						textBox5_TotalBayar.Focus();
					}
				}else{
					MessageBox.Show("NAMA PEMBELI MASIH KOSONG");
					textBox12_NamaPembeli.Focus();
				}
				
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		#endregion	
		#region _Refresh
		void Button_RefreshFromUtamaKaryawanClick(object sender, EventArgs e)
		{
			dataGridView1_UtamaKaryawan.DataSource = null;
			dataGridView1_UtamaKaryawan.Columns.Clear();
			
			
			FormUtamaKaryawanLoad(null,null);
			int count =  dataGridView1_UtamaKaryawan.Rows.Count; 
			for (int i=count-1; i>=0; i--) {
				dataGridView1_UtamaKaryawan.Rows.RemoveAt(i);
			}
			
		}
		#endregion
		#endregion		
		#region  TAB GANTI PASSWORD
		#region GANTI PASSWORD
			void Button5Click(object sender, EventArgs e)
			{
				try {
					if (textBox3_PwdLama.Text != "" && textBox11_PwdBaru.Text != "") {
						MainForm mf = new MainForm();
						string pwd = mf.MD5Hash(textBox3_PwdLama.Text);
						if (pwd == passLogin) {
							int ID = int.Parse(id);
							if (MessageBox.Show("Anda Yakin Mengrubah Password Anda ?? ","Warning ",MessageBoxButtons.YesNo ) == DialogResult.Yes) {
								int ExecuteNonQuery = Koneksi.InstanceKoneksi().UpdatePaswordLogin(textBox11_PwdBaru.Text,ID);
								if (ExecuteNonQuery == 1) {
									MessageBox.Show("Sukses Update Password","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
								}else{
									MessageBox.Show("Gagal Update Password","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
								}	
							}
						}else{
							MessageBox.Show("Password Lama Salah");
						}
					}else{
						MessageBox.Show("Password Lama / Baru Masih Kosong");
					}
					textBox3_PwdLama.Clear();
					textBox11_PwdBaru.Clear();
				} catch (Exception ex) {
					MessageBox.Show(ex.ToString());
				}
			}
			#endregion
		#endregion		
		#region TAB DATA PEMBELI
		#region CARI
		void Button2_CariPembeliClick(object sender, EventArgs e)
		{
			
				string dmn = "where id_pelanggan = "+textBox1_ID.Text;
					ds = Koneksi.InstanceKoneksi().GetDataPelanggan(dmn);
					if (ds.Tables[0].Rows.Count > 0) {
						foreach(DataRow kolom in ds.Tables[0].Rows){
							textBox1_Nama.Text = kolom["nama_pelanggan"].ToString();
							string tmp= kolom["no_hp"].ToString();
							textBox2_NomerHp.Text = tmp.Substring(3,tmp.Length-3);							
							textBox3_Alamat.Text = kolom["alamat"].ToString();
						}
						
						textBox1_ID.Enabled = false;
						textBox3_Alamat.Enabled = true;
						textBox2_NomerHp.Enabled = true;
						textBox1_Nama.Enabled=true;
						textBox1_Awal62.Enabled = false;
						button2_CariPembeli.Enabled = false;
						button6_SimpanDataPembeli.Enabled=false;
						button7_RubahDataPembeli.Enabled = true;
						button8_CetaknDataPembeli.Enabled = true;
						button9_HapusDataPembeli.Enabled=true;
						
					}
					else{
						MessageBox.Show("Data Tidak Ada !!!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
					}
								
				dataGridView1_UtamaKaryawan.DataSource = ds.Tables[0];
					
			
		}
		#endregion
		
		#endregion
		#region SimpanDataPembeli
		void Button6_SimpanDataPembeliClick(object sender, EventArgs e)
		{
			try {
				textBox1_ID.Focus();
				if (textBox1_ID.Text!="" && textBox1_Nama.Text !="" && textBox2_NomerHp.Text!="" && textBox3_Alamat.Text !="") {					
					int ExecuteNonQuery;
					ds =  Koneksi.InstanceKoneksi().GetDataPelanggan("where id_pelanggan = "+textBox1_ID.Text);
					if (ds.Tables[0].Rows.Count > 0) {
						MessageBox.Show("ID Sudah Ada Bro !!!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
					}else{
						ExecuteNonQuery = Koneksi.InstanceKoneksi().InsertDataPelangan(textBox1_ID.Text,textBox1_Nama.Text,textBox3_Alamat.Text,("+62"+textBox2_NomerHp.Text));
						if (ExecuteNonQuery == 1) {
							MessageBox.Show("Insert Data Sukses Bro...","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
						}else{
							MessageBox.Show("Gagal Insert Data Bro !!!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
						}
						
					}
					Button_RefreshDataPembeliClick(null,null);
					textBox1_ID.Focus();
				}else{
					if (textBox1_ID.Text !="") {
						if (textBox1_Nama.Text !="") {
							if (textBox2_NomerHp.Text !="") {
								if (textBox3_Alamat.Text !="") {
									MessageBox.Show("sumua data lengkap");
								}else{
									MessageBox.Show("Alamat Masih Kosong");
									textBox3_Alamat.Focus();
								}
							}else{
								MessageBox.Show("Nomer Handphone Masih Kosong");
								textBox2_NomerHp.Focus();
							}
						}else{
							MessageBox.Show("Nama Masih Kosong");
							textBox1_Nama.Focus();
						}
					}else{
						MessageBox.Show("ID Masih Kosong");
						textBox1_ID.Focus();
					}
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
			
		}
		#endregion
		#region RubahDataPembeli
		void Button7_RubahDataPembeliClick(object sender, EventArgs e)
		{			
			textBox1_Nama.Focus();
				try {				
				if (textBox1_ID.Text!="" && textBox1_Nama.Text !="" && textBox2_NomerHp.Text!="" && textBox3_Alamat.Text !="") {					
					int ExecuteNonQuery;
					
						ExecuteNonQuery = Koneksi.InstanceKoneksi().UpdateDataPelangan(textBox1_ID.Text,textBox1_Nama.Text,textBox3_Alamat.Text,("+62"+textBox2_NomerHp.Text));
						if (ExecuteNonQuery == 1) {
							MessageBox.Show("Rubah Data Sukses Bro...","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
						}else{
							MessageBox.Show("Gagal Rubah Data Bro !!!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
						}						
						Button_RefreshDataPembeliClick(null,null);
						textBox1_ID.Focus();
				}else{
					if (textBox1_ID.Text !="") {
						if (textBox1_Nama.Text !="") {
							if (textBox2_NomerHp.Text !="") {
								if (textBox3_Alamat.Text !="") {
									MessageBox.Show("sumua data lengkap");
								}else{
									MessageBox.Show("Alamat Masih Kosong");
									textBox3_Alamat.Focus();
								}
							}else{
								MessageBox.Show("Nomer Handphone Masih Kosong");
								textBox2_NomerHp.Focus();
							}
						}else{
							MessageBox.Show("Nama Masih Kosong");
							textBox1_Nama.Focus();
						}
					}else{
						MessageBox.Show("ID Masih Kosong");
						textBox1_ID.Focus();
					}
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		#endregion
		#region HapusDataPembeli
		void Button9_HapusDataPembeliClick(object sender, EventArgs e)
		{
				try {
				
				if (textBox1_ID.Text!="" && textBox1_Nama.Text !="" && textBox2_NomerHp.Text!="" && textBox3_Alamat.Text !="") {					
					int ExecuteNonQuery;
					if (MessageBox.Show("Anda Yakin Menghapaus Data Ini ?? ","Warning ",MessageBoxButtons.YesNo ) == DialogResult.Yes) {
						ExecuteNonQuery = Koneksi.InstanceKoneksi().DeleteDataPelangan(textBox1_ID.Text);
						if (ExecuteNonQuery == 1) {
							MessageBox.Show("Rubah Data Sukses Bro...","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
						}else{
							MessageBox.Show("Gagal Rubah Data Bro !!!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
						}	
					}
					Button_RefreshDataPembeliClick(null,null);
					textBox1_ID.Focus();
				}else{
					if (textBox1_ID.Text !="") {
						if (textBox1_Nama.Text !="") {
							if (textBox2_NomerHp.Text !="") {
								if (textBox3_Alamat.Text !="") {
									MessageBox.Show("sumua data lengkap");
								}else{
									MessageBox.Show("Alamat Masih Kosong");
									textBox3_Alamat.Focus();
								}
							}else{
								MessageBox.Show("Nomer Handphone Masih Kosong");
								textBox2_NomerHp.Focus();
							}
						}else{
							MessageBox.Show("Nama Masih Kosong");
							textBox1_Nama.Focus();
						}
					}else{
						MessageBox.Show("ID Masih Kosong");
						textBox1_ID.Focus();
					}
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
			
		}
		#endregion
	
		
		
		
		
		
		
		
		
		
		
		
		
		void RadioButton1_CODMouseCaptureChanged(object sender, EventArgs e)
		{
			textBox12_NamaPembeli.Enabled = true;
		}
			
		void Button_RefreshDataPembeliClick(object sender, EventArgs e)
		{
			textBox1_ID.Focus();
				 textBox1_ID.Clear();
	            textBox1_Nama.Clear();
	            textBox2_NomerHp.Clear();
	            textBox3_Alamat.Clear();
	            textBox1_ID.Enabled = true;
				textBox3_Alamat.Enabled = true;
				textBox2_NomerHp.Enabled = true;
				textBox1_Nama.Enabled=true;
				textBox1_Awal62.Enabled = false;
	            button7_RubahDataPembeli.Enabled = false;
				button8_CetaknDataPembeli.Enabled = true;
				button9_HapusDataPembeli.Enabled=false;
				button6_SimpanDataPembeli.Enabled = true;
				button2_CariPembeli.Enabled = false;
				if (ds != null) {				
	//				ds = null;			
					dataGridView1_UtamaKaryawan.DataSource =null;
					dataGridView1_UtamaKaryawan.Columns.Clear();			
				}
				ds = Koneksi.InstanceKoneksi().GetDataPelanggan("");			
				dataGridView1_UtamaKaryawan.DataSource = ds.Tables[0];
				dataGridView1_UtamaKaryawan.AllowUserToAddRows = false; // remove the null line
	            dataGridView1_UtamaKaryawan.ReadOnly = true;
	            dataGridView1_UtamaKaryawan.Columns[0].HeaderText = "ID Pelanggan\n";
	            dataGridView1_UtamaKaryawan.Columns[0].Width = 100; 
	            dataGridView1_UtamaKaryawan.Columns[1].HeaderText = "Nama Pelanggan";
	            dataGridView1_UtamaKaryawan.Columns[1].Width = 190; 
	            dataGridView1_UtamaKaryawan.Columns[2].HeaderText = "Nomor Handphone";
	            dataGridView1_UtamaKaryawan.Columns[2].Width = 120; 
	            dataGridView1_UtamaKaryawan.Columns[3].HeaderText = "Alamat";
	            dataGridView1_UtamaKaryawan.Columns[3].Width = 110;      	
		}
		
		
		
		
		
		void TextBox1_IDKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter ) {
				if (textBox1_ID.Text !="") {
					button2_CariPembeli.PerformClick();
				}else{
				MessageBox.Show("ID Pembeli kosong");
				button2_CariPembeli.Enabled = false;
				
				}				
			}
		}
		
		void TextBox2_QTYKeyDown(object sender, KeyEventArgs e)
		{
			if ( e.KeyCode == Keys.Enter)		
			{
				textBox1_ID.Focus();
				button1_ADD_Pesan.PerformClick();
				
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			PrintBro pr = new PrintBro();
                                        
                                        pr.ShowDialog();
		}
	}
}
