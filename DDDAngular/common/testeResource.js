(function () {
    "use strict";

    angular
        .module("common.services")
        .factory("testeResource",
                ["$resource",
                 "appSettings",
                    productResource])

    function productResource($resource, appSettings) {
        return $resource(appSettings.serverPath + "/api/ApiHomeController/CarregaElementosBabacas/");
    }
}());

