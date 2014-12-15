/// <reference path="~/Scripts/angular.js" />
/// <reference path="~/Scripts/ng-table.js" />

var appRoot = angular.module('main', ['ngRoute', 'ngGrid', 'ui.bootstrap', 'ngResource', 'angularStart.services', 'angularStart.directives']);

appRoot.config(['$routeProvider', function ($routeProvider) {
    $routeProvider
                 .when('/home', { templateUrl: '/home/main', controller: 'MainController' })
                 .when('/contact', { templateUrl: '/home/contact', controller: 'ContactController' })
                 .when('/about', { templateUrl: '/home/about', controller: 'AboutController' })
                 .when('/weathers', { templateUrl: '/home/weathers', controller: 'WeatherController' })
                 .otherwise({ redirectTo: '/home' });
       //.when('/', { templateUrl: '/home/index', controller: 'HomeController' })
       //.when('/contact', { templateUrl: '/home/contact', controller: 'ContactController' })
       //.when('/about', { templateUrl: '/home/about', controller: 'AboutController' })
       //.when('/weathers', { templateUrl: '/home/weathers', controller: 'WeathersController' })
       //.otherwise({ redirectTo: '/' });
}]).controller('RootController', ['$scope', '$route', '$routeParams', '$location', function ($scope, $route, $routeParams, $location) {
    $scope.$on('$routeChangeSuccess', function (e, current, previous) {
        $scope.activeViewPath = $location.path();
    });
}]);