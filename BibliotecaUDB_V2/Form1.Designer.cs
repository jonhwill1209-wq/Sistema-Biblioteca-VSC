namespace BibliotecaUDB_V2
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDocumentacion = new System.Windows.Forms.Button();
            this.chartUsuariosActivos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartLibrosMasPrestados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnEliminarLibro = new System.Windows.Forms.Button();
            this.btnEditarLibro = new System.Windows.Forms.Button();
            this.btnAnadirLibro = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.colIDLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAnioLibro = new System.Windows.Forms.TextBox();
            this.txtAutorLibro = new System.Windows.Forms.TextBox();
            this.txtTituloLibro = new System.Windows.Forms.TextBox();
            this.txtIdLibro = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.btnPrestar = new System.Windows.Forms.Button();
            this.grpOperaciones = new System.Windows.Forms.GroupBox();
            this.dgvPrestamosActivos = new System.Windows.Forms.DataGridView();
            this.colLibroId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuarioID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIdLibroPrestar = new System.Windows.Forms.TextBox();
            this.lblLibroPrestar = new System.Windows.Forms.Label();
            this.txtIdUsuarioPrestar = new System.Windows.Forms.TextBox();
            this.lblIdUsuarioPrestar = new System.Windows.Forms.Label();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.btnAnadirUsuario = new System.Windows.Forms.Button();
            this.grpGEstionUsuarios = new System.Windows.Forms.GroupBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.colIDUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCorreoUsuario = new System.Windows.Forms.TextBox();
            this.lblCorreoUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsuariosActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLibrosMasPrestados)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.grpOperaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamosActivos)).BeginInit();
            this.grpGEstionUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(881, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDocumentacion);
            this.tabPage1.Controls.Add(this.chartUsuariosActivos);
            this.tabPage1.Controls.Add(this.chartLibrosMasPrestados);
            this.tabPage1.Controls.Add(this.btnEliminarLibro);
            this.tabPage1.Controls.Add(this.btnEditarLibro);
            this.tabPage1.Controls.Add(this.btnAnadirLibro);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(873, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "📊 Dashboard y Libros";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDocumentacion
            // 
            this.btnDocumentacion.Location = new System.Drawing.Point(20, 357);
            this.btnDocumentacion.Name = "btnDocumentacion";
            this.btnDocumentacion.Size = new System.Drawing.Size(122, 23);
            this.btnDocumentacion.TabIndex = 6;
            this.btnDocumentacion.Text = "Documentacion";
            this.btnDocumentacion.UseVisualStyleBackColor = true;
            // 
            // chartUsuariosActivos
            // 
            chartArea1.Name = "ChartArea1";
            this.chartUsuariosActivos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartUsuariosActivos.Legends.Add(legend1);
            this.chartUsuariosActivos.Location = new System.Drawing.Point(499, 217);
            this.chartUsuariosActivos.Name = "chartUsuariosActivos";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartUsuariosActivos.Series.Add(series1);
            this.chartUsuariosActivos.Size = new System.Drawing.Size(255, 187);
            this.chartUsuariosActivos.TabIndex = 5;
            this.chartUsuariosActivos.Text = "chart2";
            // 
            // chartLibrosMasPrestados
            // 
            chartArea2.Name = "ChartArea1";
            this.chartLibrosMasPrestados.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartLibrosMasPrestados.Legends.Add(legend2);
            this.chartLibrosMasPrestados.Location = new System.Drawing.Point(499, 25);
            this.chartLibrosMasPrestados.Name = "chartLibrosMasPrestados";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartLibrosMasPrestados.Series.Add(series2);
            this.chartLibrosMasPrestados.Size = new System.Drawing.Size(249, 186);
            this.chartLibrosMasPrestados.TabIndex = 4;
            this.chartLibrosMasPrestados.Text = "chart1";
            // 
            // btnEliminarLibro
            // 
            this.btnEliminarLibro.Location = new System.Drawing.Point(305, 217);
            this.btnEliminarLibro.Name = "btnEliminarLibro";
            this.btnEliminarLibro.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarLibro.TabIndex = 3;
            this.btnEliminarLibro.Text = "Eliminar";
            this.btnEliminarLibro.UseVisualStyleBackColor = true;
            // 
            // btnEditarLibro
            // 
            this.btnEditarLibro.Location = new System.Drawing.Point(165, 216);
            this.btnEditarLibro.Name = "btnEditarLibro";
            this.btnEditarLibro.Size = new System.Drawing.Size(75, 23);
            this.btnEditarLibro.TabIndex = 2;
            this.btnEditarLibro.Text = "Editar";
            this.btnEditarLibro.UseVisualStyleBackColor = true;
            // 
            // btnAnadirLibro
            // 
            this.btnAnadirLibro.Location = new System.Drawing.Point(41, 217);
            this.btnAnadirLibro.Name = "btnAnadirLibro";
            this.btnAnadirLibro.Size = new System.Drawing.Size(75, 23);
            this.btnAnadirLibro.TabIndex = 1;
            this.btnAnadirLibro.Text = "Añadir";
            this.btnAnadirLibro.UseVisualStyleBackColor = true;
            this.btnAnadirLibro.Click += new System.EventHandler(this.btnAnadirLibro_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLibros);
            this.groupBox1.Controls.Add(this.txtAnioLibro);
            this.groupBox1.Controls.Add(this.txtAutorLibro);
            this.groupBox1.Controls.Add(this.txtTituloLibro);
            this.groupBox1.Controls.Add(this.txtIdLibro);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Libros";
            // 
            // dgvLibros
            // 
            this.dgvLibros.AllowUserToAddRows = false;
            this.dgvLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDLibro,
            this.colTitulo,
            this.colAutor,
            this.colAnio});
            this.dgvLibros.Location = new System.Drawing.Point(4, 50);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.ReadOnly = true;
            this.dgvLibros.RowHeadersWidth = 51;
            this.dgvLibros.RowTemplate.Height = 24;
            this.dgvLibros.Size = new System.Drawing.Size(480, 150);
            this.dgvLibros.TabIndex = 4;
            // 
            // colIDLibro
            // 
            this.colIDLibro.FillWeight = 50F;
            this.colIDLibro.HeaderText = "ID";
            this.colIDLibro.MinimumWidth = 6;
            this.colIDLibro.Name = "colIDLibro";
            this.colIDLibro.ReadOnly = true;
            // 
            // colTitulo
            // 
            this.colTitulo.HeaderText = "Titulo";
            this.colTitulo.MinimumWidth = 6;
            this.colTitulo.Name = "colTitulo";
            this.colTitulo.ReadOnly = true;
            // 
            // colAutor
            // 
            this.colAutor.HeaderText = "Autor";
            this.colAutor.MinimumWidth = 6;
            this.colAutor.Name = "colAutor";
            this.colAutor.ReadOnly = true;
            // 
            // colAnio
            // 
            this.colAnio.FillWeight = 50F;
            this.colAnio.HeaderText = "Año";
            this.colAnio.MinimumWidth = 6;
            this.colAnio.Name = "colAnio";
            this.colAnio.ReadOnly = true;
            // 
            // txtAnioLibro
            // 
            this.txtAnioLibro.Location = new System.Drawing.Point(366, 21);
            this.txtAnioLibro.Name = "txtAnioLibro";
            this.txtAnioLibro.Size = new System.Drawing.Size(48, 22);
            this.txtAnioLibro.TabIndex = 3;
            this.txtAnioLibro.Text = "Año";
            // 
            // txtAutorLibro
            // 
            this.txtAutorLibro.Location = new System.Drawing.Point(221, 21);
            this.txtAutorLibro.Name = "txtAutorLibro";
            this.txtAutorLibro.Size = new System.Drawing.Size(139, 22);
            this.txtAutorLibro.TabIndex = 2;
            this.txtAutorLibro.Text = "Autor";
            // 
            // txtTituloLibro
            // 
            this.txtTituloLibro.Location = new System.Drawing.Point(76, 21);
            this.txtTituloLibro.Name = "txtTituloLibro";
            this.txtTituloLibro.Size = new System.Drawing.Size(139, 22);
            this.txtTituloLibro.TabIndex = 1;
            this.txtTituloLibro.Text = "Titulo";
            // 
            // txtIdLibro
            // 
            this.txtIdLibro.Location = new System.Drawing.Point(3, 21);
            this.txtIdLibro.Name = "txtIdLibro";
            this.txtIdLibro.Size = new System.Drawing.Size(67, 22);
            this.txtIdLibro.TabIndex = 0;
            this.txtIdLibro.Text = "ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDevolver);
            this.tabPage2.Controls.Add(this.btnPrestar);
            this.tabPage2.Controls.Add(this.grpOperaciones);
            this.tabPage2.Controls.Add(this.btnEliminarUsuario);
            this.tabPage2.Controls.Add(this.btnEditarUsuario);
            this.tabPage2.Controls.Add(this.btnAnadirUsuario);
            this.tabPage2.Controls.Add(this.grpGEstionUsuarios);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(873, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "👥 Usuarios y Préstamos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(694, 229);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(152, 23);
            this.btnDevolver.TabIndex = 6;
            this.btnDevolver.Text = "Registar Devolución";
            this.btnDevolver.UseVisualStyleBackColor = true;
            // 
            // btnPrestar
            // 
            this.btnPrestar.Location = new System.Drawing.Point(547, 229);
            this.btnPrestar.Name = "btnPrestar";
            this.btnPrestar.Size = new System.Drawing.Size(141, 23);
            this.btnPrestar.TabIndex = 5;
            this.btnPrestar.Text = "Registrar Préstamo";
            this.btnPrestar.UseVisualStyleBackColor = true;
            // 
            // grpOperaciones
            // 
            this.grpOperaciones.Controls.Add(this.dgvPrestamosActivos);
            this.grpOperaciones.Controls.Add(this.txtIdLibroPrestar);
            this.grpOperaciones.Controls.Add(this.lblLibroPrestar);
            this.grpOperaciones.Controls.Add(this.txtIdUsuarioPrestar);
            this.grpOperaciones.Controls.Add(this.lblIdUsuarioPrestar);
            this.grpOperaciones.Location = new System.Drawing.Point(527, 6);
            this.grpOperaciones.Name = "grpOperaciones";
            this.grpOperaciones.Size = new System.Drawing.Size(338, 217);
            this.grpOperaciones.TabIndex = 4;
            this.grpOperaciones.TabStop = false;
            this.grpOperaciones.Text = "Gestion de Préstamos";
            // 
            // dgvPrestamosActivos
            // 
            this.dgvPrestamosActivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrestamosActivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestamosActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamosActivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLibroId,
            this.colUsuarioID,
            this.colFecha,
            this.colEstado});
            this.dgvPrestamosActivos.Location = new System.Drawing.Point(0, 67);
            this.dgvPrestamosActivos.Name = "dgvPrestamosActivos";
            this.dgvPrestamosActivos.ReadOnly = true;
            this.dgvPrestamosActivos.RowHeadersWidth = 51;
            this.dgvPrestamosActivos.RowTemplate.Height = 24;
            this.dgvPrestamosActivos.Size = new System.Drawing.Size(326, 150);
            this.dgvPrestamosActivos.TabIndex = 9;
            // 
            // colLibroId
            // 
            this.colLibroId.FillWeight = 50F;
            this.colLibroId.HeaderText = "ID Libro";
            this.colLibroId.MinimumWidth = 6;
            this.colLibroId.Name = "colLibroId";
            this.colLibroId.ReadOnly = true;
            // 
            // colUsuarioID
            // 
            this.colUsuarioID.FillWeight = 50F;
            this.colUsuarioID.HeaderText = "ID Usuario";
            this.colUsuarioID.MinimumWidth = 6;
            this.colUsuarioID.Name = "colUsuarioID";
            this.colUsuarioID.ReadOnly = true;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha Salida";
            this.colFecha.MinimumWidth = 6;
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.MinimumWidth = 6;
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // txtIdLibroPrestar
            // 
            this.txtIdLibroPrestar.Location = new System.Drawing.Point(116, 36);
            this.txtIdLibroPrestar.Name = "txtIdLibroPrestar";
            this.txtIdLibroPrestar.Size = new System.Drawing.Size(100, 22);
            this.txtIdLibroPrestar.TabIndex = 8;
            // 
            // lblLibroPrestar
            // 
            this.lblLibroPrestar.AutoSize = true;
            this.lblLibroPrestar.Location = new System.Drawing.Point(113, 18);
            this.lblLibroPrestar.Name = "lblLibroPrestar";
            this.lblLibroPrestar.Size = new System.Drawing.Size(75, 16);
            this.lblLibroPrestar.TabIndex = 7;
            this.lblLibroPrestar.Text = "ID del Libro";
            // 
            // txtIdUsuarioPrestar
            // 
            this.txtIdUsuarioPrestar.Location = new System.Drawing.Point(6, 36);
            this.txtIdUsuarioPrestar.Name = "txtIdUsuarioPrestar";
            this.txtIdUsuarioPrestar.Size = new System.Drawing.Size(100, 22);
            this.txtIdUsuarioPrestar.TabIndex = 6;
            // 
            // lblIdUsuarioPrestar
            // 
            this.lblIdUsuarioPrestar.AutoSize = true;
            this.lblIdUsuarioPrestar.Location = new System.Drawing.Point(6, 18);
            this.lblIdUsuarioPrestar.Name = "lblIdUsuarioPrestar";
            this.lblIdUsuarioPrestar.Size = new System.Drawing.Size(90, 16);
            this.lblIdUsuarioPrestar.TabIndex = 5;
            this.lblIdUsuarioPrestar.Text = "ID del Alumno";
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(182, 229);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarUsuario.TabIndex = 3;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.Location = new System.Drawing.Point(101, 229);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnEditarUsuario.TabIndex = 2;
            this.btnEditarUsuario.Text = "Editar";
            this.btnEditarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnAnadirUsuario
            // 
            this.btnAnadirUsuario.Location = new System.Drawing.Point(20, 229);
            this.btnAnadirUsuario.Name = "btnAnadirUsuario";
            this.btnAnadirUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnAnadirUsuario.TabIndex = 1;
            this.btnAnadirUsuario.Text = "Añadir";
            this.btnAnadirUsuario.UseVisualStyleBackColor = true;
            this.btnAnadirUsuario.Click += new System.EventHandler(this.btnAnadirUsuario_Click);
            // 
            // grpGEstionUsuarios
            // 
            this.grpGEstionUsuarios.Controls.Add(this.dgvUsuarios);
            this.grpGEstionUsuarios.Controls.Add(this.txtCorreoUsuario);
            this.grpGEstionUsuarios.Controls.Add(this.lblCorreoUsuario);
            this.grpGEstionUsuarios.Controls.Add(this.txtNombreUsuario);
            this.grpGEstionUsuarios.Controls.Add(this.lblNombreUsuario);
            this.grpGEstionUsuarios.Controls.Add(this.txtIdUsuario);
            this.grpGEstionUsuarios.Controls.Add(this.lblIdUsuario);
            this.grpGEstionUsuarios.Location = new System.Drawing.Point(6, 6);
            this.grpGEstionUsuarios.Name = "grpGEstionUsuarios";
            this.grpGEstionUsuarios.Size = new System.Drawing.Size(515, 217);
            this.grpGEstionUsuarios.TabIndex = 0;
            this.grpGEstionUsuarios.TabStop = false;
            this.grpGEstionUsuarios.Text = "Administrar Usuarios";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDUsuario,
            this.colNombre,
            this.colCorreo});
            this.dgvUsuarios.Location = new System.Drawing.Point(9, 66);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(491, 150);
            this.dgvUsuarios.TabIndex = 6;
            // 
            // colIDUsuario
            // 
            this.colIDUsuario.HeaderText = "ID";
            this.colIDUsuario.MinimumWidth = 6;
            this.colIDUsuario.Name = "colIDUsuario";
            this.colIDUsuario.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colCorreo
            // 
            this.colCorreo.HeaderText = "Correo";
            this.colCorreo.MinimumWidth = 6;
            this.colCorreo.Name = "colCorreo";
            this.colCorreo.ReadOnly = true;
            // 
            // txtCorreoUsuario
            // 
            this.txtCorreoUsuario.Location = new System.Drawing.Point(368, 37);
            this.txtCorreoUsuario.Name = "txtCorreoUsuario";
            this.txtCorreoUsuario.Size = new System.Drawing.Size(132, 22);
            this.txtCorreoUsuario.TabIndex = 5;
            // 
            // lblCorreoUsuario
            // 
            this.lblCorreoUsuario.AutoSize = true;
            this.lblCorreoUsuario.Location = new System.Drawing.Point(365, 18);
            this.lblCorreoUsuario.Name = "lblCorreoUsuario";
            this.lblCorreoUsuario.Size = new System.Drawing.Size(111, 16);
            this.lblCorreoUsuario.TabIndex = 4;
            this.lblCorreoUsuario.Text = "Correo Eletrónico";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(95, 36);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(267, 22);
            this.txtNombreUsuario.TabIndex = 3;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(91, 17);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(119, 16);
            this.lblNombreUsuario.TabIndex = 2;
            this.lblNombreUsuario.Text = "Nombre y Apellido";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(9, 37);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(80, 22);
            this.txtIdUsuario.TabIndex = 1;
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Location = new System.Drawing.Point(6, 18);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(70, 16);
            this.lblIdUsuario.TabIndex = 0;
            this.lblIdUsuario.Text = "ID Usuario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartUsuariosActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLibrosMasPrestados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.grpOperaciones.ResumeLayout(false);
            this.grpOperaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamosActivos)).EndInit();
            this.grpGEstionUsuarios.ResumeLayout(false);
            this.grpGEstionUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminarLibro;
        private System.Windows.Forms.Button btnEditarLibro;
        private System.Windows.Forms.Button btnAnadirLibro;
        private System.Windows.Forms.TextBox txtAnioLibro;
        private System.Windows.Forms.TextBox txtAutorLibro;
        private System.Windows.Forms.TextBox txtTituloLibro;
        private System.Windows.Forms.TextBox txtIdLibro;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUsuariosActivos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLibrosMasPrestados;
        private System.Windows.Forms.GroupBox grpGEstionUsuarios;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Button btnAnadirUsuario;
        private System.Windows.Forms.TextBox txtCorreoUsuario;
        private System.Windows.Forms.Label lblCorreoUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.GroupBox grpOperaciones;
        private System.Windows.Forms.Label lblIdUsuarioPrestar;
        private System.Windows.Forms.TextBox txtIdUsuarioPrestar;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Button btnPrestar;
        private System.Windows.Forms.TextBox txtIdLibroPrestar;
        private System.Windows.Forms.Label lblLibroPrestar;
        private System.Windows.Forms.DataGridView dgvPrestamosActivos;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLibroId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuarioID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.Button btnDocumentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnio;
    }
}

