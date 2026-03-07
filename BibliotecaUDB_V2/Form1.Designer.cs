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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnAnadirLibro = new System.Windows.Forms.Button();
            this.btnEditarLibro = new System.Windows.Forms.Button();
            this.btnEliminarLibro = new System.Windows.Forms.Button();
            this.chartLibrosMasPrestados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartUsuariosActivos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpGEstionUsuarios = new System.Windows.Forms.GroupBox();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblCorreoUsuario = new System.Windows.Forms.Label();
            this.txtCorreoUsuario = new System.Windows.Forms.TextBox();
            this.btnAnadirUsuario = new System.Windows.Forms.Button();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.grpOperaciones = new System.Windows.Forms.GroupBox();
            this.lblIdUsuarioPrestar = new System.Windows.Forms.Label();
            this.txtIdUsuarioPrestar = new System.Windows.Forms.TextBox();
            this.lblLibroPrestar = new System.Windows.Forms.Label();
            this.txtIdLibroPrestar = new System.Windows.Forms.TextBox();
            this.btnPrestar = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.dvgUsuarios = new System.Windows.Forms.DataGridView();
            this.dvgPrestamosActivos = new System.Windows.Forms.DataGridView();
            this.colIDUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLibroId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuarioID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgLibros = new System.Windows.Forms.DataGridView();
            this.btnDocumentacion = new System.Windows.Forms.Button();
            this.colIDLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLibrosMasPrestados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsuariosActivos)).BeginInit();
            this.grpGEstionUsuarios.SuspendLayout();
            this.grpOperaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPrestamosActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgLibros)).BeginInit();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dvgLibros);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Libros";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "ID";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(76, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Titulo";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(221, 21);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(139, 22);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Autor";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(366, 21);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(48, 22);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Año";
            // 
            // btnAnadirLibro
            // 
            this.btnAnadirLibro.Location = new System.Drawing.Point(41, 217);
            this.btnAnadirLibro.Name = "btnAnadirLibro";
            this.btnAnadirLibro.Size = new System.Drawing.Size(75, 23);
            this.btnAnadirLibro.TabIndex = 1;
            this.btnAnadirLibro.Text = "Añadir";
            this.btnAnadirLibro.UseVisualStyleBackColor = true;
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
            // btnEliminarLibro
            // 
            this.btnEliminarLibro.Location = new System.Drawing.Point(305, 217);
            this.btnEliminarLibro.Name = "btnEliminarLibro";
            this.btnEliminarLibro.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarLibro.TabIndex = 3;
            this.btnEliminarLibro.Text = "Eliminar";
            this.btnEliminarLibro.UseVisualStyleBackColor = true;
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
            this.chartUsuariosActivos.Click += new System.EventHandler(this.chartUsuariosActivos_Click);
            // 
            // grpGEstionUsuarios
            // 
            this.grpGEstionUsuarios.Controls.Add(this.dvgUsuarios);
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
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Location = new System.Drawing.Point(6, 18);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(70, 16);
            this.lblIdUsuario.TabIndex = 0;
            this.lblIdUsuario.Text = "ID Usuario";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(9, 37);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(80, 22);
            this.txtIdUsuario.TabIndex = 1;
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
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(95, 36);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(267, 22);
            this.txtNombreUsuario.TabIndex = 3;
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
            // txtCorreoUsuario
            // 
            this.txtCorreoUsuario.Location = new System.Drawing.Point(368, 37);
            this.txtCorreoUsuario.Name = "txtCorreoUsuario";
            this.txtCorreoUsuario.Size = new System.Drawing.Size(132, 22);
            this.txtCorreoUsuario.TabIndex = 5;
            // 
            // btnAnadirUsuario
            // 
            this.btnAnadirUsuario.Location = new System.Drawing.Point(20, 229);
            this.btnAnadirUsuario.Name = "btnAnadirUsuario";
            this.btnAnadirUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnAnadirUsuario.TabIndex = 1;
            this.btnAnadirUsuario.Text = "Añadir";
            this.btnAnadirUsuario.UseVisualStyleBackColor = true;
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
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(182, 229);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarUsuario.TabIndex = 3;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            // 
            // grpOperaciones
            // 
            this.grpOperaciones.Controls.Add(this.dvgPrestamosActivos);
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
            this.grpOperaciones.Enter += new System.EventHandler(this.grpOperaciones_Enter);
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
            // txtIdUsuarioPrestar
            // 
            this.txtIdUsuarioPrestar.Location = new System.Drawing.Point(6, 36);
            this.txtIdUsuarioPrestar.Name = "txtIdUsuarioPrestar";
            this.txtIdUsuarioPrestar.Size = new System.Drawing.Size(100, 22);
            this.txtIdUsuarioPrestar.TabIndex = 6;
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
            // txtIdLibroPrestar
            // 
            this.txtIdLibroPrestar.Location = new System.Drawing.Point(116, 36);
            this.txtIdLibroPrestar.Name = "txtIdLibroPrestar";
            this.txtIdLibroPrestar.Size = new System.Drawing.Size(100, 22);
            this.txtIdLibroPrestar.TabIndex = 8;
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
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(694, 229);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(152, 23);
            this.btnDevolver.TabIndex = 6;
            this.btnDevolver.Text = "Registar Devolución";
            this.btnDevolver.UseVisualStyleBackColor = true;
            // 
            // dvgUsuarios
            // 
            this.dvgUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDUsuario,
            this.colNombre,
            this.colCorreo});
            this.dvgUsuarios.Location = new System.Drawing.Point(9, 66);
            this.dvgUsuarios.Name = "dvgUsuarios";
            this.dvgUsuarios.ReadOnly = true;
            this.dvgUsuarios.RowHeadersWidth = 51;
            this.dvgUsuarios.RowTemplate.Height = 24;
            this.dvgUsuarios.Size = new System.Drawing.Size(491, 150);
            this.dvgUsuarios.TabIndex = 6;
            // 
            // dvgPrestamosActivos
            // 
            this.dvgPrestamosActivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgPrestamosActivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgPrestamosActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPrestamosActivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLibroId,
            this.colUsuarioID,
            this.colFecha,
            this.colEstado});
            this.dvgPrestamosActivos.Location = new System.Drawing.Point(0, 67);
            this.dvgPrestamosActivos.Name = "dvgPrestamosActivos";
            this.dvgPrestamosActivos.ReadOnly = true;
            this.dvgPrestamosActivos.RowHeadersWidth = 51;
            this.dvgPrestamosActivos.RowTemplate.Height = 24;
            this.dvgPrestamosActivos.Size = new System.Drawing.Size(326, 150);
            this.dvgPrestamosActivos.TabIndex = 9;
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
            // dvgLibros
            // 
            this.dvgLibros.AllowUserToAddRows = false;
            this.dvgLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDLibro,
            this.colTitulo,
            this.colAutor,
            this.colAnio});
            this.dvgLibros.Location = new System.Drawing.Point(4, 50);
            this.dvgLibros.Name = "dvgLibros";
            this.dvgLibros.ReadOnly = true;
            this.dvgLibros.RowHeadersWidth = 51;
            this.dvgLibros.RowTemplate.Height = 24;
            this.dvgLibros.Size = new System.Drawing.Size(480, 150);
            this.dvgLibros.TabIndex = 4;
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
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLibrosMasPrestados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsuariosActivos)).EndInit();
            this.grpGEstionUsuarios.ResumeLayout(false);
            this.grpGEstionUsuarios.PerformLayout();
            this.grpOperaciones.ResumeLayout(false);
            this.grpOperaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPrestamosActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgLibros)).EndInit();
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
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.DataGridView dvgPrestamosActivos;
        private System.Windows.Forms.DataGridView dvgUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLibroId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuarioID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridView dvgLibros;
        private System.Windows.Forms.Button btnDocumentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnio;
    }
}

