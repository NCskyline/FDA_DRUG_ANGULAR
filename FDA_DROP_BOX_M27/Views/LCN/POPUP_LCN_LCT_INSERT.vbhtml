@Code
    ViewData("Title") = "POPUP_LCN_LCT_INSERT"
End Code

<div>
    <div class="ic">
        <div style="font-family:'Taviraj'">
            <div class="col-sm-12">
                <div class="col-sm-3">
                    <h3><b>ประเภทสถานที่</b></h3>
                </div>
                <div class="col-sm-9">
                    <div style="margin-left:7%">
                        <input type="radio" />      ที่ตั้ง      <input type="radio" />    สถานที่เก็บ
                    </div>
                </div>
            </div>
            <br />
            <div class="col-sm-12">
                <div class="col-sm-3">
                    <h3><b>ชื่อสถานที่</b></h3>
                </div>
                <div class="col-sm-9">

                </div>
            </div>
            <div >
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
            <div >
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
        <br />
        <div style="text-align:center">
            <button class="btn btn-lg" style="background-color:#38A86B;color:white">บันทึกข้อมูลและส่งเรื่อง</button>
            <button class="btn btn-lg" style="background-color:#FFD700">ย้อนกลับ</button>
        </div>
    </div>
</div>
