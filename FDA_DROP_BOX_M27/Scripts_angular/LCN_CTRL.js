app.controller('LCN_CTRL', function ($scope, CENTER_SV, $http, $location) {

    $scope.CITIZEN = "";
    $scope.lcnno = "";
    var LCN_IDA = sessionStorage.LCN_IDA;
    var LCT_IDA = 117194; //sessionStorage.LCT_IDA;  //
    $scope.PROCESS = QueryString("PROCESS");
    var CITIZEN = '0105527028430';//'0105527028430';0000000000000
    var BSN_IDENTIFY = "";
    var IDENTIFY = "0000000000000";
    var HEAD_LCN_IDA = 49409;
    //var LCT_IDA = 117194;
    

    Pageload();
    LOAD_MODEL();

    function LOAD_MODEL() {

        var data = CENTER_SV.GET_FULLDATA_LCN();
        data.then(function (datas) {
            $scope.FULL_MODEL = datas.data;

        }, function () { });
    }

    function Pageload() {

        //listree();
    //    var data_prefix = CENTER_SV.SP_SYSPREFIX();
    //    data_prefix.then(function (datas) {
    //        $scope.PREFIX = datas.data;

    //    }, function () { });

    //}
    var data_prefix = CENTER_SV.SP_SYSPREFIX_PERSON();
    data_prefix.then(function (datas) {
        $scope.PREFIX = datas.data;

    }, function () { });

}


    $scope.BTN_MENU = function (process) {

        if (process == '101' || process == '103' || process == '104' || process == '105' || process == '106' || process == '107' || process == '108' || process == '109') {
            $scope.FULL_MODEL.PROCESS = process;
            $scope.SUB_PATH = SET_URL_SV('../LCN/FRM_LCN_DRUG');
        }
    };

    $scope.BTN_INPUT = function () {

        if ($scope.FULL_MODEL.PROCESS == '101') {
            REDIRECT('../LCN/INPUTdalcn_output_1');
        } else if ($scope.FULL_MODEL.PROCESS == '103') {
            REDIRECT('../LCN/INPUTdalcn_output_3');
        } else if ($scope.FULL_MODEL.PROCESS == '104') {
            REDIRECT('../LCN/INPUTdalcn_output_4');
        } else if ($scope.FULL_MODEL.PROCESS == '105') {
            REDIRECT('../LCN/INPUT_NORYOR_1');
        } else if ($scope.FULL_MODEL.PROCESS == '106') {
            REDIRECT('../LCN/INPUT_PORYOR_1');
        } else if ($scope.FULL_MODEL.PROCESS == '107' || $scope.FULL_MODEL.PROCESS == '108' || $scope.FULL_MODEL.PROCESS == '109') {           
            REDIRECT('/LCN/INPUT_DA_YORBOR?PROCESS=' + $scope.FULL_MODEL.PROCESS);
        }
    };

    $scope.YORBOR = function () {
        if ($scope.PROCESS == '107') {
            $scope.headLCN = 'ขายยาแผนโบราณ';
        } else if ($scope.PROCESS == '108') {
            $scope.headLCN = 'นำหรือสั่งยาแผนโบราณเข้ามาในราชอาณาจักร';
        } else if ($scope.PROCESS == '109') {
            $scope.headLCN = 'ผลิตยาแผนโบราณ';
        }
    };

    $scope.Search_lcnno = function (CITIZEN, lcnno, pvncd) {
        var GetData = CENTER_SV.SP_GET_DATA_LCN(CITIZEN, lcnno, pvncd);
        GetData.then(function (datas) {
            $scope.LIST_LCN = datas.data;
        }, function () { });
    };

    $scope.SELECT_LCN = function (datas) {
        sessionStorage.CITIZEN_ID_AUTHORIZE = datas.CITIZEN;
        sessionStorage.LCNNO = datas.lcnno;

        var url = "../LCN/FRM_LCN_STAFF_LCN_INFORMATION";
        REDIRECT(url);
    };

    $scope.pageload = function () {
        var MODLE_LCN = CENTER_SV.GET_LCN_INFORMATION_INPUT(BSN_IDENTIFY, IDENTIFY, LCT_IDA, HEAD_LCN_IDA);
        MODLE_LCN.then(function (datas) {

            $scope.LIST_LCN = datas.data;
            $scope.LIST_LCN.PROCESS = PROCESS;
        }, function () { });

        
        var data_keep = CENTER_SV.SP_LOCATION_ADDRESS_by_LOCATION_TYPE_CD_and_LCNSIDV2_KEEP('2', IDENTIFY);
        data_keep.then(function (datas) {
            $scope.REF_LOCATION_KEEP = datas.data;

        }, function () { });


    };





    //var myApp = angular.module("ANGULAR_APP", []);
    //myApp.controller("LCN_CTRL", function ($scope) {
    //    $scope.BSN_IDEN = '';
    //    $scope.getData_bsn = function (LIST_LCN) {
    //        BSN_IDENTIFY = angular.copy(LIST_LCN.BSN_IDENTIFY);
    //    };
    //});



    ////var BSN_IDEN = document.getElementsByName('txt_bsn_identify')[0].value
    //$scope.Search_BSN = function () {
    //    var GetData = CENTER_SV.GET_LCN_INFORMATION_BSN_INPUT(BSN_IDENTIFY);
    //    GetData.then(function (datas) {
    //        $scope.LIST_LCN = datas.data;
    //    }, function () { });
    //};
    $scope.getdetails = function (IDA) {

        var Data_location = CENTER_SV.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(IDA);
        Data_location.then(function (datas) {
            $scope.LIST_LABEL = datas.data;
            $scope.LIST_LABEL.fulladdr = datas.data[0].fulladdr;
        }, function () { });

    };

    $scope.BTN_Search_BSN = function (BSN_IDENTIFY) {

        var MODLE_LCN = CENTER_SV.GET_LCN_INFORMATION_INPUT(BSN_IDENTIFY, IDENTIFY, LCT_IDA, HEAD_LCN_IDA);
        MODLE_LCN.then(function (datas) {
            $scope.LIST_LCN = datas.data;
            $scope.LIST_LCN.PROCESS = PROCESS;
        }, function () { });
    };

    $scope.BTN_BACK = function () {
       
        REDIRECT('../LCN/FRM_LCN_NEWS');
    };
});