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
    End Class
End Namespace