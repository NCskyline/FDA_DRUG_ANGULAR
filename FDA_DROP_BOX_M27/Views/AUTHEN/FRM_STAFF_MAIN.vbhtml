<div>
    <div class="part part-1-3">
        <div class="page-header">
            <div class="card-tab-control page-header-content header-elements-md-inline container">
                @*<div class="tab-content" ng-repeat="datas in fildata  = (FULL_MODEL.SET_PAGE_MAIN | filter: {PROCESS_ID : 203000})">*@
                <div class="tab-content" ng-repeat="datas in SET_PAGE_MAIN1">
                    <div ng-if="datas.PROCESS_ID == POPUP_PROCESS_ID && datas.TYPE == 2 && datas.TYPE != 99">
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
                @*<div class="tab-content" ng-repeat="datas in fildata  = (FULL_MODEL.SET_PAGE_MAIN | filter: {PROCESS_ID : 203000})">*@
                <div class="tab-content" ng-repeat="datas in SET_PAGE_MAIN2">
                    <div ng-if="datas.PROCESS_ID == POPUP_PROCESS_ID && datas.TYPE == 2 && datas.TYPE != 99">
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
                @*<div class="tab-content" ng-repeat="datas in fildata  = (FULL_MODEL.SET_PAGE_MAIN | filter: {PROCESS_ID : 203000})">*@
                <div class="tab-content" ng-repeat="datas in SET_PAGE_MAIN3">
                    <div ng-if="datas.PROCESS_ID == POPUP_PROCESS_ID && datas.TYPE == 2 && datas.TYPE != 99">
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
                @*<div class="tab-content" ng-repeat="datas in fildata  = (FULL_MODEL.SET_PAGE_MAIN | filter: {PROCESS_ID : 203000})">*@
                <div class="tab-content" ng-repeat="datas in SET_PAGE_MAIN4">
                    <div ng-if="datas.PROCESS_ID == POPUP_PROCESS_ID && datas.TYPE == 2 && datas.TYPE != 99">
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
    </div>
    <div class="part part-2-3">

    </div>
</div>
