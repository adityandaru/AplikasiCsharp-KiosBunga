/*
 * Created by SharpDevelop.
 * User: This
 * Date: 11/10/2013
 * Time: 6:24 AM
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
	/// Description of FormStokBunga.
	/// </summary>
	public partial class FormStokBunga : Form
	{
		public FormUtamaKaryawan fuk = null;
		private DataSet ds ;
		public FormStokBunga()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void FormStokBungaLoad(object sender, EventArgs e)
		{
			try {
				ds = Koneksi.InstanceKoneksi().GetDataStokBunga("");
				dataGridView1_StokBunga.DataSource = ds.Tables[0];		
				dataGridView1_StokBunga.AllowUserToAddRows = false;
						dataGridView1_StokBunga.ReadOnly = true;
						dataGridView1_StokBunga.Columns[0].HeaderText = "Kode Bunga";
						dataGridView1_StokBunga.Columns[0].Width = 90;
						dataGridView1_StokBunga.Columns[1].HeaderText = "Nama Bunga";
						dataGridView1_StokBunga.Columns[1].Width = 150;
						dataGridView1_StokBunga.Columns[2].HeaderText = "Jumlah";
						dataGridView1_StokBunga.Columns[2].Width = 90;
						dataGridView1_StokBunga.Columns[3].HeaderText = "Harga pokok";
						dataGridView1_StokBunga.Columns[3].Width = 110;
						dataGridView1_StokBunga.Columns[4].HeaderText = "Harga Jual";
						dataGridView1_StokBunga.Columns[4].Width = 110;
				button1_Pilih.Enabled = false;
				button1_Cari.Enabled = false;
				textBox1_Nama.Enabled= true;
				textBox1_Nama.Focus();
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
			
		}
		
		void Button1_CariClick(object sender, EventArgs e)
		{
			try {
				if (button1_Cari.Text == "Refresh") {
					FormStokBungaLoad(null,null);
					textBox1_Nama.Clear();
					button1_Cari.Text = "Cari";
				}else{					
					string dmn = string.Format("where nama_bunga = '"+textBox1_Nama.Text.ToLower()+"'");
					ds = Koneksi.InstanceKoneksi().GetDataStokBunga(dmn);
					if (ds.Tables[0].Rows.Count > 0 ) {
						dataGridView1_StokBunga.DataSource = ds.Tables[0];
						button1_Cari.Text = "Refresh";
						button1_Pilih.Enabled = true;
					}else{
						MessageBox.Show("Data Yang Anda Cari Tidak Ada !!! ");
						textBox1_Nama.Clear();
						button1_Cari.Enabled = false;
						
					}
				}
				
				
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		
		
		
		void Button1_PilihClick(object sender, EventArgs e)
		{
			try {
				string dmn = string.Format("where nama_bunga = '"+textBox1_Nama.Text.ToLower()+"'");
				ds = Koneksi.InstanceKoneksi().GetDataStokBunga(dmn);
				if (ds.Tables[0].Rows.Count > 0) {
					foreach(DataRow kolom in ds.Tables[0].Rows){
						fuk.textBox4_ID.Text=kolom["id_bunga"].ToString();
						fuk.textBox1_NamaBunga.Text = kolom["nama_bunga"].ToString();
						fuk.textBox7_Harga.Text = kolom["harga_jual"].ToString();
						
						this.Close();
						fuk.textBox4_ID.Enabled = false;
						fuk.textBox2_QTY.Focus();
					}
				}else{
					MessageBox.Show("kode salah");
				}
				
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		
		void TextBox1_NamaKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) {
				e.Handled = true;
			}else{
				if(textBox1_Nama.Text.Length >=0) {
					button1_Cari.Enabled = true;
				}
				if(e.KeyChar == (char)Keys.Back){
					if (textBox1_Nama.Text.Length <=1){
						button1_Cari.Enabled = false;
					}
				}		
			}
		}
		
		void DataGridView1_StokBungaCellClick(object sender, DataGridViewCellEventArgs e)
		{
				if (button1_Cari.Text == "Refresh") {
					FormStokBungaLoad(null,null);
					textBox1_Nama.Clear();
					button1_Cari.Text = "Cari";
				}else{		
				textBox1_Nama.Text = dataGridView1_StokBunga.Rows[e.RowIndex].Cells[1].Value.ToString();
					string dmn = string.Format("where nama_bunga = '"+textBox1_Nama.Text.ToLower()+"'");
					ds = Koneksi.InstanceKoneksi().GetDataStokBunga(dmn);
					if (ds.Tables[0].Rows.Count > 0 ) {
						dataGridView1_StokBunga.DataSource = ds.Tables[0];
						button1_Cari.Text = "Refresh";
						button1_Pilih.Enabled = true;
						button1_Cari.Enabled = true;
						textBox1_Nama.Enabled = false;
					}else{
						MessageBox.Show("Data Yang Anda Cari Tidak Ada !!! ");
						textBox1_Nama.Clear();
						button1_Cari.Enabled = false;
						
					}
				}
		}
		
		void TextBox1_NamaKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) {
				button1_Cari.PerformClick();
			}
		}
	}
}
