
namespace Ejercicio_3
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
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txt_num3 = new System.Windows.Forms.TextBox();
            this.txtNum3 = new System.Windows.Forms.TextBox();
            this.txt_num4 = new System.Windows.Forms.TextBox();
            this.comboOpciones = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_num1
            // 
            this.txt_num1.Location = new System.Drawing.Point(70, 40);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(106, 22);
            this.txt_num1.TabIndex = 0;
            this.txt_num1.Text = "Capital ";
            this.txt_num1.TextChanged += new System.EventHandler(this.txt_num1_TextChanged);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(51, 79);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(144, 22);
            this.txtNum1.TabIndex = 1;
            // 
            // txt_num2
            // 
            this.txt_num2.Location = new System.Drawing.Point(283, 41);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(103, 22);
            this.txt_num2.TabIndex = 2;
            this.txt_num2.Text = "Tasa de interes ";
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(251, 84);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(154, 22);
            this.txtNum2.TabIndex = 3;
            // 
            // txt_num3
            // 
            this.txt_num3.Location = new System.Drawing.Point(70, 129);
            this.txt_num3.Name = "txt_num3";
            this.txt_num3.Size = new System.Drawing.Size(105, 22);
            this.txt_num3.TabIndex = 4;
            this.txt_num3.Text = "Tiempo";
            // 
            // txtNum3
            // 
            this.txtNum3.Location = new System.Drawing.Point(51, 182);
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.Size = new System.Drawing.Size(143, 22);
            this.txtNum3.TabIndex = 5;
            // 
            // txt_num4
            // 
            this.txt_num4.Location = new System.Drawing.Point(308, 129);
            this.txt_num4.Name = "txt_num4";
            this.txt_num4.Size = new System.Drawing.Size(125, 22);
            this.txt_num4.TabIndex = 6;
            this.txt_num4.Text = "Periodo de tiempo";
            // 
            // comboOpciones
            // 
            this.comboOpciones.FormattingEnabled = true;
            this.comboOpciones.Items.AddRange(new object[] {
            "Anual",
            "Mensual",
            "Diario"});
            this.comboOpciones.Location = new System.Drawing.Point(286, 172);
            this.comboOpciones.Name = "comboOpciones";
            this.comboOpciones.Size = new System.Drawing.Size(173, 24);
            this.comboOpciones.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(184, 249);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(161, 36);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.comboOpciones);
            this.Controls.Add(this.txt_num4);
            this.Controls.Add(this.txtNum3);
            this.Controls.Add(this.txt_num3);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.txt_num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txt_num3;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.TextBox txt_num4;
        private System.Windows.Forms.ComboBox comboOpciones;
        private System.Windows.Forms.Button btnCalcular;
    }
}

