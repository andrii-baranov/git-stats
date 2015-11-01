//here we need to inject ui.router as we using it for routing
var myDemoApp = angular.module('myDemoApp');

myDemoApp.controller('UserCtrl', ['$scope', '$http', '$interval', 'RepoService', 'uiGridConstants', function ($scope, $http, $interval, RepoService, uiGridConstants) {

    $scope.data = [
        { name : 'a', last : 'b', age : 45},
        { name: 'a', last: 'b', age: 45 },
        { name: 'a', last: 'b', age: 45 },
        { name: 'a', last: 'b', age: 45 },
        { name: 'a', last: 'b', age: 45 },
        { name: 'a', last: 'b', age: 45 },
    ];
}]);