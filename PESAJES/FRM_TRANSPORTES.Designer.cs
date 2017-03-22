namespace PESAJES
{
    partial class FRM_TRANSPORTES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_TRANSPORTES));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label tRANSPORTELabel;
            System.Windows.Forms.Label pLACASLabel;
            System.Windows.Forms.Label cOLORLabel;
            System.Windows.Forms.Label cAPACIDADLabel;
            System.Windows.Forms.Label bAJALabel;
            this.basculaDataSet = new PESAJES.basculaDataSet();
            this.tRANSPORTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRANSPORTESTableAdapter = new PESAJES.basculaDataSetTableAdapters.TRANSPORTESTableAdapter();
            this.tableAdapterManager = new PESAJES.basculaDataSetTableAdapters.TableAdapterManager();
            this.tRANSPORTESBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tRANSPORTESBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.tRANSPORTETextBox = new System.Windows.Forms.TextBox();
            this.pLACASTextBox = new System.Windows.Forms.TextBox();
            this.cOLORTextBox = new System.Windows.Forms.TextBox();
            this.cAPACIDADTextBox = new System.Windows.Forms.TextBox();
            this.bAJACheckBox = new System.Windows.Forms.CheckBox();
            iDLabel = new System.Windows.Forms.Label();
            tRANSPORTELabel = new System.Windows.Forms.Label();
            pLACASLabel = new System.Windows.Forms.Label();
            cOLORLabel = new System.Windows.Forms.Label();
            cAPACIDADLabel = new System.Windows.Forms.Label();
            bAJALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.basculaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANSPORTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANSPORTESBindingNavigator)).BeginInit();
            this.tRANSPORTESBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // basculaDataSet
            // 
            this.basculaDataSet.DataSetName = "basculaDataSet";
            this.basculaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tRANSPORTESBindingSource
            // 
            this.tRANSPORTESBindingSource.DataMember = "TRANSPORTES";
            this.tRANSPORTESBindingSource.DataSource = this.basculaDataSet;
            // 
            // tRANSPORTESTableAdapter
            // 
            this.tRANSPORTESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FOLIOSTableAdapter = null;
            this.tableAdapterManager.OPERADORESTableAdapter = null;
            this.tableAdapterManager.PESAJESTableAdapter = null;
            this.tableAdapterManager.TRANSPORTESTableAdapter = this.tRANSPORTESTableAdapter;
            this.tableAdapterManager.UpdateOrder = PESAJES.basculaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tRANSPORTESBindingNavigator
            // 
            this.tRANSPORTESBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tRANSPORTESBindingNavigator.BindingSource = this.tRANSPORTESBindingSource;
            this.tRANSPORTESBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tRANSPORTESBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tRANSPORTESBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tRANSPORTESBindingNavigatorSaveItem});
            this.tRANSPORTESBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tRANSPORTESBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tRANSPORTESBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tRANSPORTESBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tRANSPORTESBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tRANSPORTESBindingNavigator.Name = "tRANSPORTESBindingNavigator";
            this.tRANSPORTESBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tRANSPORTESBindingNavigator.Size = new System.Drawing.Size(452, 25);
            this.tRANSPORTESBindingNavigator.TabIndex = 0;
            this.tRANSPORTESBindingNavigator.Text = "bindingNavigator1";
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
            // tRANSPORTESBindingNavigatorSaveItem
            // 
            this.tRANSPORTESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tRANSPORTESBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tRANSPORTESBindingNavigatorSaveItem.Image")));
            this.tRANSPORTESBindingNavigatorSaveItem.Name = "tRANSPORTESBindingNavigatorSaveItem";
            this.tRANSPORTESBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tRANSPORTESBindingNavigatorSaveItem.Text = "Guardar datos";
            this.tRANSPORTESBindingNavigatorSaveItem.Click += new System.EventHandler(this.tRANSPORTESBindingNavigatorSaveItem_Click);
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(29, 43);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSPORTESBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(119, 40);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(104, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // tRANSPORTELabel
            // 
            tRANSPORTELabel.AutoSize = true;
            tRANSPORTELabel.Location = new System.Drawing.Point(29, 69);
            tRANSPORTELabel.Name = "tRANSPORTELabel";
            tRANSPORTELabel.Size = new System.Drawing.Size(84, 13);
            tRANSPORTELabel.TabIndex = 3;
            tRANSPORTELabel.Text = "TRANSPORTE:";
            // 
            // tRANSPORTETextBox
            // 
            this.tRANSPORTETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSPORTESBindingSource, "TRANSPORTE", true));
            this.tRANSPORTETextBox.Location = new System.Drawing.Point(119, 66);
            this.tRANSPORTETextBox.Name = "tRANSPORTETextBox";
            this.tRANSPORTETextBox.Size = new System.Drawing.Size(104, 20);
            this.tRANSPORTETextBox.TabIndex = 4;
            // 
            // pLACASLabel
            // 
            pLACASLabel.AutoSize = true;
            pLACASLabel.Location = new System.Drawing.Point(29, 95);
            pLACASLabel.Name = "pLACASLabel";
            pLACASLabel.Size = new System.Drawing.Size(51, 13);
            pLACASLabel.TabIndex = 5;
            pLACASLabel.Text = "PLACAS:";
            // 
            // pLACASTextBox
            // 
            this.pLACASTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSPORTESBindingSource, "PLACAS", true));
            this.pLACASTextBox.Location = new System.Drawing.Point(119, 92);
            this.pLACASTextBox.Name = "pLACASTextBox";
            this.pLACASTextBox.Size = new System.Drawing.Size(104, 20);
            this.pLACASTextBox.TabIndex = 6;
            // 
            // cOLORLabel
            // 
            cOLORLabel.AutoSize = true;
            cOLORLabel.Location = new System.Drawing.Point(29, 121);
            cOLORLabel.Name = "cOLORLabel";
            cOLORLabel.Size = new System.Drawing.Size(47, 13);
            cOLORLabel.TabIndex = 7;
            cOLORLabel.Text = "COLOR:";
            // 
            // cOLORTextBox
            // 
            this.cOLORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSPORTESBindingSource, "COLOR", true));
            this.cOLORTextBox.Location = new System.Drawing.Point(119, 118);
            this.cOLORTextBox.Name = "cOLORTextBox";
            this.cOLORTextBox.Size = new System.Drawing.Size(104, 20);
            this.cOLORTextBox.TabIndex = 8;
            // 
            // cAPACIDADLabel
            // 
            cAPACIDADLabel.AutoSize = true;
            cAPACIDADLabel.Location = new System.Drawing.Point(29, 147);
            cAPACIDADLabel.Name = "cAPACIDADLabel";
            cAPACIDADLabel.Size = new System.Drawing.Size(71, 13);
            cAPACIDADLabel.TabIndex = 9;
            cAPACIDADLabel.Text = "CAPACIDAD:";
            // 
            // cAPACIDADTextBox
            // 
            this.cAPACIDADTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRANSPORTESBindingSource, "CAPACIDAD", true));
            this.cAPACIDADTextBox.Location = new System.Drawing.Point(119, 144);
            this.cAPACIDADTextBox.Name = "cAPACIDADTextBox";
            this.cAPACIDADTextBox.Size = new System.Drawing.Size(104, 20);
            this.cAPACIDADTextBox.TabIndex = 10;
            // 
            // bAJALabel
            // 
            bAJALabel.AutoSize = true;
            bAJALabel.Location = new System.Drawing.Point(29, 175);
            bAJALabel.Name = "bAJALabel";
            bAJALabel.Size = new System.Drawing.Size(36, 13);
            bAJALabel.TabIndex = 11;
            bAJALabel.Text = "BAJA:";
            // 
            // bAJACheckBox
            // 
            this.bAJACheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tRANSPORTESBindingSource, "BAJA", true));
            this.bAJACheckBox.Location = new System.Drawing.Point(119, 170);
            this.bAJACheckBox.Name = "bAJACheckBox";
            this.bAJACheckBox.Size = new System.Drawing.Size(104, 24);
            this.bAJACheckBox.TabIndex = 12;
            this.bAJACheckBox.Text = "checkBox1";
            this.bAJACheckBox.UseVisualStyleBackColor = true;
            // 
            // FRM_TRANSPORTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 231);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(tRANSPORTELabel);
            this.Controls.Add(this.tRANSPORTETextBox);
            this.Controls.Add(pLACASLabel);
            this.Controls.Add(this.pLACASTextBox);
            this.Controls.Add(cOLORLabel);
            this.Controls.Add(this.cOLORTextBox);
            this.Controls.Add(cAPACIDADLabel);
            this.Controls.Add(this.cAPACIDADTextBox);
            this.Controls.Add(bAJALabel);
            this.Controls.Add(this.bAJACheckBox);
            this.Controls.Add(this.tRANSPORTESBindingNavigator);
            this.Name = "FRM_TRANSPORTES";
            this.Text = "FRM_TRANSPORTES";
            this.Load += new System.EventHandler(this.FRM_TRANSPORTES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.basculaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANSPORTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANSPORTESBindingNavigator)).EndInit();
            this.tRANSPORTESBindingNavigator.ResumeLayout(false);
            this.tRANSPORTESBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private basculaDataSet basculaDataSet;
        private System.Windows.Forms.BindingSource tRANSPORTESBindingSource;
        private basculaDataSetTableAdapters.TRANSPORTESTableAdapter tRANSPORTESTableAdapter;
        private basculaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tRANSPORTESBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tRANSPORTESBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox tRANSPORTETextBox;
        private System.Windows.Forms.TextBox pLACASTextBox;
        private System.Windows.Forms.TextBox cOLORTextBox;
        private System.Windows.Forms.TextBox cAPACIDADTextBox;
        private System.Windows.Forms.CheckBox bAJACheckBox;
    }
}