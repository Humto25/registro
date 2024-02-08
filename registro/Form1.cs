using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            String usuario = txtusuario.Text;
            String contra = txtcontra.Text;

            String validaUsuario = "Humberto";
            String validaContra = "25";

            if (usuario== validaUsuario &&  contra==validaContra)
            {
                MessageBox.Show("Inicio de sesion exitoso");
                Form1 form1 = new Form1();
                Form2 form2 = new Form2();  

                form1.Hide();
                form2.Show();   
            }

            else
            {
                MessageBox.Show("Usuario o contraseña invalido. Favor de intentarlo de nuevo");
                txtusuario.Clear();
                txtcontra.Clear();
                txtusuario.Focus();
            }
            
        

            
        }
    }
}
