/*
 * Created by SharpDevelop.
 * User: This
 * Date: 11/10/2013
 * Time: 1:02 PM
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
	/// Description of FormDataPelangan.
	/// </summary>
	public partial class FormDataPelangan : Form
	{
		private DataSet ds;
		public FormUtamaKaryawan fuk = null;
		public FormDataPelangan()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		#region DataPelanganLoad
		void FormDataPelanganLoad(object sender, EventArgs e)
		{
			try {
				textBox4_ID.Focus();
				textBox4_ID.Clear();
				textBox1_Nama.Clear();
				textBox2_NomerHp.Clear();
				textBox3_Alamat.Clear();
				textBox4_ID.Enabled = true;
				textBox1_Nama.Enabled = true;
				textBox2_NomerHp.Enabled = true;
				textBox3_Alamat.Enabled = true;
				textBox1_Awal62.Enabled =false;
				button5.Enabled=false;
				button3_Pilih.Enabled = false;
				button1_Simpan.Enabled = true;
					ds = Koneksi.InstanceKoneksi().GetDataPelanggan("");
					dataGridView1_FormDataPelanggan.DataSource = ds.Tables[0];
					
					dataGridView1_FormDataPelanggan.AllowUserToAddRows = false; // remove the null line
		            dataGridView1_FormDataPelanggan.ReadOnly = true;
		            dataGridView1_FormDataPelanggan.Columns[0].HeaderText = "ID";
		            dataGridView1_FormDataPelanggan.Columns[0].Width = 40; 
		            dataGridView1_FormDataPelanggan.Columns[1].HeaderText = "NAMA";
		            dataGridView1_FormDataPelanggan.Columns[1].Width = 100; 
		            dataGridView1_FormDataPelanggan.Columns[2].HeaderText = "ALAMAT";
		            dataGridView1_FormDataPelanggan.Columns[2].Width = 120; 
					dataGridView1_FormDataPelanggan.Columns[3].HeaderText = "NOMER HP";
		            dataGridView1_FormDataPelanggan.Columns[3].Width = 100; 
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		
		void TextBox4_IDKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
				e.Handled = true;	
			}else{
				if(textBox4_ID.Text.Length >=0) {
					button5.Enabled = true;
					
				}
				if(e.KeyChar == (char)Keys.Back){
					if (textBox4_ID.Text.Length <=1){
						button5.Enabled = false;
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
		#region SimpanDataPembeli
		void Button1_SimpanClick(object sender, EventArgs e)
		{
				
			try {
				textBox4_ID.Focus();
				if (textBox4_ID.Text!="" && textBox1_Nama.Text !="" && textBox2_NomerHp.Text!="" && textBox3_Alamat.Text !="") {					
					int ExecuteNonQuery;
					ds =  Koneksi.InstanceKoneksi().GetDataPelanggan("where id_pelanggan = "+textBox4_ID.Text);
					if (ds.Tables[0].Rows.Count > 0) {
						MessageBox.Show("ID Sudah Ada Bro !!!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
					}else{
						ExecuteNonQuery = Koneksi.InstanceKoneksi().InsertDataPelangan(textBox4_ID.Text,textBox1_Nama.Text,textBox3_Alamat.Text,("+62"+textBox2_NomerHp.Text));
						if (ExecuteNonQuery == 1) {
							MessageBox.Show("Insert Data Sukses Bro...","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
						}else{
							MessageBox.Show("Gagal Insert Data Bro !!!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
						}
						
					}
					FormDataPelanganLoad(null,null);
				}else{
					if (textBox4_ID.Text !="") {
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
						textBox4_ID.Focus();
					}
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		#endregion
		#region Pilih
		void Button3_PilihClick(object sender, EventArgs e)		
		{
			
			fuk.textBox12_NamaPembeli.Text = textBox1_Nama.Text;
			fuk.radioButton2_KIRIM.Checked = true;
			fuk.textBox12_NamaPembeli.Enabled = false;
		//	MessageBox.Show("masuk");
			this.Close();
		}
		#endregion
		#region Refresh
		void Button2_RefreshClick(object sender, EventArgs e)
		{
			FormDataPelanganLoad(null,null);
			textBox4_ID.Focus();
		}
		#endregion
		#region Cari
		void Button5Click(object sender, EventArgs e)
		{
			
				if (textBox4_ID.Text !="") {
					string dmn = "where id_pelanggan = "+textBox4_ID.Text;
					ds = Koneksi.InstanceKoneksi().GetDataPelanggan(dmn);
					if (ds.Tables[0].Rows.Count > 0) {
						foreach(DataRow kolom in ds.Tables[0].Rows){
							textBox1_Nama.Text = kolom["nama_pelanggan"].ToString();
							string tmp= kolom["no_hp"].ToString();
							textBox2_NomerHp.Text = tmp.Substring(3,tmp.Length-3);
							textBox3_Alamat.Text = kolom["alamat"].ToString();
						}
						textBox4_ID.Enabled = false;
						textBox3_Alamat.Enabled = false;
						textBox2_NomerHp.Enabled = false;
						textBox1_Nama.Enabled=false;
						textBox1_Awal62.Enabled = false;
						button3_Pilih.Enabled = true;
						button1_Simpan.Enabled = false;
					}
					else{
						MessageBox.Show("Data Tidak Ada !!!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
					}
								
				dataGridView1_FormDataPelanggan.DataSource = ds.Tables[0];
					
				}else{
					MessageBox.Show("ID Belum Diisi");
				}
			
		}
		#endregion
		
		
		void TextBox4_IDKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) {
				if (textBox4_ID.Text != "") {
					button5.PerformClick();
				}else{
					MessageBox.Show("ID Belum Diisi");
					button5.Enabled=false;
				}
			}
		}
		
		void DataGridView1_FormDataPelangganCellClick(object sender, DataGridViewCellEventArgs e)
		{
			
			textBox4_ID.Text = dataGridView1_FormDataPelanggan.Rows[e.RowIndex].Cells[0].Value.ToString();
			textBox1_Nama.Text = dataGridView1_FormDataPelanggan.Rows[e.RowIndex].Cells[1].Value.ToString();
			string hp = dataGridView1_FormDataPelanggan.Rows[e.RowIndex].Cells[3].Value.ToString();
			textBox2_NomerHp.Text = hp.Substring(3,hp.Length-3);
			textBox3_Alamat.Text = dataGridView1_FormDataPelanggan.Rows[e.RowIndex].Cells[2].Value.ToString();
			
			string dmn = "where id_pelanggan = "+textBox4_ID.Text;
					ds = Koneksi.InstanceKoneksi().GetDataPelanggan(dmn);
					if (ds.Tables[0].Rows.Count > 0) {
					
						textBox4_ID.Enabled = false;
						textBox3_Alamat.Enabled = false;
						textBox2_NomerHp.Enabled = false;
						textBox1_Nama.Enabled=false;
						textBox1_Awal62.Enabled = false;
						button3_Pilih.Enabled = true;
						button1_Simpan.Enabled = false;
					}
					
			
				dataGridView1_FormDataPelanggan.DataSource = ds.Tables[0];
			
		}
	}
}
