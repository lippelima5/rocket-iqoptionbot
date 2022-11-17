
namespace RocketBuy
{
    partial class F_LOG
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
            this.G_LOGS = new System.Windows.Forms.DataGridView();
            this.G_RESULT = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.G_LOGS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G_RESULT)).BeginInit();
            this.SuspendLayout();
            // 
            // G_LOGS
            // 
            this.G_LOGS.AllowUserToAddRows = false;
            this.G_LOGS.AllowUserToDeleteRows = false;
            this.G_LOGS.AllowUserToResizeColumns = false;
            this.G_LOGS.AllowUserToResizeRows = false;
            this.G_LOGS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.G_LOGS.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.G_LOGS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.G_LOGS.Location = new System.Drawing.Point(0, 0);
            this.G_LOGS.Name = "G_LOGS";
            this.G_LOGS.ReadOnly = true;
            this.G_LOGS.RowHeadersVisible = false;
            this.G_LOGS.RowTemplate.Height = 25;
            this.G_LOGS.Size = new System.Drawing.Size(966, 268);
            this.G_LOGS.TabIndex = 5;
            this.G_LOGS.Click += new System.EventHandler(this.G_LOGS_Click);
            // 
            // G_RESULT
            // 
            this.G_RESULT.AllowUserToAddRows = false;
            this.G_RESULT.AllowUserToDeleteRows = false;
            this.G_RESULT.AllowUserToResizeColumns = false;
            this.G_RESULT.AllowUserToResizeRows = false;
            this.G_RESULT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.G_RESULT.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.G_RESULT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.G_RESULT.Location = new System.Drawing.Point(0, 292);
            this.G_RESULT.Name = "G_RESULT";
            this.G_RESULT.ReadOnly = true;
            this.G_RESULT.RowHeadersVisible = false;
            this.G_RESULT.RowTemplate.Height = 25;
            this.G_RESULT.Size = new System.Drawing.Size(966, 268);
            this.G_RESULT.TabIndex = 6;
            // 
            // F_LOG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 560);
            this.Controls.Add(this.G_RESULT);
            this.Controls.Add(this.G_LOGS);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_LOG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logs do sistema";
            this.Load += new System.EventHandler(this.F_LOG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.G_LOGS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G_RESULT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView G_LOGS;
        private System.Windows.Forms.DataGridView G_RESULT;
    }
}