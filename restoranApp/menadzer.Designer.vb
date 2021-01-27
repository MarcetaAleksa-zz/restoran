<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menadzer
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NazivDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolicinaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CijenaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SkladisteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KaficDataSet1 = New restoranApp.KaficDataSet1()
        Me.SkladisteTableAdapter = New restoranApp.KaficDataSet1TableAdapters.SkladisteTableAdapter()
        Me.KaficDataSet2 = New restoranApp.KaficDataSet2()
        Me.SkladisteBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SkladisteTableAdapter1 = New restoranApp.KaficDataSet2TableAdapters.SkladisteTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkladisteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KaficDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KaficDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkladisteBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(13, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Nazad"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-23, -9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(467, 69)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(142, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PREGLED SKLADISTA"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NazivDataGridViewTextBoxColumn, Me.KolicinaDataGridViewTextBoxColumn, Me.CijenaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SkladisteBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(27, 87)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(364, 308)
        Me.DataGridView1.TabIndex = 2
        '
        'NazivDataGridViewTextBoxColumn
        '
        Me.NazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv"
        Me.NazivDataGridViewTextBoxColumn.HeaderText = "Naziv"
        Me.NazivDataGridViewTextBoxColumn.Name = "NazivDataGridViewTextBoxColumn"
        Me.NazivDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KolicinaDataGridViewTextBoxColumn
        '
        Me.KolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina"
        Me.KolicinaDataGridViewTextBoxColumn.HeaderText = "kolicina"
        Me.KolicinaDataGridViewTextBoxColumn.Name = "KolicinaDataGridViewTextBoxColumn"
        Me.KolicinaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CijenaDataGridViewTextBoxColumn
        '
        Me.CijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena"
        Me.CijenaDataGridViewTextBoxColumn.HeaderText = "cijena"
        Me.CijenaDataGridViewTextBoxColumn.Name = "CijenaDataGridViewTextBoxColumn"
        Me.CijenaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SkladisteBindingSource
        '
        Me.SkladisteBindingSource.DataMember = "Skladiste"
        Me.SkladisteBindingSource.DataSource = Me.KaficDataSet1
        '
        'KaficDataSet1
        '
        Me.KaficDataSet1.DataSetName = "KaficDataSet1"
        Me.KaficDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SkladisteTableAdapter
        '
        Me.SkladisteTableAdapter.ClearBeforeFill = True
        '
        'KaficDataSet2
        '
        Me.KaficDataSet2.DataSetName = "KaficDataSet2"
        Me.KaficDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SkladisteBindingSource1
        '
        Me.SkladisteBindingSource1.DataMember = "Skladiste"
        Me.SkladisteBindingSource1.DataSource = Me.KaficDataSet2
        '
        'SkladisteTableAdapter1
        '
        Me.SkladisteTableAdapter1.ClearBeforeFill = True
        '
        'menadzer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 419)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "menadzer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "menadzer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkladisteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KaficDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KaficDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkladisteBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents KaficDataSet1 As KaficDataSet1
    Friend WithEvents SkladisteBindingSource As BindingSource
    Friend WithEvents SkladisteTableAdapter As KaficDataSet1TableAdapters.SkladisteTableAdapter
    Friend WithEvents NazivDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KolicinaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CijenaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents KaficDataSet2 As KaficDataSet2
    Friend WithEvents SkladisteBindingSource1 As BindingSource
    Friend WithEvents SkladisteTableAdapter1 As KaficDataSet2TableAdapters.SkladisteTableAdapter
End Class
