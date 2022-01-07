@Code
'Layout = ""
End Code

    <script src="~/Scripts_angular/ANGULAR_APP.js"></script>
    <script src="~/Scripts_angular/CENTER_SV.js"></script>
    <script src="~/Scripts_angular/DR_CTRL.js"></script>

    <div ng-app="ANGULAR_APP" ng-controller="DR_CTRL">
        <div class="ic" style="font-family:'Taviraj';">
            <div>
                <table style="width:100%">
                    <tr>
                        <td style="width:30%"></td>
                        <td style="width:20%"></td>
                        <td style="width:30%; text-align:right">เลขที่ :</td>
                        <td style="width:25%; text-align:center"></td>
                    </tr>
                    <tr>
                        <td style="width:30%"></td>
                        <td style="width:20%"></td>
                        <td style="width:30%; text-align:right">วันที่ :</td>
                        <td style="width:25%; text-align:center"></td>
                    </tr>
                    <tr>
                        <td style="width:30%"></td>
                        <td style="width:20%"></td>
                        <td style="width:30%;text-align:right">ลงชื่อ :</td>
                        <td style="width:25%;text-align:right">ผู้รับคำขอ</td>
                    </tr>
                </table>
                <br />
                <center><h1>คำขอเปลี่ยนประเภทยาแผนปัจจุบันสำหรับมนุษย์</h1></center>
                <br />
                <table style="width:100%">
                    <tr>
                        <td style="text-align:right;width:90%">
                            เขียนที่
                        </td>
                        <td style="width:40%">
                            <input class="form-control inline" ng-model="LIST_DRRC.DR_RECLASS.WRITE_AT" style="font-family:'Taviraj';" type="text" />
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:right;width:100px">
                            วันที่
                        </td>
                        <td>

                            <md-datepicker ng-model="LIST_DRRC.DR_RECLASS.WRITE_DATE" md-placeholder="Enter date"
                                           input-aria-describedby="datepicker-description"
                                           input-aria-labelledby="datepicker-header ">
                            </md-datepicker>
                        </td>
                    </tr>
                </table>
                <br />
                <table style="width:100%;">
                    <tr>
                        <td style="width:2%"></td>
                        <td width="15%" align="right">
                            ข้าพเจ้า
                        </td>
                        <td style="text-align:center;border-bottom:dotted;border-bottom-width:thin;">
                            <label>{{LIST_READ_RC.thanm}}</label>
                        </td>
                    </tr>
                    <tr>

                        <td style="text-align:center;width:98%" colspan="3">
                            (ชื่อผู้ขออนุญาต)
                        </td>
                    </tr>
                </table>
                <table style="width:100%">
                    <tr>
                        <td style="width:2%"></td>
                        <td width="15%">
                            ซึ่งมีผู้ดำเนินกิจการ ชื่อ
                        </td>
                        <td style="text-align:left;width:2000px;border-bottom:dotted;border-bottom-width:thin;">
                            <label>{{LIST_READ_RC.BSN_THAIFULLNAME}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="width:2%"></td>
                        <td style="width:98%" colspan="2">ได้รับอนุญาตให้<span style="padding-left:30px;"><input type="radio" ng-model="LIST_READ_RC.PRODUCER_TYPE" disabled /></span>&nbsp; ผลิตยาแผนปัจจุบัน<span style="padding-left: 15px;"><input type="radio" ng-model="LIST_READ_RC.IMPORT_TYPE" disabled /></span>&nbsp; นำหรือสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักร</td>
                    </tr>
                </table>
                <table style="width:100%">
                    <tr>
                        <td style="width:2%"></td>
                        <td style="width:10%">ตามใบอนุญาตเลขที่</td>
                        <td width="30%" style="text-align:center;border-bottom:dotted;border-bottom-width:thin;">{{LIST_READ_RC.lcnno_no}}</td>
                        <td style="width:10%">มีสถานที่ประกอบธุรกิจชื่อ</td>
                        <td width="48%" style="text-align:center;border-bottom:dotted;border-bottom-width:thin;">{{LIST_READ_RC.location_name}}</td>
                    </tr>
                </table>
                <table style="width:100%">
                    <tr>
                        <td style="width:2%"></td>
                        <td style="width:200px">
                            อยู่เลขที่
                        </td>
                        <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;" colspan="3">
                            {{LIST_READ_RC.thanm_addr}}
                        </td>

                    </tr>
                    <tr>
                        <td style="width:2%"></td>
                        <td>
                            โทรศัพท์
                        </td>
                        <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                            {{LIST_READ_RC.tel}}
                        </td>
                    </tr>

                </table>
                <table style="width:100%">
                    <tr>
                        <td style="width:2%"></td>
                        <td style="width:15%">มีความประสงค์ขอเปลี่ยนประเภทยา ชื่อ</td>
                        <td width="40%" style="text-align:center;border-bottom:dotted;border-bottom-width:thin;">{{LIST_READ_RC.DRUG_NAME}}</td>
                        <td style="width:5%">เลขทะเบียนที่</td>
                        <td width="38%" style="text-align:center;border-bottom:dotted;border-bottom-width:thin;">{{LIST_READ_RC.register}}</td>
                    </tr>
                </table>
                <div>
                    <div>
                        <table width="100%">
                            <tr>
                                <td align="right" width="50%">
                                    <input class="form-control" placeholder="ค้นหาทะเบียนที่นี่..." ng-model="register" />
                                </td>
                                <td align="left" width="50%">
                                    <button class="btn btn-lg" ng-click="BTN_SEARCH_REGIST(register)" value="ค้นหาทะเบียนที่นี่">[กรณีตัวยา (API) และรูปแบบยา (Dosage form) เดียวกัน แต่มีหลายความแรง (Strength)]</button>
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div class="ic">
                        <table id="myTable" datatable="ng" class="dataTable" width="100%">
                            <thead>
                                <tr>
                                    <th width="50%">ชื่อยา</th>
                                    <th>เลขทะเบียน/th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr ng-repeat="datas in LIST_REGISTER | startFrom:(currentPage-1)*entryLimit | limitTo:entryLimit">
                                    <td>{{datas.DRUGNAME}}</td>
                                    <td>{{datas.register}}</td>
                                    <td>
                                        <a ng-click="BTN_ADD_REGISTER(datas)">
                                            เลือกทะเบียน
                                        </a>
                                    </td>
                                </tr>
                            </tbody>
                            <tfoot>
                                <tr></tr>
                            </tfoot>
                        </table>
                        <uib-pagination class="pagination-sm" total-items="filterData.length" ng-model="page"
                                        ng-change="pageChanged()" previous-text="&lsaquo;" next-text="&rsaquo;" items-per-page=10
                                        boundary-link-numbers="true" rotate="false" max-size="maxSize">
                        </uib-pagination>
                        <div align="center">
                            <button type="button" class="btn btn-sm" ng-disabled="currentPage == 0" ng-click="currentPage=currentPage-1"><i class="fas fa-arrow-left"></i> ก่อนหน้า (Previous)</button>
                            <button type="button" class="btn btn-sm" ng-disabled="currentPage >= LIST_CHEM.length/entryLimit - 1" ng-click="currentPage = currentPage+1">ถัดไป (Next)<i class="fas fa-arrow-right"></i></button>
                        </div>
                    </div>

                    <div>
                        <table class="dataTable" width="100%">
                            <thead>
                                <tr>
                                    <th>ลำดับ</th>
                                    <th width="55%">ชื่อยา</th>
                                    <th>เลขทะเบียน</th>
                                    <th>U1</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr ng-repeat="datas in GMP_CHEM">
                                    <td>{{$index + 1}}</td>
                                    <td>{{datas.DRUGNAME}}</td>
                                    <td>{{datas.register}}</td>
                                    <td>{{datas.Newcode}}</td>
                                    <td>
                                        <span class="fas fa-edit"></span>
                                        <a ng-click="deleteRegist(datas,$index)">
                                            ลบทะเบียน
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


                <table style="width:100%">
                    <tr>
                        <td style="width:2%"></td>
                        <td style="width:23%">ทีได้รับอนุญาตไว้จากเดิม</td>
                        <td>
                            <form name="rdl_class">


                                <label><input type="radio" ng-model="LIST_READ_RC.thakindnm" id="Rdl_old_type" value="1" disabled> ยาควบคุมพิเศษ</label>
                                <label><input type="radio" ng-model="LIST_READ_RC.thakindnm" id="Rdl_old_type" value="2" disabled> ยาอันตราย</label>
                                <label><input type="radio" ng-model="LIST_READ_RC.thakindnm" id="Rdl_old_type" value="3" disabled> ยาที่ไม่ใช่ยาอันตรายหรือยาควบคุมพิเศษ</label>
                                <label><input type="radio" ng-model="LIST_READ_RC.thakindnm" id="Rdl_old_type" value="4" disabled> ยาสามัญประจำบ้าน</label>
                            </form>
                        </td>
                        @*<td style="width:20%"><input type="checkbox" />&nbsp; ยาควบคุมพิเศษ</td>
                <td style="width:13%"><input type="checkbox" />&nbsp; ยาอันตราย</td>
                <td style="width:42%"><input type="checkbox" />&nbsp; ยาที่ไม่ใช่ยาอันตรายหรือยาควบคุมพิเศษ</td>*@
                    </tr>
                </table>
                <table style="width:100%">
                    <tr>
                        <td style="width:2%"></td>
                        <td style="width:23%"> เป็น</td>
                        <td>
                            <form name="rdl_class">
                                <label><input type="radio" ng-model="LIST_DRRC.DR_RECLASS.NEW_DOSESAGE" id="Rdl_old_type" value="1"> ยาควบคุมพิเศษ</label>
                                <label><input type="radio" ng-model="LIST_DRRC.DR_RECLASS.NEW_DOSESAGE" id="Rdl_old_type" value="2"> ยาอันตราย</label>
                                <label><input type="radio" ng-model="LIST_DRRC.DR_RECLASS.NEW_DOSESAGE" id="Rdl_old_type" value="3"> ยาที่ไม่ใช่ยาอันตรายหรือยาควบคุมพิเศษ</label>
                                <label><input type="radio" ng-model="LIST_DRRC.DR_RECLASS.NEW_DOSESAGE" id="Rdl_old_type" value="4"> ยาสามัญประจำบ้าน</label>
                            </form>
                        </td>
                    </tr>
                </table>
                <br />
                <p><span style="padding-left: 55px;">ข้าพเจ้าได้แนบเอกสาร หรือหลักฐาน ตามที่สำนักงานคณะกรรมการอาหารและยา ประกาศกำหนดไว้ในแนวทางการจัดเตรียมเอกสารประกอบการขอเปลี่ยนประเภทยาแผนปัจจุบันสำหรับมนุษย์</span></p>
                <table style="width:100%">
                    @*<tr>
                <td style="width:8%"></td>
                <td style="width:92%"><input type="checkbox" />&nbsp; แบบตรวจสอบการยื่นเอกสาร พร้อมเอกสารและหลักฐานประกอบการขอเปลี่ยนประเภทยาแผนปัจจุบันสำหรับมนุษย์ ลงนามยืนยันความถูกต้อง ครบถ้วนของเอกสาร</td>
            </tr>
            <tr>
                <td style="width:8%"></td>
                <td style="width:92%"><input type="checkbox" />&nbsp; สำเนาใบอนุญาต กรณีผู้ยื่นคำขอเป็นผู้รับอนุญาต</td>
            </tr>
            <tr>
                <td style="width:8%"></td>
                <td style="width:92%"><input type="checkbox" />&nbsp; หนังสือมอบอำนาจ ที่ระบุอำนาจให้ยื่นคำขอรวมถึงเอกสาร หลักฐาน แก้ไขเพิ่มเติม รับทราบ ติดตามผลการพิจารณา และยกเลิกคำขอพร้อมรับคำขอและเอกสาร หลักฐานคืน สำเนาบัตรประชาชนผู้มอบและผู้รับมอบอำนาจ พร้อมติดอากรแสตมป์ 30 บาท (กรณีมอบอำนาจมาเพื่อดำเนินการ)</td>
            </tr>*@
                    <tr>
                        <td style="width:2%"></td>
                        <td>
                            <form name="rdl_class">
                                <label><input type="checkbox" ng-model="ATTACH" id="Rdl_old_type" value="1">  แบบตรวจสอบการยื่นเอกสาร พร้อมเอกสารและหลักฐานประกอบการขอเปลี่ยนประเภทยาแผนปัจจุบันสำหรับมนุษย์ ลงนามยืนยันความถูกต้อง ครบถ้วนของเอกสาร</label><br />
                                <label><input type="checkbox" ng-model="ATTACH" id="Rdl_old_type" value="2">  สำเนาใบอนุญาต กรณีผู้ยื่นคำขอเป็นผู้รับอนุญาต</label><br />
                                <label><input type="checkbox" ng-model="ATTACH" id="Rdl_old_type" value="3"> หนังสือมอบอำนาจ ที่ระบุอำนาจให้ยื่นคำขอรวมถึงเอกสาร หลักฐาน แก้ไขเพิ่มเติม รับทราบ ติดตามผลการพิจารณา และยกเลิกคำขอพร้อมรับคำขอและเอกสาร หลักฐานคืน สำเนาบัตรประชาชนผู้มอบและผู้รับมอบอำนาจ พร้อมติดอากรแสตมป์ 30 บาท (กรณีมอบอำนาจมาเพื่อดำเนินการ)</label>

                            </form>
                        </td>

                    </tr>
                </table>
                <br />
                <table style="width:100%">
                    <tr>
                        <td style="width:50%; text-align:center"></td>
                        <td style="width:10%; text-align:right">(ลายมือชื่อ)</td>
                        <td style="width:20%; text-align:center"></td>
                        <td style="width:20%; text-align:start">ผู้ยื่นคำขอ</td>
                    </tr>
                    <tr>
                        <td style="width:50%; text-align:center"></td>
                        <td style="width:10%; text-align:right">(</td>
                        <td style="width:20%; text-align:center"></td>
                        <td style="width:20%; text-align:start">)</td>
                    </tr>
                </table>
                <hr style="width:95%; border-color:black" />
                <table>
                    <tr>
                        <td style="width:2%"></td>
                        <td style="width:12%"><b>หมายเหตุ :-</b></td>
                        <td style="width:86%">&nbsp; ใส่เครื่องหมาย &#128504; ในช่อง &#11036; หน้าข้อความที่ต้องการ</td>
                    </tr>
                </table>
            </div>
            <br />
        </div>
        <div class="in" style="font-family:'Taviraj';">
            <div ng-include="FILE_ATTACH">

            </div>
        </div>

        <br />
        <div style="text-align:center">
            <input type="button" class="btn btn-lg" style="background-color:#FFD700" ng-click="BTN_BACK()" value="ย้อนกลับ (Back)" />
            <input type="button" class="btn btn-lg" style="background-color:#38A86B;color:white" ng-click="BTN_SAVE_RECLASS()" value="บันทึก (Save)" />
        </div>
    </div>
