@Code
    ViewData("Title") = "FRM_LOCATION_STAFF_CONFIRM"
End Code

<div>
    <div class="content-part">
        <div class="part part-2-3 ic">
            <div style="font-family:'Taviraj'">
                <div class="col-sm-12">
                    <div class="col-sm-3">
                        <h3><b>ชื่อสถานที่</b></h3>
                    </div>
                    <div class="col-sm-9">

                    </div>
                </div>
                <div>
                    <table class="table" style="margin-left:5%;width:90%">
                        <tr>
                            <td width="15%">ชื่อสถานที่ (ภาษาไทย)</td>
                            <td>
                                <input type="text" class="form-control" />
                            </td>
                        </tr>
                        <tr>
                            <td>ชื่อสถานที่ (ภาษาอังกฤษ)</td>
                            <td>
                                <input type="text" class="form-control" />
                            </td>
                        </tr>
                    </table>
                </div>
                <br />
                <div class="col-sm-12">
                    <div class="col-sm-3">
                        <h3><b>ที่ตั้งสถานที่</b></h3>
                    </div>
                    <div class="col-sm-9">

                    </div>
                </div>
                <div>
                    <table class="table" style="margin-left:5%;width:90%">
                        <tr>
                            <td width="15%">รหัสประจำบ้าน</td>
                            <td>
                                <input type="text" class="form-control" />
                            </td>
                        </tr>
                        <tr>
                            <td>เลขที่</td>
                            <td>
                                <input type="text" class="form-control" />
                            </td>
                        </tr>
                        <tr>
                            <td>อาคาร/ตึก</td>
                            <td>
                                <input type="text" class="form-control" />
                            </td>
                        </tr>
                        <tr>
                            <td>ชั้น</td>
                            <td>
                                <input type="text" class="form-control" />
                            </td>
                        </tr>
                        <tr>
                            <td>ห้อง</td>
                            <td>
                                <input type="text" class="form-control" />
                            </td>
                        </tr>
                        <tr>
                            <td>หมู่</td>
                            <td>
                                <input type="text" class="form-control" />
                            </td>
                        </tr>
                        <tr>
                            <td>ซอย</td>
                            <td>
                                <input type="text" class="form-control" />
                            </td>
                        </tr>
                        <tr>
                            <td>ถนน</td>
                            <td>
                                <input type="text" class="form-control" />
                            </td>
                        </tr>
                        <tr>
                            <td>จังหวัด</td>
                            <td>
                                <select class="form-control">
                                    <option></option>
                                </select>
                            </td>
                        </tr>
                        <tr>
                            <td>เขต/อำเภอ	</td>
                            <td>
                                <select class="form-control">
                                    <option></option>
                                </select>
                            </td>
                        </tr>
                        <tr>
                            <td>แขวง/ตำบล</td>
                            <td>
                                <select class="form-control">
                                    <option></option>
                                </select>
                            </td>
                        </tr>
                        <tr>
                            <td>รหัสไปรษณีย์</td>
                            <td>
                                <input type="text" class="form-control" />
                            </td>
                        </tr>
                        <tr>
                            <td>โทรศัพท์</td>
                            <td>
                                <input type="text" class="form-control" />
                            </td>
                        </tr>
                        <tr>
                            <td>โทรศัพท์มือถือ</td>
                            <td>
                                <input type="text" class="form-control" />
                            </td>
                        </tr>
                        <tr>
                            <td>โทรสาร</td>
                            <td>
                                <input type="text" class="form-control" />
                            </td>
                        </tr>
                        <tr>
                            <td>latitude(ถ้าไม่มีใส่ 0)</td>
                            <td>
                                <input type="text" class="form-control" />
                            </td>
                        </tr>
                        <tr>
                            <td>longitude(ถ้าไม่มีใส่ 0)</td>
                            <td>
                                <input type="text" class="form-control" />
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
        <div class="part part-1-3 ic">
            <div class="card">
                <div>
                    <div>
                        @*style="width:80%;margin-left:10%"*@
                        <div>
                            โปรดเลือกสถานะถัดไป
                        </div>
                        <div style="width:80%;margin-left:10%">
                            <select class="form-control">
                                <option></option>
                            </select>
                        </div>
                        <br />
                        <div>
                            วันที่มีผลอนุมัติ
                        </div>
                        <div style="width:80%;margin-left:10%">
                            <md-datepicker ng-model="LIST_GMP.CER.EXP_DOCUMENT_DATE" md-placeholder="Enter date"
                                           input-aria-describedby="datepicker-description"
                                           input-aria-labelledby="datepicker-header ">
                            </md-datepicker>
                        </div>
                        <br />
                        <div class="col-sm-12" style="text-align:center">
                            <input type="button" style="width:90%" class="btn btn-lg " value="ยืนยัน" />
                        </div>
                        <br />
                        <div class="col-sm-12" style="text-align:center">
                            <input type="button" style="width:90%" class="btn btn-lg " value="กลับหน้ารายการ" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

