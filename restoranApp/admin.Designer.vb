<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class admin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin))
        Me.PozicijaComboBox = New System.Windows.Forms.ComboBox()
        Me.NaloziBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KaficDataSet = New restoranApp.KaficDataSet()
        Me.NaloziBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.imeTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Dodaj = New System.Windows.Forms.Button()
        Me.Ponisti = New System.Windows.Forms.Button()
        Me.Nazad = New System.Windows.Forms.Button()
        Me.ZaposleniBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pictureBox4 = New System.Windows.Forms.PictureBox()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.NaloziTableAdapter = New restoranApp.KaficDataSetTableAdapters.NaloziTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        CType(Me.NaloziBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KaficDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NaloziBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZaposleniBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'PozicijaComboBox
        '
        Me.PozicijaComboBox.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.PozicijaComboBox.DataSource = Me.NaloziBindingSource1
        Me.PozicijaComboBox.DisplayMember = "Naziv"
        Me.PozicijaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PozicijaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PozicijaComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.PozicijaComboBox.FormattingEnabled = True
        Me.PozicijaComboBox.Location = New System.Drawing.Point(565, 301)
        Me.PozicijaComboBox.Name = "PozicijaComboBox"
        Me.PozicijaComboBox.Size = New System.Drawing.Size(245, 32)
        Me.PozicijaComboBox.TabIndex = 3
        '
        'NaloziBindingSource1
        '
        Me.NaloziBindingSource1.DataMember = "Nalozi"
        Me.NaloziBindingSource1.DataSource = Me.KaficDataSet
        '
        'KaficDataSet
        '
        Me.KaficDataSet.DataSetName = "KaficDataSet"
        Me.KaficDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NaloziBindingSource
        '
        Me.NaloziBindingSource.DataMember = "Nalozi"
        '
        'imeTextBox
        '
        Me.imeTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.imeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.imeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imeTextBox.Location = New System.Drawing.Point(8, 3)
        Me.imeTextBox.Name = "imeTextBox"
        Me.imeTextBox.Size = New System.Drawing.Size(189, 22)
        Me.imeTextBox.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(517, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Ime"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(493, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 18)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Prezime"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(447, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Korisnicko ime"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(487, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Lozinka"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(449, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Email adresa"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(493, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 18)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Telefon"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(433, 263)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 18)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Sluzbeni telefon"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(487, 308)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 18)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Pozicija"
        '
        'Dodaj
        '
        Me.Dodaj.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Dodaj.Location = New System.Drawing.Point(548, 342)
        Me.Dodaj.Name = "Dodaj"
        Me.Dodaj.Size = New System.Drawing.Size(138, 48)
        Me.Dodaj.TabIndex = 11
        Me.Dodaj.Text = "Dodaj"
        Me.Dodaj.UseVisualStyleBackColor = True
        '
        'Ponisti
        '
        Me.Ponisti.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Ponisti.Location = New System.Drawing.Point(692, 342)
        Me.Ponisti.Name = "Ponisti"
        Me.Ponisti.Size = New System.Drawing.Size(134, 48)
        Me.Ponisti.TabIndex = 12
        Me.Ponisti.Text = "Ponisti"
        Me.Ponisti.UseVisualStyleBackColor = True
        '
        'Nazad
        '
        Me.Nazad.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Nazad.Location = New System.Drawing.Point(548, 396)
        Me.Nazad.Name = "Nazad"
        Me.Nazad.Size = New System.Drawing.Size(278, 48)
        Me.Nazad.TabIndex = 13
        Me.Nazad.Text = "Nazad"
        Me.Nazad.UseVisualStyleBackColor = True
        '
        'pictureBox4
        '
        Me.pictureBox4.Image = CType(resources.GetObject("pictureBox4.Image"), System.Drawing.Image)
        Me.pictureBox4.Location = New System.Drawing.Point(455, 154)
        Me.pictureBox4.Name = "pictureBox4"
        Me.pictureBox4.Size = New System.Drawing.Size(26, 23)
        Me.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox4.TabIndex = 48
        Me.pictureBox4.TabStop = False
        '
        'pictureBox3
        '
        Me.pictureBox3.Image = CType(resources.GetObject("pictureBox3.Image"), System.Drawing.Image)
        Me.pictureBox3.Location = New System.Drawing.Point(415, 112)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(26, 25)
        Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox3.TabIndex = 47
        Me.pictureBox3.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel1.Controls.Add(Me.imeTextBox)
        Me.Panel1.Location = New System.Drawing.Point(565, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(245, 28)
        Me.Panel1.TabIndex = 49
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Location = New System.Drawing.Point(565, 72)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(245, 28)
        Me.Panel2.TabIndex = 50
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(8, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(189, 22)
        Me.TextBox1.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Location = New System.Drawing.Point(565, 154)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(245, 28)
        Me.Panel3.TabIndex = 51
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(8, 3)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(189, 22)
        Me.TextBox2.TabIndex = 9
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel6.Controls.Add(Me.TextBox5)
        Me.Panel6.Location = New System.Drawing.Point(565, 112)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(245, 28)
        Me.Panel6.TabIndex = 50
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(8, 3)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(189, 22)
        Me.TextBox5.TabIndex = 9
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel4.Controls.Add(Me.TextBox3)
        Me.Panel4.Location = New System.Drawing.Point(565, 192)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(245, 28)
        Me.Panel4.TabIndex = 52
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(8, 3)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(189, 22)
        Me.TextBox3.TabIndex = 9
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel5.Controls.Add(Me.TextBox4)
        Me.Panel5.Location = New System.Drawing.Point(565, 263)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(245, 28)
        Me.Panel5.TabIndex = 52
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(8, 3)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(189, 22)
        Me.TextBox4.TabIndex = 9
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel7.Controls.Add(Me.TextBox6)
        Me.Panel7.Location = New System.Drawing.Point(565, 226)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(245, 28)
        Me.Panel7.TabIndex = 52
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(8, 3)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(189, 22)
        Me.TextBox6.TabIndex = 9
        '
        'NaloziTableAdapter
        '
        Me.NaloziTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(789, 572)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(-4, 127)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(398, 224)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 2
        Me.pictureBox1.TabStop = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel8.Controls.Add(Me.pictureBox1)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(394, 466)
        Me.Panel8.TabIndex = 54
        '
        'admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(858, 466)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PozicijaComboBox)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pictureBox4)
        Me.Controls.Add(Me.pictureBox3)
        Me.Controls.Add(Me.Nazad)
        Me.Controls.Add(Me.Ponisti)
        Me.Controls.Add(Me.Dodaj)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.NaloziBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KaficDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NaloziBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZaposleniBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PozicijaComboBox As ComboBox
    Friend WithEvents imeTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Dodaj As Button
    Friend WithEvents Ponisti As Button
    Friend WithEvents Nazad As Button

    Friend WithEvents ZaposleniBindingSource As BindingSource


    Friend WithEvents NaloziBindingSource As BindingSource

    Private WithEvents pictureBox4 As PictureBox
    Private WithEvents pictureBox3 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents KaficDataSet As KaficDataSet
    Friend WithEvents NaloziBindingSource1 As BindingSource
    Friend WithEvents NaloziTableAdapter As KaficDataSetTableAdapters.NaloziTableAdapter
    Friend WithEvents Button1 As Button
    Private WithEvents pictureBox1 As PictureBox
    Friend WithEvents Panel8 As Panel
End Class
