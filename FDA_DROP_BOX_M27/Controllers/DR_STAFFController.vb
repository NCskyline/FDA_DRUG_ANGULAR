Imports System.Web.Mvc

Namespace Controllers
    Public Class DR_STAFFController
        Inherits Controller

        ' GET: DR_STAFF
        Function Index() As ActionResult
            Return View()
        End Function

        Function TABEAN_YA_MAIN_STAFF() As ActionResult
            Return View()
        End Function
        Function FRM_RGT_EDIT_MAIN_STAFF() As ActionResult
            Return View()
        End Function
        Function FRM_TABEAN_SEARCH() As ActionResult
            Return View()
        End Function
        Function FRM_DS_STAFF_DRUG() As ActionResult
            Return View()
        End Function
        Function FRM_FRGN_ADD_MAIN() As ActionResult
            Return View()
        End Function
        Function FRM_STAFF_MAIN_NYM() As ActionResult
            Return View()
        End Function
        Function FRM_SUBSTITUTE_TABEAN_STAFF_MAIN() As ActionResult
            Return View()
        End Function
        Function FRM_DR_STAFF_CONFIRM() As ActionResult
            Return View()
        End Function
        Function FRM_EXTEND_TIME_LOCATION_STAFF_MAIN() As ActionResult
            Return View()
        End Function
        Function TABEAN_YA_STAFF_APPROVE() As ActionResult
            Return View()
        End Function

        Function PREVIEW_RECLASS_STAFF() As ActionResult
            Return View()
        End Function

        Function FRM_STAFF_DR_RECLASS_MAIN() As ActionResult
            Return View()
        End Function
        Function PREVIEW_RGT_EDIT() As ActionResult
            Return View()
        End Function
        Function FRM_EDIT_REQUEST_STAFF_CONFIRM() As ActionResult
            Return View()
        End Function
        Function FRM_DS_STAFF_CONFRIM() As ActionResult
            Return View()
        End Function
        Function FRM_SUBSTITUTE_TABEAN_STAFF_CONFIRM() As ActionResult
            Return View()
        End Function
        Function FRM_NYM_STAFF_CONFIRM() As ActionResult
            Return View()
        End Function
        Function POPUP_DR_STAFF() As ActionResult
            Return View()
        End Function
        Function POPUP_ADD_DR_STAFF() As ActionResult
            Return View()
        End Function
    End Class
    Public Class DR_STAFF_CENTERController
        Inherits Controller
        Function SP_DR_RECLASS_STAFF()
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_DR_RECLASS_STAFF()
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        End Function
        '
        Function SP_GET_READ_DATA_RECLASS_STAFF_BY_IDA(ByVal IDA As Integer)
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_GET_READ_DATA_RECLASS_STAFF_BY_IDA(IDA)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        End Function
    End Class
End Namespace