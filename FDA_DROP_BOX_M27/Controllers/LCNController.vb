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
        Function INPUT_BOJOD_3_4_2() As ActionResult
            Return View()
        End Function
        Function INPUT_BOJOD_3_4_3() As ActionResult
            Return View()
        End Function
        Function INPUT_BOJOD_3_4_1_Tan() As ActionResult
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
        Function INPUT_DA_YORBOR() As ActionResult
            Return View()
        End Function

        Function INPUT_NORDOJ_3_4_1_Tan() As ActionResult
            Return View()
        End Function
        Function INPUT_KORYOR15() As ActionResult
            Return View()
        End Function
        Function INPUT_KORYOR16() As ActionResult
            Return View()
        End Function
        Function INPUT_KORYOR17() As ActionResult
            Return View()
        End Function


        Function INPUT_NORYOR10() As ActionResult
            Return View()
        End Function
        Function INPUT_NORYOR11() As ActionResult
            Return View()
        End Function
        Function INPUT_PORYOR10() As ActionResult
            Return View()
        End Function
        Function INPUT_PORYOR11() As ActionResult
            Return View()
        End Function
        Function INPUT_PORYOR12() As ActionResult
            Return View()
        End Function
        Function INPUT_YORBOR16() As ActionResult
            Return View()
        End Function
        Function PREVIEW_EDIT_LCN() As ActionResult
            Return View()
        End Function

        Function INPUT_YORSOR3_ALL_EDIT() As ActionResult
            Return View()
        End Function
        '
        Function INPUT_YORBOR_14() As ActionResult
            Return View()
        End Function
        Function INPUT_YORSOR3_20_TAN() As ActionResult
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
                Case "FUNC-DATA-REQUEST"
                    ''SP_CUSTOMER_LCN_BY_FK_IDA()
            End Select
            Return Json(MODEL, JsonRequestBehavior.AllowGet)
        End Function

#Region "STORE"
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

        Function SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(ByVal LOCATION_ADDRESS_IDA As Integer)
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(LOCATION_ADDRESS_IDA)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)

        End Function

        Function SP_LOCATION_ADDRESS_by_LOCATION_TYPE_CD_and_LCNSIDV2_KEEP(ByVal LOCATION_TYPE_CD As String, ByVal IDENTIFY As String)
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_LOCATION_ADDRESS_by_LOCATION_TYPE_CD_and_LCNSIDV2(LOCATION_TYPE_CD, IDENTIFY)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)

        End Function

        Function SP_CUSTOMER_LCN_BY_FK_IDA(ByVal LCT_IDA As Integer, ByVal Process As String, ByVal iden As String)
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_CUSTOMER_LCN_BY_FK_IDA(LCT_IDA, Process, iden)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        End Function
#End Region

#Region "GET DATA"

        Function GET_LCN_SUBTITUTE_INPUT(ByVal BSN_IDENTIFY As String, ByVal LCN_IDA As Integer) As JsonResult
            Dim model As New MODEL_LCN
            Dim bao As New BAO
            Dim dt_bsn As New DataTable
            dt_bsn = bao.SP_LOCATION_BSN_BY_IDENTIFY(BSN_IDENTIFY)
            For Each dr As DataRow In dt_bsn.Rows
                Try
                    model.BSN_THAIFULLNAME = dr("BSN_THAIFULLNAME")
                Catch ex As Exception

                End Try
                Try
                    model.BSN_IDENTIFY = dr("BSN_IDENTIFY")
                Catch ex As Exception

                End Try
                Try
                    model.AGE = dr("AGE")
                Catch ex As Exception

                End Try
                Try
                    model.BSN_FULL_ADDR = dr("BSN_FULL_ADDR")
                Catch ex As Exception

                End Try
                Try
                    model.BSN_TELEPHONE = dr("BSN_TELEPHONE")
                Catch ex As Exception

                End Try
                Try
                    model.BSN_FAX = dr("BSN_FAX")
                Catch ex As Exception

                End Try
            Next
            Dim dt_addr As New DataTable
            dt_addr = bao.SP_MASTER_DALCN_DETAIL_LOCATION_KEEP_BY_IDA(LCN_IDA)
            For Each dr As DataRow In dt_addr.Rows
                Try
                    model.KEEP_THANAMEPLACE = dr("thanameplace")
                Catch ex As Exception

                End Try
                Try
                    model.KEEP_FULL_ADDR = dr("fulladdr2")
                Catch ex As Exception

                End Try
                Try
                    model.TEL = dr("tel")
                Catch ex As Exception

                End Try
                Try
                    model.Mobile = dr("fax")
                Catch ex As Exception

                End Try
                Try
                    model.HOUSENO = dr("HOUSENO")
                Catch ex As Exception

                End Try
            Next

            Dim dt_phr As New DataTable
            dt_phr = bao.SP_PHR_NOT_ROW_1_BY_FK_IDA(LCN_IDA)
            For Each dr As DataRow In dt_phr.Rows
                Try
                    model.PHR_NAME = dr("PHR_NAME")
                Catch ex As Exception

                End Try
                Try
                    model.PHR_TEXT_NUM = dr("PHR_TEXT_NUM")
                Catch ex As Exception

                End Try

            Next
            Return Json(model, JsonRequestBehavior.AllowGet)
        End Function

        Function GET_LCN_INFORMATION_INPUT(ByVal BSN_IDENTIFY As String, ByVal IDENTIFY As String, ByVal LCT_IDA As String, ByVal HEAD_LCN_IDA As String) As JsonResult
            Dim model As New MODEL_LCN
            Dim bao As New BAO
            Dim dt_tha As New DataTable
            dt_tha = bao.SP_SYSLCNSNM_BY_LCNSID_AND_IDENTIFY(IDENTIFY, "")
            For Each dr As DataRow In dt_tha.Rows
                Try
                    model.thanm = dr("thanm")
                Catch ex As Exception

                End Try

            Next
            model.IDENTIFY = IDENTIFY
            Dim lcnno_auto As String = ""
            Dim lcnno_format As String = ""
            Try
                Dim dao_main As New DAO_DRUG.ClsDBdalcn
                dao_main.GetDataby_IDA(HEAD_LCN_IDA)
                Try
                    lcnno_auto = dao_main.fields.lcnno
                Catch ex As Exception

                End Try
                Try
                    If Len(lcnno_auto) > 0 Then

                        If Right(Left(lcnno_auto, 3), 1) = "5" Then
                            lcnno_format = "จ. " & CStr(CInt(Right(lcnno_auto, 4))) & "/25" & Left(lcnno_auto, 2)
                        Else
                            lcnno_format = dao_main.fields.pvnabbr & " " & CStr(CInt(Right(lcnno_auto, 5))) & "/25" & Left(lcnno_auto, 2)
                        End If
                        'lcnno_format = dao.fields.pvnabbr & " " & CStr(CInt(Right(lcnno_auto, 5))) & "/25" & Left(lcnno_auto, 2)
                    End If
                Catch ex As Exception

                End Try

                model.HEAD_LCNNO_NCT = lcnno_format
            Catch ex As Exception

            End Try
            Dim dt_bsn As New DataTable
            dt_bsn = bao.SP_LOCATION_BSN_BY_IDENTIFY(BSN_IDENTIFY)
            For Each dr As DataRow In dt_bsn.Rows
                Try
                    model.BSN_THAIFULLNAME = dr("BSN_THAIFULLNAME")
                Catch ex As Exception

                End Try
                Try
                    model.BSN_IDENTIFY = dr("BSN_IDENTIFY")
                Catch ex As Exception

                End Try
                Try
                    model.AGE = dr("AGE")
                Catch ex As Exception

                End Try
                Try
                    model.BSN_FULL_ADDR = dr("BSN_FULL_ADDR")
                Catch ex As Exception

                End Try
                Try
                    model.BSN_TELEPHONE = dr("BSN_TELEPHONE")
                Catch ex As Exception

                End Try
                Try
                    model.BSN_FAX = dr("BSN_FAX")
                Catch ex As Exception

                End Try
            Next
            Dim dt_addr As New DataTable
            dt_addr = bao.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(LCT_IDA)
            For Each dr As DataRow In dt_addr.Rows
                Try
                    model.THANAMEPLACE = dr("thanameplace")
                Catch ex As Exception

                End Try
                Try
                    model.fulladdr3 = dr("fulladdr3")
                Catch ex As Exception

                End Try
                Try
                    model.TEL = dr("tel")
                Catch ex As Exception

                End Try
                Try
                    model.Mobile = dr("fax")
                Catch ex As Exception

                End Try
                Try
                    model.HOUSENO = dr("HOUSENO")
                Catch ex As Exception

                End Try
            Next
            Dim dao_phr As New DAO_DRUG.ClsDBDALCN_PHR
            dao_phr.GetDataby_FK_IDA(HEAD_LCN_IDA)

            Try
                model.DALCN_PHR = dao_phr.fields
            Catch ex As Exception

            End Try

            Return Json(model, JsonRequestBehavior.AllowGet)
        End Function

        Function GET_LCN_INFORMATION_BSN_INPUT(ByVal BSN_IDENTIFY As String) As JsonResult
            Dim model As New MODEL_LCN
            Dim bao As New BAO
            Dim dt_bsn As New DataTable
            dt_bsn = bao.SP_LOCATION_BSN_BY_IDENTIFY(BSN_IDENTIFY)
            For Each dr As DataRow In dt_bsn.Rows
                Try
                    model.BSN_THAIFULLNAME = dr("BSN_THAIFULLNAME")
                Catch ex As Exception

                End Try
                Try
                    model.BSN_IDENTIFY = dr("BSN_IDENTIFY")
                Catch ex As Exception

                End Try
                Try
                    model.AGE = dr("AGE")
                Catch ex As Exception

                End Try
                Try
                    model.BSN_FULL_ADDR = dr("BSN_FULL_ADDR")
                Catch ex As Exception

                End Try
                Try
                    model.BSN_TELEPHONE = dr("BSN_TELEPHONE")
                Catch ex As Exception

                End Try
                Try
                    model.BSN_FAX = dr("BSN_FAX")
                Catch ex As Exception

                End Try
            Next
            Return Json(model, JsonRequestBehavior.AllowGet)
        End Function
#End Region

    End Class
End Namespace