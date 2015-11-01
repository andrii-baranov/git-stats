//here we need to inject ui.router as we using it for routing
var myDemoApp = angular.module('myDemoApp', ['ui.router', 'ui.grid']);

//$stateprovider is the service procided by ui.router
myDemoApp.config(['$stateProvider', function ($stateProvider) {
    //create route object
    var home = {
        url: '/home',
        templateUrl: '/app/templates/home.html',
        controller: 'HomeCtrl'
    },
    repositories = {
        url: '/repositories',
        templateUrl: '/app/templates/repo/repo-list.html',
        controller: 'RepoCtrl'
    };

    //Now add these route state privider

    $stateProvider
           .state('home', home)
           .state('repositories', repositories)
}]);