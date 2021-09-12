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
    public partial class FrmModify : Form
    {
        public ProductModel PModel3 { get; set; }
        public FrmModify()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            int x = (int)nudID.Value;
            Product prd = PModel3.GetProductById(x);
            if (prd != null)
            {
                groupBox1.Visible = true;
                flowLayoutPanel1.Visible = true;
                btnAccept.Visible = false;
                btnCancel.Visible = false;
                btnCancel2.Visible = false;
                nudID.Visible = false;
                label1.Visible = false;
                txtName.Text = prd.Name;
                txtDesc.Text = prd.Description;
                nudQuantity.Value = prd.Quantity;
                nudPrice.Value = prd.Price;
                dtpCaducity.Value = prd.CaducityDate;
                cmbMeasurement.SelectedIndex = (int)prd.Unit;
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int x = (int)nudID.Value;
            Product prd = PModel3.GetProductById(x);
            Product p = new Product()
            {
                Id = prd.Id,
                Name = txtName.Text,
                Description = txtDesc.Text,
                Quantity = (int)nudQuantity.Value,
                Price = nudPrice.Value,
                CaducityDate = dtpCaducity.Value,
                Unit = (MeasurementUnit)cmbMeasurement.SelectedIndex
            };

            PModel3.Update(p);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
