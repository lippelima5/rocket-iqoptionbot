
namespace RocketBuy
{
    partial class F_GERENCIAR
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
            this.B_SALVAR = new System.Windows.Forms.Button();
            this.T_EMAIL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.G_CONTAS = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.T_SENHA = new System.Windows.Forms.TextBox();
            this.C_REAL = new System.Windows.Forms.CheckBox();
            this.T_VALOR = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.B_ADD = new System.Windows.Forms.Button();
            this.B_REMOVER = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.G_CONTAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_VALOR)).BeginInit();
            this.SuspendLayout();
            // 
            // B_SALVAR
            // 
            this.B_SALVAR.Location = new System.Drawing.Point(633, 3);
            this.B_SALVAR.Name = "B_SALVAR";
            this.B_SALVAR.Size = new System.Drawing.Size(96, 54);
            this.B_SALVAR.TabIndex = 0;
            this.B_SALVAR.Text = "Salvar";
            this.B_SALVAR.UseVisualStyleBackColor = true;
            this.B_SALVAR.Click += new System.EventHandler(this.B_SALVAR_Click);
            // 
            // T_EMAIL
            // 
            this.T_EMAIL.Location = new System.Drawing.Point(12, 30);
            this.T_EMAIL.Name = "T_EMAIL";
            this.T_EMAIL.Size = new System.Drawing.Size(377, 23);
            this.T_EMAIL.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "E-mail IQ Option";
            // 
            // G_CONTAS
            // 
            this.G_CONTAS.AllowUserToAddRows = false;
            this.G_CONTAS.AllowUserToDeleteRows = false;
            this.G_CONTAS.AllowUserToResizeColumns = false;
            this.G_CONTAS.AllowUserToResizeRows = false;
            this.G_CONTAS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.G_CONTAS.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.G_CONTAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.G_CONTAS.Location = new System.Drawing.Point(1, 243);
            this.G_CONTAS.Name = "G_CONTAS";
            this.G_CONTAS.ReadOnly = true;
            this.G_CONTAS.RowHeadersVisible = false;
            this.G_CONTAS.RowTemplate.Height = 25;
            this.G_CONTAS.Size = new System.Drawing.Size(732, 311);
            this.G_CONTAS.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(192, 273);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(377, 23);
            this.textBox3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "E-mail IQ Option";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Senha IQ Option";
            // 
            // T_SENHA
            // 
            this.T_SENHA.Location = new System.Drawing.Point(12, 89);
            this.T_SENHA.Name = "T_SENHA";
            this.T_SENHA.Size = new System.Drawing.Size(377, 23);
            this.T_SENHA.TabIndex = 6;
            // 
            // C_REAL
            // 
            this.C_REAL.AutoSize = true;
            this.C_REAL.Location = new System.Drawing.Point(302, 142);
            this.C_REAL.Name = "C_REAL";
            this.C_REAL.Size = new System.Drawing.Size(87, 19);
            this.C_REAL.TabIndex = 8;
            this.C_REAL.Text = "Operar Real";
            this.C_REAL.UseVisualStyleBackColor = true;
            // 
            // T_VALOR
            // 
            this.T_VALOR.Location = new System.Drawing.Point(12, 142);
            this.T_VALOR.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.T_VALOR.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.T_VALOR.Name = "T_VALOR";
            this.T_VALOR.Size = new System.Drawing.Size(185, 23);
            this.T_VALOR.TabIndex = 9;
            this.T_VALOR.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Valor Entrada";
            // 
            // B_ADD
            // 
            this.B_ADD.Location = new System.Drawing.Point(293, 186);
            this.B_ADD.Name = "B_ADD";
            this.B_ADD.Size = new System.Drawing.Size(96, 38);
            this.B_ADD.TabIndex = 11;
            this.B_ADD.Text = "Adicionar";
            this.B_ADD.UseVisualStyleBackColor = true;
            this.B_ADD.Click += new System.EventHandler(this.B_ADD_Click);
            // 
            // B_REMOVER
            // 
            this.B_REMOVER.Location = new System.Drawing.Point(12, 186);
            this.B_REMOVER.Name = "B_REMOVER";
            this.B_REMOVER.Size = new System.Drawing.Size(96, 38);
            this.B_REMOVER.TabIndex = 12;
            this.B_REMOVER.Text = "Remover";
            this.B_REMOVER.UseVisualStyleBackColor = true;
            this.B_REMOVER.Click += new System.EventHandler(this.B_REMOVER_Click);
            // 
            // F_GERENCIAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 554);
            this.Controls.Add(this.B_REMOVER);
            this.Controls.Add(this.B_ADD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.T_VALOR);
            this.Controls.Add(this.C_REAL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.T_SENHA);
            this.Controls.Add(this.G_CONTAS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.T_EMAIL);
            this.Controls.Add(this.B_SALVAR);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GERENCIAR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Contas";
            this.Load += new System.EventHandler(this.F_ADD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.G_CONTAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_VALOR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_SALVAR;
        private System.Windows.Forms.TextBox T_EMAIL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView G_CONTAS;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox T_SENHA;
        private System.Windows.Forms.CheckBox C_REAL;
        private System.Windows.Forms.NumericUpDown T_VALOR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button B_ADD;
        private System.Windows.Forms.Button B_REMOVER;
    }
}