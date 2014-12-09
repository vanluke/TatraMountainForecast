
/// <reference path="~/Scripts/angular.js" />
/// <reference path="./../app.js" />

var angularStartServices = angular.module('angularStart.services', ['ngResource']);     //Define the services module


//appRoot.service('weatherService', function ($http) {
////angularStartServices.factory('weatherService', [function ($http) {
//    this.getWeathers = function () {
//        return $http.get("http://localhost:33990/api/Weathers").success(function(data, status, headers, config) {
//            console.log(data);
//            console.log(status);
//            console.log(headers);
//            console.log(config);
//        }).error(function(data, status, headers, config) {
//            console.log(data);
//            console.log(status);
//            console.log(headers);
//            console.log(config);
//        });
//    }
//});
angularStartServices.factory('dataService', ['$http', function ($http) {
    return {
        getJson: function () {
            return $http.get("http://localhost/WeatherApi/api/Weathers").success(function (data, status, headers, config) {
    
            }).error(function (data, status, headers, config) {
                console.log(data);
                console.log(status);
                console.log(headers);
                console.log(config);
            });
        }
    };
}]);
//angularStartServices.factory('dataService', [function ($http) {
//    var service = {};
//    service.getJson = function ($http) {
//        return {
//            getJson: function() {
//                return $http.get("http://localhost:33990/api/Weathers").success(function(data, status, headers, config) {
//                    console.log(data);
//                    console.log(status);
//                    console.log(headers);
//                    console.log(config);
//                }).error(function(data, status, headers, config) {
//                    console.log(data);
//                    console.log(status);
//                    console.log(headers);
//                    console.log(config);
//                });
//            }
//        }
//    }
//    return service;
//}]);
//appRoot.service('dataService', function ($http) {
//    angularStartServices.factory('dataService', [
//        function($http) {
//            return {
//                getJson: function() {
//                    return $http.get("http://localhost:33990/api/Weathers").success(function(data, status, headers, config) {
//                        console.log(data);
//                        console.log(status);
//                        console.log(headers);
//                        console.log(config);
//                    }).error(function(data, status, headers, config) {
//                        console.log(data);
//                        console.log(status);
//                        console.log(headers);
//                        console.log(config);
//                    });
//                }
//            }
//        }
//    ]);
//});
