<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm2Dplatformer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm2Dplatformer))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.TmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.TmrUp = New System.Windows.Forms.Timer(Me.components)
        Me.TmrGameLogic = New System.Windows.Forms.Timer(Me.components)
        Me.TmrGravity = New System.Windows.Forms.Timer(Me.components)
        Me.PicPlayer = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PicGround = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PicAir = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ResetB = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Mover5 = New _2DPlatformer.Mover()
        Me.Mover3 = New _2DPlatformer.Mover()
        Me.Mover4 = New _2DPlatformer.Mover()
        Me.Mover2 = New _2DPlatformer.Mover()
        Me.Mover1 = New _2DPlatformer.Mover()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicAir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox1.Location = New System.Drawing.Point(314, 311)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(92, 22)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "bound"
        '
        'TmrRight
        '
        Me.TmrRight.Interval = 20
        '
        'TmrLeft
        '
        Me.TmrLeft.Interval = 20
        '
        'TmrUp
        '
        Me.TmrUp.Interval = 20
        '
        'TmrGameLogic
        '
        Me.TmrGameLogic.Interval = 20
        '
        'TmrGravity
        '
        Me.TmrGravity.Interval = 20
        '
        'PicPlayer
        '
        Me.PicPlayer.Image = CType(resources.GetObject("PicPlayer.Image"), System.Drawing.Image)
        Me.PicPlayer.Location = New System.Drawing.Point(12, 346)
        Me.PicPlayer.Name = "PicPlayer"
        Me.PicPlayer.Size = New System.Drawing.Size(54, 54)
        Me.PicPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicPlayer.TabIndex = 4
        Me.PicPlayer.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox2.Location = New System.Drawing.Point(549, 249)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(92, 22)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "bound"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox3.Location = New System.Drawing.Point(374, 147)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(92, 22)
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "bound"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox4.Location = New System.Drawing.Point(111, 98)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(92, 22)
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "bound"
        '
        'PicGround
        '
        Me.PicGround.BackColor = System.Drawing.Color.Khaki
        Me.PicGround.Location = New System.Drawing.Point(1, 406)
        Me.PicGround.Name = "PicGround"
        Me.PicGround.Size = New System.Drawing.Size(798, 47)
        Me.PicGround.TabIndex = 9
        Me.PicGround.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(265, 244)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(50, 49)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 12
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = "restart"
        '
        'PicAir
        '
        Me.PicAir.BackColor = System.Drawing.Color.Transparent
        Me.PicAir.Image = CType(resources.GetObject("PicAir.Image"), System.Drawing.Image)
        Me.PicAir.Location = New System.Drawing.Point(1, -7)
        Me.PicAir.Name = "PicAir"
        Me.PicAir.Size = New System.Drawing.Size(798, 417)
        Me.PicAir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicAir.TabIndex = 2
        Me.PicAir.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1, 431)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 11
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(576, 193)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(51, 50)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 13
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Tag = "collectable"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(398, 91)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(51, 50)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 14
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Tag = "collectable"
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(152, 42)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(51, 50)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 15
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Tag = "collectable"
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(497, 167)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(51, 50)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox9.TabIndex = 16
        Me.PictureBox9.TabStop = False
        Me.PictureBox9.Tag = "collectable"
        '
        'ScoreLabel
        '
        Me.ScoreLabel.AutoSize = True
        Me.ScoreLabel.BackColor = System.Drawing.Color.Black
        Me.ScoreLabel.ForeColor = System.Drawing.Color.Yellow
        Me.ScoreLabel.Location = New System.Drawing.Point(62, 177)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(14, 16)
        Me.ScoreLabel.TabIndex = 18
        Me.ScoreLabel.Text = "0"
        Me.ScoreLabel.Visible = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(324, 2)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(51, 50)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox10.TabIndex = 19
        Me.PictureBox10.TabStop = False
        Me.PictureBox10.Tag = "collectable"
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(333, 256)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(51, 50)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox11.TabIndex = 20
        Me.PictureBox11.TabStop = False
        Me.PictureBox11.Tag = "collectable"
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox13.Location = New System.Drawing.Point(669, 119)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(92, 22)
        Me.PictureBox13.TabIndex = 24
        Me.PictureBox13.TabStop = False
        Me.PictureBox13.Tag = "bound"
        '
        'PictureBox14
        '
        Me.PictureBox14.Image = CType(resources.GetObject("PictureBox14.Image"), System.Drawing.Image)
        Me.PictureBox14.Location = New System.Drawing.Point(692, 63)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(51, 50)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox14.TabIndex = 25
        Me.PictureBox14.TabStop = False
        Me.PictureBox14.Tag = "collectable"
        '
        'PictureBox15
        '
        Me.PictureBox15.Image = CType(resources.GetObject("PictureBox15.Image"), System.Drawing.Image)
        Me.PictureBox15.Location = New System.Drawing.Point(759, 109)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(50, 49)
        Me.PictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox15.TabIndex = 28
        Me.PictureBox15.TabStop = False
        Me.PictureBox15.Tag = "restart"
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(709, 405)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(51, 50)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox12.TabIndex = 31
        Me.PictureBox12.TabStop = False
        Me.PictureBox12.Tag = "collectable"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(11, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 16)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Banans Collected:"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(1, 2)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(226, 23)
        Me.ProgressBar1.TabIndex = 33
        Me.ProgressBar1.Value = 100
        '
        'ResetB
        '
        Me.ResetB.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetB.Location = New System.Drawing.Point(336, 291)
        Me.ResetB.Name = "ResetB"
        Me.ResetB.Size = New System.Drawing.Size(128, 62)
        Me.ResetB.TabIndex = 34
        Me.ResetB.Text = "Reset"
        Me.ResetB.UseVisualStyleBackColor = True
        Me.ResetB.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(355, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 32)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "LOSE"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(367, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 32)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "WIN"
        Me.Label3.Visible = False
        '
        'Mover5
        '
        Me.Mover5.BackColor = System.Drawing.Color.Transparent
        Me.Mover5.interval = 500
        Me.Mover5.Location = New System.Drawing.Point(679, 305)
        Me.Mover5.Name = "Mover5"
        Me.Mover5.Size = New System.Drawing.Size(96, 95)
        Me.Mover5.speed = 10
        Me.Mover5.sprite = Me.PictureBox12
        Me.Mover5.TabIndex = 30
        '
        'Mover3
        '
        Me.Mover3.BackColor = System.Drawing.Color.Transparent
        Me.Mover3.interval = 500
        Me.Mover3.Location = New System.Drawing.Point(314, 12)
        Me.Mover3.Name = "Mover3"
        Me.Mover3.Size = New System.Drawing.Size(10, 129)
        Me.Mover3.speed = 10
        Me.Mover3.sprite = Me.PictureBox10
        Me.Mover3.TabIndex = 29
        '
        'Mover4
        '
        Me.Mover4.BackColor = System.Drawing.Color.Transparent
        Me.Mover4.interval = 500
        Me.Mover4.Location = New System.Drawing.Point(669, 119)
        Me.Mover4.Name = "Mover4"
        Me.Mover4.Size = New System.Drawing.Size(92, 22)
        Me.Mover4.speed = 10
        Me.Mover4.sprite = Me.PictureBox15
        Me.Mover4.TabIndex = 27
        '
        'Mover2
        '
        Me.Mover2.BackColor = System.Drawing.Color.Transparent
        Me.Mover2.interval = 500
        Me.Mover2.Location = New System.Drawing.Point(507, 177)
        Me.Mover2.Name = "Mover2"
        Me.Mover2.Size = New System.Drawing.Size(10, 156)
        Me.Mover2.speed = 10
        Me.Mover2.sprite = Me.PictureBox9
        Me.Mover2.TabIndex = 22
        '
        'Mover1
        '
        Me.Mover1.BackColor = System.Drawing.Color.Transparent
        Me.Mover1.interval = 500
        Me.Mover1.Location = New System.Drawing.Point(275, 244)
        Me.Mover1.Name = "Mover1"
        Me.Mover1.Size = New System.Drawing.Size(10, 156)
        Me.Mover1.speed = 10
        Me.Mover1.sprite = Me.PictureBox5
        Me.Mover1.TabIndex = 21
        '
        'PictureBox16
        '
        Me.PictureBox16.Location = New System.Drawing.Point(12, 346)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(54, 54)
        Me.PictureBox16.TabIndex = 37
        Me.PictureBox16.TabStop = False
        Me.PictureBox16.Visible = False
        '
        'frm2Dplatformer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox16)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ResetB)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.PicPlayer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.Mover5)
        Me.Controls.Add(Me.Mover3)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox15)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.Mover4)
        Me.Controls.Add(Me.PictureBox14)
        Me.Controls.Add(Me.Mover2)
        Me.Controls.Add(Me.Mover1)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PicGround)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PicAir)
        Me.Name = "frm2Dplatformer"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicAir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TmrRight As Timer
    Friend WithEvents TmrLeft As Timer
    Friend WithEvents TmrUp As Timer
    Friend WithEvents TmrGameLogic As Timer
    Friend WithEvents TmrGravity As Timer
    Friend WithEvents PicPlayer As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PicGround As PictureBox
    Friend WithEvents PicAir As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents TextBox1 As MaskedTextBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents Mover1 As Mover
    Friend WithEvents Mover2 As Mover
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents Mover4 As Mover
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents Mover3 As Mover
    Friend WithEvents Mover5 As Mover
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ResetB As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox16 As PictureBox
End Class
