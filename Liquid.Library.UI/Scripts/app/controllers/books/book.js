(function () {
    'use strict';
    angular.module('liquidApp')
        .controller('book', ['$scope', '$uibModal', 'bookService', function ($scope, $uibModal, bookService) {

            var ctrl = this;

            $scope.currentPage = 0;
            $scope.pageSize = 10;

            bookService.get(function (data) {
                $scope.items = data;
                $scope.pageTotal = data.length;

                $scope.splice();
            });

            $scope.setFirstPage = function () {
                $scope.currentPage = 0;
            };

            $scope.setLastPage = function () {
                $scope.currentPage = Math.floor($scope.pageTotal / $scope.pageSize);
            };

            $scope.increaseCurrentPage = function () {
                if ($scope.currentPage < Math.floor($scope.pageTotal / $scope.pageSize))
                    ++$scope.currentPage;
            };

            $scope.decreaseCurrentPage = function () {
                if ($scope.currentPage !== 0)
                    --$scope.currentPage;
            };

            $scope.splice = function () {
                var begin = $scope.currentPage * $scope.pageSize;
                var end = begin + $scope.pageSize;

                $scope.currentItems = $scope.items.slice(begin, end);
            };

            $scope.$watch("currentPage + numPerPage", function () {
                $scope.splice();
            });
        }]);
})();