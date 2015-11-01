var myDemoApp = angular.module('myDemoApp');
  
myDemoApp.controller('RepoDetailsCtrl', ['$scope', '$stateParams', 'RepoService', function ($scope, $stateParams, RepoService) {

    $scope.id = $stateParams.id;

}]);