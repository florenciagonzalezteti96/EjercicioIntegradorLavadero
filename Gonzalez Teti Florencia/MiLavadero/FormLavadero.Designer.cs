namespace MiLavadero
{
    partial class FormLavadero
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.listaVehiculos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.MistyRose;
            this.btnAgregar.Font = new System.Drawing.Font("OCR A Extended", 9.75F);
            this.btnAgregar.Location = new System.Drawing.Point(12, 210);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(135, 55);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "agregar vehiculo";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.MistyRose;
            this.btnEliminar.Font = new System.Drawing.Font("OCR A Extended", 9.75F);
            this.btnEliminar.Location = new System.Drawing.Point(153, 210);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(149, 55);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "eliminar vehiculo";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // listaVehiculos
            // 
            this.listaVehiculos.BackColor = System.Drawing.Color.MistyRose;
            this.listaVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listaVehiculos.Font = new System.Drawing.Font("OCR A Extended", 9.75F);
            this.listaVehiculos.ForeColor = System.Drawing.Color.SaddleBrown;
            this.listaVehiculos.FormattingEnabled = true;
            this.listaVehiculos.HorizontalScrollbar = true;
            this.listaVehiculos.Location = new System.Drawing.Point(12, 34);
            this.listaVehiculos.Name = "listaVehiculos";
            this.listaVehiculos.Size = new System.Drawing.Size(431, 171);
            this.listaVehiculos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "LAVADERO";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Font = new System.Drawing.Font("OCR A Extended", 9.75F);
            this.button1.Location = new System.Drawing.Point(308, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 55);
            this.button1.TabIndex = 8;
            this.button1.Text = "eliminar todos";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.MistyRose;
            this.BtnCerrar.Font = new System.Drawing.Font("OCR A Extended", 9.75F);
            this.BtnCerrar.Location = new System.Drawing.Point(153, 334);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(149, 55);
            this.BtnCerrar.TabIndex = 9;
            this.BtnCerrar.Text = "cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MistyRose;
            this.button3.Font = new System.Drawing.Font("OCR A Extended", 9.75F);
            this.button3.Location = new System.Drawing.Point(308, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 55);
            this.button3.TabIndex = 10;
            this.button3.Text = "mostrar total facturado";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MistyRose;
            this.button4.Font = new System.Drawing.Font("OCR A Extended", 9.75F);
            this.button4.Location = new System.Drawing.Point(12, 271);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 55);
            this.button4.TabIndex = 11;
            this.button4.Text = "ordenar por patente";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MistyRose;
            this.button5.Font = new System.Drawing.Font("OCR A Extended", 9.75F);
            this.button5.Location = new System.Drawing.Point(153, 271);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(149, 55);
            this.button5.TabIndex = 12;
            this.button5.Text = "ordenar por patente";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // FormLavadero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(452, 395);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaVehiculos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLavadero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Lavadero";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLavadero_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ListBox listaVehiculos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

