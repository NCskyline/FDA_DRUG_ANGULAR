
    <script src="../Scripts_angular/ANGULAR_APP.js"></script>
    <script src="../Scripts_angular/CENTER_SV.js"></script>
    <script src="../Scripts_angular/AUTHEN_STAFF_CTRL.js"></script>

<div ng-controller="AUTHEN_STAFF_CTRL" ng-app="ANGULAR_APP">
    <div>
        <input class="text" />
        <button class="btn btn-lg" ng-click="BTN_LOT_RELEASE('5','2564')">GET</button>
    </div>
    <div>
        <table>
            <tr ng-repeat="datas in data.bulkdata">
                <td>{{CertificateNo}}</td>
                <td>{{LotAllowTotal}}</td>
                <td>{{LotAllowTotalUnitType}}</td>
                <td>{{CertificateDate}}</td>
            </tr>
        </table>
    </div>
</div>
