Option Strict On
Option Explicit On
Option Infer Off

Public Class BankTracker
    Private PackageArray() As Packages = {}
    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        If cbPackageOption.Text = "Silver Package" Then
            CaptureSilverPackage()
        ElseIf cbPackageOption.Text = "Blue Package" Then
            CaptureBluePackage()
        End If

        'DummyData()
    End Sub

    Private Function CaptureSilverPackage() As Integer
        Dim silver As New SilverPackage()
        silver.CustomerName = InputBox("What is your name?", "Specify Name")
        silver.CustomerSurname = InputBox("What is your surname?", "Specify Surname")
        AddToArray(silver)
        DisplaySilverDefault()
        DisplaySilver()
        Return 0
    End Function

    Private Function CaptureBluePackage() As Integer
        Dim Blue As New BluePackage
        Blue.CustomerName = InputBox("What is your name?", "Specify Name")
        Blue.CustomerSurname = InputBox("What is your surname?", "Specify Surname")
        AddToArray(Blue)
        DisplayBlueDefault()
        DisplayBlue()
        Return 0
    End Function
    'Blue Packages
    Private Sub btnBlueDeposit_Click(sender As Object, e As EventArgs) Handles btnBlueDeposit.Click
        Dim Value1 As Double
        Dim temp As New BluePackage()
        Value1 = CDbl(InputBox("How much would you like to deposit into your account?", "Specify Deposit Amount"))
        temp.Deposit(Value1)
        DisplayBlue()
    End Sub

    Private Sub btnBlueWithdraw_Click(sender As Object, e As EventArgs) Handles btnBlueWithdraw.Click
        Dim temp As New BluePackage()
        Dim value2 As Double
        value2 = CDbl(InputBox("How much would you like to withdraw out your account?", "Specify Withdraw Amount"))
        temp.Withdraw(value2)
        DisplayBlue()
    End Sub

    Private Sub btnCheckUBux_Click(sender As Object, e As EventArgs) Handles btnCheckUBux.Click
        Dim temp As New BluePackage()
        temp.CalcUBux()
        DisplayBlue()
    End Sub
    'Silver Packages
    Private Sub btnSilverDeposit_Click(sender As Object, e As EventArgs) Handles btnSilverDeposit.Click
        Dim Value As Double
        Dim temp As New SilverPackage()
        Value = CDbl(InputBox("How much would you like to deposit into your account?", "Specify Deposit Amount"))
        temp.Deposit(Value)
        DisplaySilver()
    End Sub

    Private Sub btnSilverWithdraw_Click(sender As Object, e As EventArgs) Handles btnSilverWithdraw.Click
        Dim temp As New SilverPackage()
        Dim value As Double
        value = CDbl(InputBox("How much would you like to withdraw out your account?", "Specify Withdraw Amount"))
        temp.Withdraw(value)
        DisplaySilver()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim temp As New SilverPackage()
        Dim value As Double
        value = CDbl(InputBox("How much would you like to withdraw out your transactions account?", "Specify Withdraw Amount"))
        temp.Save(value)
        DisplaySilver()
    End Sub

    Private Sub btnCashOut_Click(sender As Object, e As EventArgs) Handles btnCashOut.Click
        Dim temp As New SilverPackage()
        Dim amount As Double
        amount = CDbl(InputBox("How much would you like to withdraw out your savings account?", "Specify Withdraw Amount"))
        temp.CashOut(amount)
        DisplaySilver()
    End Sub

    Private Function AddToArray(ByVal obj As Packages) As Integer
        If PackageArray IsNot Nothing Then
            Array.Resize(PackageArray, PackageArray.Length + 1)
            PackageArray(PackageArray.Length - 1) = obj
        Else
            ReDim PackageArray(0)
            PackageArray(0) = obj
        End If
        Return 0
    End Function
    'graph functions and displaying of calculations

    Public Sub DTB(ByVal c As Integer, ByVal r As Integer, ByVal t As String)
        grdBlueTracker.Col = c
        grdBlueTracker.Row = r
        grdBlueTracker.Text = t
    End Sub

    Public Sub DTS(ByVal c As Integer, ByVal r As Integer, ByVal t As String)
        grdSilverTracker.Col = c
        grdSilverTracker.Row = r
        grdSilverTracker.Text = t
    End Sub

    Private Function DisplaySilverDefault() As Integer
        grdSilverTracker.Cols = PackageArray.Length + 1
        grdSilverTracker.Rows = 7

        DTS(0, 0, "Details:")
        DTS(0, 1, "Name")
        DTS(0, 2, "Surname")
        DTS(0, 3, "ID")
        DTS(0, 4, "Transaction Bal")
        DTS(0, 5, "SaveBalance")
        DTS(0, 6, "UBux")
        Return 0
    End Function

    Private Function DisplayBlueDefault() As Integer
        grdBlueTracker.Cols = PackageArray.Length + 1
        grdBlueTracker.Rows = 6
        DTB(0, 0, "Details:")
        DTB(0, 1, "Name")
        DTB(0, 2, "Surname")
        DTB(0, 3, "ID")
        DTB(0, 4, "Transaction Bal")
        DTB(0, 5, "UBux")
        Return 0
    End Function

    Private Function DisplayBlue() As Integer
        For i As Integer = 0 To PackageArray.Length - 1
            DTB(i + 1, 0, "Account " & CStr(i + 1))
            DTB(i + 1, 1, PackageArray(i).CustomerName)
            DTB(i + 1, 2, PackageArray(i).CustomerSurname)
            DTB(i + 1, 3, CStr(PackageArray(i).PackageID))
            DTB(i + 1, 4, CStr(PackageArray(i).TransactionBallance))
            DTB(i + 1, 5, CStr(PackageArray(i).UBux))
        Next
        Return 0
    End Function

    Private Function DisplaySilver() As Integer
        For i As Integer = 0 To PackageArray.Length - 1
            DTS(i + 1, 0, "Account " & CStr(i + 1))
            DTS(i + 1, 1, PackageArray(i).CustomerName)
            DTS(i + 1, 2, PackageArray(i).CustomerSurname)
            DTS(i + 1, 3, CStr(PackageArray(i).PackageID))
            DTS(i + 1, 4, Format(PackageArray(i).TransactionBallance, "0.00"))
            If TypeOf PackageArray(i) Is SilverPackage Then
                Dim Temp As SilverPackage = CType(PackageArray(i), SilverPackage)
                DTS(i + 1, 5, Format(Temp.SavingsBalance, "0.00"))
            End If
            DTS(i + 1, 6, CStr(PackageArray(i).UBux))

        Next
        Return 0
    End Function

    Private Function DummyData() As Integer
        'Blue Dummy Data

        Dim Blue As New BluePackage()
        Blue.CustomerName = "Arlo"
        Blue.CustomerSurname = "Eardley"
        DisplayBlueDefault()
        Blue.Deposit(21000)
        Blue.Withdraw(14000)
        Blue.CalcUBux()
        AddToArray(Blue)
        DisplayBlue()

        'silver dummy data
        Dim silver As New SilverPackage()
        silver.CustomerName = "Luka"
        silver.CustomerSurname = "Eardley"
        DisplaySilverDefault()
        silver.Deposit(16000)
        silver.Withdraw(4500)
        silver.Save(1000)
        silver.CashOut(2600)
        AddToArray(silver)
        DisplaySilver()

        Return 0
    End Function
End Class

