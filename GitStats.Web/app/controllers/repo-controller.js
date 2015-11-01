//here we need to inject ui.router as we using it for routing
var myDemoApp = angular.module('myDemoApp');

myDemoApp.controller('RepoCtrl', function (RepoService, $scope) {

    console.log('repo ctrl');

    var promise = RepoService.list();

    promise.then(
        function (payload) {
            $scope.items = payload.data;
        },
        function (errorPayload) {
            $log.error('failure loading repositories', errorPayload);
        });
});