﻿Public Class MODEL_DH

    Public lcnno As String
    Public rcvno As String
    Public rcvdate As Date
    Public thanameplace As String
    Public nameOperator As String
    Public Certificate_Number As String
    Public Manufacturer As String
    Public Address As String
    Public Province As String
    Public Country As String
    Public MFD_DATE As Date
    Public EXP_DATE As Date
    Public _CER As New CER

    ''' <summary>
    ''' เลขที่ใบรับรอง (Certificate Number)
    ''' </summary>
    Public CERTIFICATION_NUMBER_ALL As String
    ''' <summary>
    ''' ชื่อสถานที่ผลิตในต่างประเทศ (Manufacturer) --CER_DETAIL_MANUFACTURE 
    ''' </summary>
    Public NAME_ADDRESS As String
    ''' <summary>
    ''' ที่อยู่ (Address) CER_DETAIL_MANUFACTURE
    ''' </summary>
    Public ADDRESS_NUMBER As String
    ''' <summary>
    ''' เมือง (City / Province/ State) --CER_DETAIL_MANUFACTURE 
    ''' </summary>
    Public ADDRESS_CITY As String

End Class
