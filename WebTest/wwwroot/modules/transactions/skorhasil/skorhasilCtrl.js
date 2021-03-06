(function () {
    'use strict';
    app.controller('SkorhasilCtrl', ['$scope', '$timeout', '$localstorage', 'masterServices', 'transaksiServices', 'toastr', function ($scope, $timeout, $localstorage, masterServices, transaksiServices, toastr) {

        $scope.initLoad = function () {

            $scope.skorhasil = {};
            $scope.hasilPertandingan = $localstorage.getObject("hasilPertandingan");
            $scope.skorhasil.hasilPertandinganId = $scope.hasilPertandingan.id;
            console.log($scope.skorhasil);
            $scope.filterId = $scope.hasilPertandingan.id;
            $timeout(getSkorhasil($scope.skorhasil.hasilPertandinganId), 500);
            $timeout(getTim, 500);
            $timeout(getPemain, 500);
            //$scope.filterHasil = [$scope.hasilPertandingan.id]; 
        }

        function getSkorhasil(hasilPertandinganId) {
            var a = masterServices.GetSkorhasil(hasilPertandinganId);
            a.then(function (response) {
                $scope.listDetail = response.data;
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

        $scope.selectTableRow = function (index, item) {
            $scope.selectedIdDetail = item.id;
            $scope.skorhasil = item;
        }

    }])


})();