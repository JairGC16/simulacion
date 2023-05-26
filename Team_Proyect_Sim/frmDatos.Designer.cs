namespace Team_Proyect_Sim
{
    partial class frmDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatos));
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.lblHoraSalida = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTiempoLlegada = new System.Windows.Forms.DataGridView();
            this.clmnMinutos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnProb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnLimInf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnLimSup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvTieempoServicio = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTiempoServicio = new System.Windows.Forms.Label();
            this.nudEquipo = new System.Windows.Forms.NumericUpDown();
            this.dgvCamionesEsp = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCamionesEsp = new System.Windows.Forms.Label();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdDesplegar = new System.Windows.Forms.Button();
            this.cmdEquipo = new System.Windows.Forms.Button();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiempoLlegada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTieempoServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEquipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamionesEsp)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(162)))), ((int)(((byte)(202)))));
            this.gbInfo.Controls.Add(this.lblHoraSalida);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbInfo.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbInfo.Location = new System.Drawing.Point(12, 12);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(169, 123);
            this.gbInfo.TabIndex = 0;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Info";
            // 
            // lblHoraSalida
            // 
            this.lblHoraSalida.AutoSize = true;
            this.lblHoraSalida.Location = new System.Drawing.Point(6, 105);
            this.lblHoraSalida.Name = "lblHoraSalida";
            this.lblHoraSalida.Size = new System.Drawing.Size(113, 15);
            this.lblHoraSalida.TabIndex = 5;
            this.lblHoraSalida.Text = "Hora de salida = 7:30";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hora de descanso = 3:00am";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Costo espera = 100 x Hora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Costo operacion = 500 x Hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sueldo extra = 37.50 x Hora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sueldo normal = 25 x Hora";
            // 
            // dgvTiempoLlegada
            // 
            this.dgvTiempoLlegada.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvTiempoLlegada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiempoLlegada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnMinutos,
            this.clmnProb,
            this.clmnLimInf,
            this.clmnLimSup});
            this.dgvTiempoLlegada.Location = new System.Drawing.Point(12, 164);
            this.dgvTiempoLlegada.Name = "dgvTiempoLlegada";
            this.dgvTiempoLlegada.Size = new System.Drawing.Size(303, 125);
            this.dgvTiempoLlegada.TabIndex = 1;
            // 
            // clmnMinutos
            // 
            this.clmnMinutos.HeaderText = "Minutos";
            this.clmnMinutos.Name = "clmnMinutos";
            this.clmnMinutos.Width = 50;
            // 
            // clmnProb
            // 
            this.clmnProb.HeaderText = "Probabilidad";
            this.clmnProb.Name = "clmnProb";
            this.clmnProb.Width = 70;
            // 
            // clmnLimInf
            // 
            this.clmnLimInf.HeaderText = "Limite Inferior";
            this.clmnLimInf.Name = "clmnLimInf";
            this.clmnLimInf.Width = 70;
            // 
            // clmnLimSup
            // 
            this.clmnLimSup.HeaderText = "Limite Superior";
            this.clmnLimSup.Name = "clmnLimSup";
            this.clmnLimSup.Width = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tiempo Entre Llegadas";
            // 
            // dgvTieempoServicio
            // 
            this.dgvTieempoServicio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvTieempoServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTieempoServicio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvTieempoServicio.Location = new System.Drawing.Point(332, 164);
            this.dgvTieempoServicio.Name = "dgvTieempoServicio";
            this.dgvTieempoServicio.Size = new System.Drawing.Size(303, 125);
            this.dgvTieempoServicio.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Minutos";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Probabilidad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Limite Inferior";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Limite Superior";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 70;
            // 
            // lblTiempoServicio
            // 
            this.lblTiempoServicio.AutoSize = true;
            this.lblTiempoServicio.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoServicio.Location = new System.Drawing.Point(329, 143);
            this.lblTiempoServicio.Name = "lblTiempoServicio";
            this.lblTiempoServicio.Size = new System.Drawing.Size(164, 18);
            this.lblTiempoServicio.TabIndex = 4;
            this.lblTiempoServicio.Text = "Tiempo de Servicio Equipo: ";
            // 
            // nudEquipo
            // 
            this.nudEquipo.Location = new System.Drawing.Point(499, 141);
            this.nudEquipo.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudEquipo.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudEquipo.Name = "nudEquipo";
            this.nudEquipo.ReadOnly = true;
            this.nudEquipo.Size = new System.Drawing.Size(31, 20);
            this.nudEquipo.TabIndex = 5;
            this.nudEquipo.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudEquipo.ValueChanged += new System.EventHandler(this.nudEquipo_ValueChanged);
            // 
            // dgvCamionesEsp
            // 
            this.dgvCamionesEsp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvCamionesEsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCamionesEsp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgvCamionesEsp.Location = new System.Drawing.Point(330, 12);
            this.dgvCamionesEsp.Name = "dgvCamionesEsp";
            this.dgvCamionesEsp.Size = new System.Drawing.Size(303, 123);
            this.dgvCamionesEsp.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Camiones";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Probabilidad";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 70;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Limite Inferior";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 70;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Limite Superior";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 70;
            // 
            // lblCamionesEsp
            // 
            this.lblCamionesEsp.AutoSize = true;
            this.lblCamionesEsp.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamionesEsp.Location = new System.Drawing.Point(197, 15);
            this.lblCamionesEsp.Name = "lblCamionesEsp";
            this.lblCamionesEsp.Size = new System.Drawing.Size(127, 18);
            this.lblCamionesEsp.TabIndex = 7;
            this.lblCamionesEsp.Text = "Camiones Esperando";
            // 
            // cmdClose
            // 
            this.cmdClose.BackColor = System.Drawing.Color.Red;
            this.cmdClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClose.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmdClose.Location = new System.Drawing.Point(187, 129);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(137, 29);
            this.cmdClose.TabIndex = 8;
            this.cmdClose.Text = "&Salir";
            this.cmdClose.UseVisualStyleBackColor = false;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdDesplegar
            // 
            this.cmdDesplegar.BackColor = System.Drawing.Color.Blue;
            this.cmdDesplegar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdDesplegar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdDesplegar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmdDesplegar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmdDesplegar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDesplegar.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmdDesplegar.Location = new System.Drawing.Point(187, 40);
            this.cmdDesplegar.Name = "cmdDesplegar";
            this.cmdDesplegar.Size = new System.Drawing.Size(137, 29);
            this.cmdDesplegar.TabIndex = 9;
            this.cmdDesplegar.Text = "&Desplegar Tablas";
            this.cmdDesplegar.UseVisualStyleBackColor = false;
            this.cmdDesplegar.Click += new System.EventHandler(this.cmdDesplegar_Click);
            // 
            // cmdEquipo
            // 
            this.cmdEquipo.BackColor = System.Drawing.Color.Blue;
            this.cmdEquipo.Enabled = false;
            this.cmdEquipo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdEquipo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmdEquipo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmdEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEquipo.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmdEquipo.Location = new System.Drawing.Point(187, 84);
            this.cmdEquipo.Name = "cmdEquipo";
            this.cmdEquipo.Size = new System.Drawing.Size(137, 29);
            this.cmdEquipo.TabIndex = 10;
            this.cmdEquipo.Text = "&Cambiar Equipo";
            this.cmdEquipo.UseVisualStyleBackColor = false;
            this.cmdEquipo.Click += new System.EventHandler(this.cmdEquipo_Click);
            // 
            // frmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(645, 302);
            this.Controls.Add(this.cmdEquipo);
            this.Controls.Add(this.cmdDesplegar);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.lblCamionesEsp);
            this.Controls.Add(this.dgvCamionesEsp);
            this.Controls.Add(this.nudEquipo);
            this.Controls.Add(this.lblTiempoServicio);
            this.Controls.Add(this.dgvTieempoServicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvTiempoLlegada);
            this.Controls.Add(this.gbInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDatos";
            this.Text = "Datos";
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiempoLlegada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTieempoServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEquipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamionesEsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTiempoLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnMinutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnProb;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnLimInf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnLimSup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvTieempoServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label lblTiempoServicio;
        private System.Windows.Forms.NumericUpDown nudEquipo;
        private System.Windows.Forms.DataGridView dgvCamionesEsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label lblCamionesEsp;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdDesplegar;
        private System.Windows.Forms.Button cmdEquipo;
        private System.Windows.Forms.Label lblHoraSalida;
    }
}