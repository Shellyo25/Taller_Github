//using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using CapaControlador;

namespace CapaVista
{
    public partial class Consulta : Form
    {
        String tabla = "empleados";
        Controlador cn = new Controlador();
        public Consulta()
        {
           // InitializeComponent();
        }

        public void actualizardatagridview()
        {
            //DataTable dt = cn.llenarTbl(tabla);
            Dgv_consulta.DataSource = dt;
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            //actualizardatagridview();
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
            
        }
    }
}
