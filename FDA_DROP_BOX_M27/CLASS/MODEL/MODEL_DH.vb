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

    Private _CER_DETAIL_MANUFACTURE As CER_DETAIL_MANUFACTURE
    Public Property CER_DETAIL_MANUFACTURE() As CER_DETAIL_MANUFACTURE
        Get
            Return _CER_DETAIL_MANUFACTURE
        End Get
        Set(ByVal value As CER_DETAIL_MANUFACTURE)
            _CER_DETAIL_MANUFACTURE = value
        End Set
    End Property

    Private _CER_DETAIL_CASCHEMICAL As New List(Of CER_DETAIL_CASCHEMICAL)
    Public Property CER_DETAIL_CASCHEMICAL() As List(Of CER_DETAIL_CASCHEMICAL)
        Get
            Return _CER_DETAIL_CASCHEMICAL
        End Get
        Set(ByVal value As List(Of CER_DETAIL_CASCHEMICAL))
            _CER_DETAIL_CASCHEMICAL = value
        End Set
    End Property
End Class
