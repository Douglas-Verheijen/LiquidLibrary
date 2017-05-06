(function () {
    'use strict';
    angular.module('liquidApp')
        .controller('bookCreateNew', ['$scope', 'bookService', function ($scope, bookService) {

            $scope.submit = function () {

                var model = {
                    Name: $scope.Name,
                    Author: $scope.Author,
                    ISBN: $scope.ISBN
                };

                bookService.post(model, function (data) {
                    window.location.replace("/Book/Overview?id=" + data);
                });
            };
        }]);
})();