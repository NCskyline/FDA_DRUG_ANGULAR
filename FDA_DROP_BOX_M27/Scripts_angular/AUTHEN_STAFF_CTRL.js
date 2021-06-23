

app.controller('AUTHEN_STAFF_CTRL', function ($scope, CENTER_SV, $http, $location) {


    //$scope.loading = true;

    $scope.DOC_ID = 0;
    $scope.DOC_TITLE = "TEST";
    $scope.IS_USE = 0;

    pageload();

    function pageload() {
       
        //var token = QueryString("Token");
        var token = "PASS";
        sessionStorage.token = token;

        var getData = CENTER_SV.GET_AUTHEN(token);
    

        getData.then(function (datas) {
            $scope.AUTHEN = datas.data;
            if (datas.data.CODE == '900') {
                sessionStorage.CITIZEN_ID = datas.data.CITIZEN_ID;
                sessionStorage.CITIZEN_ID_AUTHORIZE = datas.data.CITIZEN_ID_AUTHORIZE;
                sessionStorage.THANM = datas.data.THANM;

                $scope.SET_MAIN_PAGE1 = datas.data.SET_MAIN_PAGE1;
                $scope.SET_MAIN_PAGE2 = datas.data.SET_MAIN_PAGE2;
                $scope.SET_MAIN_PAGE3 = datas.data.SET_MAIN_PAGE3;
                $scope.SET_MAIN_PAGE4 = datas.data.SET_MAIN_PAGE4;



                //window.location = "/Master_Page/MAIN_MASTER"; // << ปิดเวลาอัพขึ้นเซิร์ฟ เปิดแถวล่าง
                //window.location = "/DRUG_DROPBOX/HOME/FRM_STAFF_LIST"; 
            }
            else {

                window.location = "http://privus.fda.moph.go.th";
              //  
            }
            //LOAD_JS();
        }, function () { });

      //  GET_LIST_WAIT();
    }

    $scope.BTN_SUB_MENU_CLICK = function (BTN_GROUP, IDgroup, SEQ) {

        if (BTN_GROUP == '0') {
            gg;
        } else if (BTN_GROUP == '1') {
            gg;
        } else if (BTN_GROUP == '2') {
            gg;
        } else if (BTN_GROUP == '3') {

            if (SEQ == '1') {
                $scope.SUB_MAIN_PAGE = SET_URL_SV('../DH_STAFF/FRM_STAFF_CER_MAIN');
            } else if (SEQ == '2') {
                $scope.SUB_MAIN_PAGE = SET_URL_SV('../DH_STAFF/FRM_DH_MAIN_STAFF');
            } else if (SEQ == '3') {
                $scope.SUB_MAIN_PAGE = SET_URL_SV('../DH_STAFF/FRM_CHEMICAL_STAFF_MAIN');
            }
        }
    };


}).controller('appController', ['$scope', function ($scope) {
    $scope.$on('LOAD', function () { $scope.loading = true; alert('1'); });
    $scope.$on('UNLOAD', function () { $scope.loading = false; alert('2'); });
}]);



