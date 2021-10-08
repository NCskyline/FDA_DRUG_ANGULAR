@Code
    ViewData("Title") = "INPUT_DRUG_YORBOR13"

End Code

<div class="ic">
    <div style="font-family:'Taviraj';font-size:20px;">
        <div>
            <p style="text-align: right;">แบบ ย.บ.๑๓</p>
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

        <table style="width:100%">
            <tr>
                <td>
                    <div> <h3 style="text-align:right">คำขอต่ออายุใบอนุญาต</h3></div>
                </td>
                <td>
                    <table>
                        <tr>
                            <td> <input type="checkbox" ng-model="LIST_LCN.LCN_TYPE" value="1" disabled /> ผลิตยาแผนโบราณ</td>
                        </tr>
                        <tr>
                            <td> <input type="checkbox" ng-model="LIST_LCN.LCN_TYPE" value="2" disabled /> ขายยาแผนโบราณ</td>
                        </tr>
                        <tr>
                            <td> <input type="checkbox" ng-model="LIST_LCN.LCN_TYPE" value="3" disabled /> นำหรือสั่งยาแผนโบราณเข้ามาในราชอาณาจักร</td>
                        </tr>
                    </table>
                </td>



        </table>
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
                <td style="width:10%;text-align:right">ข้าพเจ้า </td>
                <td style="width:40%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.thanm}}</label></td>
                <td style="width:13%;text-align:right">ซึ่งมีผู้ดำเนินกิจการ ชื่อ </td>
                <td style="width:37%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:10%;text-align:right"></td>
                <td style="width:40%;text-align:center">(ชื่อผู้ขออนุญาต)</td>
                <td style="width:10%;text-align:right"></td>
                <td style="width:40%;text-align:center"></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:13%;">ได้รับอนุญาตให้</td>
                <td>
                    <input type="checkbox" ng-model="LIST_LCN.LCN_TYPE" value="1" disabled /> ผลิตยาแผนโบราณ
                    <input type="checkbox" ng-model="LIST_LCN.LCN_TYPE" value="2" disabled /> ขายยาแผนโบราณ
                    <input type="checkbox" ng-model="LIST_LCN.LCN_TYPE" value="3" disabled /> นำหรือสั่งยาแผนโบราณเข้ามา
                </td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:20%;">ในราชอาณาจักรตามใบอนุญาตที่</td>
                <td style="width:35%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.LCNNO_SHOW}}</label></td>
                <td style="width:15%;">ณ สถานที่ประกอบธุรกิจ ชื่อ</td>
                <td style="width:35%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.thanameplace}}</label></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:10%;">อยู่เลขที่</td>
                <td style="width:90%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.fulladdr3}}</label></td>
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
        <table>
            <tr>
                <td>ขอต่ออายุใบอนุญาตดังกล่าว เพื่อใช้ต่อไปในปี พ.ศ.</td>
                <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.EXP_NEWYEAR}}</label></td>
            </tr>
        </table>
        <br />
        <table style="width:100%">
            <tr>
                <td style="width:5%">
                <td style="width:95%">ข้าพเจ้าได้ส่งมอบหลักฐานต่างๆ มาด้วย คือ</td>
            </tr>
        </table>
        @*<table style="width:100%">
            <tr>
                <td style="width:5%"></td>
                <td style="width:95%">(๑) ใบรับรองของผู้ประกอบวิชาชีพเวชกรรม ซึ่งรับรองว่าผู้ดำเนินกิจการไม่เป็นโรคตามมาตรา ๔๘ (๖)แห่งพระราชบัญญัติยา พ.ศ. ๒๕๑๐ ซึ่งแก้ไขเพิ่มเติมโดยพระราชบัญญัติยา (ฉบับที่ ๓) พ.ศ. ๒๕๒๒</td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:5%"></td>
                <td style="width:95%">(๒) ใบอนุญาตประกอบธุรกิจเกี่ยวกับยาแผนโบราณหรือใบแทน</td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:5%"></td>
                <td style="width:95%">(๓) เอกสารแสดงว่าเป็นผู้จัดการหรือผู้แทน ซึ่งเป็นผู้ดำเนินกิจการของนิติบุคคล (กรณีนิติบุคคลเป็นผู้ขออนุญาต)</td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:5%"></td>
                <td style="width:95%">(๔) เอกสารอื่น ๆ ถ้ามี</td>
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
        <br />
        <hr />
        <div>หมายเหตุ :- &nbsp; ใส่เครื่องหมาย &#10004; ในช่อง [  ] หน้าข้อความที่ต้องการ</div>
    </div>
    
</div>