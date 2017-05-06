(function () {
    'use strict';
    angular.module('liquidApp')
        .controller('bookView', ['$scope', 'bookService', function ($scope, bookService) {

            var vars = [], hash, id;
            var hashes = window.location.href.slice(window.location.href.indexOf('?') + 1).split('&');
            for (var i = 0; i < hashes.length; i++) {
                hash = hashes[i].split('=');
                vars.push(hash[0]);
                vars[hash[0]] = hash[1];
                id = vars["id"];
            }

            bookService.load(id, function (data) {
                $scope.model = data;
            });
        }]);
})();