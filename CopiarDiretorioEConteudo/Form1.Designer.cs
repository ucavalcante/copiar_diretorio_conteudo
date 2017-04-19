namespace CopiarDiretorioEConteudo
{
    partial class CopiarDiretorioEConteudo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        private void InitializeComponent()
        {
            this.txbDirFonte = new System.Windows.Forms.TextBox();
            this.btnDiretorioOrigem = new System.Windows.Forms.Button();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.txbDestino = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbArqMaquinas = new System.Windows.Forms.TextBox();
            this.btnCarregarArquivos = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblStatus = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.chkBxSobrescrever = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQtdSucesso = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblQtdFalha = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblQtdTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbDirFonte
            // 
            this.txbDirFonte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDirFonte.Location = new System.Drawing.Point(12, 25);
            this.txbDirFonte.Name = "txbDirFonte";
            this.txbDirFonte.Size = new System.Drawing.Size(339, 20);
            this.txbDirFonte.TabIndex = 0;
            this.txbDirFonte.Text = "\\\\credi010\\Softlib\\Altitude\\script";
            // 
            // btnDiretorioOrigem
            // 
            this.btnDiretorioOrigem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDiretorioOrigem.Location = new System.Drawing.Point(357, 23);
            this.btnDiretorioOrigem.Name = "btnDiretorioOrigem";
            this.btnDiretorioOrigem.Size = new System.Drawing.Size(75, 23);
            this.btnDiretorioOrigem.TabIndex = 1;
            this.btnDiretorioOrigem.Text = "Diretorio";
            this.btnDiretorioOrigem.UseVisualStyleBackColor = true;
            this.btnDiretorioOrigem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCopiar
            // 
            this.btnCopiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopiar.Location = new System.Drawing.Point(357, 124);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(75, 23);
            this.btnCopiar.TabIndex = 3;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // txbDestino
            // 
            this.txbDestino.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDestino.Location = new System.Drawing.Point(12, 126);
            this.txbDestino.Name = "txbDestino";
            this.txbDestino.Size = new System.Drawing.Size(339, 20);
            this.txbDestino.TabIndex = 4;
            this.txbDestino.Text = "\\C$\\script";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Diretorio de Origem que será copiado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Caminho de destino que será criado na maquina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Arquivo com os nomes das maquinas";
            // 
            // txbArqMaquinas
            // 
            this.txbArqMaquinas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbArqMaquinas.Location = new System.Drawing.Point(12, 64);
            this.txbArqMaquinas.Name = "txbArqMaquinas";
            this.txbArqMaquinas.Size = new System.Drawing.Size(339, 20);
            this.txbArqMaquinas.TabIndex = 9;
            this.txbArqMaquinas.Text = "\\\\credi010\\Softlib\\Altitude\\maquinas.txt";
            // 
            // btnCarregarArquivos
            // 
            this.btnCarregarArquivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarregarArquivos.Location = new System.Drawing.Point(357, 62);
            this.btnCarregarArquivos.Name = "btnCarregarArquivos";
            this.btnCarregarArquivos.Size = new System.Drawing.Size(75, 23);
            this.btnCarregarArquivos.TabIndex = 10;
            this.btnCarregarArquivos.Text = "Maquinas";
            this.btnCarregarArquivos.UseVisualStyleBackColor = true;
            this.btnCarregarArquivos.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 149);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status";
            // 
            // txbStatus
            // 
            this.txbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbStatus.Location = new System.Drawing.Point(15, 165);
            this.txbStatus.Multiline = true;
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbStatus.Size = new System.Drawing.Size(417, 102);
            this.txbStatus.TabIndex = 12;
            // 
            // chkBxSobrescrever
            // 
            this.chkBxSobrescrever.AutoSize = true;
            this.chkBxSobrescrever.Location = new System.Drawing.Point(15, 90);
            this.chkBxSobrescrever.Name = "chkBxSobrescrever";
            this.chkBxSobrescrever.Size = new System.Drawing.Size(133, 17);
            this.chkBxSobrescrever.TabIndex = 13;
            this.chkBxSobrescrever.Text = "Sobrescrever Arquivos";
            this.chkBxSobrescrever.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(15, 286);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(417, 23);
            this.progressBar1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Sucesso:";
            // 
            // lblQtdSucesso
            // 
            this.lblQtdSucesso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblQtdSucesso.AutoSize = true;
            this.lblQtdSucesso.Location = new System.Drawing.Point(71, 270);
            this.lblQtdSucesso.Name = "lblQtdSucesso";
            this.lblQtdSucesso.Size = new System.Drawing.Size(0, 13);
            this.lblQtdSucesso.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Falha:";
            // 
            // lblQtdFalha
            // 
            this.lblQtdFalha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblQtdFalha.AutoSize = true;
            this.lblQtdFalha.Location = new System.Drawing.Point(156, 270);
            this.lblQtdFalha.Name = "lblQtdFalha";
            this.lblQtdFalha.Size = new System.Drawing.Size(0, 13);
            this.lblQtdFalha.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Total:";
            // 
            // lblQtdTotal
            // 
            this.lblQtdTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblQtdTotal.AutoSize = true;
            this.lblQtdTotal.Location = new System.Drawing.Point(239, 270);
            this.lblQtdTotal.Name = "lblQtdTotal";
            this.lblQtdTotal.Size = new System.Drawing.Size(0, 13);
            this.lblQtdTotal.TabIndex = 20;
            // 
            // CopiarDiretorioEConteudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 321);
            this.Controls.Add(this.lblQtdTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblQtdFalha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblQtdSucesso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.chkBxSobrescrever);
            this.Controls.Add(this.txbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnCarregarArquivos);
            this.Controls.Add(this.txbArqMaquinas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbDestino);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.btnDiretorioOrigem);
            this.Controls.Add(this.txbDirFonte);
            this.Name = "CopiarDiretorioEConteudo";
            this.Text = "Copiar Diretorio e Conteudo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbDirFonte;
        private System.Windows.Forms.Button btnDiretorioOrigem;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.TextBox txbDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbArqMaquinas;
        private System.Windows.Forms.Button btnCarregarArquivos;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.CheckBox chkBxSobrescrever;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQtdSucesso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblQtdFalha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblQtdTotal;
    }
}

