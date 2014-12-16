var angularStartDirectives = angular.module('angularStart.directives', []);     //Define the directive module

angularStartDirectives.directive('mainDirective', function () {             //use as 'test-directive' in HTML
    return {
        restrict: 'A',
        link: function (scope, element, attrs) {
        
        }
    };
});