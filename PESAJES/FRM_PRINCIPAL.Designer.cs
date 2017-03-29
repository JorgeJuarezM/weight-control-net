namespace PESAJES
{
    partial class FRM_PRINCIPAL
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label fOLIOLabel;
            System.Windows.Forms.Label iD_OPERADORLabel;
            System.Windows.Forms.Label iD_TRANSPORTELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PRINCIPAL));
            System.Windows.Forms.Label label1;
            this.basculaDataSet = new PESAJES.basculaDataSet();
            this.pESAJESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pESAJESTableAdapter = new PESAJES.basculaDataSetTableAdapters.PESAJESTableAdapter();
            this.tableAdapterManager = new PESAJES.basculaDataSetTableAdapters.TableAdapterManager();
            this.oPERADORESTableAdapter = new PESAJES.basculaDataSetTableAdapters.OPERADORESTableAdapter();
            this.pESAJESBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.fOLIOTextBox = new System.Windows.Forms.TextBox();
            this.pESO_ENTRADATextBox = new System.Windows.Forms.TextBox();
            this.pESO_SALIDATextBox = new System.Windows.Forms.TextBox();
            this.pESO_NETOTextBox = new System.Windows.Forms.TextBox();
            this.iD_OPERADORComboBox = new System.Windows.Forms.ComboBox();
            this.oPERADORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pLACASTextBox = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            fOLIOLabel = new System.Windows.Forms.Label();
            iD_OPERADORLabel = new System.Windows.Forms.Label();
            iD_TRANSPORTELabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.basculaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESAJESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESAJESBindingNavigator)).BeginInit();
            this.pESAJESBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oPERADORESBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fOLIOLabel
            // 
            fOLIOLabel.AutoSize = true;
            fOLIOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fOLIOLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            fOLIOLabel.Location = new System.Drawing.Point(20, 377);
            fOLIOLabel.Name = "fOLIOLabel";
            fOLIOLabel.Size = new System.Drawing.Size(86, 25);
            fOLIOLabel.TabIndex = 4;
            fOLIOLabel.Text = "FOLIO:";
            // 
            // iD_OPERADORLabel
            // 
            iD_OPERADORLabel.AutoSize = true;
            iD_OPERADORLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_OPERADORLabel.Location = new System.Drawing.Point(21, 245);
            iD_OPERADORLabel.Name = "iD_OPERADORLabel";
            iD_OPERADORLabel.Size = new System.Drawing.Size(105, 20);
            iD_OPERADORLabel.TabIndex = 16;
            iD_OPERADORLabel.Text = "OPERADOR:";
            // 
            // iD_TRANSPORTELabel
            // 
            iD_TRANSPORTELabel.AutoSize = true;
            iD_TRANSPORTELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_TRANSPORTELabel.Location = new System.Drawing.Point(21, 279);
            iD_TRANSPORTELabel.Name = "iD_TRANSPORTELabel";
            iD_TRANSPORTELabel.Size = new System.Drawing.Size(76, 20);
            iD_TRANSPORTELabel.TabIndex = 18;
            iD_TRANSPORTELabel.Text = "PLACAS:";
            // 
            // basculaDataSet
            // 
            this.basculaDataSet.DataSetName = "basculaDataSet";
            this.basculaDataSet.Locale = new System.Globalization.CultureInfo("es-ES");
            this.basculaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pESAJESBindingSource
            // 
            this.pESAJESBindingSource.DataMember = "PESAJES";
            this.pESAJESBindingSource.DataSource = this.basculaDataSet;
            this.pESAJESBindingSource.CurrentChanged += new System.EventHandler(this.pESAJESBindingSource_CurrentChanged);
            // 
            // pESAJESTableAdapter
            // 
            this.pESAJESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FOLIOSTableAdapter = null;
            this.tableAdapterManager.OPERADORESTableAdapter = this.oPERADORESTableAdapter;
            this.tableAdapterManager.PESAJESTableAdapter = this.pESAJESTableAdapter;
            this.tableAdapterManager.UpdateOrder = PESAJES.basculaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOSTableAdapter = null;
            // 
            // oPERADORESTableAdapter
            // 
            this.oPERADORESTableAdapter.ClearBeforeFill = true;
            // 
            // pESAJESBindingNavigator
            // 
            this.pESAJESBindingNavigator.AddNewItem = null;
            this.pESAJESBindingNavigator.BindingSource = this.pESAJESBindingSource;
            this.pESAJESBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pESAJESBindingNavigator.DeleteItem = null;
            this.pESAJESBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem});
            this.pESAJESBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pESAJESBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pESAJESBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pESAJESBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pESAJESBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pESAJESBindingNavigator.Name = "pESAJESBindingNavigator";
            this.pESAJESBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pESAJESBindingNavigator.Size = new System.Drawing.Size(754, 25);
            this.pESAJESBindingNavigator.TabIndex = 1;
            this.pESAJESBindingNavigator.Text = "bindingNavigator1";
            this.pESAJESBindingNavigator.RefreshItems += new System.EventHandler(this.pESAJESBindingNavigator_RefreshItems);
            this.pESAJESBindingNavigator.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.pESAJESBindingNavigator_ItemClicked);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // fOLIOTextBox
            // 
            this.fOLIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pESAJESBindingSource, "FOLIO", true));
            this.fOLIOTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fOLIOTextBox.Location = new System.Drawing.Point(132, 374);
            this.fOLIOTextBox.Name = "fOLIOTextBox";
            this.fOLIOTextBox.Size = new System.Drawing.Size(140, 31);
            this.fOLIOTextBox.TabIndex = 5;
            this.fOLIOTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fOLIOTextBox_KeyDown);
            // 
            // pESO_ENTRADATextBox
            // 
            this.pESO_ENTRADATextBox.BackColor = System.Drawing.SystemColors.Control;
            this.pESO_ENTRADATextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pESO_ENTRADATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pESAJESBindingSource, "PESO_ENTRADA", true));
            this.pESO_ENTRADATextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pESO_ENTRADATextBox.Enabled = false;
            this.pESO_ENTRADATextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pESO_ENTRADATextBox.Location = new System.Drawing.Point(3, 22);
            this.pESO_ENTRADATextBox.Name = "pESO_ENTRADATextBox";
            this.pESO_ENTRADATextBox.ReadOnly = true;
            this.pESO_ENTRADATextBox.Size = new System.Drawing.Size(343, 42);
            this.pESO_ENTRADATextBox.TabIndex = 0;
            this.pESO_ENTRADATextBox.TabStop = false;
            this.pESO_ENTRADATextBox.Text = "150000.000";
            this.pESO_ENTRADATextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pESO_SALIDATextBox
            // 
            this.pESO_SALIDATextBox.BackColor = System.Drawing.SystemColors.Control;
            this.pESO_SALIDATextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pESO_SALIDATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pESAJESBindingSource, "PESO_SALIDA", true));
            this.pESO_SALIDATextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pESO_SALIDATextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pESO_SALIDATextBox.Location = new System.Drawing.Point(3, 22);
            this.pESO_SALIDATextBox.Name = "pESO_SALIDATextBox";
            this.pESO_SALIDATextBox.ReadOnly = true;
            this.pESO_SALIDATextBox.Size = new System.Drawing.Size(716, 73);
            this.pESO_SALIDATextBox.TabIndex = 0;
            this.pESO_SALIDATextBox.TabStop = false;
            this.pESO_SALIDATextBox.Text = "9999999999";
            this.pESO_SALIDATextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pESO_SALIDATextBox.TextChanged += new System.EventHandler(this.pESO_SALIDATextBox_TextChanged);
            this.pESO_SALIDATextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pESO_SALIDATextBox_KeyPress);
            // 
            // pESO_NETOTextBox
            // 
            this.pESO_NETOTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.pESO_NETOTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pESO_NETOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pESAJESBindingSource, "PESO_NETO", true));
            this.pESO_NETOTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pESO_NETOTextBox.Enabled = false;
            this.pESO_NETOTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pESO_NETOTextBox.Location = new System.Drawing.Point(3, 22);
            this.pESO_NETOTextBox.Name = "pESO_NETOTextBox";
            this.pESO_NETOTextBox.ReadOnly = true;
            this.pESO_NETOTextBox.Size = new System.Drawing.Size(343, 42);
            this.pESO_NETOTextBox.TabIndex = 3;
            this.pESO_NETOTextBox.TabStop = false;
            this.pESO_NETOTextBox.Text = "50000.000";
            this.pESO_NETOTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // iD_OPERADORComboBox
            // 
            this.iD_OPERADORComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.iD_OPERADORComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.iD_OPERADORComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pESAJESBindingSource, "ID_OPERADOR", true));
            this.iD_OPERADORComboBox.DataSource = this.oPERADORESBindingSource;
            this.iD_OPERADORComboBox.DisplayMember = "NOMBRE_OPERADOR";
            this.iD_OPERADORComboBox.Enabled = false;
            this.iD_OPERADORComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_OPERADORComboBox.FormattingEnabled = true;
            this.iD_OPERADORComboBox.Location = new System.Drawing.Point(132, 242);
            this.iD_OPERADORComboBox.Name = "iD_OPERADORComboBox";
            this.iD_OPERADORComboBox.Size = new System.Drawing.Size(415, 28);
            this.iD_OPERADORComboBox.TabIndex = 1;
            this.iD_OPERADORComboBox.ValueMember = "ID";
            this.iD_OPERADORComboBox.SelectedIndexChanged += new System.EventHandler(this.iD_OPERADORComboBox_SelectedIndexChanged);
            // 
            // oPERADORESBindingSource
            // 
            this.oPERADORESBindingSource.DataMember = "OPERADORES";
            this.oPERADORESBindingSource.DataSource = this.basculaDataSet;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pESO_ENTRADATextBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox2.Location = new System.Drawing.Point(12, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 78);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PESO TARA";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pESO_SALIDATextBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox3.Location = new System.Drawing.Point(12, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(722, 111);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PESO BRUTO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pESO_NETOTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Location = new System.Drawing.Point(385, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 78);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PESO NETO";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(624, 242);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(107, 57);
            this.btnRegistrar.TabIndex = 27;
            this.btnRegistrar.Text = "R E G I S T R A R";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(624, 326);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 35);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "C A N C E L A R";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pLACASTextBox
            // 
            this.pLACASTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pESAJESBindingSource, "PLACAS", true));
            this.pLACASTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pLACASTextBox.Location = new System.Drawing.Point(132, 276);
            this.pLACASTextBox.Name = "pLACASTextBox";
            this.pLACASTextBox.ReadOnly = true;
            this.pLACASTextBox.Size = new System.Drawing.Size(140, 26);
            this.pLACASTextBox.TabIndex = 29;
            // 
            // txtTipo
            // 
            this.txtTipo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pESAJESBindingSource, "TIPO_PESAJE", true));
            this.txtTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTipo.Enabled = false;
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.FormattingEnabled = true;
            this.txtTipo.Location = new System.Drawing.Point(295, 276);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(252, 28);
            this.txtTipo.TabIndex = 30;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(132, 314);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(415, 28);
            this.comboBox1.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(21, 317);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(92, 20);
            label1.TabIndex = 32;
            label1.Text = "EMPRESA:";
            // 
            // FRM_PRINCIPAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 421);
            this.Controls.Add(label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.pLACASTextBox);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(iD_TRANSPORTELabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.iD_OPERADORComboBox);
            this.Controls.Add(iD_OPERADORLabel);
            this.Controls.Add(fOLIOLabel);
            this.Controls.Add(this.fOLIOTextBox);
            this.Controls.Add(this.pESAJESBindingNavigator);
            this.Name = "FRM_PRINCIPAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRINCIPAL";
            this.Load += new System.EventHandler(this.FRM_PRINCIPAL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.basculaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESAJESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESAJESBindingNavigator)).EndInit();
            this.pESAJESBindingNavigator.ResumeLayout(false);
            this.pESAJESBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oPERADORESBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private basculaDataSet basculaDataSet;
        private System.Windows.Forms.BindingSource pESAJESBindingSource;
        private basculaDataSetTableAdapters.PESAJESTableAdapter pESAJESTableAdapter;
        private basculaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pESAJESBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private basculaDataSetTableAdapters.OPERADORESTableAdapter oPERADORESTableAdapter;
        private System.Windows.Forms.TextBox fOLIOTextBox;
        private System.Windows.Forms.TextBox pESO_ENTRADATextBox;
        private System.Windows.Forms.TextBox pESO_SALIDATextBox;
        private System.Windows.Forms.TextBox pESO_NETOTextBox;
        private System.Windows.Forms.ComboBox iD_OPERADORComboBox;
        private System.Windows.Forms.BindingSource oPERADORESBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox pLACASTextBox;
        private System.Windows.Forms.ComboBox txtTipo;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}