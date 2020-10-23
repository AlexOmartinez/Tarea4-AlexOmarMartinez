namespace Tarea4_AlexOmarMartinez.Forms
{
    partial class FormMenu
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
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnSalEyN = new System.Windows.Forms.Button();
            this.BtnTVentas = new System.Windows.Forms.Button();
            this.BtnCuotaMV = new System.Windows.Forms.Button();
            this.BtnNSal = new System.Windows.Forms.Button();
            this.BtnCuotaMP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Aqua;
            this.BtnSalir.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(318, 164);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(72, 32);
            this.BtnSalir.TabIndex = 0;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnSalEyN
            // 
            this.BtnSalEyN.BackColor = System.Drawing.Color.Aqua;
            this.BtnSalEyN.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalEyN.Location = new System.Drawing.Point(12, 50);
            this.BtnSalEyN.Name = "BtnSalEyN";
            this.BtnSalEyN.Size = new System.Drawing.Size(122, 51);
            this.BtnSalEyN.TabIndex = 1;
            this.BtnSalEyN.Text = "Salario Extra y Salario Neto";
            this.BtnSalEyN.UseVisualStyleBackColor = false;
            this.BtnSalEyN.Click += new System.EventHandler(this.BtnSalEyN_Click);
            // 
            // BtnTVentas
            // 
            this.BtnTVentas.BackColor = System.Drawing.Color.Aqua;
            this.BtnTVentas.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTVentas.Location = new System.Drawing.Point(206, 107);
            this.BtnTVentas.Name = "BtnTVentas";
            this.BtnTVentas.Size = new System.Drawing.Size(122, 51);
            this.BtnTVentas.TabIndex = 2;
            this.BtnTVentas.Text = "Total de Ventas";
            this.BtnTVentas.UseVisualStyleBackColor = false;
            this.BtnTVentas.Click += new System.EventHandler(this.BtnTVentas_Click);
            // 
            // BtnCuotaMV
            // 
            this.BtnCuotaMV.BackColor = System.Drawing.Color.Aqua;
            this.BtnCuotaMV.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCuotaMV.Location = new System.Drawing.Point(78, 107);
            this.BtnCuotaMV.Name = "BtnCuotaMV";
            this.BtnCuotaMV.Size = new System.Drawing.Size(122, 51);
            this.BtnCuotaMV.TabIndex = 3;
            this.BtnCuotaMV.Text = "Cuota Mensual por Venta";
            this.BtnCuotaMV.UseVisualStyleBackColor = false;
            this.BtnCuotaMV.Click += new System.EventHandler(this.BtnCuotaMV_Click);
            // 
            // BtnNSal
            // 
            this.BtnNSal.BackColor = System.Drawing.Color.Aqua;
            this.BtnNSal.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNSal.Location = new System.Drawing.Point(268, 50);
            this.BtnNSal.Name = "BtnNSal";
            this.BtnNSal.Size = new System.Drawing.Size(122, 51);
            this.BtnNSal.TabIndex = 4;
            this.BtnNSal.Text = "Nuevo Salario";
            this.BtnNSal.UseVisualStyleBackColor = false;
            this.BtnNSal.Click += new System.EventHandler(this.BtnNSal_Click);
            // 
            // BtnCuotaMP
            // 
            this.BtnCuotaMP.BackColor = System.Drawing.Color.Aqua;
            this.BtnCuotaMP.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCuotaMP.Location = new System.Drawing.Point(140, 50);
            this.BtnCuotaMP.Name = "BtnCuotaMP";
            this.BtnCuotaMP.Size = new System.Drawing.Size(122, 51);
            this.BtnCuotaMP.TabIndex = 5;
            this.BtnCuotaMP.Text = "Cuota Mensual de un Prestamo";
            this.BtnCuotaMP.UseVisualStyleBackColor = false;
            this.BtnCuotaMP.Click += new System.EventHandler(this.BtnCuotaMP_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(404, 201);
            this.Controls.Add(this.BtnCuotaMP);
            this.Controls.Add(this.BtnNSal);
            this.Controls.Add(this.BtnCuotaMV);
            this.Controls.Add(this.BtnTVentas);
            this.Controls.Add(this.BtnSalEyN);
            this.Controls.Add(this.BtnSalir);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnSalEyN;
        private System.Windows.Forms.Button BtnTVentas;
        private System.Windows.Forms.Button BtnCuotaMV;
        private System.Windows.Forms.Button BtnNSal;
        private System.Windows.Forms.Button BtnCuotaMP;
    }
}