define(['angularAMD', 'angular-route', 'angular-animate', 'angular-locale', 'jquery', 'util', 'moment', 'moment-pt-br'],
    function (angularAMD, route, animate, locale, $, util) {
        var app = angular.module("app", ['ngRoute', 'ngAnimate']);
        app.config(function($routeProvider) {
            $routeProvider.when("/weathers", angularAMD.route({
                templateUrl: '../../Weathers', controller: 'WeathersController', section: 'Weathers', title: 'Weathers'
            })
            .otherwise({ redirectTo: '/Home' })
        });
    });