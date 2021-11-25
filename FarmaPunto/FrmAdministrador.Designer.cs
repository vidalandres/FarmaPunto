namespace FarmaPunto
{
    partial class FrmAdministrador
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
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PnelMenu = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnUsuarios = new System.Windows.Forms.Button();
            this.BtnFacturas = new System.Windows.Forms.Button();
            this.BtnGestiondeVentas = new System.Windows.Forms.Button();
            this.BtnProveedor = new System.Windows.Forms.Button();
            this.BtnProducto = new System.Windows.Forms.Button();
            this.Btninfo = new System.Windows.Forms.Button();
            this.PnelEjecucion = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LbelBienvenido = new System.Windows.Forms.Label();
            this.LbelHora = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.PnelMenu.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.PnelEjecucion.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // PnelMenu
            // 
            this.PnelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PnelMenu.BackColor = System.Drawing.Color.Crimson;
            this.PnelMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnelMenu.Controls.Add(this.flowLayoutPanel1);
            this.PnelMenu.Location = new System.Drawing.Point(-5, -10);
            this.PnelMenu.Name = "PnelMenu";
            this.PnelMenu.Size = new System.Drawing.Size(231, 566);
            this.PnelMenu.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Crimson;
            this.flowLayoutPanel1.Controls.Add(this.BtnUsuarios);
            this.flowLayoutPanel1.Controls.Add(this.BtnFacturas);
            this.flowLayoutPanel1.Controls.Add(this.BtnGestiondeVentas);
            this.flowLayoutPanel1.Controls.Add(this.BtnProveedor);
            this.flowLayoutPanel1.Controls.Add(this.BtnProducto);
            this.flowLayoutPanel1.Controls.Add(this.Btninfo);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-2, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(231, 540);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.BackColor = System.Drawing.Color.Crimson;
            this.BtnUsuarios.FlatAppearance.BorderSize = 0;
            this.BtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuarios.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUsuarios.ForeColor = System.Drawing.Color.White;
            this.BtnUsuarios.Image = global::FarmaPunto.Properties.Resources.icons8_staff_35;
            this.BtnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUsuarios.Location = new System.Drawing.Point(3, 3);
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Size = new System.Drawing.Size(228, 50);
            this.BtnUsuarios.TabIndex = 0;
            this.BtnUsuarios.Text = "Usuarios";
            this.BtnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUsuarios.UseVisualStyleBackColor = false;
            this.BtnUsuarios.Click += new System.EventHandler(this.BtnUsuarios_Click);
            // 
            // BtnFacturas
            // 
            this.BtnFacturas.FlatAppearance.BorderSize = 0;
            this.BtnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFacturas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFacturas.ForeColor = System.Drawing.Color.White;
            this.BtnFacturas.Image = global::FarmaPunto.Properties.Resources.icons8_activity_history_35__1_;
            this.BtnFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFacturas.Location = new System.Drawing.Point(3, 59);
            this.BtnFacturas.Name = "BtnFacturas";
            this.BtnFacturas.Size = new System.Drawing.Size(228, 50);
            this.BtnFacturas.TabIndex = 6;
            this.BtnFacturas.Text = "facturas";
            this.BtnFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFacturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFacturas.UseVisualStyleBackColor = true;
            this.BtnFacturas.Click += new System.EventHandler(this.BtnFacturas_Click);
            // 
            // BtnGestiondeVentas
            // 
            this.BtnGestiondeVentas.FlatAppearance.BorderSize = 0;
            this.BtnGestiondeVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGestiondeVentas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestiondeVentas.ForeColor = System.Drawing.Color.White;
            this.BtnGestiondeVentas.Image = global::FarmaPunto.Properties.Resources.icons8_add_shopping_cart_35;
            this.BtnGestiondeVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGestiondeVentas.Location = new System.Drawing.Point(3, 115);
            this.BtnGestiondeVentas.Name = "BtnGestiondeVentas";
            this.BtnGestiondeVentas.Size = new System.Drawing.Size(228, 50);
            this.BtnGestiondeVentas.TabIndex = 4;
            this.BtnGestiondeVentas.Text = "Ventas";
            this.BtnGestiondeVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGestiondeVentas.UseVisualStyleBackColor = true;
            this.BtnGestiondeVentas.Click += new System.EventHandler(this.BtnGestiondeVentas_Click);
            // 
            // BtnProveedor
            // 
            this.BtnProveedor.FlatAppearance.BorderSize = 0;
            this.BtnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProveedor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProveedor.ForeColor = System.Drawing.Color.White;
            this.BtnProveedor.Image = global::FarmaPunto.Properties.Resources.icons8_user_account_35;
            this.BtnProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProveedor.Location = new System.Drawing.Point(3, 171);
            this.BtnProveedor.Name = "BtnProveedor";
            this.BtnProveedor.Size = new System.Drawing.Size(228, 50);
            this.BtnProveedor.TabIndex = 1;
            this.BtnProveedor.Text = "Proveedor";
            this.BtnProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProveedor.UseVisualStyleBackColor = true;
            this.BtnProveedor.Click += new System.EventHandler(this.BtnProveedor_Click);
            // 
            // BtnProducto
            // 
            this.BtnProducto.FlatAppearance.BorderSize = 0;
            this.BtnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProducto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProducto.ForeColor = System.Drawing.Color.White;
            this.BtnProducto.Image = global::FarmaPunto.Properties.Resources.icons8_add_tag_35__1_;
            this.BtnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProducto.Location = new System.Drawing.Point(3, 227);
            this.BtnProducto.Name = "BtnProducto";
            this.BtnProducto.Size = new System.Drawing.Size(228, 50);
            this.BtnProducto.TabIndex = 5;
            this.BtnProducto.Text = "Productos";
            this.BtnProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProducto.UseVisualStyleBackColor = true;
            this.BtnProducto.Click += new System.EventHandler(this.BtnProducto_Click);
            // 
            // Btninfo
            // 
            this.Btninfo.FlatAppearance.BorderSize = 0;
            this.Btninfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btninfo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btninfo.ForeColor = System.Drawing.Color.White;
            this.Btninfo.Image = global::FarmaPunto.Properties.Resources.icons8_info_35;
            this.Btninfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btninfo.Location = new System.Drawing.Point(3, 283);
            this.Btninfo.Name = "Btninfo";
            this.Btninfo.Size = new System.Drawing.Size(228, 50);
            this.Btninfo.TabIndex = 8;
            this.Btninfo.Text = "Info";
            this.Btninfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btninfo.UseVisualStyleBackColor = true;
            this.Btninfo.Click += new System.EventHandler(this.Btninfo_Click);
            // 
            // PnelEjecucion
            // 
            this.PnelEjecucion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnelEjecucion.BackColor = System.Drawing.Color.White;
            this.PnelEjecucion.Controls.Add(this.label1);
            this.PnelEjecucion.Controls.Add(this.LbelBienvenido);
            this.PnelEjecucion.Controls.Add(this.LbelHora);
            this.PnelEjecucion.ForeColor = System.Drawing.Color.Black;
            this.PnelEjecucion.Location = new System.Drawing.Point(227, 28);
            this.PnelEjecucion.Name = "PnelEjecucion";
            this.PnelEjecucion.Size = new System.Drawing.Size(711, 517);
            this.PnelEjecucion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 78);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido";
            // 
            // LbelBienvenido
            // 
            this.LbelBienvenido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LbelBienvenido.AutoSize = true;
            this.LbelBienvenido.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbelBienvenido.ForeColor = System.Drawing.Color.DimGray;
            this.LbelBienvenido.Location = new System.Drawing.Point(26, 219);
            this.LbelBienvenido.Name = "LbelBienvenido";
            this.LbelBienvenido.Size = new System.Drawing.Size(586, 22);
            this.LbelBienvenido.TabIndex = 1;
            this.LbelBienvenido.Text = "Bienvenido al sistema de gestion de productos de farma punto\r\n";
            // 
            // LbelHora
            // 
            this.LbelHora.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LbelHora.AutoSize = true;
            this.LbelHora.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbelHora.ForeColor = System.Drawing.Color.Black;
            this.LbelHora.Location = new System.Drawing.Point(22, 144);
            this.LbelHora.Name = "LbelHora";
            this.LbelHora.Size = new System.Drawing.Size(221, 44);
            this.LbelHora.TabIndex = 0;
            this.LbelHora.Text = "Bienvenido";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FrmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 553);
            this.Controls.Add(this.PnelEjecucion);
            this.Controls.Add(this.PnelMenu);
            this.MinimumSize = new System.Drawing.Size(945, 553);
            this.Name = "FrmAdministrador";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.FrmAdministrador_Load);
            this.PnelMenu.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.PnelEjecucion.ResumeLayout(false);
            this.PnelEjecucion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel PnelMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BtnUsuarios;
        private System.Windows.Forms.Button BtnFacturas;
        private System.Windows.Forms.Button BtnProducto;
        private System.Windows.Forms.Button BtnProveedor;
        private System.Windows.Forms.Button BtnGestiondeVentas;
        private System.Windows.Forms.Panel PnelEjecucion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbelBienvenido;
        private System.Windows.Forms.Label LbelHora;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button Btninfo;
    }
}