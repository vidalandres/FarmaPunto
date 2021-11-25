namespace FarmaPunto
{
    partial class FrmFarmaceutico
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
            this.BtnFacturacion = new System.Windows.Forms.Button();
            this.BtnProductos = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.PnelEjecucion = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LbelBienvenido = new System.Windows.Forms.Label();
            this.LbelHora = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
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
            this.PnelMenu.Location = new System.Drawing.Point(-2, -2);
            this.PnelMenu.Name = "PnelMenu";
            this.PnelMenu.Size = new System.Drawing.Size(231, 557);
            this.PnelMenu.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Crimson;
            this.flowLayoutPanel1.Controls.Add(this.BtnProductos);
            this.flowLayoutPanel1.Controls.Add(this.BtnFacturacion);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-4, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(233, 487);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // BtnFacturacion
            // 
            this.BtnFacturacion.BackColor = System.Drawing.Color.Crimson;
            this.BtnFacturacion.FlatAppearance.BorderSize = 0;
            this.BtnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFacturacion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFacturacion.ForeColor = System.Drawing.Color.White;
            this.BtnFacturacion.Image = global::FarmaPunto.Properties.Resources.icons8_add_shopping_cart_35__1_;
            this.BtnFacturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFacturacion.Location = new System.Drawing.Point(3, 59);
            this.BtnFacturacion.Name = "BtnFacturacion";
            this.BtnFacturacion.Size = new System.Drawing.Size(228, 50);
            this.BtnFacturacion.TabIndex = 0;
            this.BtnFacturacion.Text = "Facturación ";
            this.BtnFacturacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFacturacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFacturacion.UseVisualStyleBackColor = false;
            this.BtnFacturacion.Click += new System.EventHandler(this.BtnFacturacion_Click);
            // 
            // BtnProductos
            // 
            this.BtnProductos.FlatAppearance.BorderSize = 0;
            this.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProductos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProductos.ForeColor = System.Drawing.Color.White;
            this.BtnProductos.Image = global::FarmaPunto.Properties.Resources.icons8_add_tag_35__1_;
            this.BtnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProductos.Location = new System.Drawing.Point(3, 3);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Size = new System.Drawing.Size(228, 50);
            this.BtnProductos.TabIndex = 1;
            this.BtnProductos.Text = "Productos";
            this.BtnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProductos.UseVisualStyleBackColor = true;
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::FarmaPunto.Properties.Resources.icons8_info_35;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(3, 115);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(228, 50);
            this.button5.TabIndex = 4;
            this.button5.Text = "Info";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
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
            this.PnelEjecucion.Location = new System.Drawing.Point(229, 25);
            this.PnelEjecucion.Name = "PnelEjecucion";
            this.PnelEjecucion.Size = new System.Drawing.Size(756, 519);
            this.PnelEjecucion.TabIndex = 1;
            this.PnelEjecucion.Paint += new System.Windows.Forms.PaintEventHandler(this.PnelEjecucion_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 49);
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
            this.LbelBienvenido.Location = new System.Drawing.Point(26, 220);
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
            this.LbelHora.Location = new System.Drawing.Point(22, 145);
            this.LbelHora.Name = "LbelHora";
            this.LbelHora.Size = new System.Drawing.Size(221, 44);
            this.LbelHora.TabIndex = 0;
            this.LbelHora.Text = "Bienvenido";
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // FrmFarmaceutico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 553);
            this.Controls.Add(this.PnelEjecucion);
            this.Controls.Add(this.PnelMenu);
            this.MinimumSize = new System.Drawing.Size(994, 553);
            this.Name = "FrmFarmaceutico";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.FrmFarmaceutico_Load);
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
        private System.Windows.Forms.Button BtnFacturacion;
        private System.Windows.Forms.Button BtnProductos;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel PnelEjecucion;
        private System.Windows.Forms.Label LbelHora;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label LbelBienvenido;
        private System.Windows.Forms.Label label1;
    }
}