var app = angular.module("app", ['ngRoute'])
    .config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
        $routeProvider.when('/Weathers', {
            templateUrl: '/app/views/weathers/index.html', 
            controller: 'WeathersController'
        });
    $locationProvider.html5Mode(true);
}]);