app.controller('CERT_GMP_CTRL', function ($scope, CENTER_SV, $http, $location) {

    //CHK_TOKEN();
    pageload();

    function pageload() {


        var data_CNT = CENTER_SV.SP_MASTER_sysisocnt();
        data_CNT.then(function (datas) {
            $scope.CNT_LIST = datas.data;
            $scope.states = loadClaim($scope.CNT_LIST);
        }, function () { });

        var data_REF_CERT = CENTER_SV.SP_MASTER_CER_PK_BY_FK_IDA(24153);
        data_REF_CERT.then(function (datas) {
            $scope.REF_CERT = datas.data;
            $scope.states = loadClaim($scope.REF_CERT);
        }, function () { })

        var data_HEADER_CERT = CENTER_SV.SP_SYSLCNSNM_BY_LCNSID_AND_IDENTIFY('0000000000000' , '');
        data_HEADER_CERT.then(function (datas) {
            $scope.LCN_NAME = datas.data;
            $scope.states = loadClaim($scope.LCN_NAME);
        }, function () { })

        
        var data_LCN_LCT = CENTER_SV.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(113416);
        data_LCN_LCT.then(function (datas) {
            $scope.LCN_LCT = datas.data;
            $scope.states = loadClaim($scope.LCN_LCT);
        }, function () { })

        var data_LCN_SHOW = CENTER_SV.GET_LCNNO_SHOW(66254);
        data_LCN_SHOW.then(function (datas) {
            $scope.LCN_SHOW = datas.data;
            $scope.states = loadClaim($scope.LCN_SHOW);
        }, function () { })
    }
}).controller('appController', ['$scope', function ($scope) {
    $scope.$on('LOAD', function () { $scope.loading = true; alert('1'); });
    $scope.$on('UNLOAD', function () { $scope.loading = false; alert('2'); });
}]);