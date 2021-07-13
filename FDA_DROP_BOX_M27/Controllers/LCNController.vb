Imports System.Web.Mvc

Namespace Controllers
    Public Class LCNController
        Inherits Controller

        ' GET: LCN
        Function Index() As ActionResult
            Return View()
        End Function
        Function INPUT_NORYOR_1() As ActionResult
            Return View()
        End Function
        Function INPUT_PORYOR_1() As ActionResult
            Return View()
        End Function
        Function INPUTdalcn_output_1() As ActionResult
            Return View()
        End Function
        Function INPUTdalcn_output_2() As ActionResult
            Return View()
        End Function
        Function INPUTdalcn_output_3() As ActionResult
            Return View()
        End Function
        Function INPUTdalcn_output_4() As ActionResult
            Return View()
        End Function
        Function INPUT_NORDOJ_3_4_1() As ActionResult
            Return View()
        End Function
        Function INPUT_SORDOJ_3_4_1() As ActionResult
            Return View()
        End Function
        Function INPUT_SORDOJ_3_4_1_Tan() As ActionResult
            Return View()
        End Function
        Function INPUT_MODIFY_BOJOD3_4() As ActionResult
            Return View()
        End Function
        Function INPUT_MODIFY_PORDOJ_3_2() As ActionResult
            Return View()
        End Function
        Function INPUT_BOJOD_3_4_1() As ActionResult
            Return View()
        End Function
        Function INPUT_KHO_WO_JO_3_2() As ActionResult
            Return View()
        End Function
        Function INPUT_KHO_WO_JO_4_2() As ActionResult
            Return View()
        End Function
        Function INPUT_KHOTO_WO_JO_3_2() As ActionResult
            Return View()
        End Function
        Function INPUT_KHOTO_WO_JO_4_2() As ActionResult
            Return View()
        End Function
        Function INPUT_KHOPO_WO_JO_3_2() As ActionResult
            Return View()
        End Function
        Function INPUT_KHOPO_WO_JO_4_2() As ActionResult
            Return View()
        End Function
        Function INPUT_PORDOJ_3_4_1() As ActionResult
            Return View()
        End Function
        Function INPUT_PORDOJ_3_4_1_Tan() As ActionResult
            Return View()
        End Function
        Function FRM_STAFF_LCN_SEARCH() As ActionResult
            Return View()
        End Function
        Function FRM_LCN_STAFF_LCN_INFORMATION() As ActionResult
            Return View()
        End Function
        Function FRM_STAFF_LCN_ADD_LOCATION() As ActionResult
            Return View()
        End Function
        Function FRM_STAFF_LCN_ADD_LOCATION_KEEP() As ActionResult
            Return View()
        End Function
        Function FRM_STAFF_LCN_SELECT_LOCATION_NEW() As ActionResult
            Return View()
        End Function
        Function FRM_STAFF_LCN_CHANGE_BSN() As ActionResult
            Return View()
        End Function
        Function FRM_STAFF_LCN_CHANGE_LCNSNM() As ActionResult
            Return View()
        End Function
        Function FRM_STAFF_LCN_PHR_INSERT() As ActionResult
            Return View()
        End Function
        Function FRM_LCN_DRUG_SEARCH() As ActionResult
            Return View()
        End Function
        Function FRM_LCN_NEWS() As ActionResult
            Return View()
        End Function
        Function FRM_LCN_DRUG() As ActionResult
            Return View()
        End Function
        Function FRM_LCN_NCT_SEARCH() As ActionResult
            Return View()
        End Function
        Function FRM_EDIT_LCN_MAIN() As ActionResult
            Return View()
        End Function

    End Class

    Public Class LCN_CENTERController
        Inherits Controller

        Function GET_FULL_MODEL() As JsonResult
            Dim model As New MODEL_LCN
            Return Json(model, JsonRequestBehavior.AllowGet)
        End Function

        Function CODE_CENTER(ByVal MODEL As MODEL_LCN)

            Select Case MODEL.FUNC_CODE
                Case "FUNC-DATA"

            End Select
            Return Json(MODEL, JsonRequestBehavior.AllowGet)
        End Function
        Function GET_FULL_MODEL_EDIT() As JsonResult
            Dim model As New MODEL_EDIT_LCN
            Return Json(model, JsonRequestBehavior.AllowGet)
        End Function
        Function SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(ByVal IDA As String)
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(IDA)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)

        End Function
        Function SP_LOCATION_ADDRESS_by_LOCATION_TYPE_CD_and_LCNSIDV2(ByVal LOCATION_TYPE_CD As Integer, ByVal iden As String)
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_LOCATION_ADDRESS_by_LOCATION_TYPE_CD_and_LCNSIDV2(LOCATION_TYPE_CD, iden)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)

        End Function
    End Class
End Namespace