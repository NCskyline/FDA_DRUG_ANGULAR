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
    End Class
End Namespace