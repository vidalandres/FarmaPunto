namespace FarmaPunto
{
    partial class UCHistorialDeVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.DtgFacturas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.BtnFacturaAdministrador = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtProveedor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(338, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtros";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(18, 54);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(681, 10);
            this.bunifuSeparator1.TabIndex = 4;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // DtgFacturas
            // 
            this.DtgFacturas.AllowUserToAddRows = false;
            this.DtgFacturas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DtgFacturas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtgFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgFacturas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DtgFacturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtgFacturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DtgFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgFacturas.DoubleBuffered = true;
            this.DtgFacturas.EnableHeadersVisualStyles = false;
            this.DtgFacturas.GridColor = System.Drawing.Color.WhiteSmoke;
            this.DtgFacturas.HeaderBgColor = System.Drawing.Color.DimGray;
            this.DtgFacturas.HeaderForeColor = System.Drawing.Color.White;
            this.DtgFacturas.Location = new System.Drawing.Point(18, 70);
            this.DtgFacturas.Name = "DtgFacturas";
            this.DtgFacturas.ReadOnly = true;
            this.DtgFacturas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgFacturas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtgFacturas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DtgFacturas.Size = new System.Drawing.Size(679, 329);
            this.DtgFacturas.TabIndex = 33;
            // 
            // BtnFacturaAdministrador
            // 
            this.BtnFacturaAdministrador.BackColor = System.Drawing.Color.Crimson;
            this.BtnFacturaAdministrador.FlatAppearance.BorderSize = 0;
            this.BtnFacturaAdministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFacturaAdministrador.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFacturaAdministrador.ForeColor = System.Drawing.Color.White;
            this.BtnFacturaAdministrador.Image = global::FarmaPunto.Properties.Resources.icons8_activity_history_35__1_;
            this.BtnFacturaAdministrador.Location = new System.Drawing.Point(519, 440);
            this.BtnFacturaAdministrador.Name = "BtnFacturaAdministrador";
            this.BtnFacturaAdministrador.Size = new System.Drawing.Size(178, 48);
            this.BtnFacturaAdministrador.TabIndex = 34;
            this.BtnFacturaAdministrador.Text = "Rep. Productos";
            this.BtnFacturaAdministrador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFacturaAdministrador.UseVisualStyleBackColor = false;
            this.BtnFacturaAdministrador.Click += new System.EventHandler(this.BtnFacturaAdministrador_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::FarmaPunto.Properties.Resources.icons8_activity_history_35__1_;
            this.button1.Location = new System.Drawing.Point(342, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 48);
            this.button1.TabIndex = 35;
            this.button1.Text = "Rep. Ventas";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtProveedor
            // 
            this.TxtProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtProveedor.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProveedor.ForeColor = System.Drawing.Color.DimGray;
            this.TxtProveedor.Location = new System.Drawing.Point(18, 24);
            this.TxtProveedor.Name = "TxtProveedor";
            this.TxtProveedor.Size = new System.Drawing.Size(679, 26);
            this.TxtProveedor.TabIndex = 80;
            this.TxtProveedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtProveedor_KeyDown);
            this.TxtProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProveedor_KeyPress);
            // 
            // UCHistorialDeVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TxtProveedor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnFacturaAdministrador);
            this.Controls.Add(this.DtgFacturas);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label1);
            this.Name = "UCHistorialDeVentas";
            this.Size = new System.Drawing.Size(712, 501);
            this.Load += new System.EventHandler(this.UCHistorialDeVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DtgFacturas;
        private System.Windows.Forms.Button BtnFacturaAdministrador;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtProveedor;
    }
}
