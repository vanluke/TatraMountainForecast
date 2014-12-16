/// <reference path="../angular.js" />
/// <reference path="../angular-route.js" />
/// <reference path="../angular-resource.js" />
/// <reference path="../dependencies/app.js" />

angular.module('main')
    .controller('AboutController', ['$scope', function ($scope) {
        $scope.pageTitle = "About";
    }]);