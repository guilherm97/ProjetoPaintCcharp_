
namespace SimplePaint
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonBorracha = new System.Windows.Forms.Button();
            this.ExpessuraDaCaneta = new System.Windows.Forms.Label();
            this.comboBoxExpessuraDaCaneta = new System.Windows.Forms.ComboBox();
            this.CorDaCaneta = new System.Windows.Forms.Label();
            this.ButtonCorCaneta = new System.Windows.Forms.Button();
            this.panelpintura = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonSalvar);
            this.groupBox1.Controls.Add(this.buttonLimpar);
            this.groupBox1.Controls.Add(this.buttonBorracha);
            this.groupBox1.Controls.Add(this.ExpessuraDaCaneta);
            this.groupBox1.Controls.Add(this.comboBoxExpessuraDaCaneta);
            this.groupBox1.Controls.Add(this.CorDaCaneta);
            this.groupBox1.Controls.Add(this.ButtonCorCaneta);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personalizar";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.Black;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.ForeColor = System.Drawing.Color.White;
            this.buttonSalvar.Location = new System.Drawing.Point(659, 43);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(90, 33);
            this.buttonSalvar.TabIndex = 6;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.Color.Black;
            this.buttonLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpar.ForeColor = System.Drawing.Color.White;
            this.buttonLimpar.Location = new System.Drawing.Point(563, 42);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(90, 33);
            this.buttonLimpar.TabIndex = 5;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonBorracha
            // 
            this.buttonBorracha.BackColor = System.Drawing.Color.Black;
            this.buttonBorracha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBorracha.ForeColor = System.Drawing.Color.White;
            this.buttonBorracha.Location = new System.Drawing.Point(465, 42);
            this.buttonBorracha.Name = "buttonBorracha";
            this.buttonBorracha.Size = new System.Drawing.Size(90, 33);
            this.buttonBorracha.TabIndex = 4;
            this.buttonBorracha.Text = "Borracha";
            this.buttonBorracha.UseVisualStyleBackColor = false;
            this.buttonBorracha.Click += new System.EventHandler(this.buttonBorracha_Click);
            this.buttonBorracha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonBorracha_MouseDown);
            // 
            // ExpessuraDaCaneta
            // 
            this.ExpessuraDaCaneta.AutoSize = true;
            this.ExpessuraDaCaneta.Location = new System.Drawing.Point(201, 51);
            this.ExpessuraDaCaneta.Name = "ExpessuraDaCaneta";
            this.ExpessuraDaCaneta.Size = new System.Drawing.Size(162, 18);
            this.ExpessuraDaCaneta.TabIndex = 3;
            this.ExpessuraDaCaneta.Text = "Expessura Da Caneta";
            // 
            // comboBoxExpessuraDaCaneta
            // 
            this.comboBoxExpessuraDaCaneta.FormattingEnabled = true;
            this.comboBoxExpessuraDaCaneta.Location = new System.Drawing.Point(369, 48);
            this.comboBoxExpessuraDaCaneta.Name = "comboBoxExpessuraDaCaneta";
            this.comboBoxExpessuraDaCaneta.Size = new System.Drawing.Size(72, 26);
            this.comboBoxExpessuraDaCaneta.TabIndex = 2;
            this.comboBoxExpessuraDaCaneta.SelectedIndexChanged += new System.EventHandler(this.comboBoxExpessuraDaCaneta_SelectedIndexChanged);
            // 
            // CorDaCaneta
            // 
            this.CorDaCaneta.AutoSize = true;
            this.CorDaCaneta.Location = new System.Drawing.Point(6, 50);
            this.CorDaCaneta.Name = "CorDaCaneta";
            this.CorDaCaneta.Size = new System.Drawing.Size(111, 18);
            this.CorDaCaneta.TabIndex = 1;
            this.CorDaCaneta.Text = "Cor da Caneta";
            this.CorDaCaneta.Click += new System.EventHandler(this.label1_Click);
            // 
            // ButtonCorCaneta
            // 
            this.ButtonCorCaneta.BackColor = System.Drawing.Color.Blue;
            this.ButtonCorCaneta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCorCaneta.ForeColor = System.Drawing.Color.Black;
            this.ButtonCorCaneta.Location = new System.Drawing.Point(123, 43);
            this.ButtonCorCaneta.Name = "ButtonCorCaneta";
            this.ButtonCorCaneta.Size = new System.Drawing.Size(72, 31);
            this.ButtonCorCaneta.TabIndex = 0;
            this.ButtonCorCaneta.UseVisualStyleBackColor = false;
            this.ButtonCorCaneta.Click += new System.EventHandler(this.ButtonCorCaneta_Click);
            // 
            // panelpintura
            // 
            this.panelpintura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelpintura.BackColor = System.Drawing.Color.White;
            this.panelpintura.Location = new System.Drawing.Point(12, 146);
            this.panelpintura.Name = "panelpintura";
            this.panelpintura.Size = new System.Drawing.Size(776, 282);
            this.panelpintura.TabIndex = 1;
            this.panelpintura.Paint += new System.Windows.Forms.PaintEventHandler(this.panelpintura_Paint);
            this.panelpintura.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelpintura_MouseDown);
            this.panelpintura.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelpintura_MouseMove);
            this.panelpintura.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelpintura_MouseUp);
            this.panelpintura.Resize += new System.EventHandler(this.panelpintura_Resize);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelpintura);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Simple Paint";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxExpessuraDaCaneta;
        private System.Windows.Forms.Label CorDaCaneta;
        private System.Windows.Forms.Button ButtonCorCaneta;
        private System.Windows.Forms.Label ExpessuraDaCaneta;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonBorracha;
        private System.Windows.Forms.Panel panelpintura;
    }
}

