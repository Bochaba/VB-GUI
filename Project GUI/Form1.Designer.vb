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
        Me.Skip = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM9"
        '
        'File_List
        '
        Me.File_List.FormattingEnabled = True
        Me.File_List.ItemHeight = 16
        Me.File_List.Location = New System.Drawing.Point(146, 12)
        Me.File_List.Name = "File_List"
        Me.File_List.Size = New System.Drawing.Size(299, 196)
        Me.File_List.TabIndex = 0
        '
        'Show_Files
        '
        Me.Show_Files.Location = New System.Drawing.Point(154, 291)
        Me.Show_Files.Name = "Show_Files"
        Me.Show_Files.Size = New System.Drawing.Size(102, 50)
        Me.Show_Files.TabIndex = 1
        Me.Show_Files.Text = "Show_Files"
        Me.Show_Files.UseVisualStyleBackColor = True
        '
        'Play
        '
        Me.Play.Location = New System.Drawing.Point(331, 226)
        Me.Play.Name = "Play"
        Me.Play.Size = New System.Drawing.Size(102, 50)
        Me.Play.TabIndex = 2
        Me.Play.Text = "Play"
        Me.Play.UseVisualStyleBackColor = True
        '
        'Pause
        '
        Me.Pause.Location = New System.Drawing.Point(331, 291)
        Me.Pause.Name = "Pause"
        Me.Pause.Size = New System.Drawing.Size(102, 50)
        Me.Pause.TabIndex = 3
        Me.Pause.Text = "Pause"
        Me.Pause.UseVisualStyleBackColor = True
        '
        'Select_Song
        '
        Me.Select_Song.Location = New System.Drawing.Point(154, 226)
        Me.Select_Song.Name = "Select_Song"
        Me.Select_Song.Size = New System.Drawing.Size(102, 50)
        Me.Select_Song.TabIndex = 4
        Me.Select_Song.Text = "Select_Song"
        Me.Select_Song.UseVisualStyleBackColor = True
        '
        'Skip
        '
        Me.Skip.Location = New System.Drawing.Point(331, 365)
        Me.Skip.Name = "Skip"
        Me.Skip.Size = New System.Drawing.Size(102, 50)
        Me.Skip.TabIndex = 5
        Me.Skip.Text = "Skip"
        Me.Skip.UseVisualStyleBackColor = True
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(154, 365)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(102, 50)
        Me.Back.TabIndex = 6
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Skip)
        Me.Controls.Add(Me.Select_Song)
        Me.Controls.Add(Me.Pause)
        Me.Controls.Add(Me.Play)
        Me.Controls.Add(Me.Show_Files)
        Me.Controls.Add(Me.File_List)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents File_List As ListBox
    Friend WithEvents Show_Files As Button
    Friend WithEvents Play As Button
    Friend WithEvents Pause As Button
    Friend WithEvents Select_Song As Button
    Friend WithEvents Skip As Button
    Friend WithEvents Back As Button
End Class
