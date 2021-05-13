app.controller('DH_CTRL', function ($scope, CENTER_SV, $http, $location) {

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

    }


}).controller('appController', ['$scope', function ($scope) {
    $scope.$on('LOAD', function () { $scope.loading = true; alert('1'); });
    $scope.$on('UNLOAD', function () { $scope.loading = false; alert('2'); });
}]);