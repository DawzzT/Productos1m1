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
    public partial class FrmProductManager : Form
    {
        public ProductModel productoModel;
        public ProductModel productoModel2;
        public FrmProductManager()
        {
            productoModel = new ProductModel();
            productoModel2 = new ProductModel();
            InitializeComponent();
        }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmbSearch.SelectedIndex)
            {
                case 0:
                    pnlByMeasurement.Visible = true;
                    pnlCaducity.Visible = false;
                    pnlId.Visible = false;
                    pnlPriceRange.Visible = false;
                        break;
                case 1:
                    pnlByMeasurement.Visible = false;
                    pnlCaducity.Visible = true;
                    pnlId.Visible = false;
                    pnlPriceRange.Visible = false;
                    break;
                case 2:
                    pnlByMeasurement.Visible = false;
                    pnlCaducity.Visible = false;
                    pnlId.Visible = true ;
                    pnlPriceRange.Visible = false;
                    break;
                case 3:
                    pnlByMeasurement.Visible = false;
                    pnlCaducity.Visible = false;
                    pnlId.Visible = false;
                    pnlPriceRange.Visible = true;
                    break;
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (cmbSearch.SelectedIndex)
            {
                case 0:
                    rtbView.Text = string.Empty;
                    Product[] f1 = productoModel.GetProductByUnidadMedida((MeasurementUnit)cmbUnit.SelectedIndex);
                    rtbView.Text =productoModel.GetProductosAsString(f1);
                    break;
                case 1:
                    rtbView.Text = string.Empty;
                    Product[] f2 = productoModel.GetProductByCaducity(dtpCaducity.Value);
                    rtbView.Text = productoModel.GetProductosAsString(f2);
                    break;
                case 2:
                    rtbView.Text = string.Empty;
                    Product f3 = productoModel.GetProductById((int)nudID.Value);
                   rtbView.Text = ". Codigo: " + f3.Id.ToString() + " Nombre: " + f3.Name.ToString() +
                              " Cantidad: " + f3.Quantity.ToString() + " Precio: " + f3.Price.ToString() +
                              " Caducidad " + f3.CaducityDate.ToString() + " Unidad de Medida: " + f3.Unit.ToString() + "\n";
                    break;
                case 3:
                    rtbView.Text = string.Empty;
                    Product[] f4 = productoModel.GetProductByPriceRange((decimal)nudMin.Value,(decimal) nudMax.Value);
                    rtbView.Text = productoModel.GetProductosAsString(f4);
                    break;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            rtbView.Text = string.Empty;

            FrmProduct frmProducto = new FrmProduct();
            frmProducto.PModel = productoModel;
            frmProducto.ShowDialog();
            
                rtbView.Text = productoModel.GetProductosAsJson();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtbView.Text = string.Empty;
            FrmDelete frmId = new FrmDelete();
            frmId.PModel2 = productoModel2;
            frmId.ShowDialog();
           
                rtbView.Text = productoModel2.GetProductosAsJson();
            
        }

        private void rtbView_TextChanged(object sender, EventArgs e)
        {

           
            
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            rtbView.Text = string.Empty;
            FrmModify frmMod = new FrmModify();
            frmMod.PModel3 = productoModel;
            frmMod.ShowDialog();

            rtbView.Text = productoModel.GetProductosAsJson();
        }
    }
}
