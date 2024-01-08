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
        Me.btnHarrisonOH = New System.Windows.Forms.Button()
        Me.btnNorwoodOh = New System.Windows.Forms.Button()
        Me.btnErlangerKy = New System.Windows.Forms.Button()
        Me.btnFlorenceKy = New System.Windows.Forms.Button()
        Me.btnLawrenceburgIn = New System.Windows.Forms.Button()
        Me.btnRisingSunIn = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblZipCode = New System.Windows.Forms.Label()
        Me.lblZipCodeText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnHarrisonOH
        '
        Me.btnHarrisonOH.Location = New System.Drawing.Point(67, 18)
        Me.btnHarrisonOH.Name = "btnHarrisonOH"
        Me.btnHarrisonOH.Size = New System.Drawing.Size(100, 23)
        Me.btnHarrisonOH.TabIndex = 0
        Me.btnHarrisonOH.Text = "Harrison, Oh"
        Me.btnHarrisonOH.UseVisualStyleBackColor = True
        '
        'btnNorwoodOh
        '
        Me.btnNorwoodOh.Location = New System.Drawing.Point(67, 61)
        Me.btnNorwoodOh.Name = "btnNorwoodOh"
        Me.btnNorwoodOh.Size = New System.Drawing.Size(100, 23)
        Me.btnNorwoodOh.TabIndex = 1
        Me.btnNorwoodOh.Text = "Norwood, Oh"
        Me.btnNorwoodOh.UseVisualStyleBackColor = True
        '
        'btnErlangerKy
        '
        Me.btnErlangerKy.Location = New System.Drawing.Point(67, 104)
        Me.btnErlangerKy.Name = "btnErlangerKy"
        Me.btnErlangerKy.Size = New System.Drawing.Size(100, 23)
        Me.btnErlangerKy.TabIndex = 2
        Me.btnErlangerKy.Text = "Erlanger, Ky"
        Me.btnErlangerKy.UseVisualStyleBackColor = True
        '
        'btnFlorenceKy
        '
        Me.btnFlorenceKy.Location = New System.Drawing.Point(67, 147)
        Me.btnFlorenceKy.Name = "btnFlorenceKy"
        Me.btnFlorenceKy.Size = New System.Drawing.Size(100, 23)
        Me.btnFlorenceKy.TabIndex = 3
        Me.btnFlorenceKy.Text = "Florence, Ky"
        Me.btnFlorenceKy.UseVisualStyleBackColor = True
        '
        'btnLawrenceburgIn
        '
        Me.btnLawrenceburgIn.Location = New System.Drawing.Point(67, 190)
        Me.btnLawrenceburgIn.Name = "btnLawrenceburgIn"
        Me.btnLawrenceburgIn.Size = New System.Drawing.Size(100, 23)
        Me.btnLawrenceburgIn.TabIndex = 4
        Me.btnLawrenceburgIn.Text = "Lawrenceburg, In"
        Me.btnLawrenceburgIn.UseVisualStyleBackColor = True
        '
        'btnRisingSunIn
        '
        Me.btnRisingSunIn.Location = New System.Drawing.Point(67, 233)
        Me.btnRisingSunIn.Name = "btnRisingSunIn"
        Me.btnRisingSunIn.Size = New System.Drawing.Size(100, 23)
        Me.btnRisingSunIn.TabIndex = 5
        Me.btnRisingSunIn.Text = "Rising Sun, In"
        Me.btnRisingSunIn.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(80, 309)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblZipCode
        '
        Me.lblZipCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblZipCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZipCode.Location = New System.Drawing.Point(99, 271)
        Me.lblZipCode.Name = "lblZipCode"
        Me.lblZipCode.Size = New System.Drawing.Size(100, 23)
        Me.lblZipCode.TabIndex = 7
        Me.lblZipCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblZipCodeText
        '
        Me.lblZipCodeText.Location = New System.Drawing.Point(35, 276)
        Me.lblZipCodeText.Name = "lblZipCodeText"
        Me.lblZipCodeText.Size = New System.Drawing.Size(58, 23)
        Me.lblZipCodeText.TabIndex = 8
        Me.lblZipCodeText.Text = "Zip Code:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 351)
        Me.Controls.Add(Me.lblZipCodeText)
        Me.Controls.Add(Me.lblZipCode)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRisingSunIn)
        Me.Controls.Add(Me.btnLawrenceburgIn)
        Me.Controls.Add(Me.btnFlorenceKy)
        Me.Controls.Add(Me.btnErlangerKy)
        Me.Controls.Add(Me.btnNorwoodOh)
        Me.Controls.Add(Me.btnHarrisonOH)
        Me.Name = "Form1"
        Me.Text = "Zip Codes"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHarrisonOH As Button
    Friend WithEvents btnNorwoodOh As Button
    Friend WithEvents btnErlangerKy As Button
    Friend WithEvents btnFlorenceKy As Button
    Friend WithEvents btnLawrenceburgIn As Button
    Friend WithEvents btnRisingSunIn As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblZipCode As Label
    Friend WithEvents lblZipCodeText As Label
End Class
