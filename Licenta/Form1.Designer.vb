<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class S
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(S))
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        RoadMover = New Timer(components)
        Car = New PictureBox()
        Left_mover = New Timer(components)
        Right_mover = New Timer(components)
        EnemyCar3 = New PictureBox()
        EnemyCar2 = New PictureBox()
        EnemyCar1 = New PictureBox()
        EnemyMover1 = New Timer(components)
        EnemyMover2 = New Timer(components)
        EnemyMover3 = New Timer(components)
        End_Text = New Label()
        Score_Text = New Label()
        Speed_Text = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(Car, ComponentModel.ISupportInitialize).BeginInit()
        CType(EnemyCar3, ComponentModel.ISupportInitialize).BeginInit()
        CType(EnemyCar2, ComponentModel.ISupportInitialize).BeginInit()
        CType(EnemyCar1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.Control
        PictureBox1.Location = New Point(40, 40)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(15, 78)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.Control
        PictureBox2.Location = New Point(40, 140)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(15, 78)
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = SystemColors.Control
        PictureBox3.Location = New Point(40, 238)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(15, 78)
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = SystemColors.Control
        PictureBox4.Location = New Point(40, 333)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(15, 78)
        PictureBox4.TabIndex = 3
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = SystemColors.Control
        PictureBox5.Location = New Point(316, 40)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(15, 78)
        PictureBox5.TabIndex = 4
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = SystemColors.Control
        PictureBox6.Location = New Point(316, 140)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(15, 78)
        PictureBox6.TabIndex = 5
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = SystemColors.Control
        PictureBox7.Location = New Point(316, 238)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(15, 78)
        PictureBox7.TabIndex = 6
        PictureBox7.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = SystemColors.Control
        PictureBox8.Location = New Point(316, 333)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(15, 78)
        PictureBox8.TabIndex = 7
        PictureBox8.TabStop = False
        ' 
        ' RoadMover
        ' 
        RoadMover.Enabled = True
        RoadMover.Interval = 10
        ' 
        ' Car
        ' 
        Car.BackColor = Color.Transparent
        Car.Image = CType(resources.GetObject("Car.Image"), Image)
        Car.Location = New Point(166, 304)
        Car.Name = "Car"
        Car.Size = New Size(47, 86)
        Car.SizeMode = PictureBoxSizeMode.StretchImage
        Car.TabIndex = 8
        Car.TabStop = False
        ' 
        ' Left_mover
        ' 
        Left_mover.Interval = 10
        ' 
        ' Right_mover
        ' 
        Right_mover.Interval = 10
        ' 
        ' EnemyCar3
        ' 
        EnemyCar3.BackColor = Color.Transparent
        EnemyCar3.Image = CType(resources.GetObject("EnemyCar3.Image"), Image)
        EnemyCar3.Location = New Point(337, 238)
        EnemyCar3.Name = "EnemyCar3"
        EnemyCar3.Size = New Size(47, 90)
        EnemyCar3.SizeMode = PictureBoxSizeMode.StretchImage
        EnemyCar3.TabIndex = 9
        EnemyCar3.TabStop = False
        ' 
        ' EnemyCar2
        ' 
        EnemyCar2.BackColor = Color.Transparent
        EnemyCar2.Image = CType(resources.GetObject("EnemyCar2.Image"), Image)
        EnemyCar2.Location = New Point(167, -37)
        EnemyCar2.Name = "EnemyCar2"
        EnemyCar2.Size = New Size(47, 86)
        EnemyCar2.SizeMode = PictureBoxSizeMode.StretchImage
        EnemyCar2.TabIndex = 10
        EnemyCar2.TabStop = False
        ' 
        ' EnemyCar1
        ' 
        EnemyCar1.BackColor = Color.Transparent
        EnemyCar1.Image = CType(resources.GetObject("EnemyCar1.Image"), Image)
        EnemyCar1.Location = New Point(2, 146)
        EnemyCar1.Name = "EnemyCar1"
        EnemyCar1.Size = New Size(47, 86)
        EnemyCar1.SizeMode = PictureBoxSizeMode.StretchImage
        EnemyCar1.TabIndex = 11
        EnemyCar1.TabStop = False
        ' 
        ' EnemyMover1
        ' 
        EnemyMover1.Enabled = True
        EnemyMover1.Interval = 10
        ' 
        ' EnemyMover2
        ' 
        EnemyMover2.Enabled = True
        EnemyMover2.Interval = 10
        ' 
        ' EnemyMover3
        ' 
        EnemyMover3.Enabled = True
        EnemyMover3.Interval = 10
        ' 
        ' End_Text
        ' 
        End_Text.AutoSize = True
        End_Text.BackColor = Color.GreenYellow
        End_Text.Font = New Font("Segoe UI Black", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        End_Text.ForeColor = Color.Red
        End_Text.Location = New Point(81, 106)
        End_Text.Name = "End_Text"
        End_Text.Size = New Size(229, 46)
        End_Text.TabIndex = 12
        End_Text.Text = "AI PIERDUT!"
        End_Text.Visible = False
        ' 
        ' Score_Text
        ' 
        Score_Text.AutoSize = True
        Score_Text.FlatStyle = FlatStyle.Flat
        Score_Text.Font = New Font("Segoe UI Black", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Score_Text.ForeColor = Color.DarkRed
        Score_Text.Location = New Point(2, 0)
        Score_Text.Name = "Score_Text"
        Score_Text.Size = New Size(60, 23)
        Score_Text.TabIndex = 13
        Score_Text.Text = "Scor:0"
        ' 
        ' Speed_Text
        ' 
        Speed_Text.AutoSize = True
        Speed_Text.Font = New Font("Segoe UI Black", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Speed_Text.ForeColor = Color.DarkRed
        Speed_Text.Location = New Point(306, 0)
        Speed_Text.Name = "Speed_Text"
        Speed_Text.Size = New Size(78, 23)
        Speed_Text.TabIndex = 14
        Speed_Text.Text = "Viteza:0"
        ' 
        ' S
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(388, 402)
        Controls.Add(Speed_Text)
        Controls.Add(Score_Text)
        Controls.Add(End_Text)
        Controls.Add(EnemyCar1)
        Controls.Add(EnemyCar2)
        Controls.Add(EnemyCar3)
        Controls.Add(Car)
        Controls.Add(PictureBox8)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        MinimumSize = New Size(240, 400)
        Name = "S"
        Text = "S"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(Car, ComponentModel.ISupportInitialize).EndInit()
        CType(EnemyCar3, ComponentModel.ISupportInitialize).EndInit()
        CType(EnemyCar2, ComponentModel.ISupportInitialize).EndInit()
        CType(EnemyCar1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents RoadMover As Timer
    Friend WithEvents Car As PictureBox
    Friend WithEvents Left_mover As Timer
    Friend WithEvents Right_mover As Timer
    Friend WithEvents EnemyCar3 As PictureBox
    Friend WithEvents EnemyCar2 As PictureBox
    Friend WithEvents EnemyCar1 As PictureBox
    Friend WithEvents EnemyMover1 As Timer
    Friend WithEvents EnemyMover2 As Timer
    Friend WithEvents EnemyMover3 As Timer
    Friend WithEvents End_Text As Label
    Friend WithEvents Score_Text As Label
    Friend WithEvents Speed_Text As Label
End Class
