@Code ViewData("Title") = "PREVIEW_NYM1" End Code

<div>
    <div class="content-part">
        <div class="part part-2-3">
            <div class="ic">
                <div style="font-family:'Taviraj';width:100%">
                    <div class="container-fluid">
                        <div>
                            <div>
                                <div class="row">
                                    <div class="col-md-9">
                                        <center>
                                            <h2>
                                                คำขออนุญาตนำหรือสั่งยาเข้ามาในราชอาณาจักรเพื่อการวิจัย
                                            </h2>
                                        </center>
                                        <hr />
                                    </div>
                                    <div class="col-md-3">
                                        <strong>แบบ น.ย.ม 1</strong>
                                        <div class="row" style="border:solid">
                                            <div class="col-md-12">
                                                <div class="form-inline">
                                                    <label>เลขรับที่</label> @*<input class="form-control ml-1 text-underline" />*@
                                                </div>
                                            </div>
                                            <div class="col-md-12">
                                                <div class="form-inline">
                                                    <label>วันที่</label> @*<input type="date" class="form-control ml-1 " />*@
                                                </div>
                                            </div>
                                            <div class="col-md-12">
                                                <div class="form-inline">
                                                    <label>ลงชื่อ</label> @*<input class="form-control ml-1" />*@<label class="ml-1">ผู้รับคำขอ</label>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="container-fluid">
                                        <div class="card-body">
                                            <div class="row">
                                                <div class="col-md-1">
                                                    <strong>ประเภท</strong>

                                                </div>
                                                <div class="col-md-11">
                                                    <div class="form-check">
                                                        <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault">
                                                        <label class="form-check-label" for="flexCheckDefault">
                                                            ยาแผนปัจจุบัน
                                                        </label>
                                                    </div>
                                                    <div class="form-check">
                                                        <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault">
                                                        <label class="form-check-label" for="flexCheckDefault">
                                                            ยาแผนโบราณ
                                                        </label>
                                                    </div>

                                                </div>
                                                <div class="col-md-2 mt-5">
                                                    <div class="form-inline">
                                                        <label>1.ข้าพเจ้า</label>
                                                        <div class="radio ml-2">
                                                            <label><input type="radio" name="optradio"> นาย</label>
                                                        </div>
                                                        <div class="radio ml-2">
                                                            <label><input type="radio" name="optradio"> นาง</label>
                                                        </div>
                                                        <div class="radio ml-2">
                                                            <label><input type="radio" name="optradio"> นางสาว</label>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="col-md-10 mt-5">
                                                    @*<input class="form-control " style="width:100%" />*@
                                                </div>
                                                <div class="col-md-12 mt-1">
                                                    <div class="row">
                                                        <div class="col-md-2 ">
                                                            <label>ตำแหน่ง</label>
                                                        </div>
                                                        <div class="col-md-10 ">
                                                            @*<input class="form-control " style="width:100%" />*@
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="col-md-12 mt-1">
                                                    <div class="row">
                                                        <div class="col-md-2 ">
                                                            <label>ในนามของ</label>
                                                        </div>
                                                        <div class="col-md-10 ">

                                                            <div class="row">
                                                                <div class="col-md-4">
                                                                    <div class="form-check">
                                                                        <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault">
                                                                        <label class="form-check-label" for="flexCheckDefault">
                                                                            กระทรวง
                                                                        </label>
                                                                        @*<input class="form-control" />*@
                                                                    </div>
                                                                    <div class="form-check">
                                                                        <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault">
                                                                        <label class="form-check-label" for="flexCheckDefault">
                                                                            สภากาชาดไทย
                                                                        </label>

                                                                    </div>

                                                                </div>
                                                                <div class="col-md-4">
                                                                    <div class="form-check">
                                                                        <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault">
                                                                        <label class="form-check-label" for="flexCheckDefault">
                                                                            ทบวง
                                                                        </label>
                                                                        @*<input class="form-control" />*@
                                                                    </div>
                                                                    <div class="form-check">
                                                                        <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault">
                                                                        <label class="form-check-label" for="flexCheckDefault">
                                                                            องค์การเภสัชกรรม
                                                                        </label>
                                                                    </div>

                                                                </div>
                                                                <div class="col-md-4">
                                                                    <div class="form-check">
                                                                        <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault">
                                                                        <label class="form-check-label" for="flexCheckDefault">
                                                                            กรม
                                                                        </label>
                                                                        @*<input class="form-control" />*@
                                                                    </div>
                                                                </div>
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-md-12 mt-2">
                                                                    <div class="form-inline">
                                                                        <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault">
                                                                        <label class="form-check-label" for="flexCheckDefault">
                                                                            ผู้รับอนุญาตผลิตยา ชื่อ
                                                                        </label>
                                                                        @*<input class="form-control ml-2" />*@
                                                                        <label class="form-check-label" for="flexCheckDefault">
                                                                            ใบอนุญาตเลขที่
                                                                        </label>
                                                                        @*<input class="form-control ml-2" />*@
                                                                    </div>
                                                                </div>
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-md-12 mt-2">
                                                                    <div class="form-inline">
                                                                        <input class="form-check-input " type="checkbox" value="" id="flexCheckDefault">
                                                                        <label class="form-check-label ml-2 mt-1" for="flexCheckDefault">
                                                                            ผู้รับอนุญาตนำหรือสั่งยา ฯ  สถานที่ชื่อ
                                                                        </label>
                                                                        @*<input class="form-control ml-2" />*@
                                                                        <label class="form-check-label ml-2 mt-1" for="flexCheckDefault">
                                                                            ใบอนุญาตเลขที่
                                                                        </label>
                                                                        @*<input class="form-control ml-2" />*@
                                                                    </div>
                                                                </div>
                                                            </div>


                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="col-md-3">
                                                    <label>อยู่เลขที่</label>
                                                    @*<input class="form-control " style="width:100%" />*@
                                                </div>
                                                <div class="col-md-3">
                                                    <label>ตรอก/ซอย</label>
                                                    @*<input class="form-control " style="width:100%" />*@
                                                </div>
                                                <div class="col-md-3">
                                                    <label>ถนน</label>
                                                    @*<input class="form-control " style="width:100%" />*@
                                                </div>
                                                <div class="col-md-3">
                                                    <label>หมู่ที่</label>
                                                    @*<input class="form-control " style="width:100%" />*@
                                                </div>
                                                <div class="col-md-3">
                                                    <label>ตำบลแขวง</label>
                                                    @*<input class="form-control " style="width:100%" />*@
                                                </div>
                                                <div class="col-md-3">
                                                    <label>อำเภอ/เขต</label>
                                                    @*<input class="form-control " style="width:100%" />*@
                                                </div>
                                                <div class="col-md-3">
                                                    <label>จังหวัด</label>
                                                    @*<input class="form-control " style="width:100%" />*@
                                                </div>
                                                <div class="col-md-3">
                                                    <label>โทรศัพท์</label>
                                                    @*<input class="form-control " style="width:100%" />*@
                                                </div>
                                                <div class="col-md-3">
                                                    <label>โทรสาร</label>
                                                    @*<input class="form-control " style="width:100%" />*@
                                                </div>
                                                <div class="col-md-12">
                                                    <label>มีความประสงค์จะขออนุญาตนำหรือสั่งยาเข้ามาในราชอาณาจักรเพื่อการวิจัย</label>
                                                </div>
                                                <div class="col-md-12">
                                                    <label>2.ชื่อโครงการวิจัย</label>
                                                </div>
                                                <div class="col-md-12 ml-3">
                                                    <label>(ภาษาอังกฤษ)</label>
                                                    @*<input class="form-control" />*@
                                                </div>
                                                <div class="col-md-12 ml-3">
                                                    <label>(ภาษาไทย)(ถ้ามี)</label>
                                                    @*<input class="form-control" />*@
                                                </div>
                                                <div class="col-md-12 ml-3">
                                                    <label>สถานที่วิจัย</label>
                                                    @*<input class="form-control" />*@
                                                </div>
                                                <div class="col-md-12 ">
                                                    <label>รหัสโครงการวิจัย(ถ้ามี)</label>
                                                    @*<input class="form-control" />*@
                                                </div>
                                                <div class="col-md-12 ">
                                                    <label>ชื่อยา</label>
                                                    <div class="form-inline">
                                                        <label>(1) ชื่อยาหรือรหัสยา</label>
                                                        @*<input class="form-control" />*@
                                                        <label>รูปแบบยา</label>
                                                        @*<input class="form-control" />*@
                                                        <label>จำนวน</label>
                                                        @*<input class="form-control" />*@
                                                    </div>
                                                </div>
                                                <div class="col-md-12 ">
                                                    <label>รายละเอียดทุกขนาดบรรจุ</label>
                                                    @*<input class="form-control" />*@
                                                </div>
                                                <div class="col-md-12 ">
                                                    <strong>กรณีที่มีรายละเอียดเพิ่มเติม โปรดแนบเอกสารเพิ่มเติมที่รูปแบบเดียวกัย ซึ่งมีจำนวน....หน้า    </strong>
                                                </div>
                                                <div class="col-md-12 ">
                                                    <label> 6. ได้แนบหลักฐานมาด้วย ดังนี้</label>
                                                    <p class="ml-3">(1) ฉลากยาทุกชนิดบรรจุ (ภาษาไทย หรือ ภาษาอังกฤษ)</p>
                                                    <p class="ml-3">(2) เอกสารกำกับยา (สำหรับยาที่ขึ้นทะเบียนตำรับยา)</p>
                                                    <p class="ml-3">(3) เอกสารคู่มือผู้วิจัย (Invetigator Brochure)(สำหรับยาที่ไม่ได้ขึ้นทะเบียน)</p>
                                                    <p class="ml-3">(4) เอกสารแนะนำอาสาสมัคร(Patient Information Sheet)(ภาษาไทย)</p>
                                                    <p class="ml-3">(5) สรุปย่อโครงการวิจัย (ภาษาไทย)</p>
                                                    <p class="ml-3">(6) รายละเอียดโครงการวิจัย ฉบับสมบูรณ์ (ภาษาไทย หรือ ภาษาอังกฤษ)</p>
                                                    <p class="ml-3">(7) เอกสารควบคุมคุณภาพและการผลิตยา</p>
                                                    <p class="ml-3">
                                                        (8) เอกสารอนุมัติให้ทำการวิจัยจากคณะกรรมการพิจารณาจริยธรรมการวิจัยในคน (Institutional
                                                        Review Board: IRB หรือ Independent Ethics Committee: IEC) ที่สำนักงานคณะกรรมการ
                                                        อาหารและยา ยอมรับ
                                                        ยดของยา
                                                    </p>

                                                </div>
                                                <div class="col-md-12">
                                                    <label>7.รายละเอียดของยา</label>
                                                    <table class="table table-striped mt-2">
                                                        <tr>
                                                            <td>
                                                                <strong>ลำดับ</strong>
                                                            </td>
                                                            <td>
                                                                <strong>ชื่อยาหรือรหัสยา</strong>
                                                            </td>
                                                            <td>
                                                                <strong>ตัวยาสำคัญ(Active Ingredients)</strong>
                                                            </td>
                                                            <td>
                                                                <strong>ปริมาณต่อหน่วย</strong>
                                                            </td>

                                                        </tr>
                                                        <tr>
                                                            <td>
                                                            </td>
                                                            <td>
                                                            </td>
                                                            <td>
                                                            </td>
                                                            <td>
                                                            </td>

                                                        </tr>
                                                    </table>
                                                </div>
                                                <div class="col-md-12">
                                                    <label>กรณีที่มีรายละเอียดเพิ่มเติม โปรดแนบเอกสารเพิ่มเติมที่มีรูปแบบเดียวกัน ซึ่งมีจำนวน....หน้า</label>
                                                    <hr />

                                                </div>

                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <br />
        <div class="part part-1-3">
            <div class="ic">
                <div class="card">
                    <div>
                        โปรดเลือกสถานะถัดไป
                    </div>
                    <br />
                    <div style="width:80%;margin-left:10%">
                        <select class="form-control">
                            <option></option>
                        </select>
                    </div>
                    <br />
                    <div class="col-sm-12" style="text-align:center">
                        <input type="button" style="width:90%" class="btn btn-lg " value="ยืนยัน" />
                    </div>
                    <br />
                    <div class="col-sm-12" style="text-align:center">
                        <input type="button" style="width:90%" class="btn btn-lg " value="ยกเลิก" />
                    </div>
                    <br />
                    <div class="col-sm-12" style="text-align:center">
                        <input type="button" style="width:90%" class="btn btn-lg " value="Download PDF" />
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
