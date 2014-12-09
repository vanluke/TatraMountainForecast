/// <reference path="./../app.js" />


angular.module('main')
    .controller('WeathersController', function ($scope, $location, dataService, modelService, $modal) {
        var nestedTable = '<div class="ngCellText"  data-ng-model="row"><button data-ng-click="detailsSelectedRow(row,$event)">Details</button></div>';
        $scope.myData = modelService;

    $scope.dataList = [];

    $scope.getDatetime = new Date();

        $scope.currentWeatherList = function(location) {
            for (var i = 0; i < myData.length; i++) {
                if (myData[i].locationName == location) {
                    var local = myData[i].weather.curren_weather;
                    dataList.push(local);
                } 
            }
        }
   
        dataService.getJson().then(
            function (res) {
                angular.copy(res.data, modelService);
            }, function () { });

        var dialog;
        $scope.detailsSelectedRow = function (row) {
            $scope.myrow = row.entity;
            var modalInstance = $modal.open({
                templateUrl: 'myModalContent.html',
                controller: modalDetails,
                resolve: {
                    items: function () {
                        return row.entity;
                    }
                }
            });
        }

        $scope.save = function () {
            console.log($modal);
            $modal.dismiss('cancel');
        }

        $scope.weatherGrid2 = {
            data: 'currentWeatherList',
            rowHeight: '100',
            columnDefs: [
                { field: 'humidity', displayName: 'humidity' },
                { field: 'pressure', displayName: 'pressure', width: '5%' },
                { field: 'temp', displayName: 'temp', width: '15%' },
                { field: 'temp_unit', displayName: 'temp_unit', width: '15%' },
                { field: 'weather_text', displayName: 'Information', width: '50%' }
            ]
        };



        $scope.weatherGrid = {
            data: 'myData',
            rowHeight: '100',
            multiSelect: false,
            enableCellSelection: true,
            enableRowSelection: false,
            selectedItems: $scope.selectedWeathers,
            enableColumnResize: false,
            columnDefs: [
                {
                    field: 'locationName', displayName: 'Location',
                    cellTemplate: '<div>{{row.entity[col.field]}}</div>'
                }, {
                    field: '', cellTemplate: '<div ng-repeat="g in weather.curren_weather"></div>', width: '30%'
                }
                //{ field: 'humidity', displayName: 'humidity', width: '5%' },
                    //{ field: 'pressure', displayName: 'pressure', width: '5%' },
                    //{ field: 'temp', displayName: 'temp', width: '15%' },
                    //{ field: 'temp_unit', displayName: 'temp_unit', width: '15%' },
                    //{ field: 'weather_text', displayName: 'Information', width: '40%' },
                    //{ field: '', cellTemplate: cellTemplate, width: '10%' }
            ]
        };
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