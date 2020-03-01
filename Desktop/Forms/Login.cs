using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Threading;
using System.ComponentModel;
using Core;

namespace Desktop_app
{
    public partial class Login : Form
    {
        List<object> list;
        bool AsAdmin;
        

        public Login()
        {
            InitializeComponent();
            load_pb.ImageLocation = "S:\\load.gif";
            load_pb.Visible = false;
            Buscar.Editor.CPF = string.Empty;
            Buscar.Editor.ID = 0;
        }
		void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
            Buscar.Usuario.Login(list[0], list[1]);
        }
       
        void Submit_Login(object sender, EventArgs e){
            load_pb.Visible = true;
            AsAdmin = modoAdministrador.Checked;
            Preencher.List(list = new List<object>(), editor);
            if (Validar.Formulario(editor))
            {
                Buscar.Usuario.Classe = AsAdmin ? "administrador" : "funcionario";
                try{
                	this.backgroundWorker1.RunWorkerAsync();
                }catch(Exception ex){
                
                }
            }
            else
            {
                MessageBox.Show(Msg.PreechimentoIncorreto, Msg.Title.Atencao);
                load_pb.Visible = false;
            }
            cpf_input.Focus();
            cpf_input.SelectAll();

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (Buscar.Usuario.ID.Equals(0))
            {
                MessageBox.Show(Msg.CpfSenhaNaoCoincide, Msg.Title.Atencao);
                senha_input.Clear();
                load_pb.Visible = false;
            }
            else
            {
                Hide();

                if (AsAdmin)
                {
                    new Administracao().ShowDialog(this);
                }
                else
                {
                    new Atendimento().ShowDialog(this);
                }
                Show();
                cpf_input.Clear();
                senha_input.Clear();
                modoAdministrador.Checked = false;
                load_pb.Visible = false;
            }
        }
    }
}
