namespace FarmaPunto
{
    partial class frmLogin
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ChxVerContraseña = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombreDeUsuario = new System.Windows.Forms.TextBox();
            this.SprtorUsuario = new Bunifu.Framework.UI.BunifuSeparator();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.SeparadorContraseña = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnIniciarSesion = new System.Windows.Forms.Button();
            this.PnelColor = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PnelColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ChxVerContraseña
            // 
            this.ChxVerContraseña.AutoSize = true;
            this.ChxVerContraseña.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.ChxVerContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChxVerContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChxVerContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.ChxVerContraseña.Location = new System.Drawing.Point(357, 340);
            this.ChxVerContraseña.Name = "ChxVerContraseña";
            this.ChxVerContraseña.Size = new System.Drawing.Size(125, 21);
            this.ChxVerContraseña.TabIndex = 0;
            this.ChxVerContraseña.Text = "Ver Contraseña";
            this.ChxVerContraseña.UseVisualStyleBackColor = true;
            this.ChxVerContraseña.CheckedChanged += new System.EventHandler(this.ChxVerContraseña_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(349, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre De Usuario";
            // 
            // TxtNombreDeUsuario
            // 
            this.TxtNombreDeUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombreDeUsuario.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreDeUsuario.ForeColor = System.Drawing.Color.Gray;
            this.TxtNombreDeUsuario.Location = new System.Drawing.Point(353, 166);
            this.TxtNombreDeUsuario.Name = "TxtNombreDeUsuario";
            this.TxtNombreDeUsuario.Size = new System.Drawing.Size(337, 26);
            this.TxtNombreDeUsuario.TabIndex = 2;
            // 
            // SprtorUsuario
            // 
            this.SprtorUsuario.AccessibleName = "";
            this.SprtorUsuario.BackColor = System.Drawing.Color.Transparent;
            this.SprtorUsuario.ForeColor = System.Drawing.Color.Maroon;
            this.SprtorUsuario.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.SprtorUsuario.LineThickness = 2;
            this.SprtorUsuario.Location = new System.Drawing.Point(353, 191);
            this.SprtorUsuario.Name = "SprtorUsuario";
            this.SprtorUsuario.Size = new System.Drawing.Size(337, 12);
            this.SprtorUsuario.TabIndex = 3;
            this.SprtorUsuario.Transparency = 255;
            this.SprtorUsuario.Vertical = false;
            this.SprtorUsuario.Load += new System.EventHandler(this.bunifuSeparator1_Load);
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtContraseña.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContraseña.ForeColor = System.Drawing.Color.Gray;
            this.TxtContraseña.Location = new System.Drawing.Point(358, 297);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(337, 26);
            this.TxtContraseña.TabIndex = 5;
            this.TxtContraseña.UseSystemPasswordChar = true;
            // 
            // SeparadorContraseña
            // 
            this.SeparadorContraseña.BackColor = System.Drawing.Color.Transparent;
            this.SeparadorContraseña.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.SeparadorContraseña.LineThickness = 2;
            this.SeparadorContraseña.Location = new System.Drawing.Point(358, 322);
            this.SeparadorContraseña.Name = "SeparadorContraseña";
            this.SeparadorContraseña.Size = new System.Drawing.Size(337, 12);
            this.SeparadorContraseña.TabIndex = 6;
            this.SeparadorContraseña.Transparency = 255;
            this.SeparadorContraseña.Vertical = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(354, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // BtnIniciarSesion
            // 
            this.BtnIniciarSesion.BackColor = System.Drawing.Color.Crimson;
            this.BtnIniciarSesion.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.BtnIniciarSesion.FlatAppearance.BorderSize = 2;
            this.BtnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciarSesion.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.BtnIniciarSesion.Location = new System.Drawing.Point(417, 476);
            this.BtnIniciarSesion.Name = "BtnIniciarSesion";
            this.BtnIniciarSesion.Size = new System.Drawing.Size(208, 40);
            this.BtnIniciarSesion.TabIndex = 7;
            this.BtnIniciarSesion.Text = "Iniciar Sesión";
            this.BtnIniciarSesion.UseVisualStyleBackColor = false;
            this.BtnIniciarSesion.Click += new System.EventHandler(this.BtnIniciarSesion_Click);
            // 
            // PnelColor
            // 
            this.PnelColor.BackColor = System.Drawing.Color.Crimson;
            this.PnelColor.Controls.Add(this.label5);
            this.PnelColor.Controls.Add(this.label4);
            this.PnelColor.Controls.Add(this.label3);
            this.PnelColor.Location = new System.Drawing.Point(-2, 0);
            this.PnelColor.Name = "PnelColor";
            this.PnelColor.Size = new System.Drawing.Size(326, 540);
            this.PnelColor.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(68, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 75);
            this.label5.TabIndex = 11;
            this.label5.Text = "VAA";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(57, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 74);
            this.label4.TabIndex = 10;
            this.label4.Text = "LAT";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 80);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bienvenido al inicio de sesion \r\nde farma punto por favor \r\ningrese sus datos per" +
    "sonales \r\npara continuar.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 539);
            this.Controls.Add(this.PnelColor);
            this.Controls.Add(this.BtnIniciarSesion);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.SeparadorContraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNombreDeUsuario);
            this.Controls.Add(this.SprtorUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChxVerContraseña);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(729, 539);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(729, 539);
            this.Name = "frmLogin";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PnelColor.ResumeLayout(false);
            this.PnelColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuSeparator SprtorUsuario;
        private System.Windows.Forms.TextBox TxtNombreDeUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChxVerContraseña;
        private System.Windows.Forms.TextBox TxtContraseña;
        private Bunifu.Framework.UI.BunifuSeparator SeparadorContraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnIniciarSesion;
        private System.Windows.Forms.Panel PnelColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

