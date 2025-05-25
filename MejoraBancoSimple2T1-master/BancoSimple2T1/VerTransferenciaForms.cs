using BancoSimple2T1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoSimple2T1
{
    public partial class VerTransferenciaForms : Form
    {
        private readonly BancoSimpleContext _context = new BancoSimpleContext();
        public VerTransferenciaForms()
        {
            InitializeComponent();
            CargarTransacciones();
        }

        private void CargarTransacciones()
        {
            dgvTransferencias.DataSource = con.Transacciones.ToList();
        }
    }
}
