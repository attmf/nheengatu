/*
 * Created by SharpDevelop.
 * User: casadodoce
 * Date: 06/08/2018
 * Time: 15:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Desktop_app
{
	partial class Loading
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox load_pb;
		
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
			this.load_pb = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.load_pb)).BeginInit();
			this.SuspendLayout();
			// 
			// load_pb
			// 
			this.load_pb.ErrorImage = null;
			this.load_pb.InitialImage = null;
			this.load_pb.Location = new System.Drawing.Point(339, 215);
			this.load_pb.Name = "load_pb";
			this.load_pb.Size = new System.Drawing.Size(150, 150);
			this.load_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.load_pb.TabIndex = 0;
			this.load_pb.TabStop = false;
			// 
			// Loading
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(810, 562);
			this.Controls.Add(this.load_pb);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Loading";
			this.Text = "Loading";
			((System.ComponentModel.ISupportInitialize)(this.load_pb)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
