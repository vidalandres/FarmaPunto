namespace FarmaPunto
{
    partial class UCFacturacion
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
            this.BtnFacturaAdministrador = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LbelFechaderealizacionA = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuSeparator7 = new Bunifu.Framework.UI.BunifuSeparator();
            this.DtgElementosFacturaAdministrador = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtCodigoFacturaAdministrador = new System.Windows.Forms.Label();
            this.LbelContraseña = new System.Windows.Forms.Label();
            this.TxtcodigoAdministrador = new System.Windows.Forms.TextBox();
            this.bunifuSeparator9 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lbSubtotalAdministrador = new System.Windows.Forms.Label();
            this.lbTotalAdministrador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbDescripcionAdministrador = new System.Windows.Forms.TextBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.NbUnidadesAdministrador = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DtgElementosFacturaAdministrador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbUnidadesAdministrador)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnFacturaAdministrador
            // 
            this.BtnFacturaAdministrador.BackColor = System.Drawing.Color.Crimson;
            this.BtnFacturaAdministrador.FlatAppearance.BorderSize = 0;
            this.BtnFacturaAdministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFacturaAdministrador.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFacturaAdministrador.ForeColor = System.Drawing.Color.White;
            this.BtnFacturaAdministrador.Image = global::FarmaPunto.Properties.Resources.icons8_activity_history_35__1_;
            this.BtnFacturaAdministrador.Location = new System.Drawing.Point(580, 462);
            this.BtnFacturaAdministrador.Name = "BtnFacturaAdministrador";
            this.BtnFacturaAdministrador.Size = new System.Drawing.Size(142, 48);
            this.BtnFacturaAdministrador.TabIndex = 7;
            this.BtnFacturaAdministrador.Text = "Facturar";
            this.BtnFacturaAdministrador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFacturaAdministrador.UseVisualStyleBackColor = false;
            this.BtnFacturaAdministrador.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(106, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Fecha De Hoy";
            // 
            // LbelFechaderealizacionA
            // 
            this.LbelFechaderealizacionA.AutoSize = true;
            this.LbelFechaderealizacionA.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbelFechaderealizacionA.ForeColor = System.Drawing.Color.DimGray;
            this.LbelFechaderealizacionA.Location = new System.Drawing.Point(27, 11);
            this.LbelFechaderealizacionA.Name = "LbelFechaderealizacionA";
            this.LbelFechaderealizacionA.Size = new System.Drawing.Size(73, 22);
            this.LbelFechaderealizacionA.TabIndex = 23;
            this.LbelFechaderealizacionA.Text = "Fecha:";
            this.LbelFechaderealizacionA.Click += new System.EventHandler(this.LbelFechaderealizacion_Click);
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
            // DtgElementosFacturaAdministrador
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DtgElementosFacturaAdministrador.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgElementosFacturaAdministrador.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DtgElementosFacturaAdministrador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtgElementosFacturaAdministrador.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgElementosFacturaAdministrador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DtgElementosFacturaAdministrador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgElementosFacturaAdministrador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Subtotal,
            this.Column5,
            this.Column6});
            this.DtgElementosFacturaAdministrador.DoubleBuffered = true;
            this.DtgElementosFacturaAdministrador.EnableHeadersVisualStyles = false;
            this.DtgElementosFacturaAdministrador.HeaderBgColor = System.Drawing.Color.Crimson;
            this.DtgElementosFacturaAdministrador.HeaderForeColor = System.Drawing.Color.White;
            this.DtgElementosFacturaAdministrador.Location = new System.Drawing.Point(31, 144);
            this.DtgElementosFacturaAdministrador.Name = "DtgElementosFacturaAdministrador";
            this.DtgElementosFacturaAdministrador.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtgElementosFacturaAdministrador.Size = new System.Drawing.Size(691, 294);
            this.DtgElementosFacturaAdministrador.TabIndex = 115;
            this.DtgElementosFacturaAdministrador.DataSourceChanged += new System.EventHandler(this.DtgElementosFactura_DataSourceChanged);
            this.DtgElementosFacturaAdministrador.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
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
            // TxtCodigoFacturaAdministrador
            // 
            this.TxtCodigoFacturaAdministrador.AutoSize = true;
            this.TxtCodigoFacturaAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoFacturaAdministrador.ForeColor = System.Drawing.Color.DimGray;
            this.TxtCodigoFacturaAdministrador.Location = new System.Drawing.Point(702, 11);
            this.TxtCodigoFacturaAdministrador.Name = "TxtCodigoFacturaAdministrador";
            this.TxtCodigoFacturaAdministrador.Size = new System.Drawing.Size(15, 16);
            this.TxtCodigoFacturaAdministrador.TabIndex = 117;
            this.TxtCodigoFacturaAdministrador.Text = "0";
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
            // TxtcodigoAdministrador
            // 
            this.TxtcodigoAdministrador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtcodigoAdministrador.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtcodigoAdministrador.ForeColor = System.Drawing.Color.DimGray;
            this.TxtcodigoAdministrador.Location = new System.Drawing.Point(28, 80);
            this.TxtcodigoAdministrador.Name = "TxtcodigoAdministrador";
            this.TxtcodigoAdministrador.Size = new System.Drawing.Size(128, 26);
            this.TxtcodigoAdministrador.TabIndex = 119;
            this.TxtcodigoAdministrador.TextChanged += new System.EventHandler(this.Txtcodigo_TextChanged);
            this.TxtcodigoAdministrador.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtcodigo_KeyDown);
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
            // lbSubtotalAdministrador
            // 
            this.lbSubtotalAdministrador.AutoSize = true;
            this.lbSubtotalAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubtotalAdministrador.ForeColor = System.Drawing.Color.DimGray;
            this.lbSubtotalAdministrador.Location = new System.Drawing.Point(28, 462);
            this.lbSubtotalAdministrador.Name = "lbSubtotalAdministrador";
            this.lbSubtotalAdministrador.Size = new System.Drawing.Size(25, 16);
            this.lbSubtotalAdministrador.TabIndex = 147;
            this.lbSubtotalAdministrador.Text = "$ #";
            // 
            // lbTotalAdministrador
            // 
            this.lbTotalAdministrador.AutoSize = true;
            this.lbTotalAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalAdministrador.ForeColor = System.Drawing.Color.DimGray;
            this.lbTotalAdministrador.Location = new System.Drawing.Point(25, 489);
            this.lbTotalAdministrador.Name = "lbTotalAdministrador";
            this.lbTotalAdministrador.Size = new System.Drawing.Size(45, 29);
            this.lbTotalAdministrador.TabIndex = 148;
            this.lbTotalAdministrador.Text = "$ #";
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
            // TbDescripcionAdministrador
            // 
            this.TbDescripcionAdministrador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbDescripcionAdministrador.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbDescripcionAdministrador.ForeColor = System.Drawing.Color.DimGray;
            this.TbDescripcionAdministrador.Location = new System.Drawing.Point(162, 80);
            this.TbDescripcionAdministrador.Name = "TbDescripcionAdministrador";
            this.TbDescripcionAdministrador.ReadOnly = true;
            this.TbDescripcionAdministrador.Size = new System.Drawing.Size(277, 26);
            this.TbDescripcionAdministrador.TabIndex = 150;
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
            // NbUnidadesAdministrador
            // 
            this.NbUnidadesAdministrador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NbUnidadesAdministrador.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.NbUnidadesAdministrador.Location = new System.Drawing.Point(444, 80);
            this.NbUnidadesAdministrador.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NbUnidadesAdministrador.Name = "NbUnidadesAdministrador";
            this.NbUnidadesAdministrador.Size = new System.Drawing.Size(86, 29);
            this.NbUnidadesAdministrador.TabIndex = 152;
            this.NbUnidadesAdministrador.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NbUnidadesAdministrador.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NbUnidades_KeyDown);
            // 
            // UCFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.NbUnidadesAdministrador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbDescripcionAdministrador);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.lbTotalAdministrador);
            this.Controls.Add(this.lbSubtotalAdministrador);
            this.Controls.Add(this.LbelContraseña);
            this.Controls.Add(this.TxtcodigoAdministrador);
            this.Controls.Add(this.bunifuSeparator9);
            this.Controls.Add(this.TxtCodigoFacturaAdministrador);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DtgElementosFacturaAdministrador);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bunifuSeparator7);
            this.Controls.Add(this.LbelFechaderealizacionA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnFacturaAdministrador);
            this.Name = "UCFacturacion";
            this.Size = new System.Drawing.Size(985, 677);
            this.Load += new System.EventHandler(this.UCFacturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgElementosFacturaAdministrador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbUnidadesAdministrador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnFacturaAdministrador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LbelFechaderealizacionA;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator7;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DtgElementosFacturaAdministrador;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label TxtCodigoFacturaAdministrador;
        private System.Windows.Forms.Label LbelContraseña;
        private System.Windows.Forms.TextBox TxtcodigoAdministrador;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator9;
        private System.Windows.Forms.Label lbSubtotalAdministrador;
        private System.Windows.Forms.Label lbTotalAdministrador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbDescripcionAdministrador;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.NumericUpDown NbUnidadesAdministrador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
