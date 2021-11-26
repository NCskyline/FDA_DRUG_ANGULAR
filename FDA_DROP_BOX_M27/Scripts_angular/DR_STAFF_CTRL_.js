
app.controller('DR_STAFF_CTRL', function ($scope, CENTER_SV, $http, $location) {

    CHK_TOKEN();

    pageload();

    function dropdown() {
        $(document).ready(function () {
            $('select').selectpicker('refresh');
        });
    }

    function pageload() {

        //$scope.INPUT = SET_URL_SV('/DR/INPUT_YOR_1');

    }






}).controller('appController', ['$scope', function ($scope) {
    $scope.$on('LOAD', function () { $scope.loading = true; alert('1'); });
    $scope.$on('UNLOAD', function () { $scope.loading = false; alert('2'); });
    }]);

function Openmodel() {
    $('#exampleModalLong').modal('toggle'); // เป็นคำสั่งเปิดปิด
}
