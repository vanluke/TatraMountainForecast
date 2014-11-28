'use strict';
angular.module("app").controller("Weathers2Controller", function ($scope, weatherRepository) {
    $scope.instructors = weatherRepository.get();
});