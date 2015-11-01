//here we need to inject ui.router as we using it for routing
var myDemoApp = angular.module('myDemoApp');

myDemoApp.controller('HomeCtrl', function ($scope) {
    $scope.message = 'Hello! we are on Home Page';
});