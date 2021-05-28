app.controller('CERT_GMP_CTRL', function ($scope, CENTER_SV, $http, $location) {

    //CHK_TOKEN();
    var LCN_IDA = sessionStorage.LCN_IDA;
    var LCT_IDA = sessionStorage.LCT_IDA;
    var PROCESS = sessionStorage.DH_PROCESS_ID;
    var CITIZEN = '0000000000000';


    pageload();

    function pageload() {

        var data_CNT = CENTER_SV.SP_MASTER_sysisocnt();
        data_CNT.then(function (datas) {
            $scope.CNT_LIST = datas.data;
         
        }, function () { });

        var data_REF_CERT = CENTER_SV.SP_MASTER_CER_PK_BY_FK_IDA(24153);
        data_REF_CERT.then(function (datas) {
            $scope.REF_CERT = datas.data;
           
        }, function () { });

        var data_HEADER_CERT = CENTER_SV.SP_SYSLCNSNM_BY_LCNSID_AND_IDENTIFY('0000000000000' , '');
        data_HEADER_CERT.then(function (datas) {
            $scope.LCN_NAME = datas.data;
           
        }, function () { });

        
        var data_LCN_LCT = CENTER_SV.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(113416);
        data_LCN_LCT.then(function (datas) {
            $scope.LCN_LCT = datas.data;
           
        }, function () { });

        var data_LCN_SHOW = CENTER_SV.GET_LCNNO_SHOW(66254);
        data_LCN_SHOW.then(function (datas) {
            $scope.LCNNO_SHOW = datas.data.LCNNO_SHOW;
            $scope.TYPE_IMPORT = datas.data.TYPE_IMPORT;
    
        }, function () { });

        if (PROCESS == '31') {
            $scope.INPUT = SET_URL_SV('../CERT/INPUT_GMP');
        }
    }
}).controller('appController', ['$scope', function ($scope) {
    $scope.$on('LOAD', function () { $scope.loading = true; alert('1'); });
    $scope.$on('UNLOAD', function () { $scope.loading = false; alert('2'); });
}]);