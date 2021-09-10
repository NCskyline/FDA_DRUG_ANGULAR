Public Class MODEL_STAFF_EDIT_LCN
    Private _dalcn As New dalcn
    Public Property dalcn() As dalcn
        Get
            Return _dalcn
        End Get
        Set(ByVal value As dalcn)
            _dalcn = value
        End Set
    End Property

    Private _DALCN_PHR As New DALCN_PHR
    Public Property DALCN_PHR() As DALCN_PHR
        Get
            Return _DALCN_PHR
        End Get
        Set(ByVal value As DALCN_PHR)
            _DALCN_PHR = value
        End Set
    End Property

    Private _DALCN_LOCATION_BSN As New DALCN_LOCATION_BSN
    Public Property DALCN_LOCATION_BSN() As DALCN_LOCATION_BSN
        Get
            Return _DALCN_LOCATION_BSN
        End Get
        Set(ByVal value As DALCN_LOCATION_BSN)
            _DALCN_LOCATION_BSN = value
        End Set
    End Property
    Private _DALCN_DETAIL_LOCATION_KEEP As New DALCN_DETAIL_LOCATION_KEEP
    Public Property DALCN_DETAIL_LOCATION_KEEP() As DALCN_DETAIL_LOCATION_KEEP
        Get
            Return _DALCN_DETAIL_LOCATION_KEEP
        End Get
        Set(ByVal value As DALCN_DETAIL_LOCATION_KEEP)
            _DALCN_DETAIL_LOCATION_KEEP = value
        End Set
    End Property

    Private _DALCN_LOCATION_ADDRESS As New DALCN_LOCATION_ADDRESS
    Public Property DALCN_LOCATION_ADDRESS() As DALCN_LOCATION_ADDRESS
        Get
            Return _DALCN_LOCATION_ADDRESS
        End Get
        Set(ByVal value As DALCN_LOCATION_ADDRESS)
            _DALCN_LOCATION_ADDRESS = value
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

    Public fulladdr_no_keep As String
    Public thanameplace As String
    Public fulladdr4 As String
    Public thanm As String
    Public BSN_THAIFULLNAME As String
    Public BSN_IDENTIFY As String
    Public LCNNO_SHOW As String
    Public AGE As String
    Public BSN_FULL_ADDR As String
    Public BSN_TELEPHONE As String
    Public BSN_FAX As String
    Public fulladdr3 As String
    Public Mobile As String
    Public RCVNO_DISPLAY As String
    Public RCV_DATE_DISPLAY As String
    Public fulladdr As String

    Public thabuilding As String
    Public thafloor As String
    Public tharoom As String
    Public engnameplace As String
    Public HOUSENO As String
    Public thaaddr As String
    Public thamu As String
    Public thasoi As String
    Public tharoad As String
    Public zipcode As String
    Public tel As String
    Public fax As String
    Public chngwtcd As String
    Public amphrcd As String
    Public thmblcd As String
    Public latitude As String
    Public longitude As String
    Public TYPE_IMPORT As String
    Public LCNNAME As String
    Public FULL_ADDR As String
    Public CITIZEN_ID_AUTHORIZE As String
    Public opentime As String
    Public cncnm As String
    Public date_cancel As String
    Public first_appdate As String

    Public KEEP_SELECT As String
    Public OLD_BSN_THAIFULLNAME As String
    Public OLD_BSN_fulladdr As String

    Public NEW_BSN_THAIFULLNAME As String
    Public NEW_BSN_fulladdr As String

    Public OLD_LCNNM As String
    Public NEW_LCNNM As String

    Public PHR_NAME As String
End Class

Public Class MODEL_DALCN
    Private _dalcn As New dalcn
    Public Property dalcn() As dalcn
        Get
            Return _dalcn
        End Get
        Set(ByVal value As dalcn)
            _dalcn = value
        End Set
    End Property
End Class
