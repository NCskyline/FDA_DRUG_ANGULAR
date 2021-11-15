
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
                    <div class="listree-submenu-heading">ขออนุญาตสถานที่ด้านยาแห่งใหม่</div>
                    <ul class="listree-submenu-items" style="color:black">
                        <li>
                            <a ng-click="BTN_MENU('101')" style="color:#06B716">ขย ๑</a>
                        </li>
                        <li>
                            <a ng-click="BTN_MENU('103')" style="color:#06B716">ขย ๓</a>
                        </li>
                        <li>
                            <a ng-click="BTN_MENU('104')" style="color:#06B716">ขย ๔</a>
                        </li>
                        <li>
                            <a ng-click="BTN_MENU('105')" style="color:#06B716">นย ๑</a>
                        </li>
                        <li>
                            <a ng-click="BTN_MENU('106')" style="color:#06B716">ผย ๑</a>
                        </li>
                        <li>
                            <a ng-click="BTN_MENU('107')" style="color:#06B716">ขยบ (ยาสัตว์)</a>
                        </li>
                        <li>
                            <a ng-click="BTN_MENU('108')" style="color:#06B716">นยบ (ยาสัตว์)</a>
                        </li>
                        <li>
                            <a ng-click="BTN_MENU('109')" style="color:#06B716">ผยบ (ยาสัตว์)</a>
                        </li>
                    </ul>
                </li>
                <li>
                    <div class="listree-submenu-heading">ขออนุญาตสถานที่วัตถุเสพติดแห่งใหม่</div>
                    <ul class="listree-submenu-items" style="color:black">
                        <li>
                            <div class="listree-submenu-heading">วัตถุออกฤทธิ์จิตและประสาทประเภท ๓ , ๔</div>
                            <ul class="listree-submenu-items" style="color:black">
                                <li>
                                    <a ng-click="BTN_MENU('131')" style="color:#06B716">นำเข้าวัตถุออกฤทธิ์ ฯ ในประเภท ๓</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('132')" style="color:#06B716">นำเข้าวัตถุออกฤทธิ์ ฯ ในประเภท ๔</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('123')" style="color:#06B716">ขายวัตถุออกฤทธิ์ ฯ ในประเภท ๓</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('124')" style="color:#06B716">ขายวัตถุออกฤทธิ์ ฯ ในประเภท ๔</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('133')" style="color:#06B716">ส่งออกวัตถุออกฤทธิ์ ฯ ในประเภท ๓</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('134')" style="color:#06B716">ส่งออกวัตถุออกฤทธิ์ ฯ ในประเภท ๔</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('125')" style="color:#06B716">ขายวัตถุออกฤทธิ์ ฯ โดยการขายส่งตรง ในประเภท ๓</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('126')" style="color:#06B716">ขายวัตถุออกฤทธิ์ ฯ โดยการขายส่งตรง ในประเภท ๔</a>
                                </li>
                            </ul>
                        </li>
                        <li>
                            <div class="listree-submenu-heading">ยาเสพติดให้โทษประเภทที่ ๓</div>
                            <ul class="listree-submenu-items" style="color:black">
                                <li>
                                    <a ng-click="BTN_MENU('116')" style="color:#06B716">นำเข้ายาเสพติดให้โทษในประเภท ๓</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('117')" style="color:#06B716">ส่งออกยาเสพติดให้โทษในประเภท ๓</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('115')" style="color:#06B716">จำหน่ายยาเสพติดให้โทษในประเภท ๓</a>
                                </li>
                            </ul>
                        </li>
                        <li>
                            <div class="listree-submenu-heading">ผลิตวัตถุออกฤทธิ์ฯประเภท ๓ หรือ ๔</div>
                            <ul class="listree-submenu-items" style="color:black">
                                <li>
                                    <a ng-click="BTN_MENU('127')" style="color:#06B716">ผลิตวัตถุออกฤทธิ์ ฯ ในประเภท ๓</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('128')" style="color:#06B716">ผลิตวัตถุออกฤทธิ์ ฯ ในประเภท ๔</a>
                                </li>
                            </ul>
                        </li>
                        <li>
                            <div class="listree-submenu-heading">ผลิตยาเสพติดให้โทษประเภทที่ ๓</div>
                            <ul class="listree-submenu-items" style="color:black">
                                <li>
                                    <a ng-click="BTN_MENU('114')" style="color:#06B716">ผลิตยาเสพติดให้โทษในประเภท ๓</a>
                                </li>
                            </ul>
                        </li>
                    </ul>
                </li>
                <li>
                    <div class="listree-submenu-heading">คำขอแก้ไข/คำขอใบแทน</div>
                    <ul class="listree-submenu-items">
                        <li>
                            <div>คำขอแก้ไขใบอนุญาต</div>
                            <ul class="listree-submenu-items">
                                <li>
                                    <a ng-click="BTN_MENU('11105')" style="color:#06B716">แก้ไขเปลี่ยนแปลงใบอนุญาตสถานที่ด้านยา ขายยาแผนปัจจุบัน</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('11106')" style="color:#06B716">แก้ไขเปลี่ยนแปลงใบอนุญาตสถานที่ด้านยา ผลิตยาแผนปัจจุบัน</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('11107')" style="color:#06B716">แก้ไขเปลี่ยนแปลงใบอนุญาตสถานที่ด้านยา นำหรือสั่งยาแผนปัจจุบัน</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('11108')" style="color:#06B716">แก้ไขเปลี่ยนแปลงใบอนุญาตสถานที่ด้านยา ยาแผนโบราณสำหรับสัตว์</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('11109')" style="color:#06B716">แก้ไขเปลี่ยนแปลงใบอนุญาตสถานที่ด้านยา ยาเสพติดให้โทษประเภทที่ ๓</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('11103')" style="color:#06B716">แก้ไขเปลี่ยนแปลงใบอนุญาตขายวัตถุออกฤทธิ์ ประเภท ๓ หรือประเภท ๔</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('11104')" style="color:#06B716">แก้ไขเปลี่ยนแปลงใบอนุญาตผลิตวัตถุออกฤทธิ์ ประเภท ๓ หรือประเภท ๔</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('11110')" style="color:#06B716">แก้ไขเปลี่ยนแปลงใบอนุญาตนำเข้าวัตถุออกฤทธิ์ ประเภท ๓ หรือประเภท ๔</a>
                                </li>
                            </ul>
                        </li>
                        <li>
                            <div class="listree-submenu-heading">คำขอใบแทน/ย้ายสถานที่</div>
                            <ul class="listree-submenu-items">
                                <li>
                                    <a ng-click="BTN_MENU('100701')" style="color:#06B716">คำขอใบแทนใบอนุญาตสถานที่ขายยาแผนปัจจุบัน</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('100702')" style="color:#06B716">คำขอใบแทนใบอนุญาตสถานที่นำเข้ายาแผนปัจจุบัน</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('100703')" style="color:#06B716">คำขอใบแทนใบอนุญาตสถานที่ผลิตยาแผนปัจจุบัน</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('100704')" style="color:#06B716">คำขอใบแทนใบอนุญาต ยาแผนโบราณ สำหรับสัตว์</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('100705')" style="color:#06B716">คำขอใบแทนใบอนุญาต ยาเสพติดให้โทษประเภทที่ ๓</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('100766')" style="color:#06B716">คำขอใบแทนใบอนุญาตขายวัตถุออกฤทธิ์ ฯ ประเภท ๓</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('100767')" style="color:#06B716">คำขอใบแทนใบอนุญาตขายวัตถุออกฤทธิ์ ฯ ประเภท ๔</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('100768')" style="color:#06B716">คำขอใบแทนใบอนุญาตผลิตวัตถุออกฤทธิ์ ฯ ประเภท ๓</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('100769')" style="color:#06B716">คำขอใบแทนใบอนุญาตผลิตวัตถุออกฤทธิ์ ฯ ประเภท ๔</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('100770')" style="color:#06B716">คำขอใบแทนใบอนุญาตนำเข้าวัตถุออกฤทธิ์ ฯ ประเภท ๓</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('100771')" style="color:#06B716">คำขอใบแทนใบอนุญาตนำเข้าวัตถุออกฤทธิ์ ฯ ประเภท ๔</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('100772')" style="color:#06B716">คำขอใบแทนใบอนุญาตส่งออกวัตถุออกฤทธิ์ ฯ ประเภท ๓</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('100773')" style="color:#06B716">คำขอใบแทนใบอนุญาตส่งออกวัตถุออกฤทธิ์ ฯ ประเภท ๔</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('100774')" style="color:#06B716">คำขอใบแทนใบอนุญาตขายส่งตรงวัตถุออกฤทธิ์ ฯ ประเภท ๓</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('100775')" style="color:#06B716">คำขอใบแทนใบอนุญาตขายส่งตรงวัตถุออกฤทธิ์ ฯ ประเภท ๔</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('100776')" style="color:#06B716">คำขอใบแทนใบอนุญาตขายส่งตรงวัตถุออกฤทธิ์ ฯ ประเภท ๓ ประชุม</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('100777')" style="color:#06B716">คำขอใบแทนใบอนุญาตขายส่งตรงวัตถุออกฤทธิ์ ฯ ประเภท ๔ ประชุม</a>
                                </li>

                                <li>
                                    <a ng-click="BTN_MENU('100791')" style="color:#06B716">คำขอย้ายสถานที่ ขายยาแผนปัจจุบัน</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('100792')" style="color:#06B716">คำขอย้ายสถานที่ นำเข้ายาแผนปัจจุบัน</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('100793')" style="color:#06B716">คำขอย้ายสถานที่ ผลิตยาแผนปัจจุบัน</a>
                                </li>
                                <li>
                                    <a ng-click="BTN_MENU('100794')" style="color:#06B716">คำขอคำขอย้ายสถานที่ ยาแผนโบราณ สำหรับสัตว์</a>
                                </li>
                                @*<li>
                            <a ng-click="BTN_MENU('100795')" style="color:#06B716">คำขอย้ายสถานที่ ยาเสพติดให้โทษประเภทที่ 3</a>
                        </li>*@
                            </ul>
                        </li>
                    </ul>
                </li>
                <li>
                    <div class="listree-submenu-heading">ยื่นคำขอต่ออายุใบอนุญาต (ระบบใหม่)</div>
                    <ul class="listree-submenu-items" style="color:black">
                        <li>
                            <a ng-click="BTN_MENU('100741')" style="color:#06B716">
                                ยื่นคำขอต่ออายุใบอนุญาต (ระบบใหม่)
                            </a>
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
