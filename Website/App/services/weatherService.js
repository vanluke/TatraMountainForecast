
/// <reference path="~/Scripts/angular.js" />
/// <reference path="./../app.js" />

var angularStartServices = angular.module('angularStart.services', ['ngResource']);     //Define the services module


angularStartServices.factory('dataService', ['$http', function ($http) {
    return {
        getJson: function () {
            return $http.get("http://localhost/weatherapi/api/Weathers");
        }
    };
}]);
