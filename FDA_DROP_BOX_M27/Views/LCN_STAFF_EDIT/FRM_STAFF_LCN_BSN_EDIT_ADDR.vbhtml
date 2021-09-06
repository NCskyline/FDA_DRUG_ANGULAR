@Code
    ViewData("Title") = "FRM_STAFF_LCN_BSN_EDIT_ADDR"
End Code

<script src="~/Scripts_angular/CENTER_SV.js"></script>
@*<script src="~/Scripts_angular/LCN_EDIT_CTRL.js"></script>*@
<script src="~/Scripts_angular/LCN_STAFF_EDIT_CTRL.js"></script>

<div ng-controller="LCN_STAFF_EDIT_CTRL" ng-app="ANGULAR_APP" ng-init="pageload()" class="ic">

    <div style="font-family:'Taviraj';font-size:20px;">
        <h2>
            แก้ไขชื่อ-ที่อยู่ผู้ดำเนินกิจการ
        </h2>
        <table class="table">
            <tr>
                <td align="right" style="width:15%;">เลขบัตรประชาชน</td>
                <td style="padding-left:1%;">
                    
                    <input class="form-control inline" ng-model="DATA_BSN.DALCN_LOCATION_BSN.BSN_IDENTIFY" style="font-family:'Taviraj';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td align="right">คำนำหน้าชื่อ</td>
                <td style="padding-left:1%;">
                    
                    <select class="dropdown" ng-model="DATA_BSN.DALCN_LOCATION_BSN.BSN_PREFIXTHAICD" >
                        <option ng-repeat="x in PREFIX_LIST" value="{{x.prefixcd}}">{{x.thanm}}</option>
                    </select>
                </td>
            </tr>
            <tr>
                <td align="right">ชื่อ</td>
                <td style="padding-left:1%;">
                    <asp:TextBox ID="txt_bsn_name" runat="server" CssClass="input-sm" Width="60%"></asp:TextBox>
                    <input class="form-control inline" ng-model="DATA_BSN.DALCN_LOCATION_BSN.BSN_THAINAME" style="font-family:'Taviraj';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td align="right">นามสกุล</td>
                <td style="padding-left:1%;">
                    <asp:TextBox ID="txt_bsn_lastname" runat="server" CssClass="input-sm" Width="60%"></asp:TextBox>
                    <input class="form-control inline" ng-model="DATA_BSN.DALCN_LOCATION_BSN.BSN_THAILASTNAME" style="font-family:'Taviraj';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td align="right">รหัสประจำบ้าน</td>
                <td style="padding-left:1%;">
                    <asp:TextBox ID="txt_BSN_HOUSENO" runat="server" CssClass="input-sm"></asp:TextBox>
                    <input class="form-control inline" ng-model="DATA_BSN.DALCN_LOCATION_BSN.BSN_HOUSENO" style="font-family:'Taviraj';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td align="right">เลขที่</td>
                <td style="padding-left:1%;">
                    <asp:TextBox ID="txt_BSN_ENGADDR" runat="server" CssClass="input-sm" Width="40%"></asp:TextBox>
                    <input class="form-control inline" ng-model="DATA_BSN.DALCN_LOCATION_BSN.BSN_ADDR" style="font-family:'Taviraj';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td align="right">หมู่</td>
                <td style="padding-left:1%;">
                    <asp:TextBox ID="txt_BSN_MOO" runat="server" CssClass="input-sm"></asp:TextBox>
                    <input class="form-control inline" ng-model="DATA_BSN.DALCN_LOCATION_BSN.BSN_MOO" style="font-family:'Taviraj';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td align="right">ซอย</td>
                <td style="padding-left:1%;">
                    <asp:TextBox ID="txt_BSN_SOI" runat="server" CssClass="input-sm"></asp:TextBox>
                    <input class="form-control inline" ng-model="DATA_BSN.DALCN_LOCATION_BSN.BSN_SOI" style="font-family:'Taviraj';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td align="right">ถนน</td>
                <td style="padding-left:1%;">
                    <asp:TextBox ID="txt_BSN_ROAD" runat="server" CssClass="input-sm"></asp:TextBox>
                    <input class="form-control inline" ng-model="DATA_BSN.DALCN_LOCATION_BSN.BSN_ROAD" style="font-family:'Taviraj';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td align="right">
                    จังหวัด
                </td>
                <td style="padding-left:1%;">
                    <select class="dropdown" ng-model="DATA_BSN.DALCN_LOCATION_BSN.CHANGWAT_ID" ng-change="Bind_dll_amp(DATA_BSN.DALCN_LOCATION_BSN.CHANGWAT_ID)">
                        <option ng-repeat="x in REF_CHNGWT" value="{{x.chngwtcd}}">{{x.thachngwtnm}}</option>
                    </select>
                </td>
            </tr>
            <tr>
                <td align="right">
                    เขต/อำเภอ
                </td>
                <td style="padding-left:1%;">
                    <select class="dropdown" ng-model="DATA_BSN.DALCN_LOCATION_BSN.AMPHR_ID" ng-change="Bind_dll_tmb(DATA_BSN.DALCN_LOCATION_BSN.CHANGWAT_ID , DATA_BSN.DALCN_LOCATION_BSN.AMPHR_ID)">
                        <option ng-repeat="x in REF_AMP" value="{{x.amphrcd}}">{{x.thaamphrnm}}</option>
                    </select>
                </td>
            </tr>
            <tr>
                <td align="right">
                    แขวง/ตำบล
                </td>
                <td style="padding-left:1%;">

                    <select class="dropdown" ng-model="DATA_BSN.DALCN_LOCATION_BSN.TUMBON_ID">
                        <option ng-repeat="x in REF_TMB" value="{{x.thmblcd}}">{{x.thathmblnm}}</option>
                    </select>
                </td>
            </tr>
            <tr>
                <td align="right">
                    รหัสไปรษณีย์
                </td>
                <td style="padding-left:1%;">
                    <input class="form-control inline" ng-model="DATA_BSN.DALCN_LOCATION_BSN.BSN_ZIPCODE" style="font-family:'Taviraj';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td align="right">
                    โทรศัพท์
                </td>
                <td style="padding-left:1%;">
                    <input class="form-control inline" ng-model="DATA_BSN.DALCN_LOCATION_BSN.BSN_TEL" style="font-family:'Taviraj';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td align="right">
                    โทรสาร
                </td>
                <td style="padding-left:1%;">
                    <input class="form-control inline" ng-model="DATA_BSN.DALCN_LOCATION_BSN.BSN_FAX" style="font-family:'Taviraj';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td align="right">
                    โทรศัพท์มือถือ
                </td>
                <td style="padding-left:1%;">
                    <input class="form-control inline" ng-model="DATA_BSN.DALCN_LOCATION_BSN.BSN_Mobile" style="font-family:'Taviraj';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    
                    <div style="text-align:center;">
                        <input type="button" value="แก้ไข" />
                        <input type="button" value="กลับหน้าหลัก" />
                    </div>
                </td>
            </tr>
        </table>
    </div>
</div>
