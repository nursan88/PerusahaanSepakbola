(function () {
    'use strict';
    app.controller('TimCtrl', ['$scope', '$timeout', 'masterServices', 'transaksiServices', 'toastr', function ($scope, $timeout, masterServices, transaksiServices, toastr) {
        $scope.Simpan = function () {
            var a = transaksiServices.SimpanTim($scope.tim);
            a.then(function (response) {
                toastr.info('Simpan Data Tim Berhasil', 'Informasi');
                $timeout(getTim(), 500);
                $scope.tim = {};
            },
                function (error) {
                    toastr.info('Simpan Gagal | ' + error.data, 'Informasi');
                });
        }

        $scope.Hapus = function () {
            var a = transaksiServices.HapusTim($scope.tim);
            a.then(function (response) {
                toastr.info('Hapus Berhasil', 'Informasi');
                $timeout(getTim(), 500);
                $scope.tim = {};
            },
                function (error) {
                    toastr.info('Hapus Gagal | ' + error.data, 'Informasi');
                });
        }


        $scope.initLoad = function () {
            $scope.tim = {};
            $timeout(getTim, 500);
            //$timeout(getPosisi, 500);
        }
        $scope.changePosisi = function (item) {
            //bisi butuh buat selected item.
        }
        function getTim() {
            var a = masterServices.GetTim();
            a.then(function (response) {
                $scope.listTim = response.data;
            },
                function (error) {
                    toastr.error(error.data, 'Error');
                });
        }
        //function getPosisi() {
        //    var posisi = masterServices.GetPosisi();
        //    posisi.then(function (response) {
        //        $scope.listPosisi = response.data;
        //    }, function (error) {
        //        toastr.error(error.data, 'Error');
        //    })
        //}
        $scope.selectTableRow = function (index, item) {
            $scope.selectedIdTim = item.id_tim;
            $scope.tim = item;

        }

    }])

    /** @ngInject */

})();