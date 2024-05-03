<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.r1Label = New System.Windows.Forms.Label()
        Me.r2Label = New System.Windows.Forms.Label()
        Me.r3Label = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SpinButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Cherry.PNG")
        Me.ImageList1.Images.SetKeyName(1, "7.PNG")
        Me.ImageList1.Images.SetKeyName(2, "Diamond.PNG")
        '
        'r1Label
        '
        Me.r1Label.AutoSize = True
        Me.r1Label.Location = New System.Drawing.Point(269, 239)
        Me.r1Label.Name = "r1Label"
        Me.r1Label.Size = New System.Drawing.Size(48, 16)
        Me.r1Label.TabIndex = 8
        Me.r1Label.Text = "Label1"
        '
        'r2Label
        '
        Me.r2Label.AutoSize = True
        Me.r2Label.Location = New System.Drawing.Point(372, 239)
        Me.r2Label.Name = "r2Label"
        Me.r2Label.Size = New System.Drawing.Size(48, 16)
        Me.r2Label.TabIndex = 9
        Me.r2Label.Text = "Label2"
        '
        'r3Label
        '
        Me.r3Label.AutoSize = True
        Me.r3Label.Location = New System.Drawing.Point(483, 239)
        Me.r3Label.Name = "r3Label"
        Me.r3Label.Size = New System.Drawing.Size(48, 16)
        Me.r3Label.TabIndex = 10
        Me.r3Label.Text = "Label3"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(364, 258)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Spin"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SpinButton
        '
        Me.SpinButton.Location = New System.Drawing.Point(359, 258)
        Me.SpinButton.Name = "SpinButton"
        Me.SpinButton.Size = New System.Drawing.Size(75, 23)
        Me.SpinButton.TabIndex = 11
        Me.SpinButton.Text = "Spin"
        Me.SpinButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ReelControl3 As ReelControl
    Friend WithEvents ReelControl1 As ReelControl
    Friend WithEvents ReelControl2 As ReelControl
    Friend WithEvents r1Label As Label
    Friend WithEvents r2Label As Label
    Friend WithEvents r3Label As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents SpinButton As Button
End Class
