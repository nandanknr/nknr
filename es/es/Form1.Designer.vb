<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    private mainMenu1 As System.Windows.Forms.MainMenu

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim IdDataGridColumnStyleDataGridTextBoxColumn As System.Windows.Forms.DataGridTextBoxColumn
        Dim NameDataGridColumnStyleDataGridTextBoxColumn As System.Windows.Forms.DataGridTextBoxColumn
        Dim DepartmentDataGridColumnStyleDataGridTextBoxColumn As System.Windows.Forms.DataGridTextBoxColumn
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.CollegeDataSet = New es.collegeDataSet
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentTableAdapter = New es.collegeDataSetTableAdapters.studentTableAdapter
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.StudentTableStyleDataGridTableStyle = New System.Windows.Forms.DataGridTableStyle
        Me.Button2 = New System.Windows.Forms.Button
        IdDataGridColumnStyleDataGridTextBoxColumn = New System.Windows.Forms.DataGridTextBoxColumn
        NameDataGridColumnStyleDataGridTextBoxColumn = New System.Windows.Forms.DataGridTextBoxColumn
        DepartmentDataGridColumnStyleDataGridTextBoxColumn = New System.Windows.Forms.DataGridTextBoxColumn
        CType(Me.CollegeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CollegeDataSet
        '
        Me.CollegeDataSet.DataSetName = "collegeDataSet"
        Me.CollegeDataSet.Prefix = ""
        Me.CollegeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "student"
        Me.StudentBindingSource.DataSource = Me.CollegeDataSet
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(31, 194)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 20)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Display"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(109, 57)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 21)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(109, 110)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(100, 21)
        Me.TextBox2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(14, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(14, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.Text = "Password:"
        '
        'DataGrid1
        '
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DataGrid1.DataSource = Me.StudentBindingSource
        Me.DataGrid1.Location = New System.Drawing.Point(11, 30)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(216, 193)
        Me.DataGrid1.TabIndex = 5
        Me.DataGrid1.TableStyles.Add(Me.StudentTableStyleDataGridTableStyle)
        '
        'StudentTableStyleDataGridTableStyle
        '
        Me.StudentTableStyleDataGridTableStyle.GridColumnStyles.Add(IdDataGridColumnStyleDataGridTextBoxColumn)
        Me.StudentTableStyleDataGridTableStyle.GridColumnStyles.Add(NameDataGridColumnStyleDataGridTextBoxColumn)
        Me.StudentTableStyleDataGridTableStyle.GridColumnStyles.Add(DepartmentDataGridColumnStyleDataGridTextBoxColumn)
        Me.StudentTableStyleDataGridTableStyle.MappingName = "student"
        '
        'IdDataGridColumnStyleDataGridTextBoxColumn
        '
        IdDataGridColumnStyleDataGridTextBoxColumn.Format = ""
        IdDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = Nothing
        IdDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "id"
        IdDataGridColumnStyleDataGridTextBoxColumn.MappingName = "id"
        '
        'NameDataGridColumnStyleDataGridTextBoxColumn
        '
        NameDataGridColumnStyleDataGridTextBoxColumn.Format = ""
        NameDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = Nothing
        NameDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "name"
        NameDataGridColumnStyleDataGridTextBoxColumn.MappingName = "name"
        '
        'DepartmentDataGridColumnStyleDataGridTextBoxColumn
        '
        DepartmentDataGridColumnStyleDataGridTextBoxColumn.Format = ""
        DepartmentDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = Nothing
        DepartmentDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "Department"
        DepartmentDataGridColumnStyleDataGridTextBoxColumn.MappingName = "Department"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(129, 194)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 20)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Menu = Me.mainMenu1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.CollegeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CollegeDataSet As es.collegeDataSet
    Friend WithEvents StudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentTableAdapter As es.collegeDataSetTableAdapters.studentTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents StudentTableStyleDataGridTableStyle As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
