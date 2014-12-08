var angularStartServices = angular.module('angularStart.services', ['ngResource']);     //Define the services module

angularStartServices.factory('TestService', [function () {
    var service = {};
    service.doWork = function () {
        console.log('Did some work !');
    }
    return service;
}]);