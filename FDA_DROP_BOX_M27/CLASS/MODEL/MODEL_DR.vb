Public Class MODEL_DR
    Private _DR_RECLASS As New DR_RECLASS
    Public Property DR_RECLASS() As DR_RECLASS
        Get
            Return _DR_RECLASS
        End Get
        Set(ByVal value As DR_RECLASS)
            _DR_RECLASS = value
        End Set
    End Property


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
    Private _amltpnm As String
    Public Property amltpnm() As String
        Get
            Return _amltpnm
        End Get
        Set(ByVal value As String)
            _amltpnm = value
        End Set
    End Property
    Private _amltpcd As String
    Public Property amltpcd() As String
        Get
            Return _amltpcd
        End Get
        Set(ByVal value As String)
            _amltpcd = value
        End Set
    End Property

    Private _amlsubnm As String
    Public Property amlsubnm() As String
        Get
            Return _amlsubnm
        End Get
        Set(ByVal value As String)
            _amlsubnm = value
        End Set
    End Property
    Private _amlsubcd As String
    Public Property amlsubcd() As String
        Get
            Return _amlsubcd
        End Get
        Set(ByVal value As String)
            _amlsubcd = value
        End Set
    End Property
    Private _usetpnm As String
    Public Property usetpnm() As String
        Get
            Return _usetpnm
        End Get
        Set(ByVal value As String)
            _usetpnm = value
        End Set
    End Property
    Private _usetpcd As String
    Public Property usetpcd() As String
        Get
            Return _usetpcd
        End Get
        Set(ByVal value As String)
            _usetpcd = value
        End Set
    End Property
End Class
