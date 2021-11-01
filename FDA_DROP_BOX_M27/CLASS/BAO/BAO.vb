Imports System.Data.SqlClient

Public Class BAO
    Private _conn As String = System.Configuration.ConfigurationManager.ConnectionStrings("FDA_MDC27ConnectionString").ConnectionString
    Private _con_CPN As String = System.Configuration.ConfigurationManager.ConnectionStrings("LGTCPNConnectionString").ConnectionString
    Private _conn_CPN As String = System.Configuration.ConfigurationManager.ConnectionStrings("LGTPERMISSIONConnectionString").ConnectionString
    Private _con_d As String = System.Configuration.ConfigurationManager.ConnectionStrings("LGT_DRUGConnectionString").ConnectionString
    '

    Public Function SP_SEARCH_PERSON(ByVal search As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_SEARCH_PERSON @search='" & search & "'"
        Dim dta As New DataTable
        Try
            dta = clsds.dsQueryselect(sql, _con_d).Tables(0)
        Catch ex As Exception

        End Try
        dta.TableName = "SP_SEARCH_PERSON"
        Return dta
    End Function
    Public Function SP_GET_ALL_PROFESSIONAL() As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_GET_ALL_PROFESSIONAL "
        Dim dt As New DataTable
        Try
            dt = clsds.dsQueryselect(sql, _con_d).Tables(0)
        Catch ex As Exception

        End Try

        dt.TableName = "SP_GET_ALL_PROFESSIONAL"
        Return dt
    End Function
    Public Function SP_SYSPREFIX() As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_SYSPREFIX"
        Dim dt As New DataTable
        dt = clsds.dsQueryselect(sql, _con_CPN).Tables(0)
        dt.TableName = "SP_SYSPREFIX"
        Return dt
    End Function
    '
    Public Function SP_CER_SEARCH() As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_CER_SEARCH"
        Dim dt As New DataTable
        Try
            dt = clsds.dsQueryselect(sql, _con_d).Tables(0)
        Catch ex As Exception

        End Try


        Return dt
    End Function

    Public Function SP_MAS_CHEMICAL_SEARCH_RESULT_STAFF() As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_MAS_CHEMICAL_SEARCH_RESULT_STAFF "
        Dim dt As New DataTable
        Try
            dt = clsds.dsQueryselect(sql, _con_d).Tables(0)
        Catch ex As Exception

        End Try


        Return dt
    End Function

    Public Function SP_STAFF_DH15RQT_V2() As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_STAFF_DH15RQT_V2 "
        Dim dt As New DataTable
        Try
            dt = clsds.dsQueryselect(sql, _con_d).Tables(0)
        Catch ex As Exception

        End Try
        Return dt
    End Function
    Public Function SP_CER_DETAIL_CASCHEMICAL_by_TR_ID(ByVal FK_IDA As Integer) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_CER_DETAIL_CASCHEMICAL_by_TR_ID @FK_IDA =  " & FK_IDA
        Dim dt As New DataTable
        Try
            dt = clsds.dsQueryselect(sql, _con_d).Tables(0)
        Catch ex As Exception

        End Try
        dt.TableName = "SP_CER_DETAIL_CASCHEMICAL_by_TR_ID"
        Return dt
    End Function
    Public Function SP_MAS_STATUS_STAFF_BY_GROUP_DDL(ByVal STAT_GROUP As String, ByVal GROUP_DLL As String) As DataTable
        Dim clsds As New ClassDataset
        Dim dt As New DataTable
        Dim sql As String = "exec SP_MAS_STATUS_STAFF_BY_GROUP_DDL @stat_group=" & STAT_GROUP & " , @group=" & GROUP_DLL
        dt = clsds.dsQueryselect(sql, _con_d).Tables(0)
        dt.TableName = "SP_STATUS_SELECT_DH_STAFF"
        Return dt
    End Function


    Public Function SP_STAFF_OFFER_DDL_BY_PVNCD(ByVal PVCODE As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_STAFF_OFFER_DDL_BY_PVNCD @pvncd =" & PVCODE
        Dim dt As New DataTable
        dt = clsds.dsQueryselect(sql, _con_d).Tables(0)
        dt.TableName = "SP_STAFF_OFFER_DDL_BY_PVNCD"
        Return dt
    End Function

    Public Function SP_STAFF_EXTEND(ByVal _GROUP As String, ByVal PVCODE As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = ""

        If _GROUP = 21020 Then
            sql = "select * from dbo.Vw_Extend where STATUS_ID >=4 and STATUS_ID <>7 order by TRANSACTION_UPLOAD desc"
        Else
            sql = "select * from dbo.Vw_Extend where STATUS_ID >=4 and STATUS_ID <>7 and pvncd=" & PVCODE & " order by TRANSACTION_UPLOAD desc"
        End If

        Dim dt As New DataTable
        dt = clsds.dsQueryselect(sql, _con_d).Tables(0)
        dt.TableName = "SP_STAFF_EXTEND"

        Return dt
    End Function

    Public Function SP_BSN_LOCATION_ADDRESS_BY_IDEN_V2(ByVal iden As String) As DataTable
        Dim sql As String = "exec SP_BSN_LOCATION_ADDRESS_BY_IDEN_V2 @iden='" & iden & "'"
        Dim dta As New DataTable
        Dim clsds As New ClassDataset
        Try
            dta = clsds.dsQueryselect(sql, _con_CPN).Tables(0)
        Catch ex As Exception

        End Try

        dta.TableName = "SP_BSN_LOCATION_ADDRESS_BY_IDEN"
        Return dta
    End Function
    Public Function SP_DALCN_NCT_SUBSTITUTE_BY_FK_IDA(ByVal LCN_IDA As Integer) As DataTable
        Dim sql As String = "exec SP_DALCN_NCT_SUBSTITUTE_BY_FK_IDA @FK_IDA=" & LCN_IDA
        Dim dta As New DataTable
        Dim clsds As New ClassDataset
        Try
            dta = clsds.dsQueryselect(sql, _con_d).Tables(0)
        Catch ex As Exception

        End Try
        dta.TableName = "SP_DALCN_NCT_SUBSTITUTE_BY_FK_IDA"
        Return dta
    End Function
    Public Function SP_SYSCHNGWT() As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_SYSCHNGWT"
        Dim dta As New DataTable
        Try
            dta = clsds.dsQueryselect(sql, _con_CPN).Tables(0)
        Catch ex As Exception

        End Try

        Return dta
    End Function
    Public Function SP_STAFF_DH15RQT() As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_STAFF_DH15RQT "
        Dim dt As New DataTable
        dt = clsds.dsQueryselect(sql, _con_d).Tables(0)

        Return dt
    End Function
    Public Function SP_STAFF_DS() As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_STAFF_DS"
        Dim dt As New DataTable
        Try
            dt = clsds.dsQueryselect(sql, _con_d).Tables(0)
        Catch ex As Exception

        End Try


        Return dt
    End Function
    Public Function SP_DRRGT_SUBSTITUTE_STAFF() As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_DRRGT_SUBSTITUTE_STAFF "
        Dim dta As New DataTable
        dta = clsds.dsQueryselect(sql, _con_d).Tables(0)
        dta.TableName = "SP_DRRGT_SUBSTITUTE_STAFF"
        Return dta
    End Function
    Public Function SP_DRRGT_EDIT_REQUEST_STAFF_PROCESS(ByVal process_id As String) As DataTable
        Dim sql As String = "exec SP_DRRGT_EDIT_REQUEST_STAFF_PROCESS @process_id='" & process_id & "'"
        Dim clsds As New ClassDataset
        Dim dta As New DataTable
        dta = clsds.dsQueryselect(sql, _con_d).Tables(0)
        dta.TableName = "SP_DRRGT_EDIT_REQUEST_STAFF_PROCESS"
        Return dta
    End Function

    Public Function SP_DRRGT_FOR_SEARCH_FROM_SAI(ByVal txt As String) As DataTable
        Dim sql As String = "exec SP_DRRGT_FOR_SEARCH_FROM_SAI @txt='" & txt & "'"
        Dim clsds As New ClassDataset
        Dim dta As New DataTable
        dta = clsds.dsQueryselect(sql, _con_d).Tables(0)
        dta.TableName = "SP_DRRGT_EDIT_REQUEST_STAFF_PROCESS"
        Return dta
    End Function
    '
    Public Function SP_STAFF_NYM_ALL(ByVal PROCESS_ID As String) As DataTable
        Dim sql As String = "exec SP_STAFF_NYM_ALL @PROCESS_ID='" & PROCESS_ID & "'"
        Dim clsds As New ClassDataset
        Dim dta As New DataTable
        dta = clsds.dsQueryselect(sql, _con_d).Tables(0)
        dta.TableName = "SP_STAFF_NYM_ALL"
        Return dta
    End Function
    Public Function SP_DRRGT_TABEAN_STAFF() As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_DRRGT_TABEAN_STAFF "
        Dim dt As New DataTable
        dt = clsds.dsQueryselect(sql, _con_d).Tables(0)

        Return dt
    End Function
    Public Function SP_DALCN_EDIT_REQUEST_STAFF() As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_DALCN_EDIT_REQUEST_STAFF "
        Dim dt As New DataTable
        Try
            dt = clsds.dsQueryselect(sql, _con_d).Tables(0)
        Catch ex As Exception

        End Try


        Return dt
    End Function
    Public Function SP_STAFF_CER() As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_STAFF_CER "
        Dim dt As New DataTable
        Try
            dt = clsds.dsQueryselect(sql, _con_d).Tables(0)
        Catch ex As Exception

        End Try


        Return dt
    End Function
    Public Function SP_DALCN_NCT_SUBSTITUTE_STAFF() As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_DALCN_NCT_SUBSTITUTE_STAFF "
        Dim dta As New DataTable
        Try
            dta = clsds.dsQueryselect(sql, _con_d).Tables(0)
        Catch ex As Exception

        End Try
        dta.TableName = "SP_DALCN_NCT_SUBSTITUTE_STAFF"
        Return dta
    End Function
    Public Function SP_STAFF_DALCN() As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_STAFF_DALCN "
        Dim dt As New DataTable
        Try
            dt = clsds.dsQueryselect(sql, _con_d).Tables(0)
        Catch ex As Exception

        End Try


        Return dt
    End Function
    Public Function SP_STAFF_DALCN_BY_PVNCD(ByVal pvncd As Integer) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_STAFF_DALCN_BY_PVNCD @pvncd=" & pvncd
        Dim dt As New DataTable
        Try
            dt = clsds.dsQueryselect(sql, _con_d).Tables(0)
        Catch ex As Exception

        End Try


        Return dt
    End Function

    Public Function SP_SYSAMPHR() As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_SYSAMPHR"
        Dim dta As New DataTable
        Try
            dta = clsds.dsQueryselect(sql, _con_CPN).Tables(0)
        Catch ex As Exception

        End Try

        Return dta
    End Function

    Public Function SP_SYSTHMBL() As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_SYSTHMBL"
        Dim dta As New DataTable
        Try
            dta = clsds.dsQueryselect(sql, _con_CPN).Tables(0)
        Catch ex As Exception

        End Try

        Return dta
    End Function

    Public Function SP_SYSAMPHR_BY_CHNGWTCD(ByVal CHNGWTCD As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_SYSAMPHR_BY_CHNGWTCD @chngwt=" & CHNGWTCD
        Dim dta As New DataTable
        Try
            dta = clsds.dsQueryselect(sql, _con_CPN).Tables(0)
        Catch ex As Exception

        End Try

        Return dta
    End Function

    Public Function SP_SYSTHMBL_BY_CHNGWTCD_AND_AMPHRCD(ByVal CHNGWTCD As String, ByVal AMPHRCD As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_SYSTHMBL_BY_CHNGWTCD_AND_AMPHRCD @chngwtcd=" & CHNGWTCD & ",@amphrcd=" & AMPHRCD
        Dim dta As New DataTable
        Try
            dta = clsds.dsQueryselect(sql, _con_CPN).Tables(0)
        Catch ex As Exception

        End Try

        Return dta
    End Function


    Public Function SP_SYSPREFIX_PERSON() As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_SYSPREFIX_PERSON"
        Dim dt As New DataTable
        dt = clsds.dsQueryselect(sql, _con_CPN).Tables(0)
        dt.TableName = "SP_SYSPREFIX_PERSON"
        Return dt
    End Function
    Public Function SP_SYSLCNSNM_BY_LCNSID_AND_IDENTIFYV2(ByVal identify As String, ByVal LCNSID As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_SYSLCNSNM_BY_LCNSID_AND_IDENTIFYV2 @lcnsid='" & LCNSID & "' ,@identify= '" & identify & "'"
        ' Dim sql As String = "exec SP_SYSLCNSNM_BY_LCNSID_AND_IDENTIFY @lcnsid=" & "0" & " ,@identify=" & "0"
        Dim dt As New DataTable
        Try
            dt = clsds.dsQueryselect(sql, _con_CPN).Tables(0)
        Catch ex As Exception

        End Try

        dt.TableName = "SP_SYSLCNSNM_BY_LCNSID_AND_IDENTIFY"
        Return dt
    End Function
    Public Function SP_DALCN_PHR_BY_FK_IDA_2(ByVal IDA As Integer) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_DALCN_PHR_BY_FK_IDA_2 @IDA =  " & IDA
        Dim dt As New DataTable
        dt.TableName = "SP_DALCN_PHR_BY_FK_IDA_2"
        Try
            dt = clsds.dsQueryselect(sql, _con_d).Tables(0)

        Catch ex As Exception

        End Try

        Return dt
    End Function
    Public Function SP_CUSTOMER_DALCN_LOCATION_ADDRESS_by_LOCATION_TYPE_ID_and_LCNSID(ByVal LOCATION_TYPE_CD As Integer, ByVal iden As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_CUSTOMER_DALCN_LOCATION_ADDRESS_by_LOCATION_TYPE_ID_and_LCNSID @iden='" & iden & "' ,@LOCATION_TYPE_CD=" & LOCATION_TYPE_CD
        Dim dta As New DataTable
        Try
            dta = clsds.dsQueryselect(sql, _con_d).Tables(0)
        Catch ex As Exception

        End Try

        Return dta
    End Function

    Public Function SP_BSN_LOCATION_ADDRESS_BY_IDA_V2(ByVal IDA As Integer) As DataTable
        Dim sql As String = "exec SP_BSN_LOCATION_ADDRESS_BY_IDA_V2 @IDA=" & IDA
        Dim dta As New DataTable
        dta = Queryds(sql)
        dta.TableName = "SP_BSN_LOCATION_ADDRESS_BY_IDA_V2"
        Return dta
    End Function


    Public Function SP_SYSLCNSNM_BY_LCNSID_AND_IDENTIFY(ByVal identify As String, ByVal LCNSID As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_SYSLCNSNM_BY_LCNSID_AND_IDENTIFY @lcnsid='" & LCNSID & "' ,@identify= '" & identify & "'"
        ' Dim sql As String = "exec SP_SYSLCNSNM_BY_LCNSID_AND_IDENTIFY @lcnsid=" & "0" & " ,@identify=" & "0"
        Dim dt As New DataTable
        Try
            dt = clsds.dsQueryselect(sql, _con_CPN).Tables(0)

        Catch ex As Exception

        End Try
        Return dt
    End Function


    Public Function SP_LOCATION_BSN_BY_LCN_IDA(ByVal IDA As Integer) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_LOCATION_BSN_BY_LCN_IDA @LCN_IDA=" & IDA
        Dim dt As New DataTable
        Try
            dt = clsds.dsQueryselect(sql, _con_d).Tables(0)

        Catch ex As Exception

        End Try
        dt.TableName = "SP_LOCATION_BSN_BY_LCN_IDA"
        Return dt
    End Function
    Function con_year(year) As String
        Dim int_year As Integer = Integer.Parse(year)
        If int_year <= 2500 Then
            int_year += 543
        End If
        Return int_year.ToString()
    End Function

    Public Function SP_LOCATION_ADDRESS_by_LOCATION_TYPE_CD_and_LCNSIDV2(ByVal LOCATION_TYPE_CD As Integer, ByVal iden As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_LOCATION_ADDRESS_by_LOCATION_TYPE_CD_and_LCNSIDV2 @LOCATION_TYPE_CD= " & LOCATION_TYPE_CD & " ,@iden= '" & iden & "'"
        Dim dt As New DataTable
        Try
            dt = clsds.dsQueryselect(sql, _con_d).Tables(0)
        Catch ex As Exception

        End Try
        dt.TableName = "SP_LOCATION_ADDRESS_by_LOCATION_TYPE_CD_and_LCNSID"
        Return dt
    End Function

    Public Function insert_transection_new(ByVal processid As String, ByVal _CITIZEN_ID As String, ByVal _CITIZEN_ID_AUTHORIZE As String) As Integer            'สร้างเลขดำเนินการ
        Dim _year As Integer
        _year = con_year(Date.Now.Year)

        Dim gen_no As Integer = 0
        gen_no = Get_NO(processid)
        Dim i As Integer = 0
        Dim dao_up As New DAO_DRUG.ClsDBTRANSACTION_UPLOAD
        i = dao_up.Count_GEN_NO(_year, processid, gen_no)
        Dim str_no As String = gen_no.ToString()
        If i > 0 Then
            gen_no = Get_NO(processid)


            str_no = String.Format("{0:0000000}", gen_no.ToString("0000000"))
            str_no = _year.ToString.Substring(2, 2) & str_no

            dao_up = New DAO_DRUG.ClsDBTRANSACTION_UPLOAD
            dao_up.fields.CITIEZEN_ID = _CITIZEN_ID
            dao_up.fields.CITIEZEN_ID_AUTHORIZE = _CITIZEN_ID_AUTHORIZE
            dao_up.fields.PROCESS_ID_STR = processid
            Try
                dao_up.fields.PROCESS_ID = processid
            Catch ex As Exception

            End Try
            dao_up.fields.GEN_NO = gen_no
            dao_up.fields.DESCRIPTION = str_no
            dao_up.fields.STATUS = 1
            dao_up.fields.UPLOAD_DATE = Date.Now()
            dao_up.fields.YEAR = _year 'con_year(Date.Now().Year())
            dao_up.insert() 'ปรับเป็น
        Else

            'Dim str_no As String = gen_no.ToString()
            str_no = String.Format("{0:0000000}", gen_no.ToString("0000000"))
            str_no = _year.ToString.Substring(2, 2) & str_no

            dao_up = New DAO_DRUG.ClsDBTRANSACTION_UPLOAD
            dao_up.fields.CITIEZEN_ID = _CITIZEN_ID
            dao_up.fields.CITIEZEN_ID_AUTHORIZE = _CITIZEN_ID_AUTHORIZE
            dao_up.fields.PROCESS_ID_STR = processid
            Try
                dao_up.fields.PROCESS_ID = processid
            Catch ex As Exception

            End Try
            dao_up.fields.DESCRIPTION = str_no
            dao_up.fields.STATUS = 1
            dao_up.fields.GEN_NO = gen_no
            dao_up.fields.UPLOAD_DATE = Date.Now()
            dao_up.fields.YEAR = _year 'con_year(Date.Now().Year())
            dao_up.insert() 'ปรับเป็น
        End If

        Return str_no

    End Function
    Public Function Get_NO(ByVal _process_id) As Integer
        Dim int_no As Integer
        Dim _year As Integer
        _year = con_year(Date.Now.Year)
        Dim dao As New DAO_DRUG.ClsDBTRANSACTION_UPLOAD
        dao.GetDataby_GEN(_year, _process_id)
        If IsNothing(dao.fields.GEN_NO) = True Then
            int_no = 0
        Else
            int_no = dao.fields.GEN_NO
        End If



        Return int_no + 1
    End Function

    Public Function SP_MAS_CHEMICAL_by_IOWANM_AND_AORI(ByVal IOWANM As String, ByVal aori As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_MAS_CHEMICAL_by_IOWANM_AND_AORI @IOWANM='" & IOWANM & "' ,@aori='" & aori & "'"
        Dim dt As New DataTable
        dt = clsds.dsQueryselect(sql, _con_d).Tables(0)

        Return dt
    End Function

    Public Function SP_LOCATION_BSN_BY_IDENTIFY(ByVal iden As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_LOCATION_BSN_BY_IDENTIFY @iden = '" & iden & "'"
        Dim dt As New DataTable
        dt = clsds.dsQueryselect(sql, _con_d).Tables(0)
        dt.TableName = "SP_LOCATION_BSN_BY_IDENTIFY"
        Return dt
    End Function
    Public Function SP_DDL_LCN_DI_DH(ByVal iden As String) As DataTable
        Dim sql As String = "exec SP_DDL_LCN_DI_DH @iden='" & iden & "'"
        Dim dta As New DataTable
        dta = Queryds(sql)
        dta.TableName = "SP_DDL_LCN_DI_DH"
        Return dta
    End Function

    Function SP_DH15RQT_BY_IDA(ByVal LCN_IDA As Integer, ByVal PROCESS_ID As Integer) As DataTable
        Dim sql As String = "exec SP_DH15RQT_BY_IDA @IDA='" & LCN_IDA & "',@PROCESS='" & PROCESS_ID & "'"
        Dim dta As New DataTable
        dta = Queryds(sql)
        dta.TableName = "SP_DH15RQT_BY_IDA"
        Return dta
    End Function

    Public Function SP_CHEMICAL_REQUEST_CUSTOMER_CHEM_TYPE(ByVal iden As String, ByVal mt As Integer, ByVal st As Integer, ByVal aori As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_CHEMICAL_REQUEST_CUSTOMER_CHEM_TYPE @iden = '" & iden & "', @mt=" & mt & " , @st=" & st & ",@aori='" & aori & "'"
        Dim dt As New DataTable
        Try
            dt = clsds.dsQueryselect(sql, _con_d).Tables(0)
        Catch ex As Exception

        End Try

        Return dt
    End Function

    Public Function SP_CUSTOMER_CER_BY_FK_IDA_and_CER_TYPE_and_iden(ByVal IDA As String, ByVal CER_TYPE As String, ByVal iden As String) As DataTable
        Dim sql As String = "exec SP_CUSTOMER_CER_BY_FK_IDA_and_CER_TYPE_and_iden @FK_IDA='" & IDA & "',@CER_TYPE='" & CER_TYPE & "',@iden='" & iden & "'"
        Dim dta As New DataTable
        dta = Queryds(sql)
        dta.TableName = "SP_CUSTOMER_CER_BY_FK_IDA_and_CER_TYPE_and_iden"
        Return dta
    End Function

    Public Function SP_DRUG_UNIT_PHYSIC() As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec dbo.SP_DRUG_UNIT_PHYSIC "
        Dim dt As New DataTable
        Try
            dt = clsds.dsQueryselect(sql, _con_d).Tables(0)
        Catch ex As Exception

        End Try


        Return dt
    End Function
    Public Function SP_drkdofdrg() As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec dbo.SP_drkdofdrg"
        Dim dt As New DataTable
        dt = clsds.dsQueryselect(sql, _con_d).Tables(0)
        dt.TableName = "SP_drkdofdrg"

        Return dt
    End Function
    Public Function SP_MAS_DRUG_SHAPE() As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec dbo.SP_MAS_DRUG_SHAPE "
        Dim dt As New DataTable
        Try
            dt = clsds.dsQueryselect(sql, _con_d).Tables(0)
        Catch ex As Exception

        End Try


        Return dt
    End Function

    Public Function SP_MASTER_drclass() As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_MASTER_drclass"
        Dim dt As New DataTable
        dt = clsds.dsQueryselect(sql, _con_d).Tables(0)
        dt.TableName = "SP_MASTER_drclass"
        Return dt
    End Function
    Public Function SP_dactg() As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec dbo.SP_dactg "
        Dim dt As New DataTable
        Try
            dt = clsds.dsQueryselect(sql, _con_d).Tables(0)
        Catch ex As Exception

        End Try


        Return dt
    End Function
    Public Function SP_dosage_form() As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec dbo.SP_dosage_form "
        Dim dt As New DataTable
        dt = clsds.dsQueryselect(sql, _con_d).Tables(0)

        Return dt
    End Function
    Public Function SP_LOCATION_ADDRESS_by_LOCATION_TYPE_CD_and_LCNSIDV2_1(ByVal LOCATION_TYPE_CD As Integer, ByVal iden As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_LOCATION_ADDRESS_by_LOCATION_TYPE_CD_and_LCNSIDV2_1 @LOCATION_TYPE_CD= " & LOCATION_TYPE_CD & " ,@iden= '" & iden & "'"
        Dim dt As New DataTable
        Try
            dt = clsds.dsQueryselect(sql, _con_d).Tables(0)

        Catch ex As Exception

        End Try
        Return dt
    End Function
    Public Function SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(ByVal LOCATION_ADDRESS_IDA As Integer) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA @LOCATION_ADDRESS_IDA = " & LOCATION_ADDRESS_IDA
        Dim dt As New DataTable
        Try
            dt = clsds.dsQueryselect(sql, _con_d).Tables(0)

        Catch ex As Exception

        End Try
        dt.TableName = "SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA"
        Return dt
    End Function

    Public Function SP_MASTER_DALCN_DETAIL_LOCATION_KEEP_BY_IDA(ByVal LCN_IDA As Integer) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_MASTER_DALCN_DETAIL_LOCATION_KEEP_BY_IDA @FK_IDA = " & LCN_IDA
        Dim dt As New DataTable
        Try
            dt = clsds.dsQueryselect(sql, _con_d).Tables(0)

        Catch ex As Exception

        End Try
        dt.TableName = "SP_MASTER_DALCN_DETAIL_LOCATION_KEEP_BY_IDA"
        Return dt
    End Function

    Public Function SP_LCN_BY_PROCESS_AND_IDEN(ByVal process As String, ByVal iden As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_LCN_BY_PROCESS_AND_IDEN @PROCESS_ID='" & process & "' ,@iden ='" & iden & "'"
        Dim dta As New DataTable
        Try
            dta = clsds.dsQueryselect(sql, _con_d).Tables(0)
        Catch ex As Exception

        End Try

        dta.TableName = "SP_LCN_BY_PROCESS_AND_IDEN"
        Return dta
    End Function

    Public Function SP_DALCN_EDIT_REQUEST_BY_FK_IDA(ByVal fk_ida As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_DALCN_EDIT_REQUEST_BY_FK_IDA @FK_IDA=" & fk_ida
        Dim dta As New DataTable
        Try
            dta = clsds.dsQueryselect(sql, _con_d).Tables(0)
        Catch ex As Exception

        End Try

        dta.TableName = "SP_DALCN_EDIT_REQUEST_BY_FK_IDA"
        Return dta
    End Function
    Public Function SP_LCN_BY_PROCESS_AND_IDEN_ALIVE(ByVal process As String, ByVal iden As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_LCN_BY_PROCESS_AND_IDEN_ALIVE @PROCESS_ID='" & process & "' ,@iden ='" & iden & "'"
        Dim dta As New DataTable
        Try
            dta = clsds.dsQueryselect(sql, _con_d).Tables(0)
        Catch ex As Exception

        End Try

        dta.TableName = "SP_LCN_BY_PROCESS_AND_IDEN_ALIVE"
        Return dta
    End Function
    Public Function SP_PHR_NOT_ROW_1_BY_FK_IDA(ByVal FK_IDA As Integer) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_PHR_NOT_ROW_1_BY_FK_IDA @FK_IDA =  " & FK_IDA
        Dim dt As New DataTable
        Try
            dt = clsds.dsQueryselect(sql, _con_d).Tables(0)
        Catch ex As Exception

        End Try

        dt.TableName = "SP_PHR_NOT_ROW_1_BY_FK_IDA"

        Return dt
    End Function
    Public Function SP_GET_DRUG_PRODUCT_ESUB(ByVal register As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_GET_DRUG_PRODUCT_ESUB @register= '" & register & "'"
        Dim dta As New DataTable
        Try
            dta = clsds.dsQueryselect(sql, _conn).Tables(0)
        Catch ex As Exception

        End Try
        Return dta
    End Function
    Public Function SP_MASTER_CER_PK_BY_FK_IDA(ByVal FK_IDA As Integer) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_MASTER_CER_PK_BY_FK_IDA @FK_IDA =  " & FK_IDA
        Dim dt As New DataTable
        dt = clsds.dsQueryselect(sql, _con_d).Tables(0)
        dt.TableName = "SP_MASTER_CER_PK_BY_FK_IDA"
        Try
            dt = clsds.dsQueryselect(sql, _con_d).Tables(0)
        Catch ex As Exception

        End Try

        Return dt
    End Function
    Public Function SP_MASTER_sysisocnt() As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_MASTER_sysisocnt"
        Dim dt As New DataTable
        dt = clsds.dsQueryselect(sql, _con_d).Tables(0)
        dt.TableName = "SP_MASTER_sysisocnt"
        Return dt
    End Function
    Public Function SP_PHR_JOB() As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_PHR_JOB "
        Dim dta As New DataTable
        dta = clsds.dsQueryselect(sql, _con_d).Tables(0)
        Return dta
    End Function

    Public Function SP_MASTER_DAPHRCD() As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_MASTER_DAPHRCD "
        Dim dta As New DataTable
        dta = clsds.dsQueryselect(sql, _con_d).Tables(0)
        Return dta
    End Function

    Public Function SP_MASTER_dacscd() As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "select * from dacscd"
        Dim dt As New DataTable
        dt = clsds.dsQueryselect(sql, _con_d).Tables(0)
        dt.TableName = "SP_MASTER_dacscd"
        Return dt
    End Function

    Public Function SP_SYSISOCNT() As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_SYSISOCNT"
        Dim dta As New DataTable
        dta = clsds.dsQueryselect(sql, _con_CPN).Tables(0)
        Return dta
    End Function

    Public Function SP_SIP_UNIT() As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_GET_SIP_UNIT"
        Dim dta As New DataTable
        dta = clsds.dsQueryselect(sql, _conn).Tables(0)
        Return dta
    End Function

    Public Function SP_GET_DRDOSAGE() As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_GET_DRDOSAGE"
        Dim dta As New DataTable
        dta = clsds.dsQueryselect(sql, _conn).Tables(0)
        Return dta
    End Function

    Public Function SP_GET_LOCATION_ADDR(ByVal NITI_IDENTIFY As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_GET_LOCATION_ADDR @IDENTIFY= '" & NITI_IDENTIFY & "'"
        Dim dts As New DataTable
        Try
            dts = clsds.dsQueryselect(sql, _conn).Tables(0)
        Catch ex As Exception
            '           	@CTZNO as nvarchar(255),
            '@NITI_CTZNO as nvarchar(255),
            '@SYSTEM_ID as nvarchar(255)
        End Try
        Return dts
    End Function
    Public Function SP_LOCATION_MDC(ByVal NITI_IDENTIFY As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_LOCATION_MDC @IDENTIFY= '" & NITI_IDENTIFY & "'"
        Dim dts As New DataTable
        Try
            dts = clsds.dsQueryselect(sql, _conn).Tables(0)
        Catch ex As Exception
            '           	@CTZNO as nvarchar(255),
            '@NITI_CTZNO as nvarchar(255),
            '@SYSTEM_ID as nvarchar(255)
        End Try
        Return dts
    End Function


    Public Function Queryds(ByVal Commands As String) As DataTable
        Dim dt As New DataTable
        Dim MyConnection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("LGT_DRUGConnectionString").ConnectionString)
        Dim mySqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(Commands, MyConnection)
        mySqlDataAdapter.Fill(dt)
        MyConnection.Close()
        Return dt
    End Function


    Public Function SP_CHECK_PERMISSON_SYSTEM(ByVal CTZNO As String, ByVal NITI_IDENTIFY As String, ByVal systemid As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_CHECK_PERMISSON_SYSTEM @CTZNO= '" & CTZNO & "',@NITI_CTZNO ='" & NITI_IDENTIFY & "',@SYSTEM_ID='" & systemid & "'"
        Dim dts As New DataTable
        Try
            dts = clsds.dsQueryselect(sql, _conn_CPN).Tables(0)
        Catch ex As Exception
            '           	@CTZNO as nvarchar(255),
            '@NITI_CTZNO as nvarchar(255),
            '@SYSTEM_ID as nvarchar(255)
        End Try
        Return dts
    End Function




    Public Function SP_GET_FILE_BOX(ByVal TR_ID As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_GET_FILE_BOX @TR_ID ='" & TR_ID & "'"
        Dim dts As New DataTable
        Try
            dts = clsds.dsQueryselect(sql, _conn).Tables(0)
        Catch ex As Exception

        End Try
        Return dts
    End Function

    Public Function SP_GET_SHARE_BOX(ByVal TR_ID As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_GET_SHARE_BOX @TR_ID ='" & TR_ID & "'"
        Dim dts As New DataTable
        Try
            dts = clsds.dsQueryselect(sql, _conn).Tables(0)
        Catch ex As Exception

        End Try
        Return dts
    End Function

    Public Function SP_GET_PRODUCT_TYPE(ByVal PRODUCT_GROUP As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_GET_PRODUCT_TYPE @PRODUCT_GROUP = N'" & PRODUCT_GROUP & "'"
        Dim dts As New DataTable
        Try
            dts = clsds.dsQueryselect(sql, _conn).Tables(0)
        Catch ex As Exception

        End Try
        Return dts
    End Function

    Public Function SP_GET_INV_HISTORY(ByVal CTZNO As String)
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_GET_INV_HISTORY @CTZNO ='" & CTZNO & "'"
        Dim dts As New DataTable
        Try
            dts = clsds.dsQueryselect(sql, _conn).Tables(0)
        Catch ex As Exception

        End Try
        Return dts
    End Function
    Public Function SP_GET_PROCESS(ByVal ORG As String, ByVal PROCESS_TYPE As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_GET_PROCESS @PROCESS_ORG ='" & ORG & "',@PROCESS_TYPE=N'" & PROCESS_TYPE & "'"
        Dim dts As New DataTable
        Try
            dts = clsds.dsQueryselect(sql, _conn).Tables(0)
        Catch ex As Exception

        End Try
        Return dts
    End Function



    Public Function SP_GET_ISO() As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_GET_ISO"
        Dim dts As New DataTable
        Try
            dts = clsds.dsQueryselect(sql, _conn).Tables(0)
        Catch ex As Exception

        End Try
        Return dts
    End Function

    Public Function SP_GET_BOX_CTZNO(ByVal CTZNO As String, ByVal REF_LCN As String, ByVal LCN_TYPE As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_GET_BOX_CTZNO @CTZNO ='" & CTZNO & "',@REF_LCN='" & REF_LCN & "',@LCN_TYPE=N'" & LCN_TYPE & "'"
        Dim dts As New DataTable
        Try
            dts = clsds.dsQueryselect(sql, _conn).Tables(0)
        Catch ex As Exception

        End Try
        Return dts
    End Function



    Public Function SP_GET_BOX_STAFF_STATUS(ByVal ORG As String, ByVal STATUS As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_GET_BOX_STAFF_STATUS @ORG='" & ORG & "',@STATUS='" & STATUS & "'"
        Dim dts As New DataTable
        Try
            dts = clsds.dsQueryselect(sql, _conn).Tables(0)
        Catch ex As Exception

        End Try
        Return dts
    End Function

    Public Function SP_GET_BOX_STAFF(ByVal ORG As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_GET_BOX_STAFF @ORG='" & ORG & "'"
        Dim dts As New DataTable
        Try
            dts = clsds.dsQueryselect(sql, _conn).Tables(0)
        Catch ex As Exception

        End Try
        Return dts
    End Function

    Public Function SP_GET_BOX_APPROVE(ByVal TR_ID As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_GET_BOX_APPROVE @TR_ID='" & TR_ID & "'"
        Dim dts As New DataTable
        Try
            dts = clsds.dsQueryselect(sql, _conn).Tables(0)
        Catch ex As Exception

        End Try
        Return dts
    End Function

    Function SP_CUSTOMER_LCN_BY_FK_IDA(ByVal LCT_IDA As Integer, ByVal Process As String, ByVal Citizen As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_CUSTOMER_LCN_BY_FK_IDA @FK_IDA='" & LCT_IDA & "',@lcntpcd='" & Process & "',@iden='" & Citizen & "'"
        Dim dts As New DataTable
        Try
            dts = clsds.dsQueryselect(sql, _conn).Tables(0)
        Catch ex As Exception

        End Try
        Return dts
    End Function

    Function SP_CUSTOMER_LCN_BY_FK_IDA_PROCESS_IDEN(ByVal LCT_IDA As Integer, ByVal Process As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_CUSTOMER_LCN_BY_FK_IDA_PROCESS_IDEN @FK_IDA='" & LCT_IDA & "',@process='" & Process & "'"
        Dim dts As New DataTable
        Try
            dts = clsds.dsQueryselect(sql, _con_d).Tables(0)
        Catch ex As Exception

        End Try
        Return dts
    End Function

    Function SP_CUSTOMER_LCN_BY_FK_IDA_PROCESS_IDEN_V2(ByVal LCT_IDA As Integer, ByVal Process As String, ByVal iden As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_CUSTOMER_LCN_BY_FK_IDA_PROCESS_IDEN_V2 @FK_IDA='" & LCT_IDA & "',@process='" & Process & "' ,@iden='" & iden & "'"
        Dim dts As New DataTable
        Try
            dts = clsds.dsQueryselect(sql, _con_d).Tables(0)
        Catch ex As Exception

        End Try
        Return dts
    End Function
    Public Function SP_LCN_EXTEND_REQUEST_BY_IDENTIFY(ByVal identify As String) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_LCN_EXTEND_REQUEST_BY_IDENTIFY @identify='" & identify & "'"
        Dim dt As New DataTable
        Try
            dt = clsds.dsQueryselect(sql, _con_d).Tables(0)
        Catch ex As Exception

        End Try


        Return dt
    End Function
    '
    Public Function SP_LCN_EXTEND_REQUEST_BY_IDENTIFY_YEAR(ByVal identify As String, ByVal _year As Integer) As DataTable
        Dim clsds As New ClassDataset
        Dim sql As String = "exec SP_LCN_EXTEND_REQUEST_BY_IDENTIFY_YEAR @identify='" & identify & "' ,@extend_year=" & _year
        Dim dt As New DataTable
        Try
            dt = clsds.dsQueryselect(sql, _con_d).Tables(0)
        Catch ex As Exception

        End Try


        Return dt
    End Function
End Class
