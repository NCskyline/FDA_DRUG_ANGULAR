Imports System.Web.Mvc

Namespace Controllers
    Public Class DLController
        Inherits Controller

        ' GET: DL
        Function Index() As ActionResult
            Return View()
        End Function
        Function DL_MAIN() As ActionResult
            Return View()
        End Function
        '
        Function INPUT_ANIMAL() As ActionResult
            Return View()
        End Function
        Function INPUT_DL() As ActionResult
            Return View()
        End Function
        Function INPUT_REGIST_DETAIL() As ActionResult
            Return View()
        End Function
        Function INPUT_PACKAGE_DETAIL() As ActionResult
            Return View()
        End Function
        Function INPUT_PACKAGE_DETAIL2() As ActionResult
            Return View()
        End Function
        '
        Function INPUT_CHEM() As ActionResult
            Return View()
        End Function
        Function INPUT_DRUG_USE() As ActionResult
            Return View()
        End Function
        Function INPUT_ATC() As ActionResult
            Return View()
        End Function
        Function INPUT_KEEP() As ActionResult
            Return View()
        End Function
        Function INPUT_PRODUCCER() As ActionResult
            Return View()
        End Function
        Function INPUT_PRODUCCER_IN() As ActionResult
            Return View()
        End Function
    End Class
End Namespace