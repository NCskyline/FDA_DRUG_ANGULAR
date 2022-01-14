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

Public Class MODEL_DS_DATA
    Private _LCNNO As String
    Public Property LCNNO() As String
        Get
            Return _LCNNO
        End Get
        Set(ByVal value As String)
            _LCNNO = value
        End Set
    End Property
    Private _DRUG_NAME_THAI As String
    Public Property DRUG_NAME_THAI() As String
        Get
            Return _DRUG_NAME_THAI
        End Get
        Set(ByVal value As String)
            _DRUG_NAME_THAI = value
        End Set
    End Property
    Private _DRUG_NAME_OTHER As String
    Public Property DRUG_NAME_OTHER() As String
        Get
            Return _DRUG_NAME_OTHER
        End Get
        Set(ByVal value As String)
            _DRUG_NAME_OTHER = value
        End Set
    End Property
    Private _DRUG_GROUP As String
    Public Property DRUG_GROUP() As String
        Get
            Return _DRUG_GROUP
        End Get
        Set(ByVal value As String)
            _DRUG_GROUP = value
        End Set
    End Property
    Private _DRUG_TYPE As String
    Public Property DRUG_TYPE() As String
        Get
            Return _DRUG_TYPE
        End Get
        Set(ByVal value As String)
            _DRUG_TYPE = value
        End Set
    End Property
    Private _COMPANYNAME As String
    Public Property COMPANYNAME() As String
        Get
            Return _COMPANYNAME
        End Get
        Set(ByVal value As String)
            _COMPANYNAME = value
        End Set
    End Property
    Private _RCVNO_DISPLAY As String
    Public Property RCVNO_DISPLAY() As String
        Get
            Return _RCVNO_DISPLAY
        End Get
        Set(ByVal value As String)
            _RCVNO_DISPLAY = value
        End Set
    End Property
End Class
