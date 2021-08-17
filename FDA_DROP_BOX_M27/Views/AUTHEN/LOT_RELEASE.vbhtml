
    <script src="../Scripts_angular/ANGULAR_APP.js"></script>
    <script src="../Scripts_angular/CENTER_SV.js"></script>
    <script src="../Scripts_angular/AUTHEN_STAFF_CTRL.js"></script>

<div ng-controller="AUTHEN_STAFF_CTRL" ng-app="ANGULAR_APP">
    <div>
        <table>
            <tr>
                <td>เดือน</td>
                <td><input type="text" class="form-control" ng-model="Month" /></td>
            </tr>
            <tr>
                <td>ปี</td>
                <td><input type="text" class="form-control" ng-model="Year" /></td>
            </tr>
        </table>
        <button class="btn btn-lg" ng-click="BTN_LOT_RELEASE(Month,Year)">GET</button>
    </div>
    <div>
        <table>
            <tr ng-repeat="datas in datas.data">
                <td>{{CertificateNo}}</td>
                <td>{{LotAllowTotal}}</td>
                <td>{{LotAllowTotalUnitType}}</td>
                <td>{{CertificateDate}}</td>
            </tr>
        </table>
    </div>
    
</div>
