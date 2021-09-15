

<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/LCN_CTRL.js"></script>

<div class="ic" ng-controller="LCN_CTRL" ng-app="ANGULAR_APP" ng-init="GET_LCT_LIST()">

    <div style="font-family:'Taviraj';width:100%">
        <div class="title-ic">
            รายการสถานที่ <i class="tt-ic fas fa-bookmark"></i>
        </div>
        <hr />
        <div class="row">
            <div class="col-sm-12">
                <div class="search-item">
                    <input class="search-input" type="text" placeholder="ค้นหา..." ng-model="filter">
                    <i class="fa fa-search search-icon"></i>
                </div>
            </div>
        </div>
        <hr />
        <div class="row">
            <div class="col-sm-12">
                <div class="card" ng-repeat="datas in LIST_LCTS | filter : filter" style=" border-top: 10px solid #277210;">

                    <div class="card-body" style="padding:unset;font-size: 15px;">
                        <div class="row">
                            <div class="col-sm-10">
                                <div class="row">
                                    <div class="col-sm-2 set-topic">
                                        ชื่อสถานที่ :
                                    </div>
                                    <div class="col-sm-10">
                                        {{datas.thanameplace}}
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-sm-2 set-topic">
                                        ที่อยู่ :
                                    </div>
                                    <div class="col-sm-10">
                                        {{datas.fulladdr}}
                                    </div>
                                </div>
                            </div>
                            <div class="col-sm-2">
                                <div class="row set-a-btn">
                                    <div class="col-sm-12 ">
                                        <span class="fa fa-eye"></span>
                                        <a ng-click="SELECT_LCTS(datas)">
                                            เลือก
                                        </a>
                                    </div>
                                </div>
                            </div>
                        </div>

                    </div>

                </div>
            </div>
        </div>
    </div>
</div>
