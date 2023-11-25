namespace ProyectoEstructura
{
    partial class Grafo
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
            lblImpresion = new Label();
            txtImpresion = new TextBox();
            grBoxGrafo = new GroupBox();
            btnAgregarAristas = new Button();
            btnImprimir = new Button();
            lblNumeroGrafo = new Label();
            txtDestino = new TextBox();
            lblDestino = new Label();
            lblOrigen = new Label();
            txtOrigen = new TextBox();
            txtVertices = new TextBox();
            btnVertice = new Button();
            btnEliminar = new Button();
            btnComprobar = new Button();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtBuscarEliminarVertice = new TextBox();
            lblComprobar = new Label();
            grBoxGrafo.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblImpresion
            // 
            lblImpresion.AutoSize = true;
            lblImpresion.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblImpresion.Location = new Point(113, 292);
            lblImpresion.Name = "lblImpresion";
            lblImpresion.Size = new Size(185, 16);
            lblImpresion.TabIndex = 35;
            lblImpresion.Text = "Impresion del gráfo Dirigido";
            // 
            // txtImpresion
            // 
            txtImpresion.Location = new Point(101, 310);
            txtImpresion.Multiline = true;
            txtImpresion.Name = "txtImpresion";
            txtImpresion.Size = new Size(586, 123);
            txtImpresion.TabIndex = 34;
            // 
            // grBoxGrafo
            // 
            grBoxGrafo.BackColor = SystemColors.ControlLight;
            grBoxGrafo.Controls.Add(btnAgregarAristas);
            grBoxGrafo.Controls.Add(btnImprimir);
            grBoxGrafo.Controls.Add(lblNumeroGrafo);
            grBoxGrafo.Controls.Add(txtDestino);
            grBoxGrafo.Controls.Add(lblDestino);
            grBoxGrafo.Controls.Add(lblOrigen);
            grBoxGrafo.Controls.Add(txtOrigen);
            grBoxGrafo.Controls.Add(txtVertices);
            grBoxGrafo.Controls.Add(btnVertice);
            grBoxGrafo.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            grBoxGrafo.Location = new Point(45, 105);
            grBoxGrafo.Name = "grBoxGrafo";
            grBoxGrafo.Size = new Size(434, 169);
            grBoxGrafo.TabIndex = 33;
            grBoxGrafo.TabStop = false;
            grBoxGrafo.Text = "Crear Gráfo";
            // 
            // btnAgregarAristas
            // 
            btnAgregarAristas.Cursor = Cursors.Hand;
            btnAgregarAristas.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarAristas.Location = new Point(321, 95);
            btnAgregarAristas.Name = "btnAgregarAristas";
            btnAgregarAristas.Size = new Size(107, 30);
            btnAgregarAristas.TabIndex = 30;
            btnAgregarAristas.Text = "Agregar Aristas";
            btnAgregarAristas.UseVisualStyleBackColor = true;
            btnAgregarAristas.Click += btnAgregarArista_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Cursor = Cursors.Hand;
            btnImprimir.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnImprimir.Location = new Point(321, 133);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(107, 30);
            btnImprimir.TabIndex = 29;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // lblNumeroGrafo
            // 
            lblNumeroGrafo.AutoSize = true;
            lblNumeroGrafo.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumeroGrafo.Location = new Point(6, 38);
            lblNumeroGrafo.Name = "lblNumeroGrafo";
            lblNumeroGrafo.Size = new Size(178, 16);
            lblNumeroGrafo.TabIndex = 27;
            lblNumeroGrafo.Text = "Cantidad de vertices del grafo";
            // 
            // txtDestino
            // 
            txtDestino.Location = new Point(170, 102);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(100, 23);
            txtDestino.TabIndex = 26;
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDestino.Location = new Point(193, 83);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(49, 16);
            lblDestino.TabIndex = 25;
            lblDestino.Text = "Destino";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblOrigen.Location = new Point(66, 83);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(45, 16);
            lblOrigen.TabIndex = 24;
            lblOrigen.Text = "Origen";
            // 
            // txtOrigen
            // 
            txtOrigen.Location = new Point(39, 102);
            txtOrigen.Name = "txtOrigen";
            txtOrigen.Size = new Size(100, 23);
            txtOrigen.TabIndex = 22;
            // 
            // txtVertices
            // 
            txtVertices.Location = new Point(190, 31);
            txtVertices.Name = "txtVertices";
            txtVertices.Size = new Size(100, 23);
            txtVertices.TabIndex = 21;
            txtVertices.KeyPress += txtVertices_KeyPress;
            // 
            // btnVertice
            // 
            btnVertice.BackColor = SystemColors.ActiveCaption;
            btnVertice.Cursor = Cursors.Hand;
            btnVertice.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnVertice.Location = new Point(312, 27);
            btnVertice.Name = "btnVertice";
            btnVertice.Size = new Size(116, 30);
            btnVertice.TabIndex = 17;
            btnVertice.Text = "Agregar Vertices";
            btnVertice.UseVisualStyleBackColor = false;
            btnVertice.Click += btnAgregarVertice_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnEliminar.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(165, 98);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 30);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnComprobar
            // 
            btnComprobar.BackColor = SystemColors.ActiveCaption;
            btnComprobar.Cursor = Cursors.Hand;
            btnComprobar.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnComprobar.Location = new Point(6, 98);
            btnComprobar.Name = "btnComprobar";
            btnComprobar.Size = new Size(86, 30);
            btnComprobar.TabIndex = 18;
            btnComprobar.Text = "Comprobar";
            btnComprobar.UseVisualStyleBackColor = false;
            btnComprobar.Click += btnComprobar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(141, 40);
            label2.Name = "label2";
            label2.Size = new Size(516, 48);
            label2.TabIndex = 32;
            label2.Text = "6. Comprobar si un vértice es fuente, es decir, si es un vértice del que sólo salen aristas.\r\n\r\nFuncionalidad: Agregar, buscar(comprobar), eliminar e imprimir si el vertice es fuente.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(333, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 23);
            label1.TabIndex = 31;
            label1.Text = "Ejercicio 6";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(txtBuscarEliminarVertice);
            groupBox1.Controls.Add(lblComprobar);
            groupBox1.Controls.Add(btnComprobar);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(510, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 169);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Text = "Funciones";
            // 
            // txtBuscarEliminarVertice
            // 
            txtBuscarEliminarVertice.Location = new Point(78, 65);
            txtBuscarEliminarVertice.Name = "txtBuscarEliminarVertice";
            txtBuscarEliminarVertice.Size = new Size(100, 22);
            txtBuscarEliminarVertice.TabIndex = 29;
            // 
            // lblComprobar
            // 
            lblComprobar.AutoSize = true;
            lblComprobar.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblComprobar.Location = new Point(44, 31);
            lblComprobar.Name = "lblComprobar";
            lblComprobar.Size = new Size(164, 16);
            lblComprobar.TabIndex = 28;
            lblComprobar.Text = "Digite el número del vertice";
            // 
            // Grafo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(lblImpresion);
            Controls.Add(txtImpresion);
            Controls.Add(grBoxGrafo);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(816, 489);
            Name = "Grafo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grafo";
            grBoxGrafo.ResumeLayout(false);
            grBoxGrafo.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblImpresion;
        private TextBox txtImpresion;
        private GroupBox grBoxGrafo;
        private Label lblNumeroGrafo;
        private TextBox txtDestino;
        private Label lblDestino;
        private Label lblOrigen;
        private TextBox txtOrigen;
        private TextBox txtVertices;
        private Button btnEliminar;
        private Button btnComprobar;
        private Button btnVertice;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtBuscarEliminarVertice;
        private Label lblComprobar;
        private Button btnImprimir;
        private Button btnAgregarAristas;
    }
}