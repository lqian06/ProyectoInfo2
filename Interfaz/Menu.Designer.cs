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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ButtonNico = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uNOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Botón2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tRESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.botón4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(671, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "boton favian";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(428, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "BotónQian";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonNico
            // 
            this.ButtonNico.BackColor = System.Drawing.Color.Red;
            this.ButtonNico.Location = new System.Drawing.Point(236, 106);
            this.ButtonNico.Name = "ButtonNico";
            this.ButtonNico.Size = new System.Drawing.Size(240, 107);
            this.ButtonNico.TabIndex = 3;
            this.ButtonNico.Text = "BOTON NICO";
            this.ButtonNico.UseVisualStyleBackColor = false;
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
            this.botón4ToolStripMenuItem});
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menúToolStripMenuItem.Text = "Menú";
            // 
            // uNOToolStripMenuItem
            // 
            this.uNOToolStripMenuItem.Name = "uNOToolStripMenuItem";
            this.uNOToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.uNOToolStripMenuItem.Text = "UNO";
            this.uNOToolStripMenuItem.Click += new System.EventHandler(this.uNOToolStripMenuItem_Click);
            // 
            // Botón2
            // 
            this.Botón2.Name = "Botón2";
            this.Botón2.Size = new System.Drawing.Size(224, 26);
            this.Botón2.Text = "DOS";
            this.Botón2.Click += new System.EventHandler(this.Botón2_Click);
            // 
            // tRESToolStripMenuItem
            // 
            this.tRESToolStripMenuItem.Name = "tRESToolStripMenuItem";
            this.tRESToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tRESToolStripMenuItem.Text = "TRES";
            this.tRESToolStripMenuItem.Click += new System.EventHandler(this.tRESToolStripMenuItem_Click);
            // 
            // botón4ToolStripMenuItem
            // 
            this.botón4ToolStripMenuItem.Name = "botón4ToolStripMenuItem";
            this.botón4ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.botón4ToolStripMenuItem.Text = "Botón 4";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonNico);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Menu";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ButtonNico;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uNOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Botón2;
        private System.Windows.Forms.ToolStripMenuItem tRESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem botón4ToolStripMenuItem;
    }
}

