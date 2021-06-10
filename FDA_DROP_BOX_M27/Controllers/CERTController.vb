Imports System.Web.Mvc

Namespace Controllers
    Public Class CERTController
        Inherits Controller

        ' GET: CERT
        Function Index() As ActionResult
            Return View()
        End Function
        Function FRM_CERT_MAIN() As ActionResult
            Return View()
        End Function
        Function INPUT_GMP() As ActionResult
            Return View()
        End Function
        '
        Function INPUT_HACCP() As ActionResult
            Return View()
        End Function
        Function HEADER_CERT() As ActionResult
            Return View()
        End Function
        Function INPUT_ISO() As ActionResult
            Return View()
        End Function
        Function INPUT_CERT_OTHER() As ActionResult
            Return View()
        End Function
        Function PREVIEW_CERT() As ActionResult
            Return View()
        End Function
    End Class
End Namespace