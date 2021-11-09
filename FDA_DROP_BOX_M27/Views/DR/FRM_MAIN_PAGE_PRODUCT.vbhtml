@Code
    ViewData("Title") = "FRM_MAIN_PAGE_PRODUCT"
End Code
    <script src="~/Scripts_angular/ANGULAR_APP.js"></script>
    <script src="~/Scripts_angular/CENTER_SV.js"></script>
    <script src="~/Scripts_angular/DR_CTRL.js"></script>


    <div ng-app="ANGULAR_APP" ng-controller="DR_CTRL">
        <div class="content-part " style="font-family:'Taviraj';width:100%">
            <div class="part part-1-3 ic">
                <ul class="listree">
                    <li>
                        <div class="listree-submenu-heading"><b>ก. โปรกเลือกประเภทยา</b></div>
                        <ul class="listree-submenu-items" style="color:black">
                            <li>
                                <a ng-click="BTN_MENU('130001')" style="color:#06B716">ยาแผนปัจจุบัน สำหรับมนุษย์</a>  @*ng-click="DATA_GMP('31')"*@
                            </li>
                            <li>
                                <a ng-click="BTN_MENU('130002')" style="color:#06B716">ยาแผนปัจจุบัน สำหรับสัตว์</a>
                            </li>
                            <li>
                                <a ng-click="BTN_MENU('130004')" style="color:#06B716">ยาแผนโบราณ สำหรับสัตว์</a>
                            </li>
                        </ul>
                    </li>
                    <li>
                        <div class="listree-submenu-heading" style="color:black">
                            <a href="../DH/FRM_SELECT_LCN?PROCESS=14">ข. รายการ DRUG REVIEW</a>
                        </div>
                    </li>
                    <li>
                        <div class="listree-submenu-heading" style="color:black">
                            <a ng-click="BTN_MENU('130099')" style="color:#06B716">ค. คำขอแก้ไขรายการในทะเบียนตำรับยา</a>
                        </div>
                    </li>
                    <li>
                        <div class="listree-submenu-heading" style="color:black">
                            <a ng-click="BTN_MENU('99')" style="color:#06B716">ง. คำขอใบแทนใบสำคัญการขึ้นทะเบียนตำรับยา</a>
                        </div>
                    </li>
                    <li>
                        <div class="listree-submenu-heading"><b>ช. นำเข้ายาเฉพาะครั้ง</b></div>
                        <ul class="listree-submenu-items" style="color:black">
                            <li>
                                <a ng-click="BTN_MENU('1026')" style="color:#06B716">เพื่อการวิจัย (น.ย.ม.1)</a>  @*ng-click="DATA_GMP('31')"*@
                            </li>
                            <li>
                                <a ng-click="BTN_MENU('1027')" style="color:#06B716">เพื่อการวิเคราะห์ (น.ย.ม.2)</a>  @*ng-click="DATA_GMP('31')"*@
                            </li>
                            <li>
                                <a ng-click="BTN_MENU('1028')" style="color:#06B716">เพื่อการจัดนิทรรศการ (น.ย.ม.3)</a>
                            </li>
                            <li>
                                <a ng-click="BTN_MENU('1029')" style="color:#06B716">เพื่อบริจาคเพื่อการกุศล (น.ย.ม.4) ภาครัฐ</a>
                            </li>
                            <li>
                                <a ng-click="BTN_MENU('1031')" style="color:#06B716">เพื่อบริจาคเพื่อการกุศล (น.ย.ม.4) ภาคเอกชน</a>
                            </li>
                        </ul>
                    </li>
                    <li>
                        <div class="listree-submenu-heading">
                            <a ng-click="BTN_MENU('DROPBOX')" style="color:#06B716">ฌ. ระบบยื่นคำขออย่างง่าย</a>
                        </div>
                    </li>
                    <li>
                        <div class="listree-submenu-heading">ญ. คำขอเปลี่ยนประเภทยา</div>
                        <ul class="listree-submenu-items" style="color:black">
                            <li>
                                <a ng-click="BTN_MENU('140099')" style="color:#06B716">คำขอเปลี่ยนประเภทยาแผนปัจจุบันสำหรับมนุษย์</a>
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