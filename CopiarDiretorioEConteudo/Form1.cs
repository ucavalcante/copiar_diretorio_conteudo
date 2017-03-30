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

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            txbStatus.Text = "";
            carregarMaquinas();
            foreach (string item in maquinas)
            {
                try
                {
                    //DirectoryCopy(txbDirFonte.Text, "\\\\" + item + txbDestino.Text, true,chkBxSobrescrever.Checked);
                    System.Threading.Thread.Sleep(500);


                    log.GravarLog("Copia realizada com sucesso para\r\n " + item+ "\r\n--------------", GetType().Name.ToString());
                    txbStatus.Invoke ((MethodInvoker)  (() => txbStatus.Text = txbStatus.Text + "\r\n" + item + " Copia Realizada."));
                }
                catch (Exception ex)
                {
                    log.GravarLog(ex.Message, GetType().Name.ToString());
                    txbStatus.Text = txbStatus.Text + "\r\n" + item + " Falha: " + ex.Message;
                }
            }
        }
    }
}
