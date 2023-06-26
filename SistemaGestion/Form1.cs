using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaGestion
{
    public partial class Form1 : Form
    {
        // Declaraci�n de variables y controles
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnEscanear;
        private Button btnTeslaMasKm;
        private ComboBox comboBoxTipoProducto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private List<Producto> productos;
        private TextBox textBoxA�o;
        private TextBox textBoxColor;
        private TextBox textBoxDue�o;
        private TextBox textBoxUnidadDeUSo;
        private ToolTip toolTip;
        private Producto producto;
        private DataGridView dataGridView1;
        private BindingSource spaceXFalcon9BindingSource;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn a�oDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unidadDeUsoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn due�oDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn autonomiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cargaRestanteDataGridViewTextBoxColumn;
        private System.ComponentModel.IContainer components;

        public Form1()
        {
            InitializeComponent();
            productos = new List<Producto>();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Agregar productos a la lista
            productos.Add(new TeslaModelX() { Modelo = "Tesla Model X", A�o = 2022, Color = "Rojo", Due�o = "John Doe", UnidadDeUso = 616 });
            productos.Add(new TeslaModelX() { Modelo = "Tesla Model X", A�o = 2022, Color = "Rojo", Due�o = "John Doe", UnidadDeUso = 5000 });
            productos.Add(new TeslaModelS() { Modelo = "Tesla Model S", A�o = 2021, Color = "Azul", Due�o = "Jane Smith", UnidadDeUso = 4400 });
            productos.Add(new TeslaCybertruck() { Modelo = "Tesla Cybertruck", A�o = 2023, Color = "Negro", Due�o = "Bob Johnson", UnidadDeUso = 450 });
            productos.Add(new SpaceXStarship() { Modelo = "SpaceX Starship", A�o = 2023, Color = "Blanco", Due�o = "SpaceX", UnidadDeUso = 1984 });
            productos.Add(new SpaceXFalcon9() { Modelo = "SpaceX Falcon 9", A�o = 2022, Color = "Gris", Due�o = "Microsoft", UnidadDeUso = 2400 });
            productos.Add(new SpaceXFalcon9() { Modelo = "SpaceX Falcon 9", A�o = 2022, Color = "Gris", Due�o = "Microsoft", UnidadDeUso = 100 });
            productos.Add(new TeslaModelX() { Modelo = "Tesla Model X", A�o = 2022, Color = "Blanco", Due�o = "Jane Doe", UnidadDeUso = 800 });
            productos.Add(new TeslaModelX() { Modelo = "Tesla Model X", A�o = 2022, Color = "Negro", Due�o = "John Smith", UnidadDeUso = 2000 });
            productos.Add(new TeslaModelS() { Modelo = "Tesla Model S", A�o = 2021, Color = "Rojo", Due�o = "Bob Doe", UnidadDeUso = 3500 });
            productos.Add(new TeslaCybertruck() { Modelo = "Tesla Cybertruck", A�o = 2023, Color = "Gris", Due�o = "Alice Johnson", UnidadDeUso = 1000 });
            productos.Add(new SpaceXStarship() { Modelo = "SpaceX Starship", A�o = 2023, Color = "Plateado", Due�o = "NASA", UnidadDeUso = 5000 });
            productos.Add(new SpaceXFalcon9() { Modelo = "SpaceX Falcon 9", A�o = 2022, Color = "Blanco", Due�o = "Amazon", UnidadDeUso = 1500 });
            productos.Add(new TeslaModelX() { Modelo = "Tesla Model X", A�o = 2022, Color = "Azul", Due�o = "Emily Brown", UnidadDeUso = 1200 });
            productos.Add(new TeslaModelX() { Modelo = "Tesla Model X", A�o = 2022, Color = "Negro", Due�o = "Daniel Johnson", UnidadDeUso = 2800 });
            productos.Add(new TeslaModelS() { Modelo = "Tesla Model S", A�o = 2021, Color = "Gris", Due�o = "Sophia Davis", UnidadDeUso = 1900 });
            productos.Add(new TeslaCybertruck() { Modelo = "Tesla Cybertruck", A�o = 2023, Color = "Blanco", Due�o = "Robert Smith", UnidadDeUso = 800 });
            productos.Add(new SpaceXStarship() { Modelo = "SpaceX Starship", A�o = 2023, Color = "Plateado", Due�o = "NASA", UnidadDeUso = 4000 });
            productos.Add(new SpaceXFalcon9() { Modelo = "SpaceX Falcon 9", A�o = 2022, Color = "Rojo", Due�o = "Apple", UnidadDeUso = 2200 });

            // Mostrar los productos en el ListBox
            MostrarProductosEnLista();

            // Configurar el ComboBox con los tipos de productos
            comboBoxTipoProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipoProducto.Items.Add("Tesla Model X");
            comboBoxTipoProducto.Items.Add("Tesla Model S");
            comboBoxTipoProducto.Items.Add("Tesla Cybertruck");
            comboBoxTipoProducto.Items.Add("SpaceX Starship");
            comboBoxTipoProducto.Items.Add("SpaceX Falcon 9");
        }

        private void MostrarProductosEnLista()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = productos;

            // Centrar el texto en el titulo y celdas del datagrid
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.BorderStyle = BorderStyle.None;
            // Quita las "miniceldas" vac�as a la izquierda de cada fila
            dataGridView1.RowHeadersVisible = false;
            // Quita la franja gris al final del datagrid
            dataGridView1.BackgroundColor = dataGridView1.DefaultCellStyle.BackColor;


            // Para que no tenga ninguna fila marcada por defecto
            dataGridView1.ClearSelection();
            // Le cambio el nombre al header del datagrid
            FormatearHeader();
            // Establecer todas las columnas del DataGridView como de solo lectura y deshabilitar el cambio de tama�o
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.ReadOnly = true;
                column.Resizable = DataGridViewTriState.False;
            }
            // Deshabilitar el cambio de tama�o de todas las filas del DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Resizable = DataGridViewTriState.False;
            }
        }

        private void FormatearHeader()
        {
            // Asignar los nombres a las columnas del DataGridView
            Modelo.HeaderText = "Modelo";
            a�oDataGridViewTextBoxColumn.HeaderText = "A�o";
            unidadDeUsoDataGridViewTextBoxColumn.HeaderText = "Kil�metros/Horas de vuelo";
            colorDataGridViewTextBoxColumn.HeaderText = "Color";
            due�oDataGridViewTextBoxColumn.HeaderText = "Due�o";
            autonomiaDataGridViewTextBoxColumn.HeaderText = "Autonom�a (Km/Hs)";
            serviceDataGridViewTextBoxColumn.HeaderText = "Service (Km/Hs)";
            cargaRestanteDataGridViewTextBoxColumn.HeaderText = "Bater�a/Combustible restante (%)";
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string tipoProducto = comboBoxTipoProducto.SelectedItem?.ToString();
            string a�o = textBoxA�o.Text;
            string unidadDeUso = textBoxUnidadDeUSo.Text;
            string color = textBoxColor.Text;
            string due�o = textBoxDue�o.Text;

            // Validar que todos los campos est�n completos
            if (string.IsNullOrEmpty(tipoProducto) || string.IsNullOrEmpty(a�o) ||
                string.IsNullOrEmpty(unidadDeUso) || string.IsNullOrEmpty(color) ||
                string.IsNullOrEmpty(due�o))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de agregar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear el nuevo producto seg�n el tipo seleccionado
            Producto nuevoProducto = null;

            switch (tipoProducto)
            {
                case "Tesla Model X":
                    nuevoProducto = new TeslaModelX();
                    break;
                case "Tesla Model S":
                    nuevoProducto = new TeslaModelS();
                    break;
                case "Tesla Cybertruck":
                    nuevoProducto = new TeslaCybertruck();
                    break;
                case "SpaceX Starship":
                    nuevoProducto = new SpaceXStarship();
                    break;
                case "SpaceX Falcon 9":
                    nuevoProducto = new SpaceXFalcon9();
                    break;
            }

            if (nuevoProducto != null)
            {
                // Asignar los valores ingresados al nuevo producto

                nuevoProducto.Modelo = tipoProducto;
                nuevoProducto.A�o = int.Parse(a�o);
                nuevoProducto.Color = color;
                nuevoProducto.Due�o = due�o;
                nuevoProducto.UnidadDeUso = int.Parse(unidadDeUso);

                // Agregar el nuevo producto a la lista
                productos.Add(nuevoProducto);

                // Mostrar la lista actualizada de productos
                MostrarProductosEnLista();

                // Limpiar los campos de entrada
                LimpiarCamposEntrada();
            }
        }

        private void LimpiarCamposEntrada()
        {
            comboBoxTipoProducto.SelectedIndex = -1;
            textBoxA�o.Clear();
            textBoxUnidadDeUSo.Clear();
            textBoxColor.Clear();
            textBoxDue�o.Clear();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (productos.Count > 0)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int rowIndex = dataGridView1.SelectedRows[0].Index;
                    if (rowIndex != -1)
                    {
                        string modelo = dataGridView1.Rows[rowIndex].Cells["Modelo"].Value.ToString();

                        if (modelo.StartsWith("Tesla"))
                        {
                            productos.RemoveAt(rowIndex);
                            MostrarProductosEnLista();
                            MessageBox.Show("Tesla eliminado correctamente.");
                        }
                        else if (modelo.StartsWith("SpaceX"))
                        {
                            productos.RemoveAt(rowIndex);
                            MostrarProductosEnLista();
                            MessageBox.Show("SpaceX eliminado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo determinar el tipo de producto.");
                        }

                        // Restablecer el objeto "producto" a nulo para que al escanear sin seleccionar tome este resultado
                        producto = null;
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona un Tesla o SpaceX para eliminar.");
                }
            }
            else
            {
                MessageBox.Show("No hay Teslas o SpaceX en la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnTeslaMasKm_Click(object sender, EventArgs e)
        {
            if (productos.Count > 0)
            {
                Producto teslaConMasKm = ObtenerTeslaConMasKilometros();
                if (teslaConMasKm != null)
                {
                    MessageBox.Show(teslaConMasKm.ObtenerInformacion());
                }
                else
                {
                    MessageBox.Show("No se encontr� ning�n Tesla en la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No hay Teslas en la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView1.ClearSelection();
        }


        private void LstProductos_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Verificar si hay filas seleccionadas
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                if (selectedIndex >= 0 && selectedIndex < productos.Count)
                {
                    producto = productos[selectedIndex];
                }
            }
        }


        private void BtnEscanear_Click(object sender, EventArgs e)
        {
            if (producto != null)
            {
                // Obtener el producto seleccionado
                producto.RealizarEscaneo();
                // Quitar la selecci�n del producto en el datagrid
                dataGridView1.ClearSelection();
            }
            else
            {
                // Manejar el caso cuando el objeto es nulo
                MessageBox.Show("Seleccionar el producto de la lista");
            }
        }

        private Producto ObtenerTeslaConMasKilometros()
        {
            Producto teslaConMasKm = null;
            int maxKilometros = 0;
            int rowIndex = -1; // Variable para almacenar el �ndice de la fila a resaltar

            // Recorrer la lista para obtener el Tesla con m�s kil�metros
            for (int i = 0; i < productos.Count; i++)
            {
                Producto producto = productos[i];
                if (producto is TeslaModelX || producto is TeslaModelS || producto is TeslaCybertruck)
                {
                    if (producto.UnidadDeUso > maxKilometros)
                    {
                        maxKilometros = producto.UnidadDeUso;
                        teslaConMasKm = producto;
                        rowIndex = i; // Guardar el �ndice de la fila a resaltar
                    }
                }
            }

            if (rowIndex != -1)
            {
                // Resaltar la fila correspondiente al Tesla con m�s kil�metros
                dataGridView1.ClearSelection();
                dataGridView1.Rows[rowIndex].Selected = true;
                dataGridView1.FirstDisplayedScrollingRowIndex = rowIndex;
            }

            return teslaConMasKm;
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnAgregar = new Button();
            btnEliminar = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnTeslaMasKm = new Button();
            btnEscanear = new Button();
            comboBoxTipoProducto = new ComboBox();
            label1 = new Label();
            textBoxA�o = new TextBox();
            label2 = new Label();
            textBoxUnidadDeUSo = new TextBox();
            textBoxColor = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxDue�o = new TextBox();
            label5 = new Label();
            toolTip = new ToolTip(components);
            dataGridView1 = new DataGridView();
            Modelo = new DataGridViewTextBoxColumn();
            a�oDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unidadDeUsoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            colorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            due�oDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            autonomiaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            serviceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cargaRestanteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            spaceXFalcon9BindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spaceXFalcon9BindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(688, 193);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(151, 29);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar Producto";
            toolTip.SetToolTip(btnAgregar, "Agrega un producto completando los datos");
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += BtnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(348, 43);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(163, 29);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar Producto";
            toolTip.SetToolTip(btnEliminar, "Selecciona un producto de la lista para eliminarlo");
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += BtnEliminar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(23, 104);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(207, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // btnTeslaMasKm
            // 
            btnTeslaMasKm.Location = new Point(348, 93);
            btnTeslaMasKm.Name = "btnTeslaMasKm";
            btnTeslaMasKm.Size = new Size(163, 29);
            btnTeslaMasKm.TabIndex = 5;
            btnTeslaMasKm.Text = "Tesla con m�s Km";
            toolTip.SetToolTip(btnTeslaMasKm, "Clic para mostrar el Tesla con m�s km");
            btnTeslaMasKm.UseVisualStyleBackColor = true;
            btnTeslaMasKm.Click += BtnTeslaMasKm_Click;
            // 
            // btnEscanear
            // 
            btnEscanear.Location = new Point(348, 143);
            btnEscanear.Name = "btnEscanear";
            btnEscanear.Size = new Size(163, 29);
            btnEscanear.TabIndex = 6;
            btnEscanear.Text = "Escanear Veh�culo";
            toolTip.SetToolTip(btnEscanear, "Selecciona un producto de la lista para escanearlo");
            btnEscanear.UseVisualStyleBackColor = true;
            btnEscanear.Click += BtnEscanear_Click;
            // 
            // comboBoxTipoProducto
            // 
            comboBoxTipoProducto.FormattingEnabled = true;
            comboBoxTipoProducto.Location = new Point(688, 24);
            comboBoxTipoProducto.Name = "comboBoxTipoProducto";
            comboBoxTipoProducto.RightToLeft = RightToLeft.No;
            comboBoxTipoProducto.Size = new Size(151, 33);
            comboBoxTipoProducto.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(613, 27);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 8;
            label1.Text = "Producto";
            // 
            // textBoxA�o
            // 
            textBoxA�o.Location = new Point(688, 57);
            textBoxA�o.Name = "textBoxA�o";
            textBoxA�o.Size = new Size(151, 31);
            textBoxA�o.TabIndex = 9;
            textBoxA�o.KeyPress += textBoxA�o_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(646, 60);
            label2.Name = "label2";
            label2.Size = new Size(45, 25);
            label2.TabIndex = 10;
            label2.Text = "A�o";
            // 
            // textBoxUnidadDeUSo
            // 
            textBoxUnidadDeUSo.Location = new Point(688, 90);
            textBoxUnidadDeUSo.Name = "textBoxUnidadDeUSo";
            textBoxUnidadDeUSo.Size = new Size(151, 31);
            textBoxUnidadDeUSo.TabIndex = 11;
            textBoxUnidadDeUSo.KeyPress += textBoxUnidadDeUSo_KeyPress;
            // 
            // textBoxColor
            // 
            textBoxColor.Location = new Point(688, 123);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(151, 31);
            textBoxColor.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(628, 93);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 13;
            label3.Text = "Km/Hs";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(637, 126);
            label4.Name = "label4";
            label4.Size = new Size(55, 25);
            label4.TabIndex = 14;
            label4.Text = "Color";
            // 
            // textBoxDue�o
            // 
            textBoxDue�o.Location = new Point(688, 156);
            textBoxDue�o.Name = "textBoxDue�o";
            textBoxDue�o.Size = new Size(151, 31);
            textBoxDue�o.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(629, 159);
            label5.Name = "label5";
            label5.Size = new Size(65, 25);
            label5.TabIndex = 16;
            label5.Text = "Due�o";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Modelo, a�oDataGridViewTextBoxColumn, unidadDeUsoDataGridViewTextBoxColumn, colorDataGridViewTextBoxColumn, due�oDataGridViewTextBoxColumn, autonomiaDataGridViewTextBoxColumn, serviceDataGridViewTextBoxColumn, cargaRestanteDataGridViewTextBoxColumn });
            dataGridView1.DataSource = spaceXFalcon9BindingSource;
            dataGridView1.Location = new Point(12, 260);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 20;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowCellErrors = false;
            dataGridView1.Size = new Size(973, 241);
            dataGridView1.TabIndex = 17;
            dataGridView1.MouseClick += LstProductos_MouseClick;
            // 
            // Modelo
            // 
            Modelo.DataPropertyName = "Modelo";
            Modelo.HeaderText = "Producto";
            Modelo.MinimumWidth = 8;
            Modelo.Name = "Modelo";
            // 
            // a�oDataGridViewTextBoxColumn
            // 
            a�oDataGridViewTextBoxColumn.DataPropertyName = "A�o";
            a�oDataGridViewTextBoxColumn.HeaderText = "A�o";
            a�oDataGridViewTextBoxColumn.MinimumWidth = 8;
            a�oDataGridViewTextBoxColumn.Name = "a�oDataGridViewTextBoxColumn";
            // 
            // unidadDeUsoDataGridViewTextBoxColumn
            // 
            unidadDeUsoDataGridViewTextBoxColumn.DataPropertyName = "UnidadDeUso";
            unidadDeUsoDataGridViewTextBoxColumn.HeaderText = "UnidadDeUso";
            unidadDeUsoDataGridViewTextBoxColumn.MinimumWidth = 8;
            unidadDeUsoDataGridViewTextBoxColumn.Name = "unidadDeUsoDataGridViewTextBoxColumn";
            // 
            // colorDataGridViewTextBoxColumn
            // 
            colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            colorDataGridViewTextBoxColumn.HeaderText = "Color";
            colorDataGridViewTextBoxColumn.MinimumWidth = 8;
            colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            // 
            // due�oDataGridViewTextBoxColumn
            // 
            due�oDataGridViewTextBoxColumn.DataPropertyName = "Due�o";
            due�oDataGridViewTextBoxColumn.HeaderText = "Due�o";
            due�oDataGridViewTextBoxColumn.MinimumWidth = 8;
            due�oDataGridViewTextBoxColumn.Name = "due�oDataGridViewTextBoxColumn";
            // 
            // autonomiaDataGridViewTextBoxColumn
            // 
            autonomiaDataGridViewTextBoxColumn.DataPropertyName = "Autonomia";
            autonomiaDataGridViewTextBoxColumn.HeaderText = "Autonomia";
            autonomiaDataGridViewTextBoxColumn.MinimumWidth = 8;
            autonomiaDataGridViewTextBoxColumn.Name = "autonomiaDataGridViewTextBoxColumn";
            // 
            // serviceDataGridViewTextBoxColumn
            // 
            serviceDataGridViewTextBoxColumn.DataPropertyName = "Service";
            serviceDataGridViewTextBoxColumn.HeaderText = "Service";
            serviceDataGridViewTextBoxColumn.MinimumWidth = 8;
            serviceDataGridViewTextBoxColumn.Name = "serviceDataGridViewTextBoxColumn";
            // 
            // cargaRestanteDataGridViewTextBoxColumn
            // 
            cargaRestanteDataGridViewTextBoxColumn.DataPropertyName = "CargaRestante";
            cargaRestanteDataGridViewTextBoxColumn.HeaderText = "CargaRestante";
            cargaRestanteDataGridViewTextBoxColumn.MinimumWidth = 8;
            cargaRestanteDataGridViewTextBoxColumn.Name = "cargaRestanteDataGridViewTextBoxColumn";
            cargaRestanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // spaceXFalcon9BindingSource
            // 
            spaceXFalcon9BindingSource.DataSource = typeof(SpaceXFalcon9);
            // 
            // Form1
            // 
            ClientSize = new Size(997, 544);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(textBoxDue�o);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxColor);
            Controls.Add(textBoxUnidadDeUSo);
            Controls.Add(label2);
            Controls.Add(textBoxA�o);
            Controls.Add(label1);
            Controls.Add(comboBoxTipoProducto);
            Controls.Add(btnEscanear);
            Controls.Add(btnTeslaMasKm);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Name = "Form1";
            Text = "Sistema de Gesti�n SpaceX - Tesla";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)spaceXFalcon9BindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        // Control del tipo de datos en los textbox al agregar un producto
        private void textBoxA�o_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancelar el car�cter ingresado si no es un d�gito!!
            }
        }

        private void textBoxUnidadDeUSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancelar el car�cter ingresado si no es un d�gito!!
            }
        }
    }
}
