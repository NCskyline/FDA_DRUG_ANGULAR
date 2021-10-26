app.controller('LCN_STAFF_CTRL', function ($scope, CENTER_SV, $http, $location) {
    CHK_TOKEN();

    Pageload();

    function Pageload() {

    }

    $scope.LoadPreview = function () {
        var MODLE_LCN = CENTER_SV.GET_LCN_INFORMATION_INPUT_V2(sessionStorage.CITIZEN_ID_AUTHORIZE, sessionStorage.LCT_IDA);
        MODLE_LCN.then(function (datas) {

            $scope.LIST_LCN = datas.data;
            $scope.LIST_LCN.PROCESS = sessionStorage.PROCESS;
            $scope.LIST_LCN.session = sessionStorage;
            //$scope.LIST_LCN.PROCESS = "101";
        }, function () { });
    };
});