Imports System.Web.Mvc

Namespace Controllers
    Public Class OtherController
        Inherits Controller

        ' GET: Other
        Function Index() As ActionResult
            Return View()
        End Function
        Function INPUT_DRUG_Project_Summary() As ActionResult
            Return View()
        End Function
        Function INPUT_Reseach_Project_Summary() As ActionResult
            Return View()
        End Function
    End Class
End Namespace