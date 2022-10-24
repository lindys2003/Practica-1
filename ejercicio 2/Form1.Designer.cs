
namespace ejercicio_2
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
            this.txt_Num1 = new System.Windows.Forms.TextBox();
            this.txt_Num2 = new System.Windows.Forms.TextBox();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.txt_num3 = new System.Windows.Forms.TextBox();
            this.comboOperaciones = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Num1
            // 
            this.txt_Num1.Location = new System.Drawing.Point(67, 37);
            this.txt_Num1.Name = "txt_Num1";
            this.txt_Num1.Size = new System.Drawing.Size(110, 22);
            this.txt_Num1.TabIndex = 0;
            this.txt_Num1.Text = "Numero 1";
            this.txt_Num1.TextChanged += new System.EventHandler(this.txt_Num1_TextChanged);
            // 
            // txt_Num2
            // 
            this.txt_Num2.Location = new System.Drawing.Point(232, 37);
            this.txt_Num2.Name = "txt_Num2";
            this.txt_Num2.Size = new System.Drawing.Size(116, 22);
            this.txt_Num2.TabIndex = 1;
            this.txt_Num2.Text = "Numero 2";
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(53, 77);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(138, 22);
            this.txtnum1.TabIndex = 2;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(220, 75);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(138, 22);
            this.txtnum2.TabIndex = 3;
            // 
            // txt_num3
            // 
            this.txt_num3.Location = new System.Drawing.Point(67, 133);
            this.txt_num3.Name = "txt_num3";
            this.txt_num3.Size = new System.Drawing.Size(109, 22);
            this.txt_num3.TabIndex = 4;
            this.txt_num3.Text = "Operaciones ";
            // 
            // comboOperaciones
            // 
            this.comboOperaciones.FormattingEnabled = true;
            this.comboOperaciones.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicacion",
            "Division"});
            this.comboOperaciones.Location = new System.Drawing.Point(52, 170);
            this.comboOperaciones.Name = "comboOperaciones";
            this.comboOperaciones.Size = new System.Drawing.Size(138, 24);
            this.comboOperaciones.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(317, 152);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(127, 41);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.comboOperaciones);
            this.Controls.Add(this.txt_num3);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.txt_Num2);
            this.Controls.Add(this.txt_Num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Num1;
        private System.Windows.Forms.TextBox txt_Num2;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.TextBox txt_num3;
        private System.Windows.Forms.ComboBox comboOperaciones;
        private System.Windows.Forms.Button btnCalcular;
    }
}

