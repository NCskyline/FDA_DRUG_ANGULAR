@Code
    ViewData("Title") = "PREVIEW_INPUT_LCN"
End Code
<script src="../Scripts_angular/ANGULAR_APP.js"></script>
<script src="../Scripts_angular/CENTER_SV.js"></script>
<script src="../Scripts_angular/LCN_CTRL.js"></script>
<div class="ic" ng-controller="LCN_CTRL" ng-app="ANGULAR_APP" ng-init="pageload()" ng-cloak=">
    @*----------ขย1---------*@
    <div ng-show="LIST_LCN.PROCESS == '101'">
        <div style="font-family:'Taviraj';font-size:24px;width:100%">
            <h1 style="text-align:right;font-size:24px;">
                <strong>แบบ ข.ย.๑</strong>
            </h1>
            <br />

            <div class="title1" style="font-size: 16px;margin-top: 25px">
                ที่ปิดรูปถ่าย<br />
                ผู้ขออนุญาติ<br />
                หรือ<br />
                ผู้ดำเนินกิจการ<br />
                ขนาด ๓ x ๔ ซม.<br />

            </div>

            <div class="title2">
                <table style="font-size:20px;width:95%;margin-top:10px;margin-left:10px">
                    <tr>
                        <td style="text-align:left;width:20%">
                            เลขรับที่
                        </td>

                        <td colspan="3">
                            {{LCN_LIST.RCVNO_DISPLAY}}
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:left">
                            วันที่
                        </td>

                        <td colspan="3">
                            {{LCN_LIST.RCV_DATE_DISPLAY}}
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:left">
                            ลงชื่่อ

                        </td>

                        <td></td>
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
                <hr style=" border-top:2px dotted ;width:17%" />
            </div>

            <table style="width:100%">
                <tr>
                    <td style="text-align:right;width:90%">
                        เขียนที่
                    </td>
                    <td style="width:40%">
                        @*<input class="form-control inline" ng-model="LIST_LCN.dalcn.WRITE_AT" style="font-family:'Taviraj';" type="text" />*@
                        {{LIST_LCN.dalcn.WRITE_AT}}
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right;width:100px">
                        วันที่
                    </td>
                    <td>

                        @*<md-datepicker ng-model="LIST_LCN.dalcn.WRITE_DATE" md-placeholder="Enter date"
                                           input-aria-describedby="datepicker-description"
                                           input-aria-labelledby="datepicker-header ">
                            </md-datepicker>*@
                        {{LIST_LCN.dalcn.WRITE_DATE}}
                    </td>
                </tr>

            </table>
            <br />
            <table style="width:100%;">
                <tr>
                    <td width="5%">
                        ข้าพเจ้า
                    </td>
                    <td style="text-align:center;">
                        {{LIST_LCN.thanm}}
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
                    <td style="text-align:left;width:2000px">
                        {{LIST_LCN.BSN_THAIFULLNAME}}
                    </td>
                    <td colspan="4">
                        (เฉพาะกรณีนิติบุคคล)
                    </td>
                </tr>
                <tr>
                    <td style="width:20%;">
                        เลขบัญประจำตัวประชาชน
                    </td>
                    <td style="text-align:left;width:30%;">
                        <form action="javascript:void(0)">
                            <table>
                                <tr>
                                    <td>
                                        @*<input class="form-control inline" ng-model="LIST_LCN.BSN_IDENTIFY" id="txt_bsn_identify" style="font-family:'Taviraj';" type="text" />*@
                                        {{LIST_LCN.BSN_IDENTIFY}}
                                    </td>
                                    @*<td>
                                            <input type="button" value="ค้นหาผู้ดำเนินฯ" ng-click="BTN_Search_BSN(LIST_LCN.BSN_IDENTIFY)" />
                                        </td>*@
                                </tr>
                            </table>


                        </form>
                    </td>
                    <td>
                        อายุ
                    </td>
                    <td style="text-align: left; width: 20%;" align="center">
                        {{LIST_LCN.AGE}}
                    </td>
                    <td>
                        ปี
                    </td>
                    <td>
                        สัญชาติ
                    </td>
                    <td style="text-align:left;width:10%;">
                        @*<input class="form-control inline" ng-model="LIST_LCN.dalcn.NATION" style="font-family:'Taviraj';" type="text" />*@
                        {{LIST_LCN.dalcn.NATION}}
                    </td>

                </tr>
            </table>

            <table style="font-size:20px;width:100%">
                <tr>
                    <td style="width:200px">
                        อยู่เลขที่
                    </td>
                    <td style="text-align:left" colspan="3">
                        {{LIST_LCN.BSN_FULL_ADDR}}
                    </td>

                </tr>
                <tr>
                    <td>
                        โทรศัพท์
                    </td>
                    <td style="text-align:left">
                        {{LIST_LCN.BSN_TELEPHONE}}
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์มือถือ
                    </td>
                    <td style="text-align:left">
                        {{LIST_LCN.BSN_FAX}}
                    </td>
                </tr>
                <tr>
                    <td>
                        E-mail
                    </td>
                    <td>
                        @*<input class="form-control inline" ng-model="LIST_LCN.dalcn.Email" style="font-family:'Taviraj';" type="text" />*@
                        {{LIST_LCN.dalcn.Email}}
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
                    <td style="text-align:left">
                        {{LIST_LCN.thanameplace}}
                    </td>
                </tr>
                <tr>
                    <td>
                        อยู่เลขที่
                    </td>
                    <td>
                        {{LIST_LCN.fulladdr3}}
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์
                    </td>
                    <td>
                        {{LIST_LCN.tel}}
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์มือถือ
                    </td>
                    <td>
                        {{LIST_LCN.fax}}
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


                            <input type="radio" ng-model="LIST_LCN.dalcn.CHK_SELL_TYPE" id="Rdl_gmpt" value="1" disabled> ขายปลีก<br />
                            <input type="radio" ng-model="LIST_LCN.dalcn.CHK_SELL_TYPE" id="Rdl_gmpt" value="2" disabled> ขายส่ง<br />
                            <input type="radio" ng-model="LIST_LCN.dalcn.CHK_SELL_TYPE" id="Rdl_gmpt" value="3" disabled> ปรุงยาสำหรับผู้ป่วยเฉพาะราย(เฉพาะขายปลีกเท่านั้น)

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

            <div class="row">
                <div class="col-sm-12">
                    <div class="card" style=" border-top: 10px solid #277210;">
                        <table width="100%" style="font-family:'Taviraj'">
                            <thead>
                                <tr>
                                    <td>ชื่อสถานที่เก็บ</td>
                                    <td>อยู่เลขที่</td>
                                </tr>
                            </thead>
                            <tbody>
                                <tr ng-repeat="data in DATA_KEEP_SHOW">
                                    <td>{{datas.thanameplace}}</td>
                                    <td>{{datas.fulladdr}}</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
            <br />

            <h3>เภสัชกร</h3>
            <div class="row">
                <div class="col-sm-12">
                    <div class="card" style=" border-top: 10px solid #277210;">
                        <table width="100%" style="font-family:'Taviraj'">
                            <thead>
                                <tr>
                                    <td>เภสัชกรชั้น</td>
                                    <td>ชื่อ-นามสกุล</td>
                                    <td>เลขบัตรประจำตัวประชาชน</td>
                                    <td>ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่</td>

                                </tr>
                            </thead>
                            <tbody>
                                <tr ng-repeat="data in DATA_PHR_SHOW">
                                    <td>{{data.PHR_LEVEL}}</td>
                                    <td>{{data.PHR_NAME}}</td>
                                    <td>{{data.PHR_CTZNO}}</td>
                                    <td>{{data.PHR_TEXT_NUM}}</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>


            <br />
            <input type="button" style="font-size:20px;width:100px" value="เพิ่ม" />
            <input type="button" style="font-size:20px;width:100px;margin-left:10px" value="ลบ" />
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
                        <input class="form-control inline" ng-model="LIST_LCN.DALCN_PHR.PHR_TEXT_WORK_TIME" style="font-size:20px;" type="text" />
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
            <div style="margin-left:10%;font-size:20px">(๑) รูปถ่ายของผู้ขออนุญาต ขนาด ๓ x ๔ เซนติเมตร จำนวน ๓ รูป</div>
            <div style="margin-left:10%;font-size:20px">(๒) เอกสารแสดงการเป็นเจ้าของกิจการและหลักทรัพย์</div>
            <div style="margin-left:10%;font-size:20px">(๓) สำเนาทะเบียนบ้านของผู้ขออนุญาต (กรณีบุคคลธรรมดาเป็นผู้ขออนุญาต) หรือ ผู้ดำเนินกิจการ (กรณีนิติบุคคลเป็นผู้ขออนุญาต)</div>
            <div style="margin-left:10%;font-size:20px">(๔) ใบรับรองของผู้ประกอบวิชาชีพเวชกรรมซึ่งรับรองว่าผู้ขออนุญาตไม่เป็นโรคตามมาตรา ๑๔ (๖) แห่งพระราชบัญญัติยา พ.ศ. ๒๕๑๐</div>
            <div style="margin-left:10%;font-size:20px">(๕) สัญญาระหว่างผู้ขออนุญาตและเภสัชกร ซึ่งรับจะเป็นผู้มีหน้าที่ปฏิบัติการของผู้ขออนุญาต</div>
            <div style="margin-left:10%;font-size:20px">(๖) สำเนาหรือรูปถ่ายใบอนุญาตประกอบวิชาชีพเภสัชกรรมของเภสัชกรทุกคน ซึ่งรับจะเป็นผู้มีหน้าที่ปฏิบัติการของผู้ขออนุญาต</div>
            <div style="margin-left:10%;font-size:20px">(๗) เอกสารแสดงว่าเป็นผู้ดำเนินกิจการ (กรณีนิติบุคคลเป็นผู้ขออนุญาต)</div>
            <br />
            <br />
            <br />
            <table style="font-size:20px;width:40%;float:right">
                <tr>
                    <td>
                        (ลายมือชื่อ)
                    </td>
                    <td style="width:50%;text-align:center"></td>
                    <td style="text-align:left">
                        ผู้ขออนุญาต
                    </td>
                </tr>
                <tr>
                    <td>
                        (
                    </td>
                    <td style="width:50%;text-align:center">
                        {{LIST_LCN.BSN_THAIFULLNAME}}
                    </td>
                    <td style="text-align:left">
                        ตัวบรรจง)
                    </td>
                </tr>
            </table>
        </div>
    </div>
    @*--------------------------*@




</div>
