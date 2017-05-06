(function () {
    'use strict';
    angular.module('liquidApp')
        .service('movieService', ['apiService', function (apiService) {
            return apiService.init("/api/movies");
        }]);
})();