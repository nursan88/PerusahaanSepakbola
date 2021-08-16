(function () {
    'use strict';
    app.controller('PemainCtrl', ['$scope', '$timeout', 'masterServices', 'transaksiServices', 'toastr', function ($scope, $timeout, masterServices, transaksiServices, toastr) {
        $scope.Simpan = function () {
            var a = transaksiServices.SimpanPemain($scope.pemain);
            a.then(function (response) {
                toastr.info('Simpan Berhasil', 'Informasi');
                $timeout(getPemain(), 500);
                $scope.pemain = {};
            },
                function (error) {
                    toastr.info('Simpan Gagal | ' + error.data, 'Informasi');
                });
        }

        $scope.Hapus = function () {
            var a = transaksiServices.HapusPemain($scope.pemain);
            a.then(function (response) {
                toastr.info('Hapus Berhasil', 'Informasi');
                $timeout(getPemain(), 500);
                $scope.pemain = {};
            },
                function (error) {
                    toastr.info('Hapus Gagal | ' + error.data, 'Informasi');
                });
        }


        $scope.initLoad = function () {
            $scope.pemain = {};
            $timeout(getPemain, 500);
            $timeout(getPosisi, 500);
            $timeout(getTim, 500);
        }
        $scope.changePosisi = function (item) {
            //bisi butuh buat selected item.
        }
        $scope.checkNo = function (no, timId) {
            var a = masterServices.CheckNo(no, timId);
            a.then(function (response) {
                var check = response.data;
                if (check) {
                    toastr.info("No Punggung tersedia", "Informasi");
                }
                else {
                    $scope.pemain.noPunggung = 0;
                    toastr.info("No Punggung tidak tersedia", "Informasi");

                }
            })
        }
        $scope.Cari = function (filter) {
            var model = masterServices.GetPemainByTim(filter);
            model.then(function (response) {
                $scope.listPemain = response.data;
            }, function (error) {
                toastr.error(error.data, 'Error');
            });
        }
        function getPemain() {
            var a = masterServices.GetPemain();
            a.then(function (response) {
                $scope.listPemain = response.data;
            },
                function (error) {
                    toastr.error(error.data, 'Error');
                });
        }
        function getPosisi() {
            var posisi = masterServices.GetPosisi();
            posisi.then(function (response) {
                $scope.listPosisi = response.data;
            }, function (error) {
                toastr.error(error.data, 'Error');
            })
        }

        function getTim() {
            var tim = masterServices.GetTim();
            tim.then(function (response) {
                $scope.listTim = response.data;
            }, function (error) {
                toastr.error(error.data, 'Error');
            })
        }

        $scope.selectTableRow = function (index, item) {
            $scope.selectedIdPemain = item.id_pemain;
            $scope.pemain = item;

        }

    }])

    /** @ngInject */

})();