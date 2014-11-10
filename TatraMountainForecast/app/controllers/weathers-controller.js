'use strict';
angular.module("app").controller("WeathersController", function ($scope, weatherRepository) {
    $scope.instructors = weatherRepository.get();
});