
@Code
    ViewData("Title") = "INPUT_DRUG_PORYOR9"

End Code
    <div class="ic" ng-app="" ng-controller="">
        <div style="font-family:'Taviraj';font-size:20px;">
            <div>
                <p style="text-align: right;">แบบ ผ.ย.๙</p>
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
            <hr />
            <div> <h3 style="text-align:center">คำขอต่ออายุใบอนุญาตผลิตยาแผนปัจจุบัน</h3></div>
            <hr />
            <table style="width:100%">
                <tr>
                    <td style="text-align:right;width:90%">
                        เขียนที่
                    </td>
                    <td style="width:40%">
                        <input class="form-control inline" ng-model="LIST_LCN.LCN_EXTEND_LITE.WRITE_AT" style="font-family:'Taviraj';" type="text" />
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right;width:100px">
                        วันที่
                    </td>
                    <td>

                        <md-datepicker ng-model="LIST_LCN.LCN_EXTEND_LITE.WRITE_DATE" md-placeholder="Enter date"
                                       input-aria-describedby="datepicker-description"
                                       input-aria-labelledby="datepicker-header ">
                        </md-datepicker>
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
                    <td style="width:13%;">ซึ่งมีผู้ดำเนินกิจการ ชื่อ</td>
                    <td style="width:69%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:18%;">ได้รับอนุญาตให้ผลิตยาแผนปัจจุบัน</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:13%;">ตามใบนอนุญาตที่</td>
                    <td style="width:50%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.LCNNO_SHOW}}</label></td>
                    <td style="width:13%;">ณ สถานที่ผลิตยาชื่อ</td>
                    <td style="width:24%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.thanameplace}}</label></td>
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
                    <td style="width:50%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.tel}}</label></td>
                    <td style="width:10%;">เวลาทำการ</td>
                    <td style="width:22%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.opentime}}</label></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td>ขอต่ออายุใบอนุญาตดังกล่าวเพื่อใช้ต่อไปในปี พ.ศ.</td>
                    <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.EXP_NEWYEAR}}</label></td>
                </tr>
            </table>
            <br />
            <table style="width:100%">
                <tr>
                    <td style="width:5%">
                    <td style="width:95%">ข้าพเจ้าได้แนบหลักฐานมาด้วย คือ</td>
                </tr>
            </table>
            @*<table style="width:100%">
            <tr>
                <td style="width:5%"></td>
                <td style="width:95%">(๑) ใบรับรองของผู้ประกอบวิชาชีพเวชกรรม ซึ่งรับรองว่าผู้ดำเนินกิจการไม่เป็นโรคตามมาตรา ๑๔ (๖)แห่งพระราชบัญญัติยา พ.ศ. ๒๕๑๐</td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:5%"></td>
                <td style="width:95%">(๒) ใบอนุญาตผลิตยาแผนปัจจุบันหรือใบแทน</td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:5%"></td>
                <td style="width:95%">(๓) เอกสารแสดงว่าเป็นผู้จัดการหรือเป็นผู้แทน ซึ่งเป็นผู้ดำเนินกิจการของนิติบุคคล (กรณีนิติบุคคลเป็นผู้ขออนุญาต)</td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:5%"></td>
                <td style="width:95%">(๔) เอกสารอื่นๆ ถ้ามี</td>
            </tr>
        </table>*@
            <div class="row">
                <div class="col-sm-10" style="width:100%">
                    <div class="card" ng-repeat="datas in DOC_LIST.FILE_LISTs">
                        <div class="card-header" ng-show="datas.PIORITY=='HIGH'">
                            หัวข้อเอกสาร <span style="color:red;"> (บังคับแนบ)</span>
                        </div>
                        <div class="card-header" ng-show="datas.PIORITY=='LOW'">
                            หัวข้อเอกสาร (ไม่บังคับแนบ)
                        </div>
                        <div class="card-body">

                            <table class="table" style="width:100%">
                                <tr>
                                    <td colspan="5">
                                        {{datas.DES}}
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width:15%;"><input id="file-input" ng-model="datas.FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                                    <td style="width:10%;">ชื่อไฟล์</td>
                                    <td style="width:50%;">{{datas.FILENAME}}</td>
                                    <td style="width:5%">
                                        <a ng-click="OPEN_DOC_PATH(datas.PATH)">{{FLAG}}</a>
                                    </td>
                                    <td style="width:20%; text-align: right;">
                                        @*<input type="button" ng-click="UPLOAD_PDFs(datas)" value="บันทึก" />*@
                                        @*<input type="button" ng-click="deleteRow(datas,$index)" value="ลบ" />*@
                                    </td>
                                </tr>

                            </table>
                        </div>

                    </div>
                </div>
            </div>
            <br />
            <table style="width:100%">
                <tr>
                    <td style="width:50%;text-align:center"></td>
                    <td style="width:10%;text-align:right">(ลายมือชื่อ)</td>
                    <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:20%;text-align:start">ผู้ยื่นคำขอ</td>
                </tr>
            </table>
        </div>
    </div>
