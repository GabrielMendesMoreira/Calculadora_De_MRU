namespace TP03_181828
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Sair = new System.Windows.Forms.Button();
            this.LIMPAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calcular = new System.Windows.Forms.Button();
            this.espacoinicial = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tempo = new System.Windows.Forms.TextBox();
            this.aceleracao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.velocidadeinicial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.deslocamento = new System.Windows.Forms.TextBox();
            this.velocidade = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sair
            // 
            this.Sair.BackColor = System.Drawing.Color.White;
            this.Sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sair.BackgroundImage")));
            this.Sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sair.Location = new System.Drawing.Point(408, 379);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(104, 109);
            this.Sair.TabIndex = 2;
            this.Sair.UseVisualStyleBackColor = false;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // LIMPAR
            // 
            this.LIMPAR.BackColor = System.Drawing.Color.White;
            this.LIMPAR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LIMPAR.BackgroundImage")));
            this.LIMPAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LIMPAR.Location = new System.Drawing.Point(239, 379);
            this.LIMPAR.Name = "LIMPAR";
            this.LIMPAR.Size = new System.Drawing.Size(104, 109);
            this.LIMPAR.TabIndex = 1;
            this.LIMPAR.UseVisualStyleBackColor = false;
            this.LIMPAR.Click += new System.EventHandler(this.LIMPAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Espaço inicial (m) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(350, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(13, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Velocidade inicial (m/s} :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // calcular
            // 
            this.calcular.BackColor = System.Drawing.Color.White;
            this.calcular.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("calcular.BackgroundImage")));
            this.calcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.calcular.Location = new System.Drawing.Point(72, 379);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(104, 109);
            this.calcular.TabIndex = 0;
            this.calcular.UseVisualStyleBackColor = false;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // espacoinicial
            // 
            this.espacoinicial.Location = new System.Drawing.Point(332, 12);
            this.espacoinicial.Name = "espacoinicial";
            this.espacoinicial.Size = new System.Drawing.Size(107, 20);
            this.espacoinicial.TabIndex = 1;
            this.espacoinicial.TextChanged += new System.EventHandler(this.espacoinicial_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tempo);
            this.panel1.Controls.Add(this.aceleracao);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.velocidadeinicial);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.espacoinicial);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(71, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 170);
            this.panel1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(13, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tempo percorrido (s):";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tempo
            // 
            this.tempo.Location = new System.Drawing.Point(332, 127);
            this.tempo.Name = "tempo";
            this.tempo.Size = new System.Drawing.Size(107, 20);
            this.tempo.TabIndex = 4;
            // 
            // aceleracao
            // 
            this.aceleracao.Location = new System.Drawing.Point(332, 90);
            this.aceleracao.Name = "aceleracao";
            this.aceleracao.Size = new System.Drawing.Size(107, 20);
            this.aceleracao.TabIndex = 3;
            this.aceleracao.TextChanged += new System.EventHandler(this.aceleracao_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(13, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Aceleração (m/s²):";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // velocidadeinicial
            // 
            this.velocidadeinicial.Location = new System.Drawing.Point(332, 51);
            this.velocidadeinicial.Name = "velocidadeinicial";
            this.velocidadeinicial.Size = new System.Drawing.Size(107, 20);
            this.velocidadeinicial.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Swis721 Blk BT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(68, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(382, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "CALCULAR MOVIMENTO RETILÍNIO UNIFORME";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(201, 524);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "HORA";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(80, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 22);
            this.label8.TabIndex = 10;
            this.label8.Text = "Deslocamento(m) =";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(67, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 29);
            this.label9.TabIndex = 11;
            this.label9.Text = "RESPOSTAS:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(80, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 22);
            this.label10.TabIndex = 12;
            this.label10.Text = "Velocidade(m/s) =";
            // 
            // deslocamento
            // 
            this.deslocamento.Cursor = System.Windows.Forms.Cursors.No;
            this.deslocamento.Enabled = false;
            this.deslocamento.Location = new System.Drawing.Point(289, 282);
            this.deslocamento.Name = "deslocamento";
            this.deslocamento.Size = new System.Drawing.Size(100, 20);
            this.deslocamento.TabIndex = 13;
            this.deslocamento.TextChanged += new System.EventHandler(this.deslocamento_TextChanged);
            // 
            // velocidade
            // 
            this.velocidade.Cursor = System.Windows.Forms.Cursors.No;
            this.velocidade.Enabled = false;
            this.velocidade.Location = new System.Drawing.Point(289, 321);
            this.velocidade.Name = "velocidade";
            this.velocidade.Size = new System.Drawing.Size(100, 20);
            this.velocidade.TabIndex = 14;
            this.velocidade.TextChanged += new System.EventHandler(this.velocidade_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(552, 555);
            this.Controls.Add(this.velocidade);
            this.Controls.Add(this.deslocamento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.LIMPAR);
            this.Controls.Add(this.calcular);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora de Movimento Retilínio Uniforme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LIMPAR;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.TextBox espacoinicial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox velocidadeinicial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tempo;
        private System.Windows.Forms.TextBox aceleracao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox deslocamento;
        private System.Windows.Forms.TextBox velocidade;
    }
}

