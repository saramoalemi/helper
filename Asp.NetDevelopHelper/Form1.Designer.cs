namespace Asp.NetDevelopHelper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.prjPathTextbx = new System.Windows.Forms.TextBox();
            this.openPrjPathBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.executeBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tableTxbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.InheretedCheckBox = new System.Windows.Forms.CheckBox();
            this.schemaComboBox = new System.Windows.Forms.ComboBox();
            this.keyTypeCombo = new System.Windows.Forms.ComboBox();
            this.hasYearCheckBox = new System.Windows.Forms.CheckBox();
            this.tableCaptionTxbx = new System.Windows.Forms.TextBox();
            this.yearIndexTxbx = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.undoBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.relationTab = new System.Windows.Forms.TabPage();
            this.relationPanel = new System.Windows.Forms.Panel();
            this.relationDataGridView = new System.Windows.Forms.DataGridView();
            this.propsTab = new System.Windows.Forms.TabPage();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.propertiesDataGridView = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Key = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Unique = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegEx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Required = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.settingTab = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.opnDomainPathBtn = new System.Windows.Forms.Button();
            this.domainPathTxtBx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.opnInfraPathBtn = new System.Windows.Forms.Button();
            this.infraPathTxtBx = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.resourceCreateCheck = new System.Windows.Forms.CheckBox();
            this.opnApplPathBtn = new System.Windows.Forms.Button();
            this.appPathTtextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.coreWebPathTxtBox = new System.Windows.Forms.TextBox();
            this.opnCoreWebPathBtn = new System.Windows.Forms.Button();
            this.modelCreateCheck = new System.Windows.Forms.CheckBox();
            this.dtoCreateCheck = new System.Windows.Forms.CheckBox();
            this.viewModelCreateCheck = new System.Windows.Forms.CheckBox();
            this.repositoryCreateCheck = new System.Windows.Forms.CheckBox();
            this.serviceCreateCheck = new System.Windows.Forms.CheckBox();
            this.controllerCreateCheck = new System.Windows.Forms.CheckBox();
            this.mappingCreateCheck = new System.Windows.Forms.CheckBox();
            this.contextReferenceCreateCheck = new System.Windows.Forms.CheckBox();
            this.relationCreateCheck = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.Schema = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Table = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PrincipalKey = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ForeignKey = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DeleteBehave = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SoftDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SoftRelation = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.topPanel.SuspendLayout();
            this.relationTab.SuspendLayout();
            this.relationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.relationDataGridView)).BeginInit();
            this.propsTab.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesDataGridView)).BeginInit();
            this.settingTab.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // prjPathTextbx
            // 
            this.prjPathTextbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prjPathTextbx.Location = new System.Drawing.Point(379, 11);
            this.prjPathTextbx.Name = "prjPathTextbx";
            this.prjPathTextbx.ReadOnly = true;
            this.prjPathTextbx.Size = new System.Drawing.Size(681, 27);
            this.prjPathTextbx.TabIndex = 0;
            this.prjPathTextbx.TextChanged += new System.EventHandler(this.prjPathTextbx_TextChanged);
            // 
            // openPrjPathBtn
            // 
            this.openPrjPathBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openPrjPathBtn.Location = new System.Drawing.Point(326, 10);
            this.openPrjPathBtn.Name = "openPrjPathBtn";
            this.openPrjPathBtn.Size = new System.Drawing.Size(47, 29);
            this.openPrjPathBtn.TabIndex = 1;
            this.openPrjPathBtn.Text = ". . .";
            this.openPrjPathBtn.UseVisualStyleBackColor = true;
            this.openPrjPathBtn.Click += new System.EventHandler(this.openPrjPathBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1066, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "مسیر پروژه";
            // 
            // executeBtn
            // 
            this.executeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.executeBtn.BackColor = System.Drawing.Color.Lime;
            this.executeBtn.Location = new System.Drawing.Point(25, 9);
            this.executeBtn.Name = "executeBtn";
            this.executeBtn.Size = new System.Drawing.Size(74, 29);
            this.executeBtn.TabIndex = 1;
            this.executeBtn.Text = "اجرا";
            this.executeBtn.UseVisualStyleBackColor = false;
            this.executeBtn.Click += new System.EventHandler(this.executeBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1066, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام اسکیما";
            // 
            // tableTxbx
            // 
            this.tableTxbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableTxbx.Location = new System.Drawing.Point(624, 53);
            this.tableTxbx.Name = "tableTxbx";
            this.tableTxbx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableTxbx.Size = new System.Drawing.Size(202, 27);
            this.tableTxbx.TabIndex = 0;
            this.tableTxbx.TextChanged += new System.EventHandler(this.Txbx_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(832, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "نام جدول";
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.InheretedCheckBox);
            this.topPanel.Controls.Add(this.schemaComboBox);
            this.topPanel.Controls.Add(this.keyTypeCombo);
            this.topPanel.Controls.Add(this.hasYearCheckBox);
            this.topPanel.Controls.Add(this.tableCaptionTxbx);
            this.topPanel.Controls.Add(this.yearIndexTxbx);
            this.topPanel.Controls.Add(this.yearTextBox);
            this.topPanel.Controls.Add(this.tableTxbx);
            this.topPanel.Controls.Add(this.label5);
            this.topPanel.Controls.Add(this.label7);
            this.topPanel.Controls.Add(this.label3);
            this.topPanel.Controls.Add(this.undoBtn);
            this.topPanel.Controls.Add(this.executeBtn);
            this.topPanel.Controls.Add(this.prjPathTextbx);
            this.topPanel.Controls.Add(this.label4);
            this.topPanel.Controls.Add(this.label2);
            this.topPanel.Controls.Add(this.openPrjPathBtn);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1169, 124);
            this.topPanel.TabIndex = 3;
            // 
            // InheretedCheckBox
            // 
            this.InheretedCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InheretedCheckBox.AutoSize = true;
            this.InheretedCheckBox.Checked = true;
            this.InheretedCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.InheretedCheckBox.Location = new System.Drawing.Point(1033, 87);
            this.InheretedCheckBox.Name = "InheretedCheckBox";
            this.InheretedCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.InheretedCheckBox.Size = new System.Drawing.Size(110, 24);
            this.InheretedCheckBox.TabIndex = 7;
            this.InheretedCheckBox.Text = "جدول وراثتی";
            this.InheretedCheckBox.UseVisualStyleBackColor = true;
            // 
            // schemaComboBox
            // 
            this.schemaComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.schemaComboBox.FormattingEnabled = true;
            this.schemaComboBox.Location = new System.Drawing.Point(909, 54);
            this.schemaComboBox.Name = "schemaComboBox";
            this.schemaComboBox.Size = new System.Drawing.Size(151, 28);
            this.schemaComboBox.TabIndex = 5;
            // 
            // keyTypeCombo
            // 
            this.keyTypeCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.keyTypeCombo.FormattingEnabled = true;
            this.keyTypeCombo.Items.AddRange(new object[] {
            "long",
            "int",
            "string"});
            this.keyTypeCombo.Location = new System.Drawing.Point(816, 86);
            this.keyTypeCombo.Name = "keyTypeCombo";
            this.keyTypeCombo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.keyTypeCombo.Size = new System.Drawing.Size(112, 28);
            this.keyTypeCombo.TabIndex = 4;
            this.keyTypeCombo.Text = "long";
            this.keyTypeCombo.SelectedIndexChanged += new System.EventHandler(this.dataTypeCombo_SelectedIndexChanged);
            // 
            // hasYearCheckBox
            // 
            this.hasYearCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hasYearCheckBox.AutoSize = true;
            this.hasYearCheckBox.Checked = true;
            this.hasYearCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hasYearCheckBox.Location = new System.Drawing.Point(675, 87);
            this.hasYearCheckBox.Name = "hasYearCheckBox";
            this.hasYearCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hasYearCheckBox.Size = new System.Drawing.Size(125, 24);
            this.hasYearCheckBox.TabIndex = 3;
            this.hasYearCheckBox.Text = "سال مالی دارد:";
            this.hasYearCheckBox.UseVisualStyleBackColor = true;
            // 
            // tableCaptionTxbx
            // 
            this.tableCaptionTxbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableCaptionTxbx.Location = new System.Drawing.Point(326, 53);
            this.tableCaptionTxbx.Name = "tableCaptionTxbx";
            this.tableCaptionTxbx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableCaptionTxbx.Size = new System.Drawing.Size(178, 27);
            this.tableCaptionTxbx.TabIndex = 0;
            this.tableCaptionTxbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // yearIndexTxbx
            // 
            this.yearIndexTxbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yearIndexTxbx.Location = new System.Drawing.Point(385, 86);
            this.yearIndexTxbx.Name = "yearIndexTxbx";
            this.yearIndexTxbx.Size = new System.Drawing.Size(71, 27);
            this.yearIndexTxbx.TabIndex = 0;
            this.yearIndexTxbx.TextChanged += new System.EventHandler(this.Txbx_TextChanged);
            // 
            // yearTextBox
            // 
            this.yearTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yearTextBox.Location = new System.Drawing.Point(599, 86);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.yearTextBox.Size = new System.Drawing.Size(70, 27);
            this.yearTextBox.TabIndex = 0;
            this.yearTextBox.Text = "Year{}";
            this.yearTextBox.TextChanged += new System.EventHandler(this.Txbx_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(510, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "نام فارسی جدول";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(462, 89);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "ایندکس سال مالی";
            // 
            // undoBtn
            // 
            this.undoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.undoBtn.BackColor = System.Drawing.Color.Red;
            this.undoBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.undoBtn.Location = new System.Drawing.Point(25, 56);
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.Size = new System.Drawing.Size(74, 29);
            this.undoBtn.TabIndex = 1;
            this.undoBtn.Text = "Undo!!!";
            this.undoBtn.UseVisualStyleBackColor = false;
            this.undoBtn.Click += new System.EventHandler(this.undoBtn_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(934, 90);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "کلید وراثتی:";
            // 
            // relationTab
            // 
            this.relationTab.Controls.Add(this.relationPanel);
            this.relationTab.Location = new System.Drawing.Point(4, 29);
            this.relationTab.Name = "relationTab";
            this.relationTab.Padding = new System.Windows.Forms.Padding(3);
            this.relationTab.Size = new System.Drawing.Size(1161, 505);
            this.relationTab.TabIndex = 1;
            this.relationTab.Text = "روابط جدول";
            this.relationTab.UseVisualStyleBackColor = true;
            // 
            // relationPanel
            // 
            this.relationPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.relationPanel.Controls.Add(this.relationDataGridView);
            this.relationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.relationPanel.Location = new System.Drawing.Point(3, 3);
            this.relationPanel.Name = "relationPanel";
            this.relationPanel.Size = new System.Drawing.Size(1155, 499);
            this.relationPanel.TabIndex = 0;
            // 
            // relationDataGridView
            // 
            this.relationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.relationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Schema,
            this.Table,
            this.PrincipalKey,
            this.ForeignKey,
            this.dataGridViewComboBoxColumn1,
            this.DeleteBehave,
            this.SoftDelete,
            this.SoftRelation});
            this.relationDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.relationDataGridView.Location = new System.Drawing.Point(0, 0);
            this.relationDataGridView.Name = "relationDataGridView";
            this.relationDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.relationDataGridView.RowHeadersWidth = 51;
            this.relationDataGridView.RowTemplate.Height = 29;
            this.relationDataGridView.Size = new System.Drawing.Size(1155, 499);
            this.relationDataGridView.TabIndex = 0;
            this.relationDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.relationDataGridView_CellValueChanged);
            // 
            // propsTab
            // 
            this.propsTab.Controls.Add(this.mainPanel);
            this.propsTab.Location = new System.Drawing.Point(4, 29);
            this.propsTab.Name = "propsTab";
            this.propsTab.Padding = new System.Windows.Forms.Padding(3);
            this.propsTab.Size = new System.Drawing.Size(1161, 505);
            this.propsTab.TabIndex = 0;
            this.propsTab.Text = "اطلاعات جدول";
            this.propsTab.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.propertiesDataGridView);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(3, 3);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1155, 499);
            this.mainPanel.TabIndex = 5;
            // 
            // propertiesDataGridView
            // 
            this.propertiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.propertiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PropName,
            this.Caption,
            this.Type,
            this.Required,
            this.MaxLength,
            this.MinLength,
            this.RegEx,
            this.Unique,
            this.Key,
            this.Index});
            this.propertiesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertiesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.propertiesDataGridView.Name = "propertiesDataGridView";
            this.propertiesDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.propertiesDataGridView.RowHeadersWidth = 51;
            this.propertiesDataGridView.RowTemplate.Height = 29;
            this.propertiesDataGridView.Size = new System.Drawing.Size(1155, 499);
            this.propertiesDataGridView.TabIndex = 0;
            this.propertiesDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.propertiesDataGridView_CellValueChanged);
            this.propertiesDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // Index
            // 
            this.Index.HeaderText = "Index";
            this.Index.MinimumWidth = 6;
            this.Index.Name = "Index";
            this.Index.Width = 50;
            // 
            // Key
            // 
            this.Key.HeaderText = "Key";
            this.Key.MinimumWidth = 6;
            this.Key.Name = "Key";
            this.Key.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Key.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Key.Width = 40;
            // 
            // Unique
            // 
            this.Unique.HeaderText = "Unique";
            this.Unique.MinimumWidth = 6;
            this.Unique.Name = "Unique";
            this.Unique.Width = 70;
            // 
            // RegEx
            // 
            this.RegEx.HeaderText = "RegEx";
            this.RegEx.MinimumWidth = 6;
            this.RegEx.Name = "RegEx";
            this.RegEx.Width = 150;
            // 
            // MinLength
            // 
            this.MinLength.HeaderText = "MinLength";
            this.MinLength.MinimumWidth = 6;
            this.MinLength.Name = "MinLength";
            this.MinLength.Width = 90;
            // 
            // MaxLength
            // 
            this.MaxLength.HeaderText = "MaxLength";
            this.MaxLength.MinimumWidth = 6;
            this.MaxLength.Name = "MaxLength";
            this.MaxLength.Width = 90;
            // 
            // Required
            // 
            this.Required.HeaderText = "Required";
            this.Required.MinimumWidth = 6;
            this.Required.Name = "Required";
            this.Required.Width = 70;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.Width = 80;
            // 
            // Caption
            // 
            this.Caption.HeaderText = "Caption";
            this.Caption.MinimumWidth = 6;
            this.Caption.Name = "Caption";
            this.Caption.Width = 200;
            // 
            // PropName
            // 
            this.PropName.HeaderText = "Property";
            this.PropName.MinimumWidth = 6;
            this.PropName.Name = "PropName";
            this.PropName.Width = 250;
            // 
            // settingTab
            // 
            this.settingTab.BackColor = System.Drawing.SystemColors.ControlLight;
            this.settingTab.Controls.Add(this.textBox2);
            this.settingTab.Controls.Add(this.button2);
            this.settingTab.Controls.Add(this.label12);
            this.settingTab.Controls.Add(this.textBox1);
            this.settingTab.Controls.Add(this.button1);
            this.settingTab.Controls.Add(this.label11);
            this.settingTab.Controls.Add(this.relationCreateCheck);
            this.settingTab.Controls.Add(this.contextReferenceCreateCheck);
            this.settingTab.Controls.Add(this.mappingCreateCheck);
            this.settingTab.Controls.Add(this.controllerCreateCheck);
            this.settingTab.Controls.Add(this.serviceCreateCheck);
            this.settingTab.Controls.Add(this.repositoryCreateCheck);
            this.settingTab.Controls.Add(this.viewModelCreateCheck);
            this.settingTab.Controls.Add(this.dtoCreateCheck);
            this.settingTab.Controls.Add(this.modelCreateCheck);
            this.settingTab.Controls.Add(this.opnCoreWebPathBtn);
            this.settingTab.Controls.Add(this.coreWebPathTxtBox);
            this.settingTab.Controls.Add(this.label10);
            this.settingTab.Controls.Add(this.appPathTtextBox);
            this.settingTab.Controls.Add(this.opnApplPathBtn);
            this.settingTab.Controls.Add(this.resourceCreateCheck);
            this.settingTab.Controls.Add(this.label9);
            this.settingTab.Controls.Add(this.infraPathTxtBx);
            this.settingTab.Controls.Add(this.opnInfraPathBtn);
            this.settingTab.Controls.Add(this.label8);
            this.settingTab.Controls.Add(this.domainPathTxtBx);
            this.settingTab.Controls.Add(this.opnDomainPathBtn);
            this.settingTab.Controls.Add(this.label6);
            this.settingTab.Location = new System.Drawing.Point(4, 29);
            this.settingTab.Name = "settingTab";
            this.settingTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingTab.Size = new System.Drawing.Size(1161, 505);
            this.settingTab.TabIndex = 2;
            this.settingTab.Text = "تنظیمات";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(755, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Domain Path";
            // 
            // opnDomainPathBtn
            // 
            this.opnDomainPathBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.opnDomainPathBtn.Location = new System.Drawing.Point(15, 132);
            this.opnDomainPathBtn.Name = "opnDomainPathBtn";
            this.opnDomainPathBtn.Size = new System.Drawing.Size(47, 29);
            this.opnDomainPathBtn.TabIndex = 10;
            this.opnDomainPathBtn.Text = ". . .";
            this.opnDomainPathBtn.UseVisualStyleBackColor = true;
            // 
            // domainPathTxtBx
            // 
            this.domainPathTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.domainPathTxtBx.Location = new System.Drawing.Point(68, 133);
            this.domainPathTxtBx.Name = "domainPathTxtBx";
            this.domainPathTxtBx.ReadOnly = true;
            this.domainPathTxtBx.Size = new System.Drawing.Size(681, 27);
            this.domainPathTxtBx.TabIndex = 9;
            this.domainPathTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(755, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Infrastructure Path";
            // 
            // opnInfraPathBtn
            // 
            this.opnInfraPathBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.opnInfraPathBtn.Location = new System.Drawing.Point(15, 97);
            this.opnInfraPathBtn.Name = "opnInfraPathBtn";
            this.opnInfraPathBtn.Size = new System.Drawing.Size(47, 29);
            this.opnInfraPathBtn.TabIndex = 13;
            this.opnInfraPathBtn.Text = ". . .";
            this.opnInfraPathBtn.UseVisualStyleBackColor = true;
            // 
            // infraPathTxtBx
            // 
            this.infraPathTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.infraPathTxtBx.Location = new System.Drawing.Point(68, 98);
            this.infraPathTxtBx.Name = "infraPathTxtBx";
            this.infraPathTxtBx.ReadOnly = true;
            this.infraPathTxtBx.Size = new System.Drawing.Size(681, 27);
            this.infraPathTxtBx.TabIndex = 12;
            this.infraPathTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(755, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Application Path";
            // 
            // resourceCreateCheck
            // 
            this.resourceCreateCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resourceCreateCheck.AutoSize = true;
            this.resourceCreateCheck.Checked = true;
            this.resourceCreateCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.resourceCreateCheck.Location = new System.Drawing.Point(976, 234);
            this.resourceCreateCheck.Name = "resourceCreateCheck";
            this.resourceCreateCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.resourceCreateCheck.Size = new System.Drawing.Size(163, 24);
            this.resourceCreateCheck.TabIndex = 8;
            this.resourceCreateCheck.Text = "ایجاد/حذف Resource";
            this.resourceCreateCheck.UseVisualStyleBackColor = true;
            // 
            // opnApplPathBtn
            // 
            this.opnApplPathBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.opnApplPathBtn.Location = new System.Drawing.Point(15, 62);
            this.opnApplPathBtn.Name = "opnApplPathBtn";
            this.opnApplPathBtn.Size = new System.Drawing.Size(47, 29);
            this.opnApplPathBtn.TabIndex = 16;
            this.opnApplPathBtn.Text = ". . .";
            this.opnApplPathBtn.UseVisualStyleBackColor = true;
            // 
            // appPathTtextBox
            // 
            this.appPathTtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.appPathTtextBox.Location = new System.Drawing.Point(68, 63);
            this.appPathTtextBox.Name = "appPathTtextBox";
            this.appPathTtextBox.ReadOnly = true;
            this.appPathTtextBox.Size = new System.Drawing.Size(681, 27);
            this.appPathTtextBox.TabIndex = 15;
            this.appPathTtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(755, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Asp.net Core Path";
            // 
            // coreWebPathTxtBox
            // 
            this.coreWebPathTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coreWebPathTxtBox.Location = new System.Drawing.Point(68, 24);
            this.coreWebPathTxtBox.Name = "coreWebPathTxtBox";
            this.coreWebPathTxtBox.ReadOnly = true;
            this.coreWebPathTxtBox.Size = new System.Drawing.Size(681, 27);
            this.coreWebPathTxtBox.TabIndex = 18;
            this.coreWebPathTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // opnCoreWebPathBtn
            // 
            this.opnCoreWebPathBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.opnCoreWebPathBtn.Location = new System.Drawing.Point(15, 27);
            this.opnCoreWebPathBtn.Name = "opnCoreWebPathBtn";
            this.opnCoreWebPathBtn.Size = new System.Drawing.Size(47, 29);
            this.opnCoreWebPathBtn.TabIndex = 20;
            this.opnCoreWebPathBtn.Text = ". . .";
            this.opnCoreWebPathBtn.UseVisualStyleBackColor = true;
            // 
            // modelCreateCheck
            // 
            this.modelCreateCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modelCreateCheck.AutoSize = true;
            this.modelCreateCheck.Checked = true;
            this.modelCreateCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.modelCreateCheck.Location = new System.Drawing.Point(993, 24);
            this.modelCreateCheck.Name = "modelCreateCheck";
            this.modelCreateCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.modelCreateCheck.Size = new System.Drawing.Size(146, 24);
            this.modelCreateCheck.TabIndex = 21;
            this.modelCreateCheck.Text = "ایجاد/حذف Model";
            this.modelCreateCheck.UseVisualStyleBackColor = true;
            // 
            // dtoCreateCheck
            // 
            this.dtoCreateCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtoCreateCheck.AutoSize = true;
            this.dtoCreateCheck.Checked = true;
            this.dtoCreateCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dtoCreateCheck.Location = new System.Drawing.Point(1011, 54);
            this.dtoCreateCheck.Name = "dtoCreateCheck";
            this.dtoCreateCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtoCreateCheck.Size = new System.Drawing.Size(128, 24);
            this.dtoCreateCheck.TabIndex = 22;
            this.dtoCreateCheck.Text = "ایجاد/حذف Dto";
            this.dtoCreateCheck.UseVisualStyleBackColor = true;
            // 
            // viewModelCreateCheck
            // 
            this.viewModelCreateCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.viewModelCreateCheck.AutoSize = true;
            this.viewModelCreateCheck.Checked = true;
            this.viewModelCreateCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewModelCreateCheck.Location = new System.Drawing.Point(961, 84);
            this.viewModelCreateCheck.Name = "viewModelCreateCheck";
            this.viewModelCreateCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.viewModelCreateCheck.Size = new System.Drawing.Size(178, 24);
            this.viewModelCreateCheck.TabIndex = 23;
            this.viewModelCreateCheck.Text = "ایجاد/حذف ViewModel";
            this.viewModelCreateCheck.UseVisualStyleBackColor = true;
            // 
            // repositoryCreateCheck
            // 
            this.repositoryCreateCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.repositoryCreateCheck.AutoSize = true;
            this.repositoryCreateCheck.Checked = true;
            this.repositoryCreateCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.repositoryCreateCheck.Location = new System.Drawing.Point(965, 144);
            this.repositoryCreateCheck.Name = "repositoryCreateCheck";
            this.repositoryCreateCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.repositoryCreateCheck.Size = new System.Drawing.Size(174, 24);
            this.repositoryCreateCheck.TabIndex = 24;
            this.repositoryCreateCheck.Text = "ایجاد/حذف Repository";
            this.repositoryCreateCheck.UseVisualStyleBackColor = true;
            // 
            // serviceCreateCheck
            // 
            this.serviceCreateCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceCreateCheck.AutoSize = true;
            this.serviceCreateCheck.Checked = true;
            this.serviceCreateCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.serviceCreateCheck.Location = new System.Drawing.Point(989, 174);
            this.serviceCreateCheck.Name = "serviceCreateCheck";
            this.serviceCreateCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.serviceCreateCheck.Size = new System.Drawing.Size(150, 24);
            this.serviceCreateCheck.TabIndex = 25;
            this.serviceCreateCheck.Text = "ایجاد/حذف Service";
            this.serviceCreateCheck.UseVisualStyleBackColor = true;
            // 
            // controllerCreateCheck
            // 
            this.controllerCreateCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controllerCreateCheck.AutoSize = true;
            this.controllerCreateCheck.Checked = true;
            this.controllerCreateCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.controllerCreateCheck.Location = new System.Drawing.Point(970, 204);
            this.controllerCreateCheck.Name = "controllerCreateCheck";
            this.controllerCreateCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.controllerCreateCheck.Size = new System.Drawing.Size(169, 24);
            this.controllerCreateCheck.TabIndex = 26;
            this.controllerCreateCheck.Text = "ایجاد/حذف Controller";
            this.controllerCreateCheck.UseVisualStyleBackColor = true;
            // 
            // mappingCreateCheck
            // 
            this.mappingCreateCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mappingCreateCheck.AutoSize = true;
            this.mappingCreateCheck.Checked = true;
            this.mappingCreateCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mappingCreateCheck.Location = new System.Drawing.Point(976, 114);
            this.mappingCreateCheck.Name = "mappingCreateCheck";
            this.mappingCreateCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mappingCreateCheck.Size = new System.Drawing.Size(163, 24);
            this.mappingCreateCheck.TabIndex = 27;
            this.mappingCreateCheck.Text = "ایجاد/حذف Mapping";
            this.mappingCreateCheck.UseVisualStyleBackColor = true;
            // 
            // contextReferenceCreateCheck
            // 
            this.contextReferenceCreateCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contextReferenceCreateCheck.AutoSize = true;
            this.contextReferenceCreateCheck.Checked = true;
            this.contextReferenceCreateCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.contextReferenceCreateCheck.Location = new System.Drawing.Point(940, 264);
            this.contextReferenceCreateCheck.Name = "contextReferenceCreateCheck";
            this.contextReferenceCreateCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextReferenceCreateCheck.Size = new System.Drawing.Size(199, 24);
            this.contextReferenceCreateCheck.TabIndex = 28;
            this.contextReferenceCreateCheck.Text = "ایجاد/حذف رفرنس Context";
            this.contextReferenceCreateCheck.UseVisualStyleBackColor = true;
            // 
            // relationCreateCheck
            // 
            this.relationCreateCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.relationCreateCheck.AutoSize = true;
            this.relationCreateCheck.Checked = true;
            this.relationCreateCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.relationCreateCheck.Location = new System.Drawing.Point(1001, 294);
            this.relationCreateCheck.Name = "relationCreateCheck";
            this.relationCreateCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.relationCreateCheck.Size = new System.Drawing.Size(138, 24);
            this.relationCreateCheck.TabIndex = 29;
            this.relationCreateCheck.Text = "ایجاد/حذف روابط";
            this.relationCreateCheck.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(755, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "Mapper Path";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(15, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 29);
            this.button1.TabIndex = 31;
            this.button1.Text = ". . .";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(68, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(681, 27);
            this.textBox1.TabIndex = 30;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(755, 207);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 20);
            this.label12.TabIndex = 35;
            this.label12.Text = "Context Path";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(15, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 29);
            this.button2.TabIndex = 34;
            this.button2.Text = ". . .";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(68, 204);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(681, 27);
            this.textBox2.TabIndex = 33;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.settingTab);
            this.mainTabControl.Controls.Add(this.propsTab);
            this.mainTabControl.Controls.Add(this.relationTab);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 124);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mainTabControl.RightToLeftLayout = true;
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1169, 538);
            this.mainTabControl.TabIndex = 5;
            // 
            // Schema
            // 
            this.Schema.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Schema.DefaultCellStyle = dataGridViewCellStyle1;
            this.Schema.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Schema.Frozen = true;
            this.Schema.HeaderText = "Schema";
            this.Schema.MinimumWidth = 150;
            this.Schema.Name = "Schema";
            this.Schema.Width = 150;
            // 
            // Table
            // 
            this.Table.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Table.HeaderText = "Table";
            this.Table.MinimumWidth = 150;
            this.Table.Name = "Table";
            this.Table.Width = 150;
            // 
            // PrincipalKey
            // 
            this.PrincipalKey.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PrincipalKey.HeaderText = "PrincipalKey";
            this.PrincipalKey.MinimumWidth = 150;
            this.PrincipalKey.Name = "PrincipalKey";
            this.PrincipalKey.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PrincipalKey.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PrincipalKey.Width = 150;
            // 
            // ForeignKey
            // 
            this.ForeignKey.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ForeignKey.HeaderText = "ForeignKey";
            this.ForeignKey.MinimumWidth = 150;
            this.ForeignKey.Name = "ForeignKey";
            this.ForeignKey.Width = 150;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.HeaderText = "Type";
            this.dataGridViewComboBoxColumn1.Items.AddRange(new object[] {
            "One2Many",
            "One2One",
            "Many2Many"});
            this.dataGridViewComboBoxColumn1.MinimumWidth = 6;
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Width = 125;
            // 
            // DeleteBehave
            // 
            this.DeleteBehave.HeaderText = "DeleteBehave";
            this.DeleteBehave.Items.AddRange(new object[] {
            "NoAction",
            "Cascade",
            "SetNull"});
            this.DeleteBehave.MinimumWidth = 6;
            this.DeleteBehave.Name = "DeleteBehave";
            this.DeleteBehave.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteBehave.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DeleteBehave.Width = 125;
            // 
            // SoftDelete
            // 
            this.SoftDelete.HeaderText = "SoftDelete";
            this.SoftDelete.MinimumWidth = 6;
            this.SoftDelete.Name = "SoftDelete";
            // 
            // SoftRelation
            // 
            this.SoftRelation.HeaderText = "SoftRelation";
            this.SoftRelation.MinimumWidth = 6;
            this.SoftRelation.Name = "SoftRelation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 662);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.topPanel);
            this.MinimumSize = new System.Drawing.Size(886, 709);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.relationTab.ResumeLayout(false);
            this.relationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.relationDataGridView)).EndInit();
            this.propsTab.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.propertiesDataGridView)).EndInit();
            this.settingTab.ResumeLayout(false);
            this.settingTab.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox prjPathTextbx;
        private Button openPrjPathBtn;
        private Label label1;
        private Button executeBtn;
        private Label label2;
        private TextBox tableTxbx;
        private Label label3;
        private Panel topPanel;
        private TextBox tableCaptionTxbx;
        private Label label5;
        private CheckBox hasYearCheckBox;
        private TextBox yearTextBox;
        private Button undoBtn;
        private ComboBox keyTypeCombo;
        private TextBox yearIndexTxbx;
        private Label label7;
        private ComboBox schemaComboBox;
        private CheckBox InheretedCheckBox;
        private Label label4;
        private TabPage relationTab;
        private Panel relationPanel;
        private DataGridView relationDataGridView;
        private DataGridViewComboBoxColumn Schema;
        private DataGridViewComboBoxColumn Table;
        private DataGridViewComboBoxColumn PrincipalKey;
        private DataGridViewComboBoxColumn ForeignKey;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private DataGridViewComboBoxColumn DeleteBehave;
        private DataGridViewCheckBoxColumn SoftDelete;
        private DataGridViewCheckBoxColumn SoftRelation;
        private TabPage propsTab;
        private Panel mainPanel;
        private DataGridView propertiesDataGridView;
        private DataGridViewTextBoxColumn PropName;
        private DataGridViewTextBoxColumn Caption;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewCheckBoxColumn Required;
        private DataGridViewTextBoxColumn MaxLength;
        private DataGridViewTextBoxColumn MinLength;
        private DataGridViewTextBoxColumn RegEx;
        private DataGridViewTextBoxColumn Unique;
        private DataGridViewCheckBoxColumn Key;
        private DataGridViewCheckBoxColumn Index;
        private TabPage settingTab;
        private TextBox textBox2;
        private Button button2;
        private Label label12;
        private TextBox textBox1;
        private Button button1;
        private Label label11;
        private CheckBox relationCreateCheck;
        private CheckBox contextReferenceCreateCheck;
        private CheckBox mappingCreateCheck;
        private CheckBox controllerCreateCheck;
        private CheckBox serviceCreateCheck;
        private CheckBox repositoryCreateCheck;
        private CheckBox viewModelCreateCheck;
        private CheckBox dtoCreateCheck;
        private CheckBox modelCreateCheck;
        private Button opnCoreWebPathBtn;
        private TextBox coreWebPathTxtBox;
        private Label label10;
        private TextBox appPathTtextBox;
        private Button opnApplPathBtn;
        private CheckBox resourceCreateCheck;
        private Label label9;
        private TextBox infraPathTxtBx;
        private Button opnInfraPathBtn;
        private Label label8;
        private TextBox domainPathTxtBx;
        private Button opnDomainPathBtn;
        private Label label6;
        private TabControl mainTabControl;
    }
}