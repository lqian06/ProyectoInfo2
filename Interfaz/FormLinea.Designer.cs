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
            this.btnParar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnInfoVuelos = new System.Windows.Forms.Button();
            this.GridDatosVuelos = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.CambiarVelBtn = new System.Windows.Forms.Button();
            this.NewVelFP1textBox = new System.Windows.Forms.TextBox();
            this.NewVelFP2textBox = new System.Windows.Forms.TextBox();
            this.NewVelFP1label = new System.Windows.Forms.Label();
            this.NewVelFP2label = new System.Windows.Forms.Label();
            this.RestartSimBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridDatosVuelos)).BeginInit();
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
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(952, 449);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(138, 77);
            this.btnParar.TabIndex = 2;
            this.btnParar.Text = "Detener simulación";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 402);
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
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1228, 449);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 70);
            this.button5.TabIndex = 6;
            this.button5.Text = "reiniciar simulación";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // CambiarVelBtn
            // 
            this.CambiarVelBtn.Location = new System.Drawing.Point(1217, 22);
            this.CambiarVelBtn.Name = "CambiarVelBtn";
            this.CambiarVelBtn.Size = new System.Drawing.Size(100, 56);
            this.CambiarVelBtn.TabIndex = 6;
            this.CambiarVelBtn.Text = "Cambiar Velocidades";
            this.CambiarVelBtn.UseVisualStyleBackColor = true;
            this.CambiarVelBtn.Click += new System.EventHandler(this.CambiarVelBtn_Click);
            // 
            // NewVelFP1textBox
            // 
            this.NewVelFP1textBox.Location = new System.Drawing.Point(1217, 112);
            this.NewVelFP1textBox.Name = "NewVelFP1textBox";
            this.NewVelFP1textBox.Size = new System.Drawing.Size(100, 22);
            this.NewVelFP1textBox.TabIndex = 7;
            // 
            // NewVelFP2textBox
            // 
            this.NewVelFP2textBox.Location = new System.Drawing.Point(1217, 173);
            this.NewVelFP2textBox.Name = "NewVelFP2textBox";
            this.NewVelFP2textBox.Size = new System.Drawing.Size(100, 22);
            this.NewVelFP2textBox.TabIndex = 8;
            // 
            // NewVelFP1label
            // 
            this.NewVelFP1label.AutoSize = true;
            this.NewVelFP1label.Location = new System.Drawing.Point(1197, 93);
            this.NewVelFP1label.Name = "NewVelFP1label";
            this.NewVelFP1label.Size = new System.Drawing.Size(140, 16);
            this.NewVelFP1label.TabIndex = 0;
            this.NewVelFP1label.Text = "Nueva velocidad FP1:";
            // 
            // NewVelFP2label
            // 
            this.NewVelFP2label.AutoSize = true;
            this.NewVelFP2label.Location = new System.Drawing.Point(1197, 154);
            this.NewVelFP2label.Name = "NewVelFP2label";
            this.NewVelFP2label.Size = new System.Drawing.Size(140, 16);
            this.NewVelFP2label.TabIndex = 0;
            this.NewVelFP2label.Text = "Nueva velocidad FP2:";
            // 
            // RestartSimBtn
            // 
            this.RestartSimBtn.Location = new System.Drawing.Point(1229, 449);
            this.RestartSimBtn.Name = "RestartSimBtn";
            this.RestartSimBtn.Size = new System.Drawing.Size(97, 70);
            this.RestartSimBtn.TabIndex = 9;
            this.RestartSimBtn.Text = "Reiniciar Simulación";
            this.RestartSimBtn.UseVisualStyleBackColor = true;
            this.RestartSimBtn.Click += new System.EventHandler(this.RestartSimBtn_Click);
            // 
            // FormLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 538);
            this.Controls.Add(this.RestartSimBtn);
            this.Controls.Add(this.NewVelFP2label);
            this.Controls.Add(this.NewVelFP1label);
            this.Controls.Add(this.NewVelFP2textBox);
            this.Controls.Add(this.NewVelFP1textBox);
            this.Controls.Add(this.CambiarVelBtn);
            this.Controls.Add(this.GridDatosVuelos);
            this.Controls.Add(this.BtnInfoVuelos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormLinea";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.FormLinea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridDatosVuelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnInfoVuelos;
        private System.Windows.Forms.DataGridView GridDatosVuelos;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button CambiarVelBtn;
        private System.Windows.Forms.TextBox NewVelFP1textBox;
        private System.Windows.Forms.TextBox NewVelFP2textBox;
        private System.Windows.Forms.Label NewVelFP1label;
        private System.Windows.Forms.Label NewVelFP2label;
        private System.Windows.Forms.Button RestartSimBtn;
    }
}