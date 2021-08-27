Public Class MODEL_LCN

    Private _session As CLS_SESSION
    Public Property session() As CLS_SESSION
        Get
            Return _session
        End Get
        Set(ByVal value As CLS_SESSION)
            _session = value
        End Set
    End Property
    Private _LCN_IDA As String

    Private _dalcn As New dalcn
    Public Property dalcn() As dalcn
        Get
            Return _dalcn
        End Get
        Set(ByVal value As dalcn)
            _dalcn = value
        End Set
    End Property

    Private _DALCN_PHR As DALCN_PHR
    Public Property DALCN_PHR() As DALCN_PHR
        Get
            Return _DALCN_PHR
        End Get
        Set(ByVal value As DALCN_PHR)
            _DALCN_PHR = value
        End Set
    End Property

    Private _DALCN_LOCATION_BSN As DALCN_LOCATION_BSN
    Public Property DALCN_LOCATION_BSN() As DALCN_LOCATION_BSN
        Get
            Return _DALCN_LOCATION_BSN
        End Get
        Set(ByVal value As DALCN_LOCATION_BSN)
            _DALCN_LOCATION_BSN = value
        End Set
    End Property
    Private _DALCN_DETAIL_LOCATION_KEEP As DALCN_DETAIL_LOCATION_KEEP
    Public Property DALCN_DETAIL_LOCATION_KEEP() As DALCN_DETAIL_LOCATION_KEEP
        Get
            Return _DALCN_DETAIL_LOCATION_KEEP
        End Get
        Set(ByVal value As DALCN_DETAIL_LOCATION_KEEP)
            _DALCN_DETAIL_LOCATION_KEEP = value
        End Set
    End Property
    Private _DALCN_NCT_SUBSTITUTE As DALCN_NCT_SUBSTITUTE
    Public Property DALCN_NCT_SUBSTITUTE() As DALCN_NCT_SUBSTITUTE
        Get
            Return _DALCN_NCT_SUBSTITUTE
        End Get
        Set(ByVal value As DALCN_NCT_SUBSTITUTE)
            _DALCN_NCT_SUBSTITUTE = value
        End Set
    End Property
    Private _DALCN_EDIT_REQUEST As New DALCN_EDIT_REQUEST
    Public Property DALCN_EDIT_REQUEST() As DALCN_EDIT_REQUEST
        Get
            Return _DALCN_EDIT_REQUEST
        End Get
        Set(ByVal value As DALCN_EDIT_REQUEST)
            _DALCN_EDIT_REQUEST = value
        End Set
    End Property

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
    Private _BSN_ADDR As String
    Public Property BSN_ADDR() As String
        Get
            Return _BSN_ADDR
        End Get
        Set(ByVal value As String)
            _BSN_ADDR = value
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
    Private _BSN_THANAMEPLACE As String
    Public Property BSN_THANAMEPLACE() As String
        Get
            Return _BSN_THANAMEPLACE
        End Get
        Set(ByVal value As String)
            _BSN_THANAMEPLACE = value
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

    Private _FUNC_CODE As String
    Public Property FUNC_CODE() As String
        Get
            Return _FUNC_CODE
        End Get
        Set(ByVal value As String)
            _FUNC_CODE = value
        End Set
    End Property

    Private _PROCESS As String
    Public Property PROCESS() As String
        Get
            Return _PROCESS
        End Get
        Set(ByVal value As String)
            _PROCESS = value
        End Set
    End Property

    Public thanm As String
    Public BSN_THAIFULLNAME As String
    Public BSN_IDENTIFY As String
    Public IDENTIFY As String
    Public HOUSENO As String
    Public AGE As String
    Public BSN_FULL_ADDR As String
    Public BSN_TELEPHONE As String
    Public BSN_FAX As String
    Public fulladdr3 As String
    Public Mobile As String
    Public RCVNO_DISPLAY As String
    Public RCV_DATE_DISPLAY As String
    Public LOCATION_SELECT As String
    Public HEAD_LCNNO_NCT As String

    Public KEEP_THANAMEPLACE As String
    Public KEEP_FULL_ADDR As String
    Public KEEP_TEL As String


    Public PHR_NAME As String
    Public PHR_TEXT_NUM As String

    Public EXP_NEWYEAR As String
End Class


