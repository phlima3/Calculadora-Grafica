namespace prjCalculadoraGraficaTB
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
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbCalculos = new System.Windows.Forms.GroupBox();
            this.rbVolume = new System.Windows.Forms.RadioButton();
            this.rbPerimetro = new System.Windows.Forms.RadioButton();
            this.rbArea = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.pnDesenho = new System.Windows.Forms.Panel();
            this.opDesenhar = new System.Windows.Forms.CheckBox();
            this.gbCalculos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCalculos
            // 
            this.gbCalculos.Controls.Add(this.rbVolume);
            this.gbCalculos.Controls.Add(this.rbPerimetro);
            this.gbCalculos.Controls.Add(this.rbArea);
            this.gbCalculos.Location = new System.Drawing.Point(12, 1);
            this.gbCalculos.Name = "gbCalculos";
            this.gbCalculos.Size = new System.Drawing.Size(246, 217);
            this.gbCalculos.TabIndex = 0;
            this.gbCalculos.TabStop = false;
            // 
            // rbVolume
            // 
            this.rbVolume.AutoSize = true;
            this.rbVolume.Location = new System.Drawing.Point(6, 147);
            this.rbVolume.Name = "rbVolume";
            this.rbVolume.Size = new System.Drawing.Size(202, 39);
            this.rbVolume.TabIndex = 2;
            this.rbVolume.Text = "Calculo Volume";
            this.rbVolume.UseVisualStyleBackColor = true;
            // 
            // rbPerimetro
            // 
            this.rbPerimetro.AutoSize = true;
            this.rbPerimetro.Location = new System.Drawing.Point(6, 90);
            this.rbPerimetro.Name = "rbPerimetro";
            this.rbPerimetro.Size = new System.Drawing.Size(235, 39);
            this.rbPerimetro.TabIndex = 1;
            this.rbPerimetro.Text = "Calculo Perímetro";
            this.rbPerimetro.UseVisualStyleBackColor = true;
            // 
            // rbArea
            // 
            this.rbArea.AutoSize = true;
            this.rbArea.Checked = true;
            this.rbArea.Location = new System.Drawing.Point(6, 31);
            this.rbArea.Name = "rbArea";
            this.rbArea.Size = new System.Drawing.Size(178, 39);
            this.rbArea.TabIndex = 0;
            this.rbArea.TabStop = true;
            this.rbArea.Text = "Calculo Área";
            this.rbArea.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o raio:";
            // 
            // txtRaio
            // 
            this.txtRaio.Location = new System.Drawing.Point(341, 73);
            this.txtRaio.MaxLength = 10;
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(157, 41);
            this.txtRaio.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(362, 120);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(116, 40);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.BackColor = System.Drawing.Color.Teal;
            this.lbResultado.ForeColor = System.Drawing.Color.White;
            this.lbResultado.Location = new System.Drawing.Point(12, 230);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(588, 79);
            this.lbResultado.TabIndex = 4;
            this.lbResultado.Text = "RESULTADO = 0";
            this.lbResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnDesenho
            // 
            this.pnDesenho.BackColor = System.Drawing.Color.Teal;
            this.pnDesenho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDesenho.Location = new System.Drawing.Point(606, 12);
            this.pnDesenho.Name = "pnDesenho";
            this.pnDesenho.Size = new System.Drawing.Size(274, 276);
            this.pnDesenho.TabIndex = 5;
            // 
            // opDesenhar
            // 
            this.opDesenhar.AutoSize = true;
            this.opDesenhar.Checked = true;
            this.opDesenhar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.opDesenhar.Location = new System.Drawing.Point(341, 179);
            this.opDesenhar.Name = "opDesenhar";
            this.opDesenhar.Size = new System.Drawing.Size(229, 39);
            this.opDesenhar.TabIndex = 6;
            this.opDesenhar.Text = "Desenhar Circulo";
            this.opDesenhar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(888, 318);
            this.Controls.Add(this.opDesenhar);
            this.Controls.Add(this.pnDesenho);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtRaio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbCalculos);
            this.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULADORA GRÁFICA";
            this.gbCalculos.ResumeLayout(false);
            this.gbCalculos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCalculos;
        private System.Windows.Forms.RadioButton rbVolume;
        private System.Windows.Forms.RadioButton rbPerimetro;
        private System.Windows.Forms.RadioButton rbArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Panel pnDesenho;
        private System.Windows.Forms.CheckBox opDesenhar;
    }
}

