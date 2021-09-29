
@Code
    Layout = Nothing
End Code

<link rel="stylesheet" href="../dist/listree.min.css" />
<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/LCN_CTRL.js"></script>
<link href="../css/bootstrap_limitless.min.css" rel="stylesheet" />

<div ng-controller="LCN_CTRL" ng-app="ANGULAR_APP">

    <div class="content-part " style="width:100%;font-family:'Taviraj'">
        <div class="part part-1-3 ic">
            <ul class="listree">
                <li>
                    <div class="listree-submenu-heading">ระบบสถานที่ด้านยา</div>
                    <ul class="listree-submenu-items" style="color:black">
                        <li>
                            <a ng-click="BTN_MENU_STAFF('1001')" style="color:#06B716">ใบอนุญาตสถานที่</a>
                        </li>
                        <li>
                            <a ng-click="BTN_MENU_STAFF('1002')" style="color:#06B716">แก้ไขใบอนุญาตสถานที่</a>
                        </li>
                        <li>
                            <a ng-click="BTN_MENU_STAFF('1003')" style="color:#06B716">ใบแทนใบอนุญาตสถานที่</a>
                        </li>
                    </ul>
                </li>

                <li>
                    <div class="listree-submenu-heading">ระบบผลิตภัณฑ์ยา</div>
                    <ul class="listree-submenu-items" style="color:black">
                        @*<li>
                            <a ng-click="BTN_MENU_STAFF('2001')" style="color:#06B716">บัญชีรายการขอขึ้นทะเบียนยา</a>
                        </li>*@
                        <li>
                            <a ng-click="BTN_MENU_STAFF('2002')" style="color:#06B716">คำขอขึ้นทะเบียนตำรับยา</a>
                        </li>
                        <li>
                            <a ng-click="BTN_MENU_STAFF('2003')" style="color:#06B716">คำขอแก้ไขเปลี่ยนแปลงทะเบียน</a>
                        </li>
                        <li>
                            <a ng-click="BTN_MENU_STAFF('2004')" style="color:#06B716">ตรวจสอบใบสำคัญและข้อมูลในระบบ</a>
                        </li>
                        <li>
                            <a ng-click="BTN_MENU_STAFF('2005')" style="color:#06B716">คำขอใบแทนใบสำคัญ</a>
                        </li>

                    </ul>
                </li>
                <li>
                    <div class="listree-submenu-heading">ระบบเภสัชเคมีภัณฑ์</div>
                    <ul class="listree-submenu-items" style="color:black">
                        <li>
                            <a ng-click="BTN_MENU_STAFF('3001')" style="color:#06B716">GMP สถานที่ผลิต</a>
                        </li>
                        <li>
                            <a ng-click="BTN_MENU_STAFF('3002')" style="color:#06B716">เภสัชเคมีภัณฑ์</a>
                        </li>
                        <li>
                            <a ng-click="BTN_MENU_STAFF('3003')" style="color:#06B716">เพิ่มสาร</a>
                        </li>
                        <li>
                            <a ng-click="BTN_MENU_STAFF('3004')" style="color:#06B716">ค้นหาเภสัชเคมีภัณฑ์</a>
                        </li>
                        <li>
                            <a ng-click="BTN_MENU_STAFF('3005')" style="color:#06B716">ค้นหาสาร</a>
                        </li>
                        <li>
                            <a ng-click="BTN_MENU_STAFF('3006')" style="color:#06B716">ค้นหา CER</a>
                        </li>
                    </ul>
                </li>
            </ul>
        </div>
        <div class="part part-2-3 ic">

            <div ng-include="SUB_PATH">

            </div>

        </div>
    </div>
</div>
