app.controller('MASTER_DATA_CTRL', function ($scope, CENTER_SV, $http, $location) {

    $scope.BTN_ADD_LOCATION = function () {
        REDIRECT('/MASTER_DATA/FRM_STAFF_LOCATION_MANUAL_INSERT');
    };

    $scope.BTN_BACK = function () {
        REDIRECT(/MASTER_DATA/FRM_STAFF_LOCATION_MANUAL_MAIN);
    }
}