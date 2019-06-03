namespace FormaSuSQL
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label drawingIndexLabel;
            System.Windows.Forms.Label startXLabel;
            System.Windows.Forms.Label startYLabel;
            System.Windows.Forms.Label endXLabel;
            System.Windows.Forms.Label endYLabel;
            System.Windows.Forms.Label layerLabel;
            System.Windows.Forms.Label addMicroJointLabel;
            this.robotDataBaseDataSet = new FormaSuSQL.RobotDataBaseDataSet();
            this.lINESQLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lINESQLTableAdapter = new FormaSuSQL.RobotDataBaseDataSetTableAdapters.LINESQLTableAdapter();
            this.tableAdapterManager = new FormaSuSQL.RobotDataBaseDataSetTableAdapters.TableAdapterManager();
            this.lINESQLBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.lINESQLBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.lINESQLDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.drawingInDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drawingInDBTableAdapter = new FormaSuSQL.RobotDataBaseDataSetTableAdapters.DrawingInDBTableAdapter();
            this.drawingInDBDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.drawingIndexTextBox = new System.Windows.Forms.TextBox();
            this.startXTextBox = new System.Windows.Forms.TextBox();
            this.startYTextBox = new System.Windows.Forms.TextBox();
            this.endXTextBox = new System.Windows.Forms.TextBox();
            this.endYTextBox = new System.Windows.Forms.TextBox();
            this.layerTextBox = new System.Windows.Forms.TextBox();
            this.addMicroJointCheckBox = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            drawingIndexLabel = new System.Windows.Forms.Label();
            startXLabel = new System.Windows.Forms.Label();
            startYLabel = new System.Windows.Forms.Label();
            endXLabel = new System.Windows.Forms.Label();
            endYLabel = new System.Windows.Forms.Label();
            layerLabel = new System.Windows.Forms.Label();
            addMicroJointLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.robotDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lINESQLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lINESQLBindingNavigator)).BeginInit();
            this.lINESQLBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lINESQLDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingInDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingInDBDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // robotDataBaseDataSet
            // 
            this.robotDataBaseDataSet.DataSetName = "RobotDataBaseDataSet";
            this.robotDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lINESQLBindingSource
            // 
            this.lINESQLBindingSource.DataMember = "LINESQL";
            this.lINESQLBindingSource.DataSource = this.robotDataBaseDataSet;
            // 
            // lINESQLTableAdapter
            // 
            this.lINESQLTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DrawingInDBTableAdapter = this.drawingInDBTableAdapter;
            this.tableAdapterManager.LINESQLTableAdapter = this.lINESQLTableAdapter;
            this.tableAdapterManager.SheetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FormaSuSQL.RobotDataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UzsakymaiTableAdapter = null;
            // 
            // lINESQLBindingNavigator
            // 
            this.lINESQLBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.lINESQLBindingNavigator.BindingSource = this.lINESQLBindingSource;
            this.lINESQLBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lINESQLBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.lINESQLBindingNavigator.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.lINESQLBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.lINESQLBindingNavigatorSaveItem});
            this.lINESQLBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.lINESQLBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lINESQLBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lINESQLBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lINESQLBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lINESQLBindingNavigator.Name = "lINESQLBindingNavigator";
            this.lINESQLBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lINESQLBindingNavigator.Size = new System.Drawing.Size(1793, 35);
            this.lINESQLBindingNavigator.TabIndex = 0;
            this.lINESQLBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 35);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(61, 30);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
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
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // lINESQLBindingNavigatorSaveItem
            // 
            this.lINESQLBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lINESQLBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lINESQLBindingNavigatorSaveItem.Image")));
            this.lINESQLBindingNavigatorSaveItem.Name = "lINESQLBindingNavigatorSaveItem";
            this.lINESQLBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.lINESQLBindingNavigatorSaveItem.Text = "Save Data";
            this.lINESQLBindingNavigatorSaveItem.Click += new System.EventHandler(this.LINESQLBindingNavigatorSaveItem_Click);
            // 
            // lINESQLDataGridView
            // 
            this.lINESQLDataGridView.AutoGenerateColumns = false;
            this.lINESQLDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lINESQLDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1});
            this.lINESQLDataGridView.DataSource = this.lINESQLBindingSource;
            this.lINESQLDataGridView.Location = new System.Drawing.Point(12, 65);
            this.lINESQLDataGridView.Name = "lINESQLDataGridView";
            this.lINESQLDataGridView.RowTemplate.Height = 31;
            this.lINESQLDataGridView.Size = new System.Drawing.Size(1369, 388);
            this.lINESQLDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DrawingIndex";
            this.dataGridViewTextBoxColumn2.HeaderText = "DrawingIndex";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "StartX";
            this.dataGridViewTextBoxColumn3.HeaderText = "StartX";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StartY";
            this.dataGridViewTextBoxColumn4.HeaderText = "StartY";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EndX";
            this.dataGridViewTextBoxColumn5.HeaderText = "EndX";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "EndY";
            this.dataGridViewTextBoxColumn6.HeaderText = "EndY";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Layer";
            this.dataGridViewTextBoxColumn7.HeaderText = "Layer";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "AddMicroJoint";
            this.dataGridViewCheckBoxColumn1.HeaderText = "AddMicroJoint";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // drawingInDBBindingSource
            // 
            this.drawingInDBBindingSource.DataMember = "DrawingInDB";
            this.drawingInDBBindingSource.DataSource = this.robotDataBaseDataSet;
            // 
            // drawingInDBTableAdapter
            // 
            this.drawingInDBTableAdapter.ClearBeforeFill = true;
            // 
            // drawingInDBDataGridView
            // 
            this.drawingInDBDataGridView.AutoGenerateColumns = false;
            this.drawingInDBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drawingInDBDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21});
            this.drawingInDBDataGridView.DataSource = this.drawingInDBBindingSource;
            this.drawingInDBDataGridView.Location = new System.Drawing.Point(12, 470);
            this.drawingInDBDataGridView.Name = "drawingInDBDataGridView";
            this.drawingInDBDataGridView.RowTemplate.Height = 31;
            this.drawingInDBDataGridView.Size = new System.Drawing.Size(1689, 380);
            this.drawingInDBDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn8.HeaderText = "Id";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "SheetId";
            this.dataGridViewTextBoxColumn9.HeaderText = "SheetId";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "PositionX";
            this.dataGridViewTextBoxColumn10.HeaderText = "PositionX";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "PositionY";
            this.dataGridViewTextBoxColumn11.HeaderText = "PositionY";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Width";
            this.dataGridViewTextBoxColumn12.HeaderText = "Width";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Height";
            this.dataGridViewTextBoxColumn13.HeaderText = "Height";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "AreaFilled";
            this.dataGridViewTextBoxColumn14.HeaderText = "AreaFilled";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "UzsakymoID";
            this.dataGridViewTextBoxColumn15.HeaderText = "UzsakymoID";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Code";
            this.dataGridViewTextBoxColumn16.HeaderText = "Code";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Package";
            this.dataGridViewTextBoxColumn17.HeaderText = "Package";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "MainItem";
            this.dataGridViewTextBoxColumn18.HeaderText = "MainItem";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "TrueName";
            this.dataGridViewTextBoxColumn19.HeaderText = "TrueName";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn20.HeaderText = "Name";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn21.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(1444, 106);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(34, 25);
            idLabel.TabIndex = 3;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lINESQLBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(1604, 103);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(104, 29);
            this.idTextBox.TabIndex = 4;
            // 
            // drawingIndexLabel
            // 
            drawingIndexLabel.AutoSize = true;
            drawingIndexLabel.Location = new System.Drawing.Point(1444, 141);
            drawingIndexLabel.Name = "drawingIndexLabel";
            drawingIndexLabel.Size = new System.Drawing.Size(142, 25);
            drawingIndexLabel.TabIndex = 5;
            drawingIndexLabel.Text = "Drawing Index:";
            // 
            // drawingIndexTextBox
            // 
            this.drawingIndexTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lINESQLBindingSource, "DrawingIndex", true));
            this.drawingIndexTextBox.Location = new System.Drawing.Point(1604, 138);
            this.drawingIndexTextBox.Name = "drawingIndexTextBox";
            this.drawingIndexTextBox.Size = new System.Drawing.Size(104, 29);
            this.drawingIndexTextBox.TabIndex = 6;
            // 
            // startXLabel
            // 
            startXLabel.AutoSize = true;
            startXLabel.Location = new System.Drawing.Point(1444, 176);
            startXLabel.Name = "startXLabel";
            startXLabel.Size = new System.Drawing.Size(78, 25);
            startXLabel.TabIndex = 7;
            startXLabel.Text = "Start X:";
            // 
            // startXTextBox
            // 
            this.startXTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lINESQLBindingSource, "StartX", true));
            this.startXTextBox.Location = new System.Drawing.Point(1604, 173);
            this.startXTextBox.Name = "startXTextBox";
            this.startXTextBox.Size = new System.Drawing.Size(104, 29);
            this.startXTextBox.TabIndex = 8;
            // 
            // startYLabel
            // 
            startYLabel.AutoSize = true;
            startYLabel.Location = new System.Drawing.Point(1444, 211);
            startYLabel.Name = "startYLabel";
            startYLabel.Size = new System.Drawing.Size(77, 25);
            startYLabel.TabIndex = 9;
            startYLabel.Text = "Start Y:";
            // 
            // startYTextBox
            // 
            this.startYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lINESQLBindingSource, "StartY", true));
            this.startYTextBox.Location = new System.Drawing.Point(1604, 208);
            this.startYTextBox.Name = "startYTextBox";
            this.startYTextBox.Size = new System.Drawing.Size(104, 29);
            this.startYTextBox.TabIndex = 10;
            // 
            // endXLabel
            // 
            endXLabel.AutoSize = true;
            endXLabel.Location = new System.Drawing.Point(1444, 246);
            endXLabel.Name = "endXLabel";
            endXLabel.Size = new System.Drawing.Size(72, 25);
            endXLabel.TabIndex = 11;
            endXLabel.Text = "End X:";
            // 
            // endXTextBox
            // 
            this.endXTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lINESQLBindingSource, "EndX", true));
            this.endXTextBox.Location = new System.Drawing.Point(1604, 243);
            this.endXTextBox.Name = "endXTextBox";
            this.endXTextBox.Size = new System.Drawing.Size(104, 29);
            this.endXTextBox.TabIndex = 12;
            // 
            // endYLabel
            // 
            endYLabel.AutoSize = true;
            endYLabel.Location = new System.Drawing.Point(1444, 281);
            endYLabel.Name = "endYLabel";
            endYLabel.Size = new System.Drawing.Size(71, 25);
            endYLabel.TabIndex = 13;
            endYLabel.Text = "End Y:";
            // 
            // endYTextBox
            // 
            this.endYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lINESQLBindingSource, "EndY", true));
            this.endYTextBox.Location = new System.Drawing.Point(1604, 278);
            this.endYTextBox.Name = "endYTextBox";
            this.endYTextBox.Size = new System.Drawing.Size(104, 29);
            this.endYTextBox.TabIndex = 14;
            // 
            // layerLabel
            // 
            layerLabel.AutoSize = true;
            layerLabel.Location = new System.Drawing.Point(1444, 316);
            layerLabel.Name = "layerLabel";
            layerLabel.Size = new System.Drawing.Size(67, 25);
            layerLabel.TabIndex = 15;
            layerLabel.Text = "Layer:";
            // 
            // layerTextBox
            // 
            this.layerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lINESQLBindingSource, "Layer", true));
            this.layerTextBox.Location = new System.Drawing.Point(1604, 313);
            this.layerTextBox.Name = "layerTextBox";
            this.layerTextBox.Size = new System.Drawing.Size(104, 29);
            this.layerTextBox.TabIndex = 16;
            // 
            // addMicroJointLabel
            // 
            addMicroJointLabel.AutoSize = true;
            addMicroJointLabel.Location = new System.Drawing.Point(1444, 353);
            addMicroJointLabel.Name = "addMicroJointLabel";
            addMicroJointLabel.Size = new System.Drawing.Size(154, 25);
            addMicroJointLabel.TabIndex = 17;
            addMicroJointLabel.Text = "Add Micro Joint:";
            // 
            // addMicroJointCheckBox
            // 
            this.addMicroJointCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.lINESQLBindingSource, "AddMicroJoint", true));
            this.addMicroJointCheckBox.Location = new System.Drawing.Point(1604, 348);
            this.addMicroJointCheckBox.Name = "addMicroJointCheckBox";
            this.addMicroJointCheckBox.Size = new System.Drawing.Size(104, 24);
            this.addMicroJointCheckBox.TabIndex = 18;
            this.addMicroJointCheckBox.Text = "checkBox1";
            this.addMicroJointCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(283, 1056);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1793, 1384);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(drawingIndexLabel);
            this.Controls.Add(this.drawingIndexTextBox);
            this.Controls.Add(startXLabel);
            this.Controls.Add(this.startXTextBox);
            this.Controls.Add(startYLabel);
            this.Controls.Add(this.startYTextBox);
            this.Controls.Add(endXLabel);
            this.Controls.Add(this.endXTextBox);
            this.Controls.Add(endYLabel);
            this.Controls.Add(this.endYTextBox);
            this.Controls.Add(layerLabel);
            this.Controls.Add(this.layerTextBox);
            this.Controls.Add(addMicroJointLabel);
            this.Controls.Add(this.addMicroJointCheckBox);
            this.Controls.Add(this.drawingInDBDataGridView);
            this.Controls.Add(this.lINESQLDataGridView);
            this.Controls.Add(this.lINESQLBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.robotDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lINESQLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lINESQLBindingNavigator)).EndInit();
            this.lINESQLBindingNavigator.ResumeLayout(false);
            this.lINESQLBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lINESQLDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingInDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingInDBDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RobotDataBaseDataSet robotDataBaseDataSet;
        private System.Windows.Forms.BindingSource lINESQLBindingSource;
        private RobotDataBaseDataSetTableAdapters.LINESQLTableAdapter lINESQLTableAdapter;
        private RobotDataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator lINESQLBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton lINESQLBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView lINESQLDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private RobotDataBaseDataSetTableAdapters.DrawingInDBTableAdapter drawingInDBTableAdapter;
        private System.Windows.Forms.BindingSource drawingInDBBindingSource;
        private System.Windows.Forms.DataGridView drawingInDBDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox drawingIndexTextBox;
        private System.Windows.Forms.TextBox startXTextBox;
        private System.Windows.Forms.TextBox startYTextBox;
        private System.Windows.Forms.TextBox endXTextBox;
        private System.Windows.Forms.TextBox endYTextBox;
        private System.Windows.Forms.TextBox layerTextBox;
        private System.Windows.Forms.CheckBox addMicroJointCheckBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}

