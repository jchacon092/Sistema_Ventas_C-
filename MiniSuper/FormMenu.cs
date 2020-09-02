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
    public partial class FormMenu : Form
    {

        public ClassVariables VAR;
        public FormMenu()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* Factura f1 = new Factura();
            f1.variable = VAR;
            f1.Show();
            */
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            if(VAR.ROL=="bodeguero")
            {
                treeView1.Nodes[2].Remove();
                treeView1.Nodes[3].Remove();
                treeView1.Nodes[2].Remove();
                treeView1.Nodes[2].Remove();
            }
            

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Parent != null)
            {
                //en este foreach cierra las ventanas hijas para que solo exista una abierta a la vez.

                foreach (Form f in this.MdiChildren)
                {
                    f.Close();
                }
                //Este switch invocará al formulario que se abrirá según el nodo del menú.

                FormMenu fmenu = new FormMenu();

                switch (e.Node.Text)
                {
                    case "Factura":
                        Factura fAgrega = new Factura();
                        fAgrega.MdiParent = this;
                        fAgrega.variable = VAR;
                        fAgrega.Show();
                        fmenu.Size = new Size(fAgrega.Size.Width, fAgrega.Size.Height);
                        break;

                    case "Compra":
                        FormCompra fMostrar = new FormCompra();
                        fMostrar.MdiParent = this;
                        fMostrar.Show();
                        fmenu.Size = new Size(fMostrar.Size.Width, fMostrar.Size.Height);
                        break;

                    case "AgregarEmpleado":
                        FormEmpleado fInsertarE = new FormEmpleado();
                        fInsertarE.MdiParent = this;
                        fInsertarE.Show();
                        break;

                    case "InsertarProducto":
                        FormProducto fInsertarP = new FormProducto();
                        fInsertarP.MdiParent = this;
                        fInsertarP.Show();
                        break;

                    case "InsertarProveedor":
                        FormProveedor fInsertarPro = new FormProveedor();
                        fInsertarPro.MdiParent = this;
                        fInsertarPro.Show();
                        break;

                    case "AgregarSerie":
                        FormSerie fAgregaS = new FormSerie();
                        fAgregaS.MdiParent = this;
                        fAgregaS.Show();
                        break;
                }
            
            }//fin del switch
        }//fin del if

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView1_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            treeView1.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }
    }
}