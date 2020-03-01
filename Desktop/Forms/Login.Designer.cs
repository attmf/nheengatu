using Core;

namespace Desktop_app
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.cpf_input = new System.Windows.Forms.MaskedTextBox();
            this.senha_input = new System.Windows.Forms.TextBox();
            this.cpf_label = new System.Windows.Forms.Label();
            this.senha_label = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.editor = new System.Windows.Forms.Panel();
            this.load_pb = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.modoAdministrador = new System.Windows.Forms.CheckBox();
            this.splash = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.formulario = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.editor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.load_pb)).BeginInit();
            this.splash.SuspendLayout();
            this.formulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // cpf_input
            // 
            this.cpf_input.BackColor = System.Drawing.Color.White;
            this.cpf_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.cpf_input, "cpf_input");
            this.cpf_input.ForeColor = System.Drawing.Color.Black;
            this.cpf_input.Name = "cpf_input";
            // 
            // senha_input
            // 
            this.senha_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.senha_input, "senha_input");
            this.senha_input.ForeColor = System.Drawing.Color.Black;
            this.senha_input.Name = "senha_input";
            this.senha_input.UseSystemPasswordChar = true;
            // 
            // cpf_label
            // 
            resources.ApplyResources(this.cpf_label, "cpf_label");
            this.cpf_label.ForeColor = System.Drawing.Color.White;
            this.cpf_label.Name = "cpf_label";
            // 
            // senha_label
            // 
            resources.ApplyResources(this.senha_label, "senha_label");
            this.senha_label.ForeColor = System.Drawing.Color.White;
            this.senha_label.Name = "senha_label";
            // 
            // btn_submit
            // 
            resources.ApplyResources(this.btn_submit, "btn_submit");
            this.btn_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_submit.FlatAppearance.BorderSize = 0;
            this.btn_submit.ForeColor = System.Drawing.Color.White;
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.Submit_Login);
            // 
            // editor
            // 
            this.editor.BackColor = Colors.Primary;
            this.editor.Controls.Add(this.load_pb);
            this.editor.Controls.Add(this.label3);
            this.editor.Controls.Add(this.cpf_label);
            this.editor.Controls.Add(this.cpf_input);
            this.editor.Controls.Add(this.senha_label);
            this.editor.Controls.Add(this.senha_input);
            this.editor.Controls.Add(this.modoAdministrador);
            this.editor.Controls.Add(this.btn_submit);
            resources.ApplyResources(this.editor, "editor");
            this.editor.ForeColor = System.Drawing.Color.Black;
            this.editor.Name = "editor";
            // 
            // load_pb
            // 
            resources.ApplyResources(this.load_pb, "load_pb");
            this.load_pb.Name = "load_pb";
            this.load_pb.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Name = "label3";
            // 
            // modoAdministrador
            // 
            resources.ApplyResources(this.modoAdministrador, "modoAdministrador");
            this.modoAdministrador.ForeColor = System.Drawing.Color.White;
            this.modoAdministrador.Name = "modoAdministrador";
            this.modoAdministrador.UseVisualStyleBackColor = true;
            // 
            // splash
            // 
            this.splash.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.splash, "splash");
            this.splash.Controls.Add(this.label2);
            this.splash.Controls.Add(this.label1);
            this.splash.ForeColor = System.Drawing.Color.Black;
            this.splash.Name = "splash";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // formulario
            // 
            this.formulario.Controls.Add(this.editor);
            this.formulario.Controls.Add(this.splash);
            resources.ApplyResources(this.formulario, "formulario");
            this.formulario.ForeColor = System.Drawing.Color.Black;
            this.formulario.Name = "formulario";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Login
            // 
            this.AcceptButton = this.btn_submit;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.formulario);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.editor.ResumeLayout(false);
            this.editor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.load_pb)).EndInit();
            this.splash.ResumeLayout(false);
            this.splash.PerformLayout();
            this.formulario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        System.Windows.Forms.MaskedTextBox cpf_input;
        System.Windows.Forms.TextBox senha_input;
        System.Windows.Forms.Label cpf_label;
        System.Windows.Forms.Label senha_label;
        System.Windows.Forms.Button btn_submit;
        System.Windows.Forms.Panel editor;
        System.Windows.Forms.CheckBox modoAdministrador;
        System.Windows.Forms.Panel splash;
        System.Windows.Forms.Panel formulario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox load_pb;
    }
}

