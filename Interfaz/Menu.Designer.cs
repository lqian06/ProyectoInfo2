namespace Interfaz
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uNOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Botón2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tRESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportarFlightPlan = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnConflicto = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uNOToolStripMenuItem,
            this.Botón2,
            this.tRESToolStripMenuItem,
            this.ImportarFlightPlan});
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menúToolStripMenuItem.Text = "Menú";
            this.menúToolStripMenuItem.Click += new System.EventHandler(this.menúToolStripMenuItem_Click);
            // 
            // uNOToolStripMenuItem
            // 
            this.uNOToolStripMenuItem.Name = "uNOToolStripMenuItem";
            this.uNOToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.uNOToolStripMenuItem.Text = "Configuración Simulador";
            this.uNOToolStripMenuItem.Click += new System.EventHandler(this.uNOToolStripMenuItem_Click);
            // 
            // Botón2
            // 
            this.Botón2.Name = "Botón2";
            this.Botón2.Size = new System.Drawing.Size(257, 26);
            this.Botón2.Text = "Planes de vuelo";
            this.Botón2.Click += new System.EventHandler(this.Botón2_Click);
            // 
            // tRESToolStripMenuItem
            // 
            this.tRESToolStripMenuItem.Name = "tRESToolStripMenuItem";
            this.tRESToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.tRESToolStripMenuItem.Text = "Simulador";
            this.tRESToolStripMenuItem.Click += new System.EventHandler(this.tRESToolStripMenuItem_Click);
            // 
            // ImportarFlightPlan
            // 
            this.ImportarFlightPlan.Name = "ImportarFlightPlan";
            this.ImportarFlightPlan.Size = new System.Drawing.Size(257, 26);
            this.ImportarFlightPlan.Text = "Importar FlightPlan";
            this.ImportarFlightPlan.Click += new System.EventHandler(this.ImportarFlightPlan_Click);
            // 
            // BtnConflicto
            // 
            this.BtnConflicto.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConflicto.Location = new System.Drawing.Point(162, 203);
            this.BtnConflicto.Name = "BtnConflicto";
            this.BtnConflicto.Size = new System.Drawing.Size(412, 77);
            this.BtnConflicto.TabIndex = 5;
            this.BtnConflicto.Text = "¿Habrá Conflicto?";
            this.BtnConflicto.UseVisualStyleBackColor = true;
            this.BtnConflicto.Click += new System.EventHandler(this.BtnConflicto_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnConflicto);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Menu";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaption;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uNOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Botón2;
        private System.Windows.Forms.ToolStripMenuItem tRESToolStripMenuItem;
        private System.Windows.Forms.Button BtnConflicto;
        private System.Windows.Forms.ToolStripMenuItem ImportarFlightPlan;
    }
}

