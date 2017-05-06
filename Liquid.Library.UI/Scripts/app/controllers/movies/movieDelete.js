(function () {
    'use strict';
    angular.module('liquidApp')
        .controller('movieDelete', ['$scope', 'movieService', function ($scope, movieService) {

            var vars = [], hash, id;
            var hashes = window.location.href.slice(window.location.href.indexOf('?') + 1).split('&');
            for (var i = 0; i < hashes.length; i++) {
                hash = hashes[i].split('=');
                vars.push(hash[0]);
                vars[hash[0]] = hash[1];
                id = vars["id"];
            }

            movieService.load(id, function (data) {
                $scope.model = data;
            });

            $scope.submit = function () {

                movieService.delete(id, function (data) {
                    window.location.replace("/Movie");
                });
            };
        }]);
})();