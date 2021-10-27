﻿@Code
    ViewData("Title") = "FRM_LCN_EDIT_RETURN"
End Code

    <script src="~/Scripts_angular/ANGULAR_APP.js"></script>
    <script src="~/Scripts_angular/CENTER_SV.js"></script>
    <script src="~/Scripts_angular/LCN_CTRL.js"></script>

<div ng-app="ANGULAR_APP" ng-controller="LCN_CTRL">
    <div class="ic" >
        <div ng-show="LIST_LCN.dalcn.P">
            <div style="font-family:'Taviraj';font-size:24px;width:100%">
                <h1 style="text-align:right;font-size:24px;">
                    <strong>แบบ ข.ย.๑</strong>
                </h1>
                <br />

                <div class="title1">
                    <label style="font-size: 16px;margin-top: 25px">
                        ที่ปิดรูปถ่าย<br />
                        ผู้ขออนุญาติ<br />
                        หรือ<br />
                        ผู้ดำเนินกิจการ<br />
                        ขนาด ๓ x ๔ ซม.<br />
                    </label>
                </div>

                <div class="title2">
                    <table style="font-size:20px;width:95%;margin-top:10px;margin-left:10px">
                        <tr>
                            <td style="text-align:left;width:20%">
                                เลขรับที่
                            </td>

                            <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                                <label>{{LCN_LIST.RCVNO_DISPLAY}}</label>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align:left">
                                วันที่
                            </td>

                            <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                                <label>{{LCN_LIST.RCV_DATE_DISPLAY}}</label>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align:left">
                                ลงชื่่อ

                            </td>

                            <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                            <td style="text-align:right;width:25%">
                                ผู้รับคำขอ
                            </td>
                        </tr>
                    </table>
                </div>
                <div style="clear:both"></div>
                <br />
                <br />

                <h1 style="text-align:center;">
                    <strong>คำขออนุญาตขายยาแผนปัจจุบัน</strong>
                </h1>
                @*process =101 *@


                <div style="text-align:center">
                    <hr style="border-top:2px dotted ;width:17%" />
                </div>

                <table style="width:100%">
                    <tr>
                        <td style="text-align:right;width:90%">
                            เขียนที่
                        </td>
                        <td style="width:40%">
                            <input class="form-control inline" ng-model="LIST_LCN.dalcn.WRITE_AT" style="font-family:'Taviraj';" type="text" />
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:right;width:100px">
                            วันที่
                        </td>
                        <td>

                            <md-datepicker ng-model="LIST_LCN.dalcn.WRITE_DATE" md-placeholder="Enter date"
                                           input-aria-describedby="datepicker-description"
                                           input-aria-labelledby="datepicker-header ">
                            </md-datepicker>
                        </td>
                    </tr>
                </table>
                <br />
                <table style="width:100%;">
                    <tr>
                        <td width="5%">
                            ข้าพเจ้า
                        </td>
                        <td style="text-align:center;border-bottom:dotted;border-bottom-width:thin;">
                            <label>{{LIST_LCN.thanm}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td style="text-align:center;">
                            (ชื่อผู้ขออนุญาต)
                        </td>
                    </tr>
                </table>

                <br />

                <table style=" font-size:20px;width:100%" ;>
                    <tr>
                        <td>
                            ซึ่งมีผู้ดำเนินกิจการ ชื่อ
                        </td>
                        <td style="text-align:left;width:2000px;border-bottom:dotted;border-bottom-width:thin;">
                            <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                        </td>
                        <td colspan="4">
                            (เฉพาะกรณีนิติบุคคล)
                        </td>
                    </tr>
                    <tr>
                        <td style="width:20%;">
                            เลขบัตรประจำตัวประชาชน
                        </td>
                        <td style="text-align:left;width:30%;">
                            <form action="javascript:void(0)">
                                <table>
                                    <tr>
                                        <td>
                                            <input class="form-control inline" ng-model="LIST_LCN.BSN_IDENTIFY" id="txt_bsn_identify" style="font-family:'Taviraj';" type="text" />
                                        </td>
                                        <td>
                                            <input type="button" value="ค้นหาผู้ดำเนินฯ" ng-click="BTN_Search_BSN(LIST_LCN.BSN_IDENTIFY)" />
                                        </td>
                                    </tr>
                                </table>


                            </form>
                        </td>
                        <td>
                            อายุ
                        </td>
                        <td style="text-align: left; width: 20%;border-bottom:dotted;border-bottom-width:thin;" align="center">
                            <label>{{LIST_LCN.AGE}}</label>
                        </td>
                        <td>
                            ปี
                        </td>
                        <td>
                            สัญชาติ
                        </td>
                        <td style="text-align:left;width:10%;border-bottom:dotted;border-bottom-width:thin;">
                            @*<input class="form-control inline" ng-model="LIST_LCN.dalcn.NATION" style="font-family:'Taviraj';" type="text" />*@
                        </td>

                    </tr>
                </table>

                <table style="font-size:20px;width:100%">
                    <tr>
                        <td style="width:200px">
                            อยู่เลขที่
                        </td>
                        <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;" colspan="3">
                            <label>{{LIST_LCN.BSN_FULL_ADDR}}</label>
                        </td>

                    </tr>
                    <tr>
                        <td>
                            โทรศัพท์
                        </td>
                        <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                            <label>{{LIST_LCN.BSN_TELEPHONE}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            โทรศัพท์มือถือ
                        </td>
                        <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                            <label>{{LIST_LCN.BSN_FAX}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            E-mail
                        </td>
                        <td>
                            <input class="form-control inline" ng-model="LIST_LCN.dalcn.Email" style="font-family:'Taviraj';border-bottom:dotted;border-bottom-width:thin;" type="text" />
                        </td>
                    </tr>
                </table>
                <br />
                <br />
                <h3>
                    ขอรับใบอนุญาตขายยาแผนปัจจุบันโดยมีสถานที่ขายยาชื่อ
                </h3>
                <table style=" font-size:20px;width:100%" ;>
                    <tr style="text-align:center">
                        <td style="width:10%"></td>
                        <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                            <label>{{LIST_LCN.thanameplace}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            อยู่เลขที่
                        </td>
                        <td style="border-bottom:dotted;border-bottom-width:thin;">
                            <label>{{LIST_LCN.fulladdr3}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            โทรศัพท์
                        </td>
                        <td style="border-bottom:dotted;border-bottom-width:thin;">
                            <label>{{LIST_LCN.tel}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            โทรศัพท์มือถือ
                        </td>
                        <td style="border-bottom:dotted;border-bottom-width:thin;">
                            <label>{{LIST_LCN.fax}}</label>
                        </td>
                    </tr>
                </table>
                <br />
                <br />

                <div style=" font-size:20px;margin-left:10%"> ลักษณะการประกอบการ (๑)</div>

                <table style=" font-size:20px;width:100%;margin-left:10%">

                    <tr>
                        <td>
                            <form name="rdl_gmp">


                                <label><input type="radio" ng-model="LIST_LCN.dalcn.CHK_SELL_TYPE" id="Rdl_gmpt" value="1"> ขายปลีก</label><br />
                                <label><input type="radio" ng-model="LIST_LCN.dalcn.CHK_SELL_TYPE" id="Rdl_gmpt" value="2"> ขายส่ง</label><br />
                                <label><input type="radio" ng-model="LIST_LCN.dalcn.CHK_SELL_TYPE" id="Rdl_gmpt" value="3"> ปรุงยาสำหรับผู้ป่วยเฉพาะราย(เฉพาะขายปลีกเท่านั้น)</label>

                            </form>
                        </td>

                    </tr>
                </table>
                <br />
                <br />
                <hr class="hr" />
                <br />
                <div style=" font-size:20px;margin-left:5%">๑) ให้ตอบมากกว่า ๑ ข้อ ในกรณีมีลักษณะการประกอบการมากกว่าหนึ่งลักษณะโดยการตอบจะมีผลต่อการประเมินความพร้อมของสถานที่ </div>
                <div style=" font-size:20px">อุปกรณ์ และการดำเนินการตามหลักวิธีปฏิบัติทางเภสัชกรรมชุมชน เพื่อประกอบการอนุญาต</div>
                <br />

                <table style="width:50%">
                    <tr>
                        <td>
                            ชื่อสถานที่เก็บ ( 1 ) :
                        </td>
                        <td>
                            <select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails(LIST_LCN.LOCATION_SELECT)">
                                @*<option value="">--กรุณาเลือก--</option>*@
                                <option ng-repeat="x in REF_LOCATION_KEEP" value="{{x.IDA}}">{{x.thanameplace}}</option>
                            </select>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            อยู่เลขที่
                        </td>
                        <td style="border-bottom:dotted;border-bottom-width:thin;">
                            <label>{{LIST_LABEL.fulladdr}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            โทรศัพท์
                        </td>
                        <td style="border-bottom:dotted;border-bottom-width:thin;">
                            <label>{{LIST_LABEL.tel}}</label>
                        </td>
                    </tr>
                    <tr style="font-size: 20px">
                        <td>
                            โทรศัพท์มือถือ
                        </td>
                        <td style="border-bottom:dotted;border-bottom-width:thin;">
                            <label>{{LIST_LABEL.Mobile}}</label>
                        </td>
                    </tr>
                </table>


                <br />
                <input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_KEEP(LIST_LABEL,LIST_LCN.LOCATION_SELECT)" />
                <div>
                    <table class="table" style="width:100%;">
                        <thead>
                            <tr>
                                <th hidden>IDA</th>
                                <th>ลำดับ</th>
                                <th>ชื่อสถานที่เก็บ</th>
                                <th>ที่อยู่</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr ng-repeat="datas in COLLECT_KEEP">
                                <td hidden>{{datas.LOCATION_IDA}}</td>
                                <td>{{$index + 1}}</td>
                                <td>{{datas.thanameplace}}</td>
                                <td>{{datas.fulladdr}}</td>
                                <td>
                                    <span class="fas fa-edit"></span>
                                    <a ng-click="deleteKEEP(datas,$index)">
                                        ลบที่เก็บ
                                    </a>
                                </td>
                            </tr>
                        </tbody>
                        <tfoot>
                            <tr></tr>
                        </tfoot>
                    </table>
                </div>
            </div>
            <br />
            <br />
            <table style="font-size:20px;width:100%">
                <tr>
                    <td style="width:20%">
                        โดยมีเภสัชกรชั้น
                    </td>
                    <td>
                        <input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_LEVEL" style="font-family:'Taviraj';font-size:20px;" type="text" />
                    </td>
                    <td style="text-align:center">
                        ชื่อ
                    </td>
                    <td style="width:10%">
                        <select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_PHR_ADD.PHR_PREFIX_ID">
                            @*<option value="0">--กรุณาเลือก--</option>*@
                            <option ng-repeat="x in PREFIX" value="{{x.prefixcd}}">{{x.thanm}}</option>
                        </select>
                    </td>
                    <td>
                        <input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />
                    </td>
                </tr>
                <tr>
                    <td style="width:20%">
                        เลขบัตรประจำตัวประชาชน
                    </td>
                    <td colspan="4">
                        <input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_CTZNO" style="font-family:'Taviraj';font-size:20px;" type="text" />
                    </td>
                </tr>
                <tr>
                    <td>
                        ใบอนุญาตประกอบวิชาชีพ
                    </td>
                    <td colspan="4"></td>
                </tr>
                <tr>
                    <td>
                        เภสัชกรรมเลขที่
                    </td>
                    <td>
                        <input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_TEXT_NUM" style="font-family:'Taviraj';font-size:20px;" type="text" />
                    </td>
                </tr>
            </table>
            <br />
            <input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_PHR(LIST_PHR_ADD)" />
            <div>
                <table class="table" width="100%">
                    <thead>
                        <tr>
                            <th>ลำดับ</th>
                            <th>เภสัชกรชั้น</th>
                            <th>ชื่อ-นามสกุล</th>
                            <th>เลขบัตรประจำตัวประชาชน</th>
                            <th>ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr ng-repeat="datas in COLLECT_PHR">
                            <td>{{$index + 1}}</td>
                            <td>{{datas.PHR_LEVEL}}</td>
                            <td>{{datas.PHR_NAME}}</td>
                            <td>{{datas.PHR_CTZNO}}</td>
                            <td>{{datas.PHR_TEXT_NUM}}</td>
                            <td>
                                <span class="fas fa-edit"></span>
                                <a ng-click="deletePHR(datas,$index)">
                                    ลบข้อมูล
                                </a>
                            </td>
                        </tr>
                    </tbody>
                    <tfoot>
                        <tr></tr>
                    </tfoot>
                </table>
            </div>

            <hr />

            <table style="width:100%">
                <tr>
                    <td style="text-align:center" colspan="2">
                        <strong>(ถ้ามีมากกว่าหนึ่งคนให้แจ้งเพิ่มเติมท้ายคำขอนี้จน)</strong>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        เป็นผู้มีหน้าที่ปฏิบัติการตามมาตรา ๓๙ หรือมาตรา ๔๐ แห่งรพระราชบัญญัติยา พ.ศ. ๒๕๑๐
                    </td>
                </tr>
                <tr>
                    <td style="width:30%">
                        <strong>เวลาทำการ (เวลาปฏิบัติการ ของผู้มีหน้าที่ปฏิบัติการ)</strong>
                    </td>
                    <td>
                        <input class="form-control inline" ng-model="LIST_LCN.dalcn.opentime" style="font-size:20px;" type="text" />
                    </td>
                </tr>
            </table>
            <br />

            <div>
                ข้าพเจ้าขอรับรองว่าในระยะเวลาสองปีก่อนยื่นคำขอนี้ ข้าพเจ้าไม่เคยได้รับโทษจำคุกโดยคำพิพากษาถึงที่สุดหรือคำสั่งที่ชอบด้วยกฎหมายให้จำคุกในความผิดที่
                กฎหมายบัญญัติ ให้ถือเอาการกระทำโดยทุจริตเป็นองค์ประกอบหรือในความผิดตามกฎหมายว่าด้วยยาเสพติดให้โทษ กฎหมายว่าด้วยวัตถุที่ออกฤทธิ์ต่อจิตและ
                ประสาท กฎหมายว่าด้วยการขายยาหรือพระราชบัญญัตินี้
                ข้าพเจ้าได้แนบหลักฐานมาด้วย คือ
            </div>
            <br />
        </div>
    </div>
</div>