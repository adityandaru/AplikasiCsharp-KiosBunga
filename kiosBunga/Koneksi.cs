/*
 * Created by SharpDevelop.
 * User: This
 * Date: 11/6/2013
 * Time: 12:20 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace kiosBunga
{
	/// <summary>
	/// Description of Koneksi.
	/// </summary>
	public class Koneksi
	{
		private string server = "localhost";
		private string database = "db_kiosbunga";
		private string port = "3306";
		private string user = "root";
		private string pwd = "";
		private string url;
		private MySqlConnection connection;
		private MySqlDataAdapter mda;
		private MySqlDataReader mdr;
		private MySqlCommand cmd;
		private DataSet ds;
		private static Koneksi objKoneksi = null;
		
		public Koneksi()
		{
			
			url = string.Format("SERVER={0}; DATABASE={1}; PORT={2}; USER={3}; PWD={4};",
			                   server,database,port,user,pwd);
			connection = new MySqlConnection(url);
		}
		
		#region  KONEKSI BUKA TUTUP
		public bool Buka(){
			try {
				connection.Open();
				return true;
			} catch (MySqlException ex) {
				switch (ex.Number) {
					case 0:
						 MessageBox.Show("Nama Server/Host Salah Bro");
						break;
					 case 1042:
                        MessageBox.Show("Nama Port Salah Bro");
                        break;
                    case 1049:
                        MessageBox.Show("Nama Database Salah Bro");
                        break;
                    case 1045:
                        MessageBox.Show("Password Database Salah Bro");
                        break;	
				}
				return false;
			}
		}
		
		public bool Tutup(){
			try {
				connection.Close();
				return true;
			} catch (MySqlException ex) {
				MessageBox.Show(ex.Message.ToString());
				return false;
			}
		}
		#endregion
		#region  singleton 
		public static Koneksi InstanceKoneksi(){
			if (objKoneksi == null) {
				objKoneksi = new Koneksi();
			}
			return objKoneksi;
		}
		#endregion
		#region  CRUD
//		private bool GetDataHasRows(string sql ){
//			bool kondisi = false;
//			Buka();
//			cmd.CommandText = sql;
//			cmd.Connection = connection;
//			mdr = cmd.ExecuteReader();
//			kondisi = mdr.HasRows;
//			Tutup();
//			return kondisi;
//		}
		private DataSet GetData(string sql){			
			
			ds = new DataSet();
			Buka();
			cmd = new MySqlCommand(sql,connection);
			mda = new MySqlDataAdapter(cmd);
	//		cmd.ExecuteNonQuery();
			mda.Fill(ds);			
			Tutup();
			
			return ds;
		}
		private int CRUD(string sql){
			int i=0;
			Buka();
			cmd = new MySqlCommand(sql, connection);
			mda = new MySqlDataAdapter(cmd);
			i = cmd.ExecuteNonQuery();
			Tutup();
			return i;
		}
		#endregion
		#region  FORM LOGIN
		public DataSet GetDataLogin(string dmn){			
			string sql = "select * from user_login "+dmn;
			//MessageBox.Show("query = "+sql.ToString());
			return GetData(sql);
		}
		#endregion
		#region  FORMKARYAWAN
		#region  GetDataStokBunga
		public DataSet GetDataStokBunga(string dmn){
			string sql = "select * from tbl_stok "+dmn;
			//MessageBox.Show("query = "+sql.ToString());
			return GetData(sql);
			 
		}
		#endregion		
		#region  UpdatePaswordLogin
		public int UpdatePaswordLogin(string pwdLama, int id){
			string sql = "update user_login set pwd = MD5('"+pwdLama+"') where id_user = "+id;
			//MessageBox.Show(sql.ToString());
			return CRUD(sql);
		}
		#endregion
		#region  UpdatePaswordLoginAdmin
		public int UpdatePaswordLoginAdmin(int id, string user, string pwd, string nama, string status, string hp){
			string sql = "update user_login set pwd = MD5('"+pwd+"'), user = '"+user+"' , nama = '"+nama+"' , status = '"+status+"' , no_hp = '"+hp+"' where id_user = "+id;
			//MessageBox.Show(sql.ToString());
			return CRUD(sql);
		}
		#endregion
		
		#region  InsertPaswordLogin
		public int InsertPaswordLogin(int id, string user, string pwd, string nama, string status, string hp){
			string sql = "insert into  user_login values('"+id+"', '"+user+"', MD5('"+pwd+"'), '"+status+"' , '"+hp+"' , '"+nama+"')";
			//MessageBox.Show(sql.ToString());
			return CRUD(sql);
		}
		#endregion
		
		#region  DetailPesan
		public DataSet DetailPesan(){
			string sql = "select * from tbl_header_detail ";
			//MessageBox.Show(sql.ToString());
			return GetData(sql);
		}
		#endregion
		#region  GetDataPelanggan
		public DataSet GetDataPelanggan(string dmn){
			string sql = "select * from tbl_pelanggan "+dmn;
		//	MessageBox.Show(sql.ToString());
			return GetData(sql);
		}
		#endregion
		#region  InsertDataPelangan
		public int InsertDataPelangan(string id, string nama, string alamat, string nohp ){
			string sql = string.Format("insert into tbl_pelanggan values ({0},'{1}','{2}','{3}')",id,nama, alamat, nohp);
			//MessageBox.Show(sql.ToString());
			return CRUD(sql);
		}
		#endregion
		#region  UpdateDataPelangan
		public int UpdateDataPelangan(string id, string nama, string alamat, string hp){
			string sql = "update tbl_pelanggan set nama_pelanggan = '"+nama+"',alamat = '"+alamat+"', no_hp = '"+hp+"' where id_pelanggan = "+id;
			//MessageBox.Show(sql.ToString());
			return CRUD(sql);
		}
		#endregion
		#region  DeleteDataPelangan
		public int DeleteDataPelangan(string id){
			string sql = "delete from tbl_pelanggan  where id_pelanggan = "+id;
			//MessageBox.Show(sql.ToString());
			return CRUD(sql);
		}
		#endregion
		#region  InsertDataTransaksi
		public int InsertDataTransaksi(int id, string bunga, int harga, int qty, string tgl, string namaPembeli){
			string sql = string.Format("insert into tbl_header_detail values({0},'{1}','{2}','{3}','{4}','{5}')",id,bunga,harga,qty,tgl,namaPembeli);
			//MessageBox.Show(sql.ToString());
			return CRUD(sql);
		}		
		#endregion
		#region  InsertHeader
		public int InsertHeader (int id_pesanan, string namaKaryawan, string tgl){
			string sql = string.Format("insert into tbl_header values({0},'{1}','{2}')",id_pesanan,namaKaryawan,tgl);			
			//MessageBox.Show(sql.ToString());
			return CRUD(sql);
		}
		#endregion
		#region  selectHeaderMAx
		public DataSet selectHeaderMax(){
			string sql = "select MAX(id_pesanan) AS id from tbl_header";
			//MessageBox.Show(sql.ToString());
			return GetData(sql);
		}
		#endregion	
	

        #region  GetPrintTransaksi
        public DataSet GetPrintTransaksi(int id)
        {
            string sql = "select nama_bunga,harga,qty,harga * qty as jumlah ,tanggal from tbl_header_detail where id_pesanan = "+id;
            MessageBox.Show(sql.ToString());
            return GetData(sql);
        }
        #endregion	


		#endregion
		
	
		#region  FORMADMIN
		#region  InsertDataBUNGA
		public int InsertDataBUNGA(string id, string bunga, string qty, string hargapk , string hargajl){
			string sql = string.Format("insert into tbl_stok values('{0}','{1}','{2}','{3}','{4}')",id,bunga,qty,hargapk,hargajl);
			//MessageBox.Show(sql.ToString());
			return CRUD(sql);
		}
		#endregion		
		#region  UpdateDataBunga
		public int UpdateDataBUNGA(int id, string bunga, int qty, int hargapk , int hargajl){
			string sql = string.Format("update tbl_stok set nama_bunga ='{0}',jumlah = {1},harga_pokok={2},harga_jual={3} where id_bunga={4}",bunga,qty,hargapk,hargajl,id);
			//MessageBox.Show(sql.ToString());
			return CRUD(sql);
		}	
		#endregion
		#region  DeleteDataBunga
		public int DeleteDataBunga(string id){
			string sql= string.Format("delete from tbl_stok where id_bunga= {0}",id);
			return CRUD(sql);
		}
		#endregion
		
		#region  TotalPendapatanPerBulan
		public DataSet TotalPendapatanPerBulan(string dmn){
			string sql = string.Format("SELECT SUM( harga * qty ) AS total FROM tbl_header_detail "+dmn);
		//	MessageBox.Show(sql.ToString());
			return GetData(sql);
		}		
		#endregion
		
		#region  GetDataPembelianSebulan
		public DataSet GetDataPembelianSebulan(string dmn){
			string sql = string.Format("SELECT * FROM `tbl_header_detail` "+dmn);
		//	MessageBox.Show(sql.ToString());
			return GetData(sql);
		}		
		#endregion
		
		#region  DeletesUserLogin
		public int DeletesUserLogin(int dmn){
			string sql = string.Format("delete from user_login where id_user = "+dmn);
			//MessageBox.Show(sql.ToString());
			return CRUD(sql);
		}		
		#endregion
		
		
		#endregion
		
	}
}
