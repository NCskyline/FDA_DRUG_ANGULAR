app.filter('startFrom', function () {
    return function (input, start) {
        if (input) {
            start = +start;
            return input.slice(start);
        }
        return [];
    };
});
app.controller('CERT_GMP_CTRL', function ($scope, CENTER_SV, $http, $location) {

    CHK_TOKEN();
    var LCN_IDA = sessionStorage.LCN_IDA;
    var IDA = sessionStorage.IDA;
    var PREVIEW_CERT_IDA = sessionStorage.PREVIEW_CERT_IDA;
    var LCT_IDA = sessionStorage.LCT_IDA;
    var PROCESS = sessionStorage.DH_PROCESS_ID;
    var CITIZEN = sessionStorage.IDENTIFY; 
    var STAGE = sessionStorage.STAGE;
    $scope.GMP_CHEM = [];
    $scope.PDF = [];

    $scope.currentPage = 0;
    $scope.paging = {
        total: 10,
        current: 1,
        onPageChanged: loadPages
    };
    function loadPages() {
        console.log('Current page is : ' + $scope.paging.current);

        // TODO : Load current page Data here

        $scope.currentPage = $scope.paging.current;
    }

    Full_Model();
    pageload();
    //LIST_GMP();
    

    function pageload() {

        var data_CNT = CENTER_SV.SP_MASTER_sysisocnt();
        data_CNT.then(function (datas) {
            $scope.CNT_LIST = datas.data;
            dropdown();
        }, function () { });

        var MODLE_GMP = CENTER_SV.SETMODEL_DH();
        MODLE_GMP.then(function (datas) {
            
            $scope.LIST_GMP = datas.data;
            $scope.LIST_GMP.session = sessionStorage;

        }, function () { });

        var data_HEADER_CERT = CENTER_SV.SP_SYSLCNSNM_BY_LCNSID_AND_IDENTIFY(CITIZEN , '');
        data_HEADER_CERT.then(function (datas) {
            $scope.LCN_NAME = datas.data;
           
        }, function () { });

        var getData_LIST = CENTER_SV.SETMODEL_LIST();
        getData_LIST.then(function (datas) {
            $scope.DOC_LIST = datas.data;
        }, function () { });
        
        var data_LCN_LCT = CENTER_SV.SP_LOCATION_ADDRESS_by_LOCATION_ADDRESS_IDA(LCT_IDA);
        data_LCN_LCT.then(function (datas) {
            $scope.LCN_LCT = datas.data;
           
        }, function () { });

        var GetdataCHEM = CENTER_SV.SP_MAS_CHEMICAL_by_IOWANM_AND_AORI("", "A");
        GetdataCHEM.then(function (datas) {
            $scope.LIST_CHEM = '';
            var auto = $scope.LIST_CHEM.length;
            $scope.currentPage = 1;
            $scope.entryLimit = 10;
            $scope.noOfPages = Math.ceil($scope.totalItems / $scope.entryLimit);
            $scope.loading_profile = false;
            $scope.product_show = true;
        }, function () { });

        var data_LCN_SHOW = CENTER_SV.GET_LCNNO_SHOW(LCN_IDA);
        data_LCN_SHOW.then(function (datas) {
            $scope.LCNNO_SHOW = datas.data.LCNNO_SHOW;
            $scope.TYPE_IMPORT = datas.data.TYPE_IMPORT;
            $scope.THANAMEPLACE = datas.data.THANAMEPLACE;
            $scope.thanameplace = datas.data.THANAMEPLACE;
            $scope.thanm = datas.data.NAME;
            $scope.fulladdr2 = datas.data.FULL_ADDR;
            $scope.tel = datas.data.TEL;
            $scope.fax = datas.data.FAX;
        }, function () { });

        var Set_PREVIEW = CENTER_SV.GET_PREVIEW_CERT(IDA);
        Set_PREVIEW.then(function (datas) {
            
            $scope.LIST_GMP = datas.data;
            $scope.LIST_GMP.session = sessionStorage;

            var TR_ID = $scope.LIST_GMP.CER.TR_ID;
            var PROCESS = $scope.LIST_GMP.CER.CER_TYPE;
           
            $scope.LIST_GMP.CER.DOCUMENT_DATE = filwill(CHANGE_FORMATDATE(CV_DATE($scope.LIST_GMP.CER.DOCUMENT_DATE)));
            $scope.LIST_GMP.CER.EXP_DOCUMENT_DATE = filwill(CHANGE_FORMATDATE(CV_DATE($scope.LIST_GMP.CER.EXP_DOCUMENT_DATE)));
            $scope.INPUT_CHEM = SET_URL_SV('/CERT/PREVIEW_CHEMICAL');

            var File = CENTER_SV.GETDATA_FILE_TR_ID_TYPE(TR_ID, PROCESS);
            File.then(function (datas) {
                $scope.LIST_File = datas.data;
            }, function () { });

        }, function () { });

        

        if (PROCESS == '31') {
            $scope.INPUT = SET_URL_SV('/CERT/INPUT_GMP');
            $scope.HEADER = 'ลงทะเบียนสถานที่ผลิตด้วยมาตรฐาน GMP (Registration of Manufacturer with GMP Standard)';
        }
        else if (PROCESS == '32') {
            $scope.INPUT = SET_URL_SV('/CERT/INPUT_ISO');
            $scope.HEADER = 'ลงทะเบียนสถานที่ผลิตด้วยมาตรฐาน ISO (Registration of Manufacturer with ISO Standard)';
        }
        else if (PROCESS == '33') {
            $scope.INPUT = SET_URL_SV('/CERT/INPUT_HACCP');
            $scope.HEADER = 'ลงทะเบียนสถานที่ผลิตด้วยมาตรฐาน HACCP (Registration of Manufacturer with HACCP Standard)';
        }
        else if (PROCESS == '34') {
            $scope.INPUT = SET_URL_SV('/CERT/INPUT_PICS');
            $scope.HEADER = 'ลงทะเบียนสถานที่ผลิตด้วยเอกสารหลักฐานการขายไปยังประเทศที่มีระบบคุณภาพที่ อย. ยอมรับ (Registration of Manufacturer with Purchase Order Document from Country with FDA equivalent Quality Control System)';
        }
        else if (PROCESS == '36') {
            $scope.INPUT = SET_URL_SV('/CERT/INPUT_CERT_OTHER');
            $scope.HEADER = 'ลงทะเบียนสถานที่ผลิตด้วยเอกสารอื่นๆ ที่ อย.เห็นชอบ (Registration of Manfacturer with FDA Approved Documents)';
        }  
    }

    function dropdown() {
        $(document).ready(function () {
            $('select').selectpicker('refresh');
        });
    }

    function Full_Model() {

        var MODLE_GMP = CENTER_SV.SETMODEL_DH();
        MODLE_GMP.then(function (datas) {

            $scope.LIST_GMP = datas.data;
            $scope.LIST_GMP.session = sessionStorage;

        }, function () { });
    }

    $scope.CER_EDIT = function () {
        var Set_EDIT = CENTER_SV.GET_PREVIEW_CERT(IDA);
        Set_EDIT.then(function (datas) {

            $scope.LIST_GMP = datas.data;
            $scope.LIST_GMP.session = sessionStorage;

            var TR_ID = $scope.LIST_GMP.CER.TR_ID;
            var PROCESS = $scope.LIST_GMP.CER.CER_TYPE;

            $scope.LIST_GMP.CER.DOCUMENT_DATE = filwill_DATE(CHANGE_FORMATDATEPICKER($scope.LIST_GMP.CER.DOCUMENT_DATE));
            $scope.LIST_GMP.CER.EXP_DOCUMENT_DATE = filwill_DATE(CHANGE_FORMATDATEPICKER($scope.LIST_GMP.CER.EXP_DOCUMENT_DATE));
            $scope.INPUT_CHEM = SET_URL_SV('/CERT/PREVIEW_CHEMICAL');

            var File = CENTER_SV.GETDATA_FILE_TR_ID_TYPE(TR_ID, PROCESS);
            File.then(function (datas) {
                $scope.LIST_File = datas.data;
            }, function () { });

        }, function () { });
    };

    $scope.BTN_ADD_CHEM = function (datas) {
        
        var obj = {

            IDA: Int32Array,
            ROW_ID:'',
            CAS_ID: datas.IDA,
            CAS_NO:'',
            CAS_NAME: datas.iowanm,
            FK_IDA: Int32Array,
            TR_ID: Int32Array,
            INN_NAME:''
           
        };
        $scope.GMP_CHEM.push(obj);        
    };
   
    $scope.BTN_SEARCH_CHEM = function (IOWANM) {

        var GetdataCHEM = CENTER_SV.SP_MAS_CHEMICAL_by_IOWANM_AND_AORI(IOWANM , "A");
        GetdataCHEM.then(function (datas) {
            $scope.LIST_CHEM = datas.data;

        }, function () { });
    };

    $scope.BTN_SAVE = function () {
        var cEmpty = 0;
        if (PROCESS == '31') {
            if ($scope.LIST_GMP.CER.COUNTRY_ID == 0) {
                cEmpty = cEmpty + 1;
            }
            if ($scope.LIST_GMP.CER.CERTIFICATION_NUMBER_ALL.trim().length < 2) {
                cEmpty = cEmpty + 1;
            }
            if ($scope.LIST_GMP.CER_DETAIL_MANUFACTURE.NAME_ADDRESS.trim().length < 2 ) {
                cEmpty = cEmpty + 1;
            }
            if ($scope.LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_NUMBER.trim().length < 2) {
                cEmpty = cEmpty + 1;
            }

            if ($scope.LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_CITY.trim().length < 2) {
                cEmpty = cEmpty + 1;
            }
            if ($scope.LIST_GMP.CER_DETAIL_MANUFACTURE.COUNTRY_GMP == 0) {
                cEmpty = cEmpty + 1;
            }
            
        }
        else if (PROCESS == '32') {
            if ($scope.LIST_GMP.CER.COUNTRY_ID == 0) {
                cEmpty = cEmpty + 1;
            }

            if ($scope.LIST_GMP.CER_DETAIL_MANUFACTURE.NAME_ADDRESS.trim().length < 2) {
                cEmpty = cEmpty + 1;
            }
            if ($scope.LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_NUMBER.trim().length < 2) {
                cEmpty = cEmpty + 1;
            }

            if ($scope.LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_CITY.trim().length < 2) {
                cEmpty = cEmpty + 1;
            }
            if ($scope.LIST_GMP.CER_DETAIL_MANUFACTURE.COUNTRY_GMP == 0) {
                cEmpty = cEmpty + 1;
            }
            if ($scope.LIST_GMP.CER.CERTIFICATION_NUMBER_ALL.trim().length < 2) {
                cEmpty = cEmpty + 1;
            }
        }
        else if (PROCESS == '33') {
          
            if ($scope.LIST_GMP.CER_DETAIL_MANUFACTURE.NAME_ADDRESS.trim().length < 2) {
                cEmpty = cEmpty + 1;
            }
            if ($scope.LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_NUMBER.trim().length < 2) {
                cEmpty = cEmpty + 1;
            }

            if ($scope.LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_CITY.trim().length < 2) {
                cEmpty = cEmpty + 1;
            }
            if ($scope.LIST_GMP.CER.CERTIFICATION_NUMBER_ALL.trim().length < 2) {
                cEmpty = cEmpty + 1;
            }

            if ($scope.LIST_GMP.CER.DEPARTMENT_REGIST_CER_NAME.trim().length < 2) {
                cEmpty = cEmpty + 1;
            }
        }
        else if (PROCESS == '34') {
            if ($scope.LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_NUMBER.trim().length < 2) {
                cEmpty = cEmpty + 1;
            }
            if ($scope.LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_CITY.trim().length < 2) {
                cEmpty = cEmpty + 1;
            }
            if ($scope.LIST_GMP.CER.COUNTRY_ID == 0) {
                cEmpty = cEmpty + 1;
            }
            if ($scope.LIST_GMP.CER_DETAIL_MANUFACTURE.LOCATION_STANDARD == 0) {
                cEmpty = cEmpty + 1;
            }
            if ($scope.LIST_GMP.CER_DETAIL_MANUFACTURE.BUYER_COUNTRY == 0) {
                cEmpty = cEmpty + 1;
            }
            if ($scope.LIST_GMP.CER.BUYER_NAME.trim().length < 2) {
                cEmpty = cEmpty + 1;
            }
            if ($scope.LIST_GMP.CER.BUYER_STANDARD == 0) {
                cEmpty = cEmpty + 1;
            }
        }
        else if (PROCESS == '36') {
            if ($scope.LIST_GMP.CER.CERTIFICATION_NUMBER_ALL.trim().length < 2) {
                cEmpty = cEmpty + 1;
            }
            if ($scope.LIST_GMP.CER.DEPARTMENT_REGIST_CER_DOCNO.trim().length < 2) {
                cEmpty = cEmpty + 1;
            }
            if ($scope.LIST_GMP.CER.COUNTRY_ID == 0) {
                cEmpty = cEmpty + 1;
            }
        }
      
        if (cEmpty == 0) {           
            var Getdata = CENTER_SV.INSERT_CERT_GMP($scope.LIST_GMP, $scope.GMP_CHEM, PROCESS);
            Getdata.then(function (datas) {
                var TR_ID = datas.data.TR_ID;
                var PROCESS = datas.data.PROCESS;
                var obj = $scope.DOC_LIST.FILE_LISTs;
                angular.forEach(obj, function (value, key) {
                    var FILEs = value.FILE_DATA;
                    $scope.PDF.push(FILEs);
                });
                var upload = CENTER_SV.UPLOAD_PDF_ATTACH($scope.DOC_LIST.FILE_LISTs, TR_ID, PROCESS, $scope.PDF);
                upload.then(function (datas) {
                    if (datas.data.result == 'SUCCESS') {
                        $scope.FLAG = 'PASS';
                    } 
                });
                Swal.fire({
                    title: 'SUCCES',
                    text: datas.data,
                    icon: 'ดฟสหำ',
                    confirmButtonColor: '#3085d6',
                    confirmButtonText: 'OK'
                });
            });
        } else {
            Swal.fire({
                title: 'ERROR',
                text: 'กรุณากรอกข้อมูลให้ครบถ้วน',
                icon: 'ดฟสหำ',
                confirmButtonColor: '#3085d6',
                confirmButtonText: 'OK'
            });
        }
    };

    $scope.BTN_BACK = function () {
        REDIRECT('/DH/FRM_MAIN_PAGE_PHESAJ');
    };
    
    $scope.BTN_SEND = function () {

        var Getdata = CENTER_SV.UPDATE_STATUS_CERT(2, sessionStorage.IDA);
        Getdata.then(function (datas) {
            Swal.fire({
                title: 'SUCCESS',
                text: datas.data,
                icon: 'ดฟสหำ',
                confirmButtonColor: '#3085d6',
                confirmButtonText: 'OK'
            });

            var Set_PREVIEW = CENTER_SV.GET_PREVIEW_CERT(IDA);
            Set_PREVIEW.then(function (datas) {

                $scope.LIST_GMP = datas.data;
                $scope.LIST_GMP.session = sessionStorage;

                $scope.LIST_GMP.CER.DOCUMENT_DATE = filwill(CHANGE_FORMATDATE(CV_DATE($scope.LIST_GMP.CER.DOCUMENT_DATE)));
                $scope.LIST_GMP.CER.EXP_DOCUMENT_DATE = filwill(CHANGE_FORMATDATE(CV_DATE($scope.LIST_GMP.CER.EXP_DOCUMENT_DATE)));

            }, function () { });
        });
    };

    $scope.BTN_SEND_REQUEST = function () {
        Swal.fire({
            title: 'คุณต้องการส่งใช่หรือไม่ ?',
            text: "กรุณาตรวจสอบความถูกต้องก่อนส่ง!",
            type: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'ใช่, ฉันต้องการส่งข้อมูล',
            cancelButtonText: 'ยกเลิก'
        }).then((result) => {
            if (result.value) {
                success_data('SUCCESS');
                REDIRECT('/DH/FRM_MAIN_PAGE_PHESAJ');
            }
        });
        
    };

    $scope.BTN_EDIT = function () {
        REDIRECT('/CERT/FRM_CERT_EDIT_REQUEST');
    };

    $scope.OPEN_DOC_PATH = function (PATH, FILENAME) {
        var urls = SET_URL_SV('/HOME/OPEN_DOC_PATH?PATH=' + PATH + '&FILENAME=' + FILENAME);
        window.open(urls);
        //OPEN_DOC
    };

    $scope.PDF_PREVIEW = function (PATH, FILENAME) {
        var urls = SET_URL_SV('/HOME/OPEN_DOC_PATH?PATH=' + PATH + '&FILENAME=' + FILENAME);
        window.open(urls);
    };

    function CV_DATE(data) {
        return new Date(parseInt(data.replace('/Date(', '').replace(')/', ''))).toLocaleDateString();
    }

    function filwill(dateString) {
        try {
            var dateArray = dateString.split("/");
            dateString = dateArray[0]; //+ "/" + dateArray[0] + "/" + dateArray[2];
        }
        catch (err) {

        }
        return dateString;
    }

    //แปลงเวลา เข้าข้อมูล (แสดง)
    function CHANGE_FORMATDATE(DATE_CHANGE) {
        var dateString = DATE_CHANGE;
        var currentTime = new Date(dateString);
        var month = currentTime.getMonth() + 1;
        if (month == '01') {
            month = "ม.ค.";
        } else if (month == '02') {
            month = "ก.พ.";
        } else if (month == '03') {
            month = "มี.ค.";
        } else if (month == '04') {
            month = "เม.ย.";
        } else if (month == '05') {
            month = "พ.ค.";
        } else if (month == '06') {
            month = "มิ.ย.";
        } else if (month == '07') {
            month = "ก.ค.";
        } else if (month == '08') {
            month = "ส.ค.";
        } else if (month == '09') {
            month = "ก.ย.";
        } else if (month == '10') {
            month = "ต.ค.";
        } else if (month == '11') {
            month = "พ.ย.";
        } else if (month == '12') {
            month = "ธ.ค.";
        }
        var day = currentTime.getDate();
        var year = currentTime.getFullYear();
        if (year > 2500) {
            year = year - 543;
        } else {
            year = year + 543;
        }
        return DATE_CHANGE = day + " " + month + " " + year;
    }

    $scope.ADD_FILE_LIST = function () {
        var obj = {
            TR_ID: '',
            DES: '',
            FILENAME: '',
            FILE_DATA: '',
            PATH: '',
            FLAG: '',
            TYPE: '',
            SIZE: 0
        };
        $scope.DOC_LIST.FILE_LISTs.push(obj);
    };

    $scope.selectFileforUpload = function (datas, file) {

        if (file.length == 0) {
            datas.FILE_DATA = '';
            datas.FILENAME = '';
        }
        else {
            if (file[0].type == 'application/pdf') {
                var b = file[0];
                datas.FILENAME = b.name;
                datas.SIZE = b.size;
                datas.TYPE = b.type;
            }
            else {
                Swal.fire({
                    title: 'Error!',
                    text: 'กรุณา UPLOAD FILE',
                    icon: 'error'
                });
                datas.FILE_DATA = '';
                datas.FILENAME = '';
            }
        }
        $scope.files.push(file);
    };

    $scope.deleteRow = function (datas, i) {

        if (datas.PIORITY == 'HIGH') {
            ERR_DATA(datas.DES + ' : เป็นเอกสารบังคับไม่สามารถลบออกได้');
        } else if (datas.PIORITY == 'LOW') {
            ERR_DATA(datas.DES + ' : ไม่สามารถลบออกได้');
        } else {
            $scope.DOC_LIST.FILE_LISTs.splice(i, 1);
        }
    };

    $scope.deleteCHEM = function (data,i) {
        $scope.GMP_CHEM.splice(i, 1);
    };

    /// ---------- แปลงวันที่ เข้า DATEPICKER -------------
    function CV_DATEPICKER(data) {
        return new Date(parseInt(data.replace('/Date(', '').replace(')/', ''))).toLocaleDateString('th-TH');
    }

    function filwill_DATE(dateString) {
        try {
            var dateArray = dateString.split("/");
            dateString = dateArray[1] + "/" + dateArray[0] + "/" + dateArray[2];
        }
        catch (err) {

        }
        return dateString;
    }

    function CHANGE_FORMATDATEPICKER(DATE_CHANGE) {
        var dateString = DATE_CHANGE.substr(6);
        var currentTime = new Date(parseInt(dateString));
        var month = currentTime.getMonth() + 1;
        var day = currentTime.getDate();
        var year = currentTime.getFullYear();
        return DATE_CHANGE = day + "/" + month + "/" + year;
    }

}).controller('appController', ['$scope', function ($scope) {
    $scope.$on('LOAD', function () { $scope.loading = true; alert('1'); });
    $scope.$on('UNLOAD', function () { $scope.loading = false; alert('2'); });

    
}]);


