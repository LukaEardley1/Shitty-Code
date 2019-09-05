Public Class SilverPackage
    Inherits Packages

    Private _SavingsBalance As Double
    'Calculated shit
    Private SaveStatus As String
    Private CashOutStatus As String
    Private InterestReturn As Double

    Public Property SavingsBalance As Double
        Set(SavingsBalance As Double)
            _SavingsBalance = SavingsBalance
        End Set
        Get
            Return _SavingsBalance
        End Get
    End Property

    Public Function Save(Amount) As Double
        If Amount < TransactionBallance Then
            TransactionBallance -= Amount
            SavingsBalance += Amount
            SaveStatus = "True"
        ElseIf Amount > TransactionBallance Then
            SaveStatus = "False"
        End If
        PayInterest()
        Return 0
    End Function

    Public Function CashOut(Amount) As Double
        If Amount < SavingsBalance Then
            SavingsBalance -= Amount
            TransactionBallance += Amount
            CashOutStatus = "True"
        ElseIf Amount > SavingsBalance Then
            CashOutStatus = "False"
        End If

        Return 0
    End Function

    Public Sub PayInterest()
        InterestReturn = SavingsBalance * (1 + (0.045 / 12)) ^ 12
        SavingsBalance += InterestReturn
    End Sub

    'overloading
    Overloads Function Deposit(Value) As Double
        TransactionBallance += Value
        nDeposits += 1
        Return TransactionBallance
    End Function

    Overloads Function Withdraw(Value) As Double
        If Value < TransactionBallance Then
            TransactionBallance -= Value
            TransactionStatus = "True"
            nWithdrawls += 1
        ElseIf Value > TransactionBallance Then
            TransactionStatus = "False"
        End If
        Return TransactionBallance
    End Function
End Class
