using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiLavadero
{
    public partial class FormLavadero : Form
    {
        private Lavadero miLavadero;

        public FormLavadero()
        {
            InitializeComponent();
            miLavadero = new Lavadero(2500, 6500, 8500);
        }
        public Lavadero MiLavadero
        {
            get 
            { 
                return this.miLavadero;
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormLavadero_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = new DialogResult();
            respuesta = MessageBox.Show("¿Esta seguro que desea salir?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
