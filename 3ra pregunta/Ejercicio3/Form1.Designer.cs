namespace Ejercicio3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.lblR = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.picColor = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReconocer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PaletaL = new System.Windows.Forms.PictureBox();
            this.PaletaT = new System.Windows.Forms.PictureBox();
            this.PaletaV = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picModificado = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaletaL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaletaT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaletaV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picModificado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(633, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Segmentacion Lago Titicaca";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.Location = new System.Drawing.Point(388, 52);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(87, 40);
            this.btnAbrir.TabIndex = 3;
            this.btnAbrir.Text = "Seleccionar Imagen";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(895, 63);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(19, 13);
            this.lblR.TabIndex = 4;
            this.lblR.Text = "R:";
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(920, 60);
            this.txtR.Name = "txtR";
            this.txtR.ReadOnly = true;
            this.txtR.Size = new System.Drawing.Size(79, 20);
            this.txtR.TabIndex = 5;
            this.txtR.TextChanged += new System.EventHandler(this.txtR_TextChanged);
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(920, 86);
            this.txtG.Name = "txtG";
            this.txtG.ReadOnly = true;
            this.txtG.Size = new System.Drawing.Size(79, 20);
            this.txtG.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(895, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "G:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(895, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "B:";
            // 
            // picColor
            // 
            this.picColor.Location = new System.Drawing.Point(748, 68);
            this.picColor.Name = "picColor";
            this.picColor.Size = new System.Drawing.Size(70, 62);
            this.picColor.TabIndex = 10;
            this.picColor.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(747, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Color:";
            // 
            // btnReconocer
            // 
            this.btnReconocer.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReconocer.Location = new System.Drawing.Point(388, 116);
            this.btnReconocer.Name = "btnReconocer";
            this.btnReconocer.Size = new System.Drawing.Size(87, 23);
            this.btnReconocer.TabIndex = 12;
            this.btnReconocer.Text = "Reconocer";
            this.btnReconocer.UseVisualStyleBackColor = true;
            this.btnReconocer.Click += new System.EventHandler(this.btnReconocer_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.PaletaL);
            this.panel1.Controls.Add(this.PaletaT);
            this.panel1.Controls.Add(this.PaletaV);
            this.panel1.Location = new System.Drawing.Point(30, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1218, 97);
            this.panel1.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(183, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tierra";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(583, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Lago";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(988, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Valles";
            // 
            // PaletaL
            // 
            this.PaletaL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PaletaL.Cursor = System.Windows.Forms.Cursors.Default;
            this.PaletaL.Location = new System.Drawing.Point(458, 24);
            this.PaletaL.Name = "PaletaL";
            this.PaletaL.Size = new System.Drawing.Size(290, 55);
            this.PaletaL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PaletaL.TabIndex = 18;
            this.PaletaL.TabStop = false;
            this.PaletaL.Click += new System.EventHandler(this.picPaletaL_Click);
            this.PaletaL.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picPaletaL_MouseClick);
            // 
            // PaletaT
            // 
            this.PaletaT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PaletaT.Cursor = System.Windows.Forms.Cursors.Default;
            this.PaletaT.Location = new System.Drawing.Point(65, 24);
            this.PaletaT.Name = "PaletaT";
            this.PaletaT.Size = new System.Drawing.Size(290, 55);
            this.PaletaT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PaletaT.TabIndex = 17;
            this.PaletaT.TabStop = false;
            this.PaletaT.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picPaletaT_MouseClick);
            // 
            // PaletaV
            // 
            this.PaletaV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PaletaV.Cursor = System.Windows.Forms.Cursors.Default;
            this.PaletaV.Location = new System.Drawing.Point(868, 24);
            this.PaletaV.Name = "PaletaV";
            this.PaletaV.Size = new System.Drawing.Size(290, 55);
            this.PaletaV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PaletaV.TabIndex = 16;
            this.PaletaV.TabStop = false;
            this.PaletaV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picPaletaV_MouseClick);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Location = new System.Drawing.Point(30, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 561);
            this.panel2.TabIndex = 19;
            // 
            // picImagen
            // 
            this.picImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picImagen.Location = new System.Drawing.Point(38, 265);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(696, 554);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picImagen.TabIndex = 1;
            this.picImagen.TabStop = false;
            this.picImagen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picImagen_MouseClick_1);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.picModificado);
            this.panel3.Location = new System.Drawing.Point(769, 265);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(640, 561);
            this.panel3.TabIndex = 20;
            // 
            // picModificado
            // 
            this.picModificado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picModificado.Location = new System.Drawing.Point(0, 0);
            this.picModificado.Name = "picModificado";
            this.picModificado.Size = new System.Drawing.Size(634, 554);
            this.picModificado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picModificado.TabIndex = 1;
            this.picModificado.TabStop = false;
            this.picModificado.Click += new System.EventHandler(this.picModificado_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(600, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(63, 20);
            this.textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(600, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(63, 20);
            this.textBox2.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(574, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Y:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(575, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "X:";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(920, 115);
            this.txtB.Name = "txtB";
            this.txtB.ReadOnly = true;
            this.txtB.Size = new System.Drawing.Size(79, 20);
            this.txtB.TabIndex = 9;
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 831);
            this.Controls.Add(this.picImagen);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReconocer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaletaL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaletaT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaletaV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picModificado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox picColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReconocer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PaletaV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picImagen;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picModificado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox PaletaL;
        private System.Windows.Forms.PictureBox PaletaT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtB;
    }
}

