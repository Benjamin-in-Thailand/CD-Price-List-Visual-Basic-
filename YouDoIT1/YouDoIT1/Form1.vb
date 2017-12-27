'Name: CD Receipt Project
'Purpose: To integrate the skills I have learned to date
'Programmer: Benjamin Hays

Option Explicit On
Option Infer Off
Option Strict On

Public Class Form1
    Private Sub btnCalc_click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Const strBASEPRICE As String = "$12"
        Const strCOUPONONE As String = "$10"
        Const strCOUPONTWO As String = "$8"
        Const strPROMPT As String = "Is the coupon $4"
        Dim strCost As String
        Dim dlgbutton As DialogResult

        strCost = txtPrice.Text.ToUpper

        If strCost = "YES" Then
            dlgbutton = MessageBox.Show(strPROMPT, "Coupon Price", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If dlgbutton = DialogResult.Yes Then
                lblPrice.Text = strCOUPONTWO
            Else
                lblPrice.Text = strCOUPONONE
            End If
        Else
            lblPrice.Text = strBASEPRICE
        End If
    End Sub
    Private Sub btnClose_click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub btnPrint_click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'Hides the forms's buttons
        btnCalc.Visible = False
        btnClear.Visible = False
        btnClose.Visible = False
        btnPrint.Visible = False

        'Prints the sales receipt
        PrintForm1.Print()

        'Shows the form's buttons
        btnCalc.Visible = True
        btnClear.Visible = True
        btnClose.Visible = True
        btnPrint.Visible = True
    End Sub

    Private Sub btnClear_click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Prepares the screen for the next sale

        txtPrice.Text = String.Empty
        lblPrice.Text = String.Empty
        'sends the focus to the Coupon  box
        txtPrice.Focus()
    End Sub
    Private Sub txtDate_keypress(sender As Object, e As KeyPressEventArgs) Handles txtDate.KeyPress
        'Allows the textbox to only accept dates, and the slash "/", backspace, and dash "-" key
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back AndAlso
                e.KeyChar <> "/" Then
            e.Handled = True
        End If
    End Sub

End Class
