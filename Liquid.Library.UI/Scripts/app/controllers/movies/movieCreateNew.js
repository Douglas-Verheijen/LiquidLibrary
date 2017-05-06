(function () {
    'use strict';
    angular.module('liquidApp')
        .controller('movieCreateNew', ['$scope', 'movieService', function ($scope, movieService) {

            $scope.submit = function () {

                var model = {
                    Name: $scope.Name,
                    Author: $scope.Author,
                    ISBN: $scope.ISBN
                };

                bookService.post(model, function (data) {
                    window.location.replace("/Movie/Overview?id=" + data);
                });
            };
        }]);
})();