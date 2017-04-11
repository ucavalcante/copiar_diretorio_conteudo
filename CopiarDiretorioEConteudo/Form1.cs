using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;


namespace CopiarDiretorioEConteudo
{
    public partial class CopiarDiretorioEConteudo : Form
    {
        Log log = new Log();
        public CopiarDiretorioEConteudo()
        {
            InitializeComponent();
        }
        ArrayList maquinas = new ArrayList();
        private void Form1_Load(object sender, EventArgs e)
        {


        }



        private void button3_Click(object sender, EventArgs e)
        {
            FileInfo arquivo = new FileInfo(txbArqMaquinas.Text);

            if (Directory.Exists(arquivo.Directory.ToString()))
            {
                openFileDialog1.InitialDirectory = arquivo.Directory.ToString();
                openFileDialog1.FileName = txbArqMaquinas.Text;
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txbArqMaquinas.Text = openFileDialog1.FileName;
                    carregarMaquinas();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txbDirFonte.Text))
            {
                folderBrowserDialog1.SelectedPath = txbDirFonte.Text;
            }

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txbDirFonte.Text = folderBrowserDialog1.SelectedPath;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error: Could not read directory from disk. Original error: " + ex.Message);
                }
            }

        }
        private void carregarMaquinas()
        {
            maquinas.Clear();
            using (StreamReader sr = new StreamReader(txbArqMaquinas.Text))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    maquinas.Add(line);
                }
            }
        }


        Queue<string> mensagens = new Queue<string>();

        private async void btnCopiar_Click(object sender, EventArgs e)
        {
            log.GravarLog("Iniciando copia dos arquivos contidos em:"+txbDirFonte.Text+ "\r\nPara as Maquinas dentro do arquivo"+txbArqMaquinas.Text , GetType().Name.ToString());
            btnCopiar.Enabled = false;
            int qtdSucesso = 0;
            int qtdFalha = 0;
            txbStatus.Text = "";

            try
            {
                carregarMaquinas();

                // Display the ProgressBar control.
                progressBar1.Visible = true;
                // Set Minimum to 1 to represent the first file being copied.
                progressBar1.Minimum = 0;
                // Set Maximum to the total number of files to copy.
                progressBar1.Maximum = maquinas.Count;
                // Set the initial value of the ProgressBar.
                progressBar1.Value = 0;
                // Set the Step property to a value of 1 to represent each file being copied.
                progressBar1.Step = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao carregar arquivo de maquinas:\r\n" + ex.Message);
            }

            foreach (string item in maquinas)
            {
                try
                {
                    bool t = await Task.Run(() => CopiaRealizada(item));

                    if (t)
                    {
                        qtdSucesso++;
                        lblQtdSucesso.Text = Convert.ToString(qtdSucesso);
                    }
                    else
                    {
                        qtdFalha++;
                        lblQtdFalha.Text = Convert.ToString(qtdFalha);
                    }
                    lblQtdTotal.Text = Convert.ToString(qtdFalha + qtdSucesso);
                    progressBar1.PerformStep();
                }
                catch (Exception ex)
                {
                    log.GravarLog(ex.Message, GetType().Name.ToString());

                    MessageBox.Show(ex.Message);
                }
                while (mensagens.Count > 0)
                {
                    txbStatus.AppendText(mensagens.Dequeue());
                }
            }
            MessageBox.Show("Processo Concluido");
            btnCopiar.Enabled = true;
            log.GravarLog("Copia Finalizada dos arquivos contidos em:" + txbDirFonte.Text + "\r\nPara as Maquinas dentro do arquivo:" + txbArqMaquinas.Text, GetType().Name.ToString());
        }

        public bool CopiaRealizada(string nomeMaquina)
        {
            try
            {
#if !DEBUG
                Copiadora.DirectoryCopy(txbDirFonte.Text, "\\\\" + nomeMaquina + txbDestino.Text, true, chkBxSobrescrever.Checked);
#endif          
                string msg = "Maquina: " + nomeMaquina + " Copia realizada com sucesso";
                if (!msg.EndsWith("\r\n"))
                {
                    msg = msg + "\r\n";
                }
                log.GravarLog(msg, GetType().Name.ToString());
                mensagens.Enqueue(msg);
                return true;
            }
            catch (Exception ex)
            {
                string msg = "Maquina: " + nomeMaquina + " Falha: " + ex.Message;
                if (!msg.EndsWith("\r\n"))
                {
                    msg = msg + "\r\n";
                }
                log.GravarLog(msg, GetType().Name.ToString());
                mensagens.Enqueue(msg);
                return false;
            }


        }
    }
}
