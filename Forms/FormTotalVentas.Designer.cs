namespace Tarea4_AlexOmarMartinez.Forms
{
    partial class FormTotalVentas
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
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.TxtVentDiaMier = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtVentDiaMart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtVentDiaLun = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTotalVentas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSalario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtVentDiaJueves = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtVentDiaVier = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Aqua;
            this.BtnSalir.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(252, 321);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(72, 32);
            this.BtnSalir.TabIndex = 1;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.Aqua;
            this.BtnLimpiar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Location = new System.Drawing.Point(174, 321);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(72, 32);
            this.BtnLimpiar.TabIndex = 31;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.Location = new System.Drawing.Point(38, 207);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(96, 48);
            this.BtnCalcular.TabIndex = 30;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // TxtVentDiaMier
            // 
            this.TxtVentDiaMier.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtVentDiaMier.Location = new System.Drawing.Point(180, 119);
            this.TxtVentDiaMier.Name = "TxtVentDiaMier";
            this.TxtVentDiaMier.Size = new System.Drawing.Size(122, 25);
            this.TxtVentDiaMier.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 122);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Ventas del Dia Miercoles";
            // 
            // TxtVentDiaMart
            // 
            this.TxtVentDiaMart.Location = new System.Drawing.Point(180, 91);
            this.TxtVentDiaMart.Name = "TxtVentDiaMart";
            this.TxtVentDiaMart.Size = new System.Drawing.Size(122, 25);
            this.TxtVentDiaMart.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ventas del Dia Martes";
            // 
            // TxtVentDiaLun
            // 
            this.TxtVentDiaLun.Location = new System.Drawing.Point(180, 63);
            this.TxtVentDiaLun.Name = "TxtVentDiaLun";
            this.TxtVentDiaLun.Size = new System.Drawing.Size(122, 25);
            this.TxtVentDiaLun.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Ventas del Dia Lunes";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(-1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ingrese los Datos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtTotalVentas
            // 
            this.TxtTotalVentas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtTotalVentas.Location = new System.Drawing.Point(157, 261);
            this.TxtTotalVentas.Name = "TxtTotalVentas";
            this.TxtTotalVentas.ReadOnly = true;
            this.TxtTotalVentas.Size = new System.Drawing.Size(122, 25);
            this.TxtTotalVentas.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Total Ventas";
            // 
            // TxtSalario
            // 
            this.TxtSalario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtSalario.Location = new System.Drawing.Point(157, 290);
            this.TxtSalario.Name = "TxtSalario";
            this.TxtSalario.ReadOnly = true;
            this.TxtSalario.Size = new System.Drawing.Size(122, 25);
            this.TxtSalario.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Salario del Vendedor";
            // 
            // TxtVentDiaJueves
            // 
            this.TxtVentDiaJueves.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtVentDiaJueves.Location = new System.Drawing.Point(180, 148);
            this.TxtVentDiaJueves.Name = "TxtVentDiaJueves";
            this.TxtVentDiaJueves.Size = new System.Drawing.Size(122, 25);
            this.TxtVentDiaJueves.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Ventas del Dia Jueves";
            // 
            // TxtVentDiaVier
            // 
            this.TxtVentDiaVier.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtVentDiaVier.Location = new System.Drawing.Point(180, 176);
            this.TxtVentDiaVier.Name = "TxtVentDiaVier";
            this.TxtVentDiaVier.Size = new System.Drawing.Size(122, 25);
            this.TxtVentDiaVier.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Ventas del Dia Viernes";
            // 
            // FormTotalVentas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(330, 357);
            this.ControlBox = false;
            this.Controls.Add(this.TxtVentDiaVier);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtVentDiaJueves);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtSalario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtTotalVentas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtVentDiaMier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtVentDiaMart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtVentDiaLun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSalir);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FormTotalVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular el Total de Ventas de un Vendedor";
            this.Load += new System.EventHandler(this.FormTotalVentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox TxtVentDiaMier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtVentDiaMart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtVentDiaLun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTotalVentas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSalario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtVentDiaJueves;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtVentDiaVier;
        private System.Windows.Forms.Label label8;
    }
}