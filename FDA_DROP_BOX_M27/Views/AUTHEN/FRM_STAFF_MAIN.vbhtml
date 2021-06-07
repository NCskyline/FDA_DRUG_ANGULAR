<script src="../Scripts_angular/ANGULAR_APP.js"></script>
<script src="../Scripts_angular/AUTHEN_STAFF_CTRL.js"></script>
<script src="../Scripts_angular/CENTER_SV.js"></script>

<div ng-controller="AUTHEN_STAFF_CTRL" ng-app="ANGULAR_APP">

    <div class="part part-1-3 no-bg">
       <div ng-repeat="datas in SET_MAIN_PAGE1">
           <div>ระบบจัดการ</div>
           <div>{{datas.BTN_NAME}}</div>
       </div>
    </div>
    <div>


    </div>
        

</div>
    @*<div class="content-part">
        <div class="part part-1-3">

            <div class="card-tab-control page-header-content header-elements-md-inline container">
                <div class="tab-content" ng-repeat="datas in fildata  = (FULL_MODEL.SET_PAGE_MAIN | filter: {PROCESS_ID : 203000})">
                <div class="tab-content" ng-repeat="datas in SET_MAIN_PAGE1">
                    <div>
                        <div>
                            ระบบจัดการ
                        </div>
                        <div data-index="{{datas.IDA}}" class="tab-content-item " ng-click="BTN_MENU_POPUP_CLICK(datas.PAGE_PATH,datas.PAGE_NAME,datas.IDA)">
                            <i class="h-icon fas fa-bookmark"></i>
                            {{datas.BTN_NAME}}
                        </div>
                    </div>
                </div>
            </div>
            <div class="card-tab-control page-header-content header-elements-md-inline container">
                <div class="tab-content" ng-repeat="datas in fildata  = (FULL_MODEL.SET_PAGE_MAIN | filter: {PROCESS_ID : 203000})">
                <div class="tab-content" ng-repeat="datas in SET_MAIN_PAGE2">
                    <div>
                        <div>
                            ระบบสถานที่ด้านยา
                        </div>
                        <div data-index="{{datas.IDA}}" class="tab-content-item " ng-click="BTN_MENU_POPUP_CLICK(datas.PAGE_PATH,datas.PAGE_NAME,datas.IDA)">
                            <i class="h-icon fas fa-bookmark"></i>
                            {{datas.BTN_NAME}}
                        </div>
                    </div>
                </div>
            </div>
            <div class="card-tab-control page-header-content header-elements-md-inline container">
                <div class="tab-content" ng-repeat="datas in fildata  = (FULL_MODEL.SET_PAGE_MAIN | filter: {PROCESS_ID : 203000})">
                <div class="tab-content" ng-repeat="datas in SET_MAIN_PAGE3">
                    <div>
                        <div>
                            ระบบผลิตภัณฑ์ยา
                        </div>
                        <div data-index="{{datas.IDA}}" class="tab-content-item " ng-click="BTN_MENU_POPUP_CLICK(datas.PAGE_PATH,datas.PAGE_NAME,datas.IDA)">
                            <i class="h-icon fas fa-bookmark"></i>
                            {{datas.BTN_NAME}}
                        </div>
                    </div>
                </div>
            </div>
            <div class="card-tab-control page-header-content header-elements-md-inline container">
                <div class="tab-content" ng-repeat="datas in fildata  = (FULL_MODEL.SET_PAGE_MAIN | filter: {PROCESS_ID : 203000})">
                <div class="tab-content" ng-repeat="datas in SET_MAIN_PAGE4">
                    <div>
                        <div>
                            ระบบเภสัชเคมีภัณฑ์
                        </div>
                        <div data-index="{{datas.IDA}}" class="tab-content-item " ng-click="BTN_MENU_POPUP_CLICK(datas.PAGE_PATH,datas.PAGE_NAME,datas.IDA)">
                            <i class="h-icon fas fa-bookmark"></i>
                            {{datas.BTN_NAME}}
                        </div>
                    </div>
                </div>
            </div>

        </div>
        <div class="part part-2-3">

        </div>
    </div>*@

