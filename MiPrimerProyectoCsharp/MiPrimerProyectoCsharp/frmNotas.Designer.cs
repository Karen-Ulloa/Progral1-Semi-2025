namespace MiPrimerProyectoCsharp
{
    partial class frmNotas
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
            System.Windows.Forms.Label idNotasLabel;
            System.Windows.Forms.Label idAlumnosLabel;
            System.Windows.Forms.Label idPeriodoLabel;
            System.Windows.Forms.Label fechaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotas));
            this.db_academicaDataSet = new MiPrimerProyectoCsharp.db_academicaDataSet();
            this.notasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notasTableAdapter = new MiPrimerProyectoCsharp.db_academicaDataSetTableAdapters.notasTableAdapter();
            this.tableAdapterManager = new MiPrimerProyectoCsharp.db_academicaDataSetTableAdapters.TableAdapterManager();
            this.notasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.idNotasLabel1 = new System.Windows.Forms.Label();
            this.idAlumnosComboBox = new System.Windows.Forms.ComboBox();
            this.idPeriodoComboBox = new System.Windows.Forms.ComboBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.notasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.notasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idNotasLabel = new System.Windows.Forms.Label();
            idAlumnosLabel = new System.Windows.Forms.Label();
            idPeriodoLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_academicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingNavigator)).BeginInit();
            this.notasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // db_academicaDataSet
            // 
            this.db_academicaDataSet.DataSetName = "db_academicaDataSet";
            this.db_academicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notasBindingSource
            // 
            this.notasBindingSource.DataMember = "notas";
            this.notasBindingSource.DataSource = this.db_academicaDataSet;
            // 
            // notasTableAdapter
            // 
            this.notasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.alumnosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.dnotasTableAdapter = null;
            this.tableAdapterManager.docentesTableAdapter = null;
            this.tableAdapterManager.MateriasTableAdapter = null;
            this.tableAdapterManager.notasTableAdapter = this.notasTableAdapter;
            this.tableAdapterManager.PeriodosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MiPrimerProyectoCsharp.db_academicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // notasBindingNavigator
            // 
            this.notasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.notasBindingNavigator.BindingSource = this.notasBindingSource;
            this.notasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.notasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.notasBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.notasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.notasBindingNavigatorSaveItem});
            this.notasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.notasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.notasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.notasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.notasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.notasBindingNavigator.Name = "notasBindingNavigator";
            this.notasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.notasBindingNavigator.Size = new System.Drawing.Size(651, 27);
            this.notasBindingNavigator.TabIndex = 0;
            this.notasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // idNotasLabel
            // 
            idNotasLabel.AutoSize = true;
            idNotasLabel.Location = new System.Drawing.Point(37, 71);
            idNotasLabel.Name = "idNotasLabel";
            idNotasLabel.Size = new System.Drawing.Size(60, 16);
            idNotasLabel.TabIndex = 1;
            idNotasLabel.Text = "Id Notas:";
            // 
            // idNotasLabel1
            // 
            this.idNotasLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "IdNotas", true));
            this.idNotasLabel1.Location = new System.Drawing.Point(119, 71);
            this.idNotasLabel1.Name = "idNotasLabel1";
            this.idNotasLabel1.Size = new System.Drawing.Size(200, 23);
            this.idNotasLabel1.TabIndex = 2;
            this.idNotasLabel1.Text = "label1";
            // 
            // idAlumnosLabel
            // 
            idAlumnosLabel.AutoSize = true;
            idAlumnosLabel.Location = new System.Drawing.Point(37, 100);
            idAlumnosLabel.Name = "idAlumnosLabel";
            idAlumnosLabel.Size = new System.Drawing.Size(76, 16);
            idAlumnosLabel.TabIndex = 3;
            idAlumnosLabel.Text = "Id Alumnos:";
            // 
            // idAlumnosComboBox
            // 
            this.idAlumnosComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "IdAlumnos", true));
            this.idAlumnosComboBox.FormattingEnabled = true;
            this.idAlumnosComboBox.Location = new System.Drawing.Point(119, 97);
            this.idAlumnosComboBox.Name = "idAlumnosComboBox";
            this.idAlumnosComboBox.Size = new System.Drawing.Size(200, 24);
            this.idAlumnosComboBox.TabIndex = 4;
            // 
            // idPeriodoLabel
            // 
            idPeriodoLabel.AutoSize = true;
            idPeriodoLabel.Location = new System.Drawing.Point(37, 130);
            idPeriodoLabel.Name = "idPeriodoLabel";
            idPeriodoLabel.Size = new System.Drawing.Size(72, 16);
            idPeriodoLabel.TabIndex = 5;
            idPeriodoLabel.Text = "id Periodo:";
            // 
            // idPeriodoComboBox
            // 
            this.idPeriodoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "idPeriodo", true));
            this.idPeriodoComboBox.FormattingEnabled = true;
            this.idPeriodoComboBox.Location = new System.Drawing.Point(119, 127);
            this.idPeriodoComboBox.Name = "idPeriodoComboBox";
            this.idPeriodoComboBox.Size = new System.Drawing.Size(200, 24);
            this.idPeriodoComboBox.TabIndex = 6;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(37, 161);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(43, 16);
            fechaLabel.TabIndex = 7;
            fechaLabel.Text = "fecha:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.notasBindingSource, "fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(119, 157);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(258, 22);
            this.fechaDateTimePicker.TabIndex = 8;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // notasBindingNavigatorSaveItem
            // 
            this.notasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.notasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("notasBindingNavigatorSaveItem.Image")));
            this.notasBindingNavigatorSaveItem.Name = "notasBindingNavigatorSaveItem";
            this.notasBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.notasBindingNavigatorSaveItem.Text = "Guardar datos";
            this.notasBindingNavigatorSaveItem.Click += new System.EventHandler(this.notasBindingNavigatorSaveItem_Click);
            // 
            // notasDataGridView
            // 
            this.notasDataGridView.AutoGenerateColumns = false;
            this.notasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.notasDataGridView.DataSource = this.notasBindingSource;
            this.notasDataGridView.Location = new System.Drawing.Point(55, 211);
            this.notasDataGridView.Name = "notasDataGridView";
            this.notasDataGridView.RowHeadersWidth = 51;
            this.notasDataGridView.RowTemplate.Height = 24;
            this.notasDataGridView.Size = new System.Drawing.Size(547, 220);
            this.notasDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdNotas";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdNotas";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdAlumnos";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdAlumnos";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idPeriodo";
            this.dataGridViewTextBoxColumn3.HeaderText = "idPeriodo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fecha";
            this.dataGridViewTextBoxColumn4.HeaderText = "fecha";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 467);
            this.Controls.Add(this.notasDataGridView);
            this.Controls.Add(idNotasLabel);
            this.Controls.Add(this.idNotasLabel1);
            this.Controls.Add(idAlumnosLabel);
            this.Controls.Add(this.idAlumnosComboBox);
            this.Controls.Add(idPeriodoLabel);
            this.Controls.Add(this.idPeriodoComboBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(this.notasBindingNavigator);
            this.Name = "frmNotas";
            this.Text = "frmNotas";
            this.Load += new System.EventHandler(this.frmNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_academicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingNavigator)).EndInit();
            this.notasBindingNavigator.ResumeLayout(false);
            this.notasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_academicaDataSet db_academicaDataSet;
        private System.Windows.Forms.BindingSource notasBindingSource;
        private db_academicaDataSetTableAdapters.notasTableAdapter notasTableAdapter;
        private db_academicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator notasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton notasBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idNotasLabel1;
        private System.Windows.Forms.ComboBox idAlumnosComboBox;
        private System.Windows.Forms.ComboBox idPeriodoComboBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.DataGridView notasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}