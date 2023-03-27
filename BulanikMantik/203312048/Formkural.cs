using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YAPAY_ZEKA
{
    public partial class Formkural : Form
    {
        


        public Formkural()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KuralSonraki sonraki = new KuralSonraki();
            sonraki.Show();
        }
    }
}
