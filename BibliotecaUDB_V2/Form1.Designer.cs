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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLimpiarLibro = new System.Windows.Forms.Button();
            this.btnDocumentacion = new System.Windows.Forms.Button();
            this.chartUsuariosActivos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartLibrosMasPrestados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnEliminarLibro = new System.Windows.Forms.Button();
            this.btnEditarLibro = new System.Windows.Forms.Button();
            this.btnAnadirLibro = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btnLimpiarUsuario = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.btnPrestar = new System.Windows.Forms.Button();
            this.grpOperaciones = new System.Windows.Forms.GroupBox();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.colLibroId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuarioID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIdLibroPrestamo = new System.Windows.Forms.TextBox();
            this.lblLibroPrestar = new System.Windows.Forms.Label();
            this.txtIdUsuarioPrestamo = new System.Windows.Forms.TextBox();
            this.lblIdUsuarioPrestar = new System.Windows.Forms.Label();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.btnAnadirUsuario = new System.Windows.Forms.Button();
            this.grpGEstionUsuarios = new System.Windows.Forms.GroupBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.txtCorreoUsuario = new System.Windows.Forms.TextBox();
            this.lblCorreoUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.colIDUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsuariosActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLibrosMasPrestados)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.grpOperaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
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
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1144, 630);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.btnLimpiarLibro);
            this.tabPage1.Controls.Add(this.btnDocumentacion);
            this.tabPage1.Controls.Add(this.chartUsuariosActivos);
            this.tabPage1.Controls.Add(this.chartLibrosMasPrestados);
            this.tabPage1.Controls.Add(this.btnEliminarLibro);
            this.tabPage1.Controls.Add(this.btnEditarLibro);
            this.tabPage1.Controls.Add(this.btnAnadirLibro);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1136, 594);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "📊 Dashboard y Libros";
            // 
            // btnLimpiarLibro
            // 
            this.btnLimpiarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarLibro.Location = new System.Drawing.Point(251, 367);
            this.btnLimpiarLibro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpiarLibro.Name = "btnLimpiarLibro";
            this.btnLimpiarLibro.Padding = new System.Windows.Forms.Padding(5);
            this.btnLimpiarLibro.Size = new System.Drawing.Size(129, 46);
            this.btnLimpiarLibro.TabIndex = 7;
            this.btnLimpiarLibro.Text = "Limpiar campos";
            this.btnLimpiarLibro.UseVisualStyleBackColor = true;
            this.btnLimpiarLibro.Click += new System.EventHandler(this.btnLimpiarLibro_Click);
            // 
            // btnDocumentacion
            // 
            this.btnDocumentacion.Location = new System.Drawing.Point(22, 513);
            this.btnDocumentacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDocumentacion.Name = "btnDocumentacion";
            this.btnDocumentacion.Size = new System.Drawing.Size(137, 33);
            this.btnDocumentacion.TabIndex = 6;
            this.btnDocumentacion.Text = "Documentacion";
            this.btnDocumentacion.UseVisualStyleBackColor = true;
            // 
            // chartUsuariosActivos
            // 
            chartArea5.Name = "ChartArea1";
            this.chartUsuariosActivos.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartUsuariosActivos.Legends.Add(legend5);
            this.chartUsuariosActivos.Location = new System.Drawing.Point(732, 310);
            this.chartUsuariosActivos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartUsuariosActivos.Name = "chartUsuariosActivos";
            this.chartUsuariosActivos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartUsuariosActivos.Series.Add(series5);
            this.chartUsuariosActivos.Size = new System.Drawing.Size(396, 269);
            this.chartUsuariosActivos.TabIndex = 5;
            this.chartUsuariosActivos.Text = "Usuarios Mas activos";
            title5.Name = "Title1";
            title5.Text = "Usuarios mas Activos";
            this.chartUsuariosActivos.Titles.Add(title5);
            // 
            // chartLibrosMasPrestados
            // 
            chartArea6.Name = "ChartArea1";
            this.chartLibrosMasPrestados.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartLibrosMasPrestados.Legends.Add(legend6);
            this.chartLibrosMasPrestados.Location = new System.Drawing.Point(732, 34);
            this.chartLibrosMasPrestados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartLibrosMasPrestados.Name = "chartLibrosMasPrestados";
            this.chartLibrosMasPrestados.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartLibrosMasPrestados.Series.Add(series6);
            this.chartLibrosMasPrestados.Size = new System.Drawing.Size(396, 267);
            this.chartLibrosMasPrestados.TabIndex = 4;
            this.chartLibrosMasPrestados.Text = "Libros Mas Prestados";
            title6.Name = "Title1";
            title6.Text = "Libros mas Prestados";
            this.chartLibrosMasPrestados.Titles.Add(title6);
            // 
            // btnEliminarLibro
            // 
            this.btnEliminarLibro.BackColor = System.Drawing.Color.Red;
            this.btnEliminarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarLibro.Location = new System.Drawing.Point(415, 367);
            this.btnEliminarLibro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminarLibro.Name = "btnEliminarLibro";
            this.btnEliminarLibro.Padding = new System.Windows.Forms.Padding(5);
            this.btnEliminarLibro.Size = new System.Drawing.Size(92, 46);
            this.btnEliminarLibro.TabIndex = 3;
            this.btnEliminarLibro.Text = "Eliminar";
            this.btnEliminarLibro.UseVisualStyleBackColor = false;
            this.btnEliminarLibro.Click += new System.EventHandler(this.btnEliminarLibro_Click);
            // 
            // btnEditarLibro
            // 
            this.btnEditarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarLibro.Location = new System.Drawing.Point(98, 367);
            this.btnEditarLibro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditarLibro.Name = "btnEditarLibro";
            this.btnEditarLibro.Padding = new System.Windows.Forms.Padding(5);
            this.btnEditarLibro.Size = new System.Drawing.Size(146, 46);
            this.btnEditarLibro.TabIndex = 2;
            this.btnEditarLibro.Text = "Guardar cambios";
            this.btnEditarLibro.UseVisualStyleBackColor = true;
            this.btnEditarLibro.Click += new System.EventHandler(this.btnEditarLibro_Click);
            // 
            // btnAnadirLibro
            // 
            this.btnAnadirLibro.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAnadirLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnadirLibro.Location = new System.Drawing.Point(7, 367);
            this.btnAnadirLibro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnadirLibro.Name = "btnAnadirLibro";
            this.btnAnadirLibro.Padding = new System.Windows.Forms.Padding(5);
            this.btnAnadirLibro.Size = new System.Drawing.Size(84, 46);
            this.btnAnadirLibro.TabIndex = 1;
            this.btnAnadirLibro.Text = "Añadir";
            this.btnAnadirLibro.UseVisualStyleBackColor = false;
            this.btnAnadirLibro.Click += new System.EventHandler(this.btnAnadirLibro_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvLibros);
            this.groupBox1.Controls.Add(this.txtAnioLibro);
            this.groupBox1.Controls.Add(this.txtAutorLibro);
            this.groupBox1.Controls.Add(this.txtTituloLibro);
            this.groupBox1.Controls.Add(this.txtIdLibro);
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(722, 354);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Libros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Autor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Titulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // dgvLibros
            // 
            this.dgvLibros.AllowUserToAddRows = false;
            this.dgvLibros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibros.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDLibro,
            this.colTitulo,
            this.colAutor,
            this.colAnio});
            this.dgvLibros.Location = new System.Drawing.Point(7, 93);
            this.dgvLibros.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.ReadOnly = true;
            this.dgvLibros.RowHeadersWidth = 51;
            this.dgvLibros.RowTemplate.Height = 24;
            this.dgvLibros.Size = new System.Drawing.Size(709, 252);
            this.dgvLibros.TabIndex = 4;
            this.dgvLibros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibros_CellClick);
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
            this.txtAnioLibro.Location = new System.Drawing.Point(469, 53);
            this.txtAnioLibro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAnioLibro.Name = "txtAnioLibro";
            this.txtAnioLibro.Size = new System.Drawing.Size(54, 30);
            this.txtAnioLibro.TabIndex = 3;
            // 
            // txtAutorLibro
            // 
            this.txtAutorLibro.Location = new System.Drawing.Point(306, 53);
            this.txtAutorLibro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAutorLibro.Name = "txtAutorLibro";
            this.txtAutorLibro.Size = new System.Drawing.Size(156, 30);
            this.txtAutorLibro.TabIndex = 2;
            // 
            // txtTituloLibro
            // 
            this.txtTituloLibro.Location = new System.Drawing.Point(89, 53);
            this.txtTituloLibro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTituloLibro.Name = "txtTituloLibro";
            this.txtTituloLibro.Size = new System.Drawing.Size(206, 30);
            this.txtTituloLibro.TabIndex = 1;
            // 
            // txtIdLibro
            // 
            this.txtIdLibro.Location = new System.Drawing.Point(7, 53);
            this.txtIdLibro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIdLibro.Name = "txtIdLibro";
            this.txtIdLibro.Size = new System.Drawing.Size(75, 30);
            this.txtIdLibro.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.btnLimpiarUsuario);
            this.tabPage2.Controls.Add(this.btnDevolver);
            this.tabPage2.Controls.Add(this.btnPrestar);
            this.tabPage2.Controls.Add(this.grpOperaciones);
            this.tabPage2.Controls.Add(this.btnEliminarUsuario);
            this.tabPage2.Controls.Add(this.btnEditarUsuario);
            this.tabPage2.Controls.Add(this.btnAnadirUsuario);
            this.tabPage2.Controls.Add(this.grpGEstionUsuarios);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(1136, 594);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "👥 Usuarios y Préstamos";
            // 
            // btnLimpiarUsuario
            // 
            this.btnLimpiarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarUsuario.Location = new System.Drawing.Point(296, 331);
            this.btnLimpiarUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpiarUsuario.Name = "btnLimpiarUsuario";
            this.btnLimpiarUsuario.Padding = new System.Windows.Forms.Padding(5);
            this.btnLimpiarUsuario.Size = new System.Drawing.Size(139, 43);
            this.btnLimpiarUsuario.TabIndex = 7;
            this.btnLimpiarUsuario.Text = "Limpiar Campos";
            this.btnLimpiarUsuario.UseVisualStyleBackColor = true;
            this.btnLimpiarUsuario.Click += new System.EventHandler(this.btnLimpiarUsuario_Click);
            // 
            // btnDevolver
            // 
            this.btnDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolver.Location = new System.Drawing.Point(839, 331);
            this.btnDevolver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Padding = new System.Windows.Forms.Padding(5);
            this.btnDevolver.Size = new System.Drawing.Size(185, 45);
            this.btnDevolver.TabIndex = 6;
            this.btnDevolver.Text = "Registar Devolución";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // btnPrestar
            // 
            this.btnPrestar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestar.Location = new System.Drawing.Point(670, 331);
            this.btnPrestar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrestar.Name = "btnPrestar";
            this.btnPrestar.Padding = new System.Windows.Forms.Padding(5);
            this.btnPrestar.Size = new System.Drawing.Size(168, 45);
            this.btnPrestar.TabIndex = 5;
            this.btnPrestar.Text = "Registrar Préstamo";
            this.btnPrestar.UseVisualStyleBackColor = true;
            this.btnPrestar.Click += new System.EventHandler(this.btnPrestar_Click);
            // 
            // grpOperaciones
            // 
            this.grpOperaciones.Controls.Add(this.dgvPrestamos);
            this.grpOperaciones.Controls.Add(this.txtIdLibroPrestamo);
            this.grpOperaciones.Controls.Add(this.lblLibroPrestar);
            this.grpOperaciones.Controls.Add(this.txtIdUsuarioPrestamo);
            this.grpOperaciones.Controls.Add(this.lblIdUsuarioPrestar);
            this.grpOperaciones.Location = new System.Drawing.Point(670, 10);
            this.grpOperaciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpOperaciones.Name = "grpOperaciones";
            this.grpOperaciones.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpOperaciones.Size = new System.Drawing.Size(456, 312);
            this.grpOperaciones.TabIndex = 4;
            this.grpOperaciones.TabStop = false;
            this.grpOperaciones.Text = "Gestion de Préstamos";
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestamos.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLibroId,
            this.colUsuarioID,
            this.colFecha,
            this.colEstado});
            this.dgvPrestamos.Location = new System.Drawing.Point(7, 96);
            this.dgvPrestamos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.ReadOnly = true;
            this.dgvPrestamos.RowHeadersWidth = 51;
            this.dgvPrestamos.RowTemplate.Height = 24;
            this.dgvPrestamos.Size = new System.Drawing.Size(435, 214);
            this.dgvPrestamos.TabIndex = 9;
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
            // txtIdLibroPrestamo
            // 
            this.txtIdLibroPrestamo.Location = new System.Drawing.Point(143, 53);
            this.txtIdLibroPrestamo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIdLibroPrestamo.Name = "txtIdLibroPrestamo";
            this.txtIdLibroPrestamo.Size = new System.Drawing.Size(112, 30);
            this.txtIdLibroPrestamo.TabIndex = 8;
            // 
            // lblLibroPrestar
            // 
            this.lblLibroPrestar.AutoSize = true;
            this.lblLibroPrestar.Location = new System.Drawing.Point(139, 27);
            this.lblLibroPrestar.Name = "lblLibroPrestar";
            this.lblLibroPrestar.Size = new System.Drawing.Size(98, 23);
            this.lblLibroPrestar.TabIndex = 7;
            this.lblLibroPrestar.Text = "ID del Libro";
            // 
            // txtIdUsuarioPrestamo
            // 
            this.txtIdUsuarioPrestamo.Location = new System.Drawing.Point(7, 52);
            this.txtIdUsuarioPrestamo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIdUsuarioPrestamo.Name = "txtIdUsuarioPrestamo";
            this.txtIdUsuarioPrestamo.Size = new System.Drawing.Size(120, 30);
            this.txtIdUsuarioPrestamo.TabIndex = 6;
            // 
            // lblIdUsuarioPrestar
            // 
            this.lblIdUsuarioPrestar.AutoSize = true;
            this.lblIdUsuarioPrestar.Location = new System.Drawing.Point(7, 26);
            this.lblIdUsuarioPrestar.Name = "lblIdUsuarioPrestar";
            this.lblIdUsuarioPrestar.Size = new System.Drawing.Size(120, 23);
            this.lblIdUsuarioPrestar.TabIndex = 5;
            this.lblIdUsuarioPrestar.Text = "ID del Alumno";
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.Red;
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(457, 331);
            this.btnEliminarUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Padding = new System.Windows.Forms.Padding(5);
            this.btnEliminarUsuario.Size = new System.Drawing.Size(92, 43);
            this.btnEliminarUsuario.TabIndex = 3;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarUsuario.Location = new System.Drawing.Point(128, 329);
            this.btnEditarUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Padding = new System.Windows.Forms.Padding(5);
            this.btnEditarUsuario.Size = new System.Drawing.Size(150, 45);
            this.btnEditarUsuario.TabIndex = 2;
            this.btnEditarUsuario.Text = "Guardar Cambios";
            this.btnEditarUsuario.UseVisualStyleBackColor = true;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // btnAnadirUsuario
            // 
            this.btnAnadirUsuario.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAnadirUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnadirUsuario.Location = new System.Drawing.Point(22, 329);
            this.btnAnadirUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnadirUsuario.Name = "btnAnadirUsuario";
            this.btnAnadirUsuario.Padding = new System.Windows.Forms.Padding(5);
            this.btnAnadirUsuario.Size = new System.Drawing.Size(90, 45);
            this.btnAnadirUsuario.TabIndex = 1;
            this.btnAnadirUsuario.Text = "Añadir";
            this.btnAnadirUsuario.UseVisualStyleBackColor = false;
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
            this.grpGEstionUsuarios.Location = new System.Drawing.Point(7, 9);
            this.grpGEstionUsuarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpGEstionUsuarios.Name = "grpGEstionUsuarios";
            this.grpGEstionUsuarios.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpGEstionUsuarios.Size = new System.Drawing.Size(631, 312);
            this.grpGEstionUsuarios.TabIndex = 0;
            this.grpGEstionUsuarios.TabStop = false;
            this.grpGEstionUsuarios.Text = "Administrar Usuarios";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDUsuario,
            this.colNombre,
            this.colCorreo});
            this.dgvUsuarios.Location = new System.Drawing.Point(7, 95);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(618, 216);
            this.dgvUsuarios.TabIndex = 6;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // txtCorreoUsuario
            // 
            this.txtCorreoUsuario.Location = new System.Drawing.Point(414, 53);
            this.txtCorreoUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCorreoUsuario.Name = "txtCorreoUsuario";
            this.txtCorreoUsuario.Size = new System.Drawing.Size(148, 30);
            this.txtCorreoUsuario.TabIndex = 5;
            // 
            // lblCorreoUsuario
            // 
            this.lblCorreoUsuario.AutoSize = true;
            this.lblCorreoUsuario.Location = new System.Drawing.Point(411, 26);
            this.lblCorreoUsuario.Name = "lblCorreoUsuario";
            this.lblCorreoUsuario.Size = new System.Drawing.Size(143, 23);
            this.lblCorreoUsuario.TabIndex = 4;
            this.lblCorreoUsuario.Text = "Correo Eletrónico";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(107, 52);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(300, 30);
            this.txtNombreUsuario.TabIndex = 3;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(102, 24);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(153, 23);
            this.lblNombreUsuario.TabIndex = 2;
            this.lblNombreUsuario.Text = "Nombre y Apellido";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(10, 53);
            this.txtIdUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(90, 30);
            this.txtIdUsuario.TabIndex = 1;
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Location = new System.Drawing.Point(7, 26);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(90, 23);
            this.lblIdUsuario.TabIndex = 0;
            this.lblIdUsuario.Text = "ID Usuario";
            // 
            // colIDUsuario
            // 
            this.colIDUsuario.FillWeight = 30F;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1144, 630);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Biblioteca UDB";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
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
        private System.Windows.Forms.TextBox txtIdUsuarioPrestamo;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Button btnPrestar;
        private System.Windows.Forms.TextBox txtIdLibroPrestamo;
        private System.Windows.Forms.Label lblLibroPrestar;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.DataGridView dgvUsuarios;
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
        private System.Windows.Forms.Button btnLimpiarLibro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiarUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreo;
    }
}

