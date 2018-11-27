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
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.File_List = New System.Windows.Forms.ListBox()
        Me.Show_Files = New System.Windows.Forms.Button()
        Me.Play = New System.Windows.Forms.Button()
        Me.Pause = New System.Windows.Forms.Button()
        Me.Select_Song = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        Me.Skip = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM4"
        '
        'File_List
        '
        Me.File_List.FormattingEnabled = True
        Me.File_List.Location = New System.Drawing.Point(104, 12)
        Me.File_List.Name = "File_List"
        Me.File_List.Size = New System.Drawing.Size(120, 95)
        Me.File_List.TabIndex = 0
        '
        'Show_Files
        '
        Me.Show_Files.Location = New System.Drawing.Point(57, 132)
        Me.Show_Files.Name = "Show_Files"
        Me.Show_Files.Size = New System.Drawing.Size(88, 23)
        Me.Show_Files.TabIndex = 1
        Me.Show_Files.Text = "Show Files"
        Me.Show_Files.UseVisualStyleBackColor = True
        '
        'Play
        '
        Me.Play.Location = New System.Drawing.Point(187, 132)
        Me.Play.Name = "Play"
        Me.Play.Size = New System.Drawing.Size(88, 23)
        Me.Play.TabIndex = 2
        Me.Play.Text = "Play"
        Me.Play.UseVisualStyleBackColor = True
        '
        'Pause
        '
        Me.Pause.Location = New System.Drawing.Point(187, 178)
        Me.Pause.Name = "Pause"
        Me.Pause.Size = New System.Drawing.Size(88, 23)
        Me.Pause.TabIndex = 3
        Me.Pause.Text = "Pause"
        Me.Pause.UseVisualStyleBackColor = True
        '
        'Select_Song
        '
        Me.Select_Song.Location = New System.Drawing.Point(57, 178)
        Me.Select_Song.Name = "Select_Song"
        Me.Select_Song.Size = New System.Drawing.Size(88, 23)
        Me.Select_Song.TabIndex = 4
        Me.Select_Song.Text = "Select Song"
        Me.Select_Song.UseVisualStyleBackColor = True
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(57, 217)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(88, 23)
        Me.Back.TabIndex = 5
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'Skip
        '
        Me.Skip.Location = New System.Drawing.Point(187, 217)
        Me.Skip.Name = "Skip"
        Me.Skip.Size = New System.Drawing.Size(88, 23)
        Me.Skip.TabIndex = 6
        Me.Skip.Text = "Skip"
        Me.Skip.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 281)
        Me.Controls.Add(Me.Skip)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Select_Song)
        Me.Controls.Add(Me.Pause)
        Me.Controls.Add(Me.Play)
        Me.Controls.Add(Me.Show_Files)
        Me.Controls.Add(Me.File_List)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents File_List As System.Windows.Forms.ListBox
    Friend WithEvents Show_Files As System.Windows.Forms.Button
    Friend WithEvents Play As System.Windows.Forms.Button
    Friend WithEvents Pause As System.Windows.Forms.Button
    Friend WithEvents Select_Song As System.Windows.Forms.Button
    Friend WithEvents Back As System.Windows.Forms.Button
    Friend WithEvents Skip As System.Windows.Forms.Button

End Class
