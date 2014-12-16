/// <reference path="../jasmine/jasmine.js" />
/// <reference path="../jasmine/jasmine-html.js" />
/// <reference path="../angular.js" />
/// <reference path="../angular-resource.js" />
/// <reference path="../angular-mocks.js" />
/// <reference path="../dependencies/mainDirective.js" />
/// <reference path="../dependencies/service.js" />
/// <reference path="../dependencies/weatherService.js" />
/// <reference path="../dependencies/aboutController.js" />
/// <reference path="../dependencies/app.js" />

describe('Controller: AboutController', function () {

    var scope;
    var ctrl;
    var mysvcMock;

    beforeEach(module('main'));

    beforeEach(function() {
        mysvcMock = {
         
        };
    });

    beforeEach(inject(function($rootScope, $controller) {
        scope = $rootScope.$new();
        ctrl = $controller('AboutController', {
            $scope: scope,
            mysvc: mysvcMock
        });
    }));

    it('should have scope defined', function () {
        expect(scope).toBeDefined();
    });
});