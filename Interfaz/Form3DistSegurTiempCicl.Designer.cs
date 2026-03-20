namespace Interfaz
{
    partial class Form3DistSegurTiempCicl
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
            this.TextDistanciaSeguridad = new System.Windows.Forms.TextBox();
            this.DistanciaSeguridad = new System.Windows.Forms.Label();
            this.TiempoCiclo = new System.Windows.Forms.Label();
            this.TextTiempoCiclo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextDistanciaSeguridad
            // 
            this.TextDistanciaSeguridad.Location = new System.Drawing.Point(455, 199);
            this.TextDistanciaSeguridad.Name = "TextDistanciaSeguridad";
            this.TextDistanciaSeguridad.Size = new System.Drawing.Size(105, 22);
            this.TextDistanciaSeguridad.TabIndex = 0;
            this.TextDistanciaSeguridad.TextChanged += new System.EventHandler(this.TextDistanciaSeguridad_TextChanged);
            // 
            // DistanciaSeguridad
            // 
            this.DistanciaSeguridad.AutoSize = true;
            this.DistanciaSeguridad.Location = new System.Drawing.Point(452, 151);
            this.DistanciaSeguridad.Name = "DistanciaSeguridad";
            this.DistanciaSeguridad.Size = new System.Drawing.Size(146, 16);
            this.DistanciaSeguridad.TabIndex = 2;
            this.DistanciaSeguridad.Text = "Distancia de seguridad";
            this.DistanciaSeguridad.Click += new System.EventHandler(this.label1_Click);
            // 
            // TiempoCiclo
            // 
            this.TiempoCiclo.AutoSize = true;
            this.TiempoCiclo.Location = new System.Drawing.Point(127, 151);
            this.TiempoCiclo.Name = "TiempoCiclo";
            this.TiempoCiclo.Size = new System.Drawing.Size(104, 16);
            this.TiempoCiclo.TabIndex = 3;
            this.TiempoCiclo.Text = "Tiempo de ciclo";
            // 
            // TextTiempoCiclo
            // 
            this.TextTiempoCiclo.Location = new System.Drawing.Point(172, 199);
            this.TextTiempoCiclo.Name = "TextTiempoCiclo";
            this.TextTiempoCiclo.Size = new System.Drawing.Size(204, 22);
            this.TextTiempoCiclo.TabIndex = 4;
            this.TextTiempoCiclo.TextChanged += new System.EventHandler(this.TextTiempoCiclo_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(569, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 58);
            this.button2.TabIndex = 0;
            this.button2.Text = "Autorrellenar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3DistSegurTiempCicl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextTiempoCiclo);
            this.Controls.Add(this.TiempoCiclo);
            this.Controls.Add(this.DistanciaSeguridad);
            this.Controls.Add(this.TextDistanciaSeguridad);
            this.Name = "Form3DistSegurTiempCicl";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextDistanciaSeguridad;
        private System.Windows.Forms.TextBox EntradaTiempoCiclo;
        private System.Windows.Forms.Label DistanciaSeguridad;
        private System.Windows.Forms.Label TiempoCiclo;
        private System.Windows.Forms.TextBox TextTiempoCiclo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}