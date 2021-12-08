@Code Layout = "" End Code

<div>
    <div style="font-family:'Taviraj';width:100%">
        <div>
            <div>
                <h3>จดแจ้งเภสัชเคมีภัณฑ์ที่ไม่มีในทะเบียนตำรับยาผลิตในประเทศ (ภค.1)</h3>
            </div>
            <table style="width:100%">
                <tr>
                    <td style="width:5%">สถานะ</td>
                    <td>
                        <select style="font-family:'Taviraj';font-size:20px;">
                            <option value="0">--กรุณาเลือก--</option>
                        </select>
                    </td>
                </tr>
                <tr>
                    <td style="width:5%">ชื่อสาร</td>
                    <td style="width:10%"><input class="form-control inline" type="text"></td>
                </tr>
                <tr>
                    <td style="width:5%">เลขดำเนินการ</td>
                    <td style="width:10%"><input class="form-control inline" type="text"></td>
                    <td style="width:10%"><button class="btn btn-lg" style="width:150px;height:40px">ค้นหา</button></td>
                </tr>
            </table>
            <br />
            <div class="row" width="100%">
                <div class="col-sm-12">
                    <div align="center" class="card" style=" border-top: 10px solid #F9D027;">
                        <table style="margin-top:10px;width:100%;" class="table table-condensed">
                            <thead>
                                <tr>
                                    <th style="width:13%">เลขที่รับคำขอ</th>
                                    <th style="width:13%">วันที่รับ</th>
                                    <th style="width:13%">วันที่ยื่นคำขอ</th>
                                    <th style="width:15%">สถานะ</th>
                                    <th style="width:20%">ชื่อสาร</th>
                                    <th style="width:15%">เลขดำเนินการ</th>
                                    <th style="width:11%"></th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr ng-repeat="data in LIST_DH_STAFF">
                                    <td>{{data.rcvno}}</td>
                                    <td>{{data.rcvdate}}</td>
                                    <td>{{data.REQUEST_DATE}}</td>
                                    <td>{{data.STATUS_NAME}}</td>
                                    <td>{{data.TRADING_NAME}}</td>
                                    <td>{{data.TR_ID}}</td>
                                    <td>
                                        <span class="fa fa-eye"></span>
                                        <a ng-click="SELECT_DH(data)">
                                            ดูข้อมูล
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
            </div>

        </div>

    </div>
</div>