'use strict';
//var app = angular.module('app', []);
var AwesomeAngularMVCApp = angular.module('AwesomeAngularMVCApp', ['ngRoute']);


AwesomeAngularMVCApp.controller('LandingPageController');

var configFunction = function ($routeProvider) {
    $routeProvider.
        when('/Weathers', {
            templateUrl: '/app/views/weathers/index.html'
        });
}
configFunction.$inject = ['$routeProvider'];

AwesomeAngularMVCApp.config(configFunction);