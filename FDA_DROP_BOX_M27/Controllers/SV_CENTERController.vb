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

        Function SP_STAFF_DH15RQT() As JsonResult
            Dim DT As New DataTable
            Dim BAO As New BAO
            DT = BAO.SP_STAFF_DH15RQT()
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(DT), JsonRequestBehavior.AllowGet)

        End Function

        Function SP_STAFF_DH15RQT_V2() As JsonResult
            Dim DT As New DataTable
            Dim BAO As New BAO
            DT = BAO.SP_STAFF_DH15RQT_V2()
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(DT), JsonRequestBehavior.AllowGet)

        End Function
        Function SP_STAFF_OFFER_DDL_BY_PVNCD(ByVal PVCODE As String) As JsonResult
            Dim DT As New DataTable
            Dim BAO As New BAO
            DT = BAO.SP_STAFF_OFFER_DDL_BY_PVNCD(PVCODE)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(DT), JsonRequestBehavior.AllowGet)

        End Function
        Function SP_CER_DETAIL_CASCHEMICAL_by_TR_ID(ByVal FK_IDA As String) As JsonResult
            Dim DT As New DataTable
            Dim BAO As New BAO
            DT = BAO.SP_CER_DETAIL_CASCHEMICAL_by_TR_ID(FK_IDA)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(DT), JsonRequestBehavior.AllowGet)

        End Function

        Function SP_STAFF_EXTEND(ByVal _GROUPS As String, ByVal PVCODE As String) As JsonResult
            Dim DT As New DataTable
            Dim BAO As New BAO
            DT = BAO.SP_STAFF_EXTEND(_GROUPS, PVCODE)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(DT), JsonRequestBehavior.AllowGet)

        End Function

        Function SP_DRRGT_SUBSTITUTE_STAFF() As JsonResult
            Dim DT As New DataTable
            Dim BAO As New BAO
            DT = BAO.SP_DRRGT_SUBSTITUTE_STAFF()
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(DT), JsonRequestBehavior.AllowGet)

        End Function

        Function SP_STAFF_DS() As JsonResult
            Dim DT As New DataTable
            Dim BAO As New BAO
            DT = BAO.SP_STAFF_DS()
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(DT), JsonRequestBehavior.AllowGet)

        End Function
        Function SP_DRRGT_TABEAN_STAFF() As JsonResult
            Dim DT As New DataTable
            Dim BAO As New BAO
            DT = BAO.SP_DRRGT_TABEAN_STAFF()
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(DT), JsonRequestBehavior.AllowGet)

        End Function

        Function SP_DRRGT_EDIT_REQUEST_STAFF_PROCESS(ByVal process_id As String) As JsonResult
            Dim DT As New DataTable
            Dim BAO As New BAO
            DT = BAO.SP_DRRGT_EDIT_REQUEST_STAFF_PROCESS(process_id)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(DT), JsonRequestBehavior.AllowGet)

        End Function

        Function SP_DRRGT_FOR_SEARCH_FROM_SAI(ByVal txt As String) As JsonResult
            Dim DT As New DataTable
            Dim BAO As New BAO
            DT = BAO.SP_DRRGT_FOR_SEARCH_FROM_SAI(txt)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(DT), JsonRequestBehavior.AllowGet)

        End Function
        '
        Function SP_STAFF_NYM_ALL(ByVal PROCESS_ID As String) As JsonResult
            Dim DT As New DataTable
            Dim BAO As New BAO
            DT = BAO.SP_STAFF_NYM_ALL(PROCESS_ID)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(DT), JsonRequestBehavior.AllowGet)

        End Function
        Function SP_STAFF_CER() As JsonResult
            Dim DT As New DataTable
            Dim BAO As New BAO
            DT = BAO.SP_STAFF_CER()
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(DT), JsonRequestBehavior.AllowGet)

        End Function
        Function SP_DALCN_EDIT_REQUEST_STAFF() As JsonResult
            Dim DT As New DataTable
            Dim BAO As New BAO
            DT = BAO.SP_DALCN_EDIT_REQUEST_STAFF()
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(DT), JsonRequestBehavior.AllowGet)

        End Function

        Function SP_DALCN_NCT_SUBSTITUTE_STAFF() As JsonResult
            Dim DT As New DataTable
            Dim BAO As New BAO
            DT = BAO.SP_DALCN_NCT_SUBSTITUTE_STAFF()
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(DT), JsonRequestBehavior.AllowGet)

        End Function
        Function SP_GET_LCN(ByVal CITIZEN As String) As JsonResult
            Dim DT As New DataTable
            Dim BAO As New BAO
            DT = BAO.SP_DDL_LCN_DI_DH(CITIZEN)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(DT), JsonRequestBehavior.AllowGet)

        End Function

        Function SP_LCN_EXTEND_REQUEST_BY_IDENTIFY(ByVal identify As String) As JsonResult
            Dim DT As New DataTable
            Dim BAO As New BAO
            DT = BAO.SP_LCN_EXTEND_REQUEST_BY_IDENTIFY(identify)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(DT), JsonRequestBehavior.AllowGet)

        End Function
        Function SP_LCN_EXTEND_REQUEST_BY_IDENTIFY_YEAR(ByVal identify As String, ByVal _YEAR As String) As JsonResult
            Dim DT As New DataTable
            Dim BAO As New BAO
            DT = BAO.SP_LCN_EXTEND_REQUEST_BY_IDENTIFY_YEAR(identify, _YEAR)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(DT), JsonRequestBehavior.AllowGet)

        End Function
        Function SP_CUSTOMER_LCN_BY_FK_IDA_PROCESS_IDEN(ByVal LCT_IDA As String, ByVal process As String) As JsonResult
            Dim DT As New DataTable
            Dim BAO As New BAO
            DT = BAO.SP_CUSTOMER_LCN_BY_FK_IDA_PROCESS_IDEN(LCT_IDA, process)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(DT), JsonRequestBehavior.AllowGet)

        End Function
        '
        Function SP_CUSTOMER_LCN_BY_FK_IDA_PROCESS_IDEN_V2(ByVal LCT_IDA As String, ByVal process As String, ByVal iden As String) As JsonResult
            Dim DT As New DataTable
            Dim BAO As New BAO
            DT = BAO.SP_CUSTOMER_LCN_BY_FK_IDA_PROCESS_IDEN_V2(LCT_IDA, process, iden)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(DT), JsonRequestBehavior.AllowGet)

        End Function

        Function SP_DALCN_NCT_SUBSTITUTE_BY_FK_IDA(ByVal LCN_IDA As String) As JsonResult
            Dim DT As New DataTable
            Dim BAO As New BAO
            DT = BAO.SP_DALCN_NCT_SUBSTITUTE_BY_FK_IDA(LCN_IDA)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(DT), JsonRequestBehavior.AllowGet)

        End Function

        Function SP_CUSTOMER_DALCN_LOCATION_ADDRESS_by_LOCATION_TYPE_ID_and_LCNSID(ByVal LOCATION_TYPE_CD As String, ByVal iden As String) As JsonResult
            Dim DT As New DataTable
            Dim BAO As New BAO
            DT = BAO.SP_CUSTOMER_DALCN_LOCATION_ADDRESS_by_LOCATION_TYPE_ID_and_LCNSID(LOCATION_TYPE_CD, iden)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(DT), JsonRequestBehavior.AllowGet)

        End Function
        Function SP_LCN_BY_PROCESS_AND_IDEN(ByVal process As String, ByVal iden As String) As JsonResult
            Dim DT As New DataTable
            Dim BAO As New BAO
            DT = BAO.SP_LCN_BY_PROCESS_AND_IDEN(process, iden)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(DT), JsonRequestBehavior.AllowGet)

        End Function

        Function SP_LCN_BY_PROCESS_AND_IDEN_ALIVE(ByVal process As String, ByVal iden As String) As JsonResult
            Dim DT As New DataTable
            Dim BAO As New BAO
            DT = BAO.SP_LCN_BY_PROCESS_AND_IDEN_ALIVE(process, iden)
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(DT), JsonRequestBehavior.AllowGet)

        End Function
        '
        Function SP_DALCN_EDIT_REQUEST_BY_FK_IDA(ByVal fk_ida As String) As JsonResult
            Dim DT As New DataTable
            Dim BAO As New BAO
            DT = BAO.SP_DALCN_EDIT_REQUEST_BY_FK_IDA(fk_ida)
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



        Function SP_STATUS_SELECT_DH_STAFF(ByVal IDA As String, ByVal STAT_GROUP As String)
            Dim dt As New DataTable
            Dim bao As New BAO
            Dim int_group_ddl As Integer = 0
            Dim dao As New DAO_DRUG.ClsDBdh15rqt
            dao.GetDataby_IDA(IDA)

            If dao.fields.STATUS_ID <= 2 Then
                int_group_ddl = 1
            ElseIf dao.fields.STATUS_ID >= 3 Then
                int_group_ddl = 4
            End If

            dt = bao.SP_MAS_STATUS_STAFF_BY_GROUP_DDL(STAT_GROUP, int_group_ddl)
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

        Function SP_STAFF_DALCN()
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_STAFF_DALCN()
            Dim clsds As New ClassDataset
            Return Json(clsds.DataTableToJSON(dt), JsonRequestBehavior.AllowGet)

        End Function
        Function SP_STAFF_DALCN_BY_PVNCD(ByVal pvncd As String) As JsonResult
            Dim dt As New DataTable
            Dim bao As New BAO
            dt = bao.SP_STAFF_DALCN_BY_PVNCD(pvncd)
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
                    model.rcvdate = TbNO.fields.rcvdate      ' เอาข้อมูล แล้วเปลี่ยนตัดค่า เวลาออก
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

        Function GETDATA_FILE_TR_ID_TYPE(ByVal TR_ID As Integer, ByVal PROCESS As String) As JsonResult

            Dim MODEL As New MODEL_FILELIST
            Dim dao_f As New DAO_DRUG.ClsDBFILE_ATTACH
            dao_f.GetDataby_TR_ID_And_Process(TR_ID, PROCESS)

            For Each dao_f.fields In dao_f.Details
                Dim filelist As New FILE_LIST
                filelist.FILENAME = dao_f.fields.NAME_REAL
                filelist.DES = dao_f.fields.DESCRIPTION
                filelist.TR_ID = TR_ID
                filelist.IDA = dao_f.fields.IDA
                filelist.PIORITY = ""
                If dao_f.fields.FILE_PATH Is Nothing Then
                    filelist.PATH_FILE = "E:\path\DRUG\upload\" & dao_f.fields.NAME_FAKE
                    filelist.PATH = "E:\path\DRUG\upload\" & dao_f.fields.NAME_FAKE
                Else
                    filelist.PATH_FILE = dao_f.fields.FILE_PATH
                    filelist.PATH = dao_f.fields.FILE_PATH
                End If
                filelist.PROCESS_NAME = ""
                filelist.FLAG = "PASS"
                'If dao_f.fields.FILE_PATH <> "" Then
                '    filelist.FLAG = "PASS"
                'End If
                MODEL.FILE_LISTs.Add(filelist)
            Next
            Return Json(MODEL, JsonRequestBehavior.AllowGet)
        End Function
        Function GET_LCN_INFORMATION_INPUT_V2(ByVal IDENTIFY As String, ByVal LCT_IDA As String) As JsonResult
            Dim model As New MODEL_LCN
            Dim bao As New BAO

            model.IDENTIFY = IDENTIFY
            Dim lcnno_auto As String = ""
            Dim lcnno_format As String = ""
            Dim HEAD_LCN_IDA As Integer = 0
            Try
                If HEAD_LCN_IDA <> 0 Then
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

                    Dim dao_phr As New DAO_DRUG.ClsDBDALCN_PHR
                    dao_phr.GetDataby_FK_IDA(HEAD_LCN_IDA)

                    Try
                        model.DALCN_PHR = dao_phr.fields
                    Catch ex As Exception

                    End Try
                End If

            Catch ex As Exception

            End Try
            'Dim dt_bsn As New DataTable
            'dt_bsn = bao.SP_LOCATION_BSN_BY_IDENTIFY(BSN_IDENTIFY)
            'For Each dr As DataRow In dt_bsn.Rows
            '    Try
            '        model.BSN_THAIFULLNAME = dr("BSN_THAIFULLNAME")
            '    Catch ex As Exception

            '    End Try
            '    Try
            '        model.BSN_IDENTIFY = dr("BSN_IDENTIFY")
            '    Catch ex As Exception

            '    End Try
            '    Try
            '        model.AGE = dr("AGE")
            '    Catch ex As Exception

            '    End Try
            '    Try
            '        model.BSN_FULL_ADDR = dr("BSN_FULL_ADDR")
            '    Catch ex As Exception

            '    End Try
            '    Try
            '        model.BSN_TELEPHONE = dr("BSN_TELEPHONE")
            '    Catch ex As Exception

            '    End Try
            '    Try
            '        model.BSN_FAX = dr("BSN_FAX")
            '    Catch ex As Exception

            '    End Try
            'Next
            Dim dt_name As New DataTable
            'Dim bao As New BAO
            dt_name = bao.SP_SYSLCNSNM_BY_LCNSID_AND_IDENTIFY(IDENTIFY, 0)
            ''Dim model As New MODEL_LCN
            With model
                .LCNNO_SHOW = lcnno_format


                For Each dr As DataRow In dt_name.Rows
                    .thanm = dr("thanm")
                Next



            End With

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


            Return Json(model, JsonRequestBehavior.AllowGet)
        End Function
        Function GET_LCN_INFORMATION_INPUT_MODIFY(ByVal IDENTIFY As String, ByVal LCT_IDA As String, ByVal LCN_IDA As String) As JsonResult
            Dim model As New MODEL_LCN
            Dim bao As New BAO
            Dim dao As New DAO_DRUG.ClsDBdalcn
            dao.GetDataby_IDA(LCN_IDA)
            Try
                If dao.fields.lcntpcd.Contains("จ3") Then
                    model.LCN_TYPE_NCT = "1"
                ElseIf dao.fields.lcntpcd.Contains("จ4") Then
                    model.LCN_TYPE_NCT = "2"
                End If
            Catch ex As Exception

            End Try

            Try
                If dao.fields.lcntpcd.Contains("ขย1") Or dao.fields.lcntpcd.Contains("ผยบ") Then
                    model.CHK_TYPE = "1"
                    model.LCN_TYPE = "1"
                ElseIf dao.fields.lcntpcd.Contains("ขย2") Or dao.fields.lcntpcd.Contains("ขยบ") Then
                    model.CHK_TYPE = "2"
                    model.LCN_TYPE = "2"
                ElseIf dao.fields.lcntpcd.Contains("ขย3") Or dao.fields.lcntpcd.Contains("นยบ") Then
                    model.CHK_TYPE = "3"
                    model.LCN_TYPE = "3"
                ElseIf dao.fields.lcntpcd.Contains("ขย4") Then
                    model.CHK_TYPE = "4"
                    model.LCN_TYPE = "4"
                End If
            Catch ex As Exception

            End Try

            model.IDENTIFY = IDENTIFY
            Dim lcnno_auto As String = ""
            Dim lcnno_format As String = ""
            Dim HEAD_LCN_IDA As Integer = 0
            Try
                If HEAD_LCN_IDA <> 0 Then
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

                    Dim dao_phr As New DAO_DRUG.ClsDBDALCN_PHR
                    dao_phr.GetDataby_FK_IDA(HEAD_LCN_IDA)

                    Try
                        model.DALCN_PHR = dao_phr.fields
                    Catch ex As Exception

                    End Try
                End If

            Catch ex As Exception

            End Try
            Try
                Dim dao_bsn As New DAO_DRUG.TB_DALCN_LOCATION_BSN
                dao_bsn.GetDataby_LCN_IDA(LCN_IDA)
                Dim dt_bsn As New DataTable
                dt_bsn = bao.SP_LOCATION_BSN_BY_IDENTIFY(dao_bsn.fields.BSN_IDENTIFY)
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
            Catch ex As Exception

            End Try
            Dim lcnno_auto2 As Integer = 0
            Dim lcnno_format2 As String = ""
            Try
                Try
                    lcnno_auto2 = dao.fields.lcnno
                Catch ex As Exception

                End Try
                Try
                    If Len(lcnno_auto2) > 0 Then

                        If Right(Left(lcnno_auto2, 3), 1) = "5" Then
                            lcnno_format2 = "จ. " & CStr(CInt(Right(lcnno_auto2, 4))) & "/25" & Left(lcnno_auto2, 2)
                        Else
                            lcnno_format2 = dao.fields.pvnabbr & " " & CStr(CInt(Right(lcnno_auto2, 5))) & "/25" & Left(lcnno_auto2, 2)
                        End If
                        'lcnno_format = dao.fields.pvnabbr & " " & CStr(CInt(Right(lcnno_auto, 5))) & "/25" & Left(lcnno_auto, 2)
                    End If
                Catch ex As Exception

                End Try

                model.LCNNO_SHOW = lcnno_format2

                Dim dao_phr As New DAO_DRUG.ClsDBDALCN_PHR
                dao_phr.GetDataby_FK_IDA_ORDER_ASC(LCN_IDA)

                Try
                    model.DALCN_PHR = dao_phr.fields
                Catch ex As Exception

                End Try
                Try
                    model.PHR_NAME = dao_phr.fields.PHR_NAME
                    model.PHR_TEXT_NUM = dao_phr.fields.PHR_TEXT_NUM
                Catch ex As Exception

                End Try
            Catch ex As Exception

            End Try
            Dim dt_name As New DataTable
            'Dim bao As New BAO
            dt_name = bao.SP_SYSLCNSNM_BY_LCNSID_AND_IDENTIFY(IDENTIFY, 0)
            ''Dim model As New MODEL_LCN
            With model

                For Each dr As DataRow In dt_name.Rows
                    .thanm = dr("thanm")
                Next



            End With

            Dim dt_addr As New DataTable
            Try
                dt_addr = bao.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(dao.fields.FK_IDA)
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
            Catch ex As Exception

            End Try

            Dim dt_keep As New DataTable
            Try
                dt_keep = bao.SP_MASTER_DALCN_DETAIL_LOCATION_KEEP_BY_IDA(LCN_IDA)
                For Each dr As DataRow In dt_keep.Rows
                    model.KEEP_FULL_ADDR = dr("fulladdr")
                    model.KEEP_THANAMEPLACE = dr("thanameplace")
                    model.KEEP_TEL = dr("tel")
                    model.KEEP_HOUSENO = dr("HOUSENO")
                Next
            Catch ex As Exception

            End Try


            Return Json(model, JsonRequestBehavior.AllowGet)
        End Function
        Function GET_LCN_APPROVE_INFORMATION_INPUT(ByVal LCN_IDA As String) As JsonResult
            Dim model As New MODEL_LCN
            Dim dao As New DAO_DRUG.ClsDBdalcn
            dao.GetDataby_IDA(LCN_IDA)

            Try
                If dao.fields.TABLET_CAPSULE = "ยังไม่ระบุผู้ลงนาม" Then
                    model.TABLET_CAPSULE = ""
                    Try
                        model.APPDATE_STR = CDate(dao.fields.appdate).ToShortDateString()
                    Catch ex As Exception

                    End Try
                    Try
                        model.PHARMACEUTICAL_CHEMICALS = dao.fields.PHARMACEUTICAL_CHEMICALS
                    Catch ex As Exception

                    End Try
                Else
                    model.TABLET_CAPSULE = dao.fields.TABLET_CAPSULE
                    Try
                        model.APPDATE_STR = CDate(dao.fields.appdate).ToShortDateString()
                    Catch ex As Exception

                    End Try
                    Try
                        model.PHARMACEUTICAL_CHEMICALS = dao.fields.PHARMACEUTICAL_CHEMICALS
                    Catch ex As Exception

                    End Try
                End If
            Catch ex As Exception

            End Try

            Return Json(model, JsonRequestBehavior.AllowGet)
        End Function
        Function GET_LCN_INFORMATION_INPUT_SUBTITUTE_AND_MOVE(ByVal IDENTIFY As String, ByVal PROCESS_ID As String, ByVal LCN_IDA As String) As JsonResult
            Dim model As New MODEL_LCN
            Dim bao As New BAO
            Dim dao As New DAO_DRUG.ClsDBdalcn
            dao.GetDataby_IDA(LCN_IDA)
            Try
                If dao.fields.lcntpcd.Contains("จ3") Then
                    model.LCN_TYPE_NCT = "1"
                ElseIf dao.fields.lcntpcd.Contains("จ4") Then
                    model.LCN_TYPE_NCT = "2"
                End If
            Catch ex As Exception

            End Try

            Try
                If dao.fields.lcntpcd.Contains("ขย1") Or dao.fields.lcntpcd.Contains("ผยบ") Then
                    model.CHK_TYPE = "1"
                    model.LCN_TYPE = "1"
                ElseIf dao.fields.lcntpcd.Contains("ขย2") Or dao.fields.lcntpcd.Contains("ขยบ") Then
                    model.CHK_TYPE = "2"
                    model.LCN_TYPE = "2"
                ElseIf dao.fields.lcntpcd.Contains("ขย3") Or dao.fields.lcntpcd.Contains("นยบ") Then
                    model.CHK_TYPE = "3"
                    model.LCN_TYPE = "3"
                ElseIf dao.fields.lcntpcd.Contains("ขย4") Then
                    model.CHK_TYPE = "4"
                    model.LCN_TYPE = "4"
                End If
            Catch ex As Exception

            End Try

            If PROCESS_ID = "100701" Or PROCESS_ID = "100702" Or PROCESS_ID = "100703" Or PROCESS_ID = "100704" Or PROCESS_ID = "100705" Or PROCESS_ID = "100766" Or PROCESS_ID = "100767" _
                Or PROCESS_ID = "100768" Or PROCESS_ID = "100769" Or PROCESS_ID = "100770" Or PROCESS_ID = "100771" Or PROCESS_ID = "100772" Or PROCESS_ID = "100773" Then
                model.REQUEST_TYPE = 1

            ElseIf PROCESS_ID = "100791" Or PROCESS_ID = "100792" Or PROCESS_ID = "100793" Or PROCESS_ID = "100794" Or PROCESS_ID = "100795" Then
                model.REQUEST_TYPE = 2
            End If
            model.IDENTIFY = IDENTIFY
            Dim lcnno_auto As String = ""
            Dim lcnno_format As String = ""
            Dim HEAD_LCN_IDA As Integer = 0
            Try
                If HEAD_LCN_IDA <> 0 Then
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

                    Dim dao_phr As New DAO_DRUG.ClsDBDALCN_PHR
                    dao_phr.GetDataby_FK_IDA(HEAD_LCN_IDA)

                    Try
                        model.DALCN_PHR = dao_phr.fields
                    Catch ex As Exception

                    End Try
                End If

            Catch ex As Exception

            End Try
            Try
                Dim dao_bsn As New DAO_DRUG.TB_DALCN_LOCATION_BSN
                dao_bsn.GetDataby_LCN_IDA(LCN_IDA)
                Dim dt_bsn As New DataTable
                dt_bsn = bao.SP_LOCATION_BSN_BY_IDENTIFY(dao_bsn.fields.BSN_IDENTIFY)
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
            Catch ex As Exception

            End Try
            Dim lcnno_auto2 As Integer = 0
            Dim lcnno_format2 As String = ""
            Try
                Try
                    lcnno_auto2 = dao.fields.lcnno
                Catch ex As Exception

                End Try
                Try
                    If Len(lcnno_auto2) > 0 Then

                        If Right(Left(lcnno_auto2, 3), 1) = "5" Then
                            lcnno_format2 = "จ. " & CStr(CInt(Right(lcnno_auto2, 4))) & "/25" & Left(lcnno_auto2, 2)
                        Else
                            lcnno_format2 = dao.fields.pvnabbr & " " & CStr(CInt(Right(lcnno_auto2, 5))) & "/25" & Left(lcnno_auto2, 2)
                        End If
                        'lcnno_format = dao.fields.pvnabbr & " " & CStr(CInt(Right(lcnno_auto, 5))) & "/25" & Left(lcnno_auto, 2)
                    End If
                Catch ex As Exception

                End Try

                model.LCNNO_SHOW = lcnno_format2

                Dim dao_phr As New DAO_DRUG.ClsDBDALCN_PHR
                dao_phr.GetDataby_FK_IDA_ORDER_ASC(LCN_IDA)

                Try
                    model.DALCN_PHR = dao_phr.fields
                Catch ex As Exception

                End Try
                Try
                    model.PHR_NAME = dao_phr.fields.PHR_NAME
                    model.PHR_TEXT_NUM = dao_phr.fields.PHR_TEXT_NUM
                Catch ex As Exception

                End Try
            Catch ex As Exception

            End Try
            Dim dt_name As New DataTable
            'Dim bao As New BAO
            dt_name = bao.SP_SYSLCNSNM_BY_LCNSID_AND_IDENTIFY(IDENTIFY, 0)
            ''Dim model As New MODEL_LCN
            With model

                For Each dr As DataRow In dt_name.Rows
                    .thanm = dr("thanm")
                Next



            End With

            Dim dt_addr As New DataTable
            Try
                dt_addr = bao.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(dao.fields.FK_IDA)
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
            Catch ex As Exception

            End Try

            Dim dt_keep As New DataTable
            Try
                dt_keep = bao.SP_MASTER_DALCN_DETAIL_LOCATION_KEEP_BY_IDA(LCN_IDA)
                For Each dr As DataRow In dt_keep.Rows
                    model.KEEP_FULL_ADDR = dr("fulladdr")
                    model.KEEP_THANAMEPLACE = dr("thanameplace")
                    model.KEEP_TEL = dr("tel")
                    model.KEEP_HOUSENO = dr("HOUSENO")
                Next
            Catch ex As Exception

            End Try


            Return Json(model, JsonRequestBehavior.AllowGet)
        End Function
        Function GET_HEAD_LCN_INFORMATION_INPUT(ByVal HEAD_LCN_IDA As String) As JsonResult
            Dim model As New MODEL_LCN
            Dim bao As New BAO
            Dim lcnno_auto As String = ""
            Dim lcnno_format As String = ""
            Try
                If HEAD_LCN_IDA <> 0 Then
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


                End If

            Catch ex As Exception

            End Try

            Return Json(model, JsonRequestBehavior.AllowGet)
        End Function
        Function GET_LCN_INFORMATION_INPUT(ByVal BSN_IDENTIFY As String, ByVal IDENTIFY As String, ByVal LCT_IDA As String) As JsonResult
            Dim model As New MODEL_LCN
            Dim bao As New BAO

            model.IDENTIFY = IDENTIFY
            Dim lcnno_auto As String = ""
            Dim lcnno_format As String = ""
            Dim HEAD_LCN_IDA As Integer = 0
            Try
                If HEAD_LCN_IDA <> 0 Then
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

                    Dim dao_phr As New DAO_DRUG.ClsDBDALCN_PHR
                    dao_phr.GetDataby_FK_IDA(HEAD_LCN_IDA)

                    Try
                        model.DALCN_PHR = dao_phr.fields
                    Catch ex As Exception

                    End Try
                End If

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


            Dim dt_name As New DataTable
            'Dim bao As New BAO
            dt_name = bao.SP_SYSLCNSNM_BY_LCNSID_AND_IDENTIFY(IDENTIFY, 0)
            ''Dim model As New MODEL_LCN
            With model
                .LCNNO_SHOW = lcnno_format


                For Each dr As DataRow In dt_name.Rows
                    .thanm = dr("thanm")
                Next



            End With

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


            Return Json(model, JsonRequestBehavior.AllowGet)
        End Function


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
                            .tel = dr("tel1")
                        Catch ex As Exception

                        End Try
                        Try
                            .fax = dr("fax")
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
                        .CHK_TYPE_LCN = 1
                    ElseIf dao.fields.lcntpcd.Contains("นย") Then
                        .LCN_TYPE = 2
                        .CHK_TYPE_LCN = 2
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
            If dao_cer.fields.STATUS_ID > 1 Then
                model.CLOSE_BTN = "TRUE"
            Else
                model.CLOSE_BTN = ""
            End If
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
            Dim dao_cas As New DAO_DRUG.TB_DH15_DETAIL_CASCHEMICAL
            Try
                dao_cas.GetDataby_FK_IDA(IDA)
            Catch ex As Exception

            End Try
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
                model.DH15_DETAIL_CASCHEMICAL = dao_cas.Details
            Catch ex As Exception

            End Try
            Try
                model.dh15rqt = dao.fields
            Catch ex As Exception

            End Try
            Try
                If dao.fields.STATUS_ID > 1 Then
                    model.CLOSE_BTN = "TRUE"
                Else
                    model.CLOSE_BTN = ""
                End If
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
                Dim dao_m As New DAO_DRUG.TB_DH15_DETAIL_CER
                dao_m.GetDataby_CER_IDA(IDA)
                model.DH15_DETAIL_CER = dao_m.fields
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
                _CLS.CITIZEN_ID = "0000000000000" ''"1100400181875" 0105522020724
                _CLS.CITIZEN_ID_AUTHORIZE = "0000000000000" '"0105540078852"
                _CLS.COMPANY_NAME = "บริษัท เทสออนลี่ จำกัด มหาขน"
                _CLS.THANM = "นายทดสอบ ระบบ"
                _CLS.TOKEN = TOKEN
                _CLS.CODE = "900"
                _CLS.PVCODE = 10
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
            Dim path As String = _PATH_DEFAULT & "upload\"
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
                Dim path As String = _PATH_DEFAULT & "\upload\"
                ''Dim path As String = "F:\path\DRUG\upload\"
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
                        .DESCRIPTION = ""
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
        Function UPDATE_APPROVE_NAME(ByVal XML_APP As String, ByVal LCN_IDA As Integer, ByVal CITIZEN_ID As String) As JsonResult
            Dim jss As New JavaScriptSerializer
            Dim bb As MODEL_LCN = jss.Deserialize(XML_APP, GetType(MODEL_LCN))
            Dim result As String = ""
            Dim jss2 As New JavaScriptSerializer
            If Len(bb.TABLET_CAPSULE) = 0 Or Len(bb.PHARMACEUTICAL_CHEMICALS) = 0 Then
                result = "กรุณากรอกข้อมูลให้ครบถ้วน"
            Else
                Dim dao As New DAO_DRUG.ClsDBdalcn
                dao.GetDataby_IDA(LCN_IDA)
                dao.fields.STATUS_ID = 8
                dao.fields.PHARMACEUTICAL_CHEMICALS = bb.PHARMACEUTICAL_CHEMICALS

                dao.fields.TABLET_CAPSULE = bb.TABLET_CAPSULE
                dao.update()

                'Try
                '    Dim ws_update126 As New WS_DRUG_126.WS_DRUG
                '    ws_update126.DRUG_INSERT_LICEN_126(LCN_IDA, CITIZEN_ID)
                'Catch ex As Exception

                'End Try

                AddLogStatus(8, dao.fields.PROCESS_ID, CITIZEN_ID, LCN_IDA)
                result = "ดำเนินการอนุมัติเรียบร้อยแล้ว"
            End If


            Return Json(result, JsonRequestBehavior.AllowGet)
        End Function
        Function SAVE_LCN_CONSIDER(ByVal XML_CSD As String, ByVal LCN_IDA As Integer, ByVal CITIZEN_ID As String, ByVal PVCODE As String) As JsonResult
            Dim jss As New JavaScriptSerializer
            Dim bb As MODEL_LCN = jss.Deserialize(XML_CSD, GetType(MODEL_LCN))
            Dim result As String = ""
            Try
                If Len(bb.PHARMACEUTICAL_CHEMICALS) >= 5 Then
                    Dim dao As New DAO_DRUG.ClsDBdalcn
                    Dim dao_up As New DAO_DRUG.ClsDBTRANSACTION_UPLOAD
                    Dim bao As New BAO_GENNO.GenNumber

                    dao.GetDataby_IDA(LCN_IDA)
                    Dim _TR_ID As Integer = 0
                    Try
                        _TR_ID = dao.fields.TR_ID
                    Catch ex As Exception

                    End Try
                    If Len(_TR_ID) >= 9 Then
                        dao_up.GetDataby_TR_ID_Process(_TR_ID, dao.fields.PROCESS_ID)
                    Else
                        dao_up.GetDataby_IDA(_TR_ID)
                    End If

                    AddLogStatus(6, dao.fields.PROCESS_ID, CITIZEN_ID, LCN_IDA)

                    Dim PROCESS_ID As String = dao.fields.PROCESS_ID

                    'Dim dao_p As New DAO_DRUG.ClsDBPROCESS_NAME
                    'dao_p.GetDataby_PROCESS_ID(PROCESS_ID)
                    Dim GROUP_NUMBER As String = dao.fields.PROCESS_ID

                    Dim CONSIDER_DATE As Date = CDate(bb.dalcn.CONSIDER_DATE)

                    '--------------------------------
                    Dim chw As String = ""
                    Dim dao_cpn As New DAO_CPN.clsDBsyschngwt
                    Try
                        dao_cpn.GetData_by_chngwtcd(dao.fields.pvncd)
                        chw = dao_cpn.fields.thacwabbr
                    Catch ex As Exception

                    End Try
                    Dim bao2 As New BAO_GENNO.GenNumber
                    Dim LCNNO As Integer
                    LCNNO = bao2.GEN_NO_01(con_year(Date.Now.Year), PVCODE, GROUP_NUMBER, PROCESS_ID, 0, 0, LCN_IDA, "")
                    dao.fields.lcnno = LCNNO 'bao.FORMAT_NUMBER_FULL(con_year(Date.Now.Year), LCNNO)

                    If chw <> "" Then
                        dao.fields.LCNNO_DISPLAY = chw & " " & bao.FORMAT_NUMBER_YEAR_FULL(con_year(Date.Now.Year), LCNNO) ' & " (ขย." & GROUP_NUMBER & ")"

                    Else
                        dao.fields.LCNNO_DISPLAY = bao.FORMAT_NUMBER_YEAR_FULL(con_year(Date.Now.Year), LCNNO) ' & " (ขย." & GROUP_NUMBER & ")"
                    End If
                    '---------------------------------------

                    dao.fields.remark = bb.dalcn.remark
                    dao.fields.STATUS_ID = 6
                    dao.fields.CONSIDER_DATE = CONSIDER_DATE

                    dao.fields.FK_STAFF_OFFER_IDA = bb.dalcn.FK_STAFF_OFFER_IDA
                    Try
                        Try
                            Dim dao_sn As New DAO_DRUG.TB_MAS_STAFF_OFFER
                            dao_sn.GetDataby_IDA(bb.dalcn.FK_STAFF_OFFER_IDA)
                            dao.fields.TABLET_CAPSULE = dao_sn.fields.STAFF_OFFER_NAME
                        Catch ex As Exception

                        End Try

                    Catch ex As Exception

                    End Try
                    Try
                        dao.fields.PHARMACEUTICAL_CHEMICALS = bb.dalcn.PHARMACEUTICAL_CHEMICALS
                    Catch ex As Exception

                    End Try
                    Try
                        dao.fields.appdate = CDate(bb.dalcn.appdate)
                    Catch ex As Exception

                    End Try
                    Try
                        dao.fields.frtappdate = CDate(bb.dalcn.appdate)
                    Catch ex As Exception

                    End Try
                    Try
                        dao.fields.FIRST_APP_DATE = CDate(bb.dalcn.appdate)
                    Catch ex As Exception

                    End Try

                    If IsNothing(dao.fields.appdate) = False Then
                        Dim appdate As Date = CDate(dao.fields.appdate)
                        Dim expyear As Integer = 0
                        Try
                            expyear = Year(appdate)
                            If expyear <> 0 Then
                                If expyear < 2500 Then
                                    expyear += 543
                                End If
                                dao.fields.expyear = expyear
                            End If
                        Catch ex As Exception

                        End Try
                    End If

                    'Try
                    '    send_mail_mini(dao.fields.CITIZEN_ID, "FDATH", "คำขอ เลขดำเนินการที่ " & dao.fields.TR_ID & " อยู่ระหว่างดำเนินการพิจารณา")
                    'Catch ex As Exception

                    'End Try

                    dao.update()

                    'Dim cls_sop As New CLS_SOP
                    'cls_sop.BLOCK_STAFF(_CLS.CITIZEN_ID, "STAFF", PROCESS_ID, _CLS.PVCODE, 6, "เสนอลงนาม", "SOP-DRUG-10-" & PROCESS_ID & "-3", "อนุมัติ", "รอเจ้าหน้าที่อนุมัติคำขอ", "STAFF", _TR_ID, SOP_STATUS:="เสนอลงนาม")
                    result = "SUCCESS"
                Else
                    result = "POSITION"
                End If

            Catch ex As Exception
                result = "DATE"

            End Try
            Return Json(result, JsonRequestBehavior.AllowGet)
        End Function
        Function SAVE_LCN_REMARK(ByVal XML_RMK As String, ByVal LCN_IDA As Integer, ByVal CITIZEN_ID As String, ByVal PVCODE As String) As JsonResult
            Dim jss As New JavaScriptSerializer
            Dim bb As MODEL_LCN = jss.Deserialize(XML_RMK, GetType(MODEL_LCN))
            Dim result As String = ""
            Dim dao As New DAO_DRUG.ClsDBdalcn
            dao.GetDataby_IDA(LCN_IDA)
            dao.fields.STATUS_ID = 7
            dao.fields.remark = bb.dalcn.remark
            dao.update()

            'Dim cls_sop As New CLS_SOP
            'cls_sop.BLOCK_STAFF(_CLS.CITIZEN_ID, "STAFF", dao.fields.PROCESS_ID, _CLS.PVCODE, 8, "คืนคำขอ", "SOP-DRUG-10-" & dao.fields.PROCESS_ID & "-3", "คืนคำขอ", "เจ้าหน้าที่คืนคำขอ", "STAFF", _TR_ID, SOP_STATUS:="คืนคำขอ")
            AddLogStatus(7, dao.fields.PROCESS_ID, CITIZEN_ID, LCN_IDA)
            result = "ดำเนินการคืนคำขอเรียบร้อยแล้ว"

            Return Json(result, JsonRequestBehavior.AllowGet)
        End Function
        'BTN_SAVE_REMARK_CERT
        Function SAVE_REMARK_CERT(ByVal XML_RMK As String, ByVal IDA As Integer, ByVal CITIZEN_ID As String) As JsonResult
            Dim jss As New JavaScriptSerializer
            Dim bb As MODEL_DH = jss.Deserialize(XML_RMK, GetType(MODEL_DH))
            Dim result As String = ""
            Dim dao As New DAO_DRUG.TB_CER
            dao.GetDataby_IDA2(IDA)
            dao.fields.STATUS_ID = 7
            dao.fields.REMARK = bb.CER.REMARK
            dao.update()

            AddLogStatus(7, dao.fields.PROCESS_ID, CITIZEN_ID, IDA)
            result = "ดำเนินการคืนคำขอเรียบร้อยแล้ว"

            Return Json(result, JsonRequestBehavior.AllowGet)
        End Function
        Function SAVE_REMARK_DH(ByVal XML_RMK As String, ByVal IDA As Integer, ByVal CITIZEN_ID As String) As JsonResult
            Dim jss As New JavaScriptSerializer
            Dim bb As MODEL_DH = jss.Deserialize(XML_RMK, GetType(MODEL_DH))
            Dim result As String = ""
            Dim dao As New DAO_DRUG.ClsDBdh15rqt
            dao.GetDataby_IDA(IDA)
            dao.fields.STATUS_ID = 7
            dao.fields.REMARK = bb.dh15rqt.REMARK
            dao.update()

            AddLogStatus(7, dao.fields.PROCESS_ID, CITIZEN_ID, IDA)
            result = "ดำเนินการคืนคำขอเรียบร้อยแล้ว"

            Return Json(result, JsonRequestBehavior.AllowGet)
        End Function


        Function SAVE_LCN_PAYNOTE(ByVal XML_PAY As String, ByVal LCN_IDA As Integer, ByVal CITIZEN_ID As String, ByVal PVCODE As String) As JsonResult
            Dim jss As New JavaScriptSerializer
            Dim bb As MODEL_LCN = jss.Deserialize(XML_PAY, GetType(MODEL_LCN))
            Dim result As String = ""
            If Len(bb.dalcn.comment) >= 10 Then
                Dim dao As New DAO_DRUG.ClsDBdalcn
                dao.GetDataby_IDA(LCN_IDA)
                dao.fields.STATUS_ID = 11
                dao.fields.comment = bb.dalcn.comment
                dao.update()

                'Dim cls_sop As New CLS_SOP
                'cls_sop.BLOCK_STAFF(_CLS.CITIZEN_ID, "STAFF", dao.fields.PROCESS_ID, _CLS.PVCODE, 8, "บันทึกการชำระเงินค่าคำขอ", "SOP-DRUG-10-" & dao.fields.PROCESS_ID & "-11", "บันทึกการชำระเงินค่าคำขอ", "เจ้าหน้าที่บันทึกการชำระเงินค่าคำขอ", "STAFF", _TR_ID, SOP_STATUS:="บันทึกการชำระเงินค่าคำขอ")
                AddLogStatus(11, dao.fields.PROCESS_ID, CITIZEN_ID, LCN_IDA)
                result = "SUCCESS"  '"บันทึกข้อมูบเรียบร้อยแล้ว")
            Else
                result = "FAIL"
            End If


            Return Json(result, JsonRequestBehavior.AllowGet)
        End Function
        Function UPDATE_STATUS_CERT(ByVal STATUS_ID As String, ByVal IDA As Integer) As JsonResult
            Dim result As String = ""
            Dim jss As New JavaScriptSerializer
            Dim dao As New DAO_DRUG.TB_CER
            'Dim bao As New BAO.GenNumber
            dao.GetDataby_IDA2(Integer.Parse(IDA))
            Dim date_now As Date = Date.Now
            Dim date_exp As Date
            Try
                date_exp = CDate(dao.fields.EXP_DOCUMENT_DATE) 'CDate(dao.fields.EXP_DOCUMENT_DATE).AddDays(180)
            Catch ex As Exception

            End Try
            'Dim ws As New AUTHEN_LOG.Authentication
            'ws.AUTHEN_LOG_DATA(_CLS.TOKEN, _CLS.CITIZEN_ID, _CLS.SYSTEM_ID, _CLS.GROUPS, _CLS.ID_MENU, "DRUG", _TR_ID, HttpContext.Current.Request.Url.AbsoluteUri, "ยื่นคำขอ Cert", _ProcessID)

            If date_now <= date_exp And dao.fields.PROCESS_ID <> 34 Then

                dao.fields.STATUS_ID = 2
                dao.fields.REQUEST_DATE = Date.Now
                Try
                    dao.fields.lmdfdate = Bind_Date(CDate(Date.Now))
                Catch ex As Exception

                End Try
                dao.update()
                'AddLogStatus(2, Request.QueryString("ProcessID"), _CLS.CITIZEN_ID, _IDA)

                result = "ยื่นคำขอเรียบร้อยแล้ว"
            Else
                If dao.fields.PROCESS_ID = 34 Then
                    dao.fields.STATUS_ID = 2
                    dao.fields.REQUEST_DATE = Date.Now
                    Try
                        dao.fields.lmdfdate = Bind_Date(CDate(Date.Now))
                    Catch ex As Exception

                    End Try
                    dao.update()
                    ' AddLogStatus(2, Request.QueryString("ProcessID"), _CLS.CITIZEN_ID, _IDA)

                    result = "ยื่นคำขอเรียบร้อยแล้ว"
                Else
                    result = "ไม่สารมารถยื่นคำขอได้ เนื่องจาก Cert หมดอายุ"
                End If

            End If
            Return Json(result, JsonRequestBehavior.AllowGet)
        End Function
        Function APPROVE_CERT_STAFF(ByVal IDA As Integer, ByVal CITIZEN_ID As String) As JsonResult
            Dim result As String = ""
            Dim jss As New JavaScriptSerializer
            Dim bao As New BAO_GENNO.GenNumber 'test
            Dim dao As New DAO_DRUG.TB_CER
            dao.GetDataby_IDA2(IDA)
            Dim cernumber As String = bao.GEN_CER_NO_V2(con_year(Date.Now.Year.ToString()), 10, dao.fields.CER_TYPE, "", "1", "1", IDA, "")
            Dim rcvno As String = bao.GEN_CER_RCVNO(con_year(Date.Now.Year.ToString()), 10, dao.fields.CER_TYPE, "", "1", "2", IDA, "")

            dao.fields.CER_NUMBER = cernumber
            dao.fields.CER_DATE = Date.Now
            dao.fields.RCVNO = rcvno
            dao.fields.RCVDATE = Date.Now
            dao.fields.STATUS_ID = 8
            dao.fields.CER_FORMAT = cernumber
            dao.update()

            Try
                'Dim ws As New AUTHEN_LOG.Authentication
                'ws.AUTHEN_LOG_DATA(_CLS.TOKEN, _CLS.CITIZEN_ID, _CLS.SYSTEM_ID, _CLS.GROUPS, _CLS.ID_MENU, "DRUG", _TR_ID, HttpContext.Current.Request.Url.AbsoluteUri, "จนท. พิจารณาคำขอ Cert", dao_tr.fields.PROCESS_ID)
            Catch ex As Exception

            End Try

            AddLogStatus(8, dao.fields.PROCESS_ID, CITIZEN_ID, IDA)
            'alert("เลขรับ คือ " & rcvno.ToString() & " REF CER คือ " & cernumber) 'test

            result = "เลขรับ คือ " & rcvno.ToString() & " REF CER คือ " & cernumber

            Return Json(result, JsonRequestBehavior.AllowGet)
        End Function
        Function UPDATE_STATUS_DH_STAFF(ByVal STATUS_ID As String, ByVal IDA As Integer, ByVal CITIZEN_ID As String, ByVal PVCODE As String) As JsonResult
            Dim result As String = ""
            Dim jss As New JavaScriptSerializer
            Dim dao As New DAO_DRUG.ClsDBdh15rqt
            dao.GetDataby_IDA(IDA)
            Dim lcn_ida As Integer = 0
            Try
                lcn_ida = dao.fields.FK_IDA
            Catch ex As Exception

            End Try
            Dim RCVNO As Integer

            If STATUS_ID = 3 Then
                Dim bao As New BAO_GENNO.GenNumber
                RCVNO = bao.GEN_NO_04(con_year(Date.Now.Year()), PVCODE, dao.fields.PROCESS_ID, dao.fields.lcnno, "", 0, IDA, "")
                dao.fields.rcvno = RCVNO
                dao.fields.RCVNO_DISPLAY = bao.FORMAT_NUMBER_MINI(con_year(Date.Now.Year()), RCVNO)
                dao.fields.rcvdate = Date.Now
                dao.fields.STATUS_ID = STATUS_ID
                dao.fields.RCVDATE_DISPLAY = Date.Now.ToShortDateString()

                dao.update()
                AddLogStatus(3, dao.fields.PROCESS_ID, CITIZEN_ID, IDA)

                'Dim ws_118 As New WS_AUTHENTICATION.Authentication
                'Dim ws_66 As New Authentication_66.Authentication
                'Dim ws_104 As New AUTHENTICATION_104.Authentication
                'Try
                '    ws_118.Timeout = 10000
                '    ws_118.AUTHEN_LOG_DATA(_CLS.TOKEN, _CLS.CITIZEN_ID, _CLS.SYSTEM_ID, _CLS.GROUPS, _CLS.ID_MENU, "DRUG", 0, HttpContext.Current.Request.Url.AbsoluteUri, "พิจารณาคำขอเภสัชเคมีภัณฑ์", _ProcessID)
                'Catch ex As Exception
                '    Try
                '        ws_66.Timeout = 10000
                '        ws_66.AUTHEN_LOG_DATA(_CLS.TOKEN, _CLS.CITIZEN_ID, _CLS.SYSTEM_ID, _CLS.GROUPS, _CLS.ID_MENU, "DRUG", 0, HttpContext.Current.Request.Url.AbsoluteUri, "พิจารณาคำขอเภสัชเคมีภัณฑ์", _ProcessID)

                '    Catch ex2 As Exception
                '        Try
                '            ws_104.Timeout = 10000
                '            ws_104.AUTHEN_LOG_DATA(_CLS.TOKEN, _CLS.CITIZEN_ID, _CLS.SYSTEM_ID, _CLS.GROUPS, _CLS.ID_MENU, "DRUG", 0, HttpContext.Current.Request.Url.AbsoluteUri, "พิจารณาคำขอเภสัชเคมีภัณฑ์", _ProcessID)

                '        Catch ex3 As Exception
                '            System.Web.UI.ScriptManager.RegisterStartupScript(Page, GetType(Page), "Codeblock", "alert('เกิดข้อผิดพลาดการเชื่อมต่อ');window.location.href = 'http://privus.fda.moph.go.th';", True)
                '        End Try
                '    End Try
                'End Try

                result = "ดำเนินการรับคำขอเรียบร้อยแล้ว เลขรับ คือ " & dao.fields.rcvno

                'ElseIf STATUS_ID = 7 Then
                '    Response.Redirect("FRM_DH_STAFF_REMARK.aspx?IDA=" & _IDA & "&TR_ID=" & _TR_ID & "&process=" & _ProcessID)

            ElseIf STATUS_ID = 10 Then
                Dim dao_lcn As New DAO_DRUG.ClsDBdalcn
                dao_lcn.GetDataby_IDA(lcn_ida)
                Try
                    dao.fields.lcntpcd = dao_lcn.fields.lcntpcd
                Catch ex As Exception

                End Try
                Try
                    dao.fields.pvnabbr = dao_lcn.fields.pvnabbr
                Catch ex As Exception

                End Try
                Try
                    dao.fields.lcnsid = dao_lcn.fields.lcnsid
                Catch ex As Exception

                End Try

                dao.fields.STATUS_ID = STATUS_ID
                dao.update()


                'Dim ws_118 As New WS_AUTHENTICATION.Authentication
                'Dim ws_66 As New Authentication_66.Authentication
                'Dim ws_104 As New AUTHENTICATION_104.Authentication
                'Try
                '    ws_118.Timeout = 10000
                '    ws_118.AUTHEN_LOG_DATA(_CLS.TOKEN, _CLS.CITIZEN_ID, _CLS.SYSTEM_ID, _CLS.GROUPS, _CLS.ID_MENU, "DRUG", 0, HttpContext.Current.Request.Url.AbsoluteUri, "พิจารณาคำขอเภสัชเคมีภัณฑ์", _ProcessID)
                'Catch ex As Exception
                '    Try
                '        ws_66.Timeout = 10000
                '        ws_66.AUTHEN_LOG_DATA(_CLS.TOKEN, _CLS.CITIZEN_ID, _CLS.SYSTEM_ID, _CLS.GROUPS, _CLS.ID_MENU, "DRUG", 0, HttpContext.Current.Request.Url.AbsoluteUri, "พิจารณาคำขอเภสัชเคมีภัณฑ์", _ProcessID)

                '    Catch ex2 As Exception
                '        Try
                '            ws_104.Timeout = 10000
                '            ws_104.AUTHEN_LOG_DATA(_CLS.TOKEN, _CLS.CITIZEN_ID, _CLS.SYSTEM_ID, _CLS.GROUPS, _CLS.ID_MENU, "DRUG", 0, HttpContext.Current.Request.Url.AbsoluteUri, "พิจารณาคำขอเภสัชเคมีภัณฑ์", _ProcessID)

                '        Catch ex3 As Exception
                '            System.Web.UI.ScriptManager.RegisterStartupScript(Page, GetType(Page), "Codeblock", "alert('เกิดข้อผิดพลาดการเชื่อมต่อ');window.location.href = 'http://privus.fda.moph.go.th';", True)
                '        End Try
                '    End Try
                'End Try

                AddLogStatus(10, dao.fields.PROCESS_ID, CITIZEN_ID, IDA)
                result = "ยืนยันการพิจารณาเรียบร้อยแล้ว"
            End If
            Return Json(result, JsonRequestBehavior.AllowGet)
        End Function
        Function UPDATE_STATUS_DH(ByVal IDA As Integer, ByVal CITIZEN_ID As String) As JsonResult
            Dim result As String = ""
            Dim lcn_ida As Integer = 0
            Dim type_rqt As Integer = 0
            Dim country As Integer = 0
            Dim _process As String = ""
            Dim dao As New DAO_DRUG.ClsDBdh15rqt
            dao.GetDataby_IDA(IDA)
            Try
                _process = dao.fields.PROCESS_ID
            Catch ex As Exception

            End Try
            Try
                lcn_ida = dao.fields.FK_IDA
            Catch ex As Exception

            End Try
            Try
                If dao.fields.lcntpcd = "ผย1" Then
                    type_rqt = 1
                End If
            Catch ex As Exception

            End Try
            Try
                country = Trim(dao.fields.FOREIGN_COUNTRY_CD)
            Catch ex As Exception

            End Try
            'If _process <> 15 Then
            If type_rqt = 1 And country <> 233 Then
                result = "ไม่สามารถจดแจ้งสถานที่ผลิตต่างประเทศภายใต้ใบอนุญาตผลิตยาได้"
            Else
                If _process = 16 Or _process = 17 Or _process = 18 Then
                    dao.fields.STATUS_ID = 8

                    Dim RCVNO As String = ""
                    Dim run_number As String = ""
                    Dim dao2 As New DAO_DRUG.TB_DH15_DETAIL_CASCHEMICAL
                    dao2.GetDataby_FK_IDA(IDA)
                    Dim bao2 As New BAO_GENNO.GenNumber
                    RCVNO = bao2.GEN_NO_04(con_year(Date.Now.Year()), 10, _process, "", "", 0, IDA, "")
                    dao.fields.rcvno = RCVNO
                    dao.fields.RCVNO_DISPLAY = bao2.FORMAT_NUMBER_MINI(con_year(Date.Now.Year()), RCVNO)
                    dao.fields.rcvdate = Date.Now
                    dao.fields.RCVDATE_DISPLAY = Date.Now.ToShortDateString()
                    dao.fields.REQUEST_DATE = Date.Now

                    Dim dao_lcn As New DAO_DRUG.ClsDBdalcn
                    dao_lcn.GetDataby_IDA(lcn_ida)
                    Try
                        dao.fields.lcntpcd = dao_lcn.fields.lcntpcd
                    Catch ex As Exception

                    End Try
                    Try
                        dao.fields.pvnabbr = dao_lcn.fields.pvnabbr
                    Catch ex As Exception

                    End Try
                    Try
                        dao.fields.lcnsid = dao_lcn.fields.lcnsid
                    Catch ex As Exception

                    End Try
                    'For Each dao2.fields In dao2.datas
                    Dim CAS_ID As Integer = 0
                    Dim dao_cas As New DAO_DRUG.TB_MAS_CHEMICAL
                    Try
                        CAS_ID = RTrim(LTrim(dao2.fields.CAS_ID))
                    Catch ex As Exception

                    End Try
                    dao_cas.GetDataby_IDA(CAS_ID)
                    Dim _YEARS As Integer = con_year(Date.Now.Year)

                    Dim bao As New BAO_GENNO.GenNumber 'test

                    run_number = bao.GEN_DH15TDGT_NO(_YEARS, dao_cas.fields.aori, _process, IDA, dao2.fields.IDA, dao.fields.QUOTA_TYPE)

                    Dim dao3 As New DAO_DRUG.TB_DH15_DETAIL_CASCHEMICAL
                    dao3.GetDataby_IDA(dao2.fields.IDA)
                    If Len(dao3.fields.phm15dgt) = 0 Then
                        dao3.fields.phm15dgt = run_number
                        dao3.update()
                    End If
                    dao.update()

                    '-------------เปิดตอนอัพจริง
                    'Dim ws_update As New WS_DRUG_126.WS_DRUG
                    'ws_update.DRUG_INSERT_DH15_126(IDA, dao.fields.CITIZEN_ID_AUTHORIZE)

                    AddLogStatus(8, _process, CITIZEN_ID, IDA)
                    result = "ยื่นคำขอเรียบร้อยแล้ว เลขจดแจ้ง 15 หลักคือ คือ " & run_number
                Else

                    If chk_exp(IDA) > 0 Then
                        If _process = 14 Then
                            dao.fields.STATUS_ID = 10

                            Dim RCVNO As String = ""
                            Dim run_number As String = ""
                            Dim bao2 As New BAO_GENNO.GenNumber
                            RCVNO = bao2.GEN_NO_04(con_year(Date.Now.Year()), 10, _process, "", "", 0, IDA, "")
                            dao.fields.rcvno = RCVNO
                            dao.fields.RCVNO_DISPLAY = bao2.FORMAT_NUMBER_MINI(con_year(Date.Now.Year()), RCVNO)
                            dao.fields.rcvdate = Date.Now
                            dao.fields.RCVDATE_DISPLAY = Date.Now.ToShortDateString()
                            dao.fields.REQUEST_DATE = Date.Now

                            Dim dao_lcn As New DAO_DRUG.ClsDBdalcn
                            dao_lcn.GetDataby_IDA(lcn_ida)
                            Try
                                dao.fields.lcntpcd = dao_lcn.fields.lcntpcd
                            Catch ex As Exception

                            End Try
                            Try
                                dao.fields.pvnabbr = dao_lcn.fields.pvnabbr
                            Catch ex As Exception

                            End Try
                            Try
                                dao.fields.lcnsid = dao_lcn.fields.lcnsid
                            Catch ex As Exception

                            End Try
                            dao.update()
                        ElseIf _process = 15 Then
                            AddLogStatus(2, _process, CITIZEN_ID, IDA)
                            dao.fields.STATUS_ID = 2
                            dao.fields.REQUEST_DATE = Date.Now
                            dao.update()
                            result = "ยื่นคำขอเรียบร้อยแล้ว"
                        End If
                    Else
                        result = "ไม่สามารถยื่นได้เนื่องจาก Cert ของท่านหมดอายุ"
                    End If



                End If




            End If

            Return Json(result, JsonRequestBehavior.AllowGet)
        End Function
        Private Function chk_exp(ByVal IDA As Integer) As Integer
            Dim i As Integer = 0
            Dim dao_cer As New DAO_DRUG.TB_DH15_DETAIL_CER
            dao_cer.GetDataby_FK_IDA(IDA)
            Try
                If dao_cer.fields.EXP_DOCUMENT_DATE >= CDate(Date.Now) Then
                    i = 1
                End If
            Catch ex As Exception

            End Try
            Return i
        End Function
        Private Function Bind_Date(ByVal _date As Date) As Date
            Dim ws As New WS_GETDATE_WORKING.BasicHttpBinding_IService1
            Dim date_result As Date
            ws.GETDATE_WORKING(_date, True, 5, True, date_result, True)
            Return date_result
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
            dao.fields.IDENTIFY = bb.session.CITIZEN_ID_AUTHORIZE
            dao.fields.PROCESS_ID = _ProcessID
            dao.fields.CER_TYPE = _ProcessID
            dao.fields.TR_ID = tr_id
            dao.fields.FK_IDA = bb.session.LCN_IDA
            dao.fields.STATUS_ID = 1
            dao.fields.CREATE_DATE = Date.Now
            dao.fields.REQUEST_DATE = Date.Now

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

        Function INSERT_DH(ByVal XML_DH As String, ByVal XML_CHEM As String, ByVal _ProcessID As String) As JsonResult

            Dim Result As String

            Try
                Dim jss As New JavaScriptSerializer
                Dim bb As MODEL_DH = jss.Deserialize(XML_DH, GetType(MODEL_DH))

                Dim bao_tran As New BAO
                Dim tr_id As Integer = 0

                tr_id = bao_tran.insert_transection_new(_ProcessID, bb.session.CITIZEN_ID, bb.session.CITIZEN_ID_AUTHORIZE)
                Dim dao As New DAO_DRUG.ClsDBdh15rqt

                dao.fields = bb.dh15rqt
                dao.fields.LCN_IDA = bb.session.LCN_IDA
                dao.fields.TR_ID = tr_id
                dao.fields.STATUS_ID = 1
                dao.fields.REQUEST_DATE = Date.Now
                dao.fields.PROCESS_ID = _ProcessID
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
                Dim ii As Integer = 1
                Dim dao_chem_dh As New DAO_DRUG.TB_DH15_DETAIL_CASCHEMICAL
                dao_chem_dh.Details = jss.Deserialize(XML_CHEM, GetType(List(Of DH15_DETAIL_CASCHEMICAL)))
                For Each dao_chem_dh.fields In dao_chem_dh.Details
                    dao_chem_dh.fields.FK_IDA = IDA
                    dao_chem_dh.fields.ROW_ID = ii
                    dao_chem_dh.fields.TR_ID = tr_id
                    dao_chem_dh.insert()
                    dao_chem_dh = New DAO_DRUG.TB_DH15_DETAIL_CASCHEMICAL
                    ii += 1
                Next


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
            dao.fields.FK_IDA = bb.session.LCN_IDA
            dao.fields.rcvno = 0
            dao.fields.CITIZEN_ID_AUTHORIZE = bb.session.CITIZEN_ID_AUTHORIZE
            dao.fields.PROCESS_ID = _ProcessID
            dao.insert()

            Return Json(Result, JsonRequestBehavior.AllowGet)
        End Function
        Function INSERT_LCN_INPUT_NEW(ByVal XML_LCN As String, ByVal XML_KEEP As String, ByVal XML_PHR As String, ByVal PROCESS As String, ByVal LCT_IDA As String) As JsonResult
            Dim _pvncd As String = ""
            Dim Result As String = ""
            Dim jss As New JavaScriptSerializer
            Dim bb As MODEL_LCN = jss.Deserialize(XML_LCN, GetType(MODEL_LCN))
            'Dim keep As MODEL_LCN = jss.Deserialize(XML_KEEP, GetType(MODEL_LCN))
            'Dim phr As MODEL_LCN = jss.Deserialize(XML_PHR, GetType(MODEL_LCN))
            Dim bao_tran As New BAO
            Dim tr_id As Integer = 0

            tr_id = bao_tran.insert_transection_new(PROCESS, bb.session.CITIZEN_ID, bb.session.CITIZEN_ID_AUTHORIZE)

            Try
                _pvncd = Personal_Province_NEW(bb.session.CITIZEN_ID, bb.session.CITIZEN_ID_AUTHORIZE, bb.session.GROUPS)
                If _pvncd = 0 Then
                    _pvncd = bb.session.PVCODE
                End If
            Catch ex As Exception
                _pvncd = 10
            End Try

            Dim dao As New DAO_DRUG.ClsDBdalcn
            dao.fields = bb.dalcn

            'dao.fields.IMAGE_BSN = bb.dalcns.IMAGE_BSN
            Try
                'dao.fields.WRITE_DATE = CDate(CStr(CDate(bb.dalcn.WRITE_DATE).Year) & "/" & CStr(CDate(bb.dalcn.WRITE_DATE).Month) & "/" & CStr(CDate(bb.dalcn.WRITE_DATE).Day))
                dao.fields.WRITE_DATE = CStr(CDate(bb.dalcn.WRITE_DATE).Year) & "-" & CStr(CDate(bb.dalcn.WRITE_DATE).Month) & "-" & CStr(CDate(bb.dalcn.WRITE_DATE).Day)
            Catch ex As Exception

            End Try
            dao.fields.lcnsid = dao.fields.lcnsid
            dao.fields.PROCESS_ID = PROCESS
            dao.fields.IDENTIFY = bb.session.CITIZEN_ID_AUTHORIZE
            dao.fields.CITIZEN_ID_AUTHORIZE = bb.session.CITIZEN_ID_AUTHORIZE
            dao.fields.rcvdate = Nothing
            dao.fields.lmdfdate = Date.Now
            dao.fields.STATUS_ID = 1
            dao.fields.rcvno = 0
            dao.fields.TR_ID = tr_id
            dao.fields.FK_IDA = LCT_IDA
            dao.fields.CTZNO = bb.session.CITIZEN_ID
            dao.fields.lcntpcd = set_lcntpcd(PROCESS)
            dao.fields.CITIZEN_ID_UPLOAD = bb.session.CITIZEN_ID

            Try
                If PROCESS > 121 Then
                    dao.fields.MAIN_LCN_IDA = bb.session.HEAD_LCN_IDA
                End If
            Catch ex As Exception

            End Try
            Try
                dao.fields.pvncd = _pvncd
            Catch ex As Exception

            End Try
            Try
                dao.fields.chngwtcd = _pvncd
            Catch ex As Exception

            End Try
            Dim chw As String = ""
            Dim dao_cpn As New DAO_CPN.clsDBsyschngwt
            Try
                dao_cpn.GetData_by_chngwtcd(_pvncd)
                chw = dao_cpn.fields.thacwabbr
            Catch ex As Exception

            End Try
            dao.fields.pvnabbr = chw

            'If Request.QueryString("staff") <> "" Then
            '    dao.fields.OTHER = "1"
            'End If
            Dim dao_syslcnsnm As New DAO_CPN.clsDBsyslcnsnm
            dao_syslcnsnm.GetDataby_identify(bb.session.CITIZEN_ID_AUTHORIZE)
            dao.fields.thanm = dao_syslcnsnm.fields.thanm
            dao.fields.syslcnsnm_ID = dao_syslcnsnm.fields.ID
            dao.fields.syslcnsnm_identify = dao_syslcnsnm.fields.identify
            dao.fields.syslcnsnm_lcnsid = dao_syslcnsnm.fields.lcnsid
            dao.fields.syslcnsnm_lcnscd = dao_syslcnsnm.fields.lcnscd
            dao.fields.syslcnsnm_prefixcd = dao_syslcnsnm.fields.prefixcd
            dao.fields.syslcnsnm_prefixnm = dao_syslcnsnm.fields.prefixnm
            dao.fields.syslcnsnm_thanm = dao_syslcnsnm.fields.thanm
            dao.fields.syslcnsnm_engnm = dao_syslcnsnm.fields.engnm
            dao.fields.syslcnsnm_lctcd = dao_syslcnsnm.fields.lctcd
            dao.fields.syslcnsnm_thalnm = dao_syslcnsnm.fields.thalnm
            dao.fields.syslcnsnm_englnm = dao_syslcnsnm.fields.englnm
            dao.fields.syslcnsnm_suffixcd = dao_syslcnsnm.fields.suffixcd
            dao.fields.syslcnsnm_lcnsst = dao_syslcnsnm.fields.lcnsst
            dao.fields.syslcnsnm_grplcnscd = dao_syslcnsnm.fields.grplcnscd
            dao.fields.syslcnsnm_bsncd = dao_syslcnsnm.fields.bsncd
            dao.fields.syslcnsnm_lstfcd = dao_syslcnsnm.fields.lstfcd
            dao.fields.syslcnsnm_lmdfdate = dao_syslcnsnm.fields.lmdfdate
            dao.fields.syslcnsnm_lcnsidst = dao_syslcnsnm.fields.lcnsidst
            dao.fields.syslcnsnm_validdate = dao_syslcnsnm.fields.validdate
            dao.fields.syslcnsnm_oldid = dao_syslcnsnm.fields.oldid
            dao.fields.syslcnsnm_type = dao_syslcnsnm.fields.type
            dao.fields.syslcnsnm_update_date = dao_syslcnsnm.fields.update_date
            dao.fields.syslcnsnm_create_date = dao_syslcnsnm.fields.create_date


            Dim dao_location_address As New DAO_DRUG.TB_DALCN_LOCATION_ADDRESS
            dao_location_address.GetDataby_IDA(LCT_IDA)
            dao.fields.LOCATION_ADDRESS_thathmblnm = dao_location_address.fields.thanameplace
            dao.fields.LOCATION_ADDRESS_thaaddr = dao_location_address.fields.thaaddr
            dao.fields.LOCATION_ADDRESS_thasoi = dao_location_address.fields.thasoi
            dao.fields.LOCATION_ADDRESS_tharoad = dao_location_address.fields.tharoad
            dao.fields.LOCATION_ADDRESS_thamu = dao_location_address.fields.thamu
            dao.fields.LOCATION_ADDRESS_thathmblnm = dao_location_address.fields.thathmblnm
            dao.fields.LOCATION_ADDRESS_thaamphrnm = dao_location_address.fields.thaamphrnm
            dao.fields.LOCATION_ADDRESS_thachngwtnm = dao_location_address.fields.thachngwtnm
            dao.fields.LOCATION_ADDRESS_tel = dao_location_address.fields.tel
            dao.fields.LOCATION_ADDRESS_fax = dao_location_address.fields.fax
            dao.fields.LOCATION_ADDRESS_thanameplace = dao_location_address.fields.thanameplace
            dao.fields.LOCATION_ADDRESS_thaaddr = dao_location_address.fields.thaaddr
            dao.fields.LOCATION_ADDRESS_thasoi = dao_location_address.fields.thasoi
            dao.fields.LOCATION_ADDRESS_tharoad = dao_location_address.fields.tharoad
            dao.fields.LOCATION_ADDRESS_thamu = dao_location_address.fields.thamu
            dao.fields.LOCATION_ADDRESS_thathmblnm = dao_location_address.fields.thathmblnm
            dao.fields.LOCATION_ADDRESS_thaamphrnm = dao_location_address.fields.thaamphrnm
            dao.fields.LOCATION_ADDRESS_thachngwtnm = dao_location_address.fields.thachngwtnm
            dao.fields.LOCATION_ADDRESS_tel = dao_location_address.fields.tel
            dao.fields.LOCATION_ADDRESS_fax = dao_location_address.fields.fax
            dao.fields.LOCATION_ADDRESS_lcnsid = dao_location_address.fields.lcnsid
            dao.fields.LOCATION_ADDRESS_engaddr = dao_location_address.fields.engaddr
            dao.fields.LOCATION_ADDRESS_tharoom = dao_location_address.fields.tharoom
            dao.fields.LOCATION_ADDRESS_thabuilding = dao_location_address.fields.thabuilding
            dao.fields.LOCATION_ADDRESS_engsoi = dao_location_address.fields.engsoi
            dao.fields.LOCATION_ADDRESS_engroad = dao_location_address.fields.engroad
            dao.fields.LOCATION_ADDRESS_zipcode = dao_location_address.fields.zipcode
            dao.fields.LOCATION_ADDRESS_lstfcd = dao_location_address.fields.lstfcd
            dao.fields.LOCATION_ADDRESS_lmdfdate = dao_location_address.fields.lmdfdate
            dao.fields.LOCATION_ADDRESS_IDA = dao_location_address.fields.IDA
            dao.fields.LOCATION_ADDRESS_FK_IDA = dao_location_address.fields.FK_IDA
            dao.fields.LOCATION_ADDRESS_TR_ID = dao_location_address.fields.TR_ID
            dao.fields.LOCATION_ADDRESS_DOWN_ID = dao_location_address.fields.DOWN_ID
            dao.fields.LOCATION_ADDRESS_CITIZEN_ID = dao_location_address.fields.CITIZEN_ID
            dao.fields.LOCATION_ADDRESS_CITIZEN_ID_UPLOAD = dao_location_address.fields.CITIZEN_ID_UPLOAD
            dao.fields.LOCATION_ADDRESS_XMLNAME = dao_location_address.fields.XMLNAME
            dao.fields.LOCATION_ADDRESS_engmu = dao_location_address.fields.engmu
            dao.fields.LOCATION_ADDRESS_engfloor = dao_location_address.fields.engfloor
            dao.fields.LOCATION_ADDRESS_engbuilding = dao_location_address.fields.engbuilding
            dao.fields.LOCATION_ADDRESS_rcvno = dao_location_address.fields.rcvno
            dao.fields.LOCATION_ADDRESS_rcvdate = dao_location_address.fields.rcvdate
            dao.fields.LOCATION_ADDRESS_lctcd = dao_location_address.fields.lctcd
            dao.fields.LOCATION_ADDRESS_engnameplace = dao_location_address.fields.engnameplace
            dao.fields.LOCATION_ADDRESS_STATUS_ID = dao_location_address.fields.STATUS_ID
            dao.fields.LOCATION_ADDRESS_HOUSENO = dao_location_address.fields.HOUSENO
            dao.fields.LOCATION_ADDRESS_Branch = dao_location_address.fields.Branch
            dao.fields.LOCATION_ADDRESS_LOCATION_TYPE_NORMAL = dao_location_address.fields.LOCATION_TYPE_NORMAL
            dao.fields.LOCATION_ADDRESS_LOCATION_TYPE_OTHER = dao_location_address.fields.LOCATION_TYPE_OTHER
            dao.fields.LOCATION_ADDRESS_LOCATION_TYPE_ID = dao_location_address.fields.LOCATION_TYPE_ID
            dao.fields.LOCATION_ADDRESS_SYSTEM_NAME = dao_location_address.fields.SYSTEM_NAME
            dao.fields.LOCATION_ADDRESS_thmblcd = dao_location_address.fields.thmblcd
            dao.fields.LOCATION_ADDRESS_chngwtcd = dao_location_address.fields.chngwtcd
            dao.fields.LOCATION_ADDRESS_engthmblnm = dao_location_address.fields.engthmblnm
            dao.fields.LOCATION_ADDRESS_engamphrnm = dao_location_address.fields.engamphrnm
            dao.fields.LOCATION_ADDRESS_engchngwtnm = dao_location_address.fields.engchngwtnm
            dao.fields.LOCATION_ADDRESS_IDENTIFY = dao_location_address.fields.IDENTIFY
            dao.fields.LOCATION_ADDRESS_REMARK = dao_location_address.fields.REMARK


            'Dim dao_location_bsn As New DAO_CPN.TB_LOCATION_BSN
            'dao_location_bsn.Getdata_by_fk_id2(dao_location_address.fields.IDA)
            Dim bsn_den As String = ""
            Try
                bsn_den = Trim(bb.BSN_IDENTIFY)
            Catch ex As Exception

            End Try

            Dim dao_syslcnsnm2 As New DAO_CPN.clsDBsyslcnsnm
            dao_syslcnsnm2.GetDataby_identify(bsn_den)
            Try
                dao.fields.bsncd = dao_syslcnsnm2.fields.lcnsid
            Catch ex As Exception

            End Try
            Dim bao_show11 As New BAO
            Dim dt_bsn As DataTable = bao_show11.SP_LOCATION_BSN_BY_IDENTIFY(bsn_den)
            For Each dr As DataRow In dt_bsn.Rows
                Try
                    dao.fields.BSN_THAIFULLNAME = dr("BSN_THAIFULLNAME")
                Catch ex As Exception

                End Try
                Try
                    dao.fields.BSN_IDENTIFY = dr("BSN_IDENTIFY")
                Catch ex As Exception

                End Try
                Try
                    dao.fields.BSN_ADDR = dr("BSN_ADDR")
                Catch ex As Exception

                End Try
                Try
                    dao.fields.BSN_SOI = dr("BSN_SOI")
                Catch ex As Exception

                End Try
                Try
                    dao.fields.BSN_ROAD = dr("BSN_ROAD")
                Catch ex As Exception

                End Try
                Try
                    dao.fields.BSN_MOO = dr("BSN_MOO")
                Catch ex As Exception

                End Try
                Try
                    dao.fields.BSN_THMBL_NAME = dr("BSN_THMBL_NAME")
                Catch ex As Exception

                End Try
                Try
                    dao.fields.BSN_AMPHR_NAME = dr("BSN_AMPHR_NAME")
                Catch ex As Exception

                End Try
                Try
                    dao.fields.BSN_CHWNGNAME = dr("BSN_CHWNGNAME")
                Catch ex As Exception

                End Try
                Try
                    dao.fields.BSN_TELEPHONE = dr("BSN_TELEPHONE")
                Catch ex As Exception

                End Try
                Try
                    dao.fields.BSN_FAX = dr("BSN_FAX")
                Catch ex As Exception

                End Try
                Try
                    dao.fields.BSN_THAINAME = dr("BSN_THAINAME")
                Catch ex As Exception

                End Try
                Try
                    dao.fields.BSN_THAILASTNAME = dr("BSN_THAILASTNAME")
                Catch ex As Exception

                End Try
                Try
                    dao.fields.BSN_PREFIXENGCD = dr("BSN_PREFIXENGCD")
                Catch ex As Exception

                End Try
                Try
                    dao.fields.BSN_ENGNAME = dr("BSN_ENGNAME")
                Catch ex As Exception

                End Try
                Try
                    dao.fields.BSN_ENGLASTNAME = dr("BSN_ENGLASTNAME")
                Catch ex As Exception

                End Try
                Try
                    dao.fields.BSN_ENGFULLNAME = dr("BSN_ENGFULLNAME")
                Catch ex As Exception

                End Try
                Try
                    dao.fields.CHANGWAT_ID = dr("CHANGWAT_ID")
                Catch ex As Exception

                End Try
                Try
                    dao.fields.AMPHR_ID = dr("AMPHR_ID")
                Catch ex As Exception

                End Try
                Try
                    dao.fields.TUMBON_ID = dr("TUMBON_ID")
                Catch ex As Exception

                End Try
                Try
                    dao.fields.BSN_FLOOR = dr("BSN_FLOOR")
                Catch ex As Exception

                End Try
                Try
                    dao.fields.BSN_BUILDING = dr("BSN_BUILDING")
                Catch ex As Exception

                End Try
                Try
                    dao.fields.BSN_ZIPCODE = dr("BSN_ZIPCODE")
                Catch ex As Exception

                End Try
                Try
                    dao.fields.CREATE_DATE = dr("CREATE_DATE")
                Catch ex As Exception

                End Try
                Try
                    dao.fields.DOWN_ID = dr("DOWN_ID")
                Catch ex As Exception

                End Try
                Try
                    dao.fields.CITIZEN_ID = dr("CITIZEN_ID")
                Catch ex As Exception

                End Try
                Try
                    dao.fields.XMLNAME = dr("XMLNAME")
                Catch ex As Exception

                End Try
                Try
                    dao.fields.NATIONALITY = dr("NATIONALITY")
                Catch ex As Exception

                End Try
                Try
                    dao.fields.BSN_HOUSENO = dr("BSN_HOUSENO")
                Catch ex As Exception

                End Try
                Try
                    dao.fields.BSN_ENGADDR = dr("BSN_ENGADDR")
                Catch ex As Exception

                End Try
                Try
                    dao.fields.BSN_ENGMU = dr("BSN_ENGMU")
                Catch ex As Exception

                End Try
                Try
                    dao.fields.BSN_ENGSOI = dr("BSN_ENGSOI")
                Catch ex As Exception

                End Try
                Try
                    dao.fields.BSN_ENGROAD = dr("BSN_ENGROAD")
                Catch ex As Exception

                End Try
                Try
                    dao.fields.BSN_CHWNG_ENGNAME = dr("BSN_CHWNG_ENGNAME")
                Catch ex As Exception

                End Try
                Try
                    dao.fields.BSN_AMPHR_ENGNAME = dr("BSN_AMPHR_ENGNAME")
                Catch ex As Exception

                End Try
                Try
                    dao.fields.BSN_THMBL_ENGNAME = dr("BSN_THMBL_ENGNAME")
                Catch ex As Exception

                End Try
                Try
                    dao.fields.BSN_NATIONALITY_CD = dr("BSN_NATIONALITY_CD")
                Catch ex As Exception

                End Try
                Try
                    dao.fields.AGE = dr("AGE")
                Catch ex As Exception

                End Try
            Next
            dao.insert()


            Dim opentime As String = ""
            Dim dao_cn As New DAO_DRUG.ClsDBdalcn
            Try
                opentime = bb.dalcn.opentime
            Catch ex As Exception

            End Try
            For Each dr As DataRow In dt_bsn.Rows
                Dim dao_bsn As New DAO_DRUG.TB_DALCN_LOCATION_BSN
                Try
                    dao_bsn.fields.BSN_THAIFULLNAME = dr("BSN_THAIFULLNAME")
                Catch ex As Exception

                End Try
                Try
                    dao_bsn.fields.BSN_IDENTIFY = dr("BSN_IDENTIFY")
                Catch ex As Exception

                End Try
                Try
                    dao_bsn.fields.BSN_ADDR = dr("BSN_ADDR")
                Catch ex As Exception

                End Try
                Try
                    dao_bsn.fields.BSN_SOI = dr("BSN_SOI")
                Catch ex As Exception

                End Try
                Try
                    dao_bsn.fields.BSN_ROAD = dr("BSN_ROAD")
                Catch ex As Exception

                End Try
                Try
                    dao_bsn.fields.BSN_MOO = dr("BSN_MOO")
                Catch ex As Exception

                End Try
                Try
                    dao_bsn.fields.BSN_THMBL_NAME = dr("BSN_THMBL_NAME")
                Catch ex As Exception

                End Try
                Try
                    dao_bsn.fields.BSN_AMPHR_NAME = dr("BSN_AMPHR_NAME")
                Catch ex As Exception

                End Try
                Try
                    dao_bsn.fields.BSN_CHWNGNAME = dr("BSN_CHWNGNAME")
                Catch ex As Exception

                End Try
                Try
                    dao_bsn.fields.BSN_TELEPHONE = dr("BSN_TELEPHONE")
                Catch ex As Exception

                End Try
                Try
                    dao_bsn.fields.BSN_FAX = dr("BSN_FAX")
                Catch ex As Exception

                End Try
                Try
                    dao_bsn.fields.BSN_THAINAME = dr("BSN_THAINAME")
                Catch ex As Exception

                End Try
                Try
                    dao_bsn.fields.BSN_THAILASTNAME = dr("BSN_THAILASTNAME")
                Catch ex As Exception

                End Try
                Try
                    dao_bsn.fields.BSN_PREFIXENGCD = dr("BSN_PREFIXENGCD")
                Catch ex As Exception

                End Try
                Try
                    dao_bsn.fields.BSN_ENGNAME = dr("BSN_ENGNAME")
                Catch ex As Exception

                End Try
                Try
                    dao_bsn.fields.BSN_ENGLASTNAME = dr("BSN_ENGLASTNAME")
                Catch ex As Exception

                End Try
                Try
                    dao_bsn.fields.BSN_ENGFULLNAME = dr("BSN_ENGFULLNAME")
                Catch ex As Exception

                End Try
                Try
                    dao_bsn.fields.CHANGWAT_ID = dr("CHANGWAT_ID")
                Catch ex As Exception

                End Try
                Try
                    dao_bsn.fields.AMPHR_ID = dr("AMPHR_ID")
                Catch ex As Exception

                End Try
                Try
                    dao_bsn.fields.TUMBON_ID = dr("TUMBON_ID")
                Catch ex As Exception

                End Try
                Try
                    dao_bsn.fields.BSN_FLOOR = dr("BSN_FLOOR")
                Catch ex As Exception

                End Try
                Try
                    dao_bsn.fields.BSN_BUILDING = dr("BSN_BUILDING")
                Catch ex As Exception

                End Try
                Try
                    dao_bsn.fields.BSN_ZIPCODE = dr("BSN_ZIPCODE")
                Catch ex As Exception

                End Try
                Try
                    dao_bsn.fields.CREATE_DATE = dr("CREATE_DATE")
                Catch ex As Exception

                End Try
                Try
                    dao_bsn.fields.DOWN_ID = dr("DOWN_ID")
                Catch ex As Exception

                End Try
                Try
                    dao_bsn.fields.CITIZEN_ID = dr("CITIZEN_ID")
                Catch ex As Exception

                End Try
                Try
                    dao_bsn.fields.XMLNAME = dr("XMLNAME")
                Catch ex As Exception

                End Try
                Try
                    dao_bsn.fields.NATIONALITY = dr("NATIONALITY")
                Catch ex As Exception

                End Try
                Try
                    dao_bsn.fields.BSN_HOUSENO = dr("BSN_HOUSENO")
                Catch ex As Exception

                End Try
                Try
                    dao_bsn.fields.BSN_ENGADDR = dr("BSN_ENGADDR")
                Catch ex As Exception

                End Try
                Try
                    dao_bsn.fields.BSN_ENGMU = dr("BSN_ENGMU")
                Catch ex As Exception

                End Try
                Try
                    dao_bsn.fields.BSN_ENGSOI = dr("BSN_ENGSOI")
                Catch ex As Exception

                End Try
                Try
                    dao_bsn.fields.BSN_ENGROAD = dr("BSN_ENGROAD")
                Catch ex As Exception

                End Try
                Try
                    dao_bsn.fields.BSN_CHWNG_ENGNAME = dr("BSN_CHWNG_ENGNAME")
                Catch ex As Exception

                End Try
                Try
                    dao_bsn.fields.BSN_AMPHR_ENGNAME = dr("BSN_AMPHR_ENGNAME")
                Catch ex As Exception

                End Try
                Try
                    dao_bsn.fields.BSN_THMBL_ENGNAME = dr("BSN_THMBL_ENGNAME")
                Catch ex As Exception

                End Try
                Try
                    dao_bsn.fields.BSN_NATIONALITY_CD = dr("BSN_NATIONALITY_CD")
                Catch ex As Exception

                End Try
                Try
                    dao_bsn.fields.AGE = dr("AGE")
                Catch ex As Exception

                End Try
                dao_bsn.fields.LCN_IDA = dao.fields.IDA
                dao_bsn.fields.FK_IDA = dao.fields.FK_IDA
                dao_bsn.insert()
            Next

            '---------------------ที่เก็บ--------------------------------
            Dim dao_KEEP_bb As New DAO_DRUG.TB_DALCN_DETAIL_LOCATION_KEEP

            dao_KEEP_bb.Details = jss.Deserialize(XML_KEEP, GetType(List(Of DALCN_DETAIL_LOCATION_KEEP)))


            Dim dao_DALCN_DETAIL_LOCATION_KEEP As New DAO_DRUG.TB_DALCN_DETAIL_LOCATION_KEEP
            For Each dao_DALCN_DETAIL_LOCATION_KEEP.fields In dao_KEEP_bb.Details
                Dim LOCATION_IDA As Integer
                If Integer.TryParse(dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_IDA, LOCATION_IDA) = True Then
                    Dim dao_LOCATION_ADDRESS_2 As New DAO_DRUG.TB_DALCN_LOCATION_ADDRESS
                    dao_LOCATION_ADDRESS_2.GetDataby_IDA(LOCATION_IDA)
                    dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_Branch = dao_LOCATION_ADDRESS_2.fields.Branch
                    Try
                        dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_chngwtcd = dao_LOCATION_ADDRESS_2.fields.chngwtcd
                    Catch ex As Exception

                    End Try
                    dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_CITIZEN_ID = bb.session.CITIZEN_ID

                    Try
                        dao_DALCN_DETAIL_LOCATION_KEEP.fields.TR_ID = tr_id
                    Catch ex As Exception

                    End Try
                    Try
                        dao_DALCN_DETAIL_LOCATION_KEEP.fields.FK_IDA = dao.fields.IDA
                    Catch ex As Exception

                    End Try
                    Try
                        dao_DALCN_DETAIL_LOCATION_KEEP.fields.LCN_IDA = dao.fields.IDA
                    Catch ex As Exception

                    End Try

                    dao_DALCN_DETAIL_LOCATION_KEEP.fields.IDENTIFY = bb.session.CITIZEN_ID_AUTHORIZE
                    If LOCATION_IDA = 0 Then
                        dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_thanameplace = "ไม่มีที่เก็บ"
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

                    Catch ex As Exception

                    End Try
                    Try
                        dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_chngwtcd = dao_LOCATION_ADDRESS_2.fields.chngwtcd
                    Catch ex As Exception

                    End Try
                    Try
                        dao_DALCN_DETAIL_LOCATION_KEEP.fields.LOCATION_ADDRESS_amphrcd = dao_LOCATION_ADDRESS_2.fields.amphrcd
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
                    dao_DALCN_DETAIL_LOCATION_KEEP = New DAO_DRUG.TB_DALCN_DETAIL_LOCATION_KEEP
                End If
            Next


            'เภสัชกร
            Dim dao_PHR_bb As New DAO_DRUG.ClsDBDALCN_PHR
            dao_PHR_bb.Details = jss.Deserialize(XML_PHR, GetType(List(Of DALCN_PHR)))

            Dim dao_DALCN_PHR As New DAO_DRUG.ClsDBDALCN_PHR
            For Each dao_DALCN_PHR.fields In dao_PHR_bb.Details
                If (dao_DALCN_PHR.fields.PHR_MEDICAL_TYPE = "1") Or (String.IsNullOrWhiteSpace(dao_DALCN_PHR.fields.PHR_MEDICAL_TYPE) = True) Then
                    'Dim PHR_NAME As String = ""
                    'Try
                    '    PHR_NAME = dao_DALCN_PHR.fields.PHR_NAME
                    'Catch ex As Exception

                    'End Try

                    If String.IsNullOrWhiteSpace(dao_DALCN_PHR.fields.PHR_NAME) = False Then
                        Dim dao_prefix As New DAO_CPN.TB_sysprefix
                        Dim PHR_PREFIX_ID As String = ""
                        Try
                            PHR_PREFIX_ID = Trim(dao_DALCN_PHR.fields.PHR_PREFIX_ID)
                        Catch ex As Exception

                        End Try
                        Try
                            dao_DALCN_PHR.fields.PHR_MEDICAL_TYPE = "1"
                        Catch ex As Exception

                        End Try
                        If PHR_PREFIX_ID <> "" Then
                            dao_prefix.Getdata_byid(PHR_PREFIX_ID)
                            dao_DALCN_PHR.fields.PHR_PREFIX_NAME = dao_prefix.fields.thanm
                            dao_DALCN_PHR.fields.PHR_PREFIX_ID = PHR_PREFIX_ID
                        Else
                            dao_DALCN_PHR.fields.PHR_PREFIX_NAME = "นาย"
                            dao_DALCN_PHR.fields.PHR_PREFIX_ID = "0"
                        End If
                        'If IsNothing(dao_DALCN_PHR.fields.PHR_PREFIX_ID) = False Then
                        '    If Integer.TryParse(dao_DALCN_PHR.fields.PHR_PREFIX_ID, PHR_PREFIX_ID) = True Then
                        '        dao_prefix.Getdata_byid(PHR_PREFIX_ID)
                        '        dao_DALCN_PHR.fields.PHR_PREFIX_NAME = dao_prefix.fields.thanm
                        '    End If

                        'End If
                        'dao_DALCN_PHR.fields.PHR_JOB_TYPE =dao_DALCN_PHR.fields.
                        Try
                            If PROCESS = "107" Or PROCESS = "108" Or PROCESS = "109" Then
                                dao_DALCN_PHR.fields.PHR_LAW_SECTION = bb.PHR_LAW_SECTION
                            End If
                        Catch ex As Exception

                        End Try
                        Try
                            dao_DALCN_PHR.fields.PHR_CHK_JOB = dao_DALCN_PHR.fields.PHR_CHK_JOB
                        Catch ex As Exception

                        End Try
                        Try
                            dao_DALCN_PHR.fields.PHR_JOB_TYPE = dao_DALCN_PHR.fields.PHR_JOB_TYPE
                        Catch ex As Exception

                        End Try
                        dao_DALCN_PHR.fields.PHR_TEXT_WORK_TIME = opentime
                        dao_DALCN_PHR.fields.TR_ID = tr_id
                        dao_DALCN_PHR.fields.FK_IDA = dao.fields.IDA
                        dao_DALCN_PHR.fields.PHR_STATUS_UPLOAD = 1
                        dao_DALCN_PHR.insert()
                        dao_DALCN_PHR = New DAO_DRUG.ClsDBDALCN_PHR


                    End If
                End If
            Next
            msg_r.MSG_DES = "เลขดำเนินการคือ " & tr_id
            msg_r.PROCESS = PROCESS
            msg_r.TR_ID = tr_id

            Return Json(msg_r, JsonRequestBehavior.AllowGet)
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
        Function INSERT_LCN_STAFF_EDIT_LCT(ByVal LCT_ID As Integer, ByVal LCN_IDA As Integer, ByVal CITIZEN_ID As String, ByVal CITIZEN_ID_AUTHORIZE As String)
            Dim Result As String = ""
            Dim dao As New DAO_DRUG.ClsDBdalcn
            dao.GetDataby_IDA(LCN_IDA)
            dao.fields.FK_IDA = LCT_ID
            dao.update()
            KEEP_LOGS_EDIT(LCN_IDA, "เลือกสถานที่ตั้งใหม่", CITIZEN_ID)

            Return Json(Result, JsonRequestBehavior.AllowGet)
        End Function
        Function INSERT_LCN_STAFF_EDIT_LCT_COPY(ByVal XML_LCT As String, ByVal LCN_IDA As Integer, ByVal CITIZEN_ID As String, ByVal CITIZEN_ID_AUTHORIZE As String)
            Dim Result As String = ""
            Dim jss As New JavaScriptSerializer
            Dim bb As MODEL_STAFF_EDIT_LCN = jss.Deserialize(XML_LCT, GetType(MODEL_STAFF_EDIT_LCN))

            Dim dao_location_addr As New DAO_DRUG.TB_DALCN_LOCATION_ADDRESS
            Dim dao_syschngwt As New DAO_CPN.clsDBsyschngwt
            Dim dao_sysamphr As New DAO_CPN.clsDBsysamphr
            Dim dao_systhmbl As New DAO_CPN.clsDBsysthmbl

            Dim chngwtcd As Integer = bb.DALCN_LOCATION_ADDRESS.chngwtcd
            Dim amphrcd As Integer = bb.DALCN_LOCATION_ADDRESS.amphrcd
            Dim thmblcd As Integer = bb.DALCN_LOCATION_ADDRESS.thmblcd


            dao_location_addr.fields.thanameplace = bb.DALCN_LOCATION_ADDRESS.thanameplace
            dao_location_addr.fields.engnameplace = bb.DALCN_LOCATION_ADDRESS.engnameplace
            dao_location_addr.fields.HOUSENO = bb.DALCN_LOCATION_ADDRESS.HOUSENO
            dao_location_addr.fields.thabuilding = bb.DALCN_LOCATION_ADDRESS.thabuilding
            dao_location_addr.fields.thafloor = bb.DALCN_LOCATION_ADDRESS.thafloor
            dao_location_addr.fields.tharoom = bb.DALCN_LOCATION_ADDRESS.tharoom
            dao_location_addr.fields.thaaddr = bb.DALCN_LOCATION_ADDRESS.thaaddr
            dao_location_addr.fields.thamu = bb.DALCN_LOCATION_ADDRESS.thamu
            dao_location_addr.fields.thasoi = bb.DALCN_LOCATION_ADDRESS.thasoi
            dao_location_addr.fields.tharoad = bb.DALCN_LOCATION_ADDRESS.tharoad
            dao_location_addr.fields.zipcode = bb.DALCN_LOCATION_ADDRESS.zipcode
            dao_location_addr.fields.tel = bb.DALCN_LOCATION_ADDRESS.tel
            dao_location_addr.fields.Mobile = bb.DALCN_LOCATION_ADDRESS.Mobile
            dao_location_addr.fields.fax = bb.DALCN_LOCATION_ADDRESS.fax

            dao_location_addr.fields.chngwtcd = chngwtcd
            dao_location_addr.fields.amphrcd = amphrcd
            dao_location_addr.fields.thmblcd = thmblcd

            dao_location_addr.fields.STATUS_ID = 8
            dao_syschngwt.GetData_by_chngwtcd(chngwtcd)
            dao_sysamphr.GetData_by_chngwtcd_amphrcd(chngwtcd, amphrcd)
            dao_systhmbl.GetData_by_chngwtcd_amphrcd_thmblcd(chngwtcd, amphrcd, thmblcd)


            dao_location_addr.fields.thachngwtnm = dao_syschngwt.fields.thachngwtnm
            dao_location_addr.fields.thaamphrnm = dao_sysamphr.fields.thaamphrnm
            dao_location_addr.fields.thathmblnm = dao_systhmbl.fields.thathmblnm

            dao_location_addr.fields.engchngwtnm = dao_syschngwt.fields.engchngwtnm
            dao_location_addr.fields.engamphrnm = dao_sysamphr.fields.engamphrnm
            dao_location_addr.fields.engthmblnm = dao_systhmbl.fields.engthmblnm

            dao_location_addr.fields.LOCATION_TYPE_ID = 1

            Dim dao_lcn As New DAO_DRUG.ClsDBdalcn
            dao_lcn.GetDataby_IDA(LCN_IDA)
            Try
                dao_location_addr.fields.IDENTIFY = dao_lcn.fields.CITIZEN_ID_AUTHORIZE
            Catch ex As Exception

            End Try

            dao_location_addr.fields.SYSTEM_NAME = "DRUG"
            Try
                dao_location_addr.fields.pvncd = dao_lcn.fields.pvncd
            Catch ex As Exception

            End Try
            Try
                dao_location_addr.fields.latitude = bb.DALCN_LOCATION_ADDRESS.latitude
                dao_location_addr.fields.longitude = bb.DALCN_LOCATION_ADDRESS.longitude
            Catch ex As Exception

            End Try
            dao_location_addr.fields.CREATE_DATE = Date.Now

            dao_location_addr.insert()

            'If Request.QueryString("ida") <> "" And Request.QueryString("t") <> "2" Then
            Dim dao As New DAO_DRUG.ClsDBdalcn
            dao.GetDataby_IDA(LCN_IDA)
            dao.fields.FK_IDA = dao_location_addr.fields.IDA
            dao.update()
            ' End If

            Return Json(Result, JsonRequestBehavior.AllowGet)
        End Function




        Function INSERT_LCN_SUBTITUTE(ByVal XML_SUB As String, ByVal FK_IDA As String, ByVal _ProcessID As String) As JsonResult

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
            dao.fields.STATUS_ID = 1
            Try
                dao.fields.REQUEST_TYPE = bb.REQUEST_TYPE
            Catch ex As Exception

            End Try

            dao.fields.FK_IDA = FK_IDA
            Try
                dao.fields.REQUEST_TYPE = bb.REQUEST_TYPE
            Catch ex As Exception

            End Try
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

        Function UPDATE_STAT_LCN(ByVal cncdate As DateTime, ByVal cnccscd As Integer, ByVal LCN_IDA As Integer, ByVal CITIZEN_ID As String, ByVal CITIZEN_ID_AUTHORIZE As String) As JsonResult
            Dim Result As String = ""
            'Dim jss As New JavaScriptSerializer
            'jss.MaxJsonLength = Int32.MaxValue
            'Dim bb As MODEL_STAFF_EDIT_LCN = jss.Deserialize(XML_LCN, GetType(MODEL_STAFF_EDIT_LCN))

            Dim dao As New DAO_DRUG.ClsDBdalcn
            dao.GetDataby_IDA(LCN_IDA)
            dao.fields.cnccscd = cnccscd
            Try
                dao.fields.cncdate = cncdate
            Catch ex As Exception

            End Try
            dao.update()

            Return Json(Result, JsonRequestBehavior.AllowGet)
        End Function

        Function UPDATE_OPENTIME_LCN(ByVal XML_LCN As String, ByVal LCN_IDA As Integer, ByVal CITIZEN_ID As String, ByVal CITIZEN_ID_AUTHORIZE As String) As JsonResult
            Dim Result As String = ""
            Dim jss As New JavaScriptSerializer
            Dim bb As MODEL_STAFF_EDIT_LCN = jss.Deserialize(XML_LCN, GetType(MODEL_STAFF_EDIT_LCN))

            Dim dao As New DAO_DRUG.ClsDBdalcn
            dao.GetDataby_IDA(LCN_IDA)
            dao.fields.opentime = bb.dalcn.opentime

            dao.update()
            KEEP_LOGS_EDIT(LCN_IDA, "แก้ไขเวลาทำการ", CITIZEN_ID)
            Return Json(Result, JsonRequestBehavior.AllowGet)
        End Function
        Function UPDATE_TEMPLATE_LCN(ByVal XML_LCN As String, ByVal LCN_IDA As Integer, ByVal CITIZEN_ID As String, ByVal CITIZEN_ID_AUTHORIZE As String) As JsonResult
            Dim Result As String = ""
            Dim jss As New JavaScriptSerializer
            Dim bb As MODEL_STAFF_EDIT_LCN = jss.Deserialize(XML_LCN, GetType(MODEL_STAFF_EDIT_LCN))

            Dim dao As New DAO_DRUG.ClsDBdalcn
            dao.GetDataby_IDA(LCN_IDA)
            dao.fields.TEMPLATE_ID = bb.dalcn.TEMPLATE_ID

            dao.update()
            KEEP_LOGS_EDIT(LCN_IDA, "แก้ไข Template เลขที่บ้านใน pdf", CITIZEN_ID)
            Return Json(Result, JsonRequestBehavior.AllowGet)
        End Function
        Function UPDATE_APPDATE_LCN(ByVal XML_LCN As String, ByVal LCN_IDA As Integer, ByVal CITIZEN_ID As String, ByVal CITIZEN_ID_AUTHORIZE As String) As JsonResult
            Dim Result As String = ""
            Dim jss As New JavaScriptSerializer
            Dim bb As MODEL_STAFF_EDIT_LCN = jss.Deserialize(XML_LCN, GetType(MODEL_STAFF_EDIT_LCN))

            Dim dao As New DAO_DRUG.ClsDBdalcn
            dao.GetDataby_IDA(LCN_IDA)
            dao.fields.appdate = bb.dalcn.appdate

            dao.update()
            KEEP_LOGS_EDIT(LCN_IDA, "แก้ไขวันที่ให้ไว้ ณ", CITIZEN_ID)
            Return Json(Result, JsonRequestBehavior.AllowGet)
        End Function

        Function UPDATE_EXPYEAR_LCN(ByVal XML_LCN As String, ByVal LCN_IDA As Integer, ByVal CITIZEN_ID As String, ByVal CITIZEN_ID_AUTHORIZE As String) As JsonResult
            Dim Result As String = ""
            Dim jss As New JavaScriptSerializer
            Dim bb As MODEL_STAFF_EDIT_LCN = jss.Deserialize(XML_LCN, GetType(MODEL_STAFF_EDIT_LCN))

            Dim dao As New DAO_DRUG.ClsDBdalcn
            dao.GetDataby_IDA(LCN_IDA)
            dao.fields.expyear = bb.dalcn.expyear

            dao.update()
            KEEP_LOGS_EDIT(LCN_IDA, "แก้ไขวันที่ให้ไว้ ณ", CITIZEN_ID)
            Return Json(Result, JsonRequestBehavior.AllowGet)
        End Function
        Function con_year(year) As String
            Dim int_year As Integer = Integer.Parse(year)
            If int_year <= 2500 Then
                int_year += 543
            End If
            Return int_year.ToString()
        End Function

        Function SEND_STATUS_PAY_TABEAN(ByVal _type_select As String, ByVal val1 As String, ByVal val2 As String, ByVal val3 As String, ByVal val4 As String, ByVal val5 As String, ByVal CITIZEN_ID As String) As JsonResult
            Dim Result As String = ""
            Dim i As Integer = 0
            If _type_select = "1" Then
                Dim dao_q As New DAO_DRUG.ClsDBdrrqt

                If Trim(val1) <> "" Then
                    dao_q.GetDataby_TR_ID_PROCESS_ID(Trim(val1), "1400001")
                    If dao_q.fields.STATUS_ID = "2" Then
                        dao_q.fields.STATUS_ID = 3
                        dao_q.update()
                        i += 1
                        INSERT_LOG_SEND_STATUS(dao_q.fields.IDA, "1400001", 3, CITIZEN_ID)
                    End If
                    'ข้ามสถานะ
                End If
                If Trim(val2) <> "" Then
                    dao_q.GetDataby_TR_ID_PROCESS_ID(Trim(val2), "1400001")
                    If dao_q.fields.STATUS_ID = "2" Then
                        dao_q.fields.STATUS_ID = 3
                        dao_q.update()
                        i += 1
                        INSERT_LOG_SEND_STATUS(dao_q.fields.IDA, "1400001", 3, CITIZEN_ID)
                    End If
                End If
                If Trim(val3) <> "" Then
                    dao_q.GetDataby_TR_ID_PROCESS_ID(Trim(val3), "1400001")
                    If dao_q.fields.STATUS_ID = "2" Then
                        dao_q.fields.STATUS_ID = 3
                        dao_q.update()
                        i += 1
                        INSERT_LOG_SEND_STATUS(dao_q.fields.IDA, "1400001", 3, CITIZEN_ID)
                    End If
                End If
                If Trim(val4) <> "" Then
                    dao_q.GetDataby_TR_ID_PROCESS_ID(Trim(val4), "1400001")
                    If dao_q.fields.STATUS_ID = "2" Then
                        dao_q.fields.STATUS_ID = 3
                        dao_q.update()
                        i += 1
                        INSERT_LOG_SEND_STATUS(dao_q.fields.IDA, "1400001", 3, CITIZEN_ID)
                    End If
                End If
                If Trim(val5) <> "" Then
                    dao_q.GetDataby_TR_ID_PROCESS_ID(Trim(val5), "1400001")
                    If dao_q.fields.STATUS_ID = "2" Then
                        dao_q.fields.STATUS_ID = 3
                        dao_q.update()
                        i += 1
                        INSERT_LOG_SEND_STATUS(dao_q.fields.IDA, "1400001", 3, CITIZEN_ID)
                    End If
                End If
            ElseIf _type_select = "2" Then
                '130099
                Dim dao_q As New DAO_DRUG.TB_DRRGT_EDIT_REQUEST

                If Trim(val1) <> "" Then
                    dao_q.GetDatabyTRID_PROCESS(Trim(val1), "130099")
                    If dao_q.fields.STATUS_ID = "2" Then
                        dao_q.fields.STATUS_ID = 3
                        dao_q.update()
                        i += 1
                        INSERT_LOG_SEND_STATUS(dao_q.fields.IDA, "130099", 3, CITIZEN_ID)
                    End If
                End If
                If Trim(val2) <> "" Then
                    dao_q.GetDatabyTRID_PROCESS(Trim(val2), "130099")
                    If dao_q.fields.STATUS_ID = "2" Then
                        dao_q.fields.STATUS_ID = 3
                        dao_q.update()
                        i += 1
                        INSERT_LOG_SEND_STATUS(dao_q.fields.IDA, "130099", 3, CITIZEN_ID)
                    End If
                End If
                If Trim(val3) <> "" Then
                    dao_q.GetDatabyTRID_PROCESS(Trim(val3), "130099")
                    If dao_q.fields.STATUS_ID = "2" Then
                        dao_q.fields.STATUS_ID = 3
                        dao_q.update()
                        i += 1
                        INSERT_LOG_SEND_STATUS(dao_q.fields.IDA, "130099", 3, CITIZEN_ID)
                    End If
                End If
                If Trim(val4) <> "" Then
                    dao_q.GetDatabyTRID_PROCESS(Trim(val4), "130099")
                    If dao_q.fields.STATUS_ID = "2" Then
                        dao_q.fields.STATUS_ID = 3
                        dao_q.update()
                        i += 1
                        INSERT_LOG_SEND_STATUS(dao_q.fields.IDA, "130099", 3, CITIZEN_ID)
                    End If
                End If
                If Trim(val5) <> "" Then
                    dao_q.GetDatabyTRID_PROCESS(Trim(val5), "130099")
                    If dao_q.fields.STATUS_ID = "2" Then
                        dao_q.fields.STATUS_ID = 3
                        dao_q.update()
                        i += 1
                        INSERT_LOG_SEND_STATUS(dao_q.fields.IDA, "130099", 3, CITIZEN_ID)
                    End If
                End If

            End If
            If i > 0 Then
                Result = "ข้ามสถานะเรียบร้อยแล้ว"
            End If
            Return Json(Result, JsonRequestBehavior.AllowGet)
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
    End Class
End Namespace