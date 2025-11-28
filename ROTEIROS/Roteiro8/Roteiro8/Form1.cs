using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Roteiro8
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0x00A1;
        public const int HT_CAPTION = 0x02;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Fecha o formulário principal
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            // Permite arrastar o formulário clicando no panel1
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, IntPtr.Zero);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form2>();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form3>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form4>();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form5>();
        }

        private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            // Versão simples: só abre o formulário
            Forms formulario = new Forms();
            formulario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Maximiza a janela
            this.WindowState = FormWindowState.Maximized;
            btnNormal.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            // Volta ao tamanho normal
            this.WindowState = FormWindowState.Normal;
            btnNormal.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Evento vazio (pode remover se não usar)
        }
    }
}
