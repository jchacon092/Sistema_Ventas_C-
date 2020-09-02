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
    public partial class FormEmpleado : Form
    {
        public FormEmpleado()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void FormEmpleado_Load(object sender, EventArgs e)
        {
            ClassUsuario LgRol = new ClassUsuario();
            this.comboBox1.DataSource = LgRol.ListarRol();
            this.comboBox1.DisplayMember = "Nombre_rol";
            this.comboBox1.ValueMember = "Id_rol";
            this.comboBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassEmpleado LgEmple = new ClassEmpleado();
            string respuesta = "";
            respuesta = LgEmple.InsertarEmpleado(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, Convert.ToInt32(this.comboBox1.SelectedValue));
            MessageBox.Show(respuesta);
        }
    }
}
