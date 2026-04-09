using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRegistroClientesRomero
{
    public partial class frmRegistroCliente : Form
    {
        public frmRegistroCliente()
        {
            InitializeComponent();
        }
        //Declaracion de un registro
        private struct RegistroCliente
        {
            public Int32 Codigo;
            public String Usuario;
            public Decimal Deuda;
            public Decimal Limite;
        }
        //Declaracion del vector
        private RegistroCliente[] clientes = new RegistroCliente[10];

        //Declaracion del indice
        private Int32 IND = 0;
        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (IND < clientes.Length)
            {
                Int32 i = 0;
                while (ClienteS[IND].Codigo !=  Convert.ToInt32()
        }
    }
}