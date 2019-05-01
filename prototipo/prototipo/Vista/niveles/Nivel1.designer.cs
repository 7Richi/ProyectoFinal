namespace Prototip.Vista.Niveles
{
    partial class Nivel1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nivel1));
            this.Tabla = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.Label();
            this.p3 = new System.Windows.Forms.Label();
            this.p4 = new System.Windows.Forms.Label();
            this.p5 = new System.Windows.Forms.Label();
            this.p6 = new System.Windows.Forms.Label();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.SigNivel = new System.Windows.Forms.Button();
            this.Tiempo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.pic6 = new System.Windows.Forms.PictureBox();
            this.pic7 = new System.Windows.Forms.PictureBox();
            this.pic8 = new System.Windows.Forms.PictureBox();
            this.pic9 = new System.Windows.Forms.PictureBox();
            this.pic10 = new System.Windows.Forms.PictureBox();
            this.p7 = new System.Windows.Forms.Label();
            this.p8 = new System.Windows.Forms.Label();
            this.p9 = new System.Windows.Forms.Label();
            this.p10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabla
            // 
            this.Tabla.AllowUserToAddRows = false;
            this.Tabla.AllowUserToDeleteRows = false;
            this.Tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla.ColumnHeadersVisible = false;
            this.Tabla.EnableHeadersVisualStyles = false;
            this.Tabla.Location = new System.Drawing.Point(197, 142);
            this.Tabla.Margin = new System.Windows.Forms.Padding(0);
            this.Tabla.MultiSelect = false;
            this.Tabla.Name = "Tabla";
            this.Tabla.RowHeadersVisible = false;
            this.Tabla.RowHeadersWidth = 20;
            this.Tabla.Size = new System.Drawing.Size(633, 243);
            this.Tabla.TabIndex = 0;
            this.Tabla.Click += new System.EventHandler(this.Color_click);
            this.Tabla.DoubleClick += new System.EventHandler(this.RegresarColor_Doclick);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.SystemColors.Info;
            this.Titulo.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.DarkRed;
            this.Titulo.Location = new System.Drawing.Point(864, 35);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(309, 24);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "ENCUENTRA LAS PALABRAS";
            // 
            // p1
            // 
            this.p1.AutoSize = true;
            this.p1.BackColor = System.Drawing.Color.Transparent;
            this.p1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.p1.Location = new System.Drawing.Point(1015, 66);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(95, 22);
            this.p1.TabIndex = 2;
            this.p1.Text = "ENTIDAD";
            // 
            // p2
            // 
            this.p2.AutoSize = true;
            this.p2.BackColor = System.Drawing.Color.Transparent;
            this.p2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.p2.Location = new System.Drawing.Point(1015, 113);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(108, 22);
            this.p2.TabIndex = 2;
            this.p2.Text = "ATRIBUTO";
            // 
            // p3
            // 
            this.p3.AutoSize = true;
            this.p3.BackColor = System.Drawing.Color.Transparent;
            this.p3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.p3.Location = new System.Drawing.Point(1015, 391);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(77, 22);
            this.p3.TabIndex = 2;
            this.p3.Text = "ACCES";
            // 
            // p4
            // 
            this.p4.AutoSize = true;
            this.p4.BackColor = System.Drawing.Color.Transparent;
            this.p4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p4.ForeColor = System.Drawing.Color.White;
            this.p4.Location = new System.Drawing.Point(1011, 152);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(72, 22);
            this.p4.TabIndex = 2;
            this.p4.Text = "LLAVE";
            // 
            // p5
            // 
            this.p5.AutoSize = true;
            this.p5.BackColor = System.Drawing.Color.Transparent;
            this.p5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.p5.Location = new System.Drawing.Point(1014, 191);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(102, 22);
            this.p5.TabIndex = 2;
            this.p5.Text = "PRIMARIA";
            // 
            // p6
            // 
            this.p6.AutoSize = true;
            this.p6.BackColor = System.Drawing.Color.Transparent;
            this.p6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.p6.Location = new System.Drawing.Point(1014, 227);
            this.p6.Name = "p6";
            this.p6.Size = new System.Drawing.Size(102, 22);
            this.p6.TabIndex = 2;
            this.p6.Text = "FORANEA";
            // 
            // pic1
            // 
            this.pic1.BackColor = System.Drawing.Color.Transparent;
            this.pic1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic1.BackgroundImage")));
            this.pic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic1.Location = new System.Drawing.Point(934, 62);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(74, 42);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1.TabIndex = 3;
            this.pic1.TabStop = false;
            // 
            // SigNivel
            // 
            this.SigNivel.BackColor = System.Drawing.Color.Red;
            this.SigNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SigNivel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SigNivel.Location = new System.Drawing.Point(441, 532);
            this.SigNivel.Name = "SigNivel";
            this.SigNivel.Size = new System.Drawing.Size(306, 52);
            this.SigNivel.TabIndex = 4;
            this.SigNivel.Text = "SIGUIENTE NIVEL";
            this.SigNivel.UseVisualStyleBackColor = false;
            this.SigNivel.Click += new System.EventHandler(this.SigNivel_Click);
            // 
            // Tiempo
            // 
            this.Tiempo.BackColor = System.Drawing.Color.Transparent;
            this.Tiempo.Enabled = false;
            this.Tiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tiempo.ForeColor = System.Drawing.Color.Yellow;
            this.Tiempo.Location = new System.Drawing.Point(328, 19);
            this.Tiempo.Name = "Tiempo";
            this.Tiempo.Size = new System.Drawing.Size(246, 69);
            this.Tiempo.TabIndex = 5;
            this.Tiempo.Text = "---:---";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(190, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 69);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tiempo:";
            // 
            // pic2
            // 
            this.pic2.BackColor = System.Drawing.Color.Transparent;
            this.pic2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic2.BackgroundImage")));
            this.pic2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic2.Location = new System.Drawing.Point(934, 104);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(74, 42);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic2.TabIndex = 7;
            this.pic2.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.BackColor = System.Drawing.Color.Transparent;
            this.pic3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic3.BackgroundImage")));
            this.pic3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic3.Location = new System.Drawing.Point(934, 142);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(74, 42);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic3.TabIndex = 8;
            this.pic3.TabStop = false;
            // 
            // pic4
            // 
            this.pic4.BackColor = System.Drawing.Color.Transparent;
            this.pic4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic4.BackgroundImage")));
            this.pic4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic4.Location = new System.Drawing.Point(934, 180);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(74, 42);
            this.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic4.TabIndex = 9;
            this.pic4.TabStop = false;
            // 
            // pic5
            // 
            this.pic5.BackColor = System.Drawing.Color.Transparent;
            this.pic5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic5.BackgroundImage")));
            this.pic5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic5.Location = new System.Drawing.Point(934, 218);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(74, 42);
            this.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic5.TabIndex = 10;
            this.pic5.TabStop = false;
            // 
            // pic6
            // 
            this.pic6.BackColor = System.Drawing.Color.Transparent;
            this.pic6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic6.BackgroundImage")));
            this.pic6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic6.Location = new System.Drawing.Point(934, 266);
            this.pic6.Name = "pic6";
            this.pic6.Size = new System.Drawing.Size(74, 42);
            this.pic6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic6.TabIndex = 11;
            this.pic6.TabStop = false;
            // 
            // pic7
            // 
            this.pic7.BackColor = System.Drawing.Color.Transparent;
            this.pic7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic7.BackgroundImage")));
            this.pic7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic7.Location = new System.Drawing.Point(934, 305);
            this.pic7.Name = "pic7";
            this.pic7.Size = new System.Drawing.Size(74, 42);
            this.pic7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic7.TabIndex = 12;
            this.pic7.TabStop = false;
            // 
            // pic8
            // 
            this.pic8.BackColor = System.Drawing.Color.Transparent;
            this.pic8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic8.BackgroundImage")));
            this.pic8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic8.Location = new System.Drawing.Point(934, 344);
            this.pic8.Name = "pic8";
            this.pic8.Size = new System.Drawing.Size(74, 42);
            this.pic8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic8.TabIndex = 13;
            this.pic8.TabStop = false;
            // 
            // pic9
            // 
            this.pic9.BackColor = System.Drawing.Color.Transparent;
            this.pic9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic9.BackgroundImage")));
            this.pic9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic9.Location = new System.Drawing.Point(934, 381);
            this.pic9.Name = "pic9";
            this.pic9.Size = new System.Drawing.Size(74, 42);
            this.pic9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic9.TabIndex = 14;
            this.pic9.TabStop = false;
            // 
            // pic10
            // 
            this.pic10.BackColor = System.Drawing.Color.Transparent;
            this.pic10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic10.BackgroundImage")));
            this.pic10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic10.Location = new System.Drawing.Point(934, 425);
            this.pic10.Name = "pic10";
            this.pic10.Size = new System.Drawing.Size(74, 42);
            this.pic10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic10.TabIndex = 15;
            this.pic10.TabStop = false;
            // 
            // p7
            // 
            this.p7.AutoSize = true;
            this.p7.BackColor = System.Drawing.Color.Transparent;
            this.p7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.p7.Location = new System.Drawing.Point(1015, 276);
            this.p7.Name = "p7";
            this.p7.Size = new System.Drawing.Size(108, 22);
            this.p7.TabIndex = 16;
            this.p7.Text = "RELACION";
            // 
            // p8
            // 
            this.p8.AutoSize = true;
            this.p8.BackColor = System.Drawing.Color.Transparent;
            this.p8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.p8.Location = new System.Drawing.Point(1015, 315);
            this.p8.Name = "p8";
            this.p8.Size = new System.Drawing.Size(50, 22);
            this.p8.TabIndex = 17;
            this.p8.Text = "SQL";
            // 
            // p9
            // 
            this.p9.AutoSize = true;
            this.p9.BackColor = System.Drawing.Color.Transparent;
            this.p9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.p9.Location = new System.Drawing.Point(1015, 353);
            this.p9.Name = "p9";
            this.p9.Size = new System.Drawing.Size(81, 22);
            this.p9.TabIndex = 18;
            this.p9.Text = "SCRIPT";
            // 
            // p10
            // 
            this.p10.AutoSize = true;
            this.p10.BackColor = System.Drawing.Color.Transparent;
            this.p10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.p10.Location = new System.Drawing.Point(1014, 435);
            this.p10.Name = "p10";
            this.p10.Size = new System.Drawing.Size(74, 22);
            this.p10.TabIndex = 19;
            this.p10.Text = "TABLA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Harlow Solid Italic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(603, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 34);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nivel 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(580, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "\"Base de datos\"";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1069, 549);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(934, 530);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Nivel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1214, 643);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.p10);
            this.Controls.Add(this.p9);
            this.Controls.Add(this.p8);
            this.Controls.Add(this.p7);
            this.Controls.Add(this.pic10);
            this.Controls.Add(this.pic9);
            this.Controls.Add(this.pic8);
            this.Controls.Add(this.pic7);
            this.Controls.Add(this.pic6);
            this.Controls.Add(this.pic5);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tiempo);
            this.Controls.Add(this.SigNivel);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.p6);
            this.Controls.Add(this.p5);
            this.Controls.Add(this.p4);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.Tabla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1230, 682);
            this.Name = "Nivel1";
            this.Text = "Nivel1";
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Tabla;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label p1;
        private System.Windows.Forms.Label p2;
        private System.Windows.Forms.Label p3;
        private System.Windows.Forms.Label p4;
        private System.Windows.Forms.Label p5;
        private System.Windows.Forms.Label p6;
        private System.Windows.Forms.Button SigNivel;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Label Tiempo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.PictureBox pic6;
        private System.Windows.Forms.PictureBox pic7;
        private System.Windows.Forms.PictureBox pic8;
        private System.Windows.Forms.PictureBox pic9;
        private System.Windows.Forms.PictureBox pic10;
        private System.Windows.Forms.Label p7;
        private System.Windows.Forms.Label p8;
        private System.Windows.Forms.Label p9;
        private System.Windows.Forms.Label p10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}