using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatServer
{
    public partial class Form1 : Form
    {
        private delegate void AtualizaStatusCallBack(string strMensagem);

        bool conectado = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_StartServer_Click(object sender, EventArgs e)
        {
            if (conectado)
            {
                Application.Exit();
                return;
            }

            if(txt_IP.Text == string.Empty)
            {
                MessageBox.Show("Informe o endereço IP!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_IP.Focus();
                return;
            }

            try
            {
                IPAddress enderecoIP = IPAddress.Parse(txt_IP.Text);
                int portaHost = (int)num_Porta.Value;

                Servidor mainServidor = new Servidor(enderecoIP, portaHost);

                Servidor.StatusChanged += new StatusChangedEventHandler(mainServidor_StatusChenged);

                mainServidor.IniciaAtendimento();

                lista_Log.Items.Add("Servidor ativo, aguardando usuarios conectarem-se...");
                lista_Log.SetSelected(lista_Log.Items.Count - 1, true);
            }
            catch(Exception ex)
            {
                lista_Log.Items.Add("Erro de conexão: " + ex.Message);
                lista_Log.SetSelected(lista_Log.Items.Count - 1, true);
                return;
            }

            conectado = true;
            txt_IP.Enabled = false;
            num_Porta.Enabled = false;
            btn_StartServer.ForeColor = Color.Red;
            btn_StartServer.Text = "Sair";

        }

        public void mainServidor_StatusChenged(object sender, StatusChangedEventArgs e)
        {
            this.Invoke(new AtualizaStatusCallBack(this.AtualizaStatus), new object[] { e.EventMessage });
        }

        private void AtualizaStatus(string strMensagem)
        {
            lista_Log.Items.Add(strMensagem);
            lista_Log.SetSelected(lista_Log.Items.Count - 1, true);
        }
    }
}
