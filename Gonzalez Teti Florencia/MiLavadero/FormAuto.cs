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
    public partial class FormAuto : FormVehiculo
    {
        private Auto autoDelForm;
        public FormAuto()
        {
            InitializeComponent();
        }
        public Vehiculo GetAutoDelForm
        {
            get
            {
                return this.autoDelForm;
            }
        }
        protected override void btnAceptarVehiculo_Click(object sender, EventArgs e)
        {
            this.autoDelForm = new Auto(base.)
            base.btnAceptarVehiculo_Click(sender, e);
        }
    }
}
