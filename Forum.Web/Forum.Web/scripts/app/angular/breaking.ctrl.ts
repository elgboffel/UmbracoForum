namespace Application {
    interface IBreaking extends ng.IScope {
        cookieValue: string;
        expireDate: number;
        setCookie(): void;
    }

    class Breaking {
        constructor(
            private $scope: IBreaking,
            private $cookies
        ) {
            var _scope = this.$scope;
            var _cookies = this.$cookies;

            // Setting a cookie
            _scope.setCookie = function () {
                var element = $('.breaking');
                var expireDate = new Date();
                expireDate.setDate(expireDate.getDate() + _scope.expireDate);

                _cookies.put('breaking', _scope.cookieValue, { 'expires': expireDate, 'path': '/' });
                element.slideUp(200);

            }
        }
    }

    app.controller('breakingCtrl', Breaking);
}