using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL1;

namespace MiniSuper
{
    public partial class FormProducto : Form
    {
        public FormProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassProducto LgProducto = new ClassProducto();
            string respuesta = "";
            respuesta = LgProducto.InsertarProducto(textBox2.Text, textBox4.Text, textBox5.Text, textBox3.Text, Convert.ToDateTime("12/12/2015"),Convert.ToInt64( textBox1.Text) );
            MessageBox.Show(respuesta);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
