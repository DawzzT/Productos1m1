
namespace TareaProductos.Forms
{
    partial class FrmModify
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
            this.nudID = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpCaducity = new System.Windows.Forms.DateTimePicker();
            this.cmbMeasurement = new System.Windows.Forms.ComboBox();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudID
            // 
            this.nudID.Location = new System.Drawing.Point(79, 42);
            this.nudID.Name = "nudID";
            this.nudID.Size = new System.Drawing.Size(221, 20);
            this.nudID.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID ";
            // 
            // btnCancel2
            // 
            this.btnCancel2.Location = new System.Drawing.Point(221, 115);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(100, 30);
            this.btnCancel2.TabIndex = 5;
            this.btnCancel2.Text = "Cancel";
            this.btnCancel2.UseVisualStyleBackColor = true;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(115, 115);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(100, 30);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtpCaducity);
            this.groupBox1.Controls.Add(this.cmbMeasurement);
            this.groupBox1.Controls.Add(this.nudPrice);
            this.groupBox1.Controls.Add(this.nudQuantity);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Location = new System.Drawing.Point(9, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 216);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Measurement Unit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Caducity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Name";
            // 
            // dtpCaducity
            // 
            this.dtpCaducity.Location = new System.Drawing.Point(156, 150);
            this.dtpCaducity.Name = "dtpCaducity";
            this.dtpCaducity.Size = new System.Drawing.Size(200, 20);
            this.dtpCaducity.TabIndex = 6;
            // 
            // cmbMeasurement
            // 
            this.cmbMeasurement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMeasurement.FormattingEnabled = true;
            this.cmbMeasurement.Items.AddRange(new object[] {
            "Unit",
            "Liters",
            "Mililiters",
            "Kilograms",
            "Grams",
            "Pounds"});
            this.cmbMeasurement.Location = new System.Drawing.Point(156, 176);
            this.cmbMeasurement.Name = "cmbMeasurement";
            this.cmbMeasurement.Size = new System.Drawing.Size(200, 21);
            this.cmbMeasurement.TabIndex = 1;
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Location = new System.Drawing.Point(156, 124);
            this.nudPrice.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(200, 20);
            this.nudPrice.TabIndex = 5;
            this.nudPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(156, 98);
            this.nudQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(200, 20);
            this.nudQuantity.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(156, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(156, 43);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(200, 49);
            this.txtDesc.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnOk);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(14, 234);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(390, 36);
            this.flowLayoutPanel1.TabIndex = 8;
            this.flowLayoutPanel1.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(287, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnOk.Location = new System.Drawing.Point(181, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 30);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Accept";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FrmModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 291);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.nudID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel2);
            this.Controls.Add(this.btnAccept);
            this.Name = "FrmModify";
            this.Text = "FrmModify";
           
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpCaducity;
        private System.Windows.Forms.ComboBox cmbMeasurement;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}