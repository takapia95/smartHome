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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSaving = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.cboMonths = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(360, 261)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Notram", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(412, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Smart Home Electric Savings"
        '
        'lblSaving
        '
        Me.lblSaving.AutoSize = True
        Me.lblSaving.Font = New System.Drawing.Font("Notram", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaving.Location = New System.Drawing.Point(270, 283)
        Me.lblSaving.Name = "lblSaving"
        Me.lblSaving.Size = New System.Drawing.Size(63, 19)
        Me.lblSaving.TabIndex = 4
        Me.lblSaving.Text = "xxxxxx"
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Font = New System.Drawing.Font("Notram", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverage.Location = New System.Drawing.Point(270, 378)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(63, 19)
        Me.lblAverage.TabIndex = 5
        Me.lblAverage.Text = "xxxxxx"
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.Font = New System.Drawing.Font("Notram", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMax.Location = New System.Drawing.Point(270, 408)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(63, 19)
        Me.lblMax.TabIndex = 6
        Me.lblMax.Text = "xxxxxx"
        '
        'btnDisplay
        '
        Me.btnDisplay.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnDisplay.Font = New System.Drawing.Font("Notram", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(274, 319)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(180, 45)
        Me.btnDisplay.TabIndex = 7
        Me.btnDisplay.Text = "Display Statistics"
        Me.btnDisplay.UseVisualStyleBackColor = False
        '
        'cboMonths
        '
        Me.cboMonths.Font = New System.Drawing.Font("Script MT Bold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonths.FormattingEnabled = True
        Me.cboMonths.Location = New System.Drawing.Point(501, 89)
        Me.cboMonths.Name = "cboMonths"
        Me.cboMonths.Size = New System.Drawing.Size(156, 26)
        Me.cboMonths.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cboMonths)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lblMax)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblSaving)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Smart Home Application"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSaving As Label
    Friend WithEvents lblAverage As Label
    Friend WithEvents lblMax As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents cboMonths As ComboBox
End Class
