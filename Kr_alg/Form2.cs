using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kr_alg
{
    public partial class Weight : Form
    {
        public int m_nWeight;
        public Weight()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {

                MessageBox.Show("please enter value");
        }
            else
            {
                m_nWeight = int.Parse(textBox1.Text);
                this.Close();
            }
        }
    }
}
