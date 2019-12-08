namespace JogoDaVelha
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_00 = new System.Windows.Forms.Button();
            this.btn_01 = new System.Windows.Forms.Button();
            this.btn_02 = new System.Windows.Forms.Button();
            this.btn_12 = new System.Windows.Forms.Button();
            this.btn_11 = new System.Windows.Forms.Button();
            this.btn_10 = new System.Windows.Forms.Button();
            this.btn_22 = new System.Windows.Forms.Button();
            this.btn_21 = new System.Windows.Forms.Button();
            this.btn_20 = new System.Windows.Forms.Button();
            this.btn_iniciarJogo = new System.Windows.Forms.Button();
            this.lbl_Turno = new System.Windows.Forms.Label();
            this.lbl_Vencedor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_00
            // 
            this.btn_00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_00.Location = new System.Drawing.Point(17, 102);
            this.btn_00.Name = "btn_00";
            this.btn_00.Size = new System.Drawing.Size(75, 71);
            this.btn_00.TabIndex = 0;
            this.btn_00.UseVisualStyleBackColor = true;
            this.btn_00.Click += new System.EventHandler(this.evento_Click);
            // 
            // btn_01
            // 
            this.btn_01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_01.Location = new System.Drawing.Point(98, 102);
            this.btn_01.Name = "btn_01";
            this.btn_01.Size = new System.Drawing.Size(75, 71);
            this.btn_01.TabIndex = 1;
            this.btn_01.UseVisualStyleBackColor = true;
            this.btn_01.Click += new System.EventHandler(this.evento_Click);
            // 
            // btn_02
            // 
            this.btn_02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_02.Location = new System.Drawing.Point(179, 102);
            this.btn_02.Name = "btn_02";
            this.btn_02.Size = new System.Drawing.Size(75, 71);
            this.btn_02.TabIndex = 2;
            this.btn_02.UseVisualStyleBackColor = true;
            this.btn_02.Click += new System.EventHandler(this.evento_Click);
            // 
            // btn_12
            // 
            this.btn_12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_12.Location = new System.Drawing.Point(179, 179);
            this.btn_12.Name = "btn_12";
            this.btn_12.Size = new System.Drawing.Size(75, 71);
            this.btn_12.TabIndex = 5;
            this.btn_12.UseVisualStyleBackColor = true;
            this.btn_12.Click += new System.EventHandler(this.evento_Click);
            // 
            // btn_11
            // 
            this.btn_11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_11.Location = new System.Drawing.Point(98, 179);
            this.btn_11.Name = "btn_11";
            this.btn_11.Size = new System.Drawing.Size(75, 71);
            this.btn_11.TabIndex = 4;
            this.btn_11.UseVisualStyleBackColor = true;
            this.btn_11.Click += new System.EventHandler(this.evento_Click);
            // 
            // btn_10
            // 
            this.btn_10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_10.Location = new System.Drawing.Point(17, 179);
            this.btn_10.Name = "btn_10";
            this.btn_10.Size = new System.Drawing.Size(75, 71);
            this.btn_10.TabIndex = 3;
            this.btn_10.UseVisualStyleBackColor = true;
            this.btn_10.Click += new System.EventHandler(this.evento_Click);
            // 
            // btn_22
            // 
            this.btn_22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_22.Location = new System.Drawing.Point(179, 256);
            this.btn_22.Name = "btn_22";
            this.btn_22.Size = new System.Drawing.Size(75, 71);
            this.btn_22.TabIndex = 8;
            this.btn_22.UseVisualStyleBackColor = true;
            this.btn_22.Click += new System.EventHandler(this.evento_Click);
            // 
            // btn_21
            // 
            this.btn_21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_21.Location = new System.Drawing.Point(98, 256);
            this.btn_21.Name = "btn_21";
            this.btn_21.Size = new System.Drawing.Size(75, 71);
            this.btn_21.TabIndex = 7;
            this.btn_21.UseVisualStyleBackColor = true;
            this.btn_21.Click += new System.EventHandler(this.evento_Click);
            // 
            // btn_20
            // 
            this.btn_20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_20.Location = new System.Drawing.Point(17, 256);
            this.btn_20.Name = "btn_20";
            this.btn_20.Size = new System.Drawing.Size(75, 71);
            this.btn_20.TabIndex = 6;
            this.btn_20.UseVisualStyleBackColor = true;
            this.btn_20.Click += new System.EventHandler(this.evento_Click);
            // 
            // btn_iniciarJogo
            // 
            this.btn_iniciarJogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iniciarJogo.Location = new System.Drawing.Point(17, 12);
            this.btn_iniciarJogo.Name = "btn_iniciarJogo";
            this.btn_iniciarJogo.Size = new System.Drawing.Size(75, 71);
            this.btn_iniciarJogo.TabIndex = 9;
            this.btn_iniciarJogo.Text = "iniciar jogo";
            this.btn_iniciarJogo.UseVisualStyleBackColor = true;
            this.btn_iniciarJogo.Click += new System.EventHandler(this.btn_iniciarJogo_Click);
            // 
            // lbl_Turno
            // 
            this.lbl_Turno.AutoSize = true;
            this.lbl_Turno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Turno.Location = new System.Drawing.Point(98, 12);
            this.lbl_Turno.Name = "lbl_Turno";
            this.lbl_Turno.Size = new System.Drawing.Size(0, 24);
            this.lbl_Turno.TabIndex = 10;
            // 
            // lbl_Vencedor
            // 
            this.lbl_Vencedor.AutoSize = true;
            this.lbl_Vencedor.Location = new System.Drawing.Point(98, 69);
            this.lbl_Vencedor.Name = "lbl_Vencedor";
            this.lbl_Vencedor.Size = new System.Drawing.Size(35, 13);
            this.lbl_Vencedor.TabIndex = 11;
            this.lbl_Vencedor.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 352);
            this.Controls.Add(this.lbl_Vencedor);
            this.Controls.Add(this.lbl_Turno);
            this.Controls.Add(this.btn_iniciarJogo);
            this.Controls.Add(this.btn_22);
            this.Controls.Add(this.btn_21);
            this.Controls.Add(this.btn_20);
            this.Controls.Add(this.btn_12);
            this.Controls.Add(this.btn_11);
            this.Controls.Add(this.btn_10);
            this.Controls.Add(this.btn_02);
            this.Controls.Add(this.btn_01);
            this.Controls.Add(this.btn_00);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_00;
        private System.Windows.Forms.Button btn_01;
        private System.Windows.Forms.Button btn_02;
        private System.Windows.Forms.Button btn_12;
        private System.Windows.Forms.Button btn_11;
        private System.Windows.Forms.Button btn_10;
        private System.Windows.Forms.Button btn_22;
        private System.Windows.Forms.Button btn_21;
        private System.Windows.Forms.Button btn_20;
        private System.Windows.Forms.Button btn_iniciarJogo;
        private System.Windows.Forms.Label lbl_Turno;
        private System.Windows.Forms.Label lbl_Vencedor;
    }
}

