
<script src="../Scripts_angular/CENTER_SV.js"></script>
<script src="../Scripts_angular/LCN_CTRL.js"></script>
<div class="ic" ng-controller="LCN_CTRL" ng-app="ANGULAR_APP" ng-init="pageload()" ng-cloak="">
    <div style="font-family:'Taviraj';font-size:20px;" class="ic">
        <div>
            <p style="text-align: right;">แบบ ย.บ.๑๔</p>
        </div>

        <div>
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
            @*<table style="width:100%">
                <tr>
                    <td style="width:20%"></td>
                    <td style="width:25%"><input type="checkbox" />&nbsp; ใบแทนใบอนุญาต</td>
                    <td style="width:20%"><input type="checkbox" />&nbsp; ผลิตยาแผนโบราณ</td>
                    <td style="width:35%; text-align:center"></td>
                </tr>
                <tr>
                    <td style="width:20%">คำขอ</td>
                    <td style="width:25%"></td>
                    <td style="width:20%"><input type="checkbox" />&nbsp; ขายยาแผนโบราณ</td>
                    <td style="width:35%; text-align:center"></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:20%"></td>
                    <td style="width:25%"><input type="checkbox" />&nbsp; ย้ายสถานที่</td>
                    <td style="width:55%"><input type="checkbox" />&nbsp; นำหรือสั่งยาแผนโบราณเข้ามาในราชอาณาจักร ในนามของ</td>
                </tr>
            </table>*@
            <table style="width:100%">
                <tr>
                    <td style="text-align:right;width:45%;"> <h2>คำขอ</h2></td>
                    <td width="10%">
                        <table style="width:100%">
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
                        <table style="width:100%">
                            <tr>
                                <td style="width:20%"><input type="radio" ng-model="LIST_LCN.LCN_TYPE" value="1" disabled />&nbsp; ผลิตยาแผนโบราณ</td>
                            </tr>
                            <tr>
                                <td style="width:20%"><input type="radio" ng-model="LIST_LCN.LCN_TYPE" value="2" disabled />&nbsp; ขายยาแผนโบราณ</td>
                            </tr>
                            <tr>
                                <td style="width:55%"><input type="radio" ng-model="LIST_LCN.LCN_TYPE" value="3" disabled />&nbsp; นำหรือสั่งยาแผนโบราณเข้ามาในราชอาณาจักร ในนามของ</td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>





            <hr style="width:20%; border-color:black;" />
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
                    <td style="width:10%; text-align:right">ข้าพเจ้า :</td>
                    <td style="width:80%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.thanm}}</label></td>
                    <td align="left" style="width:10%;">
                        ซึ่งผู้มีดำเนินกิจการ
                    </td>
                </tr>
                <tr>
                    <td style="width:10%;"></td>
                    <td style="width:90%; text-align:center" colspan="2">(ชื่อผู้ขออนุญาต)</td>
                </tr>
            </table>
            <br />
            <table style="width:100%">
                <tr>
                    <td style="width:10%;">ชื่อ</td>
                    <td style="width:60%; text-align:center;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label></td>
                    <td>
                        ได้รับอนุญาตให้
                    </td>
                    <td>
                        <input type="radio" ng-model="LIST_LCN.LCN_TYPE" value="1" disabled />&nbsp; ผลิตยาแผนโบราณ
                    </td>
                </tr>
                <tr>
                    <td style="width:10%"></td>
                    <td>
                        <input type="radio" ng-model="LIST_LCN.LCN_TYPE" value="1" disabled />&nbsp; ขายยาแผนโบราณ
                        <input type="radio" ng-model="LIST_LCN.LCN_TYPE" value="1" disabled />&nbsp; นำหรือสั่งยาแผนโบราณเข้ามาในราชอาณาจักร ตามใบอนุญาต
                    </td>
                    <td colspan="2"></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:5%">ที่</td>
                    <td style="width:35%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.LCNNO_SHOW}}</label></td>
                    <td style="width:15%">ณ สถานประกอบการ ชื่อ</td>
                    <td style="width:45%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.thanameplace}}</label></td>
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
            <table style="width:100%">
                <tr>
                    <td>
                        ขอ
                    </td>
                    <td>
                        <table>
                            <tr>
                                <td style="width:25%"><input type="checkbox" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.REQUEST_TYPE" disabled />&nbsp; ใบแทนใบอนุญาต</td>
                            </tr>

                        </table>
                    </td>
                    <td>
                        <table>
                            <tr>
                                <td style="width:20%"><input type="checkbox" ng-model="LIST_LCN.LCN_TYPE" value="1" disabled />&nbsp; ผลิตยาแผนโบราณ</td>
                            </tr>
                            <tr>
                                <td style="width:20%"><input type="checkbox" ng-model="LIST_LCN.LCN_TYPE" value="2" disabled />&nbsp; ขายยาแผนโบราณ</td>
                            </tr>
                            <tr>
                                <td style="width:55%"><input type="checkbox" ng-model="LIST_LCN.LCN_TYPE" value="3" disabled />&nbsp; นำหรือสั่งยาแผนโบราณเข้ามาในราชอาณาจักร เนื่องจาก</td>
                            </tr>
                            <tr>
                                <td>
                                    <input type="text" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE" />
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    (เหตุที่ขอรับใบแทน)
                                </td>
                            </tr>
                        </table>
                    </td>

                </tr>
                <tr>
                    <td></td>
                    <td>
                        <table>
                            <tr>
                                <td style="width:25%"><input type="checkbox" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.REQUEST_TYPE" disabled />&nbsp; ย้ายสถานที่</td>
                            </tr>
                        </table>
                    </td>
                    <td>
                        <table>
                            <tr>
                                <td style="width:20%"><input type="checkbox" ng-model="LIST_LCN.LCN_TYPE" value="1" disabled />&nbsp; ผลิตยาแผนโบราณ</td>
                            </tr>
                            <tr>
                                <td style="width:20%"><input type="checkbox" ng-model="LIST_LCN.LCN_TYPE" value="2" disabled />&nbsp; ขายยาแผนโบราณ</td>
                            </tr>
                            <tr>
                                <td style="width:55%"><input type="checkbox" ng-model="LIST_LCN.LCN_TYPE" value="3" disabled />&nbsp; นำหรือสั่งยาแผนโบราณเข้ามาในราชอาณาจักร เนื่องจาก</td>
                            </tr>
                            <tr>
                                <td>
                                    <select class="dropdown" style="font-family:'Taviraj'" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails_lct(LIST_LCN.LOCATION_SELECT)">
                                        <option value="0">--กรุณาเลือก--</option>
                                        <option ng-repeat="x in REF_LOCATION" value="{{x.IDA}}">{{x.thanameplace}}</option>
                                    </select>
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    (ชื่อสถานที่)
                                </td>
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
            <br style="padding-bottom:inherit" />
            <table style="width:100%">
                <tr>
                    <td style="width:5%"></td>
                    <td style="width:65%">ข้าพเจ้าได้แนบเอกสารมาด้วย คือ</td>
                    <td style="width:35%; text-align:center"></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:10%"></td>
                    <td style="width:65%"><input type="checkbox" value="1" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.REQUEST_TYPE" disabled />&nbsp; หลักฐานประกอบคำขอใบแทนใบอนุญาต</td>
                    <td style="width:35%; text-align:center"></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:15%"></td>
                    <td style="width:80%">(๑) รูปถ่ายของผู้ดำเนินกิจการ ขนาด ๓ x ๔ เซนติเมตร จำนวน 2 รูป</td>
                    <td style="width:5%; text-align:center"></td>
                </tr>
                <tr>
                    <td style="width:15%"></td>
                    <td style="width:80%">(๒) ใบอนุญาตประกอบธุรกิจเกี่ยวกับยาแผนโบราณ (ถ้ามี)</td>
                    <td style="width:5%; text-align:center"></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:10%"></td>
                    <td style="width:65%"><input type="checkbox" value="2" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.REQUEST_TYPE" disabled />&nbsp; หลักฐานประกอบคำขอย้ายสถานที่</td>
                    <td style="width:35%; text-align:center"></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:15%"></td>
                    <td style="width:80%">(๑) ใบอนุญาตประกอบธุรกิจเกี่ยวกับยาแผนโบราณ หรือใบแทน</td>
                    <td style="width:5%; text-align:center"></td>
                </tr>
                <tr>
                    <td style="width:15%;"></td>
                    <td style="width:80%;">(๒) แผนที่แสดงที่ตั้งสถานที่ผลิตยาและสถานที่เก็บยา รวมทั้งสิ่งปลูกสร้างที่อยู่ในบริเวณใกล้เคียงโดยรอบของสถานที่นั้น จำนวน ๒ ชุด</td>
                    <td style="width:5%; text-align:center"></td>
                </tr>
                <tr>
                    <td style="width:15%"></td>
                    <td style="width:80%">
                        (๓) แบบแปลนแผนผังสิ่งปลูกสร้างภายในบริเวณสถานที่ผลิตยาและสถานที่เก็บยาที่ถูกต้อง ตามมาตราส่วน โดยแสดงรายการ ดังต่อไปนี้<br />
                        &nbsp; &nbsp; &nbsp; (ก) รูปด้านหน้า ด้านข้าง แปลนพื้น และรูปตัดของอาคารที่ใช้ในการผลิตและเก็บยา<br />
                        &nbsp; &nbsp; &nbsp; (ข) การแบ่งกั้นห้อง เนื้อที่บริเวณที่ใช้ในการผลิตและควบคุมคุณภาพยา รวมทั้งสถานที่เก็บยาและวัสดุอื่นๆ
                    </td>
                    <td style="width:5%; text-align:center"></td>
                </tr>
                <tr>
                    <td style="width:15%"></td>
                    <td style="width:80%">(๔) รายการวัสดุที่ใช้ในการก่อสร้างส่วนต่างๆ ของอาคาร เช่น พื้น ผนัง และเพดาน</td>
                    <td style="width:5%; text-align:center"></td>
                </tr>
                <tr>
                    <td style="width:15%"></td>
                    <td style="width:80%">(๕) รายการเกี่ยวกับระบบการจัดการน้ำเสีย การกำจัดสิ่งปฏิกูลและมูลฝอย ระบบควบคุมอากาศ ระบบน้ำที่ใช้ในการผลิตยา และระบบรักษความปลอดภัย</td>
                    <td style="width:5%; text-align:center"></td>
                </tr>
                <tr>
                    <td style="width:15%"></td>
                    <td style="width:80%">(๖) เอกสารแสดงว่าเป็นผู้ได้รับอนุญาต</td>
                    <td style="width:5%; text-align:center"></td>
                </tr>
            </table>
            <br />
            <table style="width:100%">
                <tr>
                    <td style="width:50%; text-align:center"></td>
                    <td style="width:10%; text-align:right">(ลายมือชื่อ)</td>
                    <td style="width:20%; text-align:center"></td>
                    <td style="width:20%; text-align:start">ผู้ยื่นขอ</td>
                </tr>
            </table>
            <hr style="width:95%; border-color:black;" />
            <table style="width:100%">
                <tr>
                    <td style="width:5%"></td>
                    <td style="width:20%">หมายเหตุ : -</td>
                    <td style="width:70%">(๑)ในกรณีที่ใบอนุญาตสูญหายให้นำใบแจ้งความของสถานีตำรวจท้องที่ที่ใบอนุญาตนั้นสูญหายมาด้วย</td>
                    <td style="width:5%"></td>
                </tr>
                <tr>
                    <td style="width:5%"></td>
                    <td style="width:20%"></td>
                    <td style="width:70%">(๒)ในกรณีที่ใบอนุญาตถูกทำลายในสาระสำคัญ ให้แนบใบอนุญาตนั้นมาด้วย</td>
                    <td style="width:5%"></td>
                </tr>
                <tr>
                    <td style="width:5%"></td>
                    <td style="width:20%"></td>
                    <td style="width:70%">(๓)ใส่เครื่องหมาย &#10003; ในช่อง &nbsp;<input type="checkbox" />&nbsp; หน้าข้อความที่ต้องการ</td>
                    <td style="width:5%"></td>
                </tr>
            </table>
        </div>
        <div style="text-align:center">
            <input type="button" class="btn btn-lg" ng-click="BTN_BACK()" value="ย้อนกลับ" />
            <input type="button" class="btn btn-lg" ng-click="BTN_SAVE_STT()" value="บันทึก" />
        </div>
    </div>
</div>