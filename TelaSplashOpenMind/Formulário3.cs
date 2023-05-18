using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaSplashOpenMind
{
    public partial class Formulário3 : Form
    {
        public Formulário3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Sistema ativado";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Sistema Desativado";
        }
    }
}
