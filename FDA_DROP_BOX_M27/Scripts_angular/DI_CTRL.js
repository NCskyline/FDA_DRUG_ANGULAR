app.controller('DI_CTRL', function ($scope, CENTER_SV, $http, $location) {

    CHK_TOKEN;

    var PROCESS_ID = QueryString('PROCESS');

    $scope.SELECT_DL = function () {
        sessionStorage.PROCESS_ID = PROCESS_ID;
        REDIRECT('/DR/FRM_MAIN_PAGE_PRODUCT');
    };



}).controller('appController', ['$scope', function ($scope) {
    $scope.$on('LOAD', function () { $scope.loading = true; alert('1'); });
    $scope.$on('UNLOAD', function () { $scope.loading = false; alert('2'); });
}]);