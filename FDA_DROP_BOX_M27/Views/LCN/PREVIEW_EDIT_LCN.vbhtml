@Code
    ViewData("Title") = "PREVIEW_EDIT_LCN"
End Code

    <script src="~/Scripts_angular/ANGULAR_APP.js"></script>
    <script src="~/Scripts_angular/CENTER_SV.js"></script>
    <script src="~/Scripts_angular/LCN_CTRL.js"></script>

<div class="ic" ng-controller="LCN_CTRL" ng-app="ANGULAR_APP" ng-init="pageload_modify()">
    <div ng-show="LIST_GMP.DALCN_EDIT_REQUEST.PROCESS_ID == '11105'">
        <div style="font-family:'Taviraj';font-size:24px;">
            <div>
                <p style="text-align: right;">แบบ ข.ย.๑๗</p>
            </div>
            <table style="width:100%">
                <tr>
                    <td style="width:35%"></td>
                    <td style="width:35%"></td>
                    <td style="width:5%;text-align:right">เลขที่:</td>
                    <td style=" width:25%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LCN_LIST.RCVNO_DISPLAY}}</label></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:35%"></td>
                    <td style="width:35%"></td>
                    <td style="width:5%;text-align:right">วันที่:</td>
                    <td style=" width:25%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LCN_LIST.RCV_DATE_DISPLAY}}</label></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:35%"></td>
                    <td style="width:35%"></td>
                    <td style="width:5%;text-align:right"> ลงชื่อ:</td>
                    <td style=" width:15%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:10%">ผู้รับคำขอ</td>
                </tr>
            </table>
            <div> <p style="text-align:center">คำขอแก้ไขเปลี่ยนแปลงรายการในใบอนุญาตขายยาแผนปัจจุบัน</p></div>
            <hr />
            <table style="width:100%">
                <tr>
                    <td style="text-align:right;width:90%">
                        เขียนที่
                    </td>
                    <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_EDIT_REQUEST.WRITE_AT}}
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right;width:100px">
                        วันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_EDIT_REQUEST.WRITE_DATE}}
                    </td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:10%;text-align:right">ข้าพเจ้า :</td>
                    <td style="width:90%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.thanm}}</label></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:10%;"></td>
                    <td style="width:90%;text-align:center">(ชื่อผู้รับอนุญาต)</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:13%;">มีผู้ดำเนินกิจการ ชื่อ</td>
                    <td style="width:74%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label></td>
                    <td style="width:13%;">(เฉพาะกรณีนิติบุคคล)</td>
                </tr>
            </table>
            <table style="width:100%;">
                <tr>
                    <td style="width:13%;">เลขที่บัตรประชาชน</td>
                    <td style="width:87%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.BSN_IDENTIFY}}</label></td>
                </tr>
            </table>
            <div style="padding-left:30%;">
                <table>
                    <tr>
                        <td>ได้รับอนุญาตให้ :</td>
                        <td>
                            <input type="radio" name="type_a" ng-model="LIST_LCN.CHK_TYPE" value="1" id="rdl_CHK_SELL_TYPE" disabled="disabled" />ขายยาแผนปัจจุบัน
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <input type="radio" name="type_a" ng-model="LIST_LCN.CHK_TYPE" value="2" id="rdl_CHK_SELL_TYPE" disabled="disabled" />ขายยาแผนปัจจุบันเฉพาะยาบรรจุเสร็จที่ไม่ใช่ยาอันตรายหรือยาควบคุมพิเศษ
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td> <input type="radio" name="type_a" ng-model="LIST_LCN.CHK_TYPE" value="3" id="rdl_CHK_SELL_TYPE" disabled="disabled" />ขายยาแผนปัจจุบันเฉพาะยาบรรจุเสร็จสำหรับสัตว์</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td> <input type="radio" name="type_a" ng-model="LIST_LCN.CHK_TYPE" value="4" id="rdl_CHK_SELL_TYPE" disabled="disabled" />ขายส่งยาแผนปัจจุบัน</td>
                    </tr>
                </table>
            </div>
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
            <table style="width:100%">
                <tr>
                    <td>ขอเปลี่ยนแปลงรายการในใบอนุญาต ดังต่อไปนี้</td>
                <tr>
                    <td>
                        <input class="form-control inline" ng-model="LIST_LCN.DALCN_EDIT_REQUEST.EDIT_DESCRIPTION" style="font-family:'Taviraj';font-size:20px;width:100%;" type="text" />
                    </td>
                </tr>
            </table>
            <br />
            <table>
                <tr>
                    <td> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; ขายส่งยาแผนปัจจุบัน คือ</td>
                </tr>
            </table>
            <table>
                <tr>
                    <td> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; (๑) ใบอนุญาตประกอบธุรกิจเกี่ยวกับยาหรือใบแทน</td>
                </tr>
            </table>
            <table>
                <tr>
                    <td> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; (๒) เอกสารที่เป็นหลักฐานเกี่ยวข้องกับรายการที่ขอเปลี่ยนแปลง</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:50%;text-align:center"></td>
                    <td style="width:10%;text-align:right">(ลายมือชื่อ)</td>
                    <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:20%;text-align:start">ผู้รับอนุญาต</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:50%;text-align:center"></td>
                    <td style="width:10%;text-align:right">(</td>
                    <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:20%;text-align:start">) (ตัวบรรจง)</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:50%;text-align:center"></td>
                    <td style="width:10%;text-align:right">(ลายมือชื่อ)</td>
                    <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:20%;text-align:start">ผู้มีหน้าที่ปฏิบัติการ</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:50%;text-align:center"></td>
                    <td style="width:10%;text-align:right">(</td>
                    <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:20%;text-align:start">) (ตัวบรรจง)</td>
                </tr>
            </table>
        </div>
    </div>

    <div ng-show="LIST_GMP.DALCN_EDIT_REQUEST.PROCESS_ID == '11106'">
        <div style="font-family:'Taviraj';font-size:24px;">
            <div>
                <p style="text-align: right;">แบบ ผ.ย.๑๒</p>
            </div>
            <table style="width:100%">
                <tr>
                    <td style="width:35%"></td>
                    <td style="width:35%"></td>
                    <td style="width:5%;text-align:right">เลขที่:</td>
                    <td style=" width:25%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LCN_LIST.RCVNO_DISPLAY}}</label></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:35%"></td>
                    <td style="width:35%"></td>
                    <td style="width:5%;text-align:right">วันที่:</td>
                    <td style=" width:25%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LCN_LIST.RCV_DATE_DISPLAY}}</label></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:35%"></td>
                    <td style="width:35%"></td>
                    <td style="width:5%;text-align:right"> ลงชื่อ:</td>
                    <td style=" width:15%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:10%">ผู้รับคำขอ</td>
                </tr>
            </table>
            <div> <p style="text-align:center">คำขอแก้ไขเปลี่ยนแปลงรายการในใบอนุญาต</p></div>
            <div> <p style="text-align:center">ผลิตยาแผนปัจจุบัน</p></div>
            <hr />
            <table style="width:100%">
                <tr>
                    <td style="text-align:right;width:90%">
                        เขียนที่
                    </td>
                    <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_EDIT_REQUEST.WRITE_AT}}
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right;width:100px">
                        วันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_EDIT_REQUEST.WRITE_DATE}}
                    </td>
                </tr>
            </table>
            <br />
            <table style="width:100%">
                <tr>
                    <td style="width:10%;text-align:right">ข้าพเจ้า :</td>
                    <td style="width:90%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.thanm}}</label></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:10%;"></td>
                    <td style="width:90%;text-align:center">(ชื่อผู้รับอนุญาต)</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:15%;">ซึ่งมีผู้ดำเนินกิจการ ชื่อ</td>
                    <td style="width:74%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label></td>
                    <td style="width:15%;text-align:right">ได้รับอนุญาตให้ผลิตยา</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:15%;">แผนปัจจุบันตามใบอนุญาตที่</td>
                    <td style="width:35%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.LCNNO_SHOW}}</label></td>
                    <td style="width:15%;">ณ สถานที่ผลิตยาชื่อ</td>
                    <td style="width:35%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.THANAMEPLACE}}</label></td>
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
                    <td style="width:18%;">โทรศัพท์</td>
                    <td style="width:82%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.tel}}</label></td>
                </tr>
            </table>
            <p>ขอเปลี่ยนแปลงรายการในใบอนุญาต ดังต่อไปนี้</p>
            <table style="width:100%">
                <tr>
                    <td><input class="form-control inline" ng-model="LIST_LCN.DALCN_EDIT_REQUEST.EDIT_DESCRIPTION" style="font-family:'Taviraj';font-size:20px;width:100%;" type="text" /></td>
                </tr>
            </table>
            <br />
            <table>
                <tr>
                    <td>ข้าพเจ้าได้แนบหลักฐานมาด้วย คือ</td>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp; (๑) ใบอนุญาตผลิตยาแผนปัจจุบันหรือใบแทน</td>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp; (๒) เอกสารที่เป็นหลักฐานเกี่ยวข้องกับรายการที่ขอเปลี่ยนแปลง</td>
                </tr>
            </table>
            <br />
            <table style="width:100%">
                <tr>
                    <td style="width:50%;text-align:center"></td>
                    <td style="width:10%;text-align:right">(ลายมือชื่อ)</td>
                    <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:20%;text-align:start">ผู้ยื่นคำขอ</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:50%;text-align:center"></td>
                    <td style="width:10%;text-align:right">(ลายมือชื่อ)</td>
                    <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:20%;text-align:start">ผู้มีหน้าที่ปฏิบัติการ</td>
                </tr>
            </table>
        </div>
    </div>

    <div ng-show="LIST_GMP.DALCN_EDIT_REQUEST.PROCESS_ID == '11107'">
        <div style="font-family:'Taviraj';font-size:24px;">
            <div>
                <p style="text-align: right;">แบบ น.ย.๑๑</p>
            </div>
            <table style="width:100%">
                <tr>
                    <td style="width:35%"></td>
                    <td style="width:35%"></td>
                    <td style="width:5%;text-align:right">เลขที่:</td>
                    <td style=" width:25%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LCN_LIST.RCVNO_DISPLAY}}</label></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:35%"></td>
                    <td style="width:35%"></td>
                    <td style="width:5%;text-align:right">วันที่:</td>
                    <td style=" width:25%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LCN_LIST.RCV_DATE_DISPLAY}}</label></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:35%"></td>
                    <td style="width:35%"></td>
                    <td style="width:5%;text-align:right"> ลงชื่อ:</td>
                    <td style=" width:15%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:10%">ผู้รับคำขอ</td>
                </tr>
            </table>
            <div> <p style="text-align:center">คำขอแก้ไขเปลี่ยนแปลงรายการในใบอนุญาต</p></div>
            <div> <p style="text-align:center">นำหรือสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักร</p></div>
            <hr />
            <table style="width:100%">
                <tr>
                    <td style="text-align:right;width:90%">
                        เขียนที่
                    </td>
                    <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_EDIT_RREQUEST.WRITE_AT}}
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right;width:100px">
                        วันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_EDIT_RREQUEST.WRITE_DATE}}
                    </td>
                </tr>

            </table>
            <br />
            <table style="width:100%">
                <tr>
                    <td style="width:10%;text-align:right">ข้าพเจ้า :</td>
                    <td style="width:90%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.thanm}}</label></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:10%;"></td>
                    <td style="width:90%;text-align:center">(ชื่อผู้รับอนุญาต)</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:15%;">ซึ่งมีผู้ดำเนินกิจการ ชื่อ</td>
                    <td style="width:74%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label></td>
                    <td style="width:15%;text-align:right">ได้รับอนุญาตให้นำหรือสั่งยา</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:27%;">แผนปัจจุบันเข้ามาในราชอาณาจักรตามใบอนุญาตที่</td>
                    <td style="width:60%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.LCNNO_SHOW}}</label></td>
                    <td style="width:23%;text-align:right">ณ สถานที่นำหรือสั่งยาชื่อ</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:100%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.THANAMEPLACE}}</label></td>
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
                    <td style="width:13%;">โทรศัพท์</td>
                    <td style="width:87%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.tel}}</label></td>
                </tr>
            </table>
            <div>ขอเปลี่ยนแปลงรายการในใบอนุญาต ดังต่อไปนี้</div>
            <table style="width:100%">
                <tr>
                    <td><input class="form-control inline" ng-model="LIST_LCN.DALCN_EDIT_REQUEST.EDIT_DESCRIPTION" style="font-family:'Taviraj';font-size:20px;width:100%;" type="text" /></td>
                </tr>
            </table>
            <br />
            <table>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;ข้าพเจ้าได้แนบหลักฐานมาด้วย คือ</td>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;(๑) ใบอนุญาตนำหรือสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักรหรือใบแทน</td>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;(๒) เอกสารที่เป็นหลักฐานเกี่ยวข้องกับรายการที่ขอเปลี่ยนแปลง</td>
                </tr>
            </table>
            <br />
            <table style="width:100%">
                <tr>
                    <td style="width:50%;text-align:center"></td>
                    <td style="width:10%;text-align:right">(ลายมือชื่อ)</td>
                    <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:20%;text-align:start">ผู้ยื่นคำขอ</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:50%;text-align:center"></td>
                    <td style="width:10%;text-align:right">(ลายมือชื่อ)</td>
                    <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:20%;text-align:start">ผู้มีหน้าที่ปฏิบัติการ</td>
                </tr>
            </table>
        </div>
    </div>

    <div ng-show="LIST_GMP.DALCN_EDIT_REQUEST.PROCESS_ID == '11108'">
        <div style="font-family:'Taviraj';font-size:24px;">
            <div>
                <p style="text-align: right;">แบบ ย.บ.๑๖</p>
            </div>
            <table style="width:100%">
                <tr>
                    <td style="width:35%"></td>
                    <td style="width:35%"></td>
                    <td style="width:5%;text-align:right">เลขที่:</td>
                    <td style=" width:25%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LCN_LIST.RCVNO_DISPLAY}}</label></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:35%"></td>
                    <td style="width:35%"></td>
                    <td style="width:5%;text-align:right">วันที่:</td>
                    <td style=" width:25%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LCN_LIST.RCV_DATE_DISPLAY}}</label></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:35%"></td>
                    <td style="width:35%"></td>
                    <td style="width:5%;text-align:right"> ลงชื่อ:</td>
                    <td style=" width:15%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:10%">ผู้รับคำขอ</td>
                </tr>
            </table>
            <br />
            <table style="width:100%">
                <tr>
                    <td style="text-align:center">คำขอแก้ไขเปลี่ยนแปลงรายการในใบอนุญาต</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:50%"></td>
                    <td style="text-align:start"> <input type="radio" ng-model="LIST_LCN.CHK_TYPE" value="1" disabled /> ผลิตยาแผนโบราณ</td>
                <tr>
                    <td style="width:50%"></td>
                    <td style="text-align:start"> <input type="radio" ng-model="LIST_LCN.CHK_TYPE" value="2" disabled /> ขายยาแผนโบราณ</td>
                <tr>
                    <td style="width:50%"></td>
                    <td style="width:50%;text-align:start"> <input type="radio" ng-model="LIST_LCN.CHK_TYPE" value="3" disabled /> นำหรือสั่งยาแผนโบราณเข้ามาในราชอาณาจักร</td>
                </tr>
            </table>
            <hr />
            <table style="width:100%">
                <tr>
                    <td style="text-align:right;width:90%">
                        เขียนที่
                    </td>
                    <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_EDIT_REQUEST.WRITE_AT}}
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right;width:100px">
                        วันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_EDIT_REQUEST.WRITE_DATE}}
                    </td>
                </tr>
            </table>
            <br />
            <table style="width:100%">
                <tr>
                    <td style="width:10%;text-align:right">ข้าพเจ้า :</td>
                    <td style="width:90%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.thanm}}</label></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:10%;"></td>
                    <td style="width:90%;text-align:center">(ชื่อผู้รับอนุญาต)</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:13%;">มีผู้ดำเนินกิจการ ชื่อ</td>
                    <td style="width:74%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label></td>
                    <td style="width:13%;">(เฉพาะกรณีนิติบุคคล)</td>
                </tr>
            </table>
            <table>
                <tr>
                    <td style="width:20%;">ได้รับอนุญาตให้</td>
                    <td> <input type="radio" ng-model="LIST_LCN.CHK_TYPE" value="1" disabled /> ผลิตยาแผนโบราณ</td>
                    <td> <input type="radio" ng-model="LIST_LCN.CHK_TYPE" value="2" disabled /> ขายยาแผนโบราณ</td>
                    <td> <input type="radio" ng-model="LIST_LCN.CHK_TYPE" value="3" disabled /> นำหรือสั่งยาแผนโบราณเข้ามาในราชอาณาจักร</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>

                    <td style="width:15%;text-align:right">ตามใบอนุญาตที่</td>
                    <td style="width:85%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.LCNNO_SHOW}}</label></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:15%;">ณ สถานที่ประกอบธุรกิจ ชื่อ</td>
                    <td style="width:85%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.THANAMEPLACE}}</label></td>
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
                    <td style="width:18%;">โทรศัพท์</td>
                    <td style="width:82%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.tel}}</label></td>
                </tr>
            </table>
            <label>ขอเปลี่ยนแปลงรายการในใบอนุญาต ดังต่อไปนี้</label>
            <table style="width:100%">
                <tr>
                    <td><input class="form-control inline" ng-model="LIST_LCN.DALCN_EDIT_REQUEST.EDIT_DESCRIPTION" style="font-family:'Taviraj';font-size:20px;width:100%;" type="text" /></td>
                </tr>
            </table>
            <br />
            <table>
                <tr>
                    <td>ข้าพเจ้าได้แนบหลักฐานมาด้วย คือ</td>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp; (๑) ใบอนุญาตประกอบธุรกจเกี่ยวกับยาแผนโบราณหรือใบแทน</td>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp; (๒) เอกสารที่เป็นหลักฐานเกี่ยวข้องกับรายการที่ขอเปลี่ยนแปลง</td>
                </tr>
            </table>
            <br />
            <table style="width:100%">
                <tr>
                    <td style="width:50%;text-align:center"></td>
                    <td style="width:10%;text-align:right">(ลายมือชื่อ)</td>
                    <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:20%;text-align:start">ผู้ยื่นคำขอ</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:50%;text-align:center"></td>
                    <td style="width:10%;text-align:right">(ลายมือชื่อ)</td>
                    <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:20%;text-align:start">ผู้มีหน้าที่ปฏิบัติการ</td>
                </tr>
            </table>
            <hr />
            <div>หมายเหตุ : &nbsp;ใส่เครื่องหมาย &#10004; ในช่อง [  ] หน้าข้อความที่ต้องการ</div>
        </div>
    </div>

    <div ng-show="LIST_GMP.DALCN_EDIT_REQUEST.PROCESS_ID == '11109'">
        <div style="font-family:'Taviraj';font-size:15px;">
            <div>
                <h1 style="text-align:center;">
                    คำขอเปลี่ยนแปลงรายการในใบอนุญาต
                </h1>

                <hr style="width:20%; border-color:black;" />
            </div>
            <br />
            <div>
                <table style="width:100%">
                    <tr>
                        <td style="text-align:right;width:90%">
                            เขียนที่
                        </td>
                        <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                            {{LIST_LCN.DALCN_EDIT_REQUEST.WRITE_AT}}
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:right;width:100px">
                            วันที่
                        </td>
                        <td style="border-bottom:dotted;border-bottom-width:thin;">

                            {{LIST_LCN.DALCN_EDIT_REQUEST.WRITE_DATE}}
                        </td>
                    </tr>
                </table>
                <br />
                <table style="width:100%">
                    <tr>
                        <td style="width:15%; text-align:right">ข้าพเจ้า</td>
                        <td style="width:85%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.thanm}}</label></td>
                    </tr>
                </table>
                <table style="width:100%">
                    <tr>
                        <td style="width:40%"></td>
                        <td style="width:60%">ชื่อผู้รับอนุญาต</td>
                    </tr>
                </table>

                <table style="width:100%">
                    <tr>
                        <td style="width:10%">ซึ่งมีผู้ดำเนินกิจการชื่อ</td>
                        <td style="width:75%;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label></td>
                        <td style="width:15%">ได้รับอนุญาตให้</td>
                    </tr>
                </table>
                <table style="width:100%">
                    <tr>
                        <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.TYPE_LCN}}</label></td>
                        <td style="width:10%">ตามใบอนุญาตเลขที่</td>
                        <td style="width:50%;border-bottom:dotted;border-bottom-width:thin;"></td>
                    </tr>
                </table>
                <table style="width:100%">
                    <tr>
                        <td style="width:10%">ณ สถานที่ชื่อ</td>
                        <td style="width:90%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.thanameplace}}</label></td>

                    </tr>
                    <tr>
                        <td style="width:10%;">อยู่เลขที่</td>
                        <td style="width:90%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.fulladdr3}}</label></td>
                    </tr>
                </table>
                <table style="width:100%">
                    <tr>
                        <td style="width:10%">โทรศัพท์</td>
                        <td style="width:90%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.tel}}</label></td>
                    </tr>

                </table>
                <table style="width:100%">
                    <tr>
                        <td>ขอเปลี่ยนแปลงรายการในใบอนุญาต ดังต่อไปนี้</td>
                    <tr>
                        <td>
                            <input class="form-control inline" ng-model="LIST_LCN.DALCN_EDIT_REQUEST.EDIT_DESCRIPTION" style="font-family:'Taviraj';font-size:20px;width:100%;" type="text" />

                        </td>
                    </tr>
                </table>
                <br /><br /><br /><br /><br /><br /><br />
                <table style="width:100%">
                    <tr>
                        <td style="width:10%"></td>
                        <td style="width:90%">ข้าพเจ้าได้แนบหลักฐานมาด้วย คือ</td>
                    </tr>
                    <tr>
                        <td style="width:10%"></td>
                        <td style="width:90%">1.ใบอนุญาต</td>
                    </tr>
                    <tr>
                        <td style="width:10%"></td>
                        <td style="width:90%">2.เอกสารที่เป็นหลักฐานเกี่ยวข้องกับรายการเปลี่ยนแปลง</td>
                    </tr>
                </table>
                <br /><br /><br /><br />
                <table style="width:100%">
                    <tr>
                        <td style="width:50%; text-align:center"></td>
                        <td style="width:10%; text-align:right">(ลายมือชื่อ)</td>
                        <td style="width:20%; text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                        <td style="width:20%; text-align:start">ผู้ยื่นคำขอ</td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
</div>