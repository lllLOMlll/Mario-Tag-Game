<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MarioGame
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(MarioGame))
        Button_Stop = New Button()
        PictureBox_Mario_Score = New PictureBox()
        PictureBox_Luigi_Score = New PictureBox()
        Label_Mario_Losses = New Label()
        Label_Luigi_Losses = New Label()
        Timer1 = New Timer(components)
        Button_Start = New Button()
        Button_New_Game = New Button()
        Panel1 = New Panel()
        Label_Title = New Label()
        Label_Game_Lost = New Label()
        CType(PictureBox_Mario_Score, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox_Luigi_Score, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button_Stop
        ' 
        Button_Stop.BackColor = Color.Lime
        Button_Stop.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Button_Stop.FlatAppearance.BorderSize = 4
        Button_Stop.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Button_Stop.FlatStyle = FlatStyle.Flat
        Button_Stop.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Stop.Location = New Point(392, 155)
        Button_Stop.Name = "Button_Stop"
        Button_Stop.Size = New Size(158, 47)
        Button_Stop.TabIndex = 3
        Button_Stop.Text = "STOP"
        Button_Stop.UseVisualStyleBackColor = False
        ' 
        ' PictureBox_Mario_Score
        ' 
        PictureBox_Mario_Score.Image = CType(resources.GetObject("PictureBox_Mario_Score.Image"), Image)
        PictureBox_Mario_Score.Location = New Point(50, 78)
        PictureBox_Mario_Score.Name = "PictureBox_Mario_Score"
        PictureBox_Mario_Score.Size = New Size(73, 71)
        PictureBox_Mario_Score.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox_Mario_Score.TabIndex = 4
        PictureBox_Mario_Score.TabStop = False
        ' 
        ' PictureBox_Luigi_Score
        ' 
        PictureBox_Luigi_Score.Image = CType(resources.GetObject("PictureBox_Luigi_Score.Image"), Image)
        PictureBox_Luigi_Score.Location = New Point(477, 78)
        PictureBox_Luigi_Score.Name = "PictureBox_Luigi_Score"
        PictureBox_Luigi_Score.Size = New Size(73, 71)
        PictureBox_Luigi_Score.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox_Luigi_Score.TabIndex = 5
        PictureBox_Luigi_Score.TabStop = False
        ' 
        ' Label_Mario_Losses
        ' 
        Label_Mario_Losses.AutoSize = True
        Label_Mario_Losses.Font = New Font("Impact", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Mario_Losses.Location = New Point(139, 93)
        Label_Mario_Losses.Name = "Label_Mario_Losses"
        Label_Mario_Losses.Size = New Size(32, 36)
        Label_Mario_Losses.TabIndex = 6
        Label_Mario_Losses.Text = "0"
        ' 
        ' Label_Luigi_Losses
        ' 
        Label_Luigi_Losses.AutoSize = True
        Label_Luigi_Losses.Font = New Font("Impact", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Luigi_Losses.Location = New Point(429, 93)
        Label_Luigi_Losses.Name = "Label_Luigi_Losses"
        Label_Luigi_Losses.Size = New Size(32, 36)
        Label_Luigi_Losses.TabIndex = 7
        Label_Luigi_Losses.Text = "0"
        ' 
        ' Timer1
        ' 
        ' 
        ' Button_Start
        ' 
        Button_Start.BackColor = Color.Lime
        Button_Start.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Button_Start.FlatAppearance.BorderSize = 4
        Button_Start.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Button_Start.FlatStyle = FlatStyle.Flat
        Button_Start.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Start.Location = New Point(221, 155)
        Button_Start.Name = "Button_Start"
        Button_Start.Size = New Size(165, 47)
        Button_Start.TabIndex = 2
        Button_Start.Text = "START"
        Button_Start.UseVisualStyleBackColor = False
        ' 
        ' Button_New_Game
        ' 
        Button_New_Game.BackColor = Color.Lime
        Button_New_Game.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Button_New_Game.FlatAppearance.BorderSize = 4
        Button_New_Game.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Button_New_Game.FlatStyle = FlatStyle.Flat
        Button_New_Game.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button_New_Game.Location = New Point(50, 155)
        Button_New_Game.Name = "Button_New_Game"
        Button_New_Game.Size = New Size(165, 47)
        Button_New_Game.TabIndex = 1
        Button_New_Game.Text = "NEW GAME"
        Button_New_Game.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        Panel1.Location = New Point(50, 208)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(500, 350)
        Panel1.TabIndex = 8
        ' 
        ' Label_Title
        ' 
        Label_Title.AutoSize = True
        Label_Title.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Title.ForeColor = Color.Blue
        Label_Title.Location = New Point(50, 20)
        Label_Title.Name = "Label_Title"
        Label_Title.Size = New Size(494, 40)
        Label_Title.TabIndex = 9
        Label_Title.Text = "Mario, Luigi and Boooooooooooo!"
        ' 
        ' Label_Game_Lost
        ' 
        Label_Game_Lost.AutoSize = True
        Label_Game_Lost.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Game_Lost.ForeColor = Color.Red
        Label_Game_Lost.Location = New Point(211, 85)
        Label_Game_Lost.Name = "Label_Game_Lost"
        Label_Game_Lost.Size = New Size(175, 40)
        Label_Game_Lost.TabIndex = 10
        Label_Game_Lost.Text = "Games Lost"
        ' 
        ' MarioGame
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        ClientSize = New Size(585, 570)
        Controls.Add(Label_Game_Lost)
        Controls.Add(Label_Title)
        Controls.Add(Label_Luigi_Losses)
        Controls.Add(Label_Mario_Losses)
        Controls.Add(PictureBox_Luigi_Score)
        Controls.Add(PictureBox_Mario_Score)
        Controls.Add(Button_Stop)
        Controls.Add(Button_Start)
        Controls.Add(Button_New_Game)
        Controls.Add(Panel1)
        Name = "MarioGame"
        Text = "MarioGame"
        CType(PictureBox_Mario_Score, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox_Luigi_Score, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button_Stop As Button
    Friend WithEvents PictureBox_Mario_Score As PictureBox
    Friend WithEvents PictureBox_Luigi_Score As PictureBox
    Friend WithEvents Label_Mario_Losses As Label
    Friend WithEvents Label_Luigi_Losses As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button_Start As Button
    Friend WithEvents Button_New_Game As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label_Title As Label
    Friend WithEvents Label_Game_Lost As Label
End Class
