using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TelaSplashOpenMind
{
    public partial class frm : Form
    {
        Thread nt;

        public frm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(textBox1.Text=="admin" && textBox2.Text == "123456")
            {
                this.Close();
                
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            else
            {
                MessageBox.Show("Login ou Senha inválidos!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            form3 outro = new form3();
            outro.ShowDialog();
            this.Hide();
        }
    }
    }

