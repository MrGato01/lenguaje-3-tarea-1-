namespace lenguaje_3_parcial_1_tarea_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EnterotextBox = new System.Windows.Forms.TextBox();
            this.ParImpartextBox = new System.Windows.Forms.TextBox();
            this.PositivoNegativotextBox = new System.Windows.Forms.TextBox();
            this.Iniciarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un numero entero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero par o impar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero positivo o negativo:";
            // 
            // EnterotextBox
            // 
            this.EnterotextBox.Location = new System.Drawing.Point(246, 66);
            this.EnterotextBox.Name = "EnterotextBox";
            this.EnterotextBox.Size = new System.Drawing.Size(122, 20);
            this.EnterotextBox.TabIndex = 3;
            // 
            // ParImpartextBox
            // 
            this.ParImpartextBox.Location = new System.Drawing.Point(246, 186);
            this.ParImpartextBox.Name = "ParImpartextBox";
            this.ParImpartextBox.Size = new System.Drawing.Size(132, 20);
            this.ParImpartextBox.TabIndex = 4;
            // 
            // PositivoNegativotextBox
            // 
            this.PositivoNegativotextBox.Location = new System.Drawing.Point(246, 243);
            this.PositivoNegativotextBox.Name = "PositivoNegativotextBox";
            this.PositivoNegativotextBox.Size = new System.Drawing.Size(132, 20);
            this.PositivoNegativotextBox.TabIndex = 5;
            // 
            // Iniciarbutton
            // 
            this.Iniciarbutton.Location = new System.Drawing.Point(271, 106);
            this.Iniciarbutton.Name = "Iniciarbutton";
            this.Iniciarbutton.Size = new System.Drawing.Size(75, 23);
            this.Iniciarbutton.TabIndex = 6;
            this.Iniciarbutton.Text = "Iniciar";
            this.Iniciarbutton.UseVisualStyleBackColor = true;
            this.Iniciarbutton.Click += new System.EventHandler(this.Iniciarbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 357);
            this.Controls.Add(this.Iniciarbutton);
            this.Controls.Add(this.PositivoNegativotextBox);
            this.Controls.Add(this.ParImpartextBox);
            this.Controls.Add(this.EnterotextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EnterotextBox;
        private System.Windows.Forms.TextBox ParImpartextBox;
        private System.Windows.Forms.TextBox PositivoNegativotextBox;
        private System.Windows.Forms.Button Iniciarbutton;
    }
}

