
namespace IMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblpeso = new System.Windows.Forms.Label();
            this.lblaltura = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.cmdIMC = new System.Windows.Forms.Button();
            this.txtd1 = new System.Windows.Forms.TextBox();
            this.txtd2 = new System.Windows.Forms.TextBox();
            this.pbimg1 = new System.Windows.Forms.PictureBox();
            this.pbimg2 = new System.Windows.Forms.PictureBox();
            this.pbimg3 = new System.Windows.Forms.PictureBox();
            this.pbimg4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbimg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimg3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimg4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblpeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpeso.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblpeso.Location = new System.Drawing.Point(54, 44);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(57, 24);
            this.lblpeso.TabIndex = 0;
            this.lblpeso.Text = "Peso";
            this.lblpeso.Click += new System.EventHandler(this.lblpeso_Click);
            this.lblpeso.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblpeso_MouseMove);
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblaltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaltura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblaltura.Location = new System.Drawing.Point(54, 91);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(64, 24);
            this.lblaltura.TabIndex = 1;
            this.lblaltura.Text = "Altura";
            this.lblaltura.Click += new System.EventHandler(this.lblaltura_Click);
            this.lblaltura.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblaltura_MouseMove);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblResultado.Location = new System.Drawing.Point(145, 141);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(103, 24);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // cmdIMC
            // 
            this.cmdIMC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdIMC.Font = new System.Drawing.Font("AR DELANEY", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIMC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdIMC.Location = new System.Drawing.Point(159, 191);
            this.cmdIMC.Name = "cmdIMC";
            this.cmdIMC.Size = new System.Drawing.Size(75, 35);
            this.cmdIMC.TabIndex = 5;
            this.cmdIMC.Text = "IMC";
            this.cmdIMC.UseVisualStyleBackColor = false;
            this.cmdIMC.Click += new System.EventHandler(this.cmdIMC_Click);
            // 
            // txtd1
            // 
            this.txtd1.Location = new System.Drawing.Point(148, 44);
            this.txtd1.Name = "txtd1";
            this.txtd1.Size = new System.Drawing.Size(100, 20);
            this.txtd1.TabIndex = 6;
            // 
            // txtd2
            // 
            this.txtd2.Location = new System.Drawing.Point(148, 91);
            this.txtd2.Name = "txtd2";
            this.txtd2.Size = new System.Drawing.Size(100, 20);
            this.txtd2.TabIndex = 7;
            // 
            // pbimg1
            // 
            this.pbimg1.Image = ((System.Drawing.Image)(resources.GetObject("pbimg1.Image")));
            this.pbimg1.Location = new System.Drawing.Point(336, 22);
            this.pbimg1.Name = "pbimg1";
            this.pbimg1.Size = new System.Drawing.Size(123, 237);
            this.pbimg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbimg1.TabIndex = 8;
            this.pbimg1.TabStop = false;
            this.pbimg1.Visible = false;
            this.pbimg1.Click += new System.EventHandler(this.pbimg1_Click);
            // 
            // pbimg2
            // 
            this.pbimg2.Image = ((System.Drawing.Image)(resources.GetObject("pbimg2.Image")));
            this.pbimg2.Location = new System.Drawing.Point(336, 22);
            this.pbimg2.Name = "pbimg2";
            this.pbimg2.Size = new System.Drawing.Size(123, 237);
            this.pbimg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbimg2.TabIndex = 9;
            this.pbimg2.TabStop = false;
            this.pbimg2.Visible = false;
            this.pbimg2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbimg3
            // 
            this.pbimg3.Image = ((System.Drawing.Image)(resources.GetObject("pbimg3.Image")));
            this.pbimg3.Location = new System.Drawing.Point(336, 22);
            this.pbimg3.Name = "pbimg3";
            this.pbimg3.Size = new System.Drawing.Size(123, 237);
            this.pbimg3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbimg3.TabIndex = 10;
            this.pbimg3.TabStop = false;
            this.pbimg3.Visible = false;
            // 
            // pbimg4
            // 
            this.pbimg4.Image = ((System.Drawing.Image)(resources.GetObject("pbimg4.Image")));
            this.pbimg4.Location = new System.Drawing.Point(336, 22);
            this.pbimg4.Name = "pbimg4";
            this.pbimg4.Size = new System.Drawing.Size(125, 237);
            this.pbimg4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbimg4.TabIndex = 11;
            this.pbimg4.TabStop = false;
            this.pbimg4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(539, 322);
            this.Controls.Add(this.pbimg4);
            this.Controls.Add(this.pbimg3);
            this.Controls.Add(this.pbimg2);
            this.Controls.Add(this.pbimg1);
            this.Controls.Add(this.txtd2);
            this.Controls.Add(this.txtd1);
            this.Controls.Add(this.cmdIMC);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.lblpeso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbimg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimg3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimg4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpeso;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button cmdIMC;
        private System.Windows.Forms.TextBox txtd1;
        private System.Windows.Forms.TextBox txtd2;
        private System.Windows.Forms.PictureBox pbimg1;
        private System.Windows.Forms.PictureBox pbimg2;
        private System.Windows.Forms.PictureBox pbimg3;
        private System.Windows.Forms.PictureBox pbimg4;
    }
}

