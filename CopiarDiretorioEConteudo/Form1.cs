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

            if (Directory.Exists( arquivo.Directory.ToString()))
            {
                openFileDialog1.InitialDirectory = arquivo.Directory.ToString();
                openFileDialog1.FileName = txbArqMaquinas.Text;
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK )
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
            
            if (folderBrowserDialog1.ShowDialog()== DialogResult.OK)
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

        string message = "";
        private async void btnCopiar_Click(object sender, EventArgs e)
        {
            int qtdSucesso = 0;
            int qtdFalha = 0;
            txbStatus.Text = "";

            try
            {
                carregarMaquinas();

                // Display the ProgressBar control.
                progressBar1.Visible = true;
                // Set Minimum to 1 to represent the first file being copied.
                progressBar1.Minimum = 1;
                // Set Maximum to the total number of files to copy.
                progressBar1.Maximum = maquinas.Count;
                // Set the initial value of the ProgressBar.
                progressBar1.Value = 1;
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
                    message = "";
                    progressBar1.PerformStep();

                    int t = await Task.Run(() => executarCopia(item));

                    if (t == 1)
                    {
                        qtdSucesso++;
                        lblQtdSucesso.Text = Convert.ToString(qtdSucesso);
                        log.GravarLog("Copia realizada com sucesso para\r\n " + item + "\r\n--------------", GetType().Name.ToString());
                        txbStatus.AppendText(item + " Copia Realizada.\r\n");
                        //txbStatus.Invoke((MethodInvoker)(() => txbStatus.Text = txbStatus.Text + "\r\n" + item + " Copia Realizada."));
                    }
                    else
                    {
                        qtdFalha++;
                        lblQtdFalha.Text = Convert.ToString(qtdFalha);

                        txbStatus.AppendText(item + " Falha: " + message);
                        //txbStatus.Text = txbStatus.Text + "\r\n" + item + " Falha: " + message;
                    }
                    lblQtdTotal.Text = Convert.ToString(qtdFalha + qtdSucesso);
                }
                catch (Exception ex)
                {
                    log.GravarLog(ex.Message, GetType().Name.ToString());
                    message = ex.Message;
                    MessageBox.Show(ex.Message);
                }
            }
            MessageBox.Show("Processo Concluido");
            
        }

        public int executarCopia(string nomeMaquina)
        {
            try
            {
                System.Threading.Thread.Sleep(50);
#if !DEBUG
                 Copiadora.DirectoryCopy(txbDirFonte.Text, "\\\\" + nomeMaquina + txbDestino.Text, true,chkBxSobrescrever.Checked);
#endif                
                return 1;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return 0;
            }
            
            
        }
    }
}
