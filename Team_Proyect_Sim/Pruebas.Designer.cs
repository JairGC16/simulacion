namespace Team_Proyect_Sim
{
    partial class Pruebas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pruebas));
            this.dgvNums2 = new System.Windows.Forms.DataGridView();
            this.cmdPoker = new System.Windows.Forms.Button();
            this.dgvPoker = new System.Windows.Forms.DataGridView();
            this.Evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdPromedio = new System.Windows.Forms.Button();
            this.txtProm = new System.Windows.Forms.TextBox();
            this.txtZ0 = new System.Windows.Forms.TextBox();
            this.lblZ = new System.Windows.Forms.Label();
            this.lblProm = new System.Windows.Forms.Label();
            this.lblRechazo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNums2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoker)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNums2
            // 
            this.dgvNums2.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvNums2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNums2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNums2.Location = new System.Drawing.Point(475, 12);
            this.dgvNums2.Name = "dgvNums2";
            this.dgvNums2.Size = new System.Drawing.Size(172, 368);
            this.dgvNums2.TabIndex = 16;
            // 
            // cmdPoker
            // 
            this.cmdPoker.BackColor = System.Drawing.Color.AliceBlue;
            this.cmdPoker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdPoker.BackgroundImage")));
            this.cmdPoker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdPoker.ForeColor = System.Drawing.Color.Purple;
            this.cmdPoker.Location = new System.Drawing.Point(12, 98);
            this.cmdPoker.Name = "cmdPoker";
            this.cmdPoker.Size = new System.Drawing.Size(108, 83);
            this.cmdPoker.TabIndex = 17;
            this.cmdPoker.Text = "Poker";
            this.cmdPoker.UseVisualStyleBackColor = false;
            this.cmdPoker.Click += new System.EventHandler(this.cmdPoker_Click);
            // 
            // dgvPoker
            // 
            this.dgvPoker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoker.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Evento,
            this.FE,
            this.FO,
            this.Resultado});
            this.dgvPoker.Location = new System.Drawing.Point(12, 206);
            this.dgvPoker.Name = "dgvPoker";
            this.dgvPoker.ReadOnly = true;
            this.dgvPoker.Size = new System.Drawing.Size(443, 174);
            this.dgvPoker.TabIndex = 19;
            // 
            // Evento
            // 
            this.Evento.HeaderText = "EVENTO";
            this.Evento.Name = "Evento";
            this.Evento.ReadOnly = true;
            // 
            // FE
            // 
            this.FE.HeaderText = "F. ESPERADA";
            this.FE.MaxInputLength = 6;
            this.FE.Name = "FE";
            this.FE.ReadOnly = true;
            this.FE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FO
            // 
            this.FO.HeaderText = "F. OBTENIDA";
            this.FO.Name = "FO";
            this.FO.ReadOnly = true;
            // 
            // Resultado
            // 
            this.Resultado.HeaderText = "";
            this.Resultado.Name = "Resultado";
            this.Resultado.ReadOnly = true;
            // 
            // cmdPromedio
            // 
            this.cmdPromedio.Location = new System.Drawing.Point(328, 109);
            this.cmdPromedio.Name = "cmdPromedio";
            this.cmdPromedio.Size = new System.Drawing.Size(75, 23);
            this.cmdPromedio.TabIndex = 20;
            this.cmdPromedio.Text = "Promedio";
            this.cmdPromedio.UseVisualStyleBackColor = true;
            this.cmdPromedio.Click += new System.EventHandler(this.cmdPromedio_Click);
            // 
            // txtProm
            // 
            this.txtProm.Location = new System.Drawing.Point(328, 138);
            this.txtProm.Name = "txtProm";
            this.txtProm.ReadOnly = true;
            this.txtProm.Size = new System.Drawing.Size(100, 20);
            this.txtProm.TabIndex = 21;
            // 
            // txtZ0
            // 
            this.txtZ0.Location = new System.Drawing.Point(328, 161);
            this.txtZ0.Name = "txtZ0";
            this.txtZ0.ReadOnly = true;
            this.txtZ0.Size = new System.Drawing.Size(100, 20);
            this.txtZ0.TabIndex = 22;
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Location = new System.Drawing.Point(304, 164);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(18, 13);
            this.lblZ.TabIndex = 23;
            this.lblZ.Text = "z0";
            // 
            // lblProm
            // 
            this.lblProm.AutoSize = true;
            this.lblProm.Location = new System.Drawing.Point(292, 141);
            this.lblProm.Name = "lblProm";
            this.lblProm.Size = new System.Drawing.Size(30, 13);
            this.lblProm.TabIndex = 24;
            this.lblProm.Text = "prom";
            // 
            // lblRechazo
            // 
            this.lblRechazo.AutoSize = true;
            this.lblRechazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRechazo.Location = new System.Drawing.Point(12, 12);
            this.lblRechazo.Name = "lblRechazo";
            this.lblRechazo.Size = new System.Drawing.Size(14, 20);
            this.lblRechazo.TabIndex = 25;
            this.lblRechazo.Text = " ";
            // 
            // Pruebas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(659, 405);
            this.Controls.Add(this.lblRechazo);
            this.Controls.Add(this.lblProm);
            this.Controls.Add(this.lblZ);
            this.Controls.Add(this.txtZ0);
            this.Controls.Add(this.txtProm);
            this.Controls.Add(this.cmdPromedio);
            this.Controls.Add(this.dgvPoker);
            this.Controls.Add(this.cmdPoker);
            this.Controls.Add(this.dgvNums2);
            this.Name = "Pruebas";
            this.Text = "Pruebas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNums2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNums2;
        private System.Windows.Forms.Button cmdPoker;
        private System.Windows.Forms.DataGridView dgvPoker;
        private System.Windows.Forms.Button cmdPromedio;
        private System.Windows.Forms.TextBox txtProm;
        private System.Windows.Forms.TextBox txtZ0;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.Label lblProm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resultado;
        private System.Windows.Forms.Label lblRechazo;
    }
}