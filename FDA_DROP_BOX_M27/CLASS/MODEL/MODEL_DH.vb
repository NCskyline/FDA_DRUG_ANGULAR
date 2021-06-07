Public Class MODEL_DH

    Public lcnno As String
    Public rcvno As String
    Public rcvdate As Date
    Public thanameplace As String
    Public nameOperator As String
    Public Certificate_Number As String
    Public Manufacturer As String
    Public Address As String
    Public Province As String
    Public Country As String
    Public MFD_DATE As Date
    Public EXP_DATE As Date



End Class

Public Class MODEL_CER_GMP
    Private _CER As New CER
    Public Property CER() As CER
        Get
            Return _CER
        End Get
        Set(ByVal value As CER)
            _CER = value
        End Set
    End Property
End Class
