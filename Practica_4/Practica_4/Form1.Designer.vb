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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.horas = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.minutos = New System.Windows.Forms.Label()
        Me.dias = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.segundos = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Cronometro = New System.Windows.Forms.Label()
        Me.tiempo = New System.Windows.Forms.Label()
        Me.start = New System.Windows.Forms.Button()
        Me.reset = New System.Windows.Forms.Button()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'horas
        '
        Me.horas.AutoSize = True
        Me.horas.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.horas.Location = New System.Drawing.Point(449, 272)
        Me.horas.Name = "horas"
        Me.horas.Size = New System.Drawing.Size(109, 76)
        Me.horas.TabIndex = 0
        Me.horas.Text = "00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(543, 272)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 76)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = ":"
        '
        'minutos
        '
        Me.minutos.AutoSize = True
        Me.minutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minutos.Location = New System.Drawing.Point(579, 272)
        Me.minutos.Name = "minutos"
        Me.minutos.Size = New System.Drawing.Size(109, 76)
        Me.minutos.TabIndex = 2
        Me.minutos.Text = "00"
        '
        'dias
        '
        Me.dias.AutoSize = True
        Me.dias.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dias.Location = New System.Drawing.Point(416, 392)
        Me.dias.Name = "dias"
        Me.dias.Size = New System.Drawing.Size(99, 33)
        Me.dias.TabIndex = 3
        Me.dias.Text = "Lunes"
        '
        'fecha
        '
        Me.fecha.AutoSize = True
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Location = New System.Drawing.Point(416, 435)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(315, 33)
        Me.fecha.TabIndex = 4
        Me.fecha.Text = "09 de Marzo del 2026"
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(147, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(2211, 981)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(691, 356)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(51, 49)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(475, 87)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(198, 127)
        Me.Panel1.TabIndex = 6
        Me.Panel1.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Blanco", "Rojo", "Azul", "Amarillo", "Verde"})
        Me.ComboBox1.Location = New System.Drawing.Point(19, 86)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(130, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(19, 44)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Configuraciones"
        '
        'segundos
        '
        Me.segundos.AutoSize = True
        Me.segundos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.segundos.Location = New System.Drawing.Point(633, 247)
        Me.segundos.Name = "segundos"
        Me.segundos.Size = New System.Drawing.Size(55, 16)
        Me.segundos.TabIndex = 7
        Me.segundos.Text = "Label3"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.reset)
        Me.Panel2.Controls.Add(Me.start)
        Me.Panel2.Controls.Add(Me.tiempo)
        Me.Panel2.Controls.Add(Me.Cronometro)
        Me.Panel2.Location = New System.Drawing.Point(458, 73)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(244, 140)
        Me.Panel2.TabIndex = 8
        '
        'Cronometro
        '
        Me.Cronometro.AutoSize = True
        Me.Cronometro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cronometro.Location = New System.Drawing.Point(72, 14)
        Me.Cronometro.Name = "Cronometro"
        Me.Cronometro.Size = New System.Drawing.Size(103, 20)
        Me.Cronometro.TabIndex = 0
        Me.Cronometro.Text = "Cronometro"
        '
        'tiempo
        '
        Me.tiempo.AutoSize = True
        Me.tiempo.Location = New System.Drawing.Point(19, 52)
        Me.tiempo.Name = "tiempo"
        Me.tiempo.Size = New System.Drawing.Size(39, 13)
        Me.tiempo.TabIndex = 1
        Me.tiempo.Text = "Label3"
        '
        'start
        '
        Me.start.Location = New System.Drawing.Point(36, 100)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(64, 21)
        Me.start.TabIndex = 2
        Me.start.Text = "Button2"
        Me.start.UseVisualStyleBackColor = True
        '
        'reset
        '
        Me.reset.Location = New System.Drawing.Point(144, 99)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(58, 21)
        Me.reset.TabIndex = 3
        Me.reset.Text = "Button3"
        Me.reset.UseVisualStyleBackColor = True
        '
        'Timer3
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 650)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.segundos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.dias)
        Me.Controls.Add(Me.minutos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.horas)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents horas As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents minutos As Label
    Friend WithEvents dias As Label
    Friend WithEvents fecha As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents segundos As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents reset As Button
    Friend WithEvents start As Button
    Friend WithEvents tiempo As Label
    Friend WithEvents Cronometro As Label
    Friend WithEvents Timer3 As Timer
End Class
