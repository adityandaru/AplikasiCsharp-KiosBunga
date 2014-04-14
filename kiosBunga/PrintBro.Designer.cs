/*
 * Created by SharpDevelop.
 * User: No More Tear
 * Date: 1/20/2014
 * Time: 9:34 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace kiosBunga
{
	partial class PrintBro
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.Size = new System.Drawing.Size(911, 499);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // PrintBro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 499);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "PrintBro";
            this.Text = "PrintBro";
            this.Load += new System.EventHandler(this.PrintBroLoad);
            this.ResumeLayout(false);

		}

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
	}
}
