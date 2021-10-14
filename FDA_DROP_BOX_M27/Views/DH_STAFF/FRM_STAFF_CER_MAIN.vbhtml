@Code
    Layout = ""
End Code

    <div>
        <div style="font-family:'Taviraj';width:100%">
            <div>
                <div >
                    <h3>GMP สถานที่ผลิต</h3>
                </div>
                <br />
                <br />
                <div class="row" width="100%">
                    <div class="col-sm-12">
                        <div align="center" class="card" style=" border-top: 10px solid #277210;">
                            <table style="margin-top:10px;width:100%;" class="table table-condensed">
                                <thead>
                                    <tr>
                                        <th style="width:20%">เลขที่รับคำขอ</th>
                                        <th style="width:15%">วันที่รับ</th>
                                        <th style="width:15%">วันที่ยื่น</th>
                                        <th style="width:20%">สถานะ</th>
                                        <th style="width:20%">รหัสดำเนินการ</th>
                                        <th style="width:10%"></th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr ng-repeat="data in LIST_GMP_STAFF">
                                        <td>{{data.rcvno}}</td>
                                        <td>{{data.rcvdate}}</td>
                                        <td>{{data.REQ_DATE}}</td>
                                        <td>{{data.STATUS_NAME}}</td>
                                        <td>{{data.transcode}}</td>
                                        <td>
                                            <span class="fa fa-eye"></span>
                                            <a ng-click="SELECT_CER(data)">
                                                ดูข้อมูล
                                            </a>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>

            </div>

        </div>
    </div>

