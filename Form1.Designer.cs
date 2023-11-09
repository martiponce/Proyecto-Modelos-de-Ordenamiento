namespace Proyecto_Modelos_de_Ordenamiento
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.txtLimiteVector = new System.Windows.Forms.TextBox();
            this.optBubbleSort = new System.Windows.Forms.RadioButton();
            this.optMergeSort = new System.Windows.Forms.RadioButton();
            this.optQuickSort = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.txtIntercambios = new System.Windows.Forms.TextBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.columMétodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columCanElementos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columTiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columIntercambios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartDatos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnOrdenar);
            this.groupBox1.Controls.Add(this.txtLimiteVector);
            this.groupBox1.Controls.Add(this.optBubbleSort);
            this.groupBox1.Controls.Add(this.optMergeSort);
            this.groupBox1.Controls.Add(this.optQuickSort);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 316);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "• Elija el método:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "• Límite del vector";
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOrdenar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOrdenar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOrdenar.FlatAppearance.BorderSize = 2;
            this.btnOrdenar.Location = new System.Drawing.Point(35, 244);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(99, 32);
            this.btnOrdenar.TabIndex = 6;
            this.btnOrdenar.Text = "ORDENAR";
            this.btnOrdenar.UseVisualStyleBackColor = false;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click_1);
            // 
            // txtLimiteVector
            // 
            this.txtLimiteVector.Location = new System.Drawing.Point(22, 193);
            this.txtLimiteVector.Name = "txtLimiteVector";
            this.txtLimiteVector.Size = new System.Drawing.Size(131, 22);
            this.txtLimiteVector.TabIndex = 3;
            // 
            // optBubbleSort
            // 
            this.optBubbleSort.AutoSize = true;
            this.optBubbleSort.Location = new System.Drawing.Point(22, 71);
            this.optBubbleSort.Name = "optBubbleSort";
            this.optBubbleSort.Size = new System.Drawing.Size(95, 20);
            this.optBubbleSort.TabIndex = 0;
            this.optBubbleSort.TabStop = true;
            this.optBubbleSort.Text = "Bubble Sort";
            this.optBubbleSort.UseVisualStyleBackColor = true;
            // 
            // optMergeSort
            // 
            this.optMergeSort.AutoSize = true;
            this.optMergeSort.Location = new System.Drawing.Point(22, 96);
            this.optMergeSort.Name = "optMergeSort";
            this.optMergeSort.Size = new System.Drawing.Size(91, 20);
            this.optMergeSort.TabIndex = 1;
            this.optMergeSort.TabStop = true;
            this.optMergeSort.Text = "Merge Sort";
            this.optMergeSort.UseVisualStyleBackColor = true;
            // 
            // optQuickSort
            // 
            this.optQuickSort.AutoSize = true;
            this.optQuickSort.Location = new System.Drawing.Point(22, 121);
            this.optQuickSort.Name = "optQuickSort";
            this.optQuickSort.Size = new System.Drawing.Size(86, 20);
            this.optQuickSort.TabIndex = 2;
            this.optQuickSort.TabStop = true;
            this.optQuickSort.Text = "Quick Sort";
            this.optQuickSort.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTiempo);
            this.groupBox2.Controls.Add(this.txtIntercambios);
            this.groupBox2.Location = new System.Drawing.Point(12, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 240);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "• Intercambios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "• Tiempo";
            // 
            // txtTiempo
            // 
            this.txtTiempo.Enabled = false;
            this.txtTiempo.Location = new System.Drawing.Point(21, 63);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(132, 22);
            this.txtTiempo.TabIndex = 4;
            // 
            // txtIntercambios
            // 
            this.txtIntercambios.Enabled = false;
            this.txtIntercambios.Location = new System.Drawing.Point(22, 147);
            this.txtIntercambios.Name = "txtIntercambios";
            this.txtIntercambios.Size = new System.Drawing.Size(131, 22);
            this.txtIntercambios.TabIndex = 5;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columMétodo,
            this.columCanElementos,
            this.columTiempo,
            this.columIntercambios});
            this.dgvDatos.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvDatos.Location = new System.Drawing.Point(214, 22);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.Size = new System.Drawing.Size(643, 306);
            this.dgvDatos.TabIndex = 1;
            // 
            // columMétodo
            // 
            this.columMétodo.HeaderText = "Método";
            this.columMétodo.Name = "columMétodo";
            this.columMétodo.ReadOnly = true;
            // 
            // columCanElementos
            // 
            this.columCanElementos.HeaderText = "Cantidad de Elementos";
            this.columCanElementos.Name = "columCanElementos";
            this.columCanElementos.ReadOnly = true;
            // 
            // columTiempo
            // 
            this.columTiempo.HeaderText = "Tiempo";
            this.columTiempo.Name = "columTiempo";
            this.columTiempo.ReadOnly = true;
            this.columTiempo.Width = 200;
            // 
            // columIntercambios
            // 
            this.columIntercambios.HeaderText = "Intercambios";
            this.columIntercambios.Name = "columIntercambios";
            this.columIntercambios.ReadOnly = true;
            this.columIntercambios.Width = 200;
            // 
            // chartDatos
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDatos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDatos.Legends.Add(legend1);
            this.chartDatos.Location = new System.Drawing.Point(214, 349);
            this.chartDatos.Name = "chartDatos";
            this.chartDatos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            this.chartDatos.Size = new System.Drawing.Size(643, 270);
            this.chartDatos.TabIndex = 2;
            this.chartDatos.Text = "chart1";
            this.chartDatos.Click += new System.EventHandler(this.chartDatos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(879, 631);
            this.Controls.Add(this.chartDatos);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Métodos de Ordenamiento";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optBubbleSort;
        private System.Windows.Forms.RadioButton optMergeSort;
        private System.Windows.Forms.RadioButton optQuickSort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.TextBox txtLimiteVector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.TextBox txtIntercambios;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn columMétodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columCanElementos;
        private System.Windows.Forms.DataGridViewTextBoxColumn columTiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columIntercambios;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDatos;
    }
}

