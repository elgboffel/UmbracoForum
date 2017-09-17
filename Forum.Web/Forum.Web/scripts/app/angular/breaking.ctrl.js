var Application;
(function (Application) {
    var Breaking = (function () {
        function Breaking($scope, $cookies) {
            this.$scope = $scope;
            this.$cookies = $cookies;
            var _scope = this.$scope;
            var _cookies = this.$cookies;
            // Setting a cookie
            _scope.setCookie = function () {
                var element = $('.breaking');
                var expireDate = new Date();
                expireDate.setDate(expireDate.getDate() + _scope.expireDate);
                _cookies.put('breaking', _scope.cookieValue, { 'expires': expireDate, 'path': '/' });
                element.slideUp(200);
            };
        }
        return Breaking;
    }());
    Application.app.controller('breakingCtrl', Breaking);
})(Application || (Application = {}));
//# sourceMappingURL=breaking.ctrl.js.map