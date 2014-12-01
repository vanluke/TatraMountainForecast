define(['app', 'weathersService'], function (app) {

    app.register.service('weathersService', ['ajaxCall', function (ajaxService) {

        this.getWeathers = function (url, successFunction, errorFunction) {
            ajaxService.AjaxPostWithNoAuthenication(url, successFunction, errorFunction);
        };

        //this.login = function (user, successFunction, errorFunction) {
        //    ajaxService.AjaxPostWithNoAuthenication(user, "/api/accounts/Login", successFunction, errorFunction);
        //};

        //this.getUser = function (successFunction, errorFunction) {
        //    ajaxService.AjaxGet("/api/accounts/GetUser", successFunction, errorFunction);
        //};

        //this.updateUser = function (user, successFunction, errorFunction) {
        //    ajaxService.AjaxPost(user, "/api/accounts/UpdateUser", successFunction, errorFunction);
        //};

    }]);
});