Public Class MODEL_DH

    Private _session As CLS_SESSION
    Public Property session() As CLS_SESSION
        Get
            Return _session
        End Get
        Set(ByVal value As CLS_SESSION)
            _session = value
        End Set
    End Property
    Private _dh15rqt As New dh15rqt
    Public Property dh15rqt() As dh15rqt
        Get
            Return _dh15rqt
        End Get
        Set(ByVal value As dh15rqt)
            _dh15rqt = value
        End Set
    End Property

    Private _DH15_DETAIL_CASCHEMICAL As New DH15_DETAIL_CASCHEMICAL
    Public Property DH15_DETAIL_CASCHEMICAL() As DH15_DETAIL_CASCHEMICAL
        Get
            Return _DH15_DETAIL_CASCHEMICAL
        End Get
        Set(ByVal value As DH15_DETAIL_CASCHEMICAL)
            _DH15_DETAIL_CASCHEMICAL = value
        End Set
    End Property

    Private _DH15_DETAIL_CER As New DH15_DETAIL_CER
    Public Property DH15_DETAIL_CER() As DH15_DETAIL_CER
        Get
            Return _DH15_DETAIL_CER
        End Get
        Set(ByVal value As DH15_DETAIL_CER)
            _DH15_DETAIL_CER = value
        End Set
    End Property

    Private _DH15_DETAIL_MANUFACTURE As New DH15_DETAIL_MANUFACTURE
    Public Property DH15_DETAIL_MANUFACTURE() As DH15_DETAIL_MANUFACTURE
        Get
            Return _DH15_DETAIL_MANUFACTURE
        End Get
        Set(ByVal value As DH15_DETAIL_MANUFACTURE)
            _DH15_DETAIL_MANUFACTURE = value
        End Set
    End Property
    Private _CER As New CER
    Public Property CER() As CER
        Get
            Return _CER
        End Get
        Set(ByVal value As CER)
            _CER = value
        End Set
    End Property

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
    Public NAME As String
    Public LCN_TYPE As Integer
    Public LCN_NO_DISPLAY As String
    Public FULL_ADDR As String
    Public TEL As String
    Public REF_CER_NO As String
    Public COUNTRY_NAME As String
    Public AGENT_COUNTRY_NAME As String
    Public CHK_TYPE_LCN As String
End Class

Public Class MODEL_CHEMICAL

    Private _CHEMICAL_REQUEST As New CHEMICAL_REQUEST
    Public Property CHEMICAL_REQUEST() As CHEMICAL_REQUEST
        Get
            Return _CHEMICAL_REQUEST
        End Get
        Set(ByVal value As CHEMICAL_REQUEST)
            _CHEMICAL_REQUEST = value
        End Set
    End Property

    Public iowanm_show As String
    Public cas_number_show As String
    Public aori_show As String

    Private _session As CLS_SESSION
    Public Property session() As CLS_SESSION
        Get
            Return _session
        End Get
        Set(ByVal value As CLS_SESSION)
            _session = value
        End Set
    End Property

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

    Private _CER_DETAIL_MANUFACTURE As New CER_DETAIL_MANUFACTURE
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
    Public COUNTRY_GMP_SHOW As String
    Public COUNTRY_NAME As String
    Public COUNTRY_OF_DEPARTMENT_NAME As String
    Public BUYER_COUNTRY_NAME As String
    'Public NAME_ADDRESS As String
    'Public ADDRESS_NUMBER As String
    'Public ADDRESS_CITY As String
    'Public COUNTRY_ID As Integer
    'Public ZIPCODE As String
    'Public GLN As String
    'Public DOCUMENT_DATE As Date
    'Public EXP_DOCUMENT_DATE As Date
    'Public STANDARD_ID As String
    Private _session As CLS_SESSION
    Public Property session() As CLS_SESSION
        Get
            Return _session
        End Get
        Set(ByVal value As CLS_SESSION)
            _session = value
        End Set
    End Property

End Class