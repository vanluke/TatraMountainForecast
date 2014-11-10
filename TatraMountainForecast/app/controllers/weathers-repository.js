angular.module("app").factory("weatherRepository", function ($resource) {
    return {
        get : function() {
            return $resource("/api/wethers").query();
        }
    }
});