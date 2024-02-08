using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }




        private List<string> ObtenerSintomasSeleccionados()
        {
            List<string> sintomas = new List<string>();

            if (checkBox1)
       
 



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            String sexo = "";
            if (radioButton1.Checked )
            {
                sexo = "M";

            }
            else if (radioButton2.Checked ) 
            {
                sexo = "H";
            }
            string nombre = txtnombre.Text;
            string apellido = txtapellido.Text;
            long telefono = long.Parse(txttelefono.Text);
            long codigop = long.Parse(txtcodigop.Text);
            string direccion = txtdireccion.Text;
            
            
            Paciente paciente = new


             
        }
    }

    public class Paciente
    {
        public String Nombre {  get; set; }
        public String Apellidos { get; set; }
        public long Telefono { get; set; }
        public String Direccion {  get; set; }
        public long Codigop {  get; set; }
        public string Sexo { get; set; }
        

        public Paciente (string nombre, string apellidos, long telefono, long codigop, string direccion, string sexo)
        {
            Nombre = nombre;
            Apellidos = apellidos;  
            Telefono = telefono;
            Codigop = codigop;
            Sexo = sexo;
            

        }
    }
}
