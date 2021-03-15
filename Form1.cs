using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace Teste_Serial
{
    public partial class SerialForm : Form
    {
        public SerialForm()
        {
            InitializeComponent();
        }

        private void SerialForm_Load(object sender, EventArgs e)
        {
            string[] portas = SerialPort.GetPortNames();

            cbx_portacom.Sorted = true;

            foreach(var ports in portas)
            {
                cbx_portacom.Items.Add(ports);
            }


            if(cbx_portacom.Items.Count > 0)
            {
                cbx_portacom.SelectedIndex = 0;
            }
        }

        private void TarefaLonga(int p)
        {
            for (int i = 0; i <= 10; i++)
            {
                Thread.Sleep(p);
                lbl_testeenvio.BeginInvoke(
                    new Action(() =>
                    {
                        lbl_testeenvio.Text = "Teste Serial  " + i.ToString() + "Concluido";
                    }
                   ));
            }
        }

        private void btn_abrirporta_Click(object sender, EventArgs e)
        {
            if (spPorts.IsOpen)
            {
                btn_abrirporta.Text = "Abrir";
                spPorts.Close();
            }
            else
            {
                if(cbx_portacom.Text == "")
                {
                    MessageBox.Show("Nao Foi possivel abrir uma porta serial", "Error Porta serial" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    btn_abrirporta.Text = "Fechar";
                    spPorts.PortName = cbx_portacom.Text;
                    spPorts.BaudRate = 9600;
                    spPorts.Open();
                }
                
            }

            btn_enviar.Enabled = txt_envios.Enabled = spPorts.IsOpen;
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            if (txt_envios.Text == "")
            {
                MessageBox.Show("Nao Foi possivel enviar uma porta serial", "Error Porta serial", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                spPorts.Write(txt_envios.Text);
            }
            
            btn_enviar.Enabled = false;

            progressBar1.Style = ProgressBarStyle.Blocks;
            progressBar1.Value = 0;

            backgroundWorker1.RunWorkerAsync();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void spComunica_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            BeginInvoke((MethodInvoker) (() => { txt_receber.Text += spPorts.ReadExisting(); } ));

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                TarefaLonga(20);
                this.backgroundWorker1.ReportProgress(i);

                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;

                    backgroundWorker1.ReportProgress(0);
                    return;
                }
            }
            backgroundWorker1.ReportProgress(100);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;

            lbl_porcetagem.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lbl_porcetagem.Text = "Operação Cancelada!";

                lbl_porcetagem.Text = string.Empty;
            }
            else if (e.Error != null)
            {
                lbl_porcetagem.Text = "Aconteceu um erro durante a execução do processo!";
            }
            else
            {
                lbl_porcetagem.Text = "Serial Enviada!";
            }
        }
    }
}
