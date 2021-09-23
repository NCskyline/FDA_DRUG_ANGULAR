<script src="../Scripts_angular/CENTER_SV.js"></script>
<script src="../Scripts_angular/LCN_CTRL.js"></script>
<div class="ic" ng-controller="LCN_CTRL" ng-app="ANGULAR_APP" ng-init="pageload_subtitute()" ng-cloak="">
    <div style="font-family:'Taviraj';font-size:20px;" class="ic">
        <div>
            <p style="text-align: right;">แบบ ผ.ย.๑๐</p>
        </div>
        <table style="width:100%">
            <tr>
                <td style="width:35%"></td>
                <td style="width:35%"></td>
                <td style="width:5%;text-align:right">เลขที่:</td>
                <td style=" width:25%;text-align:center"><label>{{LCN_LIST.RCVNO_DISPLAY}}</label></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:35%"></td>
                <td style="width:35%"></td>
                <td style="width:5%;text-align:right">วันที่:</td>
                <td style=" width:25%;text-align:center"><label>{{LCN_LIST.RCV_DATE_DISPLAY}}</label></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:35%"></td>
                <td style="width:35%"></td>
                <td style="width:5%;text-align:right"> ลงชื่อ:</td>
                <td style=" width:15%;text-align:center"></td>
                <td style="width:10%">ผู้รับคำขอ</td>
            </tr>
        </table>
        <br />
        <table style="width:100%">
            <tr>
                <td style="text-align:right;width:45%;"> <h2>คำขอ</h2></td>
                <td width="10%">
                    <table style="width:100%">
                        <tr>
                            <td>
                                <label>
                                    <input type="radio" ng-model="LIST_LCN.REQUEST_TYPE" value="1" disabled />ใบแทนใบอนุญาต
                                </label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <label>
                                    <input type="radio" ng-model="LIST_LCN.REQUEST_TYPE" value="2" disabled />ย้ายสถานที่
                                </label>
                            </td>
                        </tr>
                    </table>
                </td>
                <td style="text-align:left;"> <h2>ผลิตยาแผนปัจจุบัน</h2></td>
            </tr>
        </table>

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
        <br />
        <table style="width:100%">
            <tr>
                <td style="width:10%;text-align:right">ข้าพเข้า </td>
                <td style="width:90%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.thanm}}</label></td>

            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:10%;"></td>
                <td style="width:40%;text-align:right">(ชื่อผู้รับอนุญาต)</td>
                <td style="width:13%;"></td>
                <td style="width:42%;"></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:13%;">ซึ่งมีผู้ดำเนินกิจการชื่อ </td>
                <td style="width:67%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label></td>
                <td style="width:20%;text-align:right">ได้รับอนุญาตให้ผลิตยาแผยปัจจุบัน</td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:15%;">ตามใบอนุญาตที่</td>
                <td style="width:35%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.LCNNO_SHOW}}</label></td>
                <td style="width:15%;">ณ สถานที่นำหรือสั่งยาชื่อ</td>
                <td style="width:35%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.thanameplace}}</label></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:5%;">อยู่เลขที่</td>
                <td style="width:95%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.fulladdr3}}</label></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:18%;">โทรศัพท์/โทรศัพท์มือถือ</td>
                <td style="width:82%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.tel}}</label></td>
            </tr>
        </table>
        <br />
        <table width="100%">
            <tr>
                <td>
                    ขอ
                </td>
                <td>
                    <table width="100%">

                        <tr>
                            <td><input type="checkbox" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.REQUEST_TYPE" disabled />ใบแทนใบอนุญาตผลิตนาแผนปัจจุบันเนื่องจาก</td>
                        <tr>
                            <td>
                                <input type="text" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE" />
                            </td>
                        </tr>
                        <tr>
                            <td style="width:100%;text-align:center">(เหตุที่ขอรับใบแทน)</td>
                        </tr>
                        <tr>
                            <td><input type="checkbox" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.REQUEST_TYPE" disabled />ย้ายสถานที่ผลิตยาแผนปัจจุบัน</td>
                        <tr>
                            <td>
                                <select class="dropdown" style="font-family:'Taviraj'" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails_lct(LIST_LCN.LOCATION_SELECT)">
                                    <option value="0">--กรุณาเลือก--</option>
                                    <option ng-repeat="x in REF_LOCATION" value="{{x.IDA}}">{{x.thanameplace}}</option>
                                </select>
                            </td>
                        </tr>
                        <tr>
                            <td style="width:100%;text-align:center">(ชื่อสถานที่นำหรือสั่งยา)</td>
                        </tr>
                    </table>
                </td>
            </tr>

        </table>
        <br />
        <table width="100%">
            <tr>
                <td style="width:7%">ไปอยู่เลขที่</td>
                <td style="width:93%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LABEL_LCT.fulladdr}}</label></td>
            </tr>
        </table>
        <table width="100%">
            <tr>
                <td style="width:5%">โทรศัพท์</td>
                <td style="width:95%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LABEL_LCT.tel}}</label></td>
            </tr>
        </table>
        <table>
            <tr>
                <td>ข้าพเจ้าได้แนบหลักฐานมาด้วย คือ</td>
            <tr>
                <td>&nbsp;&nbsp;<input type="radio" value="1" ng-model="LIST_LCN.REQUEST_TYPE" disabled /> หลักฐานประกอบคำขอใบแทนใบอนุญาต</td>
            <tr>
                <td>&nbsp;&nbsp;&nbsp;&nbsp; (๑) รูปถ่ายของผู้ดำเนินกิจการ ขนาด ๓ x ๔ เซนติเมตร จำำนวน ๒ รูป</td>
            <tr>
                <td>&nbsp;&nbsp;&nbsp;&nbsp; (๒) ใบอนุญาตนำหรือสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักร ถ้ามี</td>
            <tr>
                <td>&nbsp;&nbsp;<input type="radio" value="1" ng-model="LIST_LCN.REQUEST_TYPE" disabled /> หลักฐานประกอบคำขอย้ายสถานที่</td>
            <tr>
                <td>&nbsp;&nbsp;&nbsp;&nbsp; (๑) ใบอนุญาตผลิตแผนปัจจุบันหรือใบแทน</td>
            <tr>
                <td>&nbsp;&nbsp;&nbsp;&nbsp; (๒) แบบแปลนแผนผังสิ่งปลูกสร้างของสถานที่ผลิตแห่งใหม่ จำำนวน ๒ ชุด</td>
            <tr>
                <td>&nbsp;&nbsp;&nbsp;&nbsp; (๓) เอกสารแสดงว่าเป็นผู้ได้รับอนุญาต</td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:50%;text-align:center"></td>
                <td style="width:10%;text-align:right">(ลายมือชื่อ)</td>
                <td style="width:20%;text-align:center"></td>
                <td style="width:20%;text-align:start">ผู้ยื่นคำขอ</td>
            </tr>
        </table>
        <hr />
        <div>หมายเหตุ : &nbsp;(๑) ในกรณีที่ใบอนุญาตสูญหาย ให้นำใบรับแจ้งความของสถานีตำรวจแห่งท้องที่ที่ใบอนุญาตอนุญาตนั้นสูญหายมาด้วย</div>
        <div>&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;(๒) ในกรณีที่ใบอนุญาตถูกทำลายในสาระสำคัญ ให้นับใบอนุญาตนั้น มาด้วย</div>
        <div>&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;(๓) ใส่เครื่องหมาย &#10004 ในช่อง[  ] หน้าข้อความที่ต้องการ</div>
        <div style="text-align:center">
            <input type="button" class="btn btn-lg" ng-click="BTN_BACK()" value="ย้อนกลับ" />
            <input type="button" class="btn btn-lg" ng-click="BTN_SAVE_STT()" value="บันทึก" />
        </div>
    </div>
</div>