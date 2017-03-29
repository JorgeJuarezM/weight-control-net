namespace PESAJES
{
    partial class FRM_Folios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Folios));
            System.Windows.Forms.Label sECUENCIALabel;
            System.Windows.Forms.Label fOLIO_ACTUALLabel;
            System.Windows.Forms.Label iNTERVALOLabel;
            System.Windows.Forms.Label bAJALabel;
            System.Windows.Forms.Label eMPRESALabel;
            System.Windows.Forms.Label dOMICILIOLabel;
            System.Windows.Forms.Label tELEFONOLabel;
            this.basculaDataSet = new PESAJES.basculaDataSet();
            this.fOLIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fOLIOSTableAdapter = new PESAJES.basculaDataSetTableAdapters.FOLIOSTableAdapter();
            this.tableAdapterManager = new PESAJES.basculaDataSetTableAdapters.TableAdapterManager();
            this.fOLIOSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.fOLIOSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sECUENCIATextBox = new System.Windows.Forms.TextBox();
            this.fOLIO_ACTUALTextBox = new System.Windows.Forms.TextBox();
            this.iNTERVALOTextBox = new System.Windows.Forms.TextBox();
            this.bAJACheckBox = new System.Windows.Forms.CheckBox();
            this.eMPRESATextBox = new System.Windows.Forms.TextBox();
            this.dOMICILIOTextBox = new System.Windows.Forms.TextBox();
            this.tELEFONOTextBox = new System.Windows.Forms.TextBox();
            sECUENCIALabel = new System.Windows.Forms.Label();
            fOLIO_ACTUALLabel = new System.Windows.Forms.Label();
            iNTERVALOLabel = new System.Windows.Forms.Label();
            bAJALabel = new System.Windows.Forms.Label();
            eMPRESALabel = new System.Windows.Forms.Label();
            dOMICILIOLabel = new System.Windows.Forms.Label();
            tELEFONOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.basculaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOLIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOLIOSBindingNavigator)).BeginInit();
            this.fOLIOSBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // basculaDataSet
            // 
            this.basculaDataSet.DataSetName = "basculaDataSet";
            this.basculaDataSet.Locale = new System.Globalization.CultureInfo("es-ES");
            this.basculaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fOLIOSBindingSource
            // 
            this.fOLIOSBindingSource.DataMember = "FOLIOS";
            this.fOLIOSBindingSource.DataSource = this.basculaDataSet;
            // 
            // fOLIOSTableAdapter
            // 
            this.fOLIOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FOLIOSTableAdapter = this.fOLIOSTableAdapter;
            this.tableAdapterManager.OPERADORESTableAdapter = null;
            this.tableAdapterManager.PESAJESTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PESAJES.basculaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOSTableAdapter = null;
            // 
            // fOLIOSBindingNavigator
            // 
            this.fOLIOSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.fOLIOSBindingNavigator.BindingSource = this.fOLIOSBindingSource;
            this.fOLIOSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fOLIOSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.fOLIOSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.fOLIOSBindingNavigatorSaveItem});
            this.fOLIOSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.fOLIOSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fOLIOSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fOLIOSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fOLIOSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fOLIOSBindingNavigator.Name = "fOLIOSBindingNavigator";
            this.fOLIOSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fOLIOSBindingNavigator.Size = new System.Drawing.Size(491, 25);
            this.fOLIOSBindingNavigator.TabIndex = 0;
            this.fOLIOSBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // fOLIOSBindingNavigatorSaveItem
            // 
            this.fOLIOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fOLIOSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fOLIOSBindingNavigatorSaveItem.Image")));
            this.fOLIOSBindingNavigatorSaveItem.Name = "fOLIOSBindingNavigatorSaveItem";
            this.fOLIOSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.fOLIOSBindingNavigatorSaveItem.Text = "Guardar datos";
            this.fOLIOSBindingNavigatorSaveItem.Click += new System.EventHandler(this.fOLIOSBindingNavigatorSaveItem_Click);
            // 
            // sECUENCIALabel
            // 
            sECUENCIALabel.AutoSize = true;
            sECUENCIALabel.Location = new System.Drawing.Point(12, 46);
            sECUENCIALabel.Name = "sECUENCIALabel";
            sECUENCIALabel.Size = new System.Drawing.Size(71, 13);
            sECUENCIALabel.TabIndex = 1;
            sECUENCIALabel.Text = "SECUENCIA:";
            // 
            // sECUENCIATextBox
            // 
            this.sECUENCIATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fOLIOSBindingSource, "SECUENCIA", true));
            this.sECUENCIATextBox.Location = new System.Drawing.Point(104, 43);
            this.sECUENCIATextBox.Name = "sECUENCIATextBox";
            this.sECUENCIATextBox.Size = new System.Drawing.Size(104, 20);
            this.sECUENCIATextBox.TabIndex = 2;
            // 
            // fOLIO_ACTUALLabel
            // 
            fOLIO_ACTUALLabel.AutoSize = true;
            fOLIO_ACTUALLabel.Location = new System.Drawing.Point(12, 72);
            fOLIO_ACTUALLabel.Name = "fOLIO_ACTUALLabel";
            fOLIO_ACTUALLabel.Size = new System.Drawing.Size(86, 13);
            fOLIO_ACTUALLabel.TabIndex = 3;
            fOLIO_ACTUALLabel.Text = "FOLIO ACTUAL:";
            // 
            // fOLIO_ACTUALTextBox
            // 
            this.fOLIO_ACTUALTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fOLIOSBindingSource, "FOLIO_ACTUAL", true));
            this.fOLIO_ACTUALTextBox.Location = new System.Drawing.Point(104, 69);
            this.fOLIO_ACTUALTextBox.Name = "fOLIO_ACTUALTextBox";
            this.fOLIO_ACTUALTextBox.Size = new System.Drawing.Size(104, 20);
            this.fOLIO_ACTUALTextBox.TabIndex = 4;
            // 
            // iNTERVALOLabel
            // 
            iNTERVALOLabel.AutoSize = true;
            iNTERVALOLabel.Location = new System.Drawing.Point(12, 98);
            iNTERVALOLabel.Name = "iNTERVALOLabel";
            iNTERVALOLabel.Size = new System.Drawing.Size(71, 13);
            iNTERVALOLabel.TabIndex = 5;
            iNTERVALOLabel.Text = "INTERVALO:";
            // 
            // iNTERVALOTextBox
            // 
            this.iNTERVALOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fOLIOSBindingSource, "INTERVALO", true));
            this.iNTERVALOTextBox.Location = new System.Drawing.Point(104, 95);
            this.iNTERVALOTextBox.Name = "iNTERVALOTextBox";
            this.iNTERVALOTextBox.Size = new System.Drawing.Size(104, 20);
            this.iNTERVALOTextBox.TabIndex = 6;
            // 
            // bAJALabel
            // 
            bAJALabel.AutoSize = true;
            bAJALabel.Location = new System.Drawing.Point(12, 126);
            bAJALabel.Name = "bAJALabel";
            bAJALabel.Size = new System.Drawing.Size(36, 13);
            bAJALabel.TabIndex = 7;
            bAJALabel.Text = "BAJA:";
            // 
            // bAJACheckBox
            // 
            this.bAJACheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.fOLIOSBindingSource, "BAJA", true));
            this.bAJACheckBox.Location = new System.Drawing.Point(104, 121);
            this.bAJACheckBox.Name = "bAJACheckBox";
            this.bAJACheckBox.Size = new System.Drawing.Size(104, 24);
            this.bAJACheckBox.TabIndex = 8;
            this.bAJACheckBox.Text = "checkBox1";
            this.bAJACheckBox.UseVisualStyleBackColor = true;
            // 
            // eMPRESALabel
            // 
            eMPRESALabel.AutoSize = true;
            eMPRESALabel.Location = new System.Drawing.Point(12, 154);
            eMPRESALabel.Name = "eMPRESALabel";
            eMPRESALabel.Size = new System.Drawing.Size(62, 13);
            eMPRESALabel.TabIndex = 9;
            eMPRESALabel.Text = "EMPRESA:";
            // 
            // eMPRESATextBox
            // 
            this.eMPRESATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fOLIOSBindingSource, "EMPRESA", true));
            this.eMPRESATextBox.Location = new System.Drawing.Point(104, 151);
            this.eMPRESATextBox.Multiline = true;
            this.eMPRESATextBox.Name = "eMPRESATextBox";
            this.eMPRESATextBox.Size = new System.Drawing.Size(360, 45);
            this.eMPRESATextBox.TabIndex = 10;
            // 
            // dOMICILIOLabel
            // 
            dOMICILIOLabel.AutoSize = true;
            dOMICILIOLabel.Location = new System.Drawing.Point(12, 210);
            dOMICILIOLabel.Name = "dOMICILIOLabel";
            dOMICILIOLabel.Size = new System.Drawing.Size(65, 13);
            dOMICILIOLabel.TabIndex = 11;
            dOMICILIOLabel.Text = "DOMICILIO:";
            // 
            // dOMICILIOTextBox
            // 
            this.dOMICILIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fOLIOSBindingSource, "DOMICILIO", true));
            this.dOMICILIOTextBox.Location = new System.Drawing.Point(104, 207);
            this.dOMICILIOTextBox.Multiline = true;
            this.dOMICILIOTextBox.Name = "dOMICILIOTextBox";
            this.dOMICILIOTextBox.Size = new System.Drawing.Size(360, 44);
            this.dOMICILIOTextBox.TabIndex = 12;
            // 
            // tELEFONOLabel
            // 
            tELEFONOLabel.AutoSize = true;
            tELEFONOLabel.Location = new System.Drawing.Point(18, 271);
            tELEFONOLabel.Name = "tELEFONOLabel";
            tELEFONOLabel.Size = new System.Drawing.Size(67, 13);
            tELEFONOLabel.TabIndex = 13;
            tELEFONOLabel.Text = "TELEFONO:";
            // 
            // tELEFONOTextBox
            // 
            this.tELEFONOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fOLIOSBindingSource, "TELEFONO", true));
            this.tELEFONOTextBox.Location = new System.Drawing.Point(110, 268);
            this.tELEFONOTextBox.Name = "tELEFONOTextBox";
            this.tELEFONOTextBox.Size = new System.Drawing.Size(211, 20);
            this.tELEFONOTextBox.TabIndex = 14;
            // 
            // FRM_Folios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 407);
            this.Controls.Add(sECUENCIALabel);
            this.Controls.Add(this.sECUENCIATextBox);
            this.Controls.Add(fOLIO_ACTUALLabel);
            this.Controls.Add(this.fOLIO_ACTUALTextBox);
            this.Controls.Add(iNTERVALOLabel);
            this.Controls.Add(this.iNTERVALOTextBox);
            this.Controls.Add(bAJALabel);
            this.Controls.Add(this.bAJACheckBox);
            this.Controls.Add(eMPRESALabel);
            this.Controls.Add(this.eMPRESATextBox);
            this.Controls.Add(dOMICILIOLabel);
            this.Controls.Add(this.dOMICILIOTextBox);
            this.Controls.Add(tELEFONOLabel);
            this.Controls.Add(this.tELEFONOTextBox);
            this.Controls.Add(this.fOLIOSBindingNavigator);
            this.Name = "FRM_Folios";
            this.Text = "FRM_Folios";
            this.Load += new System.EventHandler(this.FRM_Folios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.basculaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOLIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOLIOSBindingNavigator)).EndInit();
            this.fOLIOSBindingNavigator.ResumeLayout(false);
            this.fOLIOSBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private basculaDataSet basculaDataSet;
        private System.Windows.Forms.BindingSource fOLIOSBindingSource;
        private basculaDataSetTableAdapters.FOLIOSTableAdapter fOLIOSTableAdapter;
        private basculaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator fOLIOSBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton fOLIOSBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox sECUENCIATextBox;
        private System.Windows.Forms.TextBox fOLIO_ACTUALTextBox;
        private System.Windows.Forms.TextBox iNTERVALOTextBox;
        private System.Windows.Forms.CheckBox bAJACheckBox;
        private System.Windows.Forms.TextBox eMPRESATextBox;
        private System.Windows.Forms.TextBox dOMICILIOTextBox;
        private System.Windows.Forms.TextBox tELEFONOTextBox;
    }
}