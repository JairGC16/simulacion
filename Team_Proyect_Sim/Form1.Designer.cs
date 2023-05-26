namespace Team_Proyect_Sim
{
    partial class frmPoyecto
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPoyecto));
            this.lblC_M = new System.Windows.Forms.Label();
            this.txtC_M = new System.Windows.Forms.TextBox();
            this.txtMod = new System.Windows.Forms.TextBox();
            this.lblMod = new System.Windows.Forms.Label();
            this.txtC_A = new System.Windows.Forms.TextBox();
            this.LblC_A = new System.Windows.Forms.Label();
            this.txtSemilla = new System.Windows.Forms.TextBox();
            this.lblSemilla = new System.Windows.Forms.Label();
            this.cmdClean = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.lblCant = new System.Windows.Forms.Label();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.dgvNums = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumAleatorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdDefault = new System.Windows.Forms.Button();
            this.cmdDatos = new System.Windows.Forms.Button();
            this.nudEquipo = new System.Windows.Forms.NumericUpDown();
            this.lblTamEquip = new System.Windows.Forms.Label();
            this.dgvProblema = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoLlegadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InicioServ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroPseudoServ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoServ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TermServ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OcioPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoEspera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdResolver = new System.Windows.Forms.Button();
            this.cmdIntroducir = new System.Windows.Forms.Button();
            this.dgvEquipo = new System.Windows.Forms.DataGridView();
            this.Min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LimInf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LimSup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdPruebas = new System.Windows.Forms.Button();
            this.cmdRes = new System.Windows.Forms.Button();
            this.cmdComp = new System.Windows.Forms.Button();
            this.cmdTeam = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEquipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProblema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblC_M
            // 
            this.lblC_M.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC_M.Location = new System.Drawing.Point(4, 13);
            this.lblC_M.Name = "lblC_M";
            this.lblC_M.Size = new System.Drawing.Size(97, 33);
            this.lblC_M.TabIndex = 1;
            this.lblC_M.Text = "Constante Multiplicativa =";
            // 
            // txtC_M
            // 
            this.txtC_M.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtC_M.Location = new System.Drawing.Point(91, 17);
            this.txtC_M.Name = "txtC_M";
            this.txtC_M.Size = new System.Drawing.Size(100, 22);
            this.txtC_M.TabIndex = 2;
            this.txtC_M.AcceptsTabChanged += new System.EventHandler(this.txtC_M_AcceptsTabChanged);
            // 
            // txtMod
            // 
            this.txtMod.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtMod.Location = new System.Drawing.Point(283, 50);
            this.txtMod.Name = "txtMod";
            this.txtMod.Size = new System.Drawing.Size(100, 22);
            this.txtMod.TabIndex = 4;
            // 
            // lblMod
            // 
            this.lblMod.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblMod.Location = new System.Drawing.Point(197, 56);
            this.lblMod.Name = "lblMod";
            this.lblMod.Size = new System.Drawing.Size(64, 17);
            this.lblMod.TabIndex = 3;
            this.lblMod.Text = "Modulo =";
            // 
            // txtC_A
            // 
            this.txtC_A.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtC_A.Location = new System.Drawing.Point(283, 16);
            this.txtC_A.Name = "txtC_A";
            this.txtC_A.Size = new System.Drawing.Size(100, 22);
            this.txtC_A.TabIndex = 6;
            // 
            // LblC_A
            // 
            this.LblC_A.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LblC_A.Location = new System.Drawing.Point(196, 14);
            this.LblC_A.Name = "LblC_A";
            this.LblC_A.Size = new System.Drawing.Size(65, 33);
            this.LblC_A.TabIndex = 5;
            this.LblC_A.Text = "Constante Aditiva =";
            // 
            // txtSemilla
            // 
            this.txtSemilla.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtSemilla.Location = new System.Drawing.Point(91, 51);
            this.txtSemilla.Name = "txtSemilla";
            this.txtSemilla.Size = new System.Drawing.Size(100, 22);
            this.txtSemilla.TabIndex = 8;
            // 
            // lblSemilla
            // 
            this.lblSemilla.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblSemilla.Location = new System.Drawing.Point(5, 55);
            this.lblSemilla.Name = "lblSemilla";
            this.lblSemilla.Size = new System.Drawing.Size(79, 17);
            this.lblSemilla.TabIndex = 7;
            this.lblSemilla.Text = "Semilla =";
            // 
            // cmdClean
            // 
            this.cmdClean.BackColor = System.Drawing.Color.Yellow;
            this.cmdClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdClean.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdClean.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cmdClean.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClean.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmdClean.Location = new System.Drawing.Point(73, 144);
            this.cmdClean.Name = "cmdClean";
            this.cmdClean.Size = new System.Drawing.Size(75, 30);
            this.cmdClean.TabIndex = 10;
            this.cmdClean.Text = "&Limpiar";
            this.cmdClean.UseVisualStyleBackColor = false;
            this.cmdClean.Click += new System.EventHandler(this.cmdClean_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClose.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmdClose.Location = new System.Drawing.Point(126, 225);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 30);
            this.cmdClose.TabIndex = 12;
            this.cmdClose.Text = "&Salir";
            this.cmdClose.UseVisualStyleBackColor = false;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // lblCant
            // 
            this.lblCant.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblCant.Location = new System.Drawing.Point(435, 13);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(79, 33);
            this.lblCant.TabIndex = 13;
            this.lblCant.Text = "Cantidad de Numeros =";
            // 
            // txtCant
            // 
            this.txtCant.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtCant.Location = new System.Drawing.Point(520, 17);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(100, 22);
            this.txtCant.TabIndex = 14;
            // 
            // dgvNums
            // 
            this.dgvNums.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvNums.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNums.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NumAleatorio});
            this.dgvNums.Location = new System.Drawing.Point(223, 83);
            this.dgvNums.Name = "dgvNums";
            this.dgvNums.ReadOnly = true;
            this.dgvNums.Size = new System.Drawing.Size(193, 211);
            this.dgvNums.TabIndex = 15;
            this.dgvNums.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNums_CellClick);
            this.dgvNums.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNums_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 30;
            // 
            // NumAleatorio
            // 
            this.NumAleatorio.HeaderText = "Numero PseudoAleatorio";
            this.NumAleatorio.Name = "NumAleatorio";
            this.NumAleatorio.ReadOnly = true;
            this.NumAleatorio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cmdDefault
            // 
            this.cmdDefault.BackColor = System.Drawing.Color.Aqua;
            this.cmdDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdDefault.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdDefault.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdDefault.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmdDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDefault.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmdDefault.Location = new System.Drawing.Point(26, 83);
            this.cmdDefault.Name = "cmdDefault";
            this.cmdDefault.Size = new System.Drawing.Size(75, 30);
            this.cmdDefault.TabIndex = 16;
            this.cmdDefault.Text = "Default";
            this.cmdDefault.UseVisualStyleBackColor = false;
            this.cmdDefault.Click += new System.EventHandler(this.cmdDefault_Click);
            // 
            // cmdDatos
            // 
            this.cmdDatos.BackColor = System.Drawing.Color.MediumPurple;
            this.cmdDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdDatos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmdDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDatos.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmdDatos.Location = new System.Drawing.Point(26, 180);
            this.cmdDatos.Name = "cmdDatos";
            this.cmdDatos.Size = new System.Drawing.Size(75, 30);
            this.cmdDatos.TabIndex = 17;
            this.cmdDatos.Text = "&Datos";
            this.cmdDatos.UseVisualStyleBackColor = false;
            this.cmdDatos.Click += new System.EventHandler(this.cmdDatos_Click);
            // 
            // nudEquipo
            // 
            this.nudEquipo.Location = new System.Drawing.Point(646, 59);
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
            this.nudEquipo.Size = new System.Drawing.Size(33, 20);
            this.nudEquipo.TabIndex = 18;
            this.nudEquipo.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudEquipo.ValueChanged += new System.EventHandler(this.nudEquipo_ValueChanged);
            // 
            // lblTamEquip
            // 
            this.lblTamEquip.AutoSize = true;
            this.lblTamEquip.Location = new System.Drawing.Point(539, 61);
            this.lblTamEquip.Name = "lblTamEquip";
            this.lblTamEquip.Size = new System.Drawing.Size(101, 13);
            this.lblTamEquip.TabIndex = 19;
            this.lblTamEquip.Text = "Tamaño del equipo:";
            // 
            // dgvProblema
            // 
            this.dgvProblema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProblema.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.Numero,
            this.TiempoLlegadas,
            this.TiempoLlegada,
            this.InicioServ,
            this.NumeroPseudoServ,
            this.TiempoServ,
            this.TermServ,
            this.OcioPersonal,
            this.TiempoEspera,
            this.Cola});
            this.dgvProblema.Location = new System.Drawing.Point(12, 300);
            this.dgvProblema.Name = "dgvProblema";
            this.dgvProblema.Size = new System.Drawing.Size(724, 196);
            this.dgvProblema.TabIndex = 20;
            // 
            // num
            // 
            this.num.HeaderText = "#";
            this.num.Name = "num";
            this.num.Width = 25;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero PseudoAleatorio";
            this.Numero.Name = "Numero";
            this.Numero.Width = 90;
            // 
            // TiempoLlegadas
            // 
            this.TiempoLlegadas.HeaderText = "Tiempo Entre Llegadas";
            this.TiempoLlegadas.Name = "TiempoLlegadas";
            this.TiempoLlegadas.Width = 55;
            // 
            // TiempoLlegada
            // 
            this.TiempoLlegada.HeaderText = "Tiempo de Llegada";
            this.TiempoLlegada.Name = "TiempoLlegada";
            this.TiempoLlegada.Width = 55;
            // 
            // InicioServ
            // 
            this.InicioServ.HeaderText = "Inicio del Servicio";
            this.InicioServ.Name = "InicioServ";
            this.InicioServ.Width = 55;
            // 
            // NumeroPseudoServ
            // 
            this.NumeroPseudoServ.HeaderText = "Numero PseudoAleatorio";
            this.NumeroPseudoServ.Name = "NumeroPseudoServ";
            this.NumeroPseudoServ.Width = 90;
            // 
            // TiempoServ
            // 
            this.TiempoServ.HeaderText = "Tiempo de Servicio";
            this.TiempoServ.Name = "TiempoServ";
            this.TiempoServ.Width = 50;
            // 
            // TermServ
            // 
            this.TermServ.HeaderText = "Terminacion del Servicio";
            this.TermServ.Name = "TermServ";
            this.TermServ.Width = 75;
            // 
            // OcioPersonal
            // 
            this.OcioPersonal.HeaderText = "Ocio del Personal";
            this.OcioPersonal.Name = "OcioPersonal";
            this.OcioPersonal.Width = 50;
            // 
            // TiempoEspera
            // 
            this.TiempoEspera.HeaderText = "Tiempo de Espera del Camion";
            this.TiempoEspera.Name = "TiempoEspera";
            this.TiempoEspera.Width = 50;
            // 
            // Cola
            // 
            this.Cola.HeaderText = "Longituda de la Cola";
            this.Cola.Name = "Cola";
            this.Cola.Width = 60;
            // 
            // cmdResolver
            // 
            this.cmdResolver.BackColor = System.Drawing.Color.Lime;
            this.cmdResolver.Enabled = false;
            this.cmdResolver.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdResolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cmdResolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdResolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdResolver.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmdResolver.Location = new System.Drawing.Point(126, 180);
            this.cmdResolver.Name = "cmdResolver";
            this.cmdResolver.Size = new System.Drawing.Size(75, 30);
            this.cmdResolver.TabIndex = 21;
            this.cmdResolver.Text = "&Resolver";
            this.cmdResolver.UseVisualStyleBackColor = false;
            this.cmdResolver.Click += new System.EventHandler(this.cmdResolver_Click);
            // 
            // cmdIntroducir
            // 
            this.cmdIntroducir.BackColor = System.Drawing.Color.Lime;
            this.cmdIntroducir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdIntroducir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdIntroducir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cmdIntroducir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdIntroducir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdIntroducir.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmdIntroducir.Location = new System.Drawing.Point(126, 83);
            this.cmdIntroducir.Name = "cmdIntroducir";
            this.cmdIntroducir.Size = new System.Drawing.Size(75, 30);
            this.cmdIntroducir.TabIndex = 22;
            this.cmdIntroducir.Text = "&Generar";
            this.cmdIntroducir.UseVisualStyleBackColor = false;
            this.cmdIntroducir.Click += new System.EventHandler(this.cmdIntroducir_Click_1);
            // 
            // dgvEquipo
            // 
            this.dgvEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Min,
            this.Prob,
            this.LimInf,
            this.LimSup});
            this.dgvEquipo.Location = new System.Drawing.Point(432, 83);
            this.dgvEquipo.Name = "dgvEquipo";
            this.dgvEquipo.Size = new System.Drawing.Size(304, 211);
            this.dgvEquipo.TabIndex = 23;
            // 
            // Min
            // 
            this.Min.HeaderText = "Minutos";
            this.Min.Name = "Min";
            this.Min.Width = 50;
            // 
            // Prob
            // 
            this.Prob.HeaderText = "Probabilidad";
            this.Prob.Name = "Prob";
            this.Prob.Width = 70;
            // 
            // LimInf
            // 
            this.LimInf.HeaderText = "Limite Inferior";
            this.LimInf.Name = "LimInf";
            this.LimInf.Width = 60;
            // 
            // LimSup
            // 
            this.LimSup.HeaderText = "Limite Superior";
            this.LimSup.Name = "LimSup";
            this.LimSup.Width = 60;
            // 
            // cmdPruebas
            // 
            this.cmdPruebas.BackColor = System.Drawing.Color.MediumPurple;
            this.cmdPruebas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdPruebas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdPruebas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdPruebas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmdPruebas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPruebas.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmdPruebas.Location = new System.Drawing.Point(432, 47);
            this.cmdPruebas.Name = "cmdPruebas";
            this.cmdPruebas.Size = new System.Drawing.Size(75, 30);
            this.cmdPruebas.TabIndex = 25;
            this.cmdPruebas.Text = "&Pruebas";
            this.cmdPruebas.UseVisualStyleBackColor = false;
            this.cmdPruebas.Click += new System.EventHandler(this.cmdPruebas_Click);
            // 
            // cmdRes
            // 
            this.cmdRes.BackColor = System.Drawing.Color.Aqua;
            this.cmdRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdRes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdRes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdRes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmdRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRes.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmdRes.Location = new System.Drawing.Point(26, 225);
            this.cmdRes.Name = "cmdRes";
            this.cmdRes.Size = new System.Drawing.Size(75, 30);
            this.cmdRes.TabIndex = 26;
            this.cmdRes.Text = "&Resultados";
            this.cmdRes.UseVisualStyleBackColor = false;
            this.cmdRes.Click += new System.EventHandler(this.cmdRes_Click);
            // 
            // cmdComp
            // 
            this.cmdComp.BackColor = System.Drawing.Color.Aqua;
            this.cmdComp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdComp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdComp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdComp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmdComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdComp.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmdComp.Location = new System.Drawing.Point(60, 261);
            this.cmdComp.Name = "cmdComp";
            this.cmdComp.Size = new System.Drawing.Size(88, 30);
            this.cmdComp.TabIndex = 27;
            this.cmdComp.Text = "&Comparacion";
            this.cmdComp.UseVisualStyleBackColor = false;
            this.cmdComp.Click += new System.EventHandler(this.cmdComp_Click);
            // 
            // cmdTeam
            // 
            this.cmdTeam.BackColor = System.Drawing.Color.DodgerBlue;
            this.cmdTeam.Location = new System.Drawing.Point(714, 16);
            this.cmdTeam.Name = "cmdTeam";
            this.cmdTeam.Size = new System.Drawing.Size(22, 23);
            this.cmdTeam.TabIndex = 28;
            this.cmdTeam.Text = "&i";
            this.cmdTeam.UseVisualStyleBackColor = false;
            this.cmdTeam.Click += new System.EventHandler(this.cmdTeam_Click);
            // 
            // frmPoyecto
            // 
            this.AcceptButton = this.cmdIntroducir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.cmdClose;
            this.ClientSize = new System.Drawing.Size(754, 508);
            this.Controls.Add(this.cmdTeam);
            this.Controls.Add(this.cmdComp);
            this.Controls.Add(this.cmdRes);
            this.Controls.Add(this.cmdPruebas);
            this.Controls.Add(this.dgvEquipo);
            this.Controls.Add(this.cmdIntroducir);
            this.Controls.Add(this.cmdResolver);
            this.Controls.Add(this.dgvProblema);
            this.Controls.Add(this.lblTamEquip);
            this.Controls.Add(this.nudEquipo);
            this.Controls.Add(this.cmdDatos);
            this.Controls.Add(this.cmdDefault);
            this.Controls.Add(this.dgvNums);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdClean);
            this.Controls.Add(this.txtSemilla);
            this.Controls.Add(this.lblSemilla);
            this.Controls.Add(this.txtC_A);
            this.Controls.Add(this.LblC_A);
            this.Controls.Add(this.txtMod);
            this.Controls.Add(this.lblMod);
            this.Controls.Add(this.txtC_M);
            this.Controls.Add(this.lblC_M);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPoyecto";
            this.Text = "Proyecto Simulacion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEquipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProblema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblC_M;
        private System.Windows.Forms.TextBox txtC_M;
        private System.Windows.Forms.TextBox txtMod;
        private System.Windows.Forms.Label lblMod;
        private System.Windows.Forms.TextBox txtC_A;
        private System.Windows.Forms.Label LblC_A;
        private System.Windows.Forms.TextBox txtSemilla;
        private System.Windows.Forms.Label lblSemilla;
        private System.Windows.Forms.Button cmdClean;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.DataGridView dgvNums;
        private System.Windows.Forms.Button cmdDefault;
        private System.Windows.Forms.Button cmdDatos;
        private System.Windows.Forms.NumericUpDown nudEquipo;
        private System.Windows.Forms.Label lblTamEquip;
        private System.Windows.Forms.DataGridView dgvProblema;
        private System.Windows.Forms.Button cmdResolver;
        private System.Windows.Forms.Button cmdIntroducir;
        private System.Windows.Forms.DataGridView dgvEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Min;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prob;
        private System.Windows.Forms.DataGridViewTextBoxColumn LimInf;
        private System.Windows.Forms.DataGridViewTextBoxColumn LimSup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumAleatorio;
        public System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Button cmdPruebas;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoLlegadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn InicioServ;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroPseudoServ;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoServ;
        private System.Windows.Forms.DataGridViewTextBoxColumn TermServ;
        private System.Windows.Forms.DataGridViewTextBoxColumn OcioPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoEspera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cola;
        private System.Windows.Forms.Button cmdRes;
        private System.Windows.Forms.Button cmdComp;
        private System.Windows.Forms.Button cmdTeam;
    }
}

