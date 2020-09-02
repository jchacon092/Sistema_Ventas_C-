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
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }
        public List<ClassVariables> li;
        ClassVariables variable = new ClassVariables();
        private void button1_Click(object sender, EventArgs e)
        {
            ClassUsuario LgUsuario = new ClassUsuario();
            string usuario = " ";
            int rol = 0;
            int empleado = 0;
            DataTable emple = new DataTable();
            DataTable rol1 = new DataTable();
           DataTable  respuesta = new DataTable();

            respuesta = LgUsuario.Usuario(textBox1.Text, textBox2.Text);

            if(respuesta!= null)
            {
               
                variable.IDUSUARIO = Convert.ToInt32(respuesta.Rows[0][0]);
                usuario = respuesta.Rows[0][1].ToString();
                rol = Convert.ToInt32(respuesta.Rows[0][5]);
                empleado = Convert.ToInt32(respuesta.Rows[0][4]);
            }


            ClassEmpleado LgEmpleado = new ClassEmpleado();
            emple = LgEmpleado.BusqueEmpleado(empleado);
            if(respuesta != null)
            {
              
                variable.EMPLEADO = emple.Rows[0][1].ToString() + " " + emple.Rows[0][2].ToString() ;
                variable.IDEMPLEADO = empleado;
            }

            ClassUsuario LgRol = new ClassUsuario();
            rol1 = LgRol.BusquedaRol(empleado);
            if (respuesta != null)
            {
               
                variable.ROL = rol1.Rows[0][1].ToString();
              
            }


            if (usuario == textBox1.Text)
            {
                li.Add(variable);
                MessageBox.Show("Acceso correcto" + variable.ROL.ToString());
             
                FormMenu f1 = new FormMenu();
                f1.VAR = variable;
                f1.Show();
                

            }
            else
            {               
                MessageBox.Show("Verifique sus datos");
            }
                
            
            
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            li = new List<ClassVariables>();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

           
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
           
        }

        private void textBox1_MarginChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                long a1;
                a1 = Convert.ToInt64(textBox1.Text);
                textBox1.Clear();
                //label4.Text = a1.ToString();

            }
        }
    }
}
