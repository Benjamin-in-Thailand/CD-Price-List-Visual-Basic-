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
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblCoupon = New System.Windows.Forms.Label()
        Me.lblCDPriceTotal = New System.Windows.Forms.Label()
        Me.lblSalesRecipt = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(224, 61)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(83, 37)
        Me.btnCalc.TabIndex = 8
        Me.btnCalc.Text = "Price of C&D"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'lblPrice
        '
        Me.lblPrice.BackColor = System.Drawing.SystemColors.Info
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrice.Location = New System.Drawing.Point(80, 221)
        Me.lblPrice.MaximumSize = New System.Drawing.Size(85, 20)
        Me.lblPrice.MinimumSize = New System.Drawing.Size(85, 20)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(85, 20)
        Me.lblPrice.TabIndex = 7
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(80, 170)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 5
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(221, 214)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(86, 29)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "E&xit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblCoupon
        '
        Me.lblCoupon.AutoSize = True
        Me.lblCoupon.Location = New System.Drawing.Point(19, 173)
        Me.lblCoupon.Name = "lblCoupon"
        Me.lblCoupon.Size = New System.Drawing.Size(50, 13)
        Me.lblCoupon.TabIndex = 4
        Me.lblCoupon.Text = "Coupon?"
        '
        'lblCDPriceTotal
        '
        Me.lblCDPriceTotal.AutoSize = True
        Me.lblCDPriceTotal.Location = New System.Drawing.Point(20, 222)
        Me.lblCDPriceTotal.Name = "lblCDPriceTotal"
        Me.lblCDPriceTotal.Size = New System.Drawing.Size(49, 13)
        Me.lblCDPriceTotal.TabIndex = 6
        Me.lblCDPriceTotal.Text = "CD Cost:"
        '
        'lblSalesRecipt
        '
        Me.lblSalesRecipt.AutoSize = True
        Me.lblSalesRecipt.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesRecipt.Location = New System.Drawing.Point(111, 9)
        Me.lblSalesRecipt.Name = "lblSalesRecipt"
        Me.lblSalesRecipt.Size = New System.Drawing.Size(164, 32)
        Me.lblSalesRecipt.TabIndex = 12
        Me.lblSalesRecipt.Text = "Sales Receipt"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(224, 117)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(83, 28)
        Me.btnPrint.TabIndex = 9
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(221, 165)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(86, 28)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "C&lear Screen"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(19, 125)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "Date:"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(80, 122)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(100, 20)
        Me.txtDate.TabIndex = 3
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(17, 73)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(80, 70)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 1
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 299)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblSalesRecipt)
        Me.Controls.Add(Me.lblCDPriceTotal)
        Me.Controls.Add(Me.lblCoupon)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.btnCalc)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.Text = "CD Price Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalc As Button
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents lblCoupon As Label
    Friend WithEvents lblCDPriceTotal As Label
    Friend WithEvents lblSalesRecipt As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents btnClear As Button
    Friend WithEvents txtDate As TextBox
    Friend WithEvents lblDate As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
End Class
