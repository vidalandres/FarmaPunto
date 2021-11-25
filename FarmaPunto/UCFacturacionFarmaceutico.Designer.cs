namespace FarmaPunto
{
    partial class UCFacturacionAdministrador
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnFacturaFarmaceutico = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LbelFechaderealizacionF = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuSeparator7 = new Bunifu.Framework.UI.BunifuSeparator();
            this.DtgElementosFacturaFarmaceutico = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtCodigoFacturaFarmaceutico = new System.Windows.Forms.Label();
            this.LbelContraseña = new System.Windows.Forms.Label();
            this.TxtcodigoFarmaceutico = new System.Windows.Forms.TextBox();
            this.bunifuSeparator9 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lbSubtotalFarmaceutico = new System.Windows.Forms.Label();
            this.lbTotalFarmaceutico = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbDescripcionFarmaceutico = new System.Windows.Forms.TextBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.NbUnidadesFarmaceutico = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DtgElementosFacturaFarmaceutico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbUnidadesFarmaceutico)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnFacturaFarmaceutico
            // 
            this.BtnFacturaFarmaceutico.BackColor = System.Drawing.Color.Crimson;
            this.BtnFacturaFarmaceutico.FlatAppearance.BorderSize = 0;
            this.BtnFacturaFarmaceutico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFacturaFarmaceutico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFacturaFarmaceutico.ForeColor = System.Drawing.Color.White;
            this.BtnFacturaFarmaceutico.Image = global::FarmaPunto.Properties.Resources.icons8_activity_history_35__1_;
            this.BtnFacturaFarmaceutico.Location = new System.Drawing.Point(580, 462);
            this.BtnFacturaFarmaceutico.Name = "BtnFacturaFarmaceutico";
            this.BtnFacturaFarmaceutico.Size = new System.Drawing.Size(142, 48);
            this.BtnFacturaFarmaceutico.TabIndex = 7;
            this.BtnFacturaFarmaceutico.Text = "Facturar";
            this.BtnFacturaFarmaceutico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFacturaFarmaceutico.UseVisualStyleBackColor = false;
            this.BtnFacturaFarmaceutico.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(106, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Fecha De Hoy";
            // 
            // LbelFechaderealizacionF
            // 
            this.LbelFechaderealizacionF.AutoSize = true;
            this.LbelFechaderealizacionF.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbelFechaderealizacionF.ForeColor = System.Drawing.Color.DimGray;
            this.LbelFechaderealizacionF.Location = new System.Drawing.Point(27, 11);
            this.LbelFechaderealizacionF.Name = "LbelFechaderealizacionF";
            this.LbelFechaderealizacionF.Size = new System.Drawing.Size(73, 22);
            this.LbelFechaderealizacionF.TabIndex = 23;
            this.LbelFechaderealizacionF.Text = "Fecha:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(445, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 96;
            this.label8.Text = "Unidades";
            this.label8.UseCompatibleTextRendering = true;
            // 
            // bunifuSeparator7
            // 
            this.bunifuSeparator7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator7.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator7.LineThickness = 2;
            this.bunifuSeparator7.Location = new System.Drawing.Point(444, 106);
            this.bunifuSeparator7.Name = "bunifuSeparator7";
            this.bunifuSeparator7.Size = new System.Drawing.Size(86, 15);
            this.bunifuSeparator7.TabIndex = 94;
            this.bunifuSeparator7.Transparency = 255;
            this.bunifuSeparator7.Vertical = false;
            this.bunifuSeparator7.Load += new System.EventHandler(this.bunifuSeparator7_Load);
            // 
            // DtgElementosFacturaFarmaceutico
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DtgElementosFacturaFarmaceutico.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgElementosFacturaFarmaceutico.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DtgElementosFacturaFarmaceutico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtgElementosFacturaFarmaceutico.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgElementosFacturaFarmaceutico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DtgElementosFacturaFarmaceutico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgElementosFacturaFarmaceutico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Subtotal,
            this.Column5,
            this.Column6});
            this.DtgElementosFacturaFarmaceutico.DoubleBuffered = true;
            this.DtgElementosFacturaFarmaceutico.EnableHeadersVisualStyles = false;
            this.DtgElementosFacturaFarmaceutico.HeaderBgColor = System.Drawing.Color.Crimson;
            this.DtgElementosFacturaFarmaceutico.HeaderForeColor = System.Drawing.Color.White;
            this.DtgElementosFacturaFarmaceutico.Location = new System.Drawing.Point(31, 144);
            this.DtgElementosFacturaFarmaceutico.Name = "DtgElementosFacturaFarmaceutico";
            this.DtgElementosFacturaFarmaceutico.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtgElementosFacturaFarmaceutico.Size = new System.Drawing.Size(691, 294);
            this.DtgElementosFacturaFarmaceutico.TabIndex = 115;
            this.DtgElementosFacturaFarmaceutico.DataSourceChanged += new System.EventHandler(this.DtgElementosFactura_DataSourceChanged);
            this.DtgElementosFacturaFarmaceutico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Codigo";
            this.Column2.HeaderText = "Producto";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Descripcion";
            this.Column3.HeaderText = "Descripción";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 300;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Unidades";
            this.Column4.HeaderText = "Unidades";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 70;
            // 
            // Subtotal
            // 
            this.Subtotal.DataPropertyName = "Subtotal";
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 70;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Impuesto";
            this.Column5.HeaderText = "Impuesto";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 70;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Total";
            this.Column6.HeaderText = "Total";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 70;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(626, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 116;
            this.label9.Text = "Factura N°";
            // 
            // TxtCodigoFacturaFarmaceutico
            // 
            this.TxtCodigoFacturaFarmaceutico.AutoSize = true;
            this.TxtCodigoFacturaFarmaceutico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoFacturaFarmaceutico.ForeColor = System.Drawing.Color.DimGray;
            this.TxtCodigoFacturaFarmaceutico.Location = new System.Drawing.Point(702, 11);
            this.TxtCodigoFacturaFarmaceutico.Name = "TxtCodigoFacturaFarmaceutico";
            this.TxtCodigoFacturaFarmaceutico.Size = new System.Drawing.Size(15, 16);
            this.TxtCodigoFacturaFarmaceutico.TabIndex = 117;
            this.TxtCodigoFacturaFarmaceutico.Text = "0";
            // 
            // LbelContraseña
            // 
            this.LbelContraseña.AutoSize = true;
            this.LbelContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbelContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.LbelContraseña.Location = new System.Drawing.Point(28, 61);
            this.LbelContraseña.Name = "LbelContraseña";
            this.LbelContraseña.Size = new System.Drawing.Size(128, 16);
            this.LbelContraseña.TabIndex = 120;
            this.LbelContraseña.Text = "Codigo de Producto";
            // 
            // TxtcodigoFarmaceutico
            // 
            this.TxtcodigoFarmaceutico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtcodigoFarmaceutico.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtcodigoFarmaceutico.ForeColor = System.Drawing.Color.DimGray;
            this.TxtcodigoFarmaceutico.Location = new System.Drawing.Point(28, 80);
            this.TxtcodigoFarmaceutico.Name = "TxtcodigoFarmaceutico";
            this.TxtcodigoFarmaceutico.Size = new System.Drawing.Size(128, 26);
            this.TxtcodigoFarmaceutico.TabIndex = 119;
            this.TxtcodigoFarmaceutico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtcodigo_KeyDown);
            // 
            // bunifuSeparator9
            // 
            this.bunifuSeparator9.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator9.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator9.LineThickness = 2;
            this.bunifuSeparator9.Location = new System.Drawing.Point(28, 106);
            this.bunifuSeparator9.Name = "bunifuSeparator9";
            this.bunifuSeparator9.Size = new System.Drawing.Size(128, 15);
            this.bunifuSeparator9.TabIndex = 118;
            this.bunifuSeparator9.Transparency = 255;
            this.bunifuSeparator9.Vertical = false;
            // 
            // lbSubtotalFarmaceutico
            // 
            this.lbSubtotalFarmaceutico.AutoSize = true;
            this.lbSubtotalFarmaceutico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubtotalFarmaceutico.ForeColor = System.Drawing.Color.DimGray;
            this.lbSubtotalFarmaceutico.Location = new System.Drawing.Point(28, 462);
            this.lbSubtotalFarmaceutico.Name = "lbSubtotalFarmaceutico";
            this.lbSubtotalFarmaceutico.Size = new System.Drawing.Size(25, 16);
            this.lbSubtotalFarmaceutico.TabIndex = 147;
            this.lbSubtotalFarmaceutico.Text = "$ #";
            // 
            // lbTotalFarmaceutico
            // 
            this.lbTotalFarmaceutico.AutoSize = true;
            this.lbTotalFarmaceutico.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalFarmaceutico.ForeColor = System.Drawing.Color.DimGray;
            this.lbTotalFarmaceutico.Location = new System.Drawing.Point(25, 489);
            this.lbTotalFarmaceutico.Name = "lbTotalFarmaceutico";
            this.lbTotalFarmaceutico.Size = new System.Drawing.Size(45, 29);
            this.lbTotalFarmaceutico.TabIndex = 148;
            this.lbTotalFarmaceutico.Text = "$ #";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(162, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 151;
            this.label1.Text = "Descripción";
            // 
            // TbDescripcionFarmaceutico
            // 
            this.TbDescripcionFarmaceutico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbDescripcionFarmaceutico.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbDescripcionFarmaceutico.ForeColor = System.Drawing.Color.DimGray;
            this.TbDescripcionFarmaceutico.Location = new System.Drawing.Point(162, 80);
            this.TbDescripcionFarmaceutico.Name = "TbDescripcionFarmaceutico";
            this.TbDescripcionFarmaceutico.ReadOnly = true;
            this.TbDescripcionFarmaceutico.Size = new System.Drawing.Size(277, 26);
            this.TbDescripcionFarmaceutico.TabIndex = 150;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(162, 106);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(277, 15);
            this.bunifuSeparator1.TabIndex = 149;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // NbUnidadesFarmaceutico
            // 
            this.NbUnidadesFarmaceutico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NbUnidadesFarmaceutico.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.NbUnidadesFarmaceutico.Location = new System.Drawing.Point(444, 80);
            this.NbUnidadesFarmaceutico.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NbUnidadesFarmaceutico.Name = "NbUnidadesFarmaceutico";
            this.NbUnidadesFarmaceutico.Size = new System.Drawing.Size(86, 29);
            this.NbUnidadesFarmaceutico.TabIndex = 152;
            this.NbUnidadesFarmaceutico.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NbUnidadesFarmaceutico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NbUnidades_KeyDown);
            // 
            // UCFacturacionFarmaceutico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.NbUnidadesFarmaceutico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbDescripcionFarmaceutico);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.lbTotalFarmaceutico);
            this.Controls.Add(this.lbSubtotalFarmaceutico);
            this.Controls.Add(this.LbelContraseña);
            this.Controls.Add(this.TxtcodigoFarmaceutico);
            this.Controls.Add(this.bunifuSeparator9);
            this.Controls.Add(this.TxtCodigoFacturaFarmaceutico);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DtgElementosFacturaFarmaceutico);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bunifuSeparator7);
            this.Controls.Add(this.LbelFechaderealizacionF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnFacturaFarmaceutico);
            this.Name = "UCFacturacionFarmaceutico";
            this.Size = new System.Drawing.Size(985, 677);
            this.Load += new System.EventHandler(this.UCFacturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgElementosFacturaFarmaceutico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbUnidadesFarmaceutico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnFacturaFarmaceutico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LbelFechaderealizacionF;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator7;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DtgElementosFacturaFarmaceutico;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label TxtCodigoFacturaFarmaceutico;
        private System.Windows.Forms.Label LbelContraseña;
        private System.Windows.Forms.TextBox TxtcodigoFarmaceutico;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator9;
        private System.Windows.Forms.Label lbSubtotalFarmaceutico;
        private System.Windows.Forms.Label lbTotalFarmaceutico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbDescripcionFarmaceutico;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.NumericUpDown NbUnidadesFarmaceutico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
