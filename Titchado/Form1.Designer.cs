namespace Titchado
{
    partial class Form1
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.pbOriginal = new System.Windows.Forms.PictureBox();
            this.pbCompressed = new System.Windows.Forms.PictureBox();
            this.btnCompress = new System.Windows.Forms.Button();
            this.btnSalvaImg = new System.Windows.Forms.Button();
            this.btnBonito = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gb3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCompressed)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gb3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(21, 312);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(301, 52);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Carregar imagem";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // pbOriginal
            // 
            this.pbOriginal.Location = new System.Drawing.Point(21, 17);
            this.pbOriginal.Name = "pbOriginal";
            this.pbOriginal.Size = new System.Drawing.Size(301, 264);
            this.pbOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOriginal.TabIndex = 1;
            this.pbOriginal.TabStop = false;
            // 
            // pbCompressed
            // 
            this.pbCompressed.Location = new System.Drawing.Point(19, 15);
            this.pbCompressed.Name = "pbCompressed";
            this.pbCompressed.Size = new System.Drawing.Size(301, 264);
            this.pbCompressed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCompressed.TabIndex = 3;
            this.pbCompressed.TabStop = false;
            // 
            // btnCompress
            // 
            this.btnCompress.Location = new System.Drawing.Point(29, 69);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(117, 52);
            this.btnCompress.TabIndex = 2;
            this.btnCompress.Text = "Comprimir imagem com perdas";
            this.btnCompress.UseVisualStyleBackColor = true;
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
            // 
            // btnSalvaImg
            // 
            this.btnSalvaImg.Location = new System.Drawing.Point(19, 310);
            this.btnSalvaImg.Name = "btnSalvaImg";
            this.btnSalvaImg.Size = new System.Drawing.Size(301, 52);
            this.btnSalvaImg.TabIndex = 4;
            this.btnSalvaImg.Text = "Salvar imagem";
            this.btnSalvaImg.UseVisualStyleBackColor = true;
            this.btnSalvaImg.Click += new System.EventHandler(this.btnSalvaImg_Click);
            // 
            // btnBonito
            // 
            this.btnBonito.Location = new System.Drawing.Point(29, 178);
            this.btnBonito.Name = "btnBonito";
            this.btnBonito.Size = new System.Drawing.Size(117, 52);
            this.btnBonito.TabIndex = 5;
            this.btnBonito.Text = "Comprimir imagem sem perdas";
            this.btnBonito.UseVisualStyleBackColor = true;
            this.btnBonito.Click += new System.EventHandler(this.btnBonito_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbOriginal);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 381);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imagem a ser comprimida";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSalvaImg);
            this.groupBox2.Controls.Add(this.pbCompressed);
            this.groupBox2.Location = new System.Drawing.Point(586, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 378);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Imagem comprimida";
            // 
            // gb3
            // 
            this.gb3.Controls.Add(this.btnBonito);
            this.gb3.Controls.Add(this.btnCompress);
            this.gb3.Location = new System.Drawing.Point(385, 35);
            this.gb3.Name = "gb3";
            this.gb3.Size = new System.Drawing.Size(177, 365);
            this.gb3.TabIndex = 8;
            this.gb3.TabStop = false;
            this.gb3.Text = "Operações";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 454);
            this.Controls.Add(this.gb3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Compressor de imagens";
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCompressed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.gb3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.PictureBox pbOriginal;
        private System.Windows.Forms.PictureBox pbCompressed;
        private System.Windows.Forms.Button btnCompress;
        private System.Windows.Forms.Button btnSalvaImg;
        private System.Windows.Forms.Button btnBonito;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gb3;
    }
}

