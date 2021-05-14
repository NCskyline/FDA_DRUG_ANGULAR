<h1>ค้นหาใบอนุญาตสถานที่ด้านยา</h1><br />
<table style="width:100%" @*border="1"*@>
    <tr>
        <td style="width:30%">
            สถานะใบอนุญาต
        </td>
        <td style="width:15%">
            <input type="radio" name="gender" checked />  ทั้งหมด
        </td>
        <td style="width:10%">
            <input type="radio" name="gender"  />  คงอยู่
        </td>
        <td>
            <input type="radio" name="gender"  />  ยกเลิก
        </td>
    </tr>
    <tr>
        <td style="width:30%">
            เลขนิติบุคคล/เลขบัตรประชาชน
        </td>
        <td colspan="3">
            <input style="width:50%" />
        </td>
    </tr>
    <tr>
        <td style="width:30%">
            เลขที่ใบอนุญาตสถานที่
        </td>
        <td colspan="3">
            <input style="width:50%" />(ตัวอย่าง นย1 กท 1/2555)
        </td>
    </tr>
</table>
<div style="margin-left:30%">
    <input type="button" value="ค้นหา" />
</div>
<div style="float:right">
    <input type="button" value="Tamplate เพื่อส่งนำเข้าข้อมูล" /><input type="button" value="Export ผู้ที่มีหน้าที่ปฏิบัติงาน" /><input type="button" value="Export ใบอนุญาติทั้งหมด" />
</div>

<div class="row">
    <div class="col-sm-12">
        <div class="card" ng-repeat="datas in LIST_LCN" style=" border-top: 10px solid #277210;">

            <div class="card-body" style="padding:unset;font-size: 15px;">
                <div class="row">
                    <div class="col-sm-10">
                        <div class="row">
                            <div class="col-sm-2 set-topic">
                                ใบอนุญาต :
                            </div>
                            <div class="col-sm-10">
                                {{datas.LCNNO}}
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-sm-2 set-topic">
                                ชื่อสถานที่ :
                            </div>
                            <div class="col-sm-10">
                                {{datas.NAME}}
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-2 set-topic">
                                ที่อยู่ :
                            </div>
                            <div class="col-sm-10">
                                {{datas.ADDR}}
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-2 set-topic">
                                ชื่อผู้ดำเนินกิจการ :
                            </div>
                            <div class="col-sm-10">
                                {{datas.ADDR}}
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-2 set-topic">
                                จังหวัด :
                            </div>
                            <div class="col-sm-10">
                                {{datas.ADDR}}
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-2 set-topic">
                                เลขดำเนินการ :
                            </div>
                            <div class="col-sm-10">
                                {{datas.ADDR}}
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-2 set-topic">
                                สถานะใบอนุญาต :
                            </div>
                            <div class="col-sm-10">
                                {{datas.ADDR}}
                            </div>
                        </div>
                    </div>  
                    <div class="col-sm-2">
                        <div class="row set-a-btn">
                            @*<div class="col-sm-12 ">
                    <span class="fa fa-eye"></span>
                    <a ng-click="SELECT_LCN(datas,'11')">
                        ผลิต
                    </a>
                </div>*@

                            <div class="col-sm-12 ">
                                <span class="fa fa-eye"></span>
                                <a ng-click="SELECT_LCN(datas,'12')">
                                    เลือก
                                </a>
                            </div>
                        </div>
                    </div>
                </div>

            </div>

        </div>
    </div>
</div>
