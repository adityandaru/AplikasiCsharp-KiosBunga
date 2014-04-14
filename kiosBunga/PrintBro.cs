/*
 * Created by SharpDevelop.
 * User: No More Tear
 * Date: 1/20/2014
 * Time: 9:34 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using MySql.Data.MySqlClient;

namespace kiosBunga
{
	/// <summary>
	/// Description of PrintBro.
	/// </summary>
	public partial class PrintBro : Form
	{
        public FormUtamaKaryawan fuk1 = null;
        private DataSet ds; 

		public PrintBro()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
            MessageBox.Show("id = " );
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

        public PrintBro(int id )
        {            
            InitializeComponent();
            MessageBox.Show("id = "+id);
            ds = Koneksi.InstanceKoneksi().selectHeaderMax();
           
        }
		void PrintBroLoad(object sender, EventArgs e)
		{
            ReportDocument rd = new ReportDocument();
            rd.Load("../../CrystalReport1.rpt");
            rd.Database.Tables[0].SetDataSource(ds.Tables[0]);
            crystalReportViewer1.ReportSource = rd;
            crystalReportViewer1.Refresh();


		}
	}
}
