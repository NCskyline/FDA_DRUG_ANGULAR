@*@Code
    ViewData("Title") = "FRM_CHEMICAL_STAFF_COMFIRM_TEXT"
End Code*@
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/DH_STAFF_CTRL.js"></script>
<div class="ic" ng-controller="DH_STAFF_CTRL" ng-app="ANGULAR_APP" >
    <table style="width: 100%; height: 500px;">
        <tr>
            <td rowspan="2" style="width: 55%;">

                <div class="panel-body">
   
                    <div>
                        <h3>
                            ตรวจสอบชื่อสาร
                        </h3>
                        <table class="table">
                            <tr>
                                <td>ชื่อสาร</td>
                                <td>
                                    <label>{{LIST_CHEM.iowanm_show}}</label>
                                </td>
                            </tr>

                            <tr>
                                <td>CAS NO.</td>
                                <td>
                                    <label>{{LIST_CHEM.cas_number_show}}</label>
                                </td>
                            </tr>

                            <tr>
                                <td>aori</td>
                                <td>
                                    <label>{{LIST_CHEM.aori_show}}</label>
                                </td>
                            </tr>


                        </table>

                        <table class="table">
                            <tr>
                                <td>ชื่อสารที่ต้องการค้นหา</td>
                                <td>


                                    <input class="form-control inline" ng-model="iowanm_search" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                                </td>
                                <td>
                                    <input type="button" value="ค้นหา" />
                                </td>
                            </tr>
                            <tr>
                                <td colspan="3">
                                    //ตารางผลการค้นหาสาร
                                    @*<telerik:RadGrid ID="RadGrid1" runat="server" AllowPaging="true" PageSize="10">
                        <MasterTableView AutoGenerateColumns="False" DataKeyNames="IDA">
                            <Columns>
                                <telerik:GridBoundColumn DataField="cas_number" FilterControlAltText="Filter cas_number column"
                                                         HeaderText="CAS NO." SortExpression="cas_number" UniqueName="cas_number">
                                </telerik:GridBoundColumn>

                                <telerik:GridBoundColumn DataField="iowanm" FilterControlAltText="Filter iowanm column"
                                                         HeaderText="ชื่อสาร" SortExpression="iowanm" UniqueName="iowanm">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="iowacd" FilterControlAltText="Filter iowacd column"
                                                         HeaderText="iowacd" SortExpression="iowacd" UniqueName="iowacd">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="runno" FilterControlAltText="Filter runno column"
                                                         HeaderText="runno" SortExpression="runno" UniqueName="runno">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="salt" FilterControlAltText="Filter salt column"
                                                         HeaderText="salt" SortExpression="salt" UniqueName="salt">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="syn" FilterControlAltText="Filter syn column"
                                                         HeaderText="syn" SortExpression="syn" UniqueName="syn">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="aori" FilterControlAltText="Filter aori column"
                                                         HeaderText="aori" SortExpression="aori" UniqueName="aori">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="REGIS_STATUS" FilterControlAltText="Filter REGIS_STATUS column"
                                                         HeaderText="REGIS_STATUS" SortExpression="REGIS_STATUS" UniqueName="REGIS_STATUS">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="INN" FilterControlAltText="Filter INN column"
                                                         HeaderText="INN" SortExpression="INN" UniqueName="INN">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="INN_TH" FilterControlAltText="Filter INN_TH column"
                                                         HeaderText="INN_TH" SortExpression="INN_TH" UniqueName="INN_TH">
                                </telerik:GridBoundColumn>
                            </Columns>
                        </MasterTableView>
                    </telerik:RadGrid>*@
                                </td>
                            </tr>
                        </table>
                    </div>
                    <br />


                    <div>
                        <h3>
                            รายละเอียดสาร
                        </h3>

                        <table class="table" style="width: 100%;">
                            <tr>
                                <td>ชื่อสาร</td>
                                <td>
                                    <input class="form-control inline" ng-model="LIST_CHEM.CHEMICAL_REQUEST.iowanm" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                                </td>
                            </tr>
                            <tr>
                                <td>CAS NO.</td>
                                <td>
                                    <input class="form-control inline" ng-model="LIST_CHEM.CHEMICAL_REQUEST.cas_number" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                                </td>
                            </tr>
                            <tr>
                                <td>INN</td>
                                <td>
                                    <input class="form-control inline" ng-model="LIST_CHEM.CHEMICAL_REQUEST.INN" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                                </td>
                            </tr>
                            <tr>
                                <td>INN TH</td>
                                <td>
                                    <input class="form-control inline" ng-model="LIST_CHEM.CHEMICAL_REQUEST.INN_TH" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                                </td>
                            </tr>
                            <tr>
                                <td>aori</td>
                                <td>
                                    @*<asp:DropDownList ID="ddl_aori" runat="server" CssClass="input-lg" Width="150px">
                                        <asp:ListItem Value="">กรุณาเลือก</asp:ListItem>
                                        <asp:ListItem Value="A">A</asp:ListItem>
                                        <asp:ListItem Value="I">I</asp:ListItem>
                                    </asp:DropDownList>*@

                                    <select class="dropdown" ng-model="LIST_CHEM.CHEMICAL_REQUEST.aori">
                                        <option value="A">A</option>
                                        <option Value="I">I</option>
                                    </select>
                                </td>
                            </tr>
                            <tr>
                                <td>iowacd</td>
                                <td>
        
                                    <input class="form-control inline" ng-model="LIST_CHEM.CHEMICAL_REQUEST.iowa" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                                </td>
                            </tr>
                            <tr>
                                <td>Run NO.</td>
                                <td>
                                    <input class="form-control inline" ng-model="LIST_CHEM.CHEMICAL_REQUEST.runno" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                                </td>
                            </tr>

                            <tr>
                                <td>salt</td>
                                <td>
                                    <input class="form-control inline" ng-model="LIST_CHEM.CHEMICAL_REQUEST.salt" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                                </td>
                            </tr>
                            <tr>
                                <td>syn</td>
                                <td>
                                    <input class="form-control inline" ng-model="LIST_CHEM.CHEMICAL_REQUEST.syn" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                                </td>
                            </tr>
                 
                            <tr>
                                <td>dv</td>
                                <td>
                                    <input class="form-control inline" ng-model="LIST_CHEM.CHEMICAL_REQUEST.add_digit" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                                </td>
                            </tr>
                            <tr>
                                <td>เป็นสารในทะเบียน</td>
                                <td>

                                    <select class="dropdown" ng-model="LIST_CHEM.CHEMICAL_REQUEST.REGIS_STATUS" >
                                        <option value="R">เป็นสารในทะเบียนผลิต</option>
                                        <option Value="N">ไม่เป็นสารในทะเบียนผลิต</option>
                                    </select>
                                </td>
                            </tr>
                            <tr>
                                <td>Look Type</td>
                                <td>

                                    <select class="dropdown" ng-model="LIST_CHEM.CHEMICAL_REQUEST.look_type">
                                        <option selected>Look</option>
                                        <option >No Look</option>
                                    </select>
                                </td>
                            </tr>

                            <tr>
                                <td>MODERN TRADITION</td>
                                <td>
                                    <select class="dropdown" ng-model="LIST_CHEM.CHEMICAL_REQUEST.MODERN_TRADITION">
                                        <option value="M">Modern Only</option>
                                        <option Value="H">Traditional Only</option>
                                        <option value="B">Both</option>
                                        <option value="T">TEMP</option>
                                    </select>
                                </td>
                            </tr>

                            <tr>
                                <td>มี ATC</td>
                                <td>
                                    <input type="checkbox" ng-model="LIST_CHEM.CHEMICAL_REQUEST.IS_ATC"/>
                                    &nbsp;(ถ้ามี)
                                    <input class="form-control inline" ng-model="LIST_CHEM.CHEMICAL_REQUEST.ATC_NAME" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                                </td>
                            </tr>



                        </table>
                        <table class="table" style="width: 100%;">
                            <tr>
                                <td>สารอยู่ในประกาศกระทรวงพาณิชย์ 16 รายการ</td>
                                <td>

                                    <asp:DropDownList ID="ddl_chem16" runat="server" CssClass="input-lg" Width="300px">
                                    </asp:DropDownList>

                                </td>
                                <td>
                                    <input type="button" value="เพิ่มข้อมูล" />
                                </td>
                            </tr>
                            <tr>
                                <td colspan="3">
                                    //ตารางสาร 16 รายการ
                                    @*<telerik:RadGrid ID="RadGrid3" runat="server" AllowPaging="true" PageSize="10">
                                        <MasterTableView AutoGenerateColumns="False" DataKeyNames="IDA">
                                            <Columns>
                                                <telerik:GridBoundColumn DataField="IDA" FilterControlAltText="Filter IDA column"
                                                                         HeaderText="IDA" SortExpression="IDA" UniqueName="IDA" Display="false">
                                                </telerik:GridBoundColumn>

                                                <telerik:GridBoundColumn DataField="CHEM_NAME" FilterControlAltText="Filter CHEM_NAME column"
                                                                         HeaderText="ชื่อสาร" SortExpression="CHEM_NAME" UniqueName="iowanm">
                                                </telerik:GridBoundColumn>
                                                <telerik:GridButtonColumn ButtonType="LinkButton" CommandName="del" UniqueName="del" Text="ลบ">
                                                </telerik:GridButtonColumn>
                                            </Columns>
                                        </MasterTableView>
                                    </telerik:RadGrid>*@
                                </td>
                            </tr>
                        </table>

                    </div>

                </div>
            </td>
            <td style="padding-left: 10%; height: 50%;" valign="top">

                <table class="table" style="width: 90%">

                    <tr>
                        <td>
                            <select class="dropdown" ng-model="LIST_CHEM.CHEMICAL_REQUEST.STATUS_ID">
                                <option value="8" selected>อนุมัติ</option>
                                <option value="7">ไม่อนุญาต</option>
                            </select>
                        </td>
                    </tr>

                    <tr>
                        <td>
                            วันที่
                            <md-datepicker ng-model="LIST_CHEM.CHEMICAL_REQUEST.STATUS_DATE" md-placeholder="Enter date"
                                           input-aria-describedby="datepicker-description"
                                           input-aria-labelledby="datepicker-header "></md-datepicker>
                        </td>
                    </tr>

                    <tr>
                        <td>
      
                            <input type="button" value="ยืนยัน" style="width:80%;" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <input type="button" value="กลับหน้ารายการ" style="width:80%;"  />
                        </td>
                    </tr>

                </table>



                <uc1:UC_GRID_ATTACH ID="UC_GRID_ATTACH1" runat="server" />

                <table class="table" style="width: 100%;">
                    <tr>
                        <td style="width: 40%;">Email</td>
                        <td>
                            <label>{{LIST_CHEM.CHEMICAL_REQUEST.EMAIL}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 40%;">เบอร์โทรศัพท์</td>
                        <td>
                            <label>{{LIST_CHEM.CHEMICAL_REQUEST.TEL}}</label>
                        </td>
                    </tr>
                </table>

            </td>
        </tr>
        <tr>
            <td style="width: 30%; height: 50%; padding-left: 10%">

                <br />

            </td>
        </tr>
    </table>
</div>
