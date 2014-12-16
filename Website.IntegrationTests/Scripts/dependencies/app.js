/// <reference path="../angular.js" />
/// <reference path="../angular-route.js" />


var appRoot = angular.module('main', ['ngRoute', 'ngResource', 'angularStart.services', 'angularStart.directives']);

appRoot.config(['$routeProvider', function ($routeProvider) {
    $routeProvider
                 .when('/home', { templateUrl: '/home/main', controller: 'MainController' })
                 .when('/contact', { templateUrl: '/home/contact', controller: 'ContactController' })
                 .when('/about', { templateUrl: '/home/about', controller: 'AboutController' })
                 .when('/weathers', { templateUrl: '/home/weathers', controller: 'WeatherController' })
                 .otherwise({ redirectTo: '/home' });
}]).controller('RootController', ['$scope', '$route', '$routeParams', '$location', function ($scope, $route, $routeParams, $location) {
    $scope.$on('$routeChangeSuccess', function (e, current, previous) {
        $scope.activeViewPath = $location.path();
    });
}]);