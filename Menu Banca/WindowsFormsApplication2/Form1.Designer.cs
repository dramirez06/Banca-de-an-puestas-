namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ganaciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ganaciasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gananciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.juegosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basketballToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseballToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.Deporte;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 28.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(478, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 76);
            this.label1.TabIndex = 1;
            this.label1.Text = "Banca Geurys";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(675, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.juegosToolStripMenuItem,
            this.stockToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(828, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ganaciasToolStripMenuItem,
            this.ganaciasToolStripMenuItem1,
            this.gananciasToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // ganaciasToolStripMenuItem
            // 
            this.ganaciasToolStripMenuItem.Name = "ganaciasToolStripMenuItem";
            this.ganaciasToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.ganaciasToolStripMenuItem.Text = "Stock";
            this.ganaciasToolStripMenuItem.Click += new System.EventHandler(this.ganaciasToolStripMenuItem_Click);
            // 
            // ganaciasToolStripMenuItem1
            // 
            this.ganaciasToolStripMenuItem1.Name = "ganaciasToolStripMenuItem1";
            this.ganaciasToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.ganaciasToolStripMenuItem1.Text = "Empleados";
            this.ganaciasToolStripMenuItem1.Click += new System.EventHandler(this.ganaciasToolStripMenuItem1_Click);
            // 
            // gananciasToolStripMenuItem
            // 
            this.gananciasToolStripMenuItem.Name = "gananciasToolStripMenuItem";
            this.gananciasToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.gananciasToolStripMenuItem.Text = "Balance";
            this.gananciasToolStripMenuItem.Click += new System.EventHandler(this.gananciasToolStripMenuItem_Click);
            // 
            // juegosToolStripMenuItem
            // 
            this.juegosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basketballToolStripMenuItem,
            this.baseballToolStripMenuItem});
            this.juegosToolStripMenuItem.Name = "juegosToolStripMenuItem";
            this.juegosToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.juegosToolStripMenuItem.Text = "Apuestas";
            // 
            // basketballToolStripMenuItem
            // 
            this.basketballToolStripMenuItem.Name = "basketballToolStripMenuItem";
            this.basketballToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.basketballToolStripMenuItem.Text = "basketball";
            this.basketballToolStripMenuItem.Click += new System.EventHandler(this.basketballToolStripMenuItem_Click);
            // 
            // baseballToolStripMenuItem
            // 
            this.baseballToolStripMenuItem.Name = "baseballToolStripMenuItem";
            this.baseballToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.baseballToolStripMenuItem.Text = "baseball";
            this.baseballToolStripMenuItem.Click += new System.EventHandler(this.baseballToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventaToolStripMenuItem,
            this.compraToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.stockToolStripMenuItem.Text = "Stock";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.ventaToolStripMenuItem.Text = "Venta";
            this.ventaToolStripMenuItem.Click += new System.EventHandler(this.ventaToolStripMenuItem_Click);
            // 
            // compraToolStripMenuItem
            // 
            this.compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            this.compraToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.compraToolStripMenuItem.Text = "Compra";
            this.compraToolStripMenuItem.Click += new System.EventHandler(this.compraToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 393);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Banca";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ganaciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ganaciasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gananciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem juegosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basketballToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseballToolStripMenuItem;
    }
}

