Imports System.Web.Mvc

Namespace Controllers
    Public Class DRController
        Inherits Controller

        ' GET: DR
        Function Index() As ActionResult
            Return View()
        End Function
        Function INPUT_CONDITION() As ActionResult
            Return View()
        End Function
        Function INPUT_DETAIL_USE() As ActionResult
            Return View()
        End Function
        Function INPUT_DRUG_ANIMAL() As ActionResult
            Return View()
        End Function
        Function INPUT_DRUG_KEEP() As ActionResult
            Return View()
        End Function
        Function INPUT_DTB() As ActionResult
            Return View()
        End Function
        Function INPUT_EQTO() As ActionResult
            Return View()
        End Function
        Function INPUT_GENERAL() As ActionResult
            Return View()
        End Function
        Function INPUT_NOUSE() As ActionResult
            Return View()
        End Function
        Function INPUT_PRODUCCER() As ActionResult
            Return View()
        End Function
        Function INPUT_CHEM() As ActionResult
            Return View()
        End Function
        Function INPUT_PRODUCCER_IN() As ActionResult
            Return View()
        End Function
        Function INPUT_PACKAGE_DETAIL2() As ActionResult
            Return View()
        End Function
        Function INPUT_ATC() As ActionResult
            Return View()
        End Function
        Function INPUT_SUB_DRUG_ANIMAL() As ActionResult
            Return View()
        End Function
        Function INPUT_NAME_DRUG_EXPORT() As ActionResult
            Return View()
        End Function

        Function TABEAN_YA_MAIN() As ActionResult
            Return View()
        End Function

        Function FRM_RQT_REGIST_INFORMATION() As ActionResult
            Return View()
        End Function
        Function FRM_MAIN_PAGE_PRODUCT() As ActionResult
            Return View()
        End Function
        Function TABEAN_YA_MAIN_STAFF() As ActionResult
            Return View()
        End Function
        Function FRM_SEARCH_LCN() As ActionResult
            Return View()
        End Function
        Function FRM_REGISTRATION_MAIN() As ActionResult
            Return View()
        End Function
        Function INPUT_YOR_1() As ActionResult
            Return View()
        End Function
        Function FRM_DR_TRANSFER_DL() As ActionResult
            Return View()
        End Function
        Function INPUT_RECLASS() As ActionResult
            Return View()
        End Function
        Function INPUT_RECLASS_ATTACH() As ActionResult
            Return View()
        End Function


        Function FRM_RECLASS_MAIN() As ActionResult
            Return View()
        End Function
        Function FRM_RGT_SELECT() As ActionResult
            Return View()
        End Function

        Function PREVIEW_RECLASS() As ActionResult
            Return View()
        End Function
        Function FRM_DR_CONFIRM() As ActionResult
            Return View()
        End Function
        Function FRM_DR_STAFF_CHECK_RQT() As ActionResult
            Return View()
        End Function

    End Class

    Public Class DR_CENTERController
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

#Region "STORE"
        Function SP_DRUG_REGISTRATION_BY_FK_IDA_PROCESS_ID(ByVal FK_IDA As Integer, ByVal process As Integer)
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_DRUG_REGISTRATION_BY_FK_IDA_PROCESS_ID(FK_IDA, process)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        End Function
#End Region

#Region "FILE_ATTACH"

#End Region

#Region "INSERT_DATA"

#End Region

#Region "UPDATE_DATA"

#End Region



    End Class
End Namespace