var Application;
(function (Application) {
    var CookieConsent = (function () {
        function CookieConsent($scope, $cookies) {
            this.$scope = $scope;
            this.$cookies = $cookies;
            var _scope = this.$scope;
            var _cookies = this.$cookies;
            // Setting a cookie
            _scope.setCookie = function () {
                var element = $('.cookie-consent');
                var expireDate = new Date();
                expireDate.setDate(expireDate.getDate() + 30);
                _cookies.put('CookieConsent', 1, { 'expires': expireDate, 'path': '/' });
                element.fadeOut(400);
            };
        }
        return CookieConsent;
    }());
    angular.module("niras").controller('cookieConsentCtrl', CookieConsent);
})(Application || (Application = {}));
//# sourceMappingURL=cookie-consent.ctrl.js.map