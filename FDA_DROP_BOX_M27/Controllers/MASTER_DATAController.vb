Imports System.Web.Mvc

Namespace Controllers
    Public Class MASTER_DATAController
        Inherits Controller

        ' GET: MASTER_DATA
        Function Index() As ActionResult
            Return View()
        End Function
        Function FRM_STAFF_OFFER() As ActionResult
            Return View()
        End Function
        Function FRM_STAFF_OFFER_INSERT_AND_UPDATE() As ActionResult
            Return View()
        End Function

        Function FRM_PROFESSIONAL_MAIN() As ActionResult
            Return View()
        End Function
        Function FRM_PROFESSIONAL_INSERT_AND_UPDATE() As ActionResult
            Return View()
        End Function
        Function FRM_PROFESSIONAL_IMPORT() As ActionResult
            Return View()
        End Function

        Function FRM_STAFF_LOCATION_MANUAL_MAIN() As ActionResult
            Return View()
        End Function

        Function FRM_STAFF_LOCATION_MANUAL_INSERT() As ActionResult
            Return View()
        End Function
        Function INPUT_ASSIGN_WORK_TO_STAFF() As ActionResult
            Return View()
        End Function
        Function FRM_ASSIGN_WORK_MAIN() As ActionResult
            Return View()
        End Function
    End Class
End Namespace