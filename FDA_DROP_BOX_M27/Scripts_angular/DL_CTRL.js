app.controller('DL_CTRL', function ($scope, CENTER_SV, $http, $location) {

    //CHK_TOKEN();
    pageload();

    function pageload() {
        var data_CNT = CENTER_SV.SP_MASTER_sysisocnt();
        data_CNT.then(function (datas) {
            $scope.CNT_LIST = datas.data;
            $scope.states = loadClaim($scope.CNT_LIST);
        }, function () { });

        var data_UNIT_PHYSIC = CENTER_SV.SP_DRUG_UNIT_PHYSIC();
        data_UNIT_PHYSIC.then(function (datas) {
            $scope.UNIT_PHYSIC = datas.data;
            $scope.states = loadClaim($scope.UNIT_PHYSIC);
        }, function () { });
    }


}).controller('appController', ['$scope', function ($scope) {
    $scope.$on('LOAD', function () { $scope.loading = true; alert('1'); });
    $scope.$on('UNLOAD', function () { $scope.loading = false; alert('2'); });
}]);