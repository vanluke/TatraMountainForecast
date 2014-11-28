var LandingPageController = function ($scope, $http) {
    //$scope.models = {
    //    helloAngular: 'I work!'
    //};
    $scope.AjaxGet = function(route, successFunction, errorFunction) {
            $http.get("http://localhost:49629/api/Weathers").success(function(data, status, headers, config) {
                $scope.Weathers = data.Weather;
            }).error(function(response) {
                console.log('error occured.' + response);
            });
        };
    }
    //$http.get("http://localhost:49629/api/weathers").success(function (data, status, headers, config) {
    //    $scope.Weathers = data.Weather;
    //});

// The inject property of every controller (and pretty much every other type of object in Angular) needs to be a string array equal to the controllers arguments, only as strings
LandingPageController.$inject = ['$scope'];