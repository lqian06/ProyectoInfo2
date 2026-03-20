namespace Interfaz
{
    partial class FormLinea
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnInfoVuelos = new System.Windows.Forms.Button();
            this.GridDatosVuelos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridDatosVuelos)).BeginInit();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(651, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 77);
            this.button1.TabIndex = 0;
            this.button1.Text = "Iniciar simulación";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(808, 449);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 77);
            this.button2.TabIndex = 1;
            this.button2.Text = "+ 1 Ciclo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(952, 449);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 77);
            this.button3.TabIndex = 2;
            this.button3.Text = "Detener simulación";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1325, 366);
            this.panel1.Size = new System.Drawing.Size(1325, 402);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // BtnInfoVuelos
            // 
            this.BtnInfoVuelos.Location = new System.Drawing.Point(1105, 449);
            this.BtnInfoVuelos.Name = "BtnInfoVuelos";
            this.BtnInfoVuelos.Size = new System.Drawing.Size(117, 70);
            this.BtnInfoVuelos.TabIndex = 4;
            this.BtnInfoVuelos.Text = "Información de los vuelos";
            this.BtnInfoVuelos.UseVisualStyleBackColor = true;
            this.BtnInfoVuelos.Click += new System.EventHandler(this.BtnInfoVuelos_Click);
            // 
            // GridDatosVuelos
            // 
            this.GridDatosVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDatosVuelos.Location = new System.Drawing.Point(12, 384);
            this.GridDatosVuelos.Name = "GridDatosVuelos";
            this.GridDatosVuelos.RowHeadersWidth = 51;
            this.GridDatosVuelos.RowTemplate.Height = 24;
            this.GridDatosVuelos.Size = new System.Drawing.Size(611, 142);
            this.GridDatosVuelos.TabIndex = 5;
            this.GridDatosVuelos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDatosVuelos_CellClick);
            this.GridDatosVuelos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDatosVuelos_CellContentClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1199, 449);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 77);
            this.button4.TabIndex = 4;
            this.button4.Text = "Reiniciar simulación";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 538);
            this.Controls.Add(this.GridDatosVuelos);
            this.Controls.Add(this.BtnInfoVuelos);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormLinea";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.FormLinea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridDatosVuelos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnInfoVuelos;
        private System.Windows.Forms.DataGridView GridDatosVuelos;
        private System.Windows.Forms.Button button4;
    }
}