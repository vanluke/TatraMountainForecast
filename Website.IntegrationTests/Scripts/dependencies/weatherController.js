/// <reference path="./../app.js" />


angular.module('main')
    .controller('WeatherController', function ($scope, $location, dataService, modelService) {
     
        $scope.pageTitle = "Weather";

        $scope.myData = modelService;

        $scope.dataList = [];

        $scope.getDatetime = new Date();

        dataService.getJson().then(
            function (res) {
                angular.copy(res.data, modelService);
            }, function () { });
    });
