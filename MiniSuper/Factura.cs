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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace MiniSuper
{
    public partial class Factura : Form
    {
       public ClassVariables variable;
        public List<ClassDetalleFactura> lista;
        int num = 0;
        int idserie = 0;
        decimal total = 0;
        public Factura()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            lista = new List<ClassDetalleFactura>();
            

            DataTable veri = new DataTable();
            ClassSerie serie = new ClassSerie();
            veri = serie.Verificar();
            if(veri!=null)
            {
                idserie = Convert.ToInt32(veri.Rows[0][0]);
                label7.Text = veri.Rows[0][1].ToString();
                num = Convert.ToInt32(veri.Rows[0][5]) + 1;
                label8.Text = num.ToString();
            }
        

           /* ClassProducto LgProd = new ClassProducto();
            this.comboBox2.DataSource = LgProd.ListarProducto();
            this.comboBox2.DisplayMember = "Nombre_producto";
            this.comboBox2.ValueMember = "Id_producto";*/

          
            label10.Text = variable.EMPLEADO;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 45, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(label8.Text + ".pdf", FileMode.Create));
            doc.Open();
            Paragraph paragraph = new Paragraph("                                    "+label6.Text);
            doc.Add(paragraph);
            Paragraph paragraph1 = new Paragraph("                                    " + label8.Text);
            doc.Add(paragraph1);
            Paragraph paragraph2 = new Paragraph("                                    " + label5.Text);
            doc.Add(paragraph2);
            Paragraph paragraph3 = new Paragraph("                                    " + label7.Text);
            doc.Add(paragraph3);
            Paragraph paragraph4 = new Paragraph("                                    " + label9.Text);
            doc.Add(paragraph4);
            Paragraph paragraph5 = new Paragraph("                                    " + label10.Text);
            doc.Add(paragraph5);
            Paragraph paragraph6 = new Paragraph("                                    " + label2.Text);
            doc.Add(paragraph6);
            Paragraph paragraph7 = new Paragraph("                                    " + textBox1.Text);
            doc.Add(paragraph7);
            Paragraph paragraph8 = new Paragraph("                                    " + label3.Text);
            doc.Add(paragraph8);
            Paragraph paragraph10 = new Paragraph("                                    " + textBox2.Text);
            doc.Add(paragraph10);
            Paragraph paragraph11 = new Paragraph("                                    " + label4.Text);
            doc.Add(paragraph11);
            Paragraph paragraph12 = new Paragraph("                                    " + textBox3.Text);
            doc.Add(paragraph12);
    

            PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                table.AddCell(new Phrase(dataGridView1.Columns[j].HeaderText));

            }
            table.HeaderRows = 1;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int k = 0; k < dataGridView1.Columns.Count; k++)
                {
                    if (dataGridView1[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(dataGridView1[k, i].Value.ToString()));
                    }
                }
            }
            doc.Add(table);

            Paragraph paragraph17 = new Paragraph("                                    "+label11.Text);
            doc.Add(paragraph17);
            Paragraph paragraph18 = new Paragraph("                                    "+label15.Text);
            doc.Add(paragraph18);


            doc.Close();



            ClassFactura LgCompra = new ClassFactura();
            string respuesta = "";
            respuesta = LgCompra.InsertaCompra(lista, textBox1.Text, textBox2.Text,textBox3.Text,0.ToString(),label15.Text,num.ToString(),variable.IDEMPLEADO.ToString(),idserie.ToString(),num);
            MessageBox.Show(respuesta);
            Factura_Load(sender, e);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            //textBox5.Clear();
            label15.Text = " ";
            dataGridView1.DataSource = null;



        }

        private void textBox4_BorderStyleChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_ControlRemoved(object sender, ControlEventArgs e)
        {
        
        }

        private void textBox4_ContextMenuStripChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_EnabledChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_RightToLeftChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextAlignChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)

            {
                long a1=0;
                a1 = Convert.ToInt64(textBox4.Text);
                textBox4.Clear();
                int idpro = 0;
                ClassProducto LgProducto = new ClassProducto();
                idpro = LgProducto.idproducto(a1);
                ClassDetalleFactura Lgdetalle = new ClassDetalleFactura();
                 Lgdetalle.IDPRODUCTO = idpro;
                Lgdetalle.CANTIDAD = 1;

               
                DataTable Producto = new DataTable();


                decimal precio = 0;
                string nombre = " ";

                   Producto = LgProducto.BuscaProducto(idpro);

                if (Producto != null)
                {
                    nombre = Producto.Rows[0][1].ToString();
                    precio = Convert.ToDecimal(Producto.Rows[0][3]);
                }


                Lgdetalle.PRECIOU = precio;
                Lgdetalle.NOMBRE = nombre;
                Lgdetalle.TOTAL = precio * 1;
                total = Lgdetalle.TOTAL + total;
                label15.Text = total.ToString();

                lista.Add(Lgdetalle);

                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = lista;
                this.dataGridView1.Refresh();

            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void textBox4_ReadOnlyChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox4_MultilineChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox4_Layout(object sender, LayoutEventArgs e)
        {
           
        }

        private void textBox4_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
           
        }

        private void textBox4_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void textBox4_ControlAdded(object sender, ControlEventArgs e)
        {
        }

        private void textBox4_Validated(object sender, EventArgs e)
        {

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
