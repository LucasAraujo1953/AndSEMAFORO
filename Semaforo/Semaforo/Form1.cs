using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semaforo
{
    public partial class Form1 : Form
    {
        private Luzes s;
        public Form1()
        {
            InitializeComponent();
            s = new Luzes(0);
            atualizaInterface();
        }

        private void atualizaInterface()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
