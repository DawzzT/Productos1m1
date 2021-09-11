using Domain.Entities;
using Domain.Enums;
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
    public partial class FrmProduct : Form
    {
        public ProductModel PModel { get; set; }

      
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Product p = new Product()
            {
                Id = PModel.GetLastProductoId() + 1,
                Name = txtName.Text,
                Description = txtDesc.Text,
                Quantity = (int)nudQuantity.Value,
                Price = nudPrice.Value,
                CaducityDate = dtpCaducity.Value,
                Unit = (MeasurementUnit)cmbMeasurement.SelectedIndex
            };

            PModel.Add(p);

            Dispose();
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           
            Dispose();
        }
    }
}
