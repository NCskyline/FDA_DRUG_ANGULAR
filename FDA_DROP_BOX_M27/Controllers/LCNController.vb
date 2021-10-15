Imports System.Web.Mvc
Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Web.Script.Serialization

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

        Function INPUT_PDF_DRUG_KORYOR15() As ActionResult
            Return View()
        End Function

        Function INPUT_DRUG_PORYOR9() As ActionResult
            Return View()
        End Function
        Function INPUT_DRUG_NORYOR9() As ActionResult
            Return View()
        End Function
        Function INPUT_DRUG_YORBOR13() As ActionResult
            Return View()
        End Function
        Function FRM_EXTEND_TIME_LOCATION_MAIN_USER() As ActionResult
            Return View()
        End Function

        Function PREVIEW_INPUT_LCN() As ActionResult
            Return View()
        End Function
        '
        Function FRM_SELECT_LCT() As ActionResult
            Return View()
        End Function
        Function FRM_LCN_SELECT() As ActionResult
            Return View()
        End Function

        Function FRM_LCN_EDIT_REQUEST() As ActionResult
            Return View()
        End Function
        Function INPUT_PDF_YOR_SOR_3_1() As ActionResult
            Return View()
        End Function
        Function FRM_LCN_SUBSTITUTE_MAIN() As ActionResult
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

    Public Class LCN_CENTERController
        Inherits Controller

        Public _APP As String = System.Configuration.ConfigurationManager.AppSettings("APP")
        Public _SYSTEM_ID As String = System.Configuration.ConfigurationManager.AppSettings("SYSTEM_ID")
        Public _PATH_BOX As String = System.Configuration.ConfigurationManager.AppSettings("PATH_BOX")
        Public _PATH_BOX_TEMPLATE As String = System.Configuration.ConfigurationManager.AppSettings("PATH_BOX_TEMPLATE")
        Public _PATH_PDF_TEMPLATE As String = System.Configuration.ConfigurationManager.AppSettings("PATH_PDF_TEMPLATE")    'ที่อยู่ Path
        Public _PATH_XML_CLASS As String = System.Configuration.ConfigurationManager.AppSettings("PATH_XML_CLASS")          'ที่อยู่ Path
        Public _PATH_PDF_XML_CLASS As String = System.Configuration.ConfigurationManager.AppSettings("PATH_PDF_XML_CLASS")  'ที่อยู่ Path
        Public _PATH_PDF_TRADER As String = System.Configuration.ConfigurationManager.AppSettings("PATH_PDF_TRADER")        'ที่อยู่ Path
        Public _PATH_XML_TRADER As String = System.Configuration.ConfigurationManager.AppSettings("PATH_XML_TRADER")        'ที่อยู่ Path
        Public _PATH_DEFAULT As String = System.Configuration.ConfigurationManager.AppSettings("PATH_DEFALUT")              'ที่อยู่ Path
        Public _PATH_EDIT As String = System.Configuration.ConfigurationManager.AppSettings("PATH_EDIT")              'ที่อยู่ Path
        Public _PATH_SUBS As String = System.Configuration.ConfigurationManager.AppSettings("PATH_EDIT")
        Public _RDLC As String = System.Configuration.ConfigurationManager.AppSettings("RDLC")
        Public _PATH_XML_IMPORT As String = System.Configuration.ConfigurationManager.AppSettings("PATH_XML_IMPORT")        'มินทำต้องทำต่อ 5555555555555555555
        Public _PATH_PDF_IMPORT As String = System.Configuration.ConfigurationManager.AppSettings("PATH_PDF_IMPORT")
        Dim msg_r As New MODEL_RESULT

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

        Public Function SETMODEL_LOCATION() As JsonResult
            Dim MODEL As New MODEL_LOCATION
            Dim DATA_List As New LOCATION_LIST
            DATA_List.LOCATION_SELECT = ""
            DATA_List.fulladdr = ""
            DATA_List.tel = ""
            DATA_List.Mobile = ""
            MODEL.LOCATION_LISTs.Add(DATA_List)
            Return Json(MODEL, JsonRequestBehavior.AllowGet)
        End Function

        Public Function SETMODEL_LIST(ByVal PROCESS_ID As String) As JsonResult

            Dim MODEL As New MODEL_FILELIST
            Dim N As Integer = 1
            Dim dao As New DAO_DRUG.TB_MAS_ATTACH_TEMPLATE
            dao.GetDataby_PROCESS(PROCESS_ID)

            For Each dao.fields In dao.datas
                Dim filelist As New FILE_LIST
                filelist.IDA = N
                filelist.FILENAME = ""
                filelist.DES = dao.fields.DESCRIPTION
                filelist.FILE_DATA = ""
                filelist.PIORITY = ""
                filelist.PATH = ""
                filelist.FLAG = ""
                filelist.TYPE = ""
                filelist.SIZE = 0
                MODEL.FILE_LISTs.Add(filelist)
                N += 1
            Next

            Return Json(MODEL, JsonRequestBehavior.AllowGet)
        End Function
#Region "STORE"
        Function GET_FULL_MODEL_EDIT() As JsonResult
            Dim model As New MODEL_STAFF_EDIT_LCN
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
#Region "UPDATE_DATA"
        Function UPDATE_LCN_EDIT_CONSIDER(ByVal XML_DATA As String, ByVal IDA As Integer, ByVal CITIZEN_ID As String) As JsonResult
            Dim Result As String = ""
            Dim jss As New JavaScriptSerializer
            Dim bb As MODEL_LCN = jss.Deserialize(XML_DATA, GetType(MODEL_LCN))

            Dim dao As New DAO_DRUG.TB_DALCN_EDIT_REQUEST
            dao.GetDataby_IDA(IDA)
            Dim CONSIDER_DATE As Date = CDate(bb.DALCN_EDIT_REQUEST.CONSIDER_DATE)


            dao.fields.REMARK = bb.DALCN_EDIT_REQUEST.REMARK
            dao.fields.STATUS_ID = 6
            dao.fields.CONSIDER_DATE = CONSIDER_DATE

            dao.fields.FK_STAFF_OFFER_IDA = bb.DALCN_EDIT_REQUEST.FK_STAFF_OFFER_IDA
            Try
                dao.fields.appdate = CDate(bb.DALCN_EDIT_REQUEST.appdate)
            Catch ex As Exception

            End Try
            dao.update()
            Result = "บันทึกข้อมูลเรียบร้อย"
            AddLogStatus(6, dao.fields.PROCESS_ID, CITIZEN_ID, IDA)
            Return Json(Result, JsonRequestBehavior.AllowGet)
        End Function
        Function UPDATE_REMARK_LCN_EDIT(ByVal XML_LCN As String, ByVal IDA As Integer, ByVal CITIZEN_ID As String) As JsonResult
            Dim Result As String = ""
            Dim jss As New JavaScriptSerializer
            Dim bb As MODEL_LCN = jss.Deserialize(XML_LCN, GetType(MODEL_LCN))

            Dim dao As New DAO_DRUG.TB_DALCN_EDIT_REQUEST
            dao.GetDataby_IDA(IDA)
            dao.fields.STATUS_ID = 7
            dao.fields.REMARK = bb.DALCN_EDIT_REQUEST.REMARK

            dao.update()
            AddLogStatus(7, dao.fields.PROCESS_ID, CITIZEN_ID, IDA)
            'KEEP_LOGS_EDIT(IDA, "แก้ไขวันที่ให้ไว้ ณ", CITIZEN_ID)
            Result = "ดำเนินการคืนคำขอเรียบร้อยแล้ว"
            Return Json(Result, JsonRequestBehavior.AllowGet)
        End Function

        Function UPDATE_LCN_RCVNO_TEMP(ByVal XML_LCN As String, ByVal IDA As Integer, ByVal CITIZEN_ID As String) As JsonResult
            Dim Result As String = ""
            Dim jss As New JavaScriptSerializer
            Dim bb As MODEL_LCN = jss.Deserialize(XML_LCN, GetType(MODEL_LCN))

            Dim dao As New DAO_DRUG.ClsDBdalcn
            Dim bao As New BAO_GENNO.GenNumber

            dao.GetDataby_IDA(IDA)

            AddLogStatus(3, dao.fields.PROCESS_ID, CITIZEN_ID, IDA)

            Dim PROCESS_ID As Integer = dao.fields.PROCESS_ID

            Dim dao_p As New DAO_DRUG.ClsDBPROCESS_NAME
            dao_p.GetDataby_Process_ID(PROCESS_ID)
            Dim GROUP_NUMBER As Integer = dao_p.fields.PROCESS_ID

            dao.fields.RCVNO_MANUAL = bb.dalcn.TEMPORARY_RCVNO
            Try
                dao.fields.rcvdate = CDate(txt_rcvdate.Text)
            Catch ex As Exception

            End Try

            dao.fields.TEMPORARY_RCVNO = Txt_rcvno_temp.Text
            Try

            Catch ex As Exception

            End Try

            Try
                dao.fields.TEMPLATE_ID = ddl_template.SelectedValue
            Catch ex As Exception

            End Try


            Try
                dao.fields.rcvr_id = 0 'ddl_receiver.SelectedValue
            Catch ex As Exception

            End Try

            Try
                'send_mail_mini(dao.fields.CITIZEN_ID, "FDATH", "เจ้าหน้าที่ดำเนินการรับคำขอ เลขดำเนินการที่ " & dao.fields.TR_ID & " แล้ว")
            Catch ex As Exception

            End Try
            dao.update()
            AddLogStatus(3, dao_up.fields.PROCESS_ID, _CLS.CITIZEN_ID, _IDA)
            'KEEP_LOGS_EDIT(IDA, "แก้ไขวันที่ให้ไว้ ณ", CITIZEN_ID)
            Result = "ดำเนินการคืนคำขอเรียบร้อยแล้ว"
            Return Json(Result, JsonRequestBehavior.AllowGet)
        End Function
#End Region


#Region "FILE_ATTACH"
        Public Function UPLOAD_PDF_ATTACH(ByVal model As String, ByVal TR_ID As String, ByVal PROCESS_ID As String) As String
            Dim result As String = ""
            Try
                Dim TRID As String = ""
                Dim MODEL_LIST As New MODEL_FILELIST


                Dim jsonArray As JArray = JArray.Parse(model)
                For Each parsedObject As JObject In jsonArray.Children(Of JObject)()
                    Dim filelist As New FILE_LIST
                    ''Dim kkk As String = parsedObject("TR_ID")
                    For Each parsedProperty As JProperty In parsedObject.Properties()
                        Dim propertyName As String = parsedProperty.Name
                        If propertyName = "FILENAME" Then
                            filelist.FILENAME = CStr(parsedProperty.Value)
                        ElseIf propertyName = "DES" Then
                            filelist.DES = CStr(parsedProperty.Value)
                        End If
                    Next
                    MODEL_LIST.FILE_LISTs.Add(filelist)
                Next

                Dim filename As String = ""
                Dim PATHs As String = ""
                Dim path_file As String = ""
                Dim NAME_REAL As String = ""
                Dim DD As Integer = 1
                Dim Count As Integer = 1
                ''Dim path As String = _PATH_DEFAULT & "\upload\"
                Dim path As String = "F:\path\DRUG\upload\"
                Directory.CreateDirectory(path) 'สร้าง PATH รอ
                Dim i As Integer = 0

                For Each s As String In Request.Files

                    Dim dao As New DAO_DRUG.ClsDBFILE_ATTACH
                    dao.GetDataby_TR_ID_And_Process(TR_ID, PROCESS_ID)
                    If dao.Details.Count <> 0 Then
                        DD = dao.Details.Count + 1
                    End If
                    NAME_REAL = Request.Files(i).FileName ''Request.Files(0).FileName 
                    Dim Type As String = IO.Path.GetExtension(Request.Files(i).FileName).ToString()
                    filename = "DA-" & PROCESS_ID & "-" & Date.Now.Year + 543 & "-" & TR_ID & "-" & DD & Type
                    path_file = path & filename
                    Dim postedFile As HttpPostedFileBase = Request.Files(i)

                    postedFile.SaveAs(path_file)

                    Dim dao_f As New DAO_DRUG.ClsDBFILE_ATTACH
                    With dao_f.fields
                        .NAME_FAKE = filename
                        .NAME_REAL = NAME_REAL
                        .TYPE = DD
                        .TRANSACTION_ID = TR_ID
                        For Each f As FILE_LIST In MODEL_LIST.FILE_LISTs
                            If NAME_REAL = f.FILENAME Then
                                .DESCRIPTION = f.DES
                            End If
                        Next
                        .PROCESS_ID = PROCESS_ID
                        .FILE_PATH = path_file
                    End With
                    dao_f.insert()

                    i += 1
                Next

                result = "SUCCESS"
            Catch ex As Exception
                result = "ERROR"
            End Try
            Return result
        End Function
#End Region

    End Class
End Namespace