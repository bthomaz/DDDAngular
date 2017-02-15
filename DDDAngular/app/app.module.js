(function () {
    'use strict';

    angular.module("app", ["ngResource"])
    .constant("appSettings",
    {
        serverPath: "http://localhost:3438/"
    });
})();