namespace PESAJES
{
    partial class FRM_OPERADORES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_OPERADORES));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nOMBRE_OPERADORLabel;
            System.Windows.Forms.Label iD_TRANSPORTELabel;
            System.Windows.Forms.Label bAJALabel;
            this.basculaDataSet = new PESAJES.basculaDataSet();
            this.oPERADORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oPERADORESTableAdapter = new PESAJES.basculaDataSetTableAdapters.OPERADORESTableAdapter();
            this.tableAdapterManager = new PESAJES.basculaDataSetTableAdapters.TableAdapterManager();
            this.oPERADORESBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.oPERADORESBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.nOMBRE_OPERADORTextBox = new System.Windows.Forms.TextBox();
            this.iD_TRANSPORTEComboBox = new System.Windows.Forms.ComboBox();
            this.bAJACheckBox = new System.Windows.Forms.CheckBox();
            iDLabel = new System.Windows.Forms.Label();
            nOMBRE_OPERADORLabel = new System.Windows.Forms.Label();
            iD_TRANSPORTELabel = new System.Windows.Forms.Label();
            bAJALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.basculaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPERADORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPERADORESBindingNavigator)).BeginInit();
            this.oPERADORESBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // basculaDataSet
            // 
            this.basculaDataSet.DataSetName = "basculaDataSet";
            this.basculaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oPERADORESBindingSource
            // 
            this.oPERADORESBindingSource.DataMember = "OPERADORES";
            this.oPERADORESBindingSource.DataSource = this.basculaDataSet;
            // 
            // oPERADORESTableAdapter
            // 
            this.oPERADORESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FOLIOSTableAdapter = null;
            this.tableAdapterManager.OPERADORESTableAdapter = this.oPERADORESTableAdapter;
            this.tableAdapterManager.PESAJESTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PESAJES.basculaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // oPERADORESBindingNavigator
            // 
            this.oPERADORESBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.oPERADORESBindingNavigator.BindingSource = this.oPERADORESBindingSource;
            this.oPERADORESBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.oPERADORESBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.oPERADORESBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.oPERADORESBindingNavigatorSaveItem});
            this.oPERADORESBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.oPERADORESBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.oPERADORESBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.oPERADORESBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.oPERADORESBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.oPERADORESBindingNavigator.Name = "oPERADORESBindingNavigator";
            this.oPERADORESBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.oPERADORESBindingNavigator.Size = new System.Drawing.Size(575, 25);
            this.oPERADORESBindingNavigator.TabIndex = 0;
            this.oPERADORESBindingNavigator.Text = "bindingNavigator1";
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
            // oPERADORESBindingNavigatorSaveItem
            // 
            this.oPERADORESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.oPERADORESBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("oPERADORESBindingNavigatorSaveItem.Image")));
            this.oPERADORESBindingNavigatorSaveItem.Name = "oPERADORESBindingNavigatorSaveItem";
            this.oPERADORESBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.oPERADORESBindingNavigatorSaveItem.Text = "Guardar datos";
            this.oPERADORESBindingNavigatorSaveItem.Click += new System.EventHandler(this.oPERADORESBindingNavigatorSaveItem_Click_2);
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(12, 47);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oPERADORESBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(139, 44);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(121, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // nOMBRE_OPERADORLabel
            // 
            nOMBRE_OPERADORLabel.AutoSize = true;
            nOMBRE_OPERADORLabel.Location = new System.Drawing.Point(12, 73);
            nOMBRE_OPERADORLabel.Name = "nOMBRE_OPERADORLabel";
            nOMBRE_OPERADORLabel.Size = new System.Drawing.Size(121, 13);
            nOMBRE_OPERADORLabel.TabIndex = 3;
            nOMBRE_OPERADORLabel.Text = "NOMBRE OPERADOR:";
            // 
            // nOMBRE_OPERADORTextBox
            // 
            this.nOMBRE_OPERADORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oPERADORESBindingSource, "NOMBRE_OPERADOR", true));
            this.nOMBRE_OPERADORTextBox.Location = new System.Drawing.Point(139, 70);
            this.nOMBRE_OPERADORTextBox.Name = "nOMBRE_OPERADORTextBox";
            this.nOMBRE_OPERADORTextBox.Size = new System.Drawing.Size(424, 20);
            this.nOMBRE_OPERADORTextBox.TabIndex = 4;
            // 
            // iD_TRANSPORTELabel
            // 
            iD_TRANSPORTELabel.AutoSize = true;
            iD_TRANSPORTELabel.Location = new System.Drawing.Point(12, 99);
            iD_TRANSPORTELabel.Name = "iD_TRANSPORTELabel";
            iD_TRANSPORTELabel.Size = new System.Drawing.Size(98, 13);
            iD_TRANSPORTELabel.TabIndex = 5;
            iD_TRANSPORTELabel.Text = "ID TRANSPORTE:";
            // 
            // iD_TRANSPORTEComboBox
            // 
            this.iD_TRANSPORTEComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oPERADORESBindingSource, "ID_TRANSPORTE", true));
            this.iD_TRANSPORTEComboBox.FormattingEnabled = true;
            this.iD_TRANSPORTEComboBox.Location = new System.Drawing.Point(139, 96);
            this.iD_TRANSPORTEComboBox.Name = "iD_TRANSPORTEComboBox";
            this.iD_TRANSPORTEComboBox.Size = new System.Drawing.Size(424, 21);
            this.iD_TRANSPORTEComboBox.TabIndex = 6;
            // 
            // bAJALabel
            // 
            bAJALabel.AutoSize = true;
            bAJALabel.Location = new System.Drawing.Point(12, 128);
            bAJALabel.Name = "bAJALabel";
            bAJALabel.Size = new System.Drawing.Size(36, 13);
            bAJALabel.TabIndex = 7;
            bAJALabel.Text = "BAJA:";
            // 
            // bAJACheckBox
            // 
            this.bAJACheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.oPERADORESBindingSource, "BAJA", true));
            this.bAJACheckBox.Location = new System.Drawing.Point(139, 123);
            this.bAJACheckBox.Name = "bAJACheckBox";
            this.bAJACheckBox.Size = new System.Drawing.Size(121, 24);
            this.bAJACheckBox.TabIndex = 8;
            this.bAJACheckBox.Text = "checkBox1";
            this.bAJACheckBox.UseVisualStyleBackColor = true;
            // 
            // FRM_OPERADORES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 303);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(nOMBRE_OPERADORLabel);
            this.Controls.Add(this.nOMBRE_OPERADORTextBox);
            this.Controls.Add(iD_TRANSPORTELabel);
            this.Controls.Add(this.iD_TRANSPORTEComboBox);
            this.Controls.Add(bAJALabel);
            this.Controls.Add(this.bAJACheckBox);
            this.Controls.Add(this.oPERADORESBindingNavigator);
            this.Name = "FRM_OPERADORES";
            this.Text = "FRM_OPERADORES";
            this.Load += new System.EventHandler(this.FRM_OPERADORES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.basculaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPERADORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPERADORESBindingNavigator)).EndInit();
            this.oPERADORESBindingNavigator.ResumeLayout(false);
            this.oPERADORESBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private basculaDataSet basculaDataSet;
        private System.Windows.Forms.BindingSource oPERADORESBindingSource;
        private basculaDataSetTableAdapters.OPERADORESTableAdapter oPERADORESTableAdapter;
        private basculaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator oPERADORESBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton oPERADORESBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nOMBRE_OPERADORTextBox;
        private System.Windows.Forms.ComboBox iD_TRANSPORTEComboBox;
        private System.Windows.Forms.CheckBox bAJACheckBox;
    }
}