app.controller('DH_CTRL', function ($scope, CENTER_SV, $http, $location) {

    //CHK_TOKEN();
    pageload();

    function pageload() {
        

        var data_CNT = CENTER_SV.GETDATA_SYSISOCNT();
        data_CNT.then(function (datas) {
            $scope.CNT_LIST = datas.data;
            $scope.states = loadClaim($scope.CNT_LIST);
        }, function () { });
    }


}).controller('appController', ['$scope', function ($scope) {
    $scope.$on('LOAD', function () { $scope.loading = true; alert('1'); });
    $scope.$on('UNLOAD', function () { $scope.loading = false; alert('2'); });
}]);