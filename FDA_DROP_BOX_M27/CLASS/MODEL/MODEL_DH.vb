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

Public Class MODEL_CER_GMP_DEMO

    'Public DEPARTMENT_REGIST_CER_TYPE As String
    'Public DEPARTMENT_REGIST_CER_NAME As String
    'Public CER_DETAIL_MANUFACTURE As CER_DETAIL_MANUFACTURE
    'Public CERTIFICATION_NUMBER_ALL As String
    'Public MANUFACTURER_LICENCE_NUMBER As String
    'Private _CER_DETAIL_CASCHEMICAL As New List(Of CER_DETAIL_CASCHEMICAL)
    'Public Property CER_DETAIL_CASCHEMICAL() As List(Of CER_DETAIL_CASCHEMICAL)
    '    Get
    '        Return _CER_DETAIL_CASCHEMICAL
    '    End Get
    '    Set(ByVal value As List(Of CER_DETAIL_CASCHEMICAL))
    '        _CER_DETAIL_CASCHEMICAL = value
    '    End Set
    'End Property
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

End Class