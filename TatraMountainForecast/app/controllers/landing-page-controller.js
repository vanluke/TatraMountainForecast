"use strict";

define(['application-configuration', 'weathersService', 'alertsService'], function (app) {
    app.register.controller('importProductsController', ['$scope', '$rootScope', 'weathersService', 'alertsService', function($scope, $rootScope, weathersService) {
//var LandingPageController = function ($scope, $http, weathersService) {
            //$scope.models = {
            //    helloAngular: 'I work!'
            //};
            $scope.initializeController = function() {
                $rootScope.applicationModule = "Weathers";
            }
            $scope.getWeathers = function() {
                weathersService.getWeathers('http://localhost:49629/api/weathers', function(data) {
                    console.log('not a eeror');
                }, function(err, ee1, ee2) {
                    console.log('error');
                })
                $http.get("http://localhost:49629/api/Weathers").success(function(data, status, headers, config) {
                    $scope.Weathers = data.Weather;
                }).error(function(response) {
                    console.log('error occured.' + response);
                });
            };
        }]);
});
    //$http.get("http://localhost:49629/api/weathers").success(function (data, status, headers, config) {
    //    $scope.Weathers = data.Weather;
    //});

// The inject property of every controller (and pretty much every other type of object in Angular) needs to be a string array equal to the controllers arguments, only as strings
//LandingPageController.$inject = ['$scope'];