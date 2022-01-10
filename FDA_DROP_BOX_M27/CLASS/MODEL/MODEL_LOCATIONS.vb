Public Class MODEL_LOCATIONS
    Private _DALCN_LOCATION_ADDRESS As New DALCN_LOCATION_ADDRESS
    Public Property DALCN_LOCATION_ADDRESS() As DALCN_LOCATION_ADDRESS
        Get
            Return _DALCN_LOCATION_ADDRESS
        End Get
        Set(value As DALCN_LOCATION_ADDRESS)
            _DALCN_LOCATION_ADDRESS = value
        End Set
    End Property

    Public lcnsid As String
    Public thaaddr As String
    Public engaddr As String
    Public tharoom As String
    Public thamu As String
    Public thafloor As String
    Public thasoi As String
    Public thabuilding As String
    Public engsoi As String
    Public tharoad As String
    Public engroad As String
    Public zipcode As String
    Public tel As String
    Public Mobile As String
    Public fax As String
    Public lstfcd As String
    Public lmdfdate As String
    Public DOWN_ID As String
    Public CITIZEN_ID As String
    Public CITIZEN_ID_UPLOAD As String
    Public XMLNAME As String
    Public engmu As String
    Public engfloor As String
    Public engbuilding As String
    Public rcvno As String
    Public rcvdate As String
    Public lctcd As String
    Public thanameplace As String
    Public engnameplace As String
    Public STATUS_ID As String
    Public HOUSENO As String
    Public Branch As String
    Public LOCATION_TYPE_NORMAL As String
    Public LOCATION_TYPE_KEEP As String
    Public LOCATION_TYPE_OTHER As String
    Public LOCATION_TYPE_ID As String
    Public SYSTEM_NAME As String
    Public thmblcd As String
    Public amphrcd As String
    Public chngwtcd As String
    Public thathmblnm As String
    Public thaamphrnm As String
    Public thachngwtnm As String
    Public engthmblnm As String
    Public engamphrnm As String
    Public engchngwtnm As String
    Public IDENTIFY As String
    Public REMARK As String
    Public longitude As String
    Public latitude As String
    Public Status As String
    Public TYPE As String
    Public Country As String
    Public groupdavision As String
    Public LOCATION_KIND As String
    Public bumbud As String
    Public beds_amount As String
    Public CITIZEN_RECORDER As String
    Public CREATE_DATE As String
    Public system_id As String
    Public pvncd As String
End Class
