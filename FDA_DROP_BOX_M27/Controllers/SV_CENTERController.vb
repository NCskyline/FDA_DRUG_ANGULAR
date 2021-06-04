Imports System.IO
Imports System.Web.Mvc
Imports System.Web.Script.Serialization
Imports System.Xml
Imports System.Xml.Serialization
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Namespace Controllers
    Public Class SV_CENTERController
        Inherits Controller


        Public _APP As String = System.Configuration.ConfigurationManager.AppSettings("APP")
        Public _SYSTEM_ID As String = System.Configuration.ConfigurationManager.AppSettings("SYSTEM_ID")
        Public _PATH_BOX As String = System.Configuration.ConfigurationManager.AppSettings("PATH_BOX")
        Public _PATH_BOX_TEMPLATE As String = System.Configuration.ConfigurationManager.AppSettings("PATH_BOX_TEMPLATE")
        Dim msg_r As New MODEL_RESULT
        Dim BAO_L As New BAO_DROPBOX


#Region "PDF"

#End Region

#Region "STORE"

        Function SP_GET_LCN(ByVal CITIZEN As String) As JsonResult
            Dim DT As New DataTable
            Dim BAO As New BAO
            DT = BAO.SP_DDL_LCN_DI_DH(CITIZEN)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(DT), JsonRequestBehavior.AllowGet)

        End Function
        Function SP_GET_INV_HISTORY(ByVal CTZNO As String)
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_GET_INV_HISTORY(CTZNO)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)

        End Function

        Function SP_MAS_DRUG_SHAPE()
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_MAS_DRUG_SHAPE()
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)

        End Function

        Function SP_drkdofdrg()
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_drkdofdrg()
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)

        End Function
        Function SP_SYSLCNSNM_BY_LCNSID_AND_IDENTIFY(ByVal identify As String, ByVal LCNSID As String)
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_SYSLCNSNM_BY_LCNSID_AND_IDENTIFY(identify, LCNSID)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)

        End Function
        '
        Function SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(ByVal LOCATION_ADDRESS_IDA As Integer)
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(LOCATION_ADDRESS_IDA)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)

        End Function
        Function SP_MASTER_CER_PK_BY_FK_IDA(ByVal FK_IDA As String)
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_MASTER_CER_PK_BY_FK_IDA(22069)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)

        End Function

        Function SP_DH15RQT_BY_IDA(ByVal LCN_IDA As Integer, ByVal PROCESS_ID As Integer)
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_DH15RQT_BY_IDA(LCN_IDA, PROCESS_ID)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        End Function

        'SP_MASTER_CER_PK_BY_FK_IDA
        Function SP_MASTER_sysisocnt()
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_MASTER_sysisocnt()
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)

        End Function
        '
        Function SP_dactg()
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_dactg()
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)

        End Function
        Function SP_DRUG_UNIT_PHYSIC()
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_DRUG_UNIT_PHYSIC()
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)

        End Function

        Function SP_MASTER_drclass()
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_MASTER_drclass()
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)

        End Function

        Function SP_dosage_form()
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_dosage_form()
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)

        End Function
        Function SP_GET_BOX_APPROVE(ByVal TR_ID As String) As JsonResult
            Dim DT As New DataTable
            Dim BAO As New BAO
            DT = BAO.SP_GET_BOX_APPROVE(TR_ID)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(DT), JsonRequestBehavior.AllowGet)
        End Function

        Function SP_GET_PRODUCT_TYPE(ByVal PRODUCT_GROUP As String) As JsonResult
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_GET_PRODUCT_TYPE(PRODUCT_GROUP)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        End Function

        Function SP_GET_DRUG_PRODUCT_ESUB(ByVal register As String) As JsonResult
            Dim DT As New DataTable
            Dim bao As New BAO
            DT = bao.SP_GET_DRUG_PRODUCT_ESUB(register)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(DT), JsonRequestBehavior.AllowGet)
        End Function

        Function SP_GET_ISO(ByVal CTZNO As String, ByVal TOKEN As String) As JsonResult
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_GET_ISO()
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        End Function
        Function SP_GET_BOX_CTZNO(ByVal LCN_IDA As String, ByVal CTZNO As String, ByVal LCN_TYPE As String, ByVal TOKEN As String) As JsonResult
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_GET_BOX_CTZNO(CTZNO, LCN_IDA, LCN_TYPE)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        End Function

        Function SP_GET_BOX_STAFF(ByVal ORG As String) As JsonResult
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_GET_BOX_STAFF(_APP)

            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        End Function


        Function SP_GET_BOX_STAFF_STATUS(ByVal ORG As String, ByVal STATUS As String) As JsonResult
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_GET_BOX_STAFF_STATUS(_APP, STATUS)

            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        End Function

        Function SP_SYSISOCNT() As JsonResult
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_SYSISOCNT()
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        End Function

        Function SP_GET_SIP_UNIT() As JsonResult
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_SIP_UNIT()
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        End Function

        Function SP_GET_DRDOSAGE() As JsonResult
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_GET_DRDOSAGE()
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        End Function

        Function SP_GET_PROCESS(ByVal ORG As String, ByVal PROCESS_TYPE As String) As JsonResult
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_GET_PROCESS(ORG, PROCESS_TYPE)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        End Function

        Function SP_GET_DATA_LCN(ByVal CITIZIN As String, ByVal lcnno As String, ByVal PVNCD As Integer) As JsonResult


            Dim dt As New DataTable
            Dim command As String = " "
            Dim bao_aa As New BAO
            command = "select * from dbo.Vw_SP_DALCN_SEARCH_EDIT "


            Dim str_where As String = ""
            Dim dt2 As New DataTable

            If CITIZIN = "" And lcnno = "" Then
                'If pvncd = 10 Then
                '    RadGrid1.DataSource = dt
                'Else
                '    RadGrid1.DataSource = dt.Select("pvncd = '" & pvncd & "'")
                'End If
                command &= str_where
            Else
                If CITIZIN <> "" Then
                    str_where = "where CITIZEN_ID_AUTHORIZE='" & CITIZIN & "'"
                    If lcnno <> "" Then
                        If str_where <> "" Then
                            str_where &= " and lcnno_no like '%" & lcnno & "%'"
                        Else
                            str_where &= "lcnno_no like '%" & lcnno & "%'"
                        End If

                    End If
                    'r_result = dt.Select(str_where)
                    command &= str_where
                Else
                    If str_where = "" Then
                        If str_where <> "" Then
                            If lcnno <> "" Then
                                str_where &= " and lcnno_no like '%" & lcnno & "%'"
                            End If
                        Else
                            If lcnno <> "" Then
                                str_where = "where lcnno_no like '%" & lcnno & "%'"

                            End If
                        End If
                        'r_result = dt.Select(str_where)
                        command &= str_where
                    Else
                        If lcnno <> "" Then
                            str_where = "where lcnno_no like '%" & lcnno & "%'"

                        End If
                        'r_result = dt.Select(str_where)
                        command &= str_where
                    End If
                    'r_result = dt.Select(str_where)
                    'command &= str_where
                End If
                'dt2 = dt.Clone

                'For Each dr As DataRow In r_result
                '    dt2.Rows.Add(dr.ItemArray)
                'Next




                '----new

            End If
            'pvncd = 12
            'If rdl_stat.SelectedValue = 0 Then
            '    If PVNCD = 10 Then
            '        'RadGrid1.DataSource = dt2

            '        'command &= str_where
            '    Else
            '        'RadGrid1.DataSource = dt2.Select("pvncd = '" & pvncd & "'")
            '        If command.Contains("where") Then
            '            command &= " and pvncd = '" & PVNCD & "' and lcntpcd <> 'ผย1' "
            '        Else
            '            command &= "where pvncd = '" & PVNCD & "' and lcntpcd <> 'ผย1'"
            '        End If

            '    End If

            'ElseIf rdl_stat.SelectedValue = 1 Then
            '    If PVNCD = 10 Then
            '        'RadGrid1.DataSource = dt2.Select("lcn_stat=0")
            '        If command.Contains("where") Then
            '            command &= " and lcn_stat=0"
            '        Else
            '            If command.Contains("pvncd") Then
            '                command &= " and lcn_stat=0 and lcntpcd <> 'ผย1' "
            '            Else
            '                command &= "where lcn_stat=0 and lcntpcd <> 'ผย1' "
            '            End If
            '        End If

            '    Else
            '        'RadGrid1.DataSource = dt2.Select("lcn_stat=0 and pvncd = '" & pvncd & "'")
            '        If command.Contains("where") Then
            '            command &= " and lcn_stat=0 and pvncd = '" & PVNCD & "'"
            '        Else
            '            command &= "where lcn_stat=0 and pvncd = '" & PVNCD & "'"
            '        End If

            '    End If

            'ElseIf rdl_stat.SelectedValue = 2 Then
            '    If PVNCD = 10 Then
            '        If command.Contains("where") Then
            '            command &= " and lcn_stat=0"
            '        Else
            '            If command.Contains("pvncd") Then
            '                command &= " and lcn_stat=0  and lcntpcd <> 'ผย1' "
            '            Else
            '                command &= "where lcn_stat=0  and lcntpcd <> 'ผย1' "
            '            End If
            '        End If
            '    Else
            '        'RadGrid1.DataSource = dt2.Select("lcn_stat=1 and pvncd = '" & pvncd & "'")
            '        If command.Contains("where") Then
            '            command &= " and lcn_stat=1 and pvncd = '" & PVNCD & "'"
            '        Else
            '            command &= "where lcn_stat=1 and pvncd = '" & PVNCD & "'"
            '        End If
            '    End If

            'End If
            dt = bao_aa.Queryds(command)

            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)

        End Function

        Function GET_INFORMATION(ByVal IDA As Integer) As JsonResult

            Dim model As New MODEL_DH
            Try

                Dim Tb As New DAO_DRUG.TB_DALCN_LOCATION_ADDRESS                               ' ประกาศตัวแปรเพื่อเรียกใช้
                Dim TbNO As New DAO_DRUG.ClsDBdalcn                                     ' ประกาศตัวแปรเพื่อเรียกใช้
                Dim tb_location As New DAO_DRUG.TB_DALCN_LOCATION_BSN

                TbNO.GetDataby_IDA(IDA)                                                 'การ where 
                Tb.GetDataby_IDA(TbNO.fields.FK_IDA)                                    'การ where 

                Try
                    tb_location.GetDataby_LCN_IDA(IDA)
                Catch ex As Exception

                End Try
                'การ where
                Try

                Catch ex As Exception

                End Try
                'lbl_lcnno.Text = TbNO.fields.LCNNO_DISPLAY
                Dim lcnno As String = ""
                Dim rcvno As String = ""
                Try
                    lcnno = TbNO.fields.lcntpcd & " " & CInt(Right(TbNO.fields.lcnno, 5)) & "/" & Left(TbNO.fields.lcnno, 2)
                Catch ex As Exception

                End Try
                Try
                    rcvno = CInt(Right(TbNO.fields.rcvno, 5)) & "/" & Left(TbNO.fields.rcvno, 2)
                Catch ex As Exception

                End Try
                Try
                    If TbNO.fields.lcnno IsNot Nothing Then
                        Dim raw_lcn As String = TbNO.fields.lcnno
                        model.lcnno = lcnno 'CStr(CInt((Right(raw_lcn, 5))) & "/25" & Left(raw_lcn, 2))
                    End If
                Catch ex As Exception

                End Try

                model.rcvno = rcvno                                    ' เอาข้อมูลมาโชว์ที่  label
                Try
                    model.rcvdate = CDate(TbNO.fields.rcvdate).ToLongDateString()       ' เอาข้อมูล แล้วเปลี่ยนตัดค่า เวลาออก
                Catch ex As Exception

                End Try

                model.thanameplace = Tb.fields.thanameplace                          ' เอาข้อมูลมาโชว์ที่  label
                model.nameOperator = TbNO.fields.BSN_THAIFULLNAME             ' เอาข้อมูลมาโชว์ที่  label

                If model.nameOperator = "" Then
                    Try
                        Dim dao_lcns As New DAO_CPN.clsDBsyslcnsnm
                        dao_lcns.GetDataby_lcnsid(TbNO.fields.bsnid)
                        model.nameOperator = dao_lcns.fields.prefixnm & dao_lcns.fields.thanm & " " & dao_lcns.fields.thalnm
                    Catch ex As Exception

                    End Try
                End If
            Catch ex As Exception

            End Try
            Return Json(model, JsonRequestBehavior.AllowGet)
        End Function

        Function SP_CUSTOMER_CER_BY_FK_IDA_and_CER_TYPE_and_iden(ByVal IDA As String, ByVal CER_TYPE As String, ByVal iden As String) As JsonResult
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_CUSTOMER_CER_BY_FK_IDA_and_CER_TYPE_and_iden(IDA, CER_TYPE, iden)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        End Function

        Function SP_CHEMICAL_REQUEST_CUSTOMER_CHEM_TYPE(ByVal iden As String, ByVal mt As Integer, ByVal st As Integer, ByVal aori As String) As JsonResult
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_CHEMICAL_REQUEST_CUSTOMER_CHEM_TYPE(iden, mt, st, aori)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)

        End Function

#End Region

#Region "GET_DATA"
        Function GET_LCN_NO(ByVal IDA As Integer) As JsonResult
            Dim model As New MODEL_LCN
            Dim dao As New DAO_DRUG.ClsDBdalcn
            dao.GetDataby_IDA(IDA)
            Dim lcnno_format As String = ""
            For Each dao.fields In dao.datas
                Dim lcnno_auto As Integer = 0
                Try
                    lcnno_auto = dao.fields.lcnno
                Catch ex As Exception

                End Try
                Try
                    If Len(lcnno_auto) > 0 Then

                        If Right(Left(lcnno_auto, 3), 1) = "5" Then
                            lcnno_format = "จ. " & CStr(CInt(Right(lcnno_auto, 4))) & "/25" & Left(lcnno_auto, 2)
                        Else
                            lcnno_format = dao.fields.pvnabbr & " " & CStr(CInt(Right(lcnno_auto, 5))) & "/25" & Left(lcnno_auto, 2)
                        End If
                        'lcnno_format = dao.fields.pvnabbr & " " & CStr(CInt(Right(lcnno_auto, 5))) & "/25" & Left(lcnno_auto, 2)
                    End If
                Catch ex As Exception

                End Try
                Dim dao_dalcntype As New DAO_DRUG.ClsDBdalcntype
                dao_dalcntype.GetDataby_lcntpcd(dao.fields.lcntpcd)


                ''Dim model As New MODEL_LCN
                With model
                    .LCNNO_SHOW = lcnno_format
                    Try
                        .TYPE_IMPORT = dao_dalcntype.fields.lcntpnm
                    Catch ex As Exception

                    End Try

                End With

            Next


            Return Json(model, JsonRequestBehavior.AllowGet)
        End Function

        'Function GET_MAS_BIO_UNIT(ByVal IDA As Integer) As JsonResult
        '    Dim dao As New DAO_DRUG.TB_MAS_BIO_UNIT
        '    dao.GetDataALL()
        '    Return Json(dao.datas, JsonRequestBehavior.AllowGet)
        'End Function
        Function GET_MAS_BIO_UNIT() As JsonResult
            Dim MODEL_LIST As New List(Of MODEL_DL)
            Dim dao As New DAO_DRUG.TB_MAS_BIO_UNIT
            dao.GetDataALL()
            For Each dao.fields In dao.datas
                Dim M_DL As New MODEL_DL
                With M_DL
                    .IDA_BIO = dao.fields.IDA
                    .BIO_UNIT = dao.fields.BIO_UNIT
                End With
                MODEL_LIST.Add(M_DL)
            Next

            Return Json(MODEL_LIST, JsonRequestBehavior.AllowGet)
        End Function
        Function GET_dramltype() As JsonResult
            Dim MODEL_LIST As New List(Of MODEL_DR)
            Dim dao As New DAO_DRUG.TB_dramltype
            dao.GetDataAll()
            For Each dao.fields In dao.datas
                Dim M_DR As New MODEL_DR
                With M_DR
                    .amltpnm = dao.fields.amltpnm
                    .amltpcd = dao.fields.amltpcd
                End With
                MODEL_LIST.Add(M_DR)
            Next

            Return Json(MODEL_LIST, JsonRequestBehavior.AllowGet)
        End Function
        Function GET_dramlsubtp(ByVal amltpcd As String) As JsonResult
            Dim MODEL_LIST As New List(Of MODEL_DR)
            Dim dao As New DAO_DRUG.TB_dramlsubtp
            dao.GetDataby_amltpcd(amltpcd)
            For Each dao.fields In dao.datas
                Dim M_DR As New MODEL_DR
                With M_DR
                    .amlsubnm = dao.fields.amlsubnm
                    .amlsubcd = dao.fields.amlsubcd
                End With
                MODEL_LIST.Add(M_DR)
            Next

            Return Json(MODEL_LIST, JsonRequestBehavior.AllowGet)
        End Function

        Function GET_dramlusetp(ByVal amlsubcd As String) As JsonResult
            Dim MODEL_LIST As New List(Of MODEL_DR)
            Dim dao As New DAO_DRUG.TB_dramlusetp
            dao.GetDataby_cd(amlsubcd)
            For Each dao.fields In dao.datas
                Dim M_DR As New MODEL_DR
                With M_DR
                    .usetpnm = dao.fields.usetpnm
                    .usetpcd = dao.fields.usetpcd
                End With
                MODEL_LIST.Add(M_DR)
            Next

            Return Json(MODEL_LIST, JsonRequestBehavior.AllowGet)
        End Function
        Function GET_DRUG_PACKAGING() As JsonResult
            Dim MODEL_LIST As New List(Of MODEL_DL)
            Dim dao As New DAO_DRUG.TB_MAS_DRUG_PACKAGING
            dao.GetDataAll()
            For Each dao.fields In dao.datas
                Dim M_DL As New MODEL_DL
                With M_DL
                    .UOP_CODE = dao.fields.UOP_CODE
                    .PACKAGING_NAME = dao.fields.PACKAGING_NAME
                End With
                MODEL_LIST.Add(M_DL)
            Next
            Return Json(MODEL_LIST, JsonRequestBehavior.AllowGet)
        End Function
        Function GET_DATA_DRAMLTYPE_ALL() As JsonResult
            Dim dao As New DAO_DRUG.TB_dramltype
            dao.GetDataAll()

            Return Json(dao.datas, JsonRequestBehavior.AllowGet)
        End Function



        Function GET_LIST_LCN(ByVal IDENTIFY As String, ByVal TOKEN As String, ByVal CTZNO As String) As JsonResult
            Dim MODEL_LIST As New List(Of MODEL_LCN)

            Dim bao_sp As New BAO
            Dim dt As New DataTable


            'dt = bao_sp.SP_LOCATION_MDC(IDENTIFY)
            'For Each dr As DataRow In dt.Rows
            '    Dim M_LCN As New MODEL_LCN
            '    With M_LCN
            '        .ADDR = dr("licen_addr")
            '        .LCNNO = dr("LCN_DISPLAY")
            '        .LCN_IDA = dr("Newcode")
            '        .NAME = dr("thanm")
            '        .LCN_TYPE = dr("rgttpnm")
            '        .SYSTEM_NAME = "MDC"
            '    End With
            '    MODEL_LIST.Add(M_LCN)
            'Next


            dt = bao_sp.SP_GET_LOCATION_ADDR(IDENTIFY)
            For Each dr As DataRow In dt.Rows
                Dim M_LCN As New MODEL_LCN
                With M_LCN
                    .ADDR = dr("fulladdr")
                    Try
                        .LCNNO = dr("LCNNO")
                    Catch ex As Exception

                    End Try

                    .LCN_IDA = dr("IDA")
                    .NAME = dr("nameplace")
                    .LCN_TYPE = "นำเข้า"
                    .SYSTEM_NAME = "CENTER"
                End With
                MODEL_LIST.Add(M_LCN)
            Next

            Return Json(MODEL_LIST, JsonRequestBehavior.AllowGet)
        End Function



        Function GET_AUTHEN(ByVal TOKEN As String) As JsonResult
            'CHECK_URL()

            Dim _CLS As New CLS_SESSION

            If TOKEN = "PASS" Then
                _CLS.CITIZEN_ID = "0105522020724" ''"1100400181875"
                _CLS.CITIZEN_ID_AUTHORIZE = "0105522020724" '"0105540078852"
                _CLS.COMPANY_NAME = "บริษัท เทสออนลี่ จำกัด มหาขน"
                _CLS.THANM = "นายทดสอบ ระบบ"
                _CLS.TOKEN = TOKEN
                _CLS.CODE = "900"
                _CLS.SET_MAIN_PAGE1 = GET_BTN_DATA(0, 21020)
                _CLS.SET_MAIN_PAGE2 = GET_BTN_DATA(1, 21020)
                _CLS.SET_MAIN_PAGE3 = GET_BTN_DATA(2, 21020)
                _CLS.SET_MAIN_PAGE4 = GET_BTN_DATA(3, 21020)

            Else


                Dim ws As New WS_AUTHEN.Authentication
                Dim xml As String = ""
                xml = ws.Authen_Login(TOKEN)

                Dim clsxml As New Cls_XML
                clsxml.ReadData(xml)
                _CLS.CITIZEN_ID = clsxml.Get_Value_XML("Citizen_ID")
                _CLS.CITIZEN_ID_AUTHORIZE = clsxml.Get_Value_XML("CITIEZEN_ID_AUTHORIZE")
                _CLS.TOKEN = TOKEN
                _CLS.GROUPS = clsxml.Get_Value_XML("Groups")
                _CLS.SYSTEM_ID = clsxml.Get_Value_XML("System_ID")
                _CLS.PVCODE = clsxml.Get_Value_XML("pvcode")
                _CLS.THANM = clsxml.Get_Value_XML("Name")
                _CLS.CODE = clsxml.Get_Value_XML("CODE")
                _CLS.IDgroup = clsxml.Get_Value_XML("IDgroup")

                'Dim xml_c As String = ""
                'ดึงชื่อคน LOGIN เข้าระบบ
                Dim ws_c As New WS_GET_CPN.WS_DATA_CENTER
                'xml_c = ws_c.GET_DATA_IDENTIFY(_CLS.CITIZEN_ID, "0994000165676", "FUSION", "P@ssw0rdfusion440")
                'clsxml.ReadData(xml_c)
                'Dim CUSTOMER_NAME As String = clsxml.Get_Value_XML("thanm")
                '_CLS.THANM = CUSTOMER_NAME

                Dim xml_COM As String = ""
                xml_COM = ws_c.GET_DATA_IDENTIFY(_CLS.CITIZEN_ID_AUTHORIZE, "0994000165676", "FUSION", "P@ssw0rdfusion440")
                clsxml.ReadData(xml_COM)
                Dim COMPANY_NAME As String = clsxml.Get_Value_XML("prefixnm") & " " & clsxml.Get_Value_XML("thanm") & " " & clsxml.Get_Value_XML("thalnm")
                _CLS.COMPANY_NAME = COMPANY_NAME
                _CLS.ADDR = clsxml.Get_Value_XML("Fulladdr")

                'If CUSTOMER_NAME = "" Then 'กรณีไม่เจอ
                '    'ดึงกรมการปกครอง
                '    xml_c = ws_c.FDA_IDENTIFY(_CLS.CITIZEN_ID, "0994000165676", "FUSION", "P@ssw0rdfusion440")
                '    clsxml.ReadData(xml_c) 'อ่าน XML อีกรอบ
                '    CUSTOMER_NAME = clsxml.Get_Value_XML("prefixnm") & " " & clsxml.Get_Value_XML("thanm")
                '    If CUSTOMER_NAME = "" Then 'เป็นค่าว่งอีกรอบเอาจาก สพร 
                '        Dim dao_e As New DAO_CPN.TB_SYSEMAIL
                '        dao_e.GetDataby_CTZNO(_CLS.CITIZEN_ID)
                '        CUSTOMER_NAME = dao_e.fields.NAME
                '    End If
                '    _CLS.THANM_CUSTOMER = CUSTOMER_NAME
                'Else
                '    _CLS.THANM_CUSTOMER = clsxml.Get_Value_XML("prefixnm") & " " & clsxml.Get_Value_XML("thanm")
                'End If

                _CLS.SET_MAIN_PAGE1 = GET_BTN_DATA(0, 21020)
                _CLS.SET_MAIN_PAGE2 = GET_BTN_DATA(1, 21020)
                _CLS.SET_MAIN_PAGE3 = GET_BTN_DATA(2, 21020)
                _CLS.SET_MAIN_PAGE4 = GET_BTN_DATA(3, 21020)


            End If

            Return Json(_CLS, JsonRequestBehavior.AllowGet)
        End Function

        Function GET_BTN_DATA(ByVal BTN_GROUP As Integer, ByVal IDgroup As Integer) As Object
            Dim dao As New DAO_DRUG.TB_MAS_ADMIN_BUTTON
            dao.GetDataby_Btn_Group_and_IdGroup(BTN_GROUP, IDgroup)

            Return dao.datas
        End Function


#End Region

#Region "MODEL DATA"
        Public Function SETMODEL() As JsonResult
            Dim MODEL As New MODEL_BOX


            Return Json(MODEL, JsonRequestBehavior.AllowGet)
        End Function

        Function SETMODEL_DH() As JsonResult
            Dim MODEL As New MODEL_DH

            Return Json(MODEL, JsonRequestBehavior.AllowGet)
        End Function

        Public Function SETMODEL_LIST() As JsonResult
            Dim MODEL As New MODEL_FILELIST
            Dim filelist As New FILE_LIST
            filelist.FILENAME = ""
            filelist.DES = ""
            filelist.FILE_DATA = ""
            filelist.PIORITY = ""
            filelist.PATH = ""
            filelist.FLAG = ""
            MODEL.FILE_LISTs.Add(filelist)
            Return Json(MODEL, JsonRequestBehavior.AllowGet)
        End Function
#End Region

#Region "UPLOAD PDF"
        Public Function UPLOAD_PDF(ByVal CITIZEN_ID As String, ByVal TOKEN As String) As JsonResult
            Dim filename As String = ""
            Dim path As String = _PATH_BOX_TEMPLATE & "\" & CITIZEN_ID & "\" & TOKEN
            Directory.CreateDirectory(path)
            Dim PATHs As String = ""
            Dim path_file As String = ""
            Try
                For Each s As String In Request.Files
                    filename = Request.Files(0).FileName
                    path_file = path & "\" & Date.Now.ToOADate & ".pdf"
                    Dim postedFile As HttpPostedFileBase = Request.Files(0)

                    postedFile.SaveAs(path_file)
                Next
                msg_r.MSG_CODE = "200"
                msg_r.MSG_RESULT = "SUCCESS"
                msg_r.DATA_VALUE = path_file
            Catch ex As Exception
                msg_r.MSG_CODE = "401"
                msg_r.MSG_RESULT = "ERR"
                msg_r.MSG_DES = ex.Message.ToString
                msg_r.DATA_VALUE = ""
            End Try


            Return Json(msg_r, JsonRequestBehavior.AllowGet)
        End Function

        Public Function UPLOAD_PDF_V2(ByVal model As String) As String
            Dim result As String = ""
            Try

                'JArray jsonArray = JArray.Parse(jsonArrayString);
                Dim TR_ID As String = ""
                Dim MODEL_LIST As New MODEL_FILELIST

                Dim jsonArray As JArray = JArray.Parse(model)
                For Each parsedObject As JObject In jsonArray.Children(Of JObject)()
                    Dim filelist As New FILE_LIST
                    Dim kkk As String = parsedObject("TR_ID")
                    For Each parsedProperty As JProperty In parsedObject.Properties()
                        Dim propertyName As String = parsedProperty.Name
                        If propertyName = "TR_ID" Then
                            TR_ID = CStr(parsedProperty.Value)
                            filelist.TR_ID = CStr(parsedProperty.Value)
                        ElseIf propertyName = "FILENAME" Then
                            filelist.FILENAME = CStr(parsedProperty.Value)
                        ElseIf propertyName = "DES" Then
                            filelist.DES = CStr(parsedProperty.Value)
                        ElseIf propertyName = "PATH" Then
                            filelist.PATH = CStr(parsedProperty.Value)
                        ElseIf propertyName = "FLAG" Then
                            filelist.FLAG = CStr(parsedProperty.Value)
                        ElseIf propertyName = "PIORITY" Then
                            filelist.PIORITY = CStr(parsedProperty.Value)
                        ElseIf propertyName = "PROCESS_NAME" Then
                            filelist.PROCESS_NAME = CStr(parsedProperty.Value)
                        End If
                    Next
                    MODEL_LIST.FILE_LISTs.Add(filelist)
                Next



                'Dim dao_m As New DAO.TB_S_BOX
                'dao_m.GETDATA_BY_TR_ID(TR_ID)
                'Dim version As String = dao_m.fields.VERSION
                'Dim path As String = _PATH_BOX & "\" & TR_ID & "\" & version
                'Directory.CreateDirectory(path) 'สร้าง PATH รอ
                'Dim i As Integer = 0
                'For Each f As FILE_LIST In MODEL_LIST.FILE_LISTs
                '    Dim filepath As String = f.PATH

                '    Dim dao_f As New DAO.TB_FILE_BOX
                '    With dao_f.fields
                '        .CREATE_DATE = Date.Now
                '        .TITEL = f.DES
                '        .TR_ID = TR_ID
                '        .PRIORITY = f.PIORITY
                '        .REMARK = ""
                '        .REF_TR_ID = ""
                '    End With
                '    dao_f.insert()
                '    If filepath = "" Then

                '    Else
                '        If HAVE_FILE(filepath) = True Then 'กรณีเจอไฟล์
                '            Dim output_file As String = path & "\" & dao_f.fields.IDA & ".pdf"
                '            COPY_FILE(filepath, output_file)
                '            dao_f.fields.FILENAME = f.FILENAME
                '            dao_f.fields.PATH_FILE = output_file
                '            dao_f.fields.REF_TR_ID = filepath
                '            dao_f.fields.REMARK = f.PROCESS_NAME
                '            dao_f.update()
                '        Else

                '        End If
                '    End If
                'Next
                result = "success"
            Catch ex As Exception
                result = "ERR"
            End Try
            Return result
        End Function


        Public Function UPLOAD_PDF_V3(ByVal model As String) As String
            Dim result As String = ""
            Try
                'JArray jsonArray = JArray.Parse(jsonArrayString);
                Dim TR_ID As String = ""
                Dim MODEL_LIST As New MODEL_FILELIST

                Dim jsonArray As JArray = JArray.Parse(model)
                For Each parsedObject As JObject In jsonArray.Children(Of JObject)()
                    Dim filelist As New FILE_LIST
                    For Each parsedProperty As JProperty In parsedObject.Properties()
                        Dim propertyName As String = parsedProperty.Name
                        If propertyName = "TR_ID" Then
                            TR_ID = CStr(parsedProperty.Value)
                            filelist.TR_ID = CStr(parsedProperty.Value)
                        ElseIf propertyName = "FILENAME" Then
                            filelist.FILENAME = CStr(parsedProperty.Value)
                        ElseIf propertyName = "DES" Then
                            filelist.DES = CStr(parsedProperty.Value)
                        ElseIf propertyName = "PIORITY" Then
                            filelist.PIORITY = CStr(parsedProperty.Value)
                        ElseIf propertyName = "TYPE" Then
                            filelist.TYPE = CStr(parsedProperty.Value)
                        ElseIf propertyName = "PATH" Then
                            filelist.PATH = CStr(parsedProperty.Value)
                        ElseIf propertyName = "FLAG" Then
                            filelist.FLAG = CStr(parsedProperty.Value)
                        ElseIf propertyName = "IDA" Then
                            filelist.IDA = CStr(parsedProperty.Value)
                        End If
                    Next
                    MODEL_LIST.FILE_LISTs.Add(filelist)
                Next
                Dim chk_del As Boolean = True
                For Each f As FILE_LIST In MODEL_LIST.FILE_LISTs
                    Dim IDA As String = f.IDA
                    If IDA = "" Or IDA = "0" Then 'หมายถึงการ INSERT

                    Else 'หมายถึงมี IDA แสดงว่าไม่มีการปรับ PROCESS จะมี IDA ติด
                        chk_del = False
                    End If
                Next
                'If chk_del = True Then
                '    Dim dao As New DAO.TB_FILE_BOX
                '    dao.GETDATA_BY_TR_ID(TR_ID)
                '    dao.DeleteALL()
                'End If

                'Dim dao_m As New DAO.TB_S_BOX
                'dao_m.GETDATA_BY_TR_ID(TR_ID)
                'Dim version As String = "0"
                'Dim path As String = _PATH_BOX & "\" & TR_ID & "\" & version
                'Directory.CreateDirectory(path)
                'Dim i As Integer = 0
                'For Each f As FILE_LIST In MODEL_LIST.FILE_LISTs
                '    Dim IDA As String = f.IDA
                '    Dim f_path As String = f.PATH
                '    Dim filename As String = f.FILENAME


                '    If IDA = "" Or IDA = "0" Then 'หมายถึงการ INSERT
                '        If f.TYPE = "ADD" Then 'หมายถึงมีการแนบไฟล์
                '            Dim dao_f As New DAO.TB_FILE_BOX
                '            With dao_f.fields
                '                .CREATE_DATE = Date.Now
                '                .FILENAME = filename
                '                .TITEL = f.DES
                '                .TR_ID = TR_ID
                '                .PRIORITY = f.PIORITY
                '            End With
                '            dao_f.insert()

                '            If HAVE_FILE(f_path) = True Then 'กรณีเจอไฟล์
                '                Dim path_file As String = path & "\" & dao_f.fields.IDA & ".pdf"
                '                COPY_FILE(f_path, path_file)
                '                dao_f.fields.PATH_FILE = path_file
                '                dao_f.fields.REF_TR_ID = f_path
                '            End If

                '            dao_f.update()
                '            i = i + 1
                '        Else
                '            Dim dao_f As New DAO.TB_FILE_BOX
                '            With dao_f.fields
                '                .CREATE_DATE = Date.Now
                '                .TITEL = f.DES
                '                .TR_ID = TR_ID
                '                .REMARK = ""
                '                .REF_TR_ID = ""
                '                .PRIORITY = f.PIORITY
                '            End With
                '            dao_f.insert()
                '        End If
                '    Else ' หมายถึง UPDATE
                '        If f.TYPE = "ADD" Then 'หมายถึงมีการแนบไฟล์
                '            Dim dao_f As New DAO.TB_FILE_BOX
                '            dao_f.GETDATA_BY_IDA(IDA)
                '            If HAVE_FILE(f_path) = True Then 'กรณีเจอไฟล์
                '                Dim path_file As String = path & "\" & IDA & ".pdf"
                '                COPY_FILE(f_path, path_file)
                '                With dao_f.fields
                '                    .FILENAME = filename
                '                    .TITEL = f.DES
                '                    .UPDATE_DATE = Date.Now
                '                    .PATH_FILE = path_file
                '                    .REF_TR_ID = f_path
                '                    .PRIORITY = f.PIORITY
                '                End With

                '            Else
                '                With dao_f.fields
                '                    .FILENAME = filename
                '                    .TITEL = f.DES
                '                    .UPDATE_DATE = Date.Now
                '                    .PRIORITY = f.PIORITY
                '                End With
                '            End If
                '            dao_f.update()
                '            i = i + 1
                '        Else
                '            Dim dao_f As New DAO.TB_FILE_BOX
                '            dao_f.GETDATA_BY_IDA(IDA)


                '            If HAVE_FILE(f_path) = True Then 'กรณีเจอไฟล์
                '                Dim path_file As String = path & "\" & dao_f.fields.IDA & ".pdf"
                '                COPY_FILE(f_path, path_file)
                '                With dao_f.fields
                '                    .TITEL = f.DES
                '                    .UPDATE_DATE = Date.Now
                '                    .PRIORITY = f.PIORITY
                '                    .PATH_FILE = path_file
                '                    .REF_TR_ID = f_path
                '                End With
                '            Else
                '                With dao_f.fields
                '                    .TITEL = f.DES
                '                    .UPDATE_DATE = Date.Now
                '                    .PRIORITY = f.PIORITY
                '                End With
                '            End If


                '            dao_f.update()
                '        End If
                '    End If
                'Next
                result = "success"
            Catch ex As Exception
                result = "ERR"
            End Try
            Return result
        End Function
#End Region

#Region "INSERT DATA"
        ''' <summary>
        ''' บันทึกข้อมูลเข้า S_BOX กรณีเป็นนิติบุคคล
        ''' </summary>
        ''' <param name="XML"></param>
        ''' <param name="XML2"></param>
        ''' <returns></returns>
        Function ADD_DATA_INV(ByVal XML As String, ByVal XML2 As String, ByVal TOKEN As String, ByVal CTZNO As String) As JsonResult
            Dim obj = JsonConvert.DeserializeObject(XML)
            'Dim jss As New JavaScriptSerializer
            'Dim bb As MODEL_BOX = jss.Deserialize(XML, GetType(MODEL_BOX))
            Dim result As String = ""
            Dim chk As Boolean = True
            Dim TR_ID As String = ""


            'Dim BSN_NAME As String = ""
            'BSN_NAME = GET_BSN_NAME(bb.BNS_IDENTIFY)
            'If BSN_NAME = "" Or BSN_NAME = "  " Then
            '    msg_r.MSG_CODE = "404"
            '    msg_r.MSG_RESULT = "FAILS"
            '    msg_r.DATA_VALUE = "ไม่พบข้อมูลผู้ดำเนินกิจการในระบบของ อย. กรุณาติดต่อเจ้าหน้าที่"

            '    result = "ไม่พบข้อมูลผู้ดำเนินกิจการในระบบของ อย. กรุณาติดต่อเจ้าหน้าที่"


            'End If
            Return Json(msg_r, JsonRequestBehavior.AllowGet)

        End Function
#End Region

#Region "UPDATE_DATA"
        ''' <summary>
        ''' UPDATE STATUS ของงาน
        ''' </summary>
        ''' <param name="TR_ID"></param>
        ''' <param name="STATUS_ID"></param>
        ''' <returns></returns>
        Function UPDATE_DATA(ByVal TR_ID As String, ByVal STATUS_ID As String, ByVal TOKEN As String, ByVal CTZNO As String) As String

            Dim msg_result As String = ""
            Dim bao_drop As New BAO_DROPBOX
            Dim STATUS_NAME As String = ""
            Dim CHK_DOC As Boolean = True
            Dim RCVNO As Integer = 0






            Return msg_result
        End Function










        Function con_year(year) As String
            Dim int_year As Integer = Integer.Parse(year)
            If int_year <= 2500 Then
                int_year += 543
            End If
            Return int_year.ToString()
        End Function
#End Region
    End Class
End Namespace