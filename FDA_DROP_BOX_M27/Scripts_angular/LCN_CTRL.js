app.controller('LCN_CTRL', function ($scope, CENTER_SV, $http, $location) {

    $scope.CITIZEN = "";
    $scope.lcnno = "";

    Pageload();

    function Pageload() {


    }
    

    $scope.Search_lcnno = function (CITIZEN, lcnno, pvncd) {
        var GetData = CENTER_SV.SP_GET_DATA_LCN(CITIZEN, lcnno, pvncd);
        GetData.then(function (datas) {
            $scope.LIST_LCN = datas.data;
        }, function () { });
    };

    $scope.SELECT_LCN = function (datas) {
        sessionStorage.CITIZEN_ID_AUTHORIZE = datas.CITIZEN;
        sessionStorage.LCNNO = datas.lcnno;

        var url = "../LCN/FRM_LCN_STAFF_LCN_INFORMATION";
        REDIRECT(url);
    };
});