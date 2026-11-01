namespace CatalogoRecursividad
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpia los recursos que se estén usando.
        /// </summary>
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
            this.tabEjercicios = new System.Windows.Forms.TabControl();
            this.tabFactorial = new System.Windows.Forms.TabPage();
            this.tabFibonacci = new System.Windows.Forms.TabPage();
            this.tabHanoi = new System.Windows.Forms.TabPage();
            this.tabSuma = new System.Windows.Forms.TabPage();
            this.tabBusqueda = new System.Windows.Forms.TabPage();
            this.tabPruebas = new System.Windows.Forms.TabPage();
            this.tabEjercicios.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabEjercicios
            // 
            this.tabEjercicios.Controls.Add(this.tabFactorial);
            this.tabEjercicios.Controls.Add(this.tabFibonacci);
            this.tabEjercicios.Controls.Add(this.tabHanoi);
            this.tabEjercicios.Controls.Add(this.tabSuma);
            this.tabEjercicios.Controls.Add(this.tabBusqueda);
            this.tabEjercicios.Controls.Add(this.tabPruebas);
            this.tabEjercicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabEjercicios.Location = new System.Drawing.Point(0, 0);
            this.tabEjercicios.Name = "tabEjercicios";
            this.tabEjercicios.SelectedIndex = 0;
            this.tabEjercicios.Size = new System.Drawing.Size(900, 560);
            this.tabEjercicios.TabIndex = 0;
            // 
            // tabFactorial
            // 
            this.tabFactorial.Location = new System.Drawing.Point(4, 24);
            this.tabFactorial.Name = "tabFactorial";
            this.tabFactorial.Padding = new System.Windows.Forms.Padding(3);
            this.tabFactorial.Size = new System.Drawing.Size(892, 532);
            this.tabFactorial.TabIndex = 0;
            this.tabFactorial.Text = "Factorial";
            this.tabFactorial.UseVisualStyleBackColor = true;
            // 
            // tabFibonacci
            // 
            this.tabFibonacci.Location = new System.Drawing.Point(4, 24);
            this.tabFibonacci.Name = "tabFibonacci";
            this.tabFibonacci.Padding = new System.Windows.Forms.Padding(3);
            this.tabFibonacci.Size = new System.Drawing.Size(892, 532);
            this.tabFibonacci.TabIndex = 1;
            this.tabFibonacci.Text = "Fibonacci";
            this.tabFibonacci.UseVisualStyleBackColor = true;
            // 
            // tabHanoi
            // 
            this.tabHanoi.Location = new System.Drawing.Point(4, 24);
            this.tabHanoi.Name = "tabHanoi";
            this.tabHanoi.Padding = new System.Windows.Forms.Padding(3);
            this.tabHanoi.Size = new System.Drawing.Size(892, 532);
            this.tabHanoi.TabIndex = 2;
            this.tabHanoi.Text = "Torres de Hanói";
            this.tabHanoi.UseVisualStyleBackColor = true;
            // 
            // tabSuma
            // 
            this.tabSuma.Location = new System.Drawing.Point(4, 24);
            this.tabSuma.Name = "tabSuma";
            this.tabSuma.Padding = new System.Windows.Forms.Padding(3);
            this.tabSuma.Size = new System.Drawing.Size(892, 532);
            this.tabSuma.TabIndex = 3;
            this.tabSuma.Text = "Suma de un arreglo";
            this.tabSuma.UseVisualStyleBackColor = true;
            // 
            // tabBusqueda
            // 
            this.tabBusqueda.Location = new System.Drawing.Point(4, 24);
            this.tabBusqueda.Name = "tabBusqueda";
            this.tabBusqueda.Padding = new System.Windows.Forms.Padding(3);
            this.tabBusqueda.Size = new System.Drawing.Size(892, 532);
            this.tabBusqueda.TabIndex = 4;
            this.tabBusqueda.Text = "Búsqueda lineal";
            this.tabBusqueda.UseVisualStyleBackColor = true;
            // 
            // tabPruebas
            // 
            this.tabPruebas.Location = new System.Drawing.Point(4, 24);
            this.tabPruebas.Name = "tabPruebas";
            this.tabPruebas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPruebas.Size = new System.Drawing.Size(892, 532);
            this.tabPruebas.TabIndex = 5;
            this.tabPruebas.Text = "Pruebas";
            this.tabPruebas.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 560);
            this.Controls.Add(this.tabEjercicios);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo de ejercicios: iterativo y recursivo";
            this.tabEjercicios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabEjercicios;
        private System.Windows.Forms.TabPage tabFactorial;
        private System.Windows.Forms.TabPage tabFibonacci;
        private System.Windows.Forms.TabPage tabHanoi;
        private System.Windows.Forms.TabPage tabSuma;
        private System.Windows.Forms.TabPage tabBusqueda;
        private System.Windows.Forms.TabPage tabPruebas;
    }
}