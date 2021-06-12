<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DgvGrilla = New System.Windows.Forms.DataGridView()
        Me.Equipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rtdo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RtdoVis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtBox2 = New System.Windows.Forms.TextBox()
        Me.txtBox1 = New System.Windows.Forms.TextBox()
        Me.txtBox3 = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtbox5 = New System.Windows.Forms.TextBox()
        Me.txtbox4 = New System.Windows.Forms.TextBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DgvGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvGrilla
        '
        Me.DgvGrilla.AllowUserToAddRows = False
        Me.DgvGrilla.AllowUserToDeleteRows = False
        Me.DgvGrilla.AllowUserToOrderColumns = True
        Me.DgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Equipo, Me.Rtdo, Me.RtdoVis})
        Me.DgvGrilla.Location = New System.Drawing.Point(119, 135)
        Me.DgvGrilla.Name = "DgvGrilla"
        Me.DgvGrilla.ReadOnly = True
        Me.DgvGrilla.Size = New System.Drawing.Size(340, 113)
        Me.DgvGrilla.TabIndex = 8
        '
        'Equipo
        '
        Me.Equipo.HeaderText = "Equipo"
        Me.Equipo.Name = "Equipo"
        Me.Equipo.ReadOnly = True
        '
        'Rtdo
        '
        Me.Rtdo.HeaderText = "Rtdo.Local"
        Me.Rtdo.Name = "Rtdo"
        Me.Rtdo.ReadOnly = True
        '
        'RtdoVis
        '
        Me.RtdoVis.HeaderText = "Rtdo.Visitante"
        Me.RtdoVis.Name = "RtdoVis"
        Me.RtdoVis.ReadOnly = True
        '
        'txtBox2
        '
        Me.txtBox2.Location = New System.Drawing.Point(232, 66)
        Me.txtBox2.Name = "txtBox2"
        Me.txtBox2.Size = New System.Drawing.Size(90, 20)
        Me.txtBox2.TabIndex = 1
        '
        'txtBox1
        '
        Me.txtBox1.Location = New System.Drawing.Point(69, 66)
        Me.txtBox1.Name = "txtBox1"
        Me.txtBox1.Size = New System.Drawing.Size(90, 20)
        Me.txtBox1.TabIndex = 0
        '
        'txtBox3
        '
        Me.txtBox3.Location = New System.Drawing.Point(433, 66)
        Me.txtBox3.Name = "txtBox3"
        Me.txtBox3.Size = New System.Drawing.Size(90, 20)
        Me.txtBox3.TabIndex = 2
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(536, 64)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtbox5
        '
        Me.txtbox5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbox5.Location = New System.Drawing.Point(232, 320)
        Me.txtbox5.Name = "txtbox5"
        Me.txtbox5.Size = New System.Drawing.Size(90, 20)
        Me.txtbox5.TabIndex = 10
        '
        'txtbox4
        '
        Me.txtbox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbox4.Location = New System.Drawing.Point(232, 277)
        Me.txtbox4.Name = "txtbox4"
        Me.txtbox4.Size = New System.Drawing.Size(90, 20)
        Me.txtbox4.TabIndex = 9
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(5, 65)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(40, 13)
        Me.lbl1.TabIndex = 5
        Me.lbl1.Text = "Equipo"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(184, 69)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(33, 13)
        Me.lbl2.TabIndex = 6
        Me.lbl2.Text = "Local"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(368, 69)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(47, 13)
        Me.lbl3.TabIndex = 7
        Me.lbl3.Text = "Visitante"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(465, 321)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 323)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Partidos Empatados"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(129, 277)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Partidos Jugados"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(339, 273)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 356)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.txtbox4)
        Me.Controls.Add(Me.txtbox5)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtBox3)
        Me.Controls.Add(Me.txtBox1)
        Me.Controls.Add(Me.txtBox2)
        Me.Controls.Add(Me.DgvGrilla)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DgvGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvGrilla As System.Windows.Forms.DataGridView
    Friend WithEvents txtBox2 As System.Windows.Forms.TextBox
    Friend WithEvents txtBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtBox3 As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents txtbox5 As System.Windows.Forms.TextBox
    Friend WithEvents txtbox4 As System.Windows.Forms.TextBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Equipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rtdo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RtdoVis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
