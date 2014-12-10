/// <reference path="./../app.js" />


angular.module('main')
    .controller('WeathersController', function ($scope, $location, dataService, modelService, $modal) {
        var nestedTable = '<div class="ngCellText"  data-ng-model="row"><button data-ng-click="detailsSelectedRow(row,$event)">Details</button></div>';
        $scope.myData = modelService;

        $scope.dataList = [];

        $scope.getDatetime = new Date();

        dataService.getJson().then(
            function (res) {
                angular.copy(res.data, modelService);
            }, function () { });


        $scope.save = function () {
            console.log($modal);
            $modal.dismiss('cancel');
        }
    });
var modalDetails = function ($scope, $modalInstance, items) {

    $scope.items = items;
    var name = items.name;
    var age = items.age;


    $scope.ok = function () {
        $modalInstance.close();
    };

    $scope.cancel = function () {
        items.name = name;
        items.age = age;
        $modalInstance.dismiss('cancel');
    };
};