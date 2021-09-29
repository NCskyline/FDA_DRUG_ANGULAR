Namespace BAO_GENNO
    Public Class GenNumber
        'CODE แปลงเลข ให้รองรับแบบ NCT-N-2560-1
        Public Function FORMAT_NUMBER_BOOKING(ByVal SYSTEM As String, ByVal TYPE As String, ByVal YEAR As String, ByVal int_no As Integer) As String
            Dim str_no As String = SYSTEM & "-" & TYPE & "-" & YEAR & "-" & int_no
            Return str_no
        End Function
        'ควรแบ่ง CODE ออกเป็น 2 ส่วน Code ที่ 1 เป็น CODE ดึงเลข
        'Public Function GEN_DRUG_RCVNO_NO(ByVal YEAR As String, ByVal PVNCD As String, ByVal PROCESS_ID As String, ByVal FK_IDA As Integer) As Integer
        '    Dim int_no As Integer
        '    Dim dao As New DAO_BOOKING.TB_DRUG_GENNO
        '    dao.GetDataby_Year_PVNCD_PROCESS_ID_MAX(PVNCD, YEAR, PROCESS_ID)
        '    If IsNothing(dao.fields.GENNO) = True Then
        '        int_no = 0
        '    Else
        '        int_no = dao.fields.GENNO
        '    End If
        '    int_no = int_no + 1
        '    dao = New DAO_BOOKING.TB_DRUG_GENNO
        '    dao.fields.YEAR = YEAR
        '    dao.fields.PVNCD = PVNCD
        '    dao.fields.GENNO = int_no
        '    dao.fields.PROCESS_ID = PROCESS_ID
        '    dao.fields.FK_IDA = FK_IDA
        '    dao.insert()
        '    Return int_no
        'End Function
        ''' <summary>
        ''' Function Genrcvno ในตาราง dalcn
        ''' </summary>
        Public Function GenRcvno_Falcn(ByVal Year As String, ByVal dalcn_id As Integer) As Integer
            Dim dao As New DAO_DRUG.clsDBGEN_NO_01
            dao.GetDataby_YEAR(Year)

            Dim rcvno As Integer = 1
            For Each dao.fields In dao.datas
                rcvno = dao.fields.GENNO + 1
            Next

            dao = New DAO_DRUG.clsDBGEN_NO_01
            dao.fields.GENNO = rcvno
            dao.fields.REF_IDA = dalcn_id
            dao.fields.YEAR = Year
            dao.insert()

            Return rcvno
        End Function

        ''' <summary>
        ''' Function Genrcvno ในตาราง falcn
        ''' </summary>
        Public Function GenRcvno_CHEMICAL(ByVal Year As String, ByVal IDA As Integer) As Integer
            Dim dao As New DAO_DRUG.clsDBGEN_NO_02
            dao.GetDataby_YEAR(Year)

            Dim rcvno As Integer = 1
            For Each dao.fields In dao.datas
                rcvno = dao.fields.GENNO + 1
            Next

            dao = New DAO_DRUG.clsDBGEN_NO_02
            dao.fields.GENNO = rcvno
            dao.fields.REF_IDA = IDA
            dao.fields.YEAR = Year
            dao.insert()

            Return rcvno
        End Function


        ''' <summary>
        ''' แปลงเลข yyxxxxx เป็น xxxxx/25yy
        ''' </summary>
        ''' <param name="str_no"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function Convert_no(ByVal str_no As String)
            If String.IsNullOrEmpty(str_no) = False Then
                Dim str_year As String = str_no.Trim().Substring(0, 2)
                Dim str_num As String = str_no.Trim().Substring(2, 5)
                Dim int_num As Integer = Integer.Parse(str_num)
                'str_num = String.Format("{0:00000}", int_num.ToString("00000"))
                str_num = int_num.ToString()
                str_no = str_num + "/25" + str_year
            End If

            Return str_no
        End Function
        ''' <summary>
        '''  GENNO_CER
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function GEN_CER_NO(ByVal YEAR As String, ByVal PVCODE As String, ByVal TYPE As String, ByVal LCNNO As String,
                        ByVal FORMAT As String, ByVal GROUP_NO As String, ByVal REF_IDA As String, ByVal DESCRIPTION As String) As String
            Dim int_no As Integer

            Dim dao As New DAO_DRUG.clsDBGEN_NO_02
            dao.GetDataby_GEN2(YEAR, PVCODE, TYPE, LCNNO, FORMAT, GROUP_NO, REF_IDA, DESCRIPTION)


            If IsNothing(dao.fields.GENNO) = True Then
                int_no = 0
            Else
                int_no = dao.fields.GENNO
            End If

            int_no = int_no + 1

            dao = New DAO_DRUG.clsDBGEN_NO_02

            Dim str_no As String = int_no.ToString()
            str_no = String.Format("{0:00000}", int_no.ToString("00000"))
            str_no = YEAR.Substring(2, 2) & str_no
            dao.fields.YEAR = YEAR
            dao.fields.PVCODE = PVCODE
            dao.fields.TYPE = TYPE
            dao.fields.LCNNO = LCNNO
            dao.fields.FORMAT = FORMAT
            dao.fields.GROUP_NO = GROUP_NO
            dao.fields.REF_IDA = REF_IDA
            dao.fields.DESCRIPTION = str_no
            dao.fields.GENNO = int_no
            dao.insert()
            Return str_no
        End Function
        Function GEN_CER_NO_V2(ByVal YEAR As String, ByVal PVCODE As String, ByVal TYPE As String, ByVal LCNNO As String,
                        ByVal FORMAT As String, ByVal GROUP_NO As String, ByVal REF_IDA As String, ByVal DESCRIPTION As String) As String
            Dim int_no As Integer

            Dim dao As New DAO_DRUG.clsDBGEN_NO_02
            dao.GetDataby_GEN2(YEAR, PVCODE, TYPE, LCNNO, FORMAT, GROUP_NO, REF_IDA, DESCRIPTION)

            Dim cer_seq As String = ""
            Dim cer_short As String = ""
            cer_seq = get_cer_seq(TYPE)
            cer_short = get_cer_short(TYPE)

            If IsNothing(dao.fields.GENNO) = True Then
                int_no = 0
            Else
                int_no = dao.fields.GENNO
            End If

            int_no = int_no + 1

            dao = New DAO_DRUG.clsDBGEN_NO_02

            Dim str_no As String = "" ' int_no.ToString()
            'str_no = String.Format("{0:00000}", int_no.ToString("00000"))
            str_no = cer_seq & "-" & cer_short & YEAR.Substring(2, 2) & "-" & int_no
            dao.fields.YEAR = YEAR
            dao.fields.PVCODE = PVCODE
            dao.fields.TYPE = TYPE
            dao.fields.LCNNO = LCNNO
            dao.fields.FORMAT = FORMAT
            dao.fields.GROUP_NO = GROUP_NO
            dao.fields.REF_IDA = REF_IDA
            dao.fields.DESCRIPTION = str_no
            dao.fields.GENNO = int_no
            dao.insert()
            Return str_no
        End Function
        Function get_cer_seq(ByVal cer_type As Integer) As String
            Dim cer_seq As String = ""
            If cer_type = "31" Then
                cer_seq = "01"
            ElseIf cer_type = "32" Then
                cer_seq = "02"
            ElseIf cer_type = "33" Then
                cer_seq = "03"
            ElseIf cer_type = "34" Then
                cer_seq = "04"
            ElseIf cer_type = "35" Then
                cer_seq = "05"
            ElseIf cer_type = "36" Then
                cer_seq = "06"
            End If
            Return cer_seq
        End Function
        Function get_cer_short(ByVal cer_type As Integer) As String
            Dim cer_short As String = ""
            If cer_type = "31" Then
                cer_short = "GMP"
            ElseIf cer_type = "32" Then
                cer_short = "ISO"
            ElseIf cer_type = "33" Then
                cer_short = "HAC"
            ElseIf cer_type = "34" Then
                cer_short = "PO"
            ElseIf cer_type = "35" Then
                cer_short = "COA"
            ElseIf cer_type = "36" Then
                cer_short = "XX"
            End If

            Return cer_short
        End Function
        Function GEN_CER_FOREIGN_NO(ByVal YEAR As String, ByVal PVCODE As String, ByVal TYPE As String, ByVal LCNNO As String,
                        ByVal FORMAT As String, ByVal GROUP_NO As String, ByVal REF_IDA As String, ByVal DESCRIPTION As String, ByVal TYPE_CER As Integer) As String
            Dim int_no As Integer

            Dim dao As New DAO_DRUG.clsDBGEN_NO_02
            dao.GetDataby_GEN2(YEAR, PVCODE, TYPE, LCNNO, FORMAT, GROUP_NO, REF_IDA, DESCRIPTION)

            Dim cer_seq As String = ""
            cer_seq = get_cerf_short(TYPE_CER)

            If IsNothing(dao.fields.GENNO) = True Then
                int_no = 0
            Else
                int_no = dao.fields.GENNO
            End If

            int_no = int_no + 1

            dao = New DAO_DRUG.clsDBGEN_NO_02

            Dim str_no As String = "" ' int_no.ToString()
            Dim r_no As String = int_no.ToString()
            r_no = String.Format("{0:0000}", int_no.ToString("0000"))
            str_no = cer_seq & "-" & YEAR.Substring(2, 2) & "-" & r_no
            dao.fields.YEAR = YEAR
            dao.fields.PVCODE = PVCODE
            dao.fields.TYPE = TYPE
            dao.fields.LCNNO = LCNNO
            dao.fields.FORMAT = FORMAT
            dao.fields.GROUP_NO = GROUP_NO
            dao.fields.REF_IDA = REF_IDA
            dao.fields.DESCRIPTION = str_no
            dao.fields.GENNO = int_no
            dao.insert()
            Return str_no
        End Function
        Function get_cerf_short(ByVal cer_type As Integer) As String
            Dim cer_seq As String = ""
            If cer_type = 1 Then
                cer_seq = "PS"
            ElseIf cer_type = 2 Then
                cer_seq = "CP"
            ElseIf cer_type = 3 Then
                cer_seq = "NP"
            ElseIf cer_type = 4 Then
                cer_seq = "TH"
            ElseIf cer_type = 5 Then
                cer_seq = "TH"
            End If
            Return cer_seq
        End Function
        Function GEN_CER_RCVNO(ByVal YEAR As String, ByVal PVCODE As String, ByVal TYPE As String, ByVal LCNNO As String,
                        ByVal FORMAT As String, ByVal GROUP_NO As String, ByVal REF_IDA As String, ByVal DESCRIPTION As String) As String
            Dim int_no As Integer

            Dim dao As New DAO_DRUG.clsDBGEN_NO_03
            dao.GetDataby_GEN2(YEAR, PVCODE, TYPE, LCNNO, FORMAT, GROUP_NO, REF_IDA, DESCRIPTION)


            If IsNothing(dao.fields.GENNO) = True Then
                int_no = 0
            Else
                int_no = dao.fields.GENNO
            End If

            int_no = int_no + 1

            dao = New DAO_DRUG.clsDBGEN_NO_03

            Dim str_no As String = int_no.ToString()
            str_no = String.Format("{0:00000}", int_no.ToString("00000"))
            str_no = YEAR.Substring(2, 2) & str_no
            dao.fields.YEAR = YEAR
            dao.fields.PVCODE = PVCODE
            dao.fields.TYPE = TYPE
            dao.fields.LCNNO = LCNNO
            dao.fields.FORMAT = FORMAT
            dao.fields.GROUP_NO = GROUP_NO
            dao.fields.REF_IDA = REF_IDA
            dao.fields.DESCRIPTION = str_no
            dao.fields.GENNO = int_no
            dao.insert()
            Return str_no
        End Function
        ''' <summary>
        ''' ออกเลขรับ โดยใช้แค่ ปี กับ จังหวัด
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GEN_LCNNO_RCVNO(ByVal REF_IDA As Integer, ByVal PVCODE As String, ByVal GROUP_ID As Integer) As String
            Dim Years As String = con_year(Date.Now.Year)
            Dim dao_gen As New DAO_DRUG.clsDBGEN_NO_03
            dao_gen.GetDataby_GEN_YEAR_PVCODE(Years, PVCODE, GROUP_ID)

            Dim running As Integer = 0
            Try
                running = dao_gen.fields.GENNO
            Catch ex As Exception

            End Try

            running = running + 1

            dao_gen = New DAO_DRUG.clsDBGEN_NO_03
            dao_gen.fields.REF_IDA = REF_IDA
            dao_gen.fields.DESCRIPTION = "เลขรับ สถานที่"
            dao_gen.fields.FORMAT = "1"
            dao_gen.fields.GENNO = running
            dao_gen.fields.GROUP_NO = GROUP_ID
            dao_gen.fields.LCNNO = ""
            dao_gen.fields.PVCODE = PVCODE
            dao_gen.fields.TYPE = "1"
            dao_gen.fields.YEAR = Years
            dao_gen.insert()

            Dim rcvno As String = "0"
            Dim str_no As String = running.ToString()
            str_no = String.Format("{0:00000}", running.ToString("00000"))
            str_no = Years.Substring(2, 2) & str_no
            Return str_no

        End Function

        ''' <summary>
        '''  GENNO_NO_01
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function GEN_NO_01(ByVal YEAR As String, ByVal PVCODE As String, ByVal TYPE As String, ByVal LCNNO As String,
                        ByVal FORMAT As String, ByVal GROUP_NO As String, ByVal REF_IDA As String, ByVal DESCRIPTION As String) As String
            Dim int_no As Integer
            Dim dao As New DAO_DRUG.clsDBGEN_NO_01
            dao.GetDataby_GEN(YEAR, PVCODE, TYPE, LCNNO, FORMAT, GROUP_NO, REF_IDA, DESCRIPTION)
            If IsNothing(dao.fields.GENNO) = True Then
                int_no = 0
            Else
                int_no = dao.fields.GENNO
            End If

            int_no = int_no + 1
            Dim str_no As String = int_no.ToString()
            str_no = String.Format("{0:00000}", int_no.ToString("00000"))
            str_no = YEAR.Substring(2, 2) & str_no

            Dim dao2 As New DAO_DRUG.clsDBGEN_NO_01
            dao2.fields.YEAR = YEAR
            dao2.fields.PVCODE = PVCODE
            dao2.fields.TYPE = TYPE
            dao2.fields.LCNNO = LCNNO
            dao2.fields.FORMAT = FORMAT
            dao2.fields.GROUP_NO = GROUP_NO
            dao2.fields.REF_IDA = REF_IDA
            dao2.fields.DESCRIPTION = str_no
            dao2.fields.GENNO = int_no
            dao2.insert()

            Return str_no
        End Function

        ''' <summary>
        '''  GENNO_NO_02
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function GEN_NO_02(ByVal YEAR As String, ByVal PVCODE As String, ByVal TYPE As String, ByVal LCNNO As String,
                        ByVal FORMAT As String, ByVal GROUP_NO As String, ByVal REF_IDA As String, ByVal DESCRIPTION As String) As String
            Dim int_no As Integer
            Dim dao As New DAO_DRUG.clsDBGEN_NO_02
            dao.GetDataby_GEN(YEAR, PVCODE, TYPE, LCNNO, FORMAT, GROUP_NO, REF_IDA, DESCRIPTION)
            If IsNothing(dao.fields.GENNO) = True Then
                int_no = 0
            Else
                int_no = dao.fields.GENNO
            End If

            dao = New DAO_DRUG.clsDBGEN_NO_02
            int_no = int_no + 1
            Dim str_no As String = int_no.ToString()
            str_no = String.Format("{0:00000}", int_no.ToString("00000"))
            str_no = YEAR.Substring(2, 2) & str_no
            dao.fields.YEAR = YEAR
            dao.fields.PVCODE = PVCODE
            dao.fields.TYPE = TYPE
            dao.fields.LCNNO = LCNNO
            dao.fields.FORMAT = FORMAT
            dao.fields.GROUP_NO = GROUP_NO
            dao.fields.REF_IDA = REF_IDA
            dao.fields.DESCRIPTION = str_no
            dao.fields.GENNO = int_no
            dao.insert()


            Return str_no
        End Function

        Function GEN_NO_04(ByVal YEAR As String, ByVal PVCODE As String, ByVal TYPE As String, ByVal LCNNO As String,
                        ByVal FORMAT As String, ByVal GROUP_NO As String, ByVal REF_IDA As String, ByVal DESCRIPTION As String) As String
            Dim int_no As Integer
            Dim dao As New DAO_DRUG.clsDBGEN_NO_04
            dao.GetDataby_GEN(YEAR, PVCODE, TYPE, LCNNO, FORMAT, GROUP_NO, REF_IDA, DESCRIPTION)
            If IsNothing(dao.fields.GENNO) = True Then
                int_no = 0
            Else
                int_no = dao.fields.GENNO
            End If

            int_no = int_no + 1
            Dim str_no As String = int_no.ToString()
            str_no = String.Format("{0:00000}", int_no.ToString("00000"))
            str_no = YEAR.Substring(2, 2) & str_no

            dao = New DAO_DRUG.clsDBGEN_NO_04
            dao.fields.YEAR = YEAR
            dao.fields.PVCODE = PVCODE
            dao.fields.TYPE = TYPE
            dao.fields.LCNNO = LCNNO
            dao.fields.FORMAT = FORMAT
            dao.fields.GROUP_NO = GROUP_NO
            dao.fields.REF_IDA = REF_IDA
            dao.fields.DESCRIPTION = str_no
            dao.fields.GENNO = int_no
            dao.insert()


            Return str_no
        End Function
        Function GEN_NO_05(ByVal YEAR As String, ByVal PVCODE As String, ByVal TYPE As String, ByVal LCNNO As String,
                        ByVal FORMAT As String, ByVal GROUP_NO As String, ByVal REF_IDA As String, ByVal DESCRIPTION As String) As String
            Dim int_no As Integer
            Dim dao As New DAO_DRUG.clsDBGEN_NO_05
            dao.GetDataby_GEN(YEAR, PVCODE, TYPE, LCNNO, FORMAT, GROUP_NO, REF_IDA, DESCRIPTION)
            If IsNothing(dao.fields.GENNO) = True Then
                int_no = 0
            Else
                int_no = dao.fields.GENNO
            End If

            int_no = int_no + 1
            Dim str_no As String = int_no.ToString()
            str_no = String.Format("{0:00000}", int_no.ToString("00000"))
            str_no = YEAR.Substring(2, 2) & str_no
            dao = New DAO_DRUG.clsDBGEN_NO_05
            dao.fields.YEAR = YEAR
            dao.fields.PVCODE = PVCODE
            dao.fields.TYPE = TYPE
            dao.fields.LCNNO = LCNNO
            dao.fields.FORMAT = FORMAT
            dao.fields.GROUP_NO = GROUP_NO
            dao.fields.REF_IDA = REF_IDA
            dao.fields.DESCRIPTION = str_no
            dao.fields.GENNO = int_no
            dao.insert()


            Return str_no
        End Function
        Function GEN_NO_06(ByVal YEAR As String, ByVal PVCODE As String, ByVal TYPE As String, ByVal LCNNO As String,
                       ByVal FORMAT As String, ByVal GROUP_NO As String, ByVal REF_IDA As String, ByVal DESCRIPTION As String) As String
            Dim int_no As Integer
            Dim dao As New DAO_DRUG.clsDBGEN_NO_06
            dao.GetDataby_GEN(YEAR, PVCODE, TYPE, LCNNO, FORMAT, GROUP_NO, REF_IDA, DESCRIPTION)
            If IsNothing(dao.fields.GENNO) = True Then
                int_no = 0
            Else
                int_no = dao.fields.GENNO
            End If

            dao = New DAO_DRUG.clsDBGEN_NO_06
            int_no = int_no + 1
            Dim str_no As String = int_no.ToString()
            str_no = String.Format("{0:00000}", int_no.ToString("00000"))
            str_no = YEAR.Substring(2, 2) & str_no
            dao.fields.YEAR = YEAR
            dao.fields.PVCODE = PVCODE
            dao.fields.TYPE = TYPE
            dao.fields.LCNNO = LCNNO
            dao.fields.FORMAT = FORMAT
            dao.fields.GROUP_NO = GROUP_NO
            dao.fields.REF_IDA = REF_IDA
            dao.fields.DESCRIPTION = str_no
            dao.fields.GENNO = int_no
            dao.insert()


            Return str_no
        End Function
        Function GEN_NO_07(ByVal YEAR As String, ByVal PVCODE As String, ByVal TYPE As String, ByVal LCNNO As String,
                       ByVal FORMAT As String, ByVal GROUP_NO As String, ByVal REF_IDA As String, ByVal DESCRIPTION As String) As String
            Dim int_no As Integer
            Dim dao As New DAO_DRUG.clsDBGEN_NO_07
            dao.GetDataby_GEN(YEAR, PVCODE, TYPE, LCNNO, FORMAT, GROUP_NO, REF_IDA, DESCRIPTION)
            If IsNothing(dao.fields.GENNO) = True Then
                int_no = 0
            Else
                int_no = dao.fields.GENNO
            End If

            dao = New DAO_DRUG.clsDBGEN_NO_07
            int_no = int_no + 1
            Dim str_no As String = int_no.ToString()
            str_no = String.Format("{0:00000}", int_no.ToString("00000"))
            str_no = YEAR.Substring(2, 2) & str_no
            dao.fields.YEAR = YEAR
            dao.fields.PVCODE = PVCODE
            dao.fields.TYPE = TYPE
            dao.fields.LCNNO = LCNNO
            dao.fields.FORMAT = FORMAT
            dao.fields.GROUP_NO = GROUP_NO
            dao.fields.REF_IDA = REF_IDA
            dao.fields.DESCRIPTION = str_no
            dao.fields.GENNO = int_no
            dao.insert()


            Return str_no
        End Function
        'ลงทะเบียนโปรดัค
        Function GEN_NO_16(ByVal YEAR As String, ByVal PVCODE As String, ByVal TYPE As String, ByVal LCNNO As String,
                       ByVal FORMAT As String, ByVal GROUP_NO As String, ByVal REF_IDA As String, ByVal DESCRIPTION As String) As String
            Dim int_no As Integer
            Dim dao As New DAO_DRUG.clsDBGEN_NO_16
            dao.GetDataby_GEN(YEAR, PVCODE, TYPE, LCNNO, FORMAT, GROUP_NO, REF_IDA, DESCRIPTION)
            If IsNothing(dao.fields.GENNO) = True Then
                int_no = 0
            Else
                int_no = dao.fields.GENNO
            End If

            dao = New DAO_DRUG.clsDBGEN_NO_16
            int_no = int_no + 1
            Dim str_no As String = int_no.ToString()
            str_no = String.Format("{0:00000}", int_no.ToString("00000"))
            str_no = YEAR.Substring(2, 2) & str_no
            dao.fields.YEAR = YEAR
            dao.fields.PVCODE = PVCODE
            dao.fields.TYPE = TYPE
            dao.fields.LCNNO = LCNNO
            dao.fields.FORMAT = FORMAT
            dao.fields.GROUP_NO = GROUP_NO
            dao.fields.REF_IDA = REF_IDA
            dao.fields.DESCRIPTION = str_no
            dao.fields.GENNO = int_no
            dao.insert()


            Return str_no
        End Function
        Function GEN_NO_17(ByVal YEAR As String, ByVal PVCODE As String, ByVal TYPE As String, ByVal LCNNO As String,
                        ByVal FORMAT As String, ByVal GROUP_NO As String, ByVal REF_IDA As String, ByVal DESCRIPTION As String) As String
            Dim int_no As Integer
            Dim dao As New DAO_DRUG.clsDBGEN_NO_17
            dao.GetDataby_GEN(YEAR, PVCODE, TYPE, LCNNO, FORMAT, GROUP_NO, REF_IDA, DESCRIPTION)
            If IsNothing(dao.fields.GENNO) = True Then
                int_no = 0
            Else
                int_no = dao.fields.GENNO
            End If

            dao = New DAO_DRUG.clsDBGEN_NO_17
            int_no = int_no + 1
            Dim str_no As String = int_no.ToString()
            ' str_no = String.Format("{0:00000}", int_no.ToString("00000"))
            str_no = PVCODE & "-" & GROUP_NO & "-" & YEAR.Substring(2, 2) & "-" & str_no
            dao.fields.YEAR = YEAR
            dao.fields.PVCODE = PVCODE
            dao.fields.TYPE = TYPE
            dao.fields.LCNNO = LCNNO
            dao.fields.FORMAT = FORMAT
            dao.fields.GROUP_NO = GROUP_NO
            dao.fields.REF_IDA = REF_IDA
            dao.fields.DESCRIPTION = str_no
            dao.fields.GENNO = int_no
            dao.insert()


            Return str_no
        End Function

        Function GEN_NO_18(ByVal YEAR As String, ByVal PVCODE As String, ByVal TYPE As String, ByVal LCNNO As String,
                        ByVal FORMAT As String, ByVal GROUP_NO As String, ByVal REF_IDA As String, ByVal DESCRIPTION As String) As String
            Dim int_no As Integer
            Dim dao As New DAO_DRUG.clsDBGEN_NO_18
            dao.GetDataby_GEN(YEAR, PVCODE, TYPE, LCNNO, FORMAT, GROUP_NO, REF_IDA, DESCRIPTION)
            If IsNothing(dao.fields.GENNO) = True Then
                int_no = 0
            Else
                int_no = dao.fields.GENNO
            End If

            dao = New DAO_DRUG.clsDBGEN_NO_18
            int_no = int_no + 1
            Dim str_no As String = int_no.ToString()
            ' str_no = String.Format("{0:00000}", int_no.ToString("00000"))
            str_no = PVCODE & "-" & GROUP_NO & "-" & YEAR.Substring(2, 2) & "-" & str_no
            dao.fields.YEAR = YEAR
            dao.fields.PVCODE = PVCODE
            dao.fields.TYPE = TYPE
            dao.fields.LCNNO = LCNNO
            dao.fields.FORMAT = FORMAT
            dao.fields.GROUP_NO = GROUP_NO
            dao.fields.REF_IDA = REF_IDA
            dao.fields.DESCRIPTION = str_no
            dao.fields.GENNO = int_no
            dao.insert()


            Return str_no
        End Function
        ''' <summary>
        '''  GEN เลขใบรับนัด
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function GEN_NO_02_2(ByVal YEAR As String, ByVal PVCODE As String, ByVal TYPE As String, ByVal LCNNO As String,
                        ByVal FORMAT As String, ByVal GROUP_NO As String, ByVal REF_IDA As String, ByVal DESCRIPTION As String) As String
            Dim int_no As Integer
            Dim dao As New DAO_DRUG.clsDBGEN_NO_02
            dao.GetDataby_GEN3(YEAR, PVCODE, GROUP_NO, REF_IDA)
            If IsNothing(dao.fields.GENNO) = True Then
                int_no = 0
            Else
                int_no = dao.fields.GENNO
            End If

            dao = New DAO_DRUG.clsDBGEN_NO_02
            int_no = int_no + 1
            Dim str_no As String = int_no.ToString()
            ' str_no = String.Format("{0:00000}", int_no.ToString("00000"))
            str_no = PVCODE & "-" & GROUP_NO & "-" & YEAR.Substring(2, 2) & "-" & str_no
            dao.fields.YEAR = YEAR
            dao.fields.PVCODE = PVCODE
            dao.fields.TYPE = TYPE
            dao.fields.LCNNO = LCNNO
            dao.fields.FORMAT = FORMAT
            dao.fields.GROUP_NO = GROUP_NO
            dao.fields.REF_IDA = REF_IDA
            dao.fields.DESCRIPTION = str_no
            dao.fields.GENNO = int_no
            dao.insert()


            Return str_no
        End Function


        ' gen rcvno ชื่อสาร
        Public Function GEN_RCVNO_NO(ByVal YEAR As String, ByVal PVNCD As String, ByVal PROCESS_ID As String, ByVal FK_IDA As Integer) As String
            Dim int_no As Integer
            Dim dao As New DAO_DRUG.ClsDBGEN_RCVNO                                      '
            dao.GetDataby_Year_PVNCD_PROCESS_ID_MAX(PVNCD, YEAR, PROCESS_ID)            'สร้างเลขล่าสุด
            If IsNothing(dao.fields.GEN_RCV) = True Then
                int_no = 0
            Else
                int_no = dao.fields.GEN_RCV
            End If
            int_no = int_no + 1

            Dim str_no As String = int_no.ToString()
            str_no = String.Format("{0:00000}", int_no.ToString("00000"))
            str_no = YEAR.Substring(2, 2) & str_no
            dao = New DAO_DRUG.ClsDBGEN_RCVNO
            dao.fields.YEARS = YEAR
            dao.fields.PVNCD = PVNCD
            dao.fields.GEN_RCV = int_no
            dao.fields.PROCESS_ID = PROCESS_ID
            dao.fields.FK_IDA = FK_IDA
            dao.insert()
            Return str_no
        End Function

        Public Function GEN_RCVNO_NO_50k(ByVal YEAR As String, ByVal PVNCD As String, ByVal PROCESS_ID As String, ByVal FK_IDA As Integer) As String
            Dim int_no As Integer
            Dim dao As New DAO_DRUG.ClsDBGEN_RCVNO
            dao.GetDataby_Year_PVNCD_PROCESS_ID_MAX(PVNCD, YEAR, PROCESS_ID)
            If IsNothing(dao.fields.GEN_RCV) = True Then
                int_no = 0
            Else
                int_no = dao.fields.GEN_RCV
            End If
            int_no = int_no + 1

            Dim str_no As String = int_no.ToString()
            str_no = String.Format("{0:50000}", int_no.ToString("50000"))
            str_no = YEAR.Substring(2, 2) & str_no
            dao = New DAO_DRUG.ClsDBGEN_RCVNO
            dao.fields.YEARS = YEAR
            dao.fields.PVNCD = PVNCD
            dao.fields.GEN_RCV = int_no
            dao.fields.PROCESS_ID = PROCESS_ID
            dao.fields.FK_IDA = FK_IDA
            dao.insert()
            Return str_no
        End Function
        Public Function GEN_RGTNO50K(ByVal YEAR As String, ByVal PVNCD As String, ByVal RGTTPCD As String, ByVal FK_IDA As Integer, ByVal process_id As String) As String
            Dim int_no As Integer

            Dim dao As New DAO_DRUG.clsDBGEN_NO_01  '
            dao.GetDataby_RGTNO_50KMAX(YEAR, PVNCD, RGTTPCD, FK_IDA, process_id)
            If IsNothing(dao.fields.GENNO) = True Then
                int_no = 0
            Else
                int_no = dao.fields.GENNO
            End If
            int_no = int_no + 1

            Dim str_no As String = int_no.ToString()
            str_no = String.Format("{0:50000}", int_no.ToString("50000"))
            str_no = YEAR.Substring(2, 2) & str_no
            dao = New DAO_DRUG.clsDBGEN_NO_01
            dao.fields.YEAR = YEAR
            dao.fields.PVCODE = PVNCD
            dao.fields.GENNO = int_no
            dao.fields.TYPE = process_id 'RGTTPCD
            dao.fields.GROUP_NO = RGTTPCD
            dao.fields.IDA = FK_IDA
            dao.fields.LCNNO = str_no
            dao.fields.DESCRIPTION = str_no
            dao.insert()
            Return str_no
        End Function
        Public Function GEN_RGTNO(ByVal YEAR As String, ByVal PVNCD As String, ByVal RGTTPCD As String, ByVal FK_IDA As Integer) As String
            Dim int_no As Integer

            Dim dao As New DAO_DRUG.clsDBGEN_NO_01
            '
            If RGTTPCD = "1" Or RGTTPCD = "6" Then
                dao.GetDataby_RGTNO_MAX_N_NC(YEAR, PVNCD, FK_IDA)
            ElseIf RGTTPCD = "7" Or RGTTPCD = "B" Then
                dao.GetDataby_RGTNO_MAX_NB_NBC(YEAR, PVNCD, FK_IDA)
            Else
                dao.GetDataby_RGTNO_MAX(YEAR, PVNCD, RGTTPCD, FK_IDA)
            End If
            If IsNothing(dao.fields.GENNO) = True Then
                int_no = 0
            Else
                int_no = dao.fields.GENNO
            End If
            int_no = int_no + 1

            Dim str_no As String = int_no.ToString()
            str_no = String.Format("{0:00000}", int_no.ToString("00000"))
            str_no = YEAR.Substring(2, 2) & str_no
            dao = New DAO_DRUG.clsDBGEN_NO_01
            dao.fields.YEAR = YEAR
            dao.fields.PVCODE = PVNCD
            dao.fields.GENNO = int_no
            dao.fields.TYPE = RGTTPCD
            dao.fields.IDA = FK_IDA
            dao.fields.LCNNO = str_no
            dao.fields.DESCRIPTION = str_no
            dao.insert()
            Return str_no
        End Function
        Public Function GEN_RCVNO_RGT(ByVal YEAR As String, ByVal PVNCD As String, ByVal RGTTPCD As String, ByVal FK_IDA As Integer) As String
            Dim int_no As Integer

            Dim dao As New DAO_DRUG.ClsDBGEN_RCVNO
            '
            If RGTTPCD = "1" Or RGTTPCD = "6" Then
                dao.GetDataby_RGTNO_MAX_N_NC(YEAR, PVNCD, FK_IDA)
            ElseIf RGTTPCD = "7" Or RGTTPCD = "B" Then
                dao.GetDataby_RGTNO_MAX_NB_NBC(YEAR, PVNCD, FK_IDA)
            Else
                dao.GetDataby_RGTNO_MAX(YEAR, PVNCD, RGTTPCD, FK_IDA)
            End If
            If IsNothing(dao.fields.GEN_RCV) = True Then
                int_no = 0
            Else
                int_no = dao.fields.GEN_RCV
            End If
            int_no = int_no + 1

            Dim str_no As String = int_no.ToString()
            str_no = String.Format("{0:00000}", int_no.ToString("00000"))
            str_no = YEAR.Substring(2, 2) & str_no
            dao = New DAO_DRUG.ClsDBGEN_RCVNO
            dao.fields.YEARS = YEAR
            dao.fields.PVNCD = PVNCD
            dao.fields.GEN_RCV = int_no
            dao.fields.GEN_TYPE = RGTTPCD
            dao.fields.IDA = FK_IDA
            dao.insert()
            Return str_no
        End Function
        Public Function GEN_DH15TDGT_NO(ByVal YEAR As String, ByVal aroi As String, ByVal PROCESS_ID As String, ByVal FK_IDA As Integer, ByVal DETAIL_ID As Integer _
                                        , ByVal type_cas As String) As String
            Dim int_no As Integer = 0
            Dim dao As New DAO_DRUG.clsDBGEN_DH15TDGT_NO
            dao.GetDataby_GEN_MAX2(YEAR, type_cas)
            If IsNothing(dao.fields.RUNNING_NUMBER) = True Then
                int_no = 0
            Else
                int_no = dao.fields.RUNNING_NUMBER
            End If
            int_no = int_no + 1

            Dim str_no As String = int_no.ToString()
            str_no = String.Format("{0:0000000}", int_no.ToString("0000000"))
            str_no = "DRM-" & aroi & "-" & type_cas & "-" & YEAR.Substring(2, 2) & "-" & str_no


            dao = New DAO_DRUG.clsDBGEN_DH15TDGT_NO
            dao.fields.FK_DETAIL_IDA = DETAIL_ID
            dao.fields.FULL_NUMBER_15DIGIT = str_no
            dao.fields.TYPE_CAS = type_cas
            dao.fields.YEARS = YEAR
            dao.fields.RUNNING_NUMBER = int_no
            dao.fields.PROCESS_ID = PROCESS_ID
            dao.fields.FK_IDA = FK_IDA
            dao.fields.aroi = aroi
            dao.insert()
            Return str_no
        End Function
        Function GEN_RCVNO_REQUEST(ByVal YEAR As String, ByVal PVCODE As String, ByVal GEN_TYPE As String, ByVal LCNNO As String,
                        ByVal FORMAT As String, ByVal PROCESS_ID As String, ByVal REF_IDA As String, ByVal DESCRIPTION As String) As String
            Dim int_no As Integer
            Dim dao As New DAO_DRUG.TB_GEN_RCVNO_REQUEST
            dao.GetDataby_GEN4(YEAR, PVCODE, PROCESS_ID, GEN_TYPE)
            If IsNothing(dao.fields.GEN_RCV) = True Then
                int_no = 0
            Else
                int_no = dao.fields.GEN_RCV
            End If

            dao = New DAO_DRUG.TB_GEN_RCVNO_REQUEST
            int_no = int_no + 1
            Dim str_no As String = int_no.ToString()
            ' str_no = String.Format("{0:00000}", int_no.ToString("00000"))
            str_no = PVCODE & "-" & PROCESS_ID & "-" & YEAR.Substring(2, 2) & "-" & str_no
            dao.fields.YEARS = YEAR
            dao.fields.PVNCD = PVCODE
            dao.fields.PROCESS_ID = PROCESS_ID
            dao.fields.FK_IDA = REF_IDA
            dao.fields.GEN_RCV = int_no
            dao.fields.GEN_TYPE = GEN_TYPE
            dao.insert()

            Return str_no
        End Function
        '-----------------------------------------------

        'CODE แปลงเลข 5900001
        Public Function FORMAT_NUMBER_FULL(ByVal YEAR As String, ByVal int_no As Integer) As String
            Dim str_no As String = int_no.ToString()
            str_no = String.Format("{0:00000}", int_no.ToString("00000"))
            str_no = YEAR.Substring(2, 2) & str_no
            Return str_no
        End Function

        'CODE แปลงเลข ให้รองรับแบบ 1/59
        Public Function FORMAT_NUMBER_MINI(ByVal YEAR As String, ByVal int_no As String) As String
            Dim no_split As Integer = 0

            Try
                no_split = CInt(int_no.Substring(2, 5))
            Catch ex As Exception

            End Try

            Dim str_no As String = ""
            str_no = no_split & "/" & YEAR.Substring(2, 2)
            Return str_no
        End Function

        Public Function FORMAT_NUMBER_YEAR_FULL(ByVal YEAR As String, ByVal int_no As String) As String
            Dim no_split As Integer = 0

            Try
                no_split = CInt(int_no.Substring(2, 5))
            Catch ex As Exception

            End Try

            Dim str_no As String = ""
            str_no = no_split & "/" & YEAR
            Return str_no
        End Function

    End Class
End Namespace
