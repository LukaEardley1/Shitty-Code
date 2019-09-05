<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BankTracker
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
        Me.cbPackageOption = New System.Windows.Forms.ComboBox()
        Me.btnCreateAccount = New System.Windows.Forms.Button()
        Me.grdBlueTracker = New UJGrid.UJGrid()
        Me.btnBlueDeposit = New System.Windows.Forms.Button()
        Me.btnBlueWithdraw = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSilverWithdraw = New System.Windows.Forms.Button()
        Me.btnSilverDeposit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCashOut = New System.Windows.Forms.Button()
        Me.btnCheckUBux = New System.Windows.Forms.Button()
        Me.grdSilverTracker = New UJGrid.UJGrid()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbPackageOption
        '
        Me.cbPackageOption.AutoCompleteCustomSource.AddRange(New String() {"Blue Package", "Silver Package"})
        Me.cbPackageOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPackageOption.FormattingEnabled = True
        Me.cbPackageOption.Items.AddRange(New Object() {"Blue Package", "Silver Package"})
        Me.cbPackageOption.Location = New System.Drawing.Point(21, 44)
        Me.cbPackageOption.Name = "cbPackageOption"
        Me.cbPackageOption.Size = New System.Drawing.Size(165, 28)
        Me.cbPackageOption.TabIndex = 0
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateAccount.Location = New System.Drawing.Point(21, 89)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(165, 46)
        Me.btnCreateAccount.TabIndex = 1
        Me.btnCreateAccount.Text = "Create Account"
        Me.btnCreateAccount.UseVisualStyleBackColor = True
        '
        'grdBlueTracker
        '
        Me.grdBlueTracker.FixedCols = 1
        Me.grdBlueTracker.FixedRows = 1
        Me.grdBlueTracker.Location = New System.Drawing.Point(224, 44)
        Me.grdBlueTracker.Name = "grdBlueTracker"
        Me.grdBlueTracker.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdBlueTracker.Size = New System.Drawing.Size(547, 233)
        Me.grdBlueTracker.TabIndex = 2
        '
        'btnBlueDeposit
        '
        Me.btnBlueDeposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBlueDeposit.Location = New System.Drawing.Point(21, 179)
        Me.btnBlueDeposit.Name = "btnBlueDeposit"
        Me.btnBlueDeposit.Size = New System.Drawing.Size(165, 46)
        Me.btnBlueDeposit.TabIndex = 3
        Me.btnBlueDeposit.Text = "Deposit"
        Me.btnBlueDeposit.UseVisualStyleBackColor = True
        '
        'btnBlueWithdraw
        '
        Me.btnBlueWithdraw.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBlueWithdraw.Location = New System.Drawing.Point(21, 231)
        Me.btnBlueWithdraw.Name = "btnBlueWithdraw"
        Me.btnBlueWithdraw.Size = New System.Drawing.Size(165, 46)
        Me.btnBlueWithdraw.TabIndex = 4
        Me.btnBlueWithdraw.Text = "Withdraw"
        Me.btnBlueWithdraw.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Choose Package Option:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Blue Package:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 342)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Silver Package:"
        '
        'btnSilverWithdraw
        '
        Me.btnSilverWithdraw.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSilverWithdraw.Location = New System.Drawing.Point(21, 417)
        Me.btnSilverWithdraw.Name = "btnSilverWithdraw"
        Me.btnSilverWithdraw.Size = New System.Drawing.Size(165, 46)
        Me.btnSilverWithdraw.TabIndex = 11
        Me.btnSilverWithdraw.Text = "Withdraw"
        Me.btnSilverWithdraw.UseVisualStyleBackColor = True
        '
        'btnSilverDeposit
        '
        Me.btnSilverDeposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSilverDeposit.Location = New System.Drawing.Point(21, 365)
        Me.btnSilverDeposit.Name = "btnSilverDeposit"
        Me.btnSilverDeposit.Size = New System.Drawing.Size(165, 46)
        Me.btnSilverDeposit.TabIndex = 10
        Me.btnSilverDeposit.Text = "Deposit"
        Me.btnSilverDeposit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(21, 469)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(165, 46)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCashOut
        '
        Me.btnCashOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCashOut.Location = New System.Drawing.Point(21, 521)
        Me.btnCashOut.Name = "btnCashOut"
        Me.btnCashOut.Size = New System.Drawing.Size(165, 46)
        Me.btnCashOut.TabIndex = 13
        Me.btnCashOut.Text = "Cash Out"
        Me.btnCashOut.UseVisualStyleBackColor = True
        '
        'btnCheckUBux
        '
        Me.btnCheckUBux.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckUBux.Location = New System.Drawing.Point(21, 283)
        Me.btnCheckUBux.Name = "btnCheckUBux"
        Me.btnCheckUBux.Size = New System.Drawing.Size(165, 46)
        Me.btnCheckUBux.TabIndex = 14
        Me.btnCheckUBux.Text = "Check UBux"
        Me.btnCheckUBux.UseVisualStyleBackColor = True
        '
        'grdSilverTracker
        '
        Me.grdSilverTracker.FixedCols = 1
        Me.grdSilverTracker.FixedRows = 1
        Me.grdSilverTracker.Location = New System.Drawing.Point(224, 334)
        Me.grdSilverTracker.Name = "grdSilverTracker"
        Me.grdSilverTracker.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdSilverTracker.Size = New System.Drawing.Size(547, 233)
        Me.grdSilverTracker.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(220, 309)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Silver Package:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(220, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Blue Package:"
        '
        'BankTracker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 639)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.grdSilverTracker)
        Me.Controls.Add(Me.btnCheckUBux)
        Me.Controls.Add(Me.btnCashOut)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnSilverWithdraw)
        Me.Controls.Add(Me.btnSilverDeposit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBlueWithdraw)
        Me.Controls.Add(Me.btnBlueDeposit)
        Me.Controls.Add(Me.grdBlueTracker)
        Me.Controls.Add(Me.btnCreateAccount)
        Me.Controls.Add(Me.cbPackageOption)
        Me.Name = "BankTracker"
        Me.Text = "Bank Tracker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbPackageOption As ComboBox
    Friend WithEvents btnCreateAccount As Button
    Friend WithEvents grdBlueTracker As UJGrid.UJGrid
    Friend WithEvents btnBlueDeposit As Button
    Friend WithEvents btnBlueWithdraw As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSilverWithdraw As Button
    Friend WithEvents btnSilverDeposit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCashOut As Button
    Friend WithEvents btnCheckUBux As Button
    Friend WithEvents grdSilverTracker As UJGrid.UJGrid
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
