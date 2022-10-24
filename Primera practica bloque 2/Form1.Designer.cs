
namespace Primera_practica_bloque_2
{
    partial class Form1
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
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnSuma = new System.Windows.Forms.Button();
            this.comboOpciones = new System.Windows.Forms.ComboBox();
            this.btnItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(46, 35);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(145, 22);
            this.txtMensaje.TabIndex = 0;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(69, 72);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(94, 26);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(229, 35);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(134, 22);
            this.txtNum1.TabIndex = 2;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(230, 71);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(132, 22);
            this.txtNum2.TabIndex = 3;
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(246, 111);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(104, 29);
            this.btnSuma.TabIndex = 4;
            this.btnSuma.Text = "Sumar";
            this.btnSuma.UseVisualStyleBackColor = true;
            // 
            // comboOpciones
            // 
            this.comboOpciones.FormattingEnabled = true;
            this.comboOpciones.Items.AddRange(new object[] {
            "Opción 1",
            "Opción 2",
            "Opción 3",
            "Opción 4",
            "Opción 5"});
            this.comboOpciones.Location = new System.Drawing.Point(493, 35);
            this.comboOpciones.Name = "comboOpciones";
            this.comboOpciones.Size = new System.Drawing.Size(166, 24);
            this.comboOpciones.TabIndex = 5;
            // 
            // btnItem
            // 
            this.btnItem.Location = new System.Drawing.Point(508, 99);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(129, 30);
            this.btnItem.TabIndex = 6;
            this.btnItem.Text = "Mostrar ";
            this.btnItem.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnItem);
            this.Controls.Add(this.comboOpciones);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtMensaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.ComboBox comboOpciones;
        private System.Windows.Forms.Button btnItem;
    }
}

