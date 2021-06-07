Public Class MODEL_LCN

    Private _LCN_IDA As String
    Public Property LCN_IDA() As String
        Get
            Return _LCN_IDA
        End Get
        Set(ByVal value As String)
            _LCN_IDA = value
        End Set
    End Property

    Private _LCNNO As String
    Public Property LCNNO() As String
        Get
            Return _LCNNO
        End Get
        Set(ByVal value As String)
            _LCNNO = value
        End Set
    End Property

    Private _NAME As String
    Public Property NAME() As String
        Get
            Return _NAME
        End Get
        Set(ByVal value As String)
            _NAME = value
        End Set
    End Property

    Private _ADDR As String
    Public Property ADDR() As String
        Get
            Return _ADDR
        End Get
        Set(ByVal value As String)
            _ADDR = value
        End Set
    End Property

    Private _SYSTEM_NAME As String
    Public Property SYSTEM_NAME() As String
        Get
            Return _SYSTEM_NAME
        End Get
        Set(ByVal value As String)
            _SYSTEM_NAME = value
        End Set
    End Property


    Private _LCN_TYPE As String
    Public Property LCN_TYPE() As String
        Get
            Return _LCN_TYPE
        End Get
        Set(ByVal value As String)
            _LCN_TYPE = value
        End Set
    End Property

    Private _LCNNO_SHOW As String
    Public Property LCNNO_SHOW() As String
        Get
            Return _LCNNO_SHOW
        End Get
        Set(ByVal value As String)
            _LCNNO_SHOW = value
        End Set
    End Property
    Private _TYPE_IMPORT As String
    Public Property TYPE_IMPORT() As String
        Get
            Return _TYPE_IMPORT
        End Get
        Set(ByVal value As String)
            _TYPE_IMPORT = value
        End Set
    End Property

    Private _THANAMEPLACE As String
    Public Property THANAMEPLACE() As String
        Get
            Return _THANAMEPLACE
        End Get
        Set(ByVal value As String)
            _THANAMEPLACE = value
        End Set
    End Property
    Private _FULL_ADDR As String
    Public Property FULL_ADDR() As String
        Get
            Return _FULL_ADDR
        End Get
        Set(ByVal value As String)
            _FULL_ADDR = value
        End Set
    End Property
    Private _TEL As String
    Public Property TEL() As String
        Get
            Return _TEL
        End Get
        Set(ByVal value As String)
            _TEL = value
        End Set
    End Property
    Private _FAX As String
    Public Property FAX() As String
        Get
            Return _FAX
        End Get
        Set(ByVal value As String)
            _FAX = value
        End Set
    End Property
End Class
