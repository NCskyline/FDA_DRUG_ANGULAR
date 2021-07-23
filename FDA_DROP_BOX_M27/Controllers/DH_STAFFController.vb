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
    End Class
End Namespace