(function () {
    'use strict';
    app.controller('HasilCtrl', ['$scope', '$timeout', '$localstorage', 'urlService', 'masterServices', 'transaksiServices', 'toastr', function ($scope, $timeout, $localstorage, urlService, masterServices, transaksiServices, toastr) {
        $scope.Simpan = function () {
            var a = transaksiServices.SimpanHasil($scope.hasil);
            a.then(function (response) {
                toastr.info('Simpan Data Hasil Berhasil', 'Informasi');
                $timeout(getHasil(), 500);
                $scope.hasil = {};
            },
                function (error) {
                    toastr.info('Simpan Gagal | ' + error.data, 'Informasi');
                });
        }

        $scope.Hapus = function () {
            var a = transaksiServices.HapusHasil($scope.hasil);
            a.then(function (response) {
                toastr.info('Hapus Berhasil', 'Informasi');
                $timeout(getHasil(), 500);
                $scope.hasil = {};
            },
                function (error) {
                    toastr.info('Hapus Gagal | ' + error.data, 'Informasi');
                });
        }


        $scope.initLoad = function () {

            $scope.hasil = {};
            $scope.hasil.skorPertandingan = [];
            $localstorage.setObject("hasilPertandingan", null);
            $scope.jadwalPertandingan = $localstorage.getObject("jadwalPertandingan");
            $scope.hasil.jadwalPertandinganid_jadwal = $scope.jadwalPertandingan.id_jadwal;
            $timeout(getHasil, 500);
            $timeout(getTim, 500);
            $timeout(getPemain, 500);
            $scope.filterTim = [$scope.jadwalPertandingan.timTuanRumahId_tim, $scope.jadwalPertandingan.timTamuId_tim];
            console.log($scope.filterTim);
        }
        $scope.TambahSkorTimTuanRumah = function () {
            $scope.hasil.skorPertandingan.push({});
        }
        $scope.HapusSkorTimTuanRumah = function (index, item) {
            item.splice(index, 1);
        }
        $scope.Check = function (item) {
            $scope.filterId = item.timId_tim;
        }
        $scope.changePosisi = function (item) {
            //bisi butuh buat selected item.
        }
        function getHasil() {
            var a = masterServices.GetHasil();
            a.then(function (response) {
                $scope.listHasil = response.data;
            },
                function (error) {
                    toastr.error(error.data, 'Error');
                });
        }

        function getTim() {
            var tim = masterServices.GetTim();
            tim.then(function (response) {
                $scope.listTim = response.data;
            },
                function (error) {
                    toastr.error(error.data, 'Error');
                });
        }

        function getPemain() {
            var pemain = masterServices.GetPemain();
            pemain.then(function (response) {
                $scope.listPemain = response.data;
            },
                function (error) {
                    toastr.error(error.data, 'Error');
                });
        }

        $scope.Skorhasil = function (item) {
            $localstorage.setObject("hasilPertandingan", item);
            var url = urlService.get();
            $localstorage.set('urlBack', url + 'Transaksi/HasilPertandingan');
            window.location.href = url + 'Transaksi/SkorHasil';
        }

        $scope.selectTableRow = function (index, item) {
            $scope.selectedIdHasil = item.id_hasil;
            $scope.hasil = item;

        }

    }])

    /** @ngInject */

})();