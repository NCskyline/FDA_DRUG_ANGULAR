﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
'
Namespace WS_TRADERS
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="WS_TRADERSoap", [Namespace]:="http://tempuri.org/")>  _
    Partial Public Class WS_TRADER
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private CallWS_TRADEROperationCompleted As System.Threading.SendOrPostCallback
        
        Private WS_TRADER_EGAOperationCompleted As System.Threading.SendOrPostCallback
        
        Private WS_TRADER_INSERTOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.FDA_DROP_BOX_M27.My.MySettings.Default.FDA_DROP_BOX_M27_WS_TRADERS_WS_TRADER
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event CallWS_TRADERCompleted As CallWS_TRADERCompletedEventHandler
        
        '''<remarks/>
        Public Event WS_TRADER_EGACompleted As WS_TRADER_EGACompletedEventHandler
        
        '''<remarks/>
        Public Event WS_TRADER_INSERTCompleted As WS_TRADER_INSERTCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/WS_TRADER", RequestElementName:="WS_TRADER", RequestNamespace:="http://tempuri.org/", ResponseElementName:="WS_TRADERResponse", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function CallWS_TRADER(ByVal UserName As String, ByVal Password As String, ByVal TaxNo As String) As <System.Xml.Serialization.XmlElementAttribute("WS_TRADERResult")> JuristicCertificateInfo
            Dim results() As Object = Me.Invoke("CallWS_TRADER", New Object() {UserName, Password, TaxNo})
            Return CType(results(0),JuristicCertificateInfo)
        End Function
        
        '''<remarks/>
        Public Overloads Sub CallWS_TRADERAsync(ByVal UserName As String, ByVal Password As String, ByVal TaxNo As String)
            Me.CallWS_TRADERAsync(UserName, Password, TaxNo, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub CallWS_TRADERAsync(ByVal UserName As String, ByVal Password As String, ByVal TaxNo As String, ByVal userState As Object)
            If (Me.CallWS_TRADEROperationCompleted Is Nothing) Then
                Me.CallWS_TRADEROperationCompleted = AddressOf Me.OnCallWS_TRADEROperationCompleted
            End If
            Me.InvokeAsync("CallWS_TRADER", New Object() {UserName, Password, TaxNo}, Me.CallWS_TRADEROperationCompleted, userState)
        End Sub
        
        Private Sub OnCallWS_TRADEROperationCompleted(ByVal arg As Object)
            If (Not (Me.CallWS_TRADERCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent CallWS_TRADERCompleted(Me, New CallWS_TRADERCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/WS_TRADER_EGA", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function WS_TRADER_EGA(ByVal Citizenid As String, ByVal citizen_authorize As String, ByVal UserName As String, ByVal Password As String) As Object
            Dim results() As Object = Me.Invoke("WS_TRADER_EGA", New Object() {Citizenid, citizen_authorize, UserName, Password})
            Return CType(results(0),Object)
        End Function
        
        '''<remarks/>
        Public Overloads Sub WS_TRADER_EGAAsync(ByVal Citizenid As String, ByVal citizen_authorize As String, ByVal UserName As String, ByVal Password As String)
            Me.WS_TRADER_EGAAsync(Citizenid, citizen_authorize, UserName, Password, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub WS_TRADER_EGAAsync(ByVal Citizenid As String, ByVal citizen_authorize As String, ByVal UserName As String, ByVal Password As String, ByVal userState As Object)
            If (Me.WS_TRADER_EGAOperationCompleted Is Nothing) Then
                Me.WS_TRADER_EGAOperationCompleted = AddressOf Me.OnWS_TRADER_EGAOperationCompleted
            End If
            Me.InvokeAsync("WS_TRADER_EGA", New Object() {Citizenid, citizen_authorize, UserName, Password}, Me.WS_TRADER_EGAOperationCompleted, userState)
        End Sub
        
        Private Sub OnWS_TRADER_EGAOperationCompleted(ByVal arg As Object)
            If (Not (Me.WS_TRADER_EGACompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent WS_TRADER_EGACompleted(Me, New WS_TRADER_EGACompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/WS_TRADER_INSERT", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function WS_TRADER_INSERT(ByVal UserName As String, ByVal Password As String, ByVal TaxNo As String) As String
            Dim results() As Object = Me.Invoke("WS_TRADER_INSERT", New Object() {UserName, Password, TaxNo})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub WS_TRADER_INSERTAsync(ByVal UserName As String, ByVal Password As String, ByVal TaxNo As String)
            Me.WS_TRADER_INSERTAsync(UserName, Password, TaxNo, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub WS_TRADER_INSERTAsync(ByVal UserName As String, ByVal Password As String, ByVal TaxNo As String, ByVal userState As Object)
            If (Me.WS_TRADER_INSERTOperationCompleted Is Nothing) Then
                Me.WS_TRADER_INSERTOperationCompleted = AddressOf Me.OnWS_TRADER_INSERTOperationCompleted
            End If
            Me.InvokeAsync("WS_TRADER_INSERT", New Object() {UserName, Password, TaxNo}, Me.WS_TRADER_INSERTOperationCompleted, userState)
        End Sub
        
        Private Sub OnWS_TRADER_INSERTOperationCompleted(ByVal arg As Object)
            If (Not (Me.WS_TRADER_INSERTCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent WS_TRADER_INSERTCompleted(Me, New WS_TRADER_INSERTCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://model.task.dbd.com")>  _
    Partial Public Class JuristicCertificateInfo
        
        Private juristicTypeField As String
        
        Private juristicIDField As String
        
        Private registerDateField As String
        
        Private oldJuristicIDField As String
        
        Private juristicNameField As String
        
        Private juristicNameEngField As String
        
        Private numberOfCommitteeField As Integer
        
        Private committeeInformationField() As CommitteeInformation
        
        Private registerCapitalField As Double
        
        Private paidRegisterCapitalField As Double
        
        Private juristicBuildingField As String
        
        Private juristicRoomNoField As String
        
        Private juristicFloorField As String
        
        Private juristicVillageNameField As String
        
        Private juristicAddressNoField As String
        
        Private juristicMooField As String
        
        Private juristicSoiField As String
        
        Private juristicRoadField As String
        
        Private juristicTumbolField As String
        
        Private juristicAmpurField As String
        
        Private juristicProvinceField As String
        
        Private numberOfObjectiveField As String
        
        Private numberOfPageOfObjectiveField As String
        
        Private authorizeDescriptionField() As AuthorizeDescription
        
        Private addressField As String
        
        Private bfileFromDBField() As BfileFromDB
        
        Private standardObjectiveField As StandardObjective
        
        Private juristicStatusField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)>  _
        Public Property juristicType() As String
            Get
                Return Me.juristicTypeField
            End Get
            Set
                Me.juristicTypeField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)>  _
        Public Property juristicID() As String
            Get
                Return Me.juristicIDField
            End Get
            Set
                Me.juristicIDField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)>  _
        Public Property registerDate() As String
            Get
                Return Me.registerDateField
            End Get
            Set
                Me.registerDateField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)>  _
        Public Property oldJuristicID() As String
            Get
                Return Me.oldJuristicIDField
            End Get
            Set
                Me.oldJuristicIDField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)>  _
        Public Property juristicName() As String
            Get
                Return Me.juristicNameField
            End Get
            Set
                Me.juristicNameField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)>  _
        Public Property juristicNameEng() As String
            Get
                Return Me.juristicNameEngField
            End Get
            Set
                Me.juristicNameEngField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property numberOfCommittee() As Integer
            Get
                Return Me.numberOfCommitteeField
            End Get
            Set
                Me.numberOfCommitteeField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlArrayAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true),  _
         System.Xml.Serialization.XmlArrayItemAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property committeeInformation() As CommitteeInformation()
            Get
                Return Me.committeeInformationField
            End Get
            Set
                Me.committeeInformationField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property registerCapital() As Double
            Get
                Return Me.registerCapitalField
            End Get
            Set
                Me.registerCapitalField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property paidRegisterCapital() As Double
            Get
                Return Me.paidRegisterCapitalField
            End Get
            Set
                Me.paidRegisterCapitalField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)>  _
        Public Property juristicBuilding() As String
            Get
                Return Me.juristicBuildingField
            End Get
            Set
                Me.juristicBuildingField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)>  _
        Public Property juristicRoomNo() As String
            Get
                Return Me.juristicRoomNoField
            End Get
            Set
                Me.juristicRoomNoField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)>  _
        Public Property juristicFloor() As String
            Get
                Return Me.juristicFloorField
            End Get
            Set
                Me.juristicFloorField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)>  _
        Public Property juristicVillageName() As String
            Get
                Return Me.juristicVillageNameField
            End Get
            Set
                Me.juristicVillageNameField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)>  _
        Public Property juristicAddressNo() As String
            Get
                Return Me.juristicAddressNoField
            End Get
            Set
                Me.juristicAddressNoField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)>  _
        Public Property juristicMoo() As String
            Get
                Return Me.juristicMooField
            End Get
            Set
                Me.juristicMooField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)>  _
        Public Property juristicSoi() As String
            Get
                Return Me.juristicSoiField
            End Get
            Set
                Me.juristicSoiField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)>  _
        Public Property juristicRoad() As String
            Get
                Return Me.juristicRoadField
            End Get
            Set
                Me.juristicRoadField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)>  _
        Public Property juristicTumbol() As String
            Get
                Return Me.juristicTumbolField
            End Get
            Set
                Me.juristicTumbolField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)>  _
        Public Property juristicAmpur() As String
            Get
                Return Me.juristicAmpurField
            End Get
            Set
                Me.juristicAmpurField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)>  _
        Public Property juristicProvince() As String
            Get
                Return Me.juristicProvinceField
            End Get
            Set
                Me.juristicProvinceField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)>  _
        Public Property numberOfObjective() As String
            Get
                Return Me.numberOfObjectiveField
            End Get
            Set
                Me.numberOfObjectiveField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)>  _
        Public Property numberOfPageOfObjective() As String
            Get
                Return Me.numberOfPageOfObjectiveField
            End Get
            Set
                Me.numberOfPageOfObjectiveField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlArrayAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true),  _
         System.Xml.Serialization.XmlArrayItemAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property authorizeDescription() As AuthorizeDescription()
            Get
                Return Me.authorizeDescriptionField
            End Get
            Set
                Me.authorizeDescriptionField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)>  _
        Public Property address() As String
            Get
                Return Me.addressField
            End Get
            Set
                Me.addressField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlArrayAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true),  _
         System.Xml.Serialization.XmlArrayItemAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property bfileFromDB() As BfileFromDB()
            Get
                Return Me.bfileFromDBField
            End Get
            Set
                Me.bfileFromDBField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)>  _
        Public Property standardObjective() As StandardObjective
            Get
                Return Me.standardObjectiveField
            End Get
            Set
                Me.standardObjectiveField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)>  _
        Public Property juristicStatus() As String
            Get
                Return Me.juristicStatusField
            End Get
            Set
                Me.juristicStatusField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://sub.model.task.dbd.com")>  _
    Partial Public Class CommitteeInformation
        
        Private citizenIDField As String
        
        Private idField As Integer
        
        Private nameField As String
        
        Private lastNameField As String
        
        Private titleField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)>  _
        Public Property citizenID() As String
            Get
                Return Me.citizenIDField
            End Get
            Set
                Me.citizenIDField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property id() As Integer
            Get
                Return Me.idField
            End Get
            Set
                Me.idField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)>  _
        Public Property name() As String
            Get
                Return Me.nameField
            End Get
            Set
                Me.nameField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)>  _
        Public Property lastName() As String
            Get
                Return Me.lastNameField
            End Get
            Set
                Me.lastNameField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)>  _
        Public Property title() As String
            Get
                Return Me.titleField
            End Get
            Set
                Me.titleField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://sub.model.task.dbd.com")>  _
    Partial Public Class StandardObjective
        
        Private objectiveDescriptionField As String
        
        Private standdardIdField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)>  _
        Public Property objectiveDescription() As String
            Get
                Return Me.objectiveDescriptionField
            End Get
            Set
                Me.objectiveDescriptionField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)>  _
        Public Property standdardId() As String
            Get
                Return Me.standdardIdField
            End Get
            Set
                Me.standdardIdField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://sub.model.task.dbd.com")>  _
    Partial Public Class BfileFromDB
        
        Private bfileDataField As String
        
        Private bfileNameField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)>  _
        Public Property bfileData() As String
            Get
                Return Me.bfileDataField
            End Get
            Set
                Me.bfileDataField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)>  _
        Public Property bfileName() As String
            Get
                Return Me.bfileNameField
            End Get
            Set
                Me.bfileNameField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://sub.model.task.dbd.com")>  _
    Partial Public Class AuthorizeDescription
        
        Private authorizeDescriptionField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)>  _
        Public Property authorizeDescription() As String
            Get
                Return Me.authorizeDescriptionField
            End Get
            Set
                Me.authorizeDescriptionField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")>  _
    Public Delegate Sub CallWS_TRADERCompletedEventHandler(ByVal sender As Object, ByVal e As CallWS_TRADERCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class CallWS_TRADERCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As JuristicCertificateInfo
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),JuristicCertificateInfo)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")>  _
    Public Delegate Sub WS_TRADER_EGACompletedEventHandler(ByVal sender As Object, ByVal e As WS_TRADER_EGACompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class WS_TRADER_EGACompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Object
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Object)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")>  _
    Public Delegate Sub WS_TRADER_INSERTCompletedEventHandler(ByVal sender As Object, ByVal e As WS_TRADER_INSERTCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class WS_TRADER_INSERTCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
End Namespace