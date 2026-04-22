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
            this.button5 = new System.Windows.Forms.Button();
            this.CambiarVelBtn = new System.Windows.Forms.Button();
            this.RestartSimBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ChocaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(622, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "▶︎";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(768, 486);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 70);
            this.button2.TabIndex = 1;
            this.button2.Text = "▷";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnParar
            // 
            this.btnParar.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParar.Location = new System.Drawing.Point(622, 486);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(140, 70);
            this.btnParar.TabIndex = 2;
            this.btnParar.Text = "||";
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
            this.panel1.Size = new System.Drawing.Size(1320, 468);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // BtnInfoVuelos
            // 
            this.BtnInfoVuelos.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInfoVuelos.Location = new System.Drawing.Point(12, 486);
            this.BtnInfoVuelos.Name = "BtnInfoVuelos";
            this.BtnInfoVuelos.Size = new System.Drawing.Size(140, 70);
            this.BtnInfoVuelos.TabIndex = 4;
            this.BtnInfoVuelos.Text = "ⓘ";
            this.BtnInfoVuelos.UseVisualStyleBackColor = true;
            this.BtnInfoVuelos.Click += new System.EventHandler(this.BtnInfoVuelos_Click);
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
            this.CambiarVelBtn.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CambiarVelBtn.Location = new System.Drawing.Point(1192, 486);
            this.CambiarVelBtn.Name = "CambiarVelBtn";
            this.CambiarVelBtn.Size = new System.Drawing.Size(140, 70);
            this.CambiarVelBtn.TabIndex = 6;
            this.CambiarVelBtn.Text = "⏲️";
            this.CambiarVelBtn.UseVisualStyleBackColor = true;
            this.CambiarVelBtn.Click += new System.EventHandler(this.CambiarVelBtn_Click);
            // 
            // RestartSimBtn
            // 
            this.RestartSimBtn.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartSimBtn.Location = new System.Drawing.Point(330, 486);
            this.RestartSimBtn.Name = "RestartSimBtn";
            this.RestartSimBtn.Size = new System.Drawing.Size(140, 70);
            this.RestartSimBtn.TabIndex = 9;
            this.RestartSimBtn.Text = "⟳";
            this.RestartSimBtn.UseVisualStyleBackColor = true;
            this.RestartSimBtn.Click += new System.EventHandler(this.RestartSimBtn_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(476, 486);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 70);
            this.button3.TabIndex = 11;
            this.button3.Text = "◁";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ChocaLabel
            // 
            this.ChocaLabel.AutoSize = true;
            this.ChocaLabel.Location = new System.Drawing.Point(984, 496);
            this.ChocaLabel.Name = "ChocaLabel";
            this.ChocaLabel.Size = new System.Drawing.Size(46, 16);
            this.ChocaLabel.TabIndex = 10;
            this.ChocaLabel.Text = "Choca";
            // 
            // FormLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 568);
            this.Controls.Add(this.ChocaLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.RestartSimBtn);
            this.Controls.Add(this.CambiarVelBtn);
            this.Controls.Add(this.BtnInfoVuelos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnParar);
            this.Name = "FormLinea";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.FormLinea_Load);
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
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button CambiarVelBtn;
        private System.Windows.Forms.Button RestartSimBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label ChocaLabel;
    }
}