@Code
'Layout = ""
End Code



    <div>
        <div class="ic" style="font-family:'Taviraj'">
            <h3><u>ใบอนุญาตต่ออายุ</u></h3>
            <br />
            <div>
                <table class="table" width="100%">
                    <tr>
                        <td width="20%">เลขนิติบุคคล/เลขบัตรประชาชน</td>
                        <td width="60%">
                            <input type="text" class="form-control" />
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>เลขที่ใบอนุญาตสถานที่</td>
                        <td>
                            <input type="text" class="form-control" />
                        </td>
                    </tr>
                    <tr>
                        <td>เลขสถานที่</td>
                        <td>
                            <input type="text" class="form-control" />
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <input type="button" class="form-control" style="width:30%;font-family:'Taviraj'" value="ค้นหา"/>
                        </td>
                    </tr>
                </table>
            </div>
            <div class="row">
                <div class="col-sm-12" style="width:100%;">
                    <div class="card" style=" border-top: 10px solid #F9D027;">
                        <table width="100%" class="table">
                            <thead style="font-weight:300;">
                                <tr>
                                    <td>เลขใบอนุญาต</td>
                                    <td>ประเภท</td>
                                    <td>ที่อยู่</td>
                                    <td>รหัสผู้ประกอบการ</td>
                                    <td>สถานะ</td>
                                    <td>ต่ออายุในปี</td>
                                    <td>เลขดำเนินการ</td>
                                    <td>ผู้รับผิดชอบคำขอ</td>
                                    <td></td>
                                    <td></td>
                                    <td></td>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>ผย1 กท 999/2563</td>
                                    <td>ผย1</td>
                                    <td></td>
                                    <td>99999</td>
                                    <td>ชำระเงินแล้ว รอการตรวจสอบ</td>
                                    <td>2564</td>
                                    <td>640009999</td>
                                    <td></td>
                                    <td>
                                        <input type="button" ng-click="BTN_PREVIEW_EXTEND()" value="ดูข้อมูล" />
                                    </td>
                                    <td></td>
                                    <td></td>
                                </tr>
                            </tbody>
                            <tfoot>
                                <tr></tr>
                            </tfoot>
                        </table>

                    </div>

                </div>
            </div>
        </div>
    </div>
