using Domain.Entities;
using Infraestructure.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaProductos.Forms
{
    public partial class FrmDelete : Form
    {
        public ProductModel PModel2 { get; set; }

        public FrmDelete()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            int x = (int)nudID.Value;
            Product p = PModel2.GetProductById(x);
            PModel2.Delete(p);

            Dispose();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
