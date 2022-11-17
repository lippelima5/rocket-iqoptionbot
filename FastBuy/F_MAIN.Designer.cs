
namespace RocketBuy
{
    partial class F_MAIN
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
            this.components = new System.ComponentModel.Container();
            this.B_INICIAR = new System.Windows.Forms.Button();
            this.T_OP_STATUS = new System.Windows.Forms.Label();
            this.G_CONTAS = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.R_DIGITAL = new System.Windows.Forms.RadioButton();
            this.R_BINARIA = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.L_TIMEFRAME = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.L_PARIDADES = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.B_PUT = new System.Windows.Forms.Button();
            this.B_CALL = new System.Windows.Forms.Button();
            this.B_ADD_CONTA = new System.Windows.Forms.Button();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.T_STATUS = new System.Windows.Forms.ToolStripStatusLabel();
            this.B_LOGS = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.T_HORA = new System.Windows.Forms.Label();
            this.C_MODO = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.G_CONTAS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_INICIAR
            // 
            this.B_INICIAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_INICIAR.Location = new System.Drawing.Point(1178, 19);
            this.B_INICIAR.Name = "B_INICIAR";
            this.B_INICIAR.Size = new System.Drawing.Size(76, 23);
            this.B_INICIAR.TabIndex = 0;
            this.B_INICIAR.Text = "Iniciar";
            this.B_INICIAR.UseVisualStyleBackColor = true;
            this.B_INICIAR.Click += new System.EventHandler(this.B_INICIAR_Click);
            // 
            // T_OP_STATUS
            // 
            this.T_OP_STATUS.AutoSize = true;
            this.T_OP_STATUS.Location = new System.Drawing.Point(697, 19);
            this.T_OP_STATUS.Name = "T_OP_STATUS";
            this.T_OP_STATUS.Size = new System.Drawing.Size(39, 15);
            this.T_OP_STATUS.TabIndex = 2;
            this.T_OP_STATUS.Text = "Status";
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
            this.G_CONTAS.Location = new System.Drawing.Point(12, 59);
            this.G_CONTAS.Name = "G_CONTAS";
            this.G_CONTAS.ReadOnly = true;
            this.G_CONTAS.RowHeadersVisible = false;
            this.G_CONTAS.RowTemplate.Height = 25;
            this.G_CONTAS.Size = new System.Drawing.Size(679, 334);
            this.G_CONTAS.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.R_DIGITAL);
            this.groupBox1.Controls.Add(this.R_BINARIA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.L_TIMEFRAME);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.L_PARIDADES);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.B_PUT);
            this.groupBox1.Controls.Add(this.B_CALL);
            this.groupBox1.Location = new System.Drawing.Point(697, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 345);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONTROLE DE OPERAÇÔES";
            // 
            // R_DIGITAL
            // 
            this.R_DIGITAL.AutoSize = true;
            this.R_DIGITAL.Location = new System.Drawing.Point(87, 116);
            this.R_DIGITAL.Name = "R_DIGITAL";
            this.R_DIGITAL.Size = new System.Drawing.Size(59, 19);
            this.R_DIGITAL.TabIndex = 14;
            this.R_DIGITAL.TabStop = true;
            this.R_DIGITAL.Text = "Digital";
            this.R_DIGITAL.UseVisualStyleBackColor = true;
            // 
            // R_BINARIA
            // 
            this.R_BINARIA.AutoSize = true;
            this.R_BINARIA.Location = new System.Drawing.Point(6, 116);
            this.R_BINARIA.Name = "R_BINARIA";
            this.R_BINARIA.Size = new System.Drawing.Size(61, 19);
            this.R_BINARIA.TabIndex = 13;
            this.R_BINARIA.TabStop = true;
            this.R_BINARIA.Text = "Binária";
            this.R_BINARIA.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Modo";
            // 
            // L_TIMEFRAME
            // 
            this.L_TIMEFRAME.FormattingEnabled = true;
            this.L_TIMEFRAME.Items.AddRange(new object[] {
            "M1",
            "M5",
            "M15"});
            this.L_TIMEFRAME.Location = new System.Drawing.Point(317, 49);
            this.L_TIMEFRAME.Name = "L_TIMEFRAME";
            this.L_TIMEFRAME.Size = new System.Drawing.Size(233, 23);
            this.L_TIMEFRAME.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "TimeFrame";
            // 
            // L_PARIDADES
            // 
            this.L_PARIDADES.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.L_PARIDADES.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.L_PARIDADES.FormattingEnabled = true;
            this.L_PARIDADES.Location = new System.Drawing.Point(6, 49);
            this.L_PARIDADES.Name = "L_PARIDADES";
            this.L_PARIDADES.Size = new System.Drawing.Size(233, 23);
            this.L_PARIDADES.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Paridade";
            // 
            // B_PUT
            // 
            this.B_PUT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(57)))), ((int)(((byte)(50)))));
            this.B_PUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_PUT.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.B_PUT.ForeColor = System.Drawing.Color.White;
            this.B_PUT.Location = new System.Drawing.Point(6, 218);
            this.B_PUT.Name = "B_PUT";
            this.B_PUT.Size = new System.Drawing.Size(233, 121);
            this.B_PUT.TabIndex = 8;
            this.B_PUT.Text = "PUT";
            this.B_PUT.UseVisualStyleBackColor = false;
            this.B_PUT.Click += new System.EventHandler(this.B_PUT_Click);
            // 
            // B_CALL
            // 
            this.B_CALL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(68)))));
            this.B_CALL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_CALL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.B_CALL.ForeColor = System.Drawing.Color.White;
            this.B_CALL.Location = new System.Drawing.Point(317, 218);
            this.B_CALL.Name = "B_CALL";
            this.B_CALL.Size = new System.Drawing.Size(233, 121);
            this.B_CALL.TabIndex = 7;
            this.B_CALL.Text = "CALL";
            this.B_CALL.UseVisualStyleBackColor = false;
            this.B_CALL.Click += new System.EventHandler(this.B_CALL_Click);
            // 
            // B_ADD_CONTA
            // 
            this.B_ADD_CONTA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_ADD_CONTA.Location = new System.Drawing.Point(615, 30);
            this.B_ADD_CONTA.Name = "B_ADD_CONTA";
            this.B_ADD_CONTA.Size = new System.Drawing.Size(76, 23);
            this.B_ADD_CONTA.TabIndex = 7;
            this.B_ADD_CONTA.Text = "Gerenciar";
            this.B_ADD_CONTA.UseVisualStyleBackColor = true;
            this.B_ADD_CONTA.Click += new System.EventHandler(this.B_ADD_CONTA_Click);
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.T_STATUS});
            this.StatusBar.Location = new System.Drawing.Point(0, 416);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(1266, 22);
            this.StatusBar.TabIndex = 8;
            this.StatusBar.Text = "StatusBar";
            this.StatusBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.T_STATUS_ItemClicked);
            // 
            // T_STATUS
            // 
            this.T_STATUS.Name = "T_STATUS";
            this.T_STATUS.Size = new System.Drawing.Size(118, 17);
            this.T_STATUS.Text = "toolStripStatusLabel1";
            // 
            // B_LOGS
            // 
            this.B_LOGS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_LOGS.Location = new System.Drawing.Point(533, 30);
            this.B_LOGS.Name = "B_LOGS";
            this.B_LOGS.Size = new System.Drawing.Size(76, 23);
            this.B_LOGS.TabIndex = 9;
            this.B_LOGS.Text = "Logs";
            this.B_LOGS.UseVisualStyleBackColor = true;
            this.B_LOGS.Click += new System.EventHandler(this.B_LOGS_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // T_HORA
            // 
            this.T_HORA.AutoSize = true;
            this.T_HORA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.T_HORA.Location = new System.Drawing.Point(1055, 20);
            this.T_HORA.Name = "T_HORA";
            this.T_HORA.Size = new System.Drawing.Size(72, 21);
            this.T_HORA.TabIndex = 10;
            this.T_HORA.Text = "23:59:59";
            // 
            // C_MODO
            // 
            this.C_MODO.AutoSize = true;
            this.C_MODO.Location = new System.Drawing.Point(417, 33);
            this.C_MODO.Name = "C_MODO";
            this.C_MODO.Size = new System.Drawing.Size(93, 19);
            this.C_MODO.TabIndex = 11;
            this.C_MODO.Text = "Modo Trader";
            this.C_MODO.UseVisualStyleBackColor = true;
            this.C_MODO.CheckedChanged += new System.EventHandler(this.C_MODO_CheckedChanged);
            // 
            // F_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 438);
            this.Controls.Add(this.C_MODO);
            this.Controls.Add(this.T_HORA);
            this.Controls.Add(this.B_LOGS);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.B_ADD_CONTA);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.G_CONTAS);
            this.Controls.Add(this.T_OP_STATUS);
            this.Controls.Add(this.B_INICIAR);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_MAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FastB";
            this.Load += new System.EventHandler(this.F_MAIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.G_CONTAS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_INICIAR;
        private System.Windows.Forms.Label T_OP_STATUS;
        private System.Windows.Forms.DataGridView G_CONTAS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox L_PARIDADES;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button B_PUT;
        private System.Windows.Forms.Button B_CALL;
        private System.Windows.Forms.ComboBox L_TIMEFRAME;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button B_ADD_CONTA;
        private System.Windows.Forms.StatusStrip F;
        private System.Windows.Forms.RadioButton R_DIGITAL;
        private System.Windows.Forms.RadioButton R_BINARIA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel T_STATUS;
        private System.Windows.Forms.Button B_LOGS;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label T_HORA;
        private System.Windows.Forms.CheckBox C_MODO;
    }
}

