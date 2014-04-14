/*
 * Created by SharpDevelop.
 * User: This
 * Date: 11/6/2013
 * Time: 11:37 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace kiosBunga
{
	partial class MainForm
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
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1_Username = new System.Windows.Forms.TextBox();
			this.textBox2_Password = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.comboBox1_Status = new System.Windows.Forms.ComboBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(11, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Username";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(12, 113);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Password";
			// 
			// textBox1_Username
			// 
			this.textBox1_Username.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox1_Username.Location = new System.Drawing.Point(74, 81);
			this.textBox1_Username.Name = "textBox1_Username";
			this.textBox1_Username.Size = new System.Drawing.Size(121, 20);
			this.textBox1_Username.TabIndex = 2;
			this.textBox1_Username.Text = "kw";
			this.textBox1_Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_UsernameKeyPress);
			// 
			// textBox2_Password
			// 
			this.textBox2_Password.BackColor = System.Drawing.Color.White;
			this.textBox2_Password.Location = new System.Drawing.Point(74, 110);
			this.textBox2_Password.Name = "textBox2_Password";
			this.textBox2_Password.PasswordChar = '*';
			this.textBox2_Password.Size = new System.Drawing.Size(121, 20);
			this.textBox2_Password.TabIndex = 3;
			this.textBox2_Password.Text = "kw";
			this.textBox2_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2_PasswordKeyPress);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label3.Location = new System.Drawing.Point(25, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(246, 42);
			this.label3.TabIndex = 5;
			this.label3.Text = "Login Administrator";
		
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(206, 75);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 40);
			this.button1.TabIndex = 6;
			this.button1.Text = "Masuk";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// comboBox1_Status
			// 
			this.comboBox1_Status.FormattingEnabled = true;
			this.comboBox1_Status.Location = new System.Drawing.Point(74, 136);
			this.comboBox1_Status.Name = "comboBox1_Status";
			this.comboBox1_Status.Size = new System.Drawing.Size(121, 21);
			this.comboBox1_Status.TabIndex = 7;
			this.comboBox1_Status.Text = "karyawan";
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(206, 121);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(96, 39);
			this.button2.TabIndex = 8;
			this.button2.Text = "Hapus";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(11, 139);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "Status";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Blue;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(319, 175);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.comboBox1_Status);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox2_Password);
			this.Controls.Add(this.textBox1_Username);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kios Bunga By Ndaru";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ComboBox comboBox1_Status;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1_Username;
		private System.Windows.Forms.TextBox textBox2_Password;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
