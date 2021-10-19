
<link rel="stylesheet" href="../dist/listree.min.css" />
<script src="../Scripts_angular/ANGULAR_APP.js"></script>
<script src="../Scripts_angular/CENTER_SV.js"></script>
<script src="../Scripts_angular/DH_CTRL.js"></script>
<link href="../css/bootstrap_limitless.min.css" rel="stylesheet" />

<div ng-controller="DH_CTRL" ng-app="ANGULAR_APP" ng-init="pageload()">

    <div class="content-part" style="font-family:'Taviraj';width:100%">
        <div class="part part-1-3 ic">
            <ul class="listree">
                <li>
                    <div class="listree-submenu-heading">ก. ลงทะเบียนสถานที่ผลิต (Registration of Manufacturer)</div>
                    <ol class="listree-submenu-items" style="color:black">
                        <li>
                            <a href="../DH/FRM_SELECT_LCN?PROCESS=31">มาตรฐาน GMP (GMP Standard) </a>  @*ng-click="DATA_GMP('31')"*@
                        </li>
                        <li>
                            <a href="../DH/FRM_SELECT_LCN?PROCESS=32">มาตรฐาน ISO (ISO Standard) </a>
                        </li>
                        <li>
                            <a href="../DH/FRM_SELECT_LCN?PROCESS=33">มาตรฐาน HACCP (HACCP Standard) </a>
                        </li>
                        <li>
                            <a href="../DH/FRM_SELECT_LCN?PROCESS=34">เอกสารหลักฐานการขาย (Purchase Order) </a>
                        </li>
                        <li>
                            <a href="../DH/FRM_SELECT_LCN?PROCESS=36">เอกสารอื่นที่ อย. เห็นชอบ (FDA Approved Documents) </a>
                        </li>
                    </ol>
                </li>
                <li>
                    <div class="listree-submenu-heading">ข. จดแจ้งเภสัชเคมีภัณฑ์ (Notification of Drug Substance)</div>
                    <ol class="listree-submenu-items" style="color:black">
                        <li>
                            <a href="../DH/FRM_SELECT_LCN?PROCESS=14">สารออกฤทธิ์ในทะเบียนตำรับยาผลิตในประเทศ <br />
                            (Active Substance in Locally Manufactured Drug Products) </a>
                        </li>
                        <li>
                            <a href="../DH/FRM_SELECT_LCN?PROCESS=15">สารออกฤทธิ์ที่ไม่มีในทะเบียนตำรับยาผลิตในประเทศ <br />
                            (Active Substance not in Locally Manufactured Drug Products) </a>
                        </li>
                        <li>
                            <a href="../DH/FRM_SELECT_LCN?PROCESS=16">สารไม่ออกฤทธิ์ในทะเบียนตำรับยาผลิตในประเทศ <br />
                            (Excipient in Locally Manufactured Drug Products) </a>
                        </li>
                        @*<li>
                            <a href="../DH/FRM_SELECT_LCN?PROCESS=17">4. ไม่เป็นสารออกฤทธิ์ที่ไม่มีในทะเบียนตำรับยา (ผลิต)</a>
                        </li>*@
                    </ol>
                </li>
                <li>
                    <div class="listree-submenu-heading">ค. เพิ่มสาร (Add Substance)</div>
                    <ol class="listree-submenu-items">
                        <li>
                            <div class="listree-submenu-heading">สารออกฤทธิ์ (Active Substance)</div>
                            <ul class="listree-submenu-items">
                                <li>
                                    <a ng-click="DATA_CHE1('37')" style="color:cornflowerblue">สารเดี่ยว (Substance)</a>
                                </li>
                                <li>
                                    <a ng-click="DATA_CHE2('38')" style="color:cornflowerblue">สารผสม (Mixture)</a>
                                </li>
                            </ul>
                        </li>
                        <li>
                            <div class="listree-submenu-heading">สารไม่ออกฤทธิ์ (Excipient)</div>
                            <ul class="listree-submenu-items">
                                <li>
                                    <a ng-click="DATA_CHE3('66')" style="color:cornflowerblue">สารเดี่ยว (Substance)</a>
                                </li>
                                <li>
                                    <a ng-click="DATA_CHE4('67')" style="color:cornflowerblue">สารผสม (Mixture)</a>
                                </li>
                            </ul>
                        </li>
                    </ol>
                </li>
                <li>
                    <div class="listree-submenu-heading">ง. ค้นหาการจดแจ้งเภสัชเคมีภัณฑ์ (Search for Drug Substances with DRM Numbers)</div>
                </li>
            </ul>
        </div>
        <div class="part part-2-3 ic">

            <div ng-include="SUB_PATH">

            </div>
            
        </div>
    </div>
</div>