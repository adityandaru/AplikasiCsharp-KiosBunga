/*
 * Created by SharpDevelop.
 * User: This
 * Date: 11/6/2013
 * Time: 11:37 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Text;
namespace kiosBunga
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private DataSet ds;
		
		public MainForm()
		{
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.MaximumSize = new Size(335, 213);
			this.MinimumSize = new Size(335, 213);
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			try {
				
				textBox1_Username.Focus();
				//textBox1_Username.Clear();
				//textBox2_Password.Clear();	
				for (int i=0; i<1; i++) {
					comboBox1_Status.Items.Add("Karyawan");
					comboBox1_Status.Items.Add("Administrator");
				}
				
			} catch (Exception ex) {
				MessageBox.Show(ex.Message.ToString());
			}
				
			
			
		}
		
		void TextBox1_UsernameKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar)) {
				e.Handled =true;
			}
		}
		
		void TextBox2_PasswordKeyPress(object sender, KeyPressEventArgs e)
		{
			
			if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar)) {
				e.Handled = true;
			}
		}
		
		public string MD5Hash(string password)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            
            //compute hash from the bytes of text
             md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(password));

            //get hash result after compute it
            byte[] result = md5.Hash;
 
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits
                //for each byte
                strBuilder.Append(result[i].ToString("x2"));
            }
 
            return strBuilder.ToString();
        }
		
		void Button1Click(object sender, EventArgs e)
		{
			try {
								
				if (textBox1_Username.Text != "" && textBox2_Password.Text != "" && comboBox1_Status.Text != "") {	
					
					string pwd = MD5Hash(textBox2_Password.Text.ToLower());
					string user  = textBox1_Username.Text.ToLower();
					string statusLogin = comboBox1_Status.Text;
					string where = string.Format("where user = '{0}' and pwd = '{1}' and status = '{2}'", user,pwd,statusLogin);
						
					ds = Koneksi.InstanceKoneksi().GetDataLogin(where);					
					if (ds.Tables[0].Rows.Count>0) {
							foreach(DataRow kolom in ds.Tables[0].Rows){
							string status =kolom["status"].ToString();	
							string pasword = kolom["pwd"].ToString();
							string userLogin = kolom["user"].ToString();
							string namaLogin = kolom["nama"].ToString();
							string id = kolom["id_user"].ToString();
							if (status == "Administrator") {
								FormUtamaAdmin formUtamaAdmin = new FormUtamaAdmin();
								formUtamaAdmin.namaLogin=namaLogin;
								formUtamaAdmin.Show();
								this.Hide();
							}else if (status == "Karyawan") {
								FormUtamaKaryawan formUtamaKaryawan = new FormUtamaKaryawan();
								formUtamaKaryawan.namaLogin=namaLogin;
								formUtamaKaryawan.userLogin=userLogin;
								formUtamaKaryawan.passLogin=pasword;
								formUtamaKaryawan.id = id;
								formUtamaKaryawan.Show();
								this.Hide();
							}else{
								MessageBox.Show("Data Anda Tidak Valid !!!");
							}
							
								//objPanelUtama.Show();
									//this.Hide();
							}
					}else{	
						MessageBox.Show("Username atau Password Tidak Ada Dalam Database!!!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
						comboBox1_Status.Items.Clear();
						comboBox1_Status.Items.Clear();
						MainFormLoad(null, null);
						
					}						
				}else{
					MessageBox.Show("Username atau Password Belum Di Isi","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message.ToString());
			}
		}
				
		void Button2Click(object sender, EventArgs e)
		{
			MainFormLoad(null,null);
		}
	}
}
