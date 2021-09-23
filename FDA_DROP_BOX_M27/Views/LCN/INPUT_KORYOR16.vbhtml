@Code
    ViewData("Title") = "INPUT_KORYOR16"
End Code
<div ng-controller="LCN_CTRL" ng-app="ANGULAR_APP" class="ic">
    <div class="content-part " style="width:100%;font-family:'Taviraj'">
        <div style="font-family:'Taviraj';font-size:20px;">
            <div>
       
                <h1>
                    <center>
                        แบบ ข.ย.๑๖
                    </center>

                </h1>
            </div>
            <table style="width:100%">
                <tr>
                    <td style="width:35%"></td>
                    <td style="width:35%"></td>
                    <td style="width:5%;text-align:right">เลขที่</td>
                    <td style=" width:25%;text-align:center"><label>{{LCN_LIST.RCVNO_DISPLAY}}</label></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:35%"></td>
                    <td style="width:35%"></td>
                    <td style="width:5%;text-align:right">วันที่</td>
                    <td style=" width:25%;text-align:center"> <label>{{LCN_LIST.RCV_DATE_DISPLAY}}</label></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:35%"></td>
                    <td style="width:35%"></td>
                    <td style="width:5%;text-align:right"> ลงชื่อ</td>
                    <td style=" width:15%;text-align:center"></td>
                    <td style="width:10%">ผู้รับคำขอ</td>
                </tr>
            </table>
            <div>
                <p style="text-align:center">

                    <table width="100%">
                        <tr>
                            <td style="width:30%"></td>
                            <td>
                                คำขอ
                            </td>
                            <td>
                                <table>
                                    <tr>
                                        <td>
                                            <label>
                                                <input type="radio" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.REQUEST_TYPE" value="1" disabled />ใบแทนใบอนุญาต
                                            </label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <label>
                                                <input type="radio" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.REQUEST_TYPE" value="2" disabled />ย้ายสถานที่
                                            </label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td>
                                <table>
                                    <tr>
                                        <td>
                                            <input type="radio" ng-model="LIST_LCN.LCN_TYPE" value="1" disabled />ขายยาแผนปัจจุบัน
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <input type="radio" ng-model="LIST_LCN.LCN_TYPE" value="2" disabled />ขายส่งยาแผนปัจจุบัน
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <input type="radio" ng-model="LIST_LCN.LCN_TYPE" value="3" disabled />ขายยาแผนปัจจุบันเฉพาะยาบรรจุเสร็จที่ไม่ใช่ยาอันตรายหรือยาควบคุมพิเศษ
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <input type="radio" ng-model="LIST_LCN.LCN_TYPE" value="4" disabled />ขายยาแผนปัจจุบันเฉพาะยาบรรจุเสร็จสำหรับสัตว์
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>

                    </table>

            </div>
            <hr />
            <table style="width:100%">
                <tr>
                    <td style="text-align:right;width:90%">
                        เขียนที่
                    </td>
                    <td style="width:40%">
                        <input class="form-control inline" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.WRITE_AT" style="font-family:'Taviraj';" type="text" />
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right;width:100px">
                        วันที่
                    </td>
                    <td>

                        <md-datepicker ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.WRITE_DATE" md-placeholder="Enter date"
                                       input-aria-describedby="datepicker-description"
                                       input-aria-labelledby="datepicker-header ">
                        </md-datepicker>
                    </td>
                </tr>

            </table>
            <table style="width:100%;">
                <tr>
                    <td style="padding-left:10%;"></td>
                    <td width="5%">
                        ข้าพเจ้า
                    </td>
                    <td style="width:90%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.thanm}}</label></td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td style="text-align:center;">
                        (ชื่อผู้ขออนุญาต)
                    </td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:13%;">มีผู้ดำเนินกิจการ ชื่อ</td>
                    <td style="width:74%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label></td>
                    <td style="width:13%;">(เฉพาะกรณีนิติบุคคล)</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:13%;">เลขที่บัตรประชาชน</td>
                    <td style="width:50%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.BSN_IDENTIFY}}</label></td>
                    <td style="width:13%;">ได้รับอนุญาตให้ขายยา</td>
                    <td style="width:24%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:13%;">ใบอนุญาตเลขที่</td>
                    <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.LCNNO_SHOW}}</label></td>
                    <td style="width:12%;">ณ สถานที่ขายยาชื่อ</td>
                    <td style="width:55%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.thanameplace}}</label></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:10%;">ตั้งอยู่เลขที่</td>
                    <td style="width:90%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.fulladdr3}}</label></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:13%;">โทรศัพท์/โทรศัพท์มือถือ</td>
                    <td style="width:87%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.tel}}</label></td>
                </tr>
            </table>
            <div>มีความประสงค์ขอ</div>
            <table style="width:100%;">
                <tr>
                    <td width="17%"><input type="checkbox" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.REQUEST_TYPE" disabled />ใบแทนใบอนุญาตขายยา  เนื่องจาก</td>
                    <td width="68%">
                        <input type="text" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE" />
                    </td>
                    <td width="15%">
                        (ระบุเหตุที่ขอรับใบแทน)
                    </td>
                </tr>
            </table>
            <table>
                <tr>
                    <td><input type="checkbox" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.REQUEST_TYPE" disabled />ย้ายสถานที่ขายยาชื่อ</td>
                    <td>
                        <select class="dropdown" style="font-family:'Taviraj'" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails_lct(LIST_LCN.LOCATION_SELECT)">
                            <option value="0">--กรุณาเลือก--</option>
                            <option ng-repeat="x in REF_LOCATION" value="{{x.IDA}}">{{x.thanameplace}}</option>
                        </select>
                    </td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:5%">ไปอยู่ที่</td>
                    <td style="width:95%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LABEL_LCT.fulladdr}}</label></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:13%">โทรศัพท์/โทรศัพท์มือถือ</td>
                    <td style="width:87%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LABEL_LCT.tel}}</label></td>
                </tr>
            </table>
            <div>ข้าพเจ้าได้แนบหลักฐานมาด้วย คือ</div>
            <br />
            <table style="width:100%" border="1">
                <tr>
                    <td style="width:50%"><input type="radio" value="1" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.REQUEST_TYPE" disabled /> หลักฐานประกอบคำขอใบแทนใบอนุญาต</td>
                    <td style="width:50%"><input type="radio" value="2" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.REQUEST_TYPE" disabled /> หลักฐานประกอบคำขอย้ายสถานที่</td>
                </tr>
            </table>
            <table style="width:100%" border="1">
                <tr>
                    <td style="width:50%">(๑) รูปถ่ายของผู้ขออนุญาต หรือผู้แทนหรือผู้จัดการนิติบุคคล ขนาด ๓ x ๔ เซนติเมตร จำนวน ๓ รูป </td>
                    <td style="width:50%">(๑) ใบอนุญาตประกอบธุรกิจเกี่ยวกับยาแผนปัจจุบันหรือใบแทน </td>
                </tr>
            </table>
            <table style="width:100%" border="1">
                <tr>
                    <td style="width:50%">(๒) ใบอนุญาตประกอบธุรกิจเกี่ยวกับยาแผนปัจจุบัน (ถ้ามี)</td>
                    <td style="width:50%">(๒) แบบแปลนแผนผังสิ่งปลูกส้รางของสถานที่ขายยาแห่งใหม่</td>
                </tr>
            </table>
            <table style="width:100%" border="1">
                <tr>
                    <td style="width:50%">(๓) ใบรับแจ้งความของสถานีตำรวจแห่งท้องที่ที่ใบอนุญาตนั้นสูญหายมาด้วย</td>
                    <td style="width:50%">(๓) เอกสารอื่นถ้าจำเป็น</td>
                </tr>
            </table>
            <table style="width:100%" border="1">
                <tr>
                    <td style="width:50%">(๔) ใบอนุญาตใบเดิม (กรณีที่ใบอนุญาตถูกทำำลายในสาระสำคัญ)</td>
                    <td style="width:50%"></td>
                </tr>
            </table>
            <br />
            <table style="width:100%">
                <tr>
                    <td style="width:50%;text-align:center"></td>
                    <td style="width:10%;text-align:right">(ลายมือชื่อ)</td>
                    <td style="width:20%;text-align:center"></td>
                    <td style="width:20%;text-align:start">ผู้รับอนุญาต</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:50%;text-align:center"></td>
                    <td style="width:10%;text-align:right">(</td>
                    <td style="width:20%;text-align:center"></td>
                    <td style="width:20%;text-align:start">) (ตัวบรรจง)</td>
                </tr>
            </table>
            <hr />
            <div>หมายเหตุ : &nbsp;(๑) ใส่เครื่องหมาย &#10004; ในช่อง [  ] หน้าข้อความที่ต้องการ</div>
        </div>
    </div>
</div>