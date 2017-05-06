(function () {
    'use strict';
    angular.module('liquidApp')
        .service('apiService', ['$http', function ($http) {

            return {
                apiPath: "",

                init: function (path) {
                    this.apiPath = path;
                    return this;
                },

                get: function (callback) {
                    $http.get(this.apiPath).then(function (result) {
                        callback(result.data);
                    })
                },

                load: function (id, callback) {
                    $http.get(this.apiPath + '/' + id).then(function (result) {
                        callback(result.data);
                    })
                },

                post: function (model, callback) {
                    $http.post(this.apiPath, model).then(function (result) {
                        callback(result.data);
                    });
                },

                delete: function (id, callback) {
                    $http.delete(this.apiPath + '/' + id).then(function (result) {
                        callback(result.data);
                    });
                }
            };
        }]);
})();