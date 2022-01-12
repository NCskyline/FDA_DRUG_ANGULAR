Imports System.Web.Mvc
Imports System.Web.Script.Serialization
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Namespace Controllers
    Public Class DRController
        Inherits Controller

        ' GET: DR
        Function Index() As ActionResult
            Return View()
        End Function
        Function INPUT_CONDITION() As ActionResult
            Return View()
        End Function
        Function INPUT_DETAIL_USE() As ActionResult
            Return View()
        End Function
        Function INPUT_DRUG_ANIMAL() As ActionResult
            Return View()
        End Function
        Function INPUT_DRUG_KEEP() As ActionResult
            Return View()
        End Function
        Function INPUT_DTB() As ActionResult
            Return View()
        End Function
        Function INPUT_EQTO() As ActionResult
            Return View()
        End Function
        Function INPUT_GENERAL() As ActionResult
            Return View()
        End Function
        Function INPUT_NOUSE() As ActionResult
            Return View()
        End Function
        Function INPUT_PRODUCCER() As ActionResult
            Return View()
        End Function
        Function INPUT_CHEM() As ActionResult
            Return View()
        End Function
        Function INPUT_PRODUCCER_IN() As ActionResult
            Return View()
        End Function
        Function INPUT_PACKAGE_DETAIL2() As ActionResult
            Return View()
        End Function
        Function INPUT_ATC() As ActionResult
            Return View()
        End Function
        Function INPUT_SUB_DRUG_ANIMAL() As ActionResult
            Return View()
        End Function
        Function INPUT_NAME_DRUG_EXPORT() As ActionResult
            Return View()
        End Function

        Function TABEAN_YA_MAIN() As ActionResult
            Return View()
        End Function
        Function FRM_RQT_REGIST_INFORMATION() As ActionResult
            Return View()
        End Function
        Function FRM_MAIN_PAGE_PRODUCT() As ActionResult
            Return View()
        End Function
        Function TABEAN_YA_MAIN_STAFF() As ActionResult
            Return View()
        End Function
        Function FRM_SEARCH_LCN() As ActionResult
            Return View()
        End Function
        Function FRM_REGISTRATION_MAIN() As ActionResult
            Return View()
        End Function
        Function INPUT_YOR_1() As ActionResult
            Return View()
        End Function
        Function INPUT_YOR_3() As ActionResult
            Return View()
        End Function
        Function PREVIEW_INPUT_YOR_3() As ActionResult
            Return View()
        End Function
        Function FRM_DR_TRANSFER_DL() As ActionResult
            Return View()
        End Function
        Function INPUT_RECLASS() As ActionResult
            Return View()
        End Function
        Function INPUT_RECLASS_ATTACH() As ActionResult
            Return View()
        End Function
        Function FRM_RECLASS_MAIN() As ActionResult
            Return View()
        End Function
        Function FRM_RGT_SELECT() As ActionResult
            Return View()
        End Function
        Function PREVIEW_RECLASS() As ActionResult
            Return View()
        End Function
        Function FRM_DR_CONFIRM() As ActionResult
            Return View()
        End Function
        Function FRM_DR_STAFF_CHECK_RQT() As ActionResult
            Return View()
        End Function
        Function FRM_SUBSTITUTE_TABEAN_MAIN() As ActionResult
            Return View()
        End Function
        Function FRM_SUBSTITUTE_CONFIRM() As ActionResult
            Return View()
        End Function


    End Class

    Public Class DR_CENTERController
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

#Region "STORE"
        Function SP_DRUG_REGISTRATION_BY_FK_IDA_PROCESS_ID(ByVal FK_IDA As Integer, ByVal process As Integer)
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_DRUG_REGISTRATION_BY_FK_IDA_PROCESS_ID(FK_IDA, process)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        End Function
        '
        Function SP_GET_READ_DATA_RECLASS_BY_NEWCODE(ByVal Newcode As String)
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_GET_READ_DATA_RECLASS_BY_NEWCODE(Newcode)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        End Function
        Function SP_GET_DATA_RECLASS_BY_IDA(ByVal IDA As Integer)
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_GET_DATA_RECLASS_BY_IDA(IDA)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)
        End Function
#End Region

#Region "FILE_ATTACH"

#End Region

#Region "INSERT_DATA"

        Function INSERT_RECLASS(ByVal XML As String, ByVal XML2 As String, ByVal CTZNO As String, ByVal CITIZEN_ID_AUTHORIZE As String, ByVal PROCESS_ID As String, ByVal NEWCODE_U As String) As JsonResult
            Dim obj = JsonConvert.DeserializeObject(XML)
            Dim jss As New JavaScriptSerializer
            Dim bb As MODEL_DR = jss.Deserialize(XML, GetType(MODEL_DR))

            Dim result As String = ""
            Dim chk As Boolean = True
            Dim TR_ID As String = ""

            Dim bao_tran As New BAO
            TR_ID = bao_tran.insert_transection_new(PROCESS_ID, CTZNO, CITIZEN_ID_AUTHORIZE)
            Try

            Catch ex As Exception

            End Try

            Dim baoo As New BAO
            Dim dt As New DataTable

            dt = baoo.SP_GET_READ_DATA_RECLASS_BY_NEWCODE(NEWCODE_U)

            Dim dao_re As New DAO_DRUG.TB_DR_RECLASS
            With dao_re.fields
                'If bb.DR_RECLASS.ATTACH1 Is Nothing Or bb.DR_RECLASS.ATTACH1 = "" Then
                '    .ATTACH1 = "0"
                'Else
                '    .ATTACH1 = "1"
                'End If
                'If bb.DR_RECLASS.ATTACH2 Is Nothing Or bb.DR_RECLASS.ATTACH2 = "" Then
                '    .ATTACH2 = "0"
                'Else
                '    .ATTACH2 = "1"
                'End If
                'If bb.DR_RECLASS.ATTACH3 Is Nothing Or bb.DR_RECLASS.ATTACH3 = "" Then
                '    .ATTACH3 = "0"
                'Else
                '    .ATTACH3 = "1"
                'End If
                .ATTACH1 = bb.DR_RECLASS.ATTACH1
                .ATTACH2 = bb.DR_RECLASS.ATTACH2
                .ATTACH3 = bb.DR_RECLASS.ATTACH3
                .A_NO = ""
                .CTZNO = CTZNO
                '
                .IDENTIFY = CITIZEN_ID_AUTHORIZE
                .NEWCODE_U = NEWCODE_U
                .NEW_DOSESAGE = bb.DR_RECLASS.NEW_DOSESAGE
                Try
                    For Each dr As DataRow In dt.Rows
                        .FK_IDA = dr("IDA_drrgt")
                        .OLD_DOSESAGE = dr("old_kindcd")

                    Next
                Catch ex As Exception

                End Try
                Try
                    Dim ds As String = "0"
                    If bb.DR_RECLASS.NEW_DOSESAGE = "1" Then
                        ds = "53"
                    ElseIf bb.DR_RECLASS.NEW_DOSESAGE = "2" Then
                        ds = "52"
                    ElseIf bb.DR_RECLASS.NEW_DOSESAGE = "3" Then
                        ds = "54"
                    ElseIf bb.DR_RECLASS.NEW_DOSESAGE = "4" Then
                        ds = "57"
                    End If
                    .NEW_DOSESAGE = ds
                Catch ex As Exception

                End Try
                .PROCESS_ID = PROCESS_ID
                .STATUS_ID = 1
                .TR_ID = TR_ID
                .WRITE_AT = bb.DR_RECLASS.WRITE_AT
                Try
                    .WRITE_DATE = bb.DR_RECLASS.WRITE_DATE
                Catch ex As Exception

                End Try

            End With

            dao_re.insert()

            Dim dao_det As New DAO_DRUG.TB_DR_RECLASS_REGIST_DETAIL
            Dim jss2 As New JavaScriptSerializer
            dao_det.Details = jss2.Deserialize(XML2, GetType(List(Of DR_RECLASS_REGIST_DETAIL)))
            Dim i As Integer = 1
            For Each dao_det.fields In dao_det.Details
                Dim dao_det2 As New DAO_DRUG.TB_DR_RECLASS_REGIST_DETAIL
                With dao_det2.fields
                    Try
                        .DRUG_NAME = dao_det.fields.DRUG_NAME
                    Catch ex As Exception

                    End Try
                    Try
                        .FK_IDA = dao_re.fields.IDA
                    Catch ex As Exception

                    End Try
                    Try
                        .NEWCODE_U = dao_det.fields.NEWCODE_U
                    Catch ex As Exception

                    End Try
                    Try
                        .REGISTER = dao_det.fields.REGISTER
                    Catch ex As Exception

                    End Try
                    .RID = i
                End With
                dao_det2.insert()
                i += 1

            Next

            msg_r.TR_ID = dao_re.fields.TR_ID

            Return Json(msg_r, JsonRequestBehavior.AllowGet)

        End Function

        Sub INSERT_LOG_SEND_STATUS(ByVal IDA As Integer, ByVal process_id As String, ByVal STATUS_ID As Integer, ByVal CITIZEN_ID As String)
            Dim dao As New DAO_DRUG.TB_LOG_CHANGE_STATUS_MN
            dao.fields.FK_IDA = IDA
            dao.fields.IDENTIFY = CITIZEN_ID
            dao.fields.PROCESS_ID = process_id
            dao.fields.STATUS_DATE = Date.Now
            dao.fields.STATUS_ID = STATUS_ID
            dao.insert()
        End Sub
#End Region

#Region "UPDATE_DATA"
        Function SEND_RQT_RECLASS(ByVal IDA As String, ByVal EMAIL As String, ByVal TEL As String, ByVal CITIZEN_ID As String) As JsonResult
            Dim Result As String = ""
            Dim dao As New DAO_DRUG.TB_DR_RECLASS
            dao.GetDataby_IDA(IDA)
            dao.fields.EMAIL = EMAIL
            dao.fields.TEL = TEL
            dao.fields.STATUS_ID = 2
            dao.update()

            INSERT_LOG_SEND_STATUS(IDA, dao.fields.PROCESS_ID, 2, CITIZEN_ID)

            Return Json(Result, JsonRequestBehavior.AllowGet)
        End Function
#End Region

#Region "GET_DATE"

#End Region

    End Class
End Namespace