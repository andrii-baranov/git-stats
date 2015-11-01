//here we need to inject ui.router as we using it for routing
var myDemoApp = angular.module('myDemoApp');

myDemoApp.controller('RepoCtrl', ['$scope', '$state','RepoService', function ($scope, $state, RepoService) {

    $scope.gridOptions =
        {
            enableRowSelection: true,
            enableRowHeaderSelection: false,
            multiSelect : false,
            modifierKeysToMultiSelect : false,
            noUnselect : true,
            rowTemplate: "<div ng-dblclick=\"grid.appScope.onDblClick(row)\" ng-repeat=\"(colRenderIndex, col) in colContainer.renderedColumns track by col.colDef.name\" class=\"ui-grid-cell\" ng-class=\"{ 'ui-grid-row-header-cell': col.isRowHeader }\" ui-grid-cell ></div>",
            onRegisterApi : function (gridApi) {
                $scope.gridApi = gridApi;
            },
            appScopeProvider: {
                onDblClick: function (row) {

                    $state.go("repository", { "id": row.entity.Name });
                }
            }
        };
   
    var promise = RepoService.list();

    promise.success(function(data) {
            $scope.gridOptions.data = data;
    });
}]);