<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Account_NoLabel As System.Windows.Forms.Label
        Dim Customer_NameLabel As System.Windows.Forms.Label
        Dim Customer_AddressLabel As System.Windows.Forms.Label
        Dim TariffLabel As System.Windows.Forms.Label
        Dim Meter_NoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Current_ReadingTextBox = New System.Windows.Forms.TextBox()
        Me.Meter_ReadingsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Electricity_CustomersDataSet = New _1st_Year_Project.Electricity_CustomersDataSet()
        Me.Current_Reading_DateDateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Previous_Reading_DateDateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Previous_ReadingLabel1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaButton3 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.TariffLabel2 = New System.Windows.Forms.Label()
        Me.Meter_NoLabel2 = New System.Windows.Forms.Label()
        Me.Customer_AddressLabel2 = New System.Windows.Forms.Label()
        Me.Customer_NameLabel2 = New System.Windows.Forms.Label()
        Me.Account_NoLabel2 = New System.Windows.Forms.Label()
        Me.GunaGroupBox2 = New Guna.UI.WinForms.GunaGroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Meter_ReadingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New _1st_Year_Project.Electricity_CustomersDataSetTableAdapters.CustomerTableAdapter()
        Me.TableAdapterManager = New _1st_Year_Project.Electricity_CustomersDataSetTableAdapters.TableAdapterManager()
        Me.CustomerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CustomerBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CustomerTableAdapter1 = New _1st_Year_Project.Electricity_CustomersDataSetTableAdapters.CustomerTableAdapter()
        Me.CustomerTableAdapter2 = New _1st_Year_Project.Electricity_CustomersDataSetTableAdapters.CustomerTableAdapter()
        Me.Meter_ReadingsTableAdapter = New _1st_Year_Project.Electricity_CustomersDataSet1TableAdapters.Meter_ReadingsTableAdapter()
        Me.TableAdapterManager1 = New _1st_Year_Project.Electricity_CustomersDataSet1TableAdapters.TableAdapterManager()
        Me.Meter_ReadingsTableAdapter1 = New _1st_Year_Project.Electricity_CustomersDataSetTableAdapters.Meter_ReadingsTableAdapter()
        Me.Electricity_CustomersDataSet1 = New _1st_Year_Project.Electricity_CustomersDataSet1()
        Account_NoLabel = New System.Windows.Forms.Label()
        Customer_NameLabel = New System.Windows.Forms.Label()
        Customer_AddressLabel = New System.Windows.Forms.Label()
        TariffLabel = New System.Windows.Forms.Label()
        Meter_NoLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Meter_ReadingsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Electricity_CustomersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGroupBox1.SuspendLayout()
        Me.GunaGroupBox2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.Meter_ReadingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomerBindingNavigator.SuspendLayout()
        CType(Me.Electricity_CustomersDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Account_NoLabel
        '
        Account_NoLabel.AutoSize = True
        Account_NoLabel.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Account_NoLabel.Location = New System.Drawing.Point(17, 34)
        Account_NoLabel.Name = "Account_NoLabel"
        Account_NoLabel.Size = New System.Drawing.Size(134, 34)
        Account_NoLabel.TabIndex = 2
        Account_NoLabel.Text = "Account No:"
        '
        'Customer_NameLabel
        '
        Customer_NameLabel.AutoSize = True
        Customer_NameLabel.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Customer_NameLabel.Location = New System.Drawing.Point(17, 80)
        Customer_NameLabel.Name = "Customer_NameLabel"
        Customer_NameLabel.Size = New System.Drawing.Size(182, 34)
        Customer_NameLabel.TabIndex = 3
        Customer_NameLabel.Text = "Customer Name:"
        '
        'Customer_AddressLabel
        '
        Customer_AddressLabel.AutoSize = True
        Customer_AddressLabel.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Customer_AddressLabel.Location = New System.Drawing.Point(17, 127)
        Customer_AddressLabel.Name = "Customer_AddressLabel"
        Customer_AddressLabel.Size = New System.Drawing.Size(201, 34)
        Customer_AddressLabel.TabIndex = 4
        Customer_AddressLabel.Text = "Customer Address:"
        '
        'TariffLabel
        '
        TariffLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TariffLabel.AutoSize = True
        TariffLabel.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TariffLabel.Location = New System.Drawing.Point(687, 80)
        TariffLabel.Name = "TariffLabel"
        TariffLabel.Size = New System.Drawing.Size(69, 34)
        TariffLabel.TabIndex = 13
        TariffLabel.Text = "Tariff:"
        '
        'Meter_NoLabel
        '
        Meter_NoLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Meter_NoLabel.AutoSize = True
        Meter_NoLabel.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Meter_NoLabel.Location = New System.Drawing.Point(687, 35)
        Meter_NoLabel.Name = "Meter_NoLabel"
        Meter_NoLabel.Size = New System.Drawing.Size(111, 34)
        Meter_NoLabel.TabIndex = 11
        Meter_NoLabel.Text = "Meter No:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.60619!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.39381!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1556, 904)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoScroll = True
        Me.TableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.84825!))
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 130)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1544, 768)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.Label43)
        Me.GroupBox1.Controls.Add(Me.Current_ReadingTextBox)
        Me.GroupBox1.Controls.Add(Me.Current_Reading_DateDateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Previous_Reading_DateDateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Previous_ReadingLabel1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GunaButton3)
        Me.GroupBox1.Controls.Add(Me.GunaButton2)
        Me.GroupBox1.Controls.Add(Me.GunaButton1)
        Me.GroupBox1.Controls.Add(Me.GunaGroupBox1)
        Me.GroupBox1.Controls.Add(Me.GunaGroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(5, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1534, 758)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Label43
        '
        Me.Label43.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(6, 727)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(193, 24)
        Me.Label43.TabIndex = 43
        Me.Label43.Text = "© Thiwanka Imalshan"
        '
        'Current_ReadingTextBox
        '
        Me.Current_ReadingTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Current_ReadingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Meter_ReadingsBindingSource1, "Current_Reading", True))
        Me.Current_ReadingTextBox.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Current_ReadingTextBox.Location = New System.Drawing.Point(901, 367)
        Me.Current_ReadingTextBox.Name = "Current_ReadingTextBox"
        Me.Current_ReadingTextBox.Size = New System.Drawing.Size(190, 32)
        Me.Current_ReadingTextBox.TabIndex = 42
        '
        'Meter_ReadingsBindingSource1
        '
        Me.Meter_ReadingsBindingSource1.DataMember = "CustomerMeter_Readings"
        Me.Meter_ReadingsBindingSource1.DataSource = Me.CustomerBindingSource
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.Electricity_CustomersDataSet
        '
        'Electricity_CustomersDataSet
        '
        Me.Electricity_CustomersDataSet.DataSetName = "Electricity_CustomersDataSet"
        Me.Electricity_CustomersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Current_Reading_DateDateTimePicker1
        '
        Me.Current_Reading_DateDateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Current_Reading_DateDateTimePicker1.CustomFormat = "    dd / MM / yyyy"
        Me.Current_Reading_DateDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Meter_ReadingsBindingSource1, "Current_Reading_Date", True))
        Me.Current_Reading_DateDateTimePicker1.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Current_Reading_DateDateTimePicker1.Location = New System.Drawing.Point(235, 366)
        Me.Current_Reading_DateDateTimePicker1.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Current_Reading_DateDateTimePicker1.Name = "Current_Reading_DateDateTimePicker1"
        Me.Current_Reading_DateDateTimePicker1.Size = New System.Drawing.Size(420, 32)
        Me.Current_Reading_DateDateTimePicker1.TabIndex = 41
        '
        'Previous_Reading_DateDateTimePicker1
        '
        Me.Previous_Reading_DateDateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Previous_Reading_DateDateTimePicker1.CustomFormat = "    dd / MM / yyyy"
        Me.Previous_Reading_DateDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Meter_ReadingsBindingSource1, "Previous_Reading_Date", True))
        Me.Previous_Reading_DateDateTimePicker1.Enabled = False
        Me.Previous_Reading_DateDateTimePicker1.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Previous_Reading_DateDateTimePicker1.Location = New System.Drawing.Point(235, 314)
        Me.Previous_Reading_DateDateTimePicker1.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Previous_Reading_DateDateTimePicker1.Name = "Previous_Reading_DateDateTimePicker1"
        Me.Previous_Reading_DateDateTimePicker1.Size = New System.Drawing.Size(420, 32)
        Me.Previous_Reading_DateDateTimePicker1.TabIndex = 40
        '
        'Previous_ReadingLabel1
        '
        Me.Previous_ReadingLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Previous_ReadingLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Meter_ReadingsBindingSource1, "Previous_Reading", True))
        Me.Previous_ReadingLabel1.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Previous_ReadingLabel1.Location = New System.Drawing.Point(895, 312)
        Me.Previous_ReadingLabel1.Name = "Previous_ReadingLabel1"
        Me.Previous_ReadingLabel1.Size = New System.Drawing.Size(202, 31)
        Me.Previous_ReadingLabel1.TabIndex = 39
        Me.Previous_ReadingLabel1.Text = "Previous Reading"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(682, 364)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(179, 34)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Current Reading"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(683, 312)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(185, 34)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Previous Reading"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(61, 364)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 34)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Current Date"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(61, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 34)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Previous Date"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(401, 535)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(229, 25)
        Me.TextBox3.TabIndex = 26
        Me.TextBox3.Text = "No of Units"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(401, 485)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(229, 25)
        Me.TextBox2.TabIndex = 25
        Me.TextBox2.Text = "No of Days"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(70, 534)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(235, 34)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "No of Units Consumed"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(70, 485)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 34)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "No of Days"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(783, 251)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 40)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Meter Reading"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(394, 251)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 40)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Date"
        '
        'GunaButton3
        '
        Me.GunaButton3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GunaButton3.AnimationHoverSpeed = 0.07!
        Me.GunaButton3.AnimationSpeed = 0.03!
        Me.GunaButton3.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton3.BaseColor = System.Drawing.Color.White
        Me.GunaButton3.BorderColor = System.Drawing.Color.MediumBlue
        Me.GunaButton3.BorderSize = 1
        Me.GunaButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton3.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton3.ForeColor = System.Drawing.Color.MediumBlue
        Me.GunaButton3.Image = Nothing
        Me.GunaButton3.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton3.Location = New System.Drawing.Point(840, 641)
        Me.GunaButton3.Name = "GunaButton3"
        Me.GunaButton3.OnHoverBaseColor = System.Drawing.Color.MediumBlue
        Me.GunaButton3.OnHoverBorderColor = System.Drawing.Color.White
        Me.GunaButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton3.OnHoverImage = Nothing
        Me.GunaButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton3.Radius = 10
        Me.GunaButton3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GunaButton3.Size = New System.Drawing.Size(160, 42)
        Me.GunaButton3.TabIndex = 15
        Me.GunaButton3.Text = "Next"
        Me.GunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButton2
        '
        Me.GunaButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton2.BaseColor = System.Drawing.Color.White
        Me.GunaButton2.BorderColor = System.Drawing.Color.MediumBlue
        Me.GunaButton2.BorderSize = 1
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton2.ForeColor = System.Drawing.Color.MediumBlue
        Me.GunaButton2.Image = Nothing
        Me.GunaButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton2.Location = New System.Drawing.Point(126, 641)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.MediumBlue
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Radius = 10
        Me.GunaButton2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GunaButton2.Size = New System.Drawing.Size(160, 42)
        Me.GunaButton2.TabIndex = 14
        Me.GunaButton2.Text = "Previous"
        Me.GunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButton1
        '
        Me.GunaButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.MediumBlue
        Me.GunaButton1.BorderColor = System.Drawing.Color.White
        Me.GunaButton1.BorderSize = 1
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Montserrat", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(454, 641)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.MediumBlue
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.MediumBlue
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Radius = 10
        Me.GunaButton1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GunaButton1.Size = New System.Drawing.Size(227, 55)
        Me.GunaButton1.TabIndex = 13
        Me.GunaButton1.Text = "Calculate"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BorderSize = 3
        Me.GunaGroupBox1.Controls.Add(Me.TariffLabel2)
        Me.GunaGroupBox1.Controls.Add(Me.Meter_NoLabel2)
        Me.GunaGroupBox1.Controls.Add(Me.Customer_AddressLabel2)
        Me.GunaGroupBox1.Controls.Add(Me.Customer_NameLabel2)
        Me.GunaGroupBox1.Controls.Add(Me.Account_NoLabel2)
        Me.GunaGroupBox1.Controls.Add(TariffLabel)
        Me.GunaGroupBox1.Controls.Add(Account_NoLabel)
        Me.GunaGroupBox1.Controls.Add(Meter_NoLabel)
        Me.GunaGroupBox1.Controls.Add(Customer_NameLabel)
        Me.GunaGroupBox1.Controls.Add(Customer_AddressLabel)
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.Location = New System.Drawing.Point(45, 31)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Radius = 15
        Me.GunaGroupBox1.Size = New System.Drawing.Size(1071, 190)
        Me.GunaGroupBox1.TabIndex = 11
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'TariffLabel2
        '
        Me.TariffLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TariffLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Tariff", True))
        Me.TariffLabel2.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TariffLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TariffLabel2.Location = New System.Drawing.Point(826, 83)
        Me.TariffLabel2.Name = "TariffLabel2"
        Me.TariffLabel2.Size = New System.Drawing.Size(185, 31)
        Me.TariffLabel2.TabIndex = 40
        Me.TariffLabel2.Text = "Tariff"
        '
        'Meter_NoLabel2
        '
        Me.Meter_NoLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Meter_NoLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Meter_No", True))
        Me.Meter_NoLabel2.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Meter_NoLabel2.Location = New System.Drawing.Point(826, 38)
        Me.Meter_NoLabel2.Name = "Meter_NoLabel2"
        Me.Meter_NoLabel2.Size = New System.Drawing.Size(185, 30)
        Me.Meter_NoLabel2.TabIndex = 40
        Me.Meter_NoLabel2.Text = "Meter No"
        '
        'Customer_AddressLabel2
        '
        Me.Customer_AddressLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Customer_Address", True))
        Me.Customer_AddressLabel2.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Customer_AddressLabel2.Location = New System.Drawing.Point(256, 130)
        Me.Customer_AddressLabel2.Name = "Customer_AddressLabel2"
        Me.Customer_AddressLabel2.Size = New System.Drawing.Size(437, 31)
        Me.Customer_AddressLabel2.TabIndex = 40
        Me.Customer_AddressLabel2.Text = "Customer Address"
        '
        'Customer_NameLabel2
        '
        Me.Customer_NameLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Customer_Name", True))
        Me.Customer_NameLabel2.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Customer_NameLabel2.Location = New System.Drawing.Point(256, 83)
        Me.Customer_NameLabel2.Name = "Customer_NameLabel2"
        Me.Customer_NameLabel2.Size = New System.Drawing.Size(337, 31)
        Me.Customer_NameLabel2.TabIndex = 40
        Me.Customer_NameLabel2.Text = "Customer Name"
        '
        'Account_NoLabel2
        '
        Me.Account_NoLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Meter_ReadingsBindingSource1, "Account_No", True))
        Me.Account_NoLabel2.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Account_NoLabel2.Location = New System.Drawing.Point(256, 37)
        Me.Account_NoLabel2.Name = "Account_NoLabel2"
        Me.Account_NoLabel2.Size = New System.Drawing.Size(337, 31)
        Me.Account_NoLabel2.TabIndex = 39
        Me.Account_NoLabel2.Text = "Account No"
        '
        'GunaGroupBox2
        '
        Me.GunaGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GunaGroupBox2.BorderColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox2.BorderSize = 3
        Me.GunaGroupBox2.Controls.Add(Me.TableLayoutPanel3)
        Me.GunaGroupBox2.Controls.Add(Me.TableLayoutPanel5)
        Me.GunaGroupBox2.Controls.Add(Me.Label47)
        Me.GunaGroupBox2.Controls.Add(Me.Label48)
        Me.GunaGroupBox2.LineColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox2.Location = New System.Drawing.Point(1144, 31)
        Me.GunaGroupBox2.Name = "GunaGroupBox2"
        Me.GunaGroupBox2.Radius = 15
        Me.GunaGroupBox2.Size = New System.Drawing.Size(373, 709)
        Me.GunaGroupBox2.TabIndex = 10
        Me.GunaGroupBox2.TextLocation = New System.Drawing.Point(10, 8)
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label42, 3, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.Label41, 2, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.Label40, 1, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.Label39, 0, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.Label38, 3, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.Label37, 2, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.Label36, 1, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.Label35, 0, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.Label34, 3, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Label33, 2, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Label32, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Label31, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Label30, 3, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label28, 2, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label27, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label24, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label23, 3, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label19, 2, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label18, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label17, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label16, 3, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label15, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label14, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label13, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label12, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label11, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label9, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label10, 1, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(19, 83)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 7
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.07724!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.81933!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.82069!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.82069!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.82069!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.82069!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.82069!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(334, 307)
        Me.TableLayoutPanel3.TabIndex = 4
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label42.Location = New System.Drawing.Point(236, 265)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(39, 30)
        Me.Label42.TabIndex = 27
        Me.Label42.Text = "00"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label41.Location = New System.Drawing.Point(160, 265)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(39, 30)
        Me.Label41.TabIndex = 26
        Me.Label41.Text = "00"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(88, 265)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(60, 30)
        Me.Label40.TabIndex = 25
        Me.Label40.Text = "Rs.89"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(3, 265)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(53, 30)
        Me.Label39.TabIndex = 24
        Me.Label39.Text = "180>"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label38.Location = New System.Drawing.Point(236, 226)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(39, 30)
        Me.Label38.TabIndex = 23
        Me.Label38.Text = "00"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label37.Location = New System.Drawing.Point(160, 226)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(39, 30)
        Me.Label37.TabIndex = 22
        Me.Label37.Text = "00"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(88, 226)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(60, 30)
        Me.Label36.TabIndex = 21
        Me.Label36.Text = "Rs.59"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(3, 226)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(75, 30)
        Me.Label35.TabIndex = 20
        Me.Label35.Text = "121-180"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label34.Location = New System.Drawing.Point(236, 187)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(39, 30)
        Me.Label34.TabIndex = 19
        Me.Label34.Text = "00"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label33.Location = New System.Drawing.Point(160, 187)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(39, 30)
        Me.Label33.TabIndex = 18
        Me.Label33.Text = "00"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(88, 187)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(60, 30)
        Me.Label32.TabIndex = 17
        Me.Label32.Text = "Rs.59"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(3, 187)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(68, 30)
        Me.Label31.TabIndex = 16
        Me.Label31.Text = "91-120"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label30.Location = New System.Drawing.Point(236, 148)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(39, 30)
        Me.Label30.TabIndex = 15
        Me.Label30.Text = "00"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(160, 148)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(39, 30)
        Me.Label28.TabIndex = 14
        Me.Label28.Text = "00"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(88, 148)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(56, 30)
        Me.Label27.TabIndex = 13
        Me.Label27.Text = "Rs.41"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(3, 148)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(62, 30)
        Me.Label24.TabIndex = 12
        Me.Label24.Text = "61-90"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(236, 109)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(39, 30)
        Me.Label23.TabIndex = 11
        Me.Label23.Text = "00"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(160, 109)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(39, 30)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "00"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(88, 109)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(62, 30)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "Rs.30"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 109)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 30)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "31-60"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(236, 70)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 30)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "00"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(160, 70)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 30)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "00"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(88, 70)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 30)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Rs.12"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 70)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 30)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "0-30"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(236, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 30)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Charge"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(160, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 30)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Units"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 60)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Tariff Block"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(88, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 60)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Unit Rate"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.49701!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.50299!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label25, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label26, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label29, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.Label20, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label21, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label22, 1, 2)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(19, 547)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 3
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.98795!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(334, 128)
        Me.TableLayoutPanel5.TabIndex = 3
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(3, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(165, 30)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Charges for Units"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(3, 36)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(130, 30)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "Fixed Charge"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(3, 72)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(129, 40)
        Me.Label29.TabIndex = 5
        Me.Label29.Text = "Total Bill"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(175, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(39, 30)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "00"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(175, 36)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(39, 30)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "00"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(175, 72)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(53, 40)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "00"
        '
        'Label47
        '
        Me.Label47.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Label47.Location = New System.Drawing.Point(79, 492)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(213, 40)
        Me.Label47.TabIndex = 1
        Me.Label47.Text = "Bill Calculation"
        '
        'Label48
        '
        Me.Label48.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Label48.Location = New System.Drawing.Point(72, 18)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(237, 40)
        Me.Label48.TabIndex = 0
        Me.Label48.Text = "Tariff Calculation"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackgroundImage = CType(resources.GetObject("FlowLayoutPanel2.BackgroundImage"), System.Drawing.Image)
        Me.FlowLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(6, 6)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(1544, 115)
        Me.FlowLayoutPanel2.TabIndex = 1
        '
        'Meter_ReadingsBindingSource
        '
        Me.Meter_ReadingsBindingSource.DataMember = "Meter_Readings"
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.Meter_ReadingsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = _1st_Year_Project.Electricity_CustomersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomerBindingNavigator
        '
        Me.CustomerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CustomerBindingNavigator.BindingSource = Me.CustomerBindingSource
        Me.CustomerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CustomerBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CustomerBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.CustomerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CustomerBindingNavigatorSaveItem})
        Me.CustomerBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CustomerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CustomerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CustomerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CustomerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CustomerBindingNavigator.Name = "CustomerBindingNavigator"
        Me.CustomerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustomerBindingNavigator.Size = New System.Drawing.Size(1556, 31)
        Me.CustomerBindingNavigator.TabIndex = 1
        Me.CustomerBindingNavigator.Text = "BindingNavigator1"
        Me.CustomerBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(54, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'CustomerBindingNavigatorSaveItem
        '
        Me.CustomerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustomerBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustomerBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustomerBindingNavigatorSaveItem.Name = "CustomerBindingNavigatorSaveItem"
        Me.CustomerBindingNavigatorSaveItem.Size = New System.Drawing.Size(28, 28)
        Me.CustomerBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CustomerTableAdapter1
        '
        Me.CustomerTableAdapter1.ClearBeforeFill = True
        '
        'CustomerTableAdapter2
        '
        Me.CustomerTableAdapter2.ClearBeforeFill = True
        '
        'Meter_ReadingsTableAdapter
        '
        Me.Meter_ReadingsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.CustomerTableAdapter = Nothing
        Me.TableAdapterManager1.Meter_ReadingsTableAdapter = Me.Meter_ReadingsTableAdapter
        Me.TableAdapterManager1.UpdateOrder = _1st_Year_Project.Electricity_CustomersDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Meter_ReadingsTableAdapter1
        '
        Me.Meter_ReadingsTableAdapter1.ClearBeforeFill = True
        '
        'Electricity_CustomersDataSet1
        '
        Me.Electricity_CustomersDataSet1.DataSetName = "Electricity_CustomersDataSet1"
        Me.Electricity_CustomersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1556, 904)
        Me.Controls.Add(Me.CustomerBindingNavigator)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Electricity Bill Calculator"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Meter_ReadingsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Electricity_CustomersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.PerformLayout()
        Me.GunaGroupBox2.ResumeLayout(False)
        Me.GunaGroupBox2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        CType(Me.Meter_ReadingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomerBindingNavigator.ResumeLayout(False)
        Me.CustomerBindingNavigator.PerformLayout()
        CType(Me.Electricity_CustomersDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Electricity_CustomersDataSet As _1st_Year_Project.Electricity_CustomersDataSet
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTableAdapter As _1st_Year_Project.Electricity_CustomersDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents TableAdapterManager As _1st_Year_Project.Electricity_CustomersDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomerBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CustomerBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CustomerTableAdapter1 As _1st_Year_Project.Electricity_CustomersDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents CustomerTableAdapter2 As _1st_Year_Project.Electricity_CustomersDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents GunaGroupBox2 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton3 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Meter_ReadingsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Meter_ReadingsTableAdapter As _1st_Year_Project.Electricity_CustomersDataSet1TableAdapters.Meter_ReadingsTableAdapter
    Friend WithEvents TableAdapterManager1 As _1st_Year_Project.Electricity_CustomersDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Meter_ReadingsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Meter_ReadingsTableAdapter1 As _1st_Year_Project.Electricity_CustomersDataSetTableAdapters.Meter_ReadingsTableAdapter
    Friend WithEvents Account_NoLabel2 As System.Windows.Forms.Label
    Friend WithEvents Previous_ReadingLabel1 As System.Windows.Forms.Label
    Friend WithEvents Customer_AddressLabel2 As System.Windows.Forms.Label
    Friend WithEvents Customer_NameLabel2 As System.Windows.Forms.Label
    Friend WithEvents TariffLabel2 As System.Windows.Forms.Label
    Friend WithEvents Meter_NoLabel2 As System.Windows.Forms.Label
    Friend WithEvents Current_ReadingTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Current_Reading_DateDateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Electricity_CustomersDataSet1 As _1st_Year_Project.Electricity_CustomersDataSet1
    Friend WithEvents Previous_Reading_DateDateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label

End Class
