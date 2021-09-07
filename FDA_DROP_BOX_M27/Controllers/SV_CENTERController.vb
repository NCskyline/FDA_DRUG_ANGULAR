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

        Function SP_MAS_CHEMICAL_by_IOWANM_AND_AORI(ByVal iowanm As String, ByVal aori As String) As JsonResult
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_MAS_CHEMICAL_by_IOWANM_AND_AORI(iowanm, "A")
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

        Function SP_LOCATION_ADDRESS_by_LOCATION_TYPE_CD_and_LCNSIDV2_1(ByVal LOCATION_TYPE_CD As Integer, ByVal IDENTIFY As String)
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_LOCATION_ADDRESS_by_LOCATION_TYPE_CD_and_LCNSIDV2_1(LOCATION_TYPE_CD, IDENTIFY)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)

        End Function

        Function SP_BSN_LOCATION_ADDRESS_BY_IDA_V2(ByVal IDA As String)
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_BSN_LOCATION_ADDRESS_BY_IDA_V2(IDA)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)

        End Function

        Function SP_LOCATION_ADDRESS_by_LOCATION_TYPE_CD_and_LCNSIDV2_KEEP(ByVal LOCATION_TYPE_CD As Integer, ByVal IDENTIFY As String)
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_LOCATION_ADDRESS_by_LOCATION_TYPE_CD_and_LCNSIDV2(LOCATION_TYPE_CD, IDENTIFY)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)

        End Function
        Function SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(ByVal LOCATION_ADDRESS_IDA As String) As JsonResult
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(LOCATION_ADDRESS_IDA)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)

        End Function

        Function SP_MASTER_CER_PK_BY_FK_IDA(ByVal IDA As String) As JsonResult
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_MASTER_CER_PK_BY_FK_IDA(IDA)
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
        Function SP_PHR_JOB()
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_PHR_JOB()
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)

        End Function

        Function SP_MASTER_DAPHRCD()
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_MASTER_DAPHRCD()
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)

        End Function

        Function bind_ddl_lcn_stat()
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_MASTER_dacscd()
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
        Public Function SP_SYSCHNGWT()
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_SYSCHNGWT()
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        End Function
        '
        Public Function SP_SYSAMPHR()
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_SYSAMPHR()
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        End Function

        Public Function SP_SYSTHMBL()
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_SYSAMPHR()
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        End Function

        Public Function SP_SYSAMPHR_BY_CHNGWTCD(ByVal CHNGWTCD As String)
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_SYSAMPHR_BY_CHNGWTCD(CHNGWTCD)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        End Function

        Public Function SP_SYSTHMBL_BY_CHNGWTCD_AND_AMPHRCD(ByVal CHNGWTCD As String, ByVal AMPHRCD As String)
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_SYSTHMBL_BY_CHNGWTCD_AND_AMPHRCD(CHNGWTCD, AMPHRCD)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        End Function

        Function SP_SYSPREFIX()
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_SYSPREFIX()
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)

        End Function

        Function SP_SYSPREFIX_PERSON()
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_SYSPREFIX_PERSON()
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

        Function SP_GET_DATA_LCN(ByVal CITIZEN As String, ByVal lcnno As String, ByVal PVNCD As Integer) As JsonResult


            Dim dt As New DataTable
            Dim command As String = " "
            Dim bao_aa As New BAO
            command = "select * from dbo.Vw_SP_DALCN_SEARCH_EDIT "


            Dim str_where As String = ""
            Dim dt2 As New DataTable

            If CITIZEN = "" And lcnno = "" Then
                'If pvncd = 10 Then
                '    RadGrid1.DataSource = dt
                'Else
                '    RadGrid1.DataSource = dt.Select("pvncd = '" & pvncd & "'")
                'End If
                command &= str_where
            Else
                If CITIZEN <> "" Then
                    str_where = "where CITIZEN_ID_AUTHORIZE='" & CITIZEN & "'"
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
                    If TbNO.fields.lcntpcd = "ผย1" Then
                        model.CHK_TYPE_LCN = 1
                    ElseIf TbNO.fields.lcntpcd = "นย1" Then
                        model.CHK_TYPE_LCN = 2
                    End If
                Catch ex As Exception

                End Try

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


                Dim dt_name As New DataTable
                Dim bao As New BAO
                dt_name = bao.SP_SYSLCNSNM_BY_LCNSID_AND_IDENTIFY(dao.fields.CITIZEN_ID_AUTHORIZE, 0)
                ''Dim model As New MODEL_LCN

                Dim dt_addr As New DataTable

                dt_addr = bao.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(dao.fields.FK_IDA)
                With model
                    .LCNNO_SHOW = lcnno_format
                    Try
                        .TYPE_IMPORT = dao_dalcntype.fields.lcntpnm
                    Catch ex As Exception

                    End Try

                    For Each dr As DataRow In dt_name.Rows
                        .NAME = dr("thanm")
                    Next

                    For Each dr As DataRow In dt_addr.Rows
                        Try
                            .THANAMEPLACE = dr("thanameplace")
                        Catch ex As Exception

                        End Try
                        Try
                            .FULL_ADDR = dr("fulladdr2")
                        Catch ex As Exception

                        End Try
                        Try
                            .TEL = dr("tel1")
                        Catch ex As Exception

                        End Try
                        Try
                            .FAX = dr("fax")
                        Catch ex As Exception

                        End Try

                    Next


                End With

            Next


            Return Json(model, JsonRequestBehavior.AllowGet)
        End Function
        Function GET_LOCATION_STAFF_EDIT(ByVal IDA As String) As JsonResult
            Dim dt As New DataTable
            Dim bao As New BAO
            Dim dao As New DAO_DRUG.ClsDBdalcn
            dao.GetDataby_IDA(IDA)
            dt = bao.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(dao.fields.FK_IDA)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)

        End Function

        Function SP_MASTER_DALCN_DETAIL_LOCATION_KEEP_BY_IDA(ByVal IDA As String) As JsonResult
            Dim dt As New DataTable
            Dim bao As New BAO

            dt = bao.SP_MASTER_DALCN_DETAIL_LOCATION_KEEP_BY_IDA(IDA)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)

        End Function

        Function SP_LOCATION_BSN_BY_LCN_IDA(ByVal IDA As String) As JsonResult
            Dim dt As New DataTable
            Dim bao As New BAO

            dt = bao.SP_LOCATION_BSN_BY_LCN_IDA(IDA)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)

        End Function

        Function GET_LCNSNM_STAFF_EDIT(ByVal IDA As String) As JsonResult
            Dim dt As New DataTable
            Dim bao As New BAO
            Dim dao As New DAO_DRUG.ClsDBdalcn
            dao.GetDataby_IDA(IDA)
            dt = bao.SP_SYSLCNSNM_BY_LCNSID_AND_IDENTIFYV2(dao.fields.CITIZEN_ID_AUTHORIZE, "0")
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)

        End Function

        Function SP_DALCN_PHR_BY_FK_IDA_2(ByVal IDA As String) As JsonResult
            Dim dt As New DataTable
            Dim bao As New BAO

            dt = bao.SP_DALCN_PHR_BY_FK_IDA_2(IDA)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)

        End Function

        Function GET_PHR_DATA_EDIT(ByVal PHR_IDA As String) As JsonResult
            Dim model As New MODEL_STAFF_EDIT_LCN
            Dim dao As New DAO_DRUG.ClsDBDALCN_PHR
            dao.GetDataby_IDA(PHR_IDA)

            model.DALCN_PHR = dao.fields

            Return Json(model, JsonRequestBehavior.AllowGet)
        End Function
        Function GET_BSN_NEW(ByVal identify As String) As JsonResult
            Dim model As New MODEL_STAFF_EDIT_LCN
            Dim CITIZEN_ID_AUTHORIZE As String = ""
            Try
                CITIZEN_ID_AUTHORIZE = identify
            Catch ex As Exception

            End Try

            Dim ws2 As New WS_Taxno_TaxnoAuthorize.WebService1
            Dim ws_taxno = ws2.getProfile_byidentify(CITIZEN_ID_AUTHORIZE)

            Dim dao_syslcnsid As New DAO_CPN.clsDBsyslcnsid
            dao_syslcnsid.GetDataby_identify(CITIZEN_ID_AUTHORIZE)
            If dao_syslcnsid.fields.IDA = 0 Then
                Response.Write("<script type='text/javascript'>alert('ไม่พบข้อมูล');</script> ")
            Else
                Try
                    model.NEW_BSN_THAIFULLNAME = ws_taxno.SYSLCNSNMs.thanm & " " & ws_taxno.SYSLCNSNMs.thalnm
                Catch ex As Exception

                End Try
                Try
                    model.PHR_NAME = ws_taxno.SYSLCNSNMs.thanm & " " & ws_taxno.SYSLCNSNMs.thalnm
                Catch ex As Exception

                End Try
                Try
                    'dao_bsn.Getdata_by_fk_id2(dao.fields.FK_IDA)
                    Dim bao As New BAO
                    Dim dt As New DataTable
                    dt = bao.SP_BSN_LOCATION_ADDRESS_BY_IDEN_V2(CITIZEN_ID_AUTHORIZE)

                    For Each dr As DataRow In dt.Rows
                        model.NEW_BSN_fulladdr = dr("fulladdr")
                    Next
                Catch ex As Exception

                End Try

            End If
            Return Json(model, JsonRequestBehavior.AllowGet)
        End Function

        Function GET_LCNSNM_NEW(ByVal identify As String) As JsonResult
            Dim model As New MODEL_STAFF_EDIT_LCN
            Dim dao_lcn As New DAO_CPN.clsDBsyslcnsnm
            dao_lcn.GetDataby_identify(identify)

            Dim name As String = "0"
            Try
                name = dao_lcn.fields.ID
            Catch ex As Exception

            End Try
            If name = "0" Then

            Else
                Try
                    model.NEW_LCNNM = dao_lcn.fields.thanm & " " & dao_lcn.fields.thalnm
                Catch ex As Exception

                End Try

            End If
            Return Json(model, JsonRequestBehavior.AllowGet)
        End Function

        Function GET_LCN_NO_STAFF_EDIT(ByVal IDA As Integer) As JsonResult
            Dim model As New MODEL_STAFF_EDIT_LCN
            Dim dao As New DAO_DRUG.ClsDBdalcn
            dao.GetDataby_IDA(IDA)
            Try
                model.dalcn = dao.fields
            Catch ex As Exception

            End Try
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
                Try
                    model.CITIZEN_ID_AUTHORIZE = dao.fields.CITIZEN_ID_AUTHORIZE
                Catch ex As Exception

                End Try

                Dim dt_name As New DataTable
                Dim bao As New BAO
                dt_name = bao.SP_SYSLCNSNM_BY_LCNSID_AND_IDENTIFY(dao.fields.CITIZEN_ID_AUTHORIZE, 0)
                ''Dim model As New MODEL_LCN

                Dim dt_addr As New DataTable

                dt_addr = bao.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(dao.fields.FK_IDA)
                With model
                    .LCNNO_SHOW = lcnno_format
                    Try
                        .TYPE_IMPORT = dao_dalcntype.fields.lcntpnm
                    Catch ex As Exception

                    End Try

                    For Each dr As DataRow In dt_name.Rows
                        .LCNNAME = dr("thanm")
                    Next

                    For Each dr As DataRow In dt_addr.Rows
                        Try
                            .thanameplace = dr("thanameplace")
                        Catch ex As Exception

                        End Try
                        Try
                            .FULL_ADDR = dr("fulladdr2")
                        Catch ex As Exception

                        End Try
                        Try
                            .TEL = dr("tel1")
                        Catch ex As Exception

                        End Try
                        Try
                            .FAX = dr("fax")
                        Catch ex As Exception

                        End Try

                    Next


                End With

            Next
            Try
                Dim dao_bsn As New DAO_DRUG.TB_DALCN_LOCATION_BSN
                dao_bsn.GetDataby_LCN_IDA(IDA)
                model.BSN_THAIFULLNAME = dao_bsn.fields.BSN_THAIFULLNAME

                model.OLD_BSN_THAIFULLNAME = dao_bsn.fields.BSN_THAIFULLNAME
            Catch ex As Exception

            End Try

            Try
                Dim bao_bsn_addr As New BAO
                Dim dt_b As New DataTable
                dt_b = bao_bsn_addr.SP_BSN_LOCATION_ADDRESS_BY_IDA_V2(IDA)

                For Each dr As DataRow In dt_b.Rows
                    model.OLD_BSN_fulladdr = dr("fulladdr")
                Next
            Catch ex As Exception

            End Try
            Dim ccc As String = ""
            Try
                ccc = dao.fields.cnccscd
                'dao.fields.cnccscd = Nothing
                'lbl_statname.Text = dao.fields.
            Catch ex As Exception
                ccc = ""
            End Try
            Try
                model.opentime = dao.fields.opentime
            Catch ex As Exception

            End Try
            If ccc = "" Then
                model.cncnm = "คงอยู่"
            Else
                Try
                    Dim dao_cnc As New DAO_DRUG.ClsDBdacscd
                    dao_cnc.GetData_by_cd(ccc)
                    model.cncnm = dao_cnc.fields.csnm
                Catch ex As Exception

                End Try

            End If

            Try
                model.date_cancel = get_short_month(dao.fields.cncdate)
            Catch ex As Exception

            End Try
            Try
                model.first_appdate = get_short_month(dao.fields.frtappdate)
            Catch ex As Exception

            End Try

            Return Json(model, JsonRequestBehavior.AllowGet)
        End Function
        Function SET_LCN_NO_STAFF_EDIT(ByVal IDA As Integer) As JsonResult
            Dim model As New MODEL_STAFF_EDIT_LCN
            Dim dao As New DAO_DRUG.ClsDBdalcn
            dao.GetDataby_IDA(IDA)
            Try
                model.dalcn = dao.fields
            Catch ex As Exception

            End Try


            Return Json(model, JsonRequestBehavior.AllowGet)
        End Function
        Function GET_DETAIL_CHEM_RQT_STAFF(ByVal IDA_CHEM_RQT As Integer) As JsonResult
            Dim model As New MODEL_CHEMICAL
            Dim dao As New DAO_DRUG.TB_CHEMICAL_REQUEST
            dao.GetDataby_IDA(IDA_CHEM_RQT)
            model.CHEMICAL_REQUEST = dao.fields

            Return Json(model, JsonRequestBehavior.AllowGet)
        End Function
        Function GET_INFORMARION_DH(ByVal LCN_IDA As Integer) As JsonResult
            Dim model As New MODEL_DH
            Dim dao As New DAO_DRUG.ClsDBdalcn
            dao.GetDataby_IDA(LCN_IDA)
            Dim dt_name As New DataTable
            Dim bao As New BAO
            dt_name = bao.SP_SYSLCNSNM_BY_LCNSID_AND_IDENTIFY(dao.fields.CITIZEN_ID_AUTHORIZE, 0)
            Dim dt_addr As New DataTable

            dt_addr = bao.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(dao.fields.FK_IDA)
            With model
                For Each dr As DataRow In dt_name.Rows
                    Try
                        .NAME = dr("thanm")
                    Catch ex As Exception

                    End Try


                Next

                Try
                    If dao.fields.lcntpcd.Contains("ผย") Then
                        .LCN_TYPE = 1
                    ElseIf dao.fields.lcntpcd.Contains("นย") Then
                        .LCN_TYPE = 2
                    End If
                Catch ex As Exception

                End Try
                Dim lcnno_auto As Integer = 0
                Try
                    lcnno_auto = dao.fields.lcnno
                Catch ex As Exception

                End Try
                Try
                    If Len(lcnno_auto) > 0 Then

                        If Right(Left(lcnno_auto, 3), 1) = "5" Then
                            .LCN_NO_DISPLAY = "จ. " & CStr(CInt(Right(lcnno_auto, 4))) & "/25" & Left(lcnno_auto, 2)
                        Else
                            .LCN_NO_DISPLAY = dao.fields.pvnabbr & " " & CStr(CInt(Right(lcnno_auto, 5))) & "/25" & Left(lcnno_auto, 2)
                        End If

                    End If
                Catch ex As Exception

                End Try

                For Each dr As DataRow In dt_addr.Rows
                    Try
                        .thanameplace = dr("thanameplace")
                    Catch ex As Exception

                    End Try
                    Try
                        .FULL_ADDR = dr("fulladdr2")
                    Catch ex As Exception

                    End Try
                    Try
                        .TEL = dr("tel1")
                    Catch ex As Exception

                    End Try
                Next


            End With


            Return Json(model, JsonRequestBehavior.AllowGet)
        End Function

        Function GET_PREVIEW_CERT(ByVal IDA As Integer) As JsonResult
            'IDA = 41941
            Dim DT As DataTable
            Dim model As New MODEL_CER_GMP
            Dim dao_cer As New DAO_DRUG.TB_CER
            Dim dao_chem As New DAO_DRUG.TB_CER_DETAIL_CASCHEMICAL
            Dim dao_manu As New DAO_DRUG.TB_CER_DETAIL_MANUFACTURE
            Dim dao_iso As New DAO_CPN.clsDBsysisocnt
            dao_cer.GetDataby_IDA2(IDA)
            dao_manu.GetDataby_FK_IDA(IDA)
            dao_chem.GetDataby_FK_IDA(IDA)
            Try
                model.CER = dao_cer.fields
            Catch ex As Exception

            End Try
            Try
                model.CER_DETAIL_MANUFACTURE = dao_manu.fields
            Catch ex As Exception

            End Try
            Try
                model.CER_DETAIL_CASCHEMICAL = dao_chem.Details
            Catch ex As Exception

            End Try
            Try
                model.STR_DOCUMENT_DATE = get_short_month(dao_cer.fields.DOCUMENT_DATE)

            Catch ex As Exception

            End Try
            Try
                model.STR_EXP_DOCUMENT_DATE = get_short_month(dao_cer.fields.EXP_DOCUMENT_DATE)

            Catch ex As Exception

            End Try
            Try
                dao_iso.GetDataby_IDA(dao_manu.fields.COUNTRY_GMP)
                model.COUNTRY_GMP_SHOW = dao_iso.fields.engcntnm
            Catch ex As Exception

            End Try
            Try
                dao_iso.GetDataby_IDA(dao_manu.fields.COUNTRY_ID)
                model.COUNTRY_NAME = dao_iso.fields.engcntnm
            Catch ex As Exception

            End Try
            Try
                dao_iso.GetDataby_IDA(dao_cer.fields.COUNTRY_OF_DEPARTMENT_IDA)
                model.COUNTRY_OF_DEPARTMENT_NAME = dao_iso.fields.engcntnm
            Catch ex As Exception

            End Try
            Try
                dao_iso.GetDataby_IDA(dao_cer.fields.BUYER_COUNTRY)
                model.BUYER_COUNTRY_NAME = dao_iso.fields.engcntnm
            Catch ex As Exception

            End Try
            Return Json(model, JsonRequestBehavior.AllowGet)
        End Function
        Function GET_PREVIEW_DH(ByVal IDA As Integer) As JsonResult
            Dim model As New MODEL_DH
            Dim dao As New DAO_DRUG.ClsDBdh15rqt
            dao.GetDataby_IDA(IDA)
            Dim dao_dcer As New DAO_DRUG.TB_DH15_DETAIL_CER
            Dim dao_iso As New DAO_CPN.clsDBsysisocnt
            Try
                dao_dcer.GetDataby_FK_IDA(IDA)
            Catch ex As Exception

            End Try

            Dim dao_c As New DAO_DRUG.TB_CER
            Dim dao_manu As New DAO_DRUG.TB_DH15_DETAIL_MANUFACTURE

            Try
                dao_manu.GetData_by_FK_IDA(IDA)
            Catch ex As Exception

            End Try
            Try
                dao_c.GetDataby_IDA2(dao_dcer.fields.CER_DETAIL_CHEMICAL_IDA)
            Catch ex As Exception

            End Try
            Try
                model.REF_CER_NO = dao_c.fields.CER_FORMAT
            Catch ex As Exception

            End Try
            Try
                model.dh15rqt = dao.fields
            Catch ex As Exception

            End Try
            Try
                model.DH15_DETAIL_CER = dao_dcer.fields
            Catch ex As Exception

            End Try
            Try
                model.DH15_DETAIL_MANUFACTURE = dao_manu.fields
            Catch ex As Exception

            End Try
            Try
                dao_iso.GetDataby_IDA(dao_manu.fields.COUNTRY_ID)
                model.COUNTRY_NAME = dao_iso.fields.engcntnm
            Catch ex As Exception

            End Try
            Try

                dao_iso = New DAO_CPN.clsDBsysisocnt
                dao_iso.GetDataby_IDA(dao.fields.AGENT_COUNTRY_ID)
                model.COUNTRY_NAME = dao_iso.fields.engcntnm
            Catch ex As Exception

            End Try

            Return Json(model, JsonRequestBehavior.AllowGet)
        End Function

        Function GET_LCN_EDIT(ByVal IDA As Integer) As JsonResult
            Dim model As New MODEL_STAFF_EDIT_LCN
            Dim bao As New BAO
            Dim dao As New DAO_DRUG.ClsDBdalcn
            dao.GetDataby_IDA(IDA)
            'Dim dt As New DataTable
            'Try
            '    dt = bao.SP_LOCATION_ADDRESS_by_LOCATION_TYPE_CD_and_LCNSIDV2(2, dao.fields.CITIZEN_ID_AUTHORIZE)
            'Catch ex As Exception

            'End Try
            'For Each dr As DataRow In dt.Rows
            '    Try
            '        model.fulladdr_no_keep = dr("fulladdr_no")
            '    Catch ex As Exception

            '    End Try
            'Next
            Return Json(model, JsonRequestBehavior.AllowGet)
        End Function

        Function GET_REF_CERT_DH(ByVal IDA As Integer) As JsonResult
            Dim model As New MODEL_DH
            Dim bao As New BAO
            'Dim dao As New DAO_DRUG.TB_DH15_DETAIL_CER
            'dao.GetDataby_FK_IDA(IDA)
            Dim dao As New DAO_DRUG.TB_CER



            Try
                dao.GetDataby_IDA2(IDA)
                model.CER = dao.fields
            Catch ex As Exception

            End Try
            Try
                Dim dao_manu As New DAO_DRUG.TB_CER_DETAIL_MANUFACTURE
                dao_manu.GetDataby_FK_IDA(IDA)
                Dim dao_iso As New DAO_CPN.clsDBsysisocnt
                dao_iso.GetDataby_IDA(dao_manu.fields.COUNTRY_ID)
                model.COUNTRY_NAME = dao_iso.fields.engcntnm
            Catch ex As Exception

            End Try
            Try

            Catch ex As Exception

            End Try
            'Dim dt As New DataTable
            'Try
            '    dt = bao.SP_LOCATION_ADDRESS_by_LOCATION_TYPE_CD_and_LCNSIDV2(2, dao.fields.CITIZEN_ID_AUTHORIZE)
            'Catch ex As Exception

            'End Try
            'For Each dr As DataRow In dt.Rows
            '    Try
            '        model.fulladdr_no_keep = dr("fulladdr_no")
            '    Catch ex As Exception

            '    End Try
            'Next
            Return Json(model, JsonRequestBehavior.AllowGet)
        End Function

        Function test_dh() As JsonResult
            Dim model_dhs As New MODEL_DH
            ''model_dhs._CER.TR_ID = 0




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
                _CLS.CITIZEN_ID = "0105522020724" ''"1100400181875" 0105522020724
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

        Function GETDATA_CHEMICAL(ByVal IDA As Integer) As JsonResult
            Dim dao As New DAO_DRUG.TB_CHEMICAL_REQUEST
            dao.GetDataby_IDA(IDA)

            Return Json(dao.fields, JsonRequestBehavior.AllowGet)
        End Function

#End Region

#Region "MODEL DATA"
        Public Function SETMODEL() As JsonResult
            Dim MODEL As New MODEL_BOX


            Return Json(MODEL, JsonRequestBehavior.AllowGet)
        End Function

        Function SETMODEL_DH() As JsonResult

            Dim MODEL As New MODEL_CER_GMP

            Return Json(MODEL, JsonRequestBehavior.AllowGet)
        End Function
        Function SETMODEL_CHEM() As JsonResult
            Dim MODEL As New MODEL_CHEMICAL
            Return Json(MODEL, JsonRequestBehavior.AllowGet)
        End Function

        Function SETMODEL_DHA() As JsonResult

            Dim MODEL As New MODEL_DH

            Return Json(MODEL, JsonRequestBehavior.AllowGet)
        End Function

        Function SETMODEL_EDIT_LCN() As JsonResult

            Dim MODEL As New MODEL_STAFF_EDIT_LCN

            Return Json(MODEL, JsonRequestBehavior.AllowGet)
        End Function
        Function SETMODEL_CHEMICAL() As JsonResult

            Dim MODEL As New MODEL_CHEMICAL

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
            filelist.TYPE = ""
            filelist.SIZE = 0
            MODEL.FILE_LISTs.Add(filelist)
            Return Json(MODEL, JsonRequestBehavior.AllowGet)
        End Function
#End Region

#Region "UPLOAD PDF"
        Public Function UPLOAD_PDF(ByVal PROCESS_ID As String, ByVal TR_ID As String) As JsonResult
            Dim filename As String = ""
            Dim path As String = _PATH_DEFAULT & "\upload\"
            Directory.CreateDirectory(path)
            Dim PATHs As String = ""
            Dim path_file As String = ""
            Dim NAME_REAL As String = ""
            Dim DD As Integer = 1
            Dim Count As Integer = 1
            Try
                For Each s As String In Request.Files
                    NAME_REAL = Request.Files(0).FileName
                    Dim Type As String = IO.Path.GetExtension(Request.Files(0).FileName).ToString()
                    filename = "DA-" & PROCESS_ID & "-" & Date.Now.Year & "-" & TR_ID & "-" & DD & Type
                    path_file = path & filename
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

        Public Function UPLOAD_PDF_CERT(ByVal model As String, ByVal TR_ID As String, ByVal PROCESS_ID As String) As String
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
                        ElseIf propertyName = "FILE_DATA" Then
                            filelist.FILE_DATA = CStr(parsedProperty.Value)
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
                Dim path As String = "F:\path\DRUG\upload\" ''_PATH_DEFAULT & "\upload\"
                Directory.CreateDirectory(path) 'สร้าง PATH รอ
                Dim i As Integer = 0

                For Each s As String In Request.Files
                    NAME_REAL = Request.Files(0).FileName
                    Dim Type As String = IO.Path.GetExtension(Request.Files(0).FileName).ToString()
                    filename = "DA-" & PROCESS_ID & "-" & Date.Now.Year & "-" & TR_ID & "-" & DD & Type
                    path_file = path & filename
                    Dim postedFile As HttpPostedFileBase = Request.Files(0)

                    postedFile.SaveAs(path_file)
                Next

                For Each f As FILE_LIST In MODEL_LIST.FILE_LISTs

                    Dim dao As New DAO_DRUG.ClsDBFILE_ATTACH
                    dao.GetDataby_TR_ID_And_Process(TR_ID, PROCESS_ID)
                    If dao.Details.Count <> 0 Then
                        DD = dao.Details.Count + 1
                    End If
                    Dim filepath As String = f.PATH
                    NAME_REAL = f.FILENAME
                    Dim Type As String = IO.Path.GetExtension(f.FILENAME).ToString()
                    filename = "DA-" & PROCESS_ID & "-" & Date.Now.Year & "-" & TR_ID & "-" & DD & Type
                    path_file = path & filename

                    'Dim postedFile As HttpPostedFileBase = Request.Files(0)
                    'postedFile.SaveAs(path_file)

                    Dim dao_f As New DAO_DRUG.ClsDBFILE_ATTACH
                    With dao_f.fields
                        .NAME_FAKE = filename
                        .NAME_REAL = NAME_REAL
                        .TYPE = DD
                        .TRANSACTION_ID = TR_ID
                        .DESCRIPTION = ""
                        .PROCESS_ID = PROCESS_ID
                    End With
                    dao_f.insert()

                Next
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
            Dim jss As New JavaScriptSerializer
            Dim bb As MODEL_BOX = jss.Deserialize(XML, GetType(MODEL_BOX))
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
        Function INSERT_CHEM_RQT(ByVal XML_CHEM As String, ByVal _ProcessID As String, ByVal FK_IDA As Integer, ByVal MAIN_TYPE As Integer, ByVal SUB_TYPE As Integer, ByVal aori As String) As JsonResult
            Dim jss As New JavaScriptSerializer
            Dim bb As MODEL_CHEMICAL = jss.Deserialize(XML_CHEM, GetType(MODEL_CHEMICAL))

            Dim dao As New DAO_DRUG.TB_CHEMICAL_REQUEST


            Dim jss2 As New JavaScriptSerializer


            'Dim dao2 As New DAO_DRUG.TB_CHEMICAL_REQUEST
            dao.Details = jss2.Deserialize(XML_CHEM, GetType(List(Of CHEMICAL_REQUEST)))
            dao.fields.REQUEST_DATE = Date.Now
            'Try
            '    dao.fields.iowanm = dao2.fields.iowanm
            'Catch ex As Exception

            'End Try
            'Try
            '    dao.fields.DESCRIPTION_OTHER = dao2.fields.DESCRIPTION_OTHER
            'Catch ex As Exception

            'End Try
            'Try
            '    dao.fields.cas_number = dao2.fields.cas_number
            'Catch ex As Exception

            'End Try
            'Try
            '    dao.fields.INN = dao2.fields.INN
            'Catch ex As Exception

            'End Try
            'Try
            '    dao.fields.EMAIL = dao2.fields.EMAIL
            'Catch ex As Exception

            'End Try
            'Try
            '    dao.fields.TEL = dao2.fields.TEL
            'Catch ex As Exception

            'End Try
            'Try
            '    dao.fields.INN_TH = dao2.fields.INN_TH
            'Catch ex As Exception

            'End Try

            Try
                dao.fields.FK_IDA = FK_IDA
            Catch ex As Exception

            End Try
            Try
                dao.fields.IDENTIFY = bb.session.CITIZEN_ID
            Catch ex As Exception

            End Try
            Try
                dao.fields.CITIZEN_ID_AUTHORIZE = bb.session.CITIZEN_ID_AUTHORIZE
            Catch ex As Exception

            End Try
            Try
                dao.fields.PROCESS_ID = _ProcessID
            Catch ex As Exception

            End Try
            dao.fields.STATUS_ID = 1
            dao.fields.MAIN_TYPE = MAIN_TYPE 'Request.QueryString("mt")
            dao.fields.SUB_TYPE = SUB_TYPE 'Request.QueryString("st")
            dao.fields.aori = aori 'Request.QueryString("t")
            Try
                dao.fields.PROCESS_ID = _ProcessID 'Request.QueryString("process")
            Catch ex As Exception

            End Try
            dao.insert()

            Return Json(msg_r, JsonRequestBehavior.AllowGet)
        End Function

        Function UPDATE_CHEM_RQT(ByVal XML_CHEM As String, ByVal IDA As Integer) As JsonResult
            Dim jss As New JavaScriptSerializer
            Dim bb As MODEL_CHEMICAL = jss.Deserialize(XML_CHEM, GetType(MODEL_CHEMICAL))

            Dim dao As New DAO_DRUG.TB_CHEMICAL_REQUEST
            dao.GetDataby_IDA(IDA)

            Dim jss2 As New JavaScriptSerializer


            'Dim dao2 As New DAO_DRUG.TB_CHEMICAL_REQUEST
            Try
                dao.Details = jss2.Deserialize(XML_CHEM, GetType(List(Of CHEMICAL_REQUEST)))

                dao.update()
            Catch ex As Exception

            End Try


            Return Json(msg_r, JsonRequestBehavior.AllowGet)
        End Function

        'Function INSERT_LCN_EDIT(ByVal XML_EDIT As String, ByVal _ProcessID As String) As JsonResult
        '    Dim jss As New JavaScriptSerializer
        '    Dim bb As MODEL_LCN = jss.Deserialize(XML_EDIT, GetType(MODEL_LCN))

        '    Dim bao_tran As New BAO
        '    Dim tr_id As Integer = 0
        '    tr_id = bao_tran.insert_transection_new(_ProcessID, bb.session.CITIZEN_ID, bb.session.CITIZEN_ID_AUTHORIZE)
        '    Dim dao As New DAO_DRUG.TB_DALCN_EDIT_REQUEST
        '    dao.fields.PROCESS_ID = _ProcessID
        '    dao.fields = bb.DALCN_EDIT_REQUEST
        '    dao.fields.TR_ID = tr_id

        '    dao.insert()



        '    Return Json(msg_r, JsonRequestBehavior.AllowGet)
        'End Function
        Function INSERT_CERT_GMP(ByVal XML_CERT As String, ByVal XML_CHEM As String, ByVal _ProcessID As String, ByVal model As String) As JsonResult
            Dim jss As New JavaScriptSerializer
            Dim bb As MODEL_CER_GMP = jss.Deserialize(XML_CERT, GetType(MODEL_CER_GMP))

            'Dim bbm As MODEL_CER_GMP = jss.Deserialize(XML_MANUFAC, GetType(MODEL_CER_GMP))
            'Dim bbc As MODEL_CER_GMP = jss.Deserialize(XML_CHEM, GetType(MODEL_CER_GMP))


            Dim bao_tran As New BAO
            Dim tr_id As Integer = 0
            tr_id = bao_tran.insert_transection_new(_ProcessID, bb.session.CITIZEN_ID, bb.session.CITIZEN_ID_AUTHORIZE)
            Dim dao As New DAO_DRUG.TB_CER

            dao.fields = bb.CER
            dao.fields.PROCESS_ID = _ProcessID
            dao.fields.TR_ID = tr_id
            dao.insert()

            Dim IDA As Integer = dao.fields.IDA

            Dim dao_manu As New DAO_DRUG.TB_CER_DETAIL_MANUFACTURE
            dao_manu.fields = bb.CER_DETAIL_MANUFACTURE
            dao_manu.fields.FK_IDA = IDA
            dao_manu.insert()
            Dim dao_chem As New DAO_DRUG.TB_CER_DETAIL_CASCHEMICAL
            Dim jss2 As New JavaScriptSerializer
            dao_chem.Details = jss2.Deserialize(XML_CHEM, GetType(List(Of CER_DETAIL_CASCHEMICAL)))
            Dim i As Integer = 1
            '''สาร
            For Each dao_chem.fields In dao_chem.Details


                Dim dao_chem1 As New DAO_DRUG.TB_CER_DETAIL_CASCHEMICAL
                With dao_chem1.fields
                    Try
                        .CAS_ID = dao_chem.fields.CAS_ID
                    Catch ex As Exception

                    End Try
                    Try
                        .CAS_NAME = dao_chem.fields.CAS_NAME
                    Catch ex As Exception

                    End Try
                    Try
                        .CAS_NO = dao_chem.fields.CAS_NO
                    Catch ex As Exception

                    End Try
                    Try
                        .INN_NAME = dao_chem.fields.INN_NAME
                    Catch ex As Exception

                    End Try
                    .FK_IDA = IDA
                    .ROW_ID = i
                    .TR_ID = tr_id
                End With
                dao_chem1.insert()
                i += 1
            Next

            msg_r.TR_ID = dao.fields.TR_ID
            msg_r.PROCESS = dao.fields.PROCESS_ID

            Return Json(msg_r, JsonRequestBehavior.AllowGet)
        End Function

        Function INSERT_DH(ByVal XML_DH As String, ByVal _ProcessID As String) As JsonResult

            Dim Result As String

            Try
                Dim jss As New JavaScriptSerializer
                Dim bb As MODEL_DH = jss.Deserialize(XML_DH, GetType(MODEL_DH))
                Dim bao_tran As New BAO
                Dim tr_id As Integer = 0

                tr_id = bao_tran.insert_transection_new(_ProcessID, bb.session.CITIZEN_ID, bb.session.CITIZEN_ID_AUTHORIZE)
                Dim dao As New DAO_DRUG.ClsDBdh15rqt

                dao.fields = bb.dh15rqt
                dao.fields.TR_ID = tr_id
                dao.fields.IDENTIFY = bb.session.CITIZEN_ID_AUTHORIZE
                If _ProcessID = 14 Then
                    dao.fields.QUOTA_TYPE = "00"
                ElseIf _ProcessID = 15 Then
                    dao.fields.QUOTA_TYPE = "01"
                ElseIf _ProcessID = 16 Then
                    dao.fields.QUOTA_TYPE = "00"
                ElseIf _ProcessID = 17 Then
                    dao.fields.QUOTA_TYPE = "01"
                ElseIf _ProcessID = 18 Then
                    dao.fields.QUOTA_TYPE = "00"
                End If



                dao.insert()


                Dim IDA As Integer = dao.fields.IDA

                Dim dao_DH15_DETAIL_MANUFACTURE_CER As New DAO_DRUG.TB_DH15_DETAIL_MANUFACTURE
                Dim dao_CER_DETAIL_MANUFACTURE As New DAO_DRUG.TB_CER_DETAIL_MANUFACTURE
                dao_CER_DETAIL_MANUFACTURE.GetDataby_FK_IDA(bb.DH15_DETAIL_CER.CER_DETAIL_CHEMICAL_IDA)

                dao_DH15_DETAIL_MANUFACTURE_CER.fields.TR_ID = tr_id
                dao_DH15_DETAIL_MANUFACTURE_CER.fields.FK_IDA = IDA
                dao_DH15_DETAIL_MANUFACTURE_CER.fields.ADDRESS_CITY = dao_CER_DETAIL_MANUFACTURE.fields.ADDRESS_CITY
                dao_DH15_DETAIL_MANUFACTURE_CER.fields.ADDRESS_NUMBER = dao_CER_DETAIL_MANUFACTURE.fields.ADDRESS_NUMBER
                dao_DH15_DETAIL_MANUFACTURE_CER.fields.CER_DATE = dao_CER_DETAIL_MANUFACTURE.fields.CER_DATE
                dao_DH15_DETAIL_MANUFACTURE_CER.fields.COMPANY_NAME = dao_CER_DETAIL_MANUFACTURE.fields.COMPANY_NAME
                dao_DH15_DETAIL_MANUFACTURE_CER.fields.COUNTRY = dao_CER_DETAIL_MANUFACTURE.fields.COUNTRY
                dao_DH15_DETAIL_MANUFACTURE_CER.fields.COUNTRY_GMP = dao_CER_DETAIL_MANUFACTURE.fields.COUNTRY_GMP
                dao_DH15_DETAIL_MANUFACTURE_CER.fields.COUNTRY_ID = dao_CER_DETAIL_MANUFACTURE.fields.COUNTRY_ID
                dao_DH15_DETAIL_MANUFACTURE_CER.fields.GLN = dao_CER_DETAIL_MANUFACTURE.fields.GLN
                dao_DH15_DETAIL_MANUFACTURE_CER.fields.LOCATION_STANDARD = dao_CER_DETAIL_MANUFACTURE.fields.LOCATION_STANDARD
                dao_DH15_DETAIL_MANUFACTURE_CER.fields.NAME_ADDRESS = dao_CER_DETAIL_MANUFACTURE.fields.NAME_ADDRESS
                dao_DH15_DETAIL_MANUFACTURE_CER.fields.SALE_DATE = dao_CER_DETAIL_MANUFACTURE.fields.SALE_DATE
                dao_DH15_DETAIL_MANUFACTURE_CER.fields.STANDARD_ID = dao_CER_DETAIL_MANUFACTURE.fields.STANDARD_ID
                dao_DH15_DETAIL_MANUFACTURE_CER.fields.ZIPCODE = dao_CER_DETAIL_MANUFACTURE.fields.ZIPCODE

                dao_DH15_DETAIL_MANUFACTURE_CER.insert()
                Result = "success"
            Catch ex As Exception
                Result = "false"
            End Try

            Return Json(Result, JsonRequestBehavior.AllowGet)
        End Function

        Function INSERT_LCN_EDIT_RQT(ByVal XML_EDIT As String, ByVal _ProcessID As String) As JsonResult

            Dim Result As String = ""
            Dim jss As New JavaScriptSerializer
            Dim bb As MODEL_LCN = jss.Deserialize(XML_EDIT, GetType(MODEL_LCN))
            Dim bao_tran As New BAO
            Dim tr_id As Integer = 0

            tr_id = bao_tran.insert_transection_new(_ProcessID, bb.session.CITIZEN_ID, bb.session.CITIZEN_ID_AUTHORIZE)
            Dim dao As New DAO_DRUG.TB_DALCN_EDIT_REQUEST

            dao.fields = bb.DALCN_EDIT_REQUEST
            dao.fields.TR_ID = tr_id
            dao.fields.CITIZEN_ID_AUTHORIZE = bb.session.CITIZEN_ID_AUTHORIZE
            dao.fields.PROCESS_ID = _ProcessID
            dao.insert()

            Return Json(Result, JsonRequestBehavior.AllowGet)
        End Function
        Function INSERT_PHR(ByVal XML_PHR As String, ByVal LCN_IDA As Integer, ByVal CITIZEN_ID As String, ByVal CITIZEN_ID_AUTHORIZE As String) As JsonResult
            Dim Result As String = ""
            Dim jss As New JavaScriptSerializer
            Dim bb As MODEL_STAFF_EDIT_LCN = jss.Deserialize(XML_PHR, GetType(MODEL_STAFF_EDIT_LCN))
            Dim dao_phr As New DAO_DRUG.ClsDBDALCN_PHR
            Try
                dao_phr.fields = bb.DALCN_PHR
                dao_phr.fields.FK_IDA = LCN_IDA
                Try
                    If bb.DALCN_PHR.PERSONAL_TYPE = "12" Or bb.DALCN_PHR.PERSONAL_TYPE = "15" Then
                        dao_phr.fields.PHR_MEDICAL_TYPE = 3
                    End If
                Catch ex As Exception

                End Try
                Try
                    Dim dao_pre As New DAO_CPN.TB_sysprefix
                    dao_pre.Getdata_byid(bb.DALCN_PHR.PHR_PREFIX_ID)
                    dao_phr.fields.PHR_PREFIX_NAME = dao_pre.fields.thanm
                Catch ex As Exception

                End Try
                dao_phr.insert()
            Catch ex As Exception

            End Try

            Return Json(Result, JsonRequestBehavior.AllowGet)
        End Function
        Function INSERT_LCN_STAFF_EDIT_KEEP(ByVal KEEP_ID As Integer, ByVal LCN_IDA As Integer, ByVal CITIZEN_ID As String, ByVal CITIZEN_ID_AUTHORIZE As String)
            Dim Result As String = ""
            'Dim jss As New JavaScriptSerializer
            'Dim bb As MODEL_STAFF_EDIT_LCN = jss.Deserialize(XML_EDIT, GetType(MODEL_STAFF_EDIT_LCN))
            Try
                'Dim dao_keep As New DAO_DRUG.TB_DALCN_DETAIL_LOCATION_KEEP
                'dao_keep.GetData_by_LCN_IDA(Request.QueryString("ida"))
                'If dao_keep.fields.IDA <> 0 Then
                '    dao_keep.delete()
                'End If
                Dim _IDA_lo As String = ""
                Try
                    _IDA_lo = KEEP_ID
                Catch ex As Exception

                End Try
                If _IDA_lo = "0" Then
                    _IDA_lo = "89791"
                ElseIf _IDA_lo = "" Then
                    _IDA_lo = "0"
                End If

                Dim dao_DALCN_DETAIL_LOCATION_KEEP As New DAO_DRUG.TB_DALCN_DETAIL_LOCATION_KEEP
                Dim dao_LOCATION_ADDRESS_2 As New DAO_DRUG.TB_DALCN_LOCATION_ADDRESS
                dao_LOCATION_ADDRESS_2.GetDataby_IDA(_IDA_lo)
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_Branch = dao_LOCATION_ADDRESS_2.fields.Branch
                Try
                    dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_chngwtcd = dao_LOCATION_ADDRESS_2.fields.chngwtcd
                Catch ex As Exception

                End Try
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_CITIZEN_ID = CITIZEN_ID

                Try
                    dao_DALCN_DETAIL_LOCATION_KEEP.fields.TR_ID = 0
                Catch ex As Exception

                End Try
                Try
                    dao_DALCN_DETAIL_LOCATION_KEEP.fields.FK_IDA = LCN_IDA
                Catch ex As Exception

                End Try
                Try
                    dao_DALCN_DETAIL_LOCATION_KEEP.fields.LCN_IDA = LCN_IDA
                Catch ex As Exception

                End Try

                dao_DALCN_DETAIL_LOCATION_KEEP.fields.IDENTIFY = CITIZEN_ID_AUTHORIZE
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_thathmblnm = dao_LOCATION_ADDRESS_2.fields.thanameplace
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_thaaddr = dao_LOCATION_ADDRESS_2.fields.thaaddr
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_thasoi = dao_LOCATION_ADDRESS_2.fields.thasoi
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_tharoad = dao_LOCATION_ADDRESS_2.fields.tharoad
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_thamu = dao_LOCATION_ADDRESS_2.fields.thamu
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_thathmblnm = dao_LOCATION_ADDRESS_2.fields.thathmblnm
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_thaamphrnm = dao_LOCATION_ADDRESS_2.fields.thaamphrnm
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_thachngwtnm = dao_LOCATION_ADDRESS_2.fields.thachngwtnm
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_tel = dao_LOCATION_ADDRESS_2.fields.tel
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_fax = dao_LOCATION_ADDRESS_2.fields.fax
                If _IDA_lo = "0" Or _IDA_lo = "" Then
                    dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_thanameplace = "ไม่มีสถานที่เก็บ"
                Else
                    dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_thanameplace = dao_LOCATION_ADDRESS_2.fields.thanameplace
                End If

                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_thaaddr = dao_LOCATION_ADDRESS_2.fields.thaaddr
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_thasoi = dao_LOCATION_ADDRESS_2.fields.thasoi
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_tharoad = dao_LOCATION_ADDRESS_2.fields.tharoad
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_thamu = dao_LOCATION_ADDRESS_2.fields.thamu
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_thathmblnm = dao_LOCATION_ADDRESS_2.fields.thathmblnm
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_thaamphrnm = dao_LOCATION_ADDRESS_2.fields.thaamphrnm
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_thachngwtnm = dao_LOCATION_ADDRESS_2.fields.thachngwtnm
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_tel = dao_LOCATION_ADDRESS_2.fields.tel
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_fax = dao_LOCATION_ADDRESS_2.fields.fax
                Try
                    dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_lcnsid = dao_LOCATION_ADDRESS_2.fields.lcnsid
                Catch ex As Exception

                End Try

                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_engaddr = dao_LOCATION_ADDRESS_2.fields.engaddr
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_tharoom = dao_LOCATION_ADDRESS_2.fields.tharoom
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_thabuilding = dao_LOCATION_ADDRESS_2.fields.thabuilding
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_engsoi = dao_LOCATION_ADDRESS_2.fields.engsoi
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_engroad = dao_LOCATION_ADDRESS_2.fields.engroad
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_zipcode = dao_LOCATION_ADDRESS_2.fields.zipcode
                Try
                    dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_lstfcd = dao_LOCATION_ADDRESS_2.fields.lstfcd
                Catch ex As Exception

                End Try
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_lmdfdate = dao_LOCATION_ADDRESS_2.fields.lmdfdate
                Try
                    dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_IDA = dao_LOCATION_ADDRESS_2.fields.IDA
                Catch ex As Exception

                End Try
                Try
                    dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_FK_IDA = dao_LOCATION_ADDRESS_2.fields.FK_IDA
                Catch ex As Exception

                End Try
                Try
                    dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_TR_ID = dao_LOCATION_ADDRESS_2.fields.TR_ID
                    dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_DOWN_ID = dao_LOCATION_ADDRESS_2.fields.DOWN_ID
                Catch ex As Exception

                End Try
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_CITIZEN_ID = dao_LOCATION_ADDRESS_2.fields.CITIZEN_ID
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_CITIZEN_ID_UPLOAD = dao_LOCATION_ADDRESS_2.fields.CITIZEN_ID_UPLOAD
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_XMLNAME = dao_LOCATION_ADDRESS_2.fields.XMLNAME
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_engmu = dao_LOCATION_ADDRESS_2.fields.engmu
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_engfloor = dao_LOCATION_ADDRESS_2.fields.engfloor
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_engbuilding = dao_LOCATION_ADDRESS_2.fields.engbuilding
                Try
                    dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_rcvno = dao_LOCATION_ADDRESS_2.fields.rcvno
                    dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_rcvdate = dao_LOCATION_ADDRESS_2.fields.rcvdate
                Catch ex As Exception

                End Try
                Try
                    dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_lctcd = dao_LOCATION_ADDRESS_2.fields.lctcd
                    dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_STATUS_ID = dao_LOCATION_ADDRESS_2.fields.STATUS_ID
                Catch ex As Exception

                End Try


                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_engnameplace = dao_LOCATION_ADDRESS_2.fields.engnameplace

                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_HOUSENO = dao_LOCATION_ADDRESS_2.fields.HOUSENO
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_Branch = dao_LOCATION_ADDRESS_2.fields.Branch
                Try
                    dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_LOCATION_TYPE_NORMAL = dao_LOCATION_ADDRESS_2.fields.LOCATION_TYPE_NORMAL
                    dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_LOCATION_TYPE_OTHER = dao_LOCATION_ADDRESS_2.fields.LOCATION_TYPE_OTHER
                Catch ex As Exception

                End Try

                Try
                    dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_LOCATION_TYPE_ID = dao_LOCATION_ADDRESS_2.fields.LOCATION_TYPE_ID
                Catch ex As Exception

                End Try
                Try
                    dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_thmblcd = dao_LOCATION_ADDRESS_2.fields.thmblcd
                    dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_chngwtcd = dao_LOCATION_ADDRESS_2.fields.chngwtcd
                Catch ex As Exception

                End Try
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_SYSTEM_NAME = dao_LOCATION_ADDRESS_2.fields.SYSTEM_NAME
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_engthmblnm = dao_LOCATION_ADDRESS_2.fields.engthmblnm
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_engamphrnm = dao_LOCATION_ADDRESS_2.fields.engamphrnm
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_engchngwtnm = dao_LOCATION_ADDRESS_2.fields.engchngwtnm
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_IDENTIFY = dao_LOCATION_ADDRESS_2.fields.IDENTIFY
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_REMARK = dao_LOCATION_ADDRESS_2.fields.REMARK
                dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_Mobile = dao_LOCATION_ADDRESS_2.fields.Mobile
                dao_DALCN_DETAIL_LOCATION_KEEP.insert()

                'KEEP_LOGS_EDIT(LCN_IDA, "เพิ่มสถานที่เก็บใหม่", CITIZEN_ID)

                'Dim ws_update126 As New WS_DRUG_126.WS_DRUG
                'ws_update126.DRUG_UPDATE_LICEN_126(LCN_IDA, CITIZEN_ID)




            Catch ex As Exception

            End Try
            Return Json(Result, JsonRequestBehavior.AllowGet)
        End Function


        Function INSERT_LCN_SUBTITUTE(ByVal XML_SUB As String, ByVal _ProcessID As String) As JsonResult

            Dim Result As String = ""
            Dim jss As New JavaScriptSerializer
            Dim bb As MODEL_LCN = jss.Deserialize(XML_SUB, GetType(MODEL_LCN))
            Dim bao_tran As New BAO
            Dim tr_id As Integer = 0

            tr_id = bao_tran.insert_transection_new(_ProcessID, bb.session.CITIZEN_ID, bb.session.CITIZEN_ID_AUTHORIZE)
            Dim dao As New DAO_DRUG.TB_DALCN_NCT_SUBSTITUTE

            dao.fields = bb.DALCN_NCT_SUBSTITUTE
            dao.fields.TR_ID = tr_id
            dao.fields.IDENTIFY = bb.session.CITIZEN_ID_AUTHORIZE
            dao.fields.PROCESS_ID = _ProcessID

            dao.insert()

            Return Json(Result, JsonRequestBehavior.AllowGet)
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


        Function UPDATE_NAME_LCNS(ByVal LCN_IDA As Integer, ByVal CITIZEN_ID As String, ByVal CITIZEN_ID_AUTHORIZE As String)
            Dim Result As String = ""
            Dim dao As New DAO_DRUG.ClsDBdalcn
            dao.GetDataby_IDA(LCN_IDA)
            If dao.fields.CITIZEN_ID_AUTHORIZE <> "" Then
                Dim ws2 As New WS_Taxno_TaxnoAuthorize.WebService1
                Dim a As String = ""
                Try
                    a = ws2.insert_taxno_authorize(dao.fields.CITIZEN_ID_AUTHORIZE)
                Catch ex As Exception

                End Try
                Try
                    a = ws2.insert_taxno(dao.fields.CITIZEN_ID_AUTHORIZE)
                Catch ex As Exception

                End Try
                Try
                    Dim ws1 As New WS_FDA_CITIZEN.WS_FDA_CITIZEN
                    ws1.FDA_CITIZEN(dao.fields.CITIZEN_ID_AUTHORIZE, "1102001745831", "fusion", "P@ssw0rdfusion440")
                Catch ex As Exception

                End Try
                Try
                    Dim ws3 As New WS_TRADERS.WS_TRADER
                    ws3.CallWS_TRADER("fusion", "P@ssw0rdfusion440", dao.fields.CITIZEN_ID_AUTHORIZE)
                Catch ex As Exception

                End Try

            End If


            KEEP_LOGS_EDIT(LCN_IDA, "อัพเดตข้อมูลผู้รับอนุญาต - " & dao.fields.CITIZEN_ID_AUTHORIZE, CITIZEN_ID, url:="")

            Return Json(Result, JsonRequestBehavior.AllowGet)
        End Function

        Function UPDATE_PHR(ByVal PHR_IDA As String, ByVal XML_PHR As String, ByVal LCN_IDA As Integer, ByVal CITIZEN_ID As String, ByVal CITIZEN_ID_AUTHORIZE As String) As JsonResult
            Dim Result As String = ""
            Dim jss As New JavaScriptSerializer
            Dim bb As MODEL_STAFF_EDIT_LCN = jss.Deserialize(XML_PHR, GetType(MODEL_STAFF_EDIT_LCN))
            Dim dao_phr As New DAO_DRUG.ClsDBDALCN_PHR
            dao_phr.GetDataby_IDA(PHR_IDA)


            With dao_phr.fields
                .PHR_NAME = bb.DALCN_PHR.PHR_NAME
                .PHR_LEVEL = bb.DALCN_PHR.PHR_LEVEL
                .PHR_PREFIX_ID = bb.DALCN_PHR.PHR_PREFIX_ID
                .PHR_PREFIX_NAME = bb.DALCN_PHR.PHR_PREFIX_NAME
                .PHR_CTZNO = bb.DALCN_PHR.PHR_CTZNO
                .PHR_TEXT_NUM = bb.DALCN_PHR.PHR_TEXT_NUM
                .PHR_TEXT_WORK_TIME = bb.DALCN_PHR.PHR_TEXT_WORK_TIME
                .PHR_VETERINARY_FIELD = bb.DALCN_PHR.PHR_VETERINARY_FIELD
                Try
                    .PHR_LAW_SECTION = bb.DALCN_PHR.PHR_LAW_SECTION
                Catch ex As Exception

                End Try

                Try
                    .PHR_JOB_TYPE = bb.DALCN_PHR.PHR_JOB_TYPE
                Catch ex As Exception

                End Try
                Try
                    Dim dao_pre As New DAO_CPN.TB_sysprefix
                    dao_pre.Getdata_byid(bb.DALCN_PHR.PHR_PREFIX_ID)
                    .PHR_PREFIX_NAME = dao_pre.fields.thanm
                Catch ex As Exception

                End Try
                Try
                    .PERSONAL_TYPE = bb.DALCN_PHR.PERSONAL_TYPE 'rdl_per_type.SelectedValue
                Catch ex As Exception

                End Try
                Try
                    If bb.DALCN_PHR.PERSONAL_TYPE = "12" Or bb.DALCN_PHR.PERSONAL_TYPE = "15" Then
                        dao_phr.fields.PHR_MEDICAL_TYPE = 3
                    End If
                Catch ex As Exception

                End Try
                Try
                    .PHR_TEXT_JOB = bb.DALCN_PHR.PHR_TEXT_JOB
                Catch ex As Exception

                End Try
                Try
                    .PHR_MEDICAL_TYPE = bb.DALCN_PHR.PHR_MEDICAL_TYPE
                Catch ex As Exception

                End Try
            End With

            dao_phr.update()

            KEEP_LOGS_EDIT(PHR_IDA, "แก้ไขผู้ปฏิบัติการจาก " & dao_phr.fields.PHR_NAME & " เป็น " & bb.DALCN_PHR.PHR_NAME, CITIZEN_ID, url:="")
            Return Json(Result, JsonRequestBehavior.AllowGet)
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