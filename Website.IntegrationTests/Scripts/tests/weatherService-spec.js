/// <reference path="../jasmine/jasmine.js" />
/// <reference path="../jasmine/jasmine-html.js" />
/// <reference path="../angular.js" />
/// <reference path="../angular-resource.js" />
/// <reference path="../angular-mocks.js" />
/// <reference path="../dependencies/app.js" />
/// <reference path="../dependencies/mainDirective.js" />
/// <reference path="../dependencies/service.js" />
/// <reference path="../dependencies/weatherService.js" />
/// <reference path="../dependencies/aboutController.js" />


describe('dataService', function () {
    var dataService,
        httpBackend;

    beforeEach(function () {
        module('angularStart.services');

        // get your service, also get $httpBackend
        // $httpBackend will be a mock, thanks to angular-mocks.js
        inject(function ($httpBackend, _dataService_) {
            dataService = _dataService_;
            httpBackend = $httpBackend;
        });
    });

    afterEach(function () {
        httpBackend.verifyNoOutstandingExpectation();
        httpBackend.verifyNoOutstandingRequest();
    });

    it('should return the response.', function () {
        // set up some data for the http call to return and test later.
        var returnData = { excited: true };

        // expectGET to make sure this is called once.
        httpBackend.expectGET('http://localhost/weatherapi/api/Weathers').respond(returnData);

        // make the call.
        var returnedPromise = dataService.getJson();

        // set up a handler for the response, that will put the result
        // into a variable in this scope for you to test.
        var result;
        returnedPromise.then(function (response) {
            result = response;
        });

        // flush the backend to "execute" the request to do the expectedGET assertion.
        httpBackend.flush();
        var codeResult = '200';
        // check the result. 
        // (after Angular 1.2.5: be sure to use `toEqual` and not `toBe`
        // as the object will be a copy and not the same instance.)
        expect(result).not.toBe(null);
    });
});