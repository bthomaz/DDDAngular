(function () {
    "use strict";
    angular
        .module("app")
        .controller("TesteController",
                     ["testeResource",
                         TesteController]);
    
    function TesteController(testeResource) {
        var vm = this;

        testeResource.query(function (data) {
            vm.hometest = data;
        });
    }
}());