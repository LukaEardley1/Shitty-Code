Public Class BluePackage
    Inherits Packages
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
        Return TransactionStatus
    End Function
    Overloads Function CalcUBux() As Double
        If nDeposits > nWithdrawls Then
            UBux = TransactionBallance * 0.1
        ElseIf nDeposits < nWithdrawls Then
            UBux = TransactionBallance * 0.05
        Else
            UBux = TransactionBallance * 0.075
        End If
        Return UBux
    End Function
End Class
