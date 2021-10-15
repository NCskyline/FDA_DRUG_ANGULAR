

app.controller('AUTHEN_CTRL', function ($scope, CENTER_SV, $http, $location) {


    $scope.loading = true;
    //var Trigger = QueryString("Trigger");
    //var Trigger = "DH";
    $scope.DOC_ID = 0;
    $scope.DOC_TITLE = "TEST";
    $scope.IS_USE = 0;


    $scope.pageload = function (TYPE) {
       
        var token = '';
        if (location.hostname == 'localhost') {
            token = "PASS"; //"PASS";
        } else {
            token = QueryString("Token");
        }
        
        //var token = "PASS";
        sessionStorage.token = token;

        var getData = CENTER_SV.GET_AUTHEN_DATA(token);

        getData.then(function (datas) {
            $scope.AUTHEN = datas.data;
            if (datas.data.CODE == '900') {

                
                sessionStorage.CITIZEN_ID = datas.data.CITIZEN_ID;
                sessionStorage.CITIZEN_ID_AUTHORIZE = datas.data.CITIZEN_ID_AUTHORIZE;
                sessionStorage.THANM = datas.data.THANM;
                sessionStorage.COMPANY_NAME = datas.data.COMPANY_NAME;
                sessionStorage.TOKEN = datas.data.TOKEN;
                sessionStorage.GROUPS = datas.data.GROUPS;
                sessionStorage.PVCODE = datas.data.PVCODE;
                if (location.hostname == 'localhost') {

                    if (TYPE == 'LCN') {
                        sessionStorage.PROCESS = '';
                        window.location = "/LCN/FRM_LCN_NEWS";
                    } else if (TYPE == 'DH') {
                        window.location = "/DH/FRM_MAIN_PAGE_PHESAJ";
                    } else if (TYPE == 'DR') {
                        window.location = "/DH/FRM_MAIN_PAGE_PRODUCT";
                    }

                } else {

                    if (TYPE == 'LCN') {
                        //window.location = "/FDA_DRUG_ANGULAR_DEMO/LCN/FRM_LCN_NEWS";
                        window.location = "/FDA_DRUG_ANGULAR_DEMO/LCN/FRM_LCN_NEWS";

                    } else if (TYPE == 'DH') {
                        window.location = "/FDA_DRUG_ANGULAR_DEMO/DH/FRM_MAIN_PAGE_PHESAJ";  // << ปิดเวลาอัพขึ้นเซิร์ฟ เปิดแถวล่าง
                    } else if (TYPE == 'DR') {
                        window.location = "/FDA_DRUG_ANGULAR_DEMO/DH/FRM_MAIN_PAGE_PRODUCT";
                    }
                    
                }
                // window.location = "/FDA_DRUG_ANGULAR_DEMO/DH/FRM_MAIN_PAGE_PHESAJ";
            }
            else {

                window.location = "http://privus.fda.moph.go.th";
                //  
            }
            //LOAD_JS();
        }, function () { });

        //  GET_LIST_WAIT();
    };


}).controller('appController', ['$scope', function ($scope) {
    $scope.$on('LOAD', function () { $scope.loading = true; alert('1'); });
    $scope.$on('UNLOAD', function () { $scope.loading = false; alert('2') });
}]);



