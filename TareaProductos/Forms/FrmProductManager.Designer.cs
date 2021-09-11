
namespace TareaProductos.Forms
{
    partial class FrmProductManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.txtById = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlId = new System.Windows.Forms.Panel();
            this.pnlByMeasurement = new System.Windows.Forms.Panel();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.pnlPriceRange = new System.Windows.Forms.Panel();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.pnlCaducity = new System.Windows.Forms.Panel();
            this.dtpCaducity = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlId.SuspendLayout();
            this.pnlByMeasurement.SuspendLayout();
            this.pnlPriceRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            this.pnlCaducity.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.btnModify);
            this.flowLayoutPanel1.Controls.Add(this.btnNew);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 397);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(759, 41);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(656, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(550, 3);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(100, 30);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(444, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 30);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // cmbUnit
            // 
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Items.AddRange(new object[] {
            "Unit",
            "Liters",
            "Mililiters",
            "Kilograms",
            "Grams",
            "Pounds"});
            this.cmbUnit.Location = new System.Drawing.Point(0, 2);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(376, 21);
            this.cmbUnit.TabIndex = 1;
            // 
            // txtById
            // 
            this.txtById.Location = new System.Drawing.Point(0, 3);
            this.txtById.Name = "txtById";
            this.txtById.Size = new System.Drawing.Size(410, 20);
            this.txtById.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(669, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlId
            // 
            this.pnlId.Controls.Add(this.txtById);
            this.pnlId.Location = new System.Drawing.Point(224, 9);
            this.pnlId.Name = "pnlId";
            this.pnlId.Size = new System.Drawing.Size(439, 26);
            this.pnlId.TabIndex = 4;
            this.pnlId.Visible = false;
            // 
            // pnlByMeasurement
            // 
            this.pnlByMeasurement.Controls.Add(this.cmbUnit);
            this.pnlByMeasurement.Location = new System.Drawing.Point(224, 9);
            this.pnlByMeasurement.Name = "pnlByMeasurement";
            this.pnlByMeasurement.Size = new System.Drawing.Size(439, 26);
            this.pnlByMeasurement.TabIndex = 5;
            this.pnlByMeasurement.Visible = false;
            // 
            // cmbSearch
            // 
            this.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "Measurement Unit",
            "Caducity Date",
            "ID",
            "Price Range"});
            this.cmbSearch.Location = new System.Drawing.Point(13, 12);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(181, 21);
            this.cmbSearch.TabIndex = 6;
            this.cmbSearch.SelectedIndexChanged += new System.EventHandler(this.cmbSearch_SelectedIndexChanged);
            // 
            // pnlPriceRange
            // 
            this.pnlPriceRange.Controls.Add(this.nudMax);
            this.pnlPriceRange.Controls.Add(this.nudMin);
            this.pnlPriceRange.Location = new System.Drawing.Point(224, 9);
            this.pnlPriceRange.Name = "pnlPriceRange";
            this.pnlPriceRange.Size = new System.Drawing.Size(439, 26);
            this.pnlPriceRange.TabIndex = 7;
            this.pnlPriceRange.Visible = false;
            // 
            // nudMin
            // 
            this.nudMin.Location = new System.Drawing.Point(0, 3);
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(200, 20);
            this.nudMin.TabIndex = 0;
            // 
            // nudMax
            // 
            this.nudMax.Location = new System.Drawing.Point(206, 3);
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(200, 20);
            this.nudMax.TabIndex = 1;
            // 
            // pnlCaducity
            // 
            this.pnlCaducity.Controls.Add(this.dtpCaducity);
            this.pnlCaducity.Location = new System.Drawing.Point(224, 9);
            this.pnlCaducity.Name = "pnlCaducity";
            this.pnlCaducity.Size = new System.Drawing.Size(439, 26);
            this.pnlCaducity.TabIndex = 8;
            this.pnlCaducity.Visible = false;
            // 
            // dtpCaducity
            // 
            this.dtpCaducity.Location = new System.Drawing.Point(0, 3);
            this.dtpCaducity.Name = "dtpCaducity";
            this.dtpCaducity.Size = new System.Drawing.Size(307, 20);
            this.dtpCaducity.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 38);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(757, 350);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // FrmProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pnlId);
            this.Controls.Add(this.pnlPriceRange);
            this.Controls.Add(this.pnlCaducity);
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.pnlByMeasurement);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FrmProductManager";
            this.Text = "FrmProductManager";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlId.ResumeLayout(false);
            this.pnlId.PerformLayout();
            this.pnlByMeasurement.ResumeLayout(false);
            this.pnlPriceRange.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            this.pnlCaducity.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.TextBox txtById;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlId;
        private System.Windows.Forms.Panel pnlByMeasurement;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Panel pnlPriceRange;
        private System.Windows.Forms.NumericUpDown nudMax;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.Panel pnlCaducity;
        private System.Windows.Forms.DateTimePicker dtpCaducity;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}