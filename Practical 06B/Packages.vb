Public Class Packages
    Private _PackageID As Integer
    Private _TransactionBallance As Double
    Private _CustomerName As String
    Private _CustomerSurname As String
    Private _nDeposits As Integer = 0
    Private _nWithdrawls As Integer = 0
    'shit to be calculated
    Private _UBux As Double
    Private _TransactionStatus As String
    Public Sub AssignID(Name, Surname)
        PackageID = CStr(Name & Surname + 6)
        TransactionBallance = 0
    End Sub
    Public Sub New()

    End Sub

    Public Property PackageID As Integer
        Set(PackageID As Integer)
            _PackageID = PackageID
        End Set
        Get
            Return _PackageID
        End Get
    End Property

    Public Property TransactionBallance As Double
        Set(TransactionBallance As Double)
            _TransactionBallance = TransactionBallance
        End Set
        Get
            Return _TransactionBallance
        End Get
    End Property

    Public Property CustomerName As String
        Set(CustomerName As String)
            _CustomerName = CustomerName
        End Set
        Get
            Return _CustomerName
        End Get
    End Property

    Public Property CustomerSurname As String
        Set(CustomerSurname As String)
            _CustomerSurname = CustomerSurname
        End Set
        Get
            Return _CustomerSurname
        End Get
    End Property

    Public Property nDeposits As Integer
        Set(nDeposits As Integer)
            _nDeposits = nDeposits
        End Set
        Get
            Return _nDeposits
        End Get
    End Property

    Public Property nWithdrawls As Integer
        Set(nWithdrawls As Integer)
            _nWithdrawls = nWithdrawls
        End Set
        Get
            Return _nWithdrawls
        End Get
    End Property
    'calculated shit
    Public Property UBux As Double
        Set(UBux As Double)
            _UBux = UBux
        End Set
        Get
            Return _UBux
        End Get
    End Property
    Public Property TransactionStatus As String
        Set(TransactionStatus As String)
            _TransactionStatus = TransactionStatus
        End Set
        Get
            Return _TransactionStatus
        End Get
    End Property
    Private Function CalcUBux() As Double
        If nDeposits > nWithdrawls Then
            UBux = TransactionBallance * 0.1
        ElseIf nDeposits < nWithdrawls Then
            UBux = TransactionBallance * 0.05
        Else
            UBux = TransactionBallance * 0.075
        End If
        Return UBux
    End Function

    Private Function Deposit(Value) As Double
        TransactionBallance += Value
        nDeposits += 1
        Return TransactionBallance
    End Function

    Private Function Withdraw(Value, Balance) As Double
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
End Class
