using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sockets
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
            ChamarServidor();
        }
        private void ChamarServidor()
        {
            Servidor callServ = new Servidor();
            callServ.Show();
        }
        private static string nomeAbreviadoArquivo = "";
        private void Cliente_Load(object sender, EventArgs e)
        {
        }
        private void BtnProcurar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Cliente - Escolha o arquivo";
            dlg.ShowDialog();
            txtArquivo.Text = dlg.FileName;
            nomeAbreviadoArquivo = dlg.SafeFileName;
        }

        private void BtnEnviarArquivo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEnderecoIP.Text) &&
               string.IsNullOrEmpty(txtPortaHost.Text) &&
               string.IsNullOrEmpty(txtArquivo.Text))
            {
                MessageBox.Show("Dados Inválidos...");
                return;
            }
            //
            string enderecoIP = txtEnderecoIP.Text;
            int porta = int.Parse(txtPortaHost.Text);
            string nomeArquivo = txtArquivo.Text;
            //
            try
            {
                Task.Factory.StartNew(() => EnviarArquivo(enderecoIP, porta, nomeArquivo, nomeAbreviadoArquivo));
                MessageBox.Show("Arquivo Enviado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }
        public void EnviarArquivo(string IPHostRemoto, int PortaHostRemoto, string nomeCaminhoArquivo, string nomeAbreviadoArquivo)
        {
            try
            {
                if (!string.IsNullOrEmpty(IPHostRemoto))
                {
                    byte[] fileNameByte = Encoding.ASCII.GetBytes(nomeAbreviadoArquivo);
                    byte[] fileData = File.ReadAllBytes(nomeCaminhoArquivo);
                    byte[] clientData = new byte[4 + fileNameByte.Length + fileData.Length];
                    byte[] fileNameLen = BitConverter.GetBytes(fileNameByte.Length);
                    //
                    fileNameLen.CopyTo(clientData, 0);
                    fileNameByte.CopyTo(clientData, 4);
                    fileData.CopyTo(clientData, 4 + fileNameByte.Length);
                    //
                    TcpClient clientSocket = new TcpClient(IPHostRemoto, PortaHostRemoto);
                    NetworkStream networkStream = clientSocket.GetStream();
                    //
                    networkStream.Write(clientData, 0, clientData.GetLength(0));
                    networkStream.Close();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
