(function () {
    'use strict';
    angular.module('liquidApp')
        .service('bookService', ['apiService', function (apiService) {
            return apiService.init("/api/books");
        }]);
})();