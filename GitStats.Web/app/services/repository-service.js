angular.module('myDemoApp')
    .service('RepoService', ['$log', '$http', function ($log, $http) {

        console.log('repo service created!')

        return {
            list: function () {
                 return $http.get("/api/repo/list");
            }
        };

    }])