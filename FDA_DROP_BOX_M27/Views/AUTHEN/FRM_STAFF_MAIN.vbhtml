<script src="../Scripts_angular/ANGULAR_APP.js"></script>
<script src="../Scripts_angular/AUTHEN_STAFF_CTRL.js"></script>
<script src="../Scripts_angular/CENTER_SV.js"></script>

<div ng-controller="AUTHEN_STAFF_CTRL" ng-app="ANGULAR_APP">

    <div class="content-part no-pm">
        <div class="part part-1-3">
            <div align="center"><h3>ระบบจัดการ</h3></div>
            <div ng-repeat="datas in SET_MAIN_PAGE1">
                <div class="l-sign"><span class="ss"></span></div>
                <div>
                    <div data-target="s1" class="l-item s{{$index+1}}">
                        <span ng-show="loadarray[$index].LOADING" class="spinner-border spinner-border-sm" role="status" aria-hidden="true"></span>
                        <div class="l-text hide-xs button" ng-click="BTN_SUB_MENU_CLICK(datas.BTN_GROUP , datas.IDgroup , datas.SEQ)" style="width:100%;background-color:#EEEEE6">
                            @*<i class="h-icon fas fa-bookmark"></i>*@
                            {{datas.BTN_NAME}}
                        </div>
                    </div>
                </div>

            </div>
            
            <div align="center"><h3>ระบบสถานที่ด้านยา</h3></div>
            <div ng-repeat="datas in SET_MAIN_PAGE2">
                <div class="l-sign"><span class="ss"></span></div>
                <div>
                    <div data-target="s1" class="l-item s{{$index+1}}">
                        <span ng-show="loadarray[$index].LOADING" class="spinner-border spinner-border-sm" role="status" aria-hidden="true"></span>
                        <div class="l-text hide-xs button" ng-click="BTN_SUB_MENU_CLICK(datas.BTN_GROUP , datas.IDgroup , datas.SEQ)" style="width:100%;background-color:darkgrey">
                            @*<i class="h-icon fas fa-bookmark"></i>*@
                            {{datas.BTN_NAME}}
                        </div>
                    </div>
                </div>

            </div>
            
            <div align="center"><h3>ระบบผลิตภัณฑ์ยา</h3></div>
            <div ng-repeat="datas in SET_MAIN_PAGE3">
                <div class="l-sign"><span class="ss"></span></div>
                <div>
                    <div data-target="s1" class="l-item s{{$index+1}}">
                        <span ng-show="loadarray[$index].LOADING" class="spinner-border spinner-border-sm" role="status" aria-hidden="true"></span>
                        <div class="l-text hide-xs button" ng-click="BTN_SUB_MENU_CLICK(datas.BTN_GROUP , datas.IDgroup , datas.SEQ)" style="width:100%;background-color:darkgrey">
                            @*<i class="h-icon fas fa-bookmark"></i>*@
                            {{datas.BTN_NAME}}
                        </div>
                    </div>
                </div>

            </div>
            
            <div align="center"><h3>ระบบเภสัชเคมีภัณฑ์</h3></div>
            <div ng-repeat="datas in SET_MAIN_PAGE4">
                <div class="l-sign"><span class="ss"></span></div>
                <div>
                    <div data-target="s1" class="l-item s{{$index+1}}">
                        <span ng-show="loadarray[$index].LOADING" class="spinner-border spinner-border-sm" role="status" aria-hidden="true"></span>
                        <div class="l-text hide-xs button" ng-click="BTN_SUB_MENU_CLICK(datas.BTN_GROUP , datas.IDgroup , datas.SEQ)" style="width:100%;background-color:darkgrey">
                            @*<i class="h-icon fas fa-bookmark"></i>*@
                            {{datas.BTN_NAME}}
                        </div>
                    </div>
                </div>

            </div>
           
        </div>
        <div class="part part-2-3">

            <div ng-include="SUB_MAIN_PAGE">

            </div>

        </div>
    </div>

</div>
 