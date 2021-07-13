﻿

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


                if (datas.data.menuid == '') {
                    //window.location = "/AUTHEN/FRM_DATA_REQUEST"; // << ปิดเวลาอัพขึ้นเซิร์ฟ เปิดแถวล่าง

                } else {
                    //window.location = "/Master_Page/MAIN_MASTER"; // << ปิดเวลาอัพขึ้นเซิร์ฟ เปิดแถวล่าง
                    //window.location = "/DRUG_DROPBOX/HOME/FRM_STAFF_LIST"; 
                }
                
            }
            else {

                window.location = "http://privus.fda.moph.go.th";
              //  
            }
            //LOAD_JS();
        }, function () { });

      //  GET_LIST_WAIT();
        var getData_LIST = CENTER_SV.SETMODEL_LIST();
        getData_LIST.then(function (datas) {
            $scope.DOC_LIST = datas.data;
        }, function () { });
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

    $scope.BTN_LOT_RELEASE = function (Month, Year) {
        var getdata = CENTER_SV.GET_LOT_RELEASE(Month, Year);
        getdata.then(function (datas) {
            $scope.data = datas.data.RESULT;
        });
    };

    $scope.UPLOAD_PDFs = function (values) {
        var files = values.FILE_DATA;
        var ADDFILE = CENTER_SV.UPLOAD_PDF(CITIZEN_NO, TOKEN, files);
        ADDFILE.then(function (datas) {
            var result = datas.data;
            if (result.MSG_RESULT == "ERR") {
                ERR_DATA('การบันทึกไฟล์ของท่านมีปัญหา');
            }
            else if (result.MSG_RESULT == "SUCCESS") {
                values.PATH = result.DATA_VALUE;
                values.FLAG = "PASS";
                $scope.Upload = "PASS";
            }
            OPEN_BUTTON();
        }, function () {
            ERR_DATA('การบันทึกไฟล์ของท่านมีปัญหา');
            OPEN_BUTTON();
        });


    };

    $scope.ADD_DATA = function () {
        var getData = CENTER_SV.UPDATE_BOX_INV($scope.DOC, $scope.INV_LIST);
        getData.then(function (datas) {
            var TR_ID = QueryString('TR_ID');
            $scope.filedata = [];
            var obj = $scope.DOC_LIST.FILE_LISTs;
            angular.forEach(obj, function (value, key) {
                var DES = value.DES;
                var FILEs = value.FILE_DATA;
                value.TR_ID = TR_ID;
                value.FILE_DATA = '';

            });

            var ADDFILE = CENTER_SV.UPLOAD_PDF_V2($scope.DOC_LIST.FILE_LISTs, $scope.filedata);
            ADDFILE.then(function (datas) {
                success_data('ดำเนินการแก้ไขเรียบร้อย');
                REDIRECT("/HOME/FRM_CUSTOMER_LIST");
            }, function () {

                success_data('ดำเนินการแก้ไขเรียบร้อย');
            });

        }, function () { });
    };

    $scope.ADD_FILE_LIST = function () {
        var obj = {
            TR_ID: '',
            DES: '',
            FILENAME: '',
            FILE_DATA: '',
            PATH: '',
            FLAG: ''
        };
        $scope.DOC_LIST.FILE_LISTs.push(obj);
    };

    $scope.deleteRow = function (datas, i) {
        if (datas.PIORITY == 'HIGH') {
            ERR_DATA(datas.DES + ' : เป็นเอกสารบังคับไม่สามารถลบออกได้');
        }
        else if (datas.PIORITY == 'LOW') {

            ERR_DATA(datas.DES + ' : ไม่สามารถลบออกได้');
        }
        else {
            $scope.DOC_LIST.FILE_LISTs.splice(i, 1);
        }
    };

}).controller('appController', ['$scope', function ($scope) {
    $scope.$on('LOAD', function () { $scope.loading = true; alert('1'); });
    $scope.$on('UNLOAD', function () { $scope.loading = false; alert('2'); });
}]);



