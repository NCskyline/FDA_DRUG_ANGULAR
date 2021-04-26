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
        Function INPUT_DL() As ActionResult
            Return View()
        End Function
        Function INPUT_REGIST_DETAIL() As ActionResult
            Return View()
        End Function
    End Class
End Namespace