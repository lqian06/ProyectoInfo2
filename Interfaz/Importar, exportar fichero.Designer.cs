namespace Interfaz
{
    partial class Importar__exportar_fichero
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
            this.ImportarFlightPlan = new System.Windows.Forms.Label();
            this.ExportarFlightPlan = new System.Windows.Forms.Label();
            this.ImportarFlightPlanTextBox = new System.Windows.Forms.TextBox();
            this.ExportarFlightPlanTextBox = new System.Windows.Forms.TextBox();
            this.bttnImportarFlightPlan = new System.Windows.Forms.Button();
            this.bttnExportarFlightPlan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ImportarFlightPlan
            // 
            this.ImportarFlightPlan.AutoSize = true;
            this.ImportarFlightPlan.Location = new System.Drawing.Point(93, 75);
            this.ImportarFlightPlan.Name = "ImportarFlightPlan";
            this.ImportarFlightPlan.Size = new System.Drawing.Size(118, 16);
            this.ImportarFlightPlan.TabIndex = 0;
            this.ImportarFlightPlan.Text = "Importar FlightPlan";
            // 
            // ExportarFlightPlan
            // 
            this.ExportarFlightPlan.AutoSize = true;
            this.ExportarFlightPlan.Location = new System.Drawing.Point(348, 75);
            this.ExportarFlightPlan.Name = "ExportarFlightPlan";
            this.ExportarFlightPlan.Size = new System.Drawing.Size(118, 16);
            this.ExportarFlightPlan.TabIndex = 1;
            this.ExportarFlightPlan.Text = "Guardar FlightPlan";
            // 
            // ImportarFlightPlanTextBox
            // 
            this.ImportarFlightPlanTextBox.Location = new System.Drawing.Point(96, 113);
            this.ImportarFlightPlanTextBox.Name = "ImportarFlightPlanTextBox";
            this.ImportarFlightPlanTextBox.Size = new System.Drawing.Size(115, 22);
            this.ImportarFlightPlanTextBox.TabIndex = 2;

            // 
            // ExportarFlightPlanTextBox
            // 
            this.ExportarFlightPlanTextBox.Location = new System.Drawing.Point(351, 113);
            this.ExportarFlightPlanTextBox.Name = "ExportarFlightPlanTextBox";
            this.ExportarFlightPlanTextBox.Size = new System.Drawing.Size(116, 22);
            this.ExportarFlightPlanTextBox.TabIndex = 3;
            this.ExportarFlightPlanTextBox.TextChanged += new System.EventHandler(this.ExportarFlightPlanTextBox_TextChanged);
            // 
            // bttnImportarFlightPlan
            // 
            this.bttnImportarFlightPlan.Location = new System.Drawing.Point(110, 174);
            this.bttnImportarFlightPlan.Name = "bttnImportarFlightPlan";
            this.bttnImportarFlightPlan.Size = new System.Drawing.Size(83, 41);
            this.bttnImportarFlightPlan.TabIndex = 4;
            this.bttnImportarFlightPlan.Text = "Aceptar";
            this.bttnImportarFlightPlan.UseVisualStyleBackColor = true;
            this.bttnImportarFlightPlan.Click += new System.EventHandler(this.bttnImportarFlightPlan_Click);
            // 
            // bttnExportarFlightPlan
            // 
            this.bttnExportarFlightPlan.Location = new System.Drawing.Point(367, 174);
            this.bttnExportarFlightPlan.Name = "bttnExportarFlightPlan";
            this.bttnExportarFlightPlan.Size = new System.Drawing.Size(83, 41);
            this.bttnExportarFlightPlan.TabIndex = 5;
            this.bttnExportarFlightPlan.Text = "Aceptar";
            this.bttnExportarFlightPlan.UseVisualStyleBackColor = true;
            // 
            // Importar__exportar_fichero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 315);
            this.Controls.Add(this.bttnExportarFlightPlan);
            this.Controls.Add(this.bttnImportarFlightPlan);
            this.Controls.Add(this.ExportarFlightPlanTextBox);
            this.Controls.Add(this.ImportarFlightPlanTextBox);
            this.Controls.Add(this.ExportarFlightPlan);
            this.Controls.Add(this.ImportarFlightPlan);
            this.Name = "Importar__exportar_fichero";
            this.Text = "Importar__exportar_fichero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ImportarFlightPlan;
        private System.Windows.Forms.Label ExportarFlightPlan;
        private System.Windows.Forms.TextBox ImportarFlightPlanTextBox;
        private System.Windows.Forms.TextBox ExportarFlightPlanTextBox;
        private System.Windows.Forms.Button bttnImportarFlightPlan;
        private System.Windows.Forms.Button bttnExportarFlightPlan;
    }
}