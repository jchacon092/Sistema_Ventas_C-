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
    public partial class FormCompra : Form
    {
        private List<ClassCompraDetalle> lista;
        public FormCompra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassCompraDetalle Lgdetalle = new ClassCompraDetalle();
            ClassProducto lgproducto = new ClassProducto();

            Lgdetalle.IDPRODUCTO = Convert.ToInt32(lgproducto.idproducto(Convert.ToInt64( textBox3.Text)));
            Lgdetalle.CANTIDAD = Convert.ToInt32(textBox4.Text);
            Lgdetalle.SUBTOTAL = Convert.ToDecimal(textBox5.Text);

            lista.Add(Lgdetalle);
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = lista;
            this.dataGridView1.Refresh();
        }

        private void FormCompra_Load(object sender, EventArgs e)
        {
            lista = new List<ClassCompraDetalle>();
           

            ClassProveedor LgProv = new ClassProveedor();
            this.comboBox1.DataSource = LgProv.ListarProveedor();
            this.comboBox1.DisplayMember = "Nombre_proveedor";
            this.comboBox1.ValueMember = "Id_proveedor";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClassCompra LgCompra = new ClassCompra();
            string respuesta = "";
            respuesta = LgCompra.InsertaCompra(lista, Convert.ToDecimal(textBox2.Text), Convert.ToInt32(textBox1.Text), Convert.ToInt32(this.comboBox1.SelectedValue));
            MessageBox.Show(respuesta);
        }
    }
}
