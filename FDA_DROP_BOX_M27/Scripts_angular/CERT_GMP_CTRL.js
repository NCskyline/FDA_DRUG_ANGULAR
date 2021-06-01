app.controller('CERT_GMP_CTRL', function ($scope, CENTER_SV, $http, $location) {

    //CHK_TOKEN();
    var LCN_IDA = sessionStorage.LCN_IDA;
    var LCT_IDA = sessionStorage.LCT_IDA;
    var PROCESS = QueryString("PROCESS");
    var CITIZEN = '0000000000000';


    pageload();

    function pageload() {

        var data_CNT = CENTER_SV.SP_MASTER_sysisocnt();
        data_CNT.then(function (datas) {
            $scope.CNT_LIST = datas.data;
         
        }, function () { });

        var data_HEADER_CERT = CENTER_SV.SP_SYSLCNSNM_BY_LCNSID_AND_IDENTIFY(CITIZEN , '');
        data_HEADER_CERT.then(function (datas) {
            $scope.LCN_NAME = datas.data;
           
        }, function () { });

        
        var data_LCN_LCT = CENTER_SV.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(LCT_IDA);
        data_LCN_LCT.then(function (datas) {
            $scope.LCN_LCT = datas.data;
           
        }, function () { });

        var data_LCN_SHOW = CENTER_SV.GET_LCNNO_SHOW(LCN_IDA);
        data_LCN_SHOW.then(function (datas) {
            $scope.LCNNO_SHOW = datas.data.LCNNO_SHOW;
            $scope.TYPE_IMPORT = datas.data.TYPE_IMPORT;
    
        }, function () { });

        if (PROCESS == '31') {
            $scope.INPUT = SET_URL_SV('../CERT/INPUT_GMP');
        }
        else if (PROCESS == '32') {
            $scope.INPUT = SET_URL_SV('../CERT/INPUT_ISO');
        }
        else if (PROCESS == '33') {
            $scope.INPUT = SET_URL_SV('../CERT/INPUT_HACCP');
        }
        else if (PROCESS == '34') {
            $scope.INPUT = SET_URL_SV('../CERT/INPUT_CERT_OTHER');
        }
        else if (PROCESS == '36') {
            $scope.INPUT = SET_URL_SV('');
        }

        LIST_GMP();
    }

    function LIST_GMP() {
        var obj = {
           ddd:''
        };

        $scope.LIST_GMP.push(obj);
    }





}).controller('appController', ['$scope', function ($scope) {
    $scope.$on('LOAD', function () { $scope.loading = true; alert('1'); });
    $scope.$on('UNLOAD', function () { $scope.loading = false; alert('2'); });
}]);