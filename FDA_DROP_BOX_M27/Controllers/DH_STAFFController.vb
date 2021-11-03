Imports System.Web.Mvc

Namespace Controllers
    Public Class DH_STAFFController
        Inherits Controller

        ' GET: DH_STAFF
        Function Index() As ActionResult
            Return View()
        End Function
        Function FRM_STAFF_CER_MAIN() As ActionResult
            Return View()
        End Function
        Function FRM_DH_MAIN_STAFF() As ActionResult
            Return View()
        End Function
        Function FRM_CHEMICAL_STAFF_MAIN() As ActionResult
            Return View()
        End Function
        Function FRM_CHEMICAL_STAFF_COMFIRM_TEXT() As ActionResult
            Return View()
        End Function

        Function FRM_TABEAN_YA_CHANGE_STATUS() As ActionResult
            Return View()
        End Function
        Function FRM_PREVIEW_CERT_STAFF() As ActionResult
            Return View()
        End Function
        Function FRM_PREVIEW_DH_STAFF() As ActionResult
            Return View()
        End Function
        Function FRM_STAFF_CER_REMARK() As ActionResult
            Return View()
        End Function

        Function FRM_DH_STAFF_REMARK() As ActionResult
            Return View()
        End Function

        Function FRM_EDIT_REQUEST() As ActionResult
            Return View()
        End Function

        Function FRM_DH_SEARCH() As ActionResult
            Return View()
        End Function

        Function FRM_CHEMICAL_STAFF_SEARCH() As ActionResult
            Return View()
        End Function
        Function FRM_CER_STAFF_SEARCH() As ActionResult
            Return View()
        End Function
    End Class
End Namespace