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
        Me.nilaiInput = New System.Windows.Forms.TextBox()
        Me.nimInput = New System.Windows.Forms.TextBox()
        Me.namaInput = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnUlangi = New System.Windows.Forms.Button()
        Me.btnProses = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'nilaiInput
        '
        Me.nilaiInput.Location = New System.Drawing.Point(269, 264)
        Me.nilaiInput.Name = "nilaiInput"
        Me.nilaiInput.Size = New System.Drawing.Size(357, 26)
        Me.nilaiInput.TabIndex = 23
        '
        'nimInput
        '
        Me.nimInput.Location = New System.Drawing.Point(269, 199)
        Me.nimInput.Name = "nimInput"
        Me.nimInput.Size = New System.Drawing.Size(357, 26)
        Me.nimInput.TabIndex = 22
        '
        'namaInput
        '
        Me.namaInput.Location = New System.Drawing.Point(269, 137)
        Me.namaInput.Name = "namaInput"
        Me.namaInput.Size = New System.Drawing.Size(357, 26)
        Me.namaInput.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(63, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 20)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Nilai"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "NIM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Nama"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(377, 343)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 55)
        Me.btnExit.TabIndex = 32
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnUlangi
        '
        Me.btnUlangi.Location = New System.Drawing.Point(296, 343)
        Me.btnUlangi.Name = "btnUlangi"
        Me.btnUlangi.Size = New System.Drawing.Size(75, 55)
        Me.btnUlangi.TabIndex = 31
        Me.btnUlangi.Text = "Ulangi"
        Me.btnUlangi.UseVisualStyleBackColor = True
        '
        'btnProses
        '
        Me.btnProses.Location = New System.Drawing.Point(215, 343)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(75, 55)
        Me.btnProses.TabIndex = 30
        Me.btnProses.Text = "Proses"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(158, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(417, 36)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Menentukan Mahasiswa Lulus"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 612)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnUlangi)
        Me.Controls.Add(Me.btnProses)
        Me.Controls.Add(Me.nilaiInput)
        Me.Controls.Add(Me.nimInput)
        Me.Controls.Add(Me.namaInput)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nilaiInput As System.Windows.Forms.TextBox
    Friend WithEvents nimInput As System.Windows.Forms.TextBox
    Friend WithEvents namaInput As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnUlangi As System.Windows.Forms.Button
    Friend WithEvents btnProses As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
