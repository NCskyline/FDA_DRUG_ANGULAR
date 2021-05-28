Public Class MODEL_DL
    Private _IDA_BIO As String
    Public Property IDA_BIO() As String
        Get
            Return _IDA_BIO
        End Get
        Set(ByVal value As String)
            _IDA_BIO = value
        End Set
    End Property
    Private _BIO_UNIT As String
    Public Property BIO_UNIT() As String
        Get
            Return _BIO_UNIT
        End Get
        Set(ByVal value As String)
            _BIO_UNIT = value
        End Set
    End Property
    Private _UOP_CODE As String
    Public Property UOP_CODE() As String
        Get
            Return _UOP_CODE
        End Get
        Set(ByVal value As String)
            _UOP_CODE = value
        End Set
    End Property
    Private _PACKAGING_NAME As String
    Public Property PACKAGING_NAME() As String
        Get
            Return _PACKAGING_NAME
        End Get
        Set(ByVal value As String)
            _PACKAGING_NAME = value
        End Set
    End Property
End Class
