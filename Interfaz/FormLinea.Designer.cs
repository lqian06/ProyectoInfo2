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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.CambiarVelBtn = new System.Windows.Forms.Button();
            this.RestartSimBtn = new System.Windows.Forms.Button();
            this.BtnInfoVuelos = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDatosVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GridDatosVuelos);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 402);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
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
            // ChocaLabel
            // 
            this.ChocaLabel.AutoSize = true;
            this.ChocaLabel.Location = new System.Drawing.Point(1242, 271);
            this.ChocaLabel.Name = "ChocaLabel";
            this.ChocaLabel.Size = new System.Drawing.Size(46, 16);
            this.ChocaLabel.TabIndex = 10;
            this.ChocaLabel.Text = "Choca";
            // 
            // GridDatosVuelos
            // 
            this.GridDatosVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDatosVuelos.Location = new System.Drawing.Point(0, 260);
            this.GridDatosVuelos.Name = "GridDatosVuelos";
            this.GridDatosVuelos.RowHeadersWidth = 51;
            this.GridDatosVuelos.RowTemplate.Height = 24;
            this.GridDatosVuelos.Size = new System.Drawing.Size(611, 142);
            this.GridDatosVuelos.TabIndex = 5;
            this.GridDatosVuelos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDatosVuelos_CellClick);
            this.GridDatosVuelos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDatosVuelos_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(566, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 75);
            this.button1.TabIndex = 12;
            this.button1.Text = "▶︎";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(410, 435);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 75);
            this.button3.TabIndex = 17;
            this.button3.Text = "◁";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // RestartSimBtn
            // 
            this.RestartSimBtn.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartSimBtn.Location = new System.Drawing.Point(878, 435);
            this.RestartSimBtn.Name = "RestartSimBtn";
            this.RestartSimBtn.Size = new System.Drawing.Size(150, 75);
            this.RestartSimBtn.TabIndex = 16;
            this.RestartSimBtn.Text = "⟳";
            this.RestartSimBtn.UseVisualStyleBackColor = true;
            // 
            // BtnInfoVuelos
            // 
            this.BtnInfoVuelos.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInfoVuelos.Location = new System.Drawing.Point(13, 435);
            this.BtnInfoVuelos.Name = "BtnInfoVuelos";
            this.BtnInfoVuelos.Size = new System.Drawing.Size(150, 75);
            this.BtnInfoVuelos.TabIndex = 15;
            this.BtnInfoVuelos.Text = "ⓘ";
            this.BtnInfoVuelos.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(722, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 75);
            this.button2.TabIndex = 13;
            this.button2.Text = "▷";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnParar
            // 
            this.btnParar.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParar.Location = new System.Drawing.Point(566, 435);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(150, 75);
            this.btnParar.TabIndex = 14;
            this.btnParar.Text = "||";
            this.btnParar.UseVisualStyleBackColor = true;
            // 
            // FormLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 535);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.RestartSimBtn);
            this.Controls.Add(this.BtnInfoVuelos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.ChocaLabel);
            this.Controls.Add(this.RestartSimBtn);
            this.Controls.Add(this.CambiarVelBtn);
            this.Controls.Add(this.panel1);
            this.Name = "FormLinea";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.FormLinea_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridDatosVuelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button CambiarVelBtn;
        private System.Windows.Forms.Button RestartSimBtn;
        private System.Windows.Forms.Button BtnInfoVuelos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnParar;
    }
}