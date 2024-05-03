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
        Me.SpinButton = New System.Windows.Forms.Button()
        Me.r1label = New System.Windows.Forms.Label()
        Me.r2label = New System.Windows.Forms.Label()
        Me.r3label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.doButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ReelControl1 = New SlotMachine_Good.ReelControl()
        Me.ReelControl2 = New SlotMachine_Good.ReelControl()
        Me.ReelControl3 = New SlotMachine_Good.ReelControl()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SpinButton
        '
        Me.SpinButton.BackColor = System.Drawing.Color.Black
        Me.SpinButton.Location = New System.Drawing.Point(584, 64)
        Me.SpinButton.Name = "SpinButton"
        Me.SpinButton.Size = New System.Drawing.Size(46, 46)
        Me.SpinButton.TabIndex = 0
        Me.SpinButton.UseVisualStyleBackColor = False
        '
        'r1label
        '
        Me.r1label.AutoSize = True
        Me.r1label.Location = New System.Drawing.Point(339, 115)
        Me.r1label.Name = "r1label"
        Me.r1label.Size = New System.Drawing.Size(14, 16)
        Me.r1label.TabIndex = 1
        Me.r1label.Text = "0"
        Me.r1label.Visible = False
        '
        'r2label
        '
        Me.r2label.AutoSize = True
        Me.r2label.Location = New System.Drawing.Point(414, 115)
        Me.r2label.Name = "r2label"
        Me.r2label.Size = New System.Drawing.Size(14, 16)
        Me.r2label.TabIndex = 2
        Me.r2label.Text = "0"
        Me.r2label.Visible = False
        '
        'r3label
        '
        Me.r3label.AutoSize = True
        Me.r3label.Location = New System.Drawing.Point(460, 115)
        Me.r3label.Name = "r3label"
        Me.r3label.Size = New System.Drawing.Size(14, 16)
        Me.r3label.TabIndex = 3
        Me.r3label.Text = "0"
        Me.r3label.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Goudy Stout", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(378, 282)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 31)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Goudy Stout", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(320, 371)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 31)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = " Label2"
        Me.Label2.Visible = False
        '
        'doButton
        '
        Me.doButton.BackColor = System.Drawing.Color.White
        Me.doButton.BackgroundImage = CType(resources.GetObject("doButton.BackgroundImage"), System.Drawing.Image)
        Me.doButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.doButton.Location = New System.Drawing.Point(326, 275)
        Me.doButton.Name = "doButton"
        Me.doButton.Size = New System.Drawing.Size(45, 45)
        Me.doButton.TabIndex = 9
        Me.doButton.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(175, -121)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(516, 694)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'ReelControl1
        '
        Me.ReelControl1.itemValue = 0
        Me.ReelControl1.Location = New System.Drawing.Point(314, 165)
        Me.ReelControl1.Name = "ReelControl1"
        Me.ReelControl1.Size = New System.Drawing.Size(64, 80)
        Me.ReelControl1.spinTime = 2000
        Me.ReelControl1.TabIndex = 11
        '
        'ReelControl2
        '
        Me.ReelControl2.itemValue = 0
        Me.ReelControl2.Location = New System.Drawing.Point(382, 165)
        Me.ReelControl2.Name = "ReelControl2"
        Me.ReelControl2.Size = New System.Drawing.Size(64, 80)
        Me.ReelControl2.spinTime = 2000
        Me.ReelControl2.TabIndex = 12
        '
        'ReelControl3
        '
        Me.ReelControl3.itemValue = 0
        Me.ReelControl3.Location = New System.Drawing.Point(450, 165)
        Me.ReelControl3.Name = "ReelControl3"
        Me.ReelControl3.Size = New System.Drawing.Size(64, 80)
        Me.ReelControl3.spinTime = 2000
        Me.ReelControl3.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReelControl3)
        Me.Controls.Add(Me.ReelControl2)
        Me.Controls.Add(Me.ReelControl1)
        Me.Controls.Add(Me.doButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.r3label)
        Me.Controls.Add(Me.r2label)
        Me.Controls.Add(Me.r1label)
        Me.Controls.Add(Me.SpinButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SpinButton As Button
    Friend WithEvents r1label As Label
    Friend WithEvents r2label As Label
    Friend WithEvents r3label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents doButton As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ReelControl1 As ReelControl
    Friend WithEvents ReelControl2 As ReelControl
    Friend WithEvents ReelControl3 As ReelControl
End Class
