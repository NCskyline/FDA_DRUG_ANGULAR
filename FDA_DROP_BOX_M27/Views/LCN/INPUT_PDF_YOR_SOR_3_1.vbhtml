<script src="../Scripts_angular/ANGULAR_APP.js"></script>
<script src="../Scripts_angular/CENTER_SV.js"></script>
<script src="../Scripts_angular/LCN_CTRL.js"></script>

<script type="text/javascript">
    $(document).ready(function () {
        $('select').selectpicker('refresh');
    })
</script>

<div class="ic" ng-controller="LCN_CTRL" ng-app="ANGULAR_APP" ng-init="pageload()" ng-cloak="">
    <div style="font-family:'Taviraj';font-size:24px;width:100%">
        <div>
            <p style="text-align: left;"><b>แบบ ย.ส. ๓-๑</b></p>
        </div>
        <div class="container">
            <div class="row">
                <div class="col-md-6">
                    <table style="width :50%" align="left" border="1">
                        <tr>
                            <td style="width: 100%">
                                เลขที่รับ<br />
                                วันที่<br />
                                <span style="padding-left: 30px;">(สำหรับเจ้าหน้าที่เป็นผู้กรอก)</span>
                            </td>
                        </tr>
                    </table>
                </div>
                <div class="col-md-6 offset-md-4">
                    <table style="width: 25%" align="right" border="1">
                        <tr>
                            <td style="width:100%; text-align:center"><img src="..." class="rounded float-end" alt="...">ที่ปิดรูปถ่ายของผู้ขอรับอนุญาตหรือผู้ดำเนินกิจการ ขนาด ๓ x ๔ ซม.</td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
        <br />
        <div>
            <p style="text-align: center; font-size: large">คำขอรับอนุญาต</p>
            <p style="text-align: center; font-size: large">ผลิต นำเข้า ส่งออก จำหน่ายหรือมีไว้ครอบครองเพื่อจำหน่าย</p>
            <p style="text-align: center; font-size: large">ซึ่งยาเสพติดให้โทษในประเภท ๓</p>
            <hr style="width: 17%; border-color: black" />
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
            <table style="width: 100%">
                <tr>
                    <td style="width: 2%"></td>
                    <td style="width: 30%"><b>๑. ข้าพเจ้า</b>&nbsp; (ชื่อบุคคล/นิติบุคคลผู้ขอรับใบอนุญาต)</td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">{{LIST_LCN.thanm}}</td>
                </tr>
                <tr>
                    <td style="width: 2%"></td>
                    <td style="width: 30%">เลขที่บัตรประชาชน หรือทะเบียนนิติบุคคลเลขที่</td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">{{LIST_LCN.IDENTIFY}}</td>
                </tr>
            </table>
            <table style="width: 100%">
                <tr>
                    <td style="width: 2%"></td>
                    <td style="font-size:20px">
                        อยู่เลขที่
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.fulladdr3}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 2%"></td>
                    <td style="font-size:20px">
                        โทรศัพท์/มือถือ
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.tel}}</label>
                    </td>
                </tr>
            </table>
            <table style="width: 100%">
                <tr>
                    <td style="width: 2%"></td>
                    <td style="width: 98%" colspan="2"><b>๒. ซึ่งมีผู้ได้รับมอบหมายให้ดำเนินกิจการของนิติบุคคลผู้ขอรับใบอนุญาตกรณีผู้ขอรับใบอนุญาตเป็นนิติบุคคล</b></td>
                </tr>
                <tr>
                    <td style="width: 2%"></td>
                    <td>ชื่อ</td>
                    <td style="width: 98%;border-bottom:dotted;border-bottom-width:thin;">{{LIST_LCN.BSN_THAIFULLNAME}}</td>
                </tr>
            </table>
            <table style="width: 100%">
                <tr>
                    <td style="width: 2%"></td>
                    <td style="width: 20%">เลขที่บัตรประชาชน</td>
                    <td style="width: 46%">
                        <form>
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
                        <label>{{LIST_LCN.AGE}}</label>ปี
                    </td>
                    <td>
                        สัญชาติ
                    </td>
                    <td style="text-align:left;width:10%;">
                        <input class="form-control inline" ng-model="LIST_LCN.dalcn.NATION" style="font-family:'Taviraj';" type="text" />
                    </td>
                </tr>
            </table>
            <table style="width: 100%">
                <tr>
                    <td style="width: 2%"></td>
                    <td style="width:200px">
                        อยู่เลขที่
                    </td>
                    <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;" colspan="3">
                        <label>{{LIST_LCN.BSN_FULL_ADDR}}</label>
                    </td>

                </tr>
                <tr>
                    <td style="width: 2%"></td>
                    <td>
                        โทรศัพท์
                    </td>
                    <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_TELEPHONE}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 2%"></td>
                    <td>
                        โทรศัพท์มือถือ
                    </td>
                    <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_FAX}}</label>
                    </td>
                </tr>
            </table>
            <table style="width: 100%">
                <tr>
                    <td style="width: 2%"></td>
                    <td style="width: 98%"><b>๓. ขอรับใบอนุญาต</b>(ให้ขีดเลือกข้อความในช่องให้ตรงตามความประสงค์จะขออนุญาตเพียงช่องเดียว)</td>
                </tr>
            </table>

            <table style=" font-size:20px;width:100%;margin-left:10%">

                <tr>
                    <td>
                        <form name="rdl_gmp">


                            <label><input type="radio" ng-model="LIST_LCN.PROCESS" id="Rdl_gmpt" value="114" disabled> ผลิตซึ่งยาเสพติดให้โทษในประเภท ๓</label><br />
                            <label><input type="radio" ng-model="LIST_LCN.PROCESS" id="Rdl_gmpt" value="116" disabled> นำเข้าซึ่งยาเสพติดให้โทษในประเภท ๓</label><br />
                            <label><input type="radio" ng-model="LIST_LCN.PROCESS" id="Rdl_gmpt" value="117" disabled> ส่งออกซึ่งยาเสพติดให้โทษในประเภท ๓</label><br />
                            <label><input type="radio" ng-model="LIST_LCN.PROCESS" id="Rdl_gmpt" value="115" disabled> จำหน่ายหรือมีไว้ในครอบครองเพื่อจำหน่ายซึ่งยาเสพติดให้โทษในประเภท ๓</label>
                        </form>
                    </td>

                </tr>
            </table>



            <table style="width: 100%">
                <tr>
                    <td style="width: 2%"></td>
                    <td style="width: 98%">ณ สถานที่ ชื่อ</td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">{{LIST_LCN.thanameplace}}</td>
                </tr>
                <tr>
                    <td>
                        ตั้งอยู่เลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.fulladdr3}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์/มือถือ
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.tel}}</label>
                    </td>
                </tr>
            </table>
            <table style="font-size:20px;width:100%">
                <tr>
                    <td style="width:20%">
                        โดยมีเภสัชกรชั้น
                    </td>
                    <td style="width:10%">
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
            @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_PHR(LIST_PHR_ADD)" />*@
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

            <hr style="width: 100%; border-color: black" />
            <p>เป็นผู้มีหน้าที่ควบคุมตามมาตรา ๒๑ แห่งพระราชบัญญัติยาเสพติดให้โทษ พ.ศ.๒๕๒๒</p>
            <div class="row">
                <div class="col-sm-12 in" style="width:100%">
                    <div ng-include="FILE_ATTACH">

                    </div>
                </div>
            </div>
            @*<table style="width: 100%">
            <tr>
                <td style="width: 2%"></td>
                <td style="width: 98%"><b>๕. พร้อมกับคำขอนี้ข้าพเจ้าได้แนบเอกสารหรือหลักฐานต่างๆ มาด้วย คือ</b></td>
            </tr>
            <tr>
                <td style="width: 2%"></td>
                <td style="width: 98%">(๑) สำเนาทะเบียนบ้านของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายให้ดำเนินกิจการ</td>
            </tr>
            <tr>
                <td style="width: 2%"></td>
                <td style="width: 98%">(๒) สำเนาบัตรประชาชนของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายให้ ดำเนินกิจการ</td>
            </tr>
            <tr>
                <td style="width: 2%"></td>
                <td style="width: 98%">(๓) รูปถ่ายของผู้ขอรับใบอนุญาตหรือผูู้ได้รับมอบหมายให้ดำเนินกิจการขนาด ๓ x ๔ เซนติเมตร จำนวน ๒ รูปซึ่งถ่ายไว้ไม่เกิน ๖ เดือน</td>
            </tr>
            <tr>
                <td style="width: 2%"></td>
                <td style="width: 98%">(๔) สำเนาหนังสือรับรองแสดงการจดทะเบียนเป็นนิติบุคคลซึ่งนายทะเบียนออกไว้ไม่เกิน ๖ เดือน</td>
            </tr>
            <tr>
                <td style="width: 2%"></td>
                <td style="width: 98%">(๕) หนังสือแสดงว่าผู้ได้รับมอบหมายให้ดำเนินกิจการของนิติบุคคลผู้ขอรับใบอนุญาตกรณีผู้ขอรับใบอนุญาตเป็นนิติบุคคล</td>
            </tr>
            <tr>
                <td style="width: 2%"></td>
                <td style="width: 98%">(๖) สำเนาใบอนุญาตประกอบวิชาชีพ</td>
            </tr>
            <tr>
                <td style="width: 2%"></td>
                <td style="width: 98%">(๗) สำเนาใบอนุญาตผลิตหรือขายยาแผนปัจจุบัน หรือใบอนุญาตนำหรือสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักรตามกฏหมายว่าด้วยยา แล้วแต่กรณี</td>
            </tr>
            <tr>
                <td style="width: 2%"></td>
                <td style="width: 98%">(๘) เอกสารหรือหลักฐานอื่นๆ(ถ้ามี)</td>
            </tr>
        </table>*@
            <br /><br />


            <table style="font-size:20px;width:70%;float:right">
                <tr>
                    <td style="width:10%;text-align:center">
                        (ลายมือชื่อ)
                    </td>
                    <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="text-align:left;width:40%">
                        ผู้ขอรับใบอนุญาต / ผู้ได้รับมอบหมายให้ ดำเนินกิจการ
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        (
                    </td>
                    <td style="width:50%;text-align:center;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                    </td>
                    <td style="text-align:left">
                        )
                    </td>
                </tr>
            </table>

        </div>
       @*<br />
        <div class="col-sm-12">
            <div class="row">
                <div class="col-sm-3" style="text-align:center">
                    รายละเอืยด :
                </div>
                <div class="col-sm-9">
                    {{REMARK}}
                </div>
            </div>
            <br />
            <table class="table" style="width:100%">
                <tr>
                    <td>ชื่อไฟล์</td>
                    <td></td>
                </tr>
                <tr ng-repeat="datas in LIST_LCN" style="background-color:#FDFCE3">
                    <td>{{datas.FILENAME}}</td>
                    <td>
                        <a ng-show="PROCESS == '116'" ng-click="OPEN_DOC_PATH(datas.PATH,datas.FILENAME)">ดูเอกสาร</a>
                    </td>
                </tr>
            </table>
        </div>*@
        <br />
        <br />
        <div class="col-sm-12" style="text-align:center;margin-bottom:40px;width:100%;">
            <table style="width:100%">
                <tr>
                    <td align="center">
                        <input type="button" class="btn btn-lg " ng-click="BTN_SAVE_LCN_INPUT()" value="บันทึก" />

                        <input type="button" class="btn btn-lg " ng-click="BTN_LCN_BACK()" value="ย้อนกลับ" />
                    </td>
                </tr>
            </table>

        </div>
    </div>
</div>