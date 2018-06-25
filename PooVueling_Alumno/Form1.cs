using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PooVueling_Alumno
{
    public partial class Form1 : Form
    {
        Alumno alumno = new Alumno();
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            alumno.Nombre = txtbx_Nombre.Text;
            alumno.Apellidos = txtbx_Apellidos.Text;
            alumno.DNI = txtbx_DNI.Text;
            alumno.Id = txtbx_ID.Text;
            alumno.Guardar();
        }
    }
}
