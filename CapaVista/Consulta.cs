using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class Consulta : Form
    {
        String tabla = "empleados";
        Controlador cn = new Controlador();
        public Consulta()
        {
            InitializeComponent();
        }

        public void actualizardatagridview()
        {
            
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Dgv_consulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Controlador ctriv = new Controlador();
                string codigotext = txt_codigo.Text;
                int id = Convert.ToInt32(codigotext);
                string n = txt_nombre.Text;
                string p = txt_puesto.Text;
                string d = txt_departamento.Text;
                string estadotxt = txt_estado.Text;
                int es = Convert.ToInt32(estadotxt);
                ctriv.modificar(id, n, p, d, es);
                MessageBox.Show("Registro Modificado Correctamente");
            }
            catch
            {
                MessageBox.Show("Registro No Modificado");
            }
        }
    }
}
