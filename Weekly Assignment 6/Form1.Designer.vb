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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.btnInternetSpeed = New System.Windows.Forms.Button()
        Me.lbxInput = New System.Windows.Forms.ListBox()
        Me.lblAvgSpeed = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.BackColor = System.Drawing.Color.White
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeading.Location = New System.Drawing.Point(274, 20)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(325, 39)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Internet Speed Test Survey"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnInternetSpeed
        '
        Me.btnInternetSpeed.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnInternetSpeed.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnInternetSpeed.ForeColor = System.Drawing.Color.Black
        Me.btnInternetSpeed.Location = New System.Drawing.Point(333, 73)
        Me.btnInternetSpeed.Name = "btnInternetSpeed"
        Me.btnInternetSpeed.Size = New System.Drawing.Size(195, 40)
        Me.btnInternetSpeed.TabIndex = 2
        Me.btnInternetSpeed.Text = "Enter Internet Speed"
        Me.btnInternetSpeed.UseVisualStyleBackColor = False
        '
        'lbxInput
        '
        Me.lbxInput.FormattingEnabled = True
        Me.lbxInput.Location = New System.Drawing.Point(614, 58)
        Me.lbxInput.Name = "lbxInput"
        Me.lbxInput.Size = New System.Drawing.Size(74, 160)
        Me.lbxInput.TabIndex = 3
        '
        'lblAvgSpeed
        '
        Me.lblAvgSpeed.BackColor = System.Drawing.Color.Transparent
        Me.lblAvgSpeed.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblAvgSpeed.Location = New System.Drawing.Point(375, 399)
        Me.lblAvgSpeed.Name = "lblAvgSpeed"
        Me.lblAvgSpeed.Size = New System.Drawing.Size(282, 35)
        Me.lblAvgSpeed.TabIndex = 5
        Me.lblAvgSpeed.Text = "XXXXXXXXXXXX 0000"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(524, 334)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Weekly_Assignment_6.My.Resources.Resources.speed
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(712, 462)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblAvgSpeed)
        Me.Controls.Add(Me.lbxInput)
        Me.Controls.Add(Me.btnInternetSpeed)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHeading As Label
    Friend WithEvents btnInternetSpeed As Button
    Friend WithEvents lbxInput As ListBox
    Friend WithEvents lblAvgSpeed As Label
    Friend WithEvents btnClear As Button
End Class
