Imports System.Web.Mvc

Namespace Controllers
    Public Class LCN_STAFFController
        Inherits Controller

        ' GET: LCN_STAFF
        Function Index() As ActionResult
            Return View()
        End Function
        Function FRM_EDIT_LCN_STAFF_MAIN() As ActionResult
            Return View()
        End Function
        Function FRM_LCN_DRUG_STAFF() As ActionResult
            Return View()
        End Function
        Function FRM_SUBSTITUTE_NCT_MAIN_STAFF() As ActionResult
            Return View()
        End Function
        Function FRM_SUBSTITUTE_NCT_CONSIDER() As ActionResult
            Return View()
        End Function
        Function FRM_EDIT_LCN_REMARK() As ActionResult
            Return View()
        End Function
        Function FRM_EDIT_LCN_CONSIDER() As ActionResult
            Return View()
        End Function
        Function FRM_STAFF_LCN_CONSIDER() As ActionResult
            Return View()
        End Function
        Function FRM_STAFF_LCN_PAY_NOTE() As ActionResult
            Return View()
        End Function
        Function FRM_STAFF_LCN_RCV_MANUAL() As ActionResult
            Return View()
        End Function
        Function FRM_STAFF_LCN_REMARK() As ActionResult
            Return View()
        End Function
        Function FRM_STAFF_OFFER_INSERT_AND_UPDATE() As ActionResult
            Return View()
        End Function

        Function PREVIEW_LCN_STAFF() As ActionResult
            Return View()
        End Function
        Function FRM_EDIT_REQUEST() As ActionResult
            Return View()
        End Function

        Function PREVIEW_LCN_EXTEND_STAFF() As ActionResult
            Return View()
        End Function
        Function PREVIEW_LCN_STT_STAFF() As ActionResult
            Return View()
        End Function

        Function PREVIEW_LCN_EDIT_STAFF() As ActionResult
            Return View()
        End Function
        Function FRM_EXTEND_TIME_LOCATION_STAFF_MAIN() As ActionResult
            Return View()
        End Function
        Function FRM_EXTEND_STAFF_CONFIRM() As ActionResult
            Return View()
        End Function
        Function FRM_SUBSTITUTE_NCT_STAFF_CONFIRM() As ActionResult
            Return View()
        End Function

    End Class

    Public Class LCN_STAFFCENTERController
        Inherits Controller

        Public _APP As String = System.Configuration.ConfigurationManager.AppSettings("APP")
        Public _SYSTEM_ID As String = System.Configuration.ConfigurationManager.AppSettings("SYSTEM_ID")
        Public _PATH_BOX As String = System.Configuration.ConfigurationManager.AppSettings("PATH_BOX")
        Public _PATH_BOX_TEMPLATE As String = System.Configuration.ConfigurationManager.AppSettings("PATH_BOX_TEMPLATE")
        Public _PATH_PDF_TEMPLATE As String = System.Configuration.ConfigurationManager.AppSettings("PATH_PDF_TEMPLATE")    'ที่อยู่ Path
        Public _PATH_XML_CLASS As String = System.Configuration.ConfigurationManager.AppSettings("PATH_XML_CLASS")          'ที่อยู่ Path
        Public _PATH_PDF_XML_CLASS As String = System.Configuration.ConfigurationManager.AppSettings("PATH_PDF_XML_CLASS")  'ที่อยู่ Path
        Public _PATH_PDF_TRADER As String = System.Configuration.ConfigurationManager.AppSettings("PATH_PDF_TRADER")        'ที่อยู่ Path
        Public _PATH_XML_TRADER As String = System.Configuration.ConfigurationManager.AppSettings("PATH_XML_TRADER")        'ที่อยู่ Path
        Public _PATH_DEFAULT As String = System.Configuration.ConfigurationManager.AppSettings("PATH_DEFALUT")              'ที่อยู่ Path
        Public _PATH_EDIT As String = System.Configuration.ConfigurationManager.AppSettings("PATH_EDIT")              'ที่อยู่ Path
        Public _PATH_SUBS As String = System.Configuration.ConfigurationManager.AppSettings("PATH_EDIT")
        Public _RDLC As String = System.Configuration.ConfigurationManager.AppSettings("RDLC")
        Public _PATH_XML_IMPORT As String = System.Configuration.ConfigurationManager.AppSettings("PATH_XML_IMPORT")        'มินทำต้องทำต่อ 5555555555555555555
        Public _PATH_PDF_IMPORT As String = System.Configuration.ConfigurationManager.AppSettings("PATH_PDF_IMPORT")
        Dim msg_r As New MODEL_RESULT

        Function SP_STATUS_SELECT_LCN_STAFF(ByVal IDA As String, ByVal STAT_GROUP As String)
            Dim dt As New DataTable
            Dim bao As New BAO
            Dim int_group_ddl As Integer = 0
            Dim dao As New DAO_DRUG.ClsDBdalcn
            dao.GetDataby_IDA(IDA)

            If dao.fields.STATUS_ID <= 2 Then
                int_group_ddl = 1
            ElseIf dao.fields.STATUS_ID = 11 Then
                int_group_ddl = 2
            ElseIf dao.fields.STATUS_ID > 2 And dao.fields.STATUS_ID < 6 Then
                int_group_ddl = 3
            ElseIf dao.fields.STATUS_ID >= 6 And dao.fields.STATUS_ID < 11 Then
                int_group_ddl = 4
            End If

            dt = bao.SP_MAS_STATUS_STAFF_BY_GROUP_DDL(2, int_group_ddl)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)

        End Function
    End Class

End Namespace