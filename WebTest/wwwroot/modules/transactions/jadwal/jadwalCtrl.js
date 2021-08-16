(function () {
    'use strict';
    app.controller('JadwalCtrl', ['$scope', '$filter', '$timeout', '$localstorage', 'urlService', 'masterServices', 'transaksiServices', 'toastr', function ($scope, $filter, $timeout, $localstorage, urlService, masterServices, transaksiServices, toastr) {
        $scope.Simpan = function () {
            var a = transaksiServices.SimpanJadwal($scope.jadwal);
            a.then(function (response) {
                toastr.info('Simpan Data Jadwal Berhasil', 'Informasi');
                $timeout(getJadwal(), 500);
                $scope.jadwal = {};
            },
                function (error) {
                    toastr.info('Simpan Gagal | ' + error.data, 'Informasi');
                });
        }

        $scope.Hapus = function () {
            var a = transaksiServices.HapusJadwal($scope.jadwal);
            a.then(function (response) {
                toastr.info('Hapus Berhasil', 'Informasi');
                $timeout(getJadwal(), 500);
                $scope.jadwal = {};
            },
                function (error) {
                    toastr.info('Hapus Gagal | ' + error.data, 'Informasi');
                });
        }


        $scope.initLoad = function () {
            $localstorage.setObject("jadwalPertandingan", null);
            $scope.jadwal = {};
            $timeout(getJadwal, 500);
            $timeout(getTim, 500);
            //$timeout(getTimRumah, 500);
        }
        $scope.changePosisi = function (item) {
            //bisi butuh buat selected item.
        }

        function getJadwal() {
            var a = masterServices.GetJadwal();
            a.then(function (response) {
                $scope.listJadwal = response.data;
            },
                function (error) {
                    toastr.error(error.data, 'Error');
                });
        }

        $scope.formatDate = function (date) {
            var format = new Date(date);
            var da = $filter('date')(format, "dd-MM-yyyy");
            return da;
        }
        function getTim() {
            var tim = masterServices.GetTim();
            tim.then(function (response) {
                $scope.listTim = response.data;
            }, function (error) {
                toastr.error(error.data, 'Error');
            })
        }
        $scope.Hasil = function (item) {
            $localstorage.setObject("jadwalPertandingan", item);
            var url = urlService.get();
            $localstorage.set('urlBack', url + 'Transaksi/JadwalPertandingan');
            window.location.href = url + 'Transaksi/HasilPertandingan';
        }

        $scope.selectTableRow = function (index, item) {
            $scope.selectedIdJadwal = item.id_jadwal;
            $scope.jadwal = item;

        }

    }])

    /** @ngInject */

})();