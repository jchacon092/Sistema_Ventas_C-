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
    public partial class FormSerie : Form
    {
        public FormSerie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassSerie LgSerie = new ClassSerie();
            string respuesta = "";
            respuesta = LgSerie.InsertarSerie(textBox1.Text, textBox2.Text, textBox3.Text);
            MessageBox.Show(respuesta);

        }
    }
}
