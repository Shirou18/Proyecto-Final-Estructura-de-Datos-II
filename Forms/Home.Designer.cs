namespace ProyectoEstructura
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnArbol = new Button();
            btnGrafo = new Button();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 22);
            label1.Name = "label1";
            label1.Size = new Size(394, 23);
            label1.TabIndex = 0;
            label1.Text = "Proyecto Final de Estructura de Datos II";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(49, 62);
            label2.Name = "label2";
            label2.Size = new Size(300, 16);
            label2.TabIndex = 1;
            label2.Text = "Estudiante: David Francisco Rodríguez Gálvez";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(439, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(265, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 98);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(400, 269);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // btnArbol
            // 
            btnArbol.Cursor = Cursors.Hand;
            btnArbol.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            btnArbol.Location = new Point(482, 220);
            btnArbol.Name = "btnArbol";
            btnArbol.Size = new Size(126, 47);
            btnArbol.TabIndex = 4;
            btnArbol.Text = "Árbol Binario";
            btnArbol.UseVisualStyleBackColor = true;
            btnArbol.Click += btnArbol_Click;
            // 
            // btnGrafo
            // 
            btnGrafo.Cursor = Cursors.Hand;
            btnGrafo.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            btnGrafo.Location = new Point(482, 310);
            btnGrafo.Name = "btnGrafo";
            btnGrafo.Size = new Size(126, 47);
            btnGrafo.TabIndex = 5;
            btnGrafo.Text = "Gráfo de Lista";
            btnGrafo.UseVisualStyleBackColor = true;
            btnGrafo.Click += btnGrafo_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(633, 202);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(115, 74);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(633, 293);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(115, 74);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(780, 416);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(btnGrafo);
            Controls.Add(btnArbol);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(796, 455);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnArbol;
        private Button btnGrafo;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}