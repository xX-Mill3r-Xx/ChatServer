using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatServer
{
    class Conexao
    {
        TcpClient tcpCliente;

        private Thread thrSender;

        private StreamReader srReceptor;

        private StreamWriter swEnviador;

        private string usuarioAtual;
        private string strResposta;

        public Conexao(TcpClient tcpCon)
        {
            tcpCliente = tcpCon;

            thrSender = new Thread(AceitaCliente);
            thrSender.IsBackground = true;
            thrSender.Start();
        }

        private void FechaConexao()
        {
            tcpCliente.Close();
            srReceptor.Close();
            swEnviador.Close();
        }

        private void AceitaCliente()
        {
            srReceptor = new StreamReader(tcpCliente.GetStream());
            swEnviador = new StreamWriter(tcpCliente.GetStream());

            usuarioAtual = srReceptor.ReadLine();
            if(usuarioAtual != "")
            {
                if (Servidor.htUsuarios.Contains(usuarioAtual))
                {
                    swEnviador.WriteLine("0|Este Nome de Usuario ja existe!");
                    swEnviador.Flush();
                    FechaConexao();
                    return;
                }
                else if (usuarioAtual == "Administrador")
                {
                    swEnviador.WriteLine("0|Este Nome de Usuario é Reservado!");
                    swEnviador.Flush();
                    FechaConexao();
                    return;
                }
                else
                {
                    swEnviador.WriteLine("1");
                    swEnviador.Flush();

                    Servidor.IncluirUsuario(tcpCliente, usuarioAtual);
                }
            }
            else
            {
                FechaConexao();
                return;
            }

            try
            {
                while ((strResposta = srReceptor.ReadLine()) != "")
                {
                    if (strResposta == null)
                    {
                        Servidor.RemoveUsuario(tcpCliente);
                    }
                    else
                    {
                        Servidor.EnviaMensagem(usuarioAtual, strResposta);
                    }
                }
            }
            catch
            {
                Servidor.RemoveUsuario(tcpCliente);
            }
        }
    }
}
