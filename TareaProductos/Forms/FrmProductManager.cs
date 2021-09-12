﻿using Infraestructure.Products;
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
        public FrmProductManager()
        {
            productoModel = new ProductModel();
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
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            rtbView.Text = string.Empty;

            FrmProduct frmProducto = new FrmProduct();
            frmProducto.PModel = productoModel;
            frmProducto.ShowDialog();
            if (productoModel.GetAll() != null)
            {
                rtbView.Text = productoModel.GetProductosAsJson();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtbView.Text = string.Empty;
            FrmDelete frmId = new FrmDelete();
            frmId.PModel = productoModel;
            frmId.ShowDialog();
           
            if (productoModel.GetAll() != null)
            {
                rtbView.Text = productoModel.GetProductosAsJson();
            }
        }

        private void rtbView_TextChanged(object sender, EventArgs e)
        {

            rtbView.Text = string.Empty;
            FrmModify frmMod = new FrmModify();
            frmMod.PModel = productoModel;
            frmMod.ShowDialog();

            if (productoModel.GetAll() != null)
            {
                rtbView.Text = productoModel.GetProductosAsJson();
            }
        }
    }
}
