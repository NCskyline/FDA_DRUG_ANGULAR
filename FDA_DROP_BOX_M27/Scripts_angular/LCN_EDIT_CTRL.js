app.controller('LCN_EDIT_CTRL', function ($scope, CENTER_SV, $http, $location) {

    $scope.CITIZEN = "";
    $scope.lcnno = "";
    var IDA = sessionStorage.IDA;
    var LCN_IDA = sessionStorage.LCN_IDA;
    var LCT_IDA = sessionStorage.LCT_IDA;
    var PROCESS = QueryString("PROCESS");
    var CITIZEN = '0105527028430';//'0105527028430';0000000000000
    var BSN_IDENTIFY = "";
    IDA = 66254;
    var IDENTIFY = '0107542000011';
    var LCT_IDA = 117194;
    Pageload();
    //LOAD_MODEL();
    //MODEL_EDIT_LCN
    //function LOAD_MODEL() {

    //    var data = CENTER_SV.GET_FULLDATA_LCN_EDIT();
    //    data.then(function (datas) {
    //        $scope.FULL_MODEL = datas.data;

    //    }, function () { });
    //}
    function Pageload() {
        var MODEL_EDIT_LCN = CENTER_SV.SETMODEL_EDIT_LCN();
        MODEL_EDIT_LCN.then(function (datas) {

            $scope.LIST_EDIT_LCN = datas.data;

        }, function () { });  


        var data_keep = CENTER_SV.SP_LOCATION_ADDRESS_by_LOCATION_TYPE_CD_and_LCNSIDV2_KEEP('2', IDENTIFY);
        data_keep.then(function (datas) {
            $scope.REF_LOCATION = datas.data;

    }, function () { });

        var data_CNT = CENTER_SV.SP_MASTER_sysisocnt();
        data_CNT.then(function (datas) {
            $scope.CNT_LIST = datas.data;

        }, function () { });


        //var GET_LCN_EDIT = CENTER_SV.GET_LCN_EDIT(IDA);
        //GET_LCN_EDIT.then(function (datas) {

        //    $scope.LIST_EDIT_LCN = datas.data;


        //}, function () { });
    }

    
    $scope.Bind_Data_ddl = function (IDA) {

        var Data_location = CENTER_SV.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(IDA);
        Data_location.then(function (datas) {
            $scope.LIST_LABEL = datas.data;
            //$scope.LIST_EDIT_LCN.fulladdr = datas.data.fulladdr;
        }, function () { });
    };
    
    $scope.getdetails = function (IDA) {
       
        if (IDA == "0") {
            var Data_location = CENTER_SV.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(IDA);
            Data_location.then(function (datas) {
                $scope.LIST_LABEL = datas.data;
                $scope.LIST_LABEL.fulladdr = datas.data[0].fulladdr; 
            }, function () { });
           
        }
        else {
            var Data_location = CENTER_SV.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(IDA);
            Data_location.then(function (datas) {
                $scope.LIST_LABEL = datas.data;
                $scope.LIST_LABEL.fulladdr = datas.data[0].fulladdr;
            }, function () { });

        }
    
    };

    $scope.BTN_CLICKs = function (IDA) {
        alert(IDA);
    };

});