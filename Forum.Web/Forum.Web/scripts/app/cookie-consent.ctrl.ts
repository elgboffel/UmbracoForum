namespace Application {
    interface ICookieConsent extends ng.IScope {
        cookieValue: string;
        expireDate: number;
        setCookie(): void;
    }

    class CookieConsent {
        constructor(
            private $scope: ICookieConsent,
            private $cookies
        ) {
            var _scope = this.$scope;
            var _cookies = this.$cookies;

            // Setting a cookie
            _scope.setCookie = function () {
                var element = $('.cookie-consent');
                var expireDate = new Date();
                expireDate.setDate(expireDate.getDate() + 30);

                _cookies.put('CookieConsent', 1, { 'expires': expireDate, 'path': '/' });
                element.fadeOut(400);
            }
        }
    }

    angular.module("niras").controller('cookieConsentCtrl', CookieConsent);
}