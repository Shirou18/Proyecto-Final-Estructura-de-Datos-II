namespace ProyectoEstructura
{
    partial class Arbol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arbol));
            label1 = new Label();
            label2 = new Label();
            grBoxProducto = new GroupBox();
            btnImprimir = new Button();
            lblNombreProd = new Label();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            lblCantidad = new Label();
            txtCantidad = new TextBox();
            txtNombreProducto = new TextBox();
            btnActualizar = new Button();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            txtImpresion = new TextBox();
            lblImpresion = new Label();
            groupBox1 = new GroupBox();
            txtBuscarProducto = new TextBox();
            lblNomBuscar = new Label();
            grBoxProducto.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(324, 22);
            label1.Name = "label1";
            label1.Size = new Size(110, 23);
            label1.TabIndex = 0;
            label1.Text = "Ejercicio 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(104, 61);
            label2.Name = "label2";
            label2.Size = new Size(574, 64);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            // 
            // grBoxProducto
            // 
            grBoxProducto.BackColor = SystemColors.ControlLight;
            grBoxProducto.Controls.Add(btnImprimir);
            grBoxProducto.Controls.Add(lblNombreProd);
            grBoxProducto.Controls.Add(txtPrecio);
            grBoxProducto.Controls.Add(lblPrecio);
            grBoxProducto.Controls.Add(lblCantidad);
            grBoxProducto.Controls.Add(txtCantidad);
            grBoxProducto.Controls.Add(txtNombreProducto);
            grBoxProducto.Controls.Add(btnActualizar);
            grBoxProducto.Controls.Add(btnAgregar);
            grBoxProducto.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            grBoxProducto.Location = new Point(47, 140);
            grBoxProducto.Name = "grBoxProducto";
            grBoxProducto.Size = new Size(361, 153);
            grBoxProducto.TabIndex = 2;
            grBoxProducto.TabStop = false;
            grBoxProducto.Text = "Producto";
            // 
            // btnImprimir
            // 
            btnImprimir.Cursor = Cursors.Hand;
            btnImprimir.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnImprimir.Location = new Point(261, 112);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(86, 30);
            btnImprimir.TabIndex = 28;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // lblNombreProd
            // 
            lblNombreProd.AutoSize = true;
            lblNombreProd.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreProd.Location = new Point(6, 36);
            lblNombreProd.Name = "lblNombreProd";
            lblNombreProd.Size = new Size(127, 16);
            lblNombreProd.TabIndex = 27;
            lblNombreProd.Text = "Nombre del Producto";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(137, 119);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 26;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(89, 126);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(42, 16);
            lblPrecio.TabIndex = 25;
            lblPrecio.Text = "Precio";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidad.Location = new Point(74, 79);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(57, 16);
            lblCantidad.TabIndex = 24;
            lblCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(138, 72);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 22;
            txtCantidad.KeyPress += txtCantidad_KeyPress;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(138, 29);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(100, 23);
            txtNombreProducto.TabIndex = 21;
            // 
            // btnActualizar
            // 
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnActualizar.Location = new Point(261, 65);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(86, 30);
            btnActualizar.TabIndex = 19;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ActiveCaption;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(261, 22);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(86, 30);
            btnAgregar.TabIndex = 17;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(179, 112);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 30);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ActiveCaption;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.Location = new Point(52, 112);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(86, 30);
            btnBuscar.TabIndex = 18;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtImpresion
            // 
            txtImpresion.Cursor = Cursors.No;
            txtImpresion.Location = new Point(68, 315);
            txtImpresion.Multiline = true;
            txtImpresion.Name = "txtImpresion";
            txtImpresion.Size = new Size(642, 123);
            txtImpresion.TabIndex = 29;
            txtImpresion.KeyPress += txtImpresion_KeyPress;
            // 
            // lblImpresion
            // 
            lblImpresion.AutoSize = true;
            lblImpresion.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblImpresion.Location = new Point(104, 297);
            lblImpresion.Name = "lblImpresion";
            lblImpresion.Size = new Size(250, 16);
            lblImpresion.TabIndex = 30;
            lblImpresion.Text = "Impresion de los Producto en InOrder";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(txtBuscarProducto);
            groupBox1.Controls.Add(lblNomBuscar);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(432, 140);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(325, 153);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "Funciones";
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new Point(110, 68);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(100, 22);
            txtBuscarProducto.TabIndex = 29;
            // 
            // lblNomBuscar
            // 
            lblNomBuscar.AutoSize = true;
            lblNomBuscar.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomBuscar.Location = new Point(97, 36);
            lblNomBuscar.Name = "lblNomBuscar";
            lblNomBuscar.Size = new Size(127, 16);
            lblNomBuscar.TabIndex = 28;
            lblNomBuscar.Text = "Nombre del Producto";
            // 
            // Arbol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(lblImpresion);
            Controls.Add(txtImpresion);
            Controls.Add(grBoxProducto);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(816, 489);
            Name = "Arbol";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Árbol Binario";
            grBoxProducto.ResumeLayout(false);
            grBoxProducto.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox grBoxProducto;
        private Label lblNombreProd;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private Label lblCantidad;
        private TextBox txtCantidad;
        private TextBox txtNombreProducto;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnBuscar;
        private Button btnAgregar;
        private Button btnImprimir;
        private TextBox txtImpresion;
        private Label lblImpresion;
        private GroupBox groupBox1;
        private TextBox txtBuscarProducto;
        private Label lblNomBuscar;
    }
}