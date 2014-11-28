/// <reference path="controllers/landing-page-controller.js" />
/// <reference path="controllers/landing-page-controller.js" />
/// <reference path="views/weathers/index.html" />
'use strict';
//var app = angular.module('app', []);
//var app = angular.module('AwesomeAngularMVCApp', ['ngRoute']);


//app.controller('LandingPageController');

//var configFunction = function ($routeProvider) {
//    $routeProvider.
//        when('/Weathers', {
//            templateUrl: '/app/views/weathers/index.html'
//        });
//}
//configFunction.$inject = ['$routeProvider'];

//app.config(configFunction);
var app = angular.module('app', []);
//Define Routing for the application
app.config(['$routeProvider',
    function ($routeProvider) {
        $routeProvider.
            when('/Weathers/AddNewCustomer', {
                templateUrl: 'views/weathers/index.html',
                controller: 'WeathersController'
            });
    }]);

var app = angular.module('app', ['ngRoute']);

app.controller('LandingPageController', LandingPageController);

var configFunction = function ($routeProvider) {
    $routeProvider.
        when('/Weathers2', {
            templateUrl: function(rp) { return '/app/views/weathers/index.html'; },
            controllerUrl: "/app/controllers/landing-page-controller.js"
        });
    //.when('/WeathersTwo', {
    //    templateUrl: 'Weathers/two'
    //})
    //.when('/WeathersThree', {
    //    templateUrl: 'Weathers/three'
    //});
}
configFunction.$inject = ['$routeProvider'];

app.config(configFunction);