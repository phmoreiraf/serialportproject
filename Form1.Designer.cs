namespace Teste_Serial
{
    partial class SerialForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.spPorts = new System.IO.Ports.SerialPort(this.components);
            this.cbx_portacom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_abrirporta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_envios = new System.Windows.Forms.TextBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_receber = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_testeenvio = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bgWorkerIndeterminada = new System.ComponentModel.BackgroundWorker();
            this.lbl_porcetagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // spPorts
            // 
            this.spPorts.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.spComunica_DataReceived);
            // 
            // cbx_portacom
            // 
            this.cbx_portacom.FormattingEnabled = true;
            this.cbx_portacom.Location = new System.Drawing.Point(135, 76);
            this.cbx_portacom.Name = "cbx_portacom";
            this.cbx_portacom.Size = new System.Drawing.Size(121, 21);
            this.cbx_portacom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teste Serial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Porta:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_abrirporta
            // 
            this.btn_abrirporta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_abrirporta.Location = new System.Drawing.Point(276, 76);
            this.btn_abrirporta.Name = "btn_abrirporta";
            this.btn_abrirporta.Size = new System.Drawing.Size(75, 23);
            this.btn_abrirporta.TabIndex = 3;
            this.btn_abrirporta.Text = "Abrir";
            this.btn_abrirporta.UseVisualStyleBackColor = true;
            this.btn_abrirporta.Click += new System.EventHandler(this.btn_abrirporta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Envios: ";
            // 
            // txt_envios
            // 
            this.txt_envios.Enabled = false;
            this.txt_envios.Location = new System.Drawing.Point(135, 128);
            this.txt_envios.Name = "txt_envios";
            this.txt_envios.Size = new System.Drawing.Size(121, 20);
            this.txt_envios.TabIndex = 5;
            // 
            // btn_enviar
            // 
            this.btn_enviar.Enabled = false;
            this.btn_enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar.Location = new System.Drawing.Point(276, 128);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(75, 23);
            this.btn_enviar.TabIndex = 6;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Receber:";
            // 
            // txt_receber
            // 
            this.txt_receber.Location = new System.Drawing.Point(16, 301);
            this.txt_receber.Multiline = true;
            this.txt_receber.Name = "txt_receber";
            this.txt_receber.Size = new System.Drawing.Size(335, 131);
            this.txt_receber.TabIndex = 8;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 166);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(257, 23);
            this.progressBar1.TabIndex = 9;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // lbl_testeenvio
            // 
            this.lbl_testeenvio.AutoSize = true;
            this.lbl_testeenvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_testeenvio.Location = new System.Drawing.Point(12, 205);
            this.lbl_testeenvio.Name = "lbl_testeenvio";
            this.lbl_testeenvio.Size = new System.Drawing.Size(0, 20);
            this.lbl_testeenvio.TabIndex = 10;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // bgWorkerIndeterminada
            // 
            this.bgWorkerIndeterminada.WorkerReportsProgress = true;
            this.bgWorkerIndeterminada.WorkerSupportsCancellation = true;
            // 
            // lbl_porcetagem
            // 
            this.lbl_porcetagem.AutoSize = true;
            this.lbl_porcetagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_porcetagem.Location = new System.Drawing.Point(288, 176);
            this.lbl_porcetagem.Name = "lbl_porcetagem";
            this.lbl_porcetagem.Size = new System.Drawing.Size(0, 12);
            this.lbl_porcetagem.TabIndex = 11;
            // 
            // SerialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 462);
            this.Controls.Add(this.lbl_porcetagem);
            this.Controls.Add(this.lbl_testeenvio);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txt_receber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.txt_envios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_abrirporta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_portacom);
            this.Name = "SerialForm";
            this.Text = "Teste Serial";
            this.Load += new System.EventHandler(this.SerialForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort spPorts;
        private System.Windows.Forms.ComboBox cbx_portacom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_abrirporta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_envios;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_receber;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbl_testeenvio;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker bgWorkerIndeterminada;
        private System.Windows.Forms.Label lbl_porcetagem;
    }
}

