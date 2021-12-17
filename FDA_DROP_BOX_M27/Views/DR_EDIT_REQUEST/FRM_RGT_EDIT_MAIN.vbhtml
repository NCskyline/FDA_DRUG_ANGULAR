@Code
    Layout = ""
End Code

<div>
    <div class="ic" style="font-family:'Taviraj'">
        <div>
            <table class="table" width="100%">
                <tr>
                    <td width="40%">คำขอแก้ไขเปลี่ยนแปลงทะเบียน > K 1/62 (NC)</td> @*{{register}}*@
                    <td width="50%" align="center">
                        <select style="width:40%;font-family:'Taviraj'" class="form-control">
                            <option>นาย ณัฐสิทธิ์ อาจเมือง</option>
                            <option></option>
                        </select>
                    </td>
                    <td>
                        <input type="button" class="btn btn-lg" style="background-color:#38A86B;color:white"  ng-click="BTN_INPUT_YOR5()" value="สร้างคำขอแก้ไข" />
                    </td>
                </tr>
            </table>
        </div>
        <br />
        <div class="row">
            <div class="col-sm-12" style="width:100%;">
                <div class="card" style="border-top: 10px solid #F9D027;">
                    <table width="100%" class="table">
                        <thead style="        font-weight: 300;
">
                            <tr>
                                <td>เลขรับที่</td>
                                <td>ทะเบียน</td>
                                <td>ชื่อยา</td>
                                <td>เลขดำเนินการ</td>
                                <td>รายละเอียดการแก้ไข</td>
                                <td>สถานะ</td>
                                <td></td>
                                <td></td>
                                <td></td>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td></td>
                                <td>K 1/62 (NC)</td>
                                <td>ทดสอบ4 /test4</td>
                                <td>64009999</td>
                                <td></td>
                                <td>บันทึกและรอส่งเรื่อง</td>
                                <td>
                                    <a ng-click="">ใบนัด</a>
                                </td>
                                <td>
                                    <span class="fa fa-eye"></span>
                                    <a ng-click="BTN_PREVIEW_RGT_EDIT()">
                                        ดูข้อมูล
                                    </a>
                                </td>
                                <td>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                                <td>K 1/62 (NC)</td>
                                <td>ทดสอบ4 /test4</td>
                                <td>64009999</td>
                                <td></td>
                                <td>ส่งเรื่องและรอพิจารณา</td>
                                <td>
                                    <a ng-click="">ใบนัด</a>
                                </td>
                                <td>
                                    <span class="fa fa-eye"></span>
                                    <a ng-click="BTN_PREVIEW_RGT_EDIT()">
                                        ดูข้อมูล
                                    </a>
                                </td>
                                <td>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                                <td>K 1/62 (NC)</td>
                                <td>ทดสอบ4 /test4</td>
                                <td>64009999</td>
                                <td></td>
                                <td>เสนอลงนาม</td>
                                <td>
                                    <a ng-click="">ใบนัด</a>
                                </td>
                                <td>
                                    <span class="fa fa-eye"></span>
                                    <a ng-click="BTN_PREVIEW_RGT_EDIT()">
                                        ดูข้อมูล
                                    </a>
                                </td>
                                <td>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                                <td>K 1/62 (NC)</td>
                                <td>ทดสอบ4 /test4</td>
                                <td>64009999</td>
                                <td></td>
                                <td>อนุมัติ</td>
                                <td>
                                    <a ng-click="">ใบนัด</a>
                                </td>
                                <td>
                                    <span class="fa fa-eye"></span>
                                    <a ng-click="BTN_PREVIEW_RGT_EDIT()">
                                        ดูข้อมูล
                                    </a>
                                </td>
                                <td>
                                </td>
                            </tr>
                        </tbody>
                        <tfoot>
                            <tr></tr>
                        </tfoot>
                    </table>
                </div>
                <div align="right">
                    <a ng-click="BTN_PAYMENT()" style="color:blue">กดที่นี่เพื่อชำระเงิน</a>
                </div>
            </div>
        </div>
    </div>
</div>
