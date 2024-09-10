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
            DataTable dt = cn.llenarTbl(tabla);
            Dgv_consulta.DataSource = dt;
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            actualizardatagridview();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            string codigotext = txt_codigo.Text;
            int codigo = Convert.ToInt32(codigotext);
            string nombre = txt_nombre.Text;
            string puesto = txt_puesto.Text;
            string departamento = txt_departamento.Text;
            string estadotexto = txt_estado.Text;
            int estado = Convert.ToInt32(estadotexto);

            try
            {
                cn.saveEmpleado(codigo, nombre, puesto, departamento, estado);
                MessageBox.Show("Registro Agregado correctamente :)");
            }
            catch
            {
                MessageBox.Show("Registro No ingresado");
            }

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
            
        }
    }
}
