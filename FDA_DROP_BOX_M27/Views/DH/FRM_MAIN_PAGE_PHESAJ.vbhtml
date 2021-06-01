
<link rel="stylesheet" href="../dist/listree.min.css" />
<script src="../js/dist/listree.umd.min.js"></script>
<script src="../Scripts_angular/ANGULAR_APP.js"></script>
<script src="../Scripts_angular/CENTER_SV.js"></script>
<script src="../Scripts_angular/DH_CTRL.js"></script>


<div class="ic" ng-controller="DH_CTRL" ng-app="ANGULAR_APP" ng-init="pageload()">

    <div class="content-part">
        <div class="part part-1-3 no-bg">
            <ul class="listree">
                <li>
                    <div class="listree-submenu-heading">ก. ลงทะเบียนสถานที่ผลิต</div>
                    <ul class="listree-submenu-items" style="color:black">
                        <li>
                            <a href="../DH/FRM_SELECT_LCN?PROCESS=31">1.Certificate of GMP</a>  @*ng-click="DATA_GMP('31')"*@
                        </li>
                        <li>
                            <a href="../DH/FRM_SELECT_LCN?PROCESS=32">2.ISO</a>
                        </li>
                        <li>
                            <a href="../DH/FRM_SELECT_LCN?PROCESS=33">3.HACCP</a>
                        </li>
                        <li>
                            <a href="../DH/FRM_SELECT_LCN?PROCESS=34">4.Purchase Order</a>
                        </li>
                        <li>
                            <a href="../DH/FRM_SELECT_LCN?PROCESS=36">5.Other</a>
                        </li>
                    </ul>
                </li>
                <li>
                    <div class="listree-submenu-heading">ข. เภสัชเคมีภัณฑ์</div>
                    <ul class="listree-submenu-items" style="color:black">
                        <li>
                            <a href="../DH/FRM_SELECT_LCN?PROCESS=23">1. เป็นสารออกฤทธิ์ตามทะเบียนตำรับยา (ผลิต)</a>
                        </li>
                        <li>
                            <a href="../DH/FRM_SELECT_LCN?PROCESS=24">2. เป็นสารออกฤทธิ์ที่ไม่มีในทะเบียนตำรับยา (ผลิต)</a>
                        </li>
                        <li>
                            <a href="../DH/FRM_SELECT_LCN?PROCESS=25">3. ไม่เป็นสารออกฤทธิ์ตามทะเบียนตำรับยา (ผลิต)</a>
                        </li>
                        <li>
                            <a href="../DH/FRM_SELECT_LCN?PROCESS=26">4. ไม่เป็นสารออกฤทธิ์ที่ไม่มีในทะเบียนตำรับยา (ผลิต)</a>
                        </li>
                    </ul>
                </li>
                <li>
                    <div class="listree-submenu-heading">ค. เพิ่มสาร</div>
                    <ul class="listree-submenu-items">
                        <li>
                            <div class="listree-submenu-heading">สารเคมีที่มีส่วนผสมของสารออกฤทธิ์</div>
                            <ul class="listree-submenu-items">
                                <li>
                                    <a href="../DH/FRM_SELECT_LCN?PROCESS=37">สารเคมีชนิดสารเดี่ยว</a>
                                </li>
                                <li>
                                    <a href="../DH/FRM_SELECT_LCN?PROCESS=38">สารเคมีชนิดสารผสม</a>
                                </li>
                            </ul>
                            <div class="listree-submenu-heading">สารเคมีที่ไม่มีส่วนผสมของสารออกฤทธิ์</div>
                            <ul class="listree-submenu-items">
                                <li>
                                    <a ng-click="DATA_GMP('950002')">สารเคมีชนิดสารเดี่ยว</a>
                                </li>
                                <li>
                                    <a ng-click="DATA_GMP('950002')">สารเคมีชนิดสารผสม</a>
                                </li>
                            </ul>
                        </li>
                    </ul>
                </li>
            </ul>
        </div>
        <div class="part part-2-3 no-bg">

            <div ng-include="SUB_PATH" >

            </div>
        </div>
    </div>
</div>
