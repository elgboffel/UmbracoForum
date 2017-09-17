var App;
(function (App) {
    var SoMeShare = (function () {
        function SoMeShare() {
            this._element = $('.so-me--share');
            this.stickyShare();
        }
        SoMeShare.prototype.stickyShare = function () {
            var screenMdMin = window.matchMedia('(min-width: 991px)');
            if (screenMdMin.matches) {
                var element = this._element;
                var elementHeight = element.height();
                var elementOriginalTop = element.offset().top;
                var stickyClass = 'so-me--fixed';
                var stickBottomClass = 'so-me--stick-bottom';
                var productList = $('.product-list');
                var hasProductList = productList.length;
                var productListTop = hasProductList ? productList.offset().top : null;
                var footerTop = $('footer').offset().top - 150;
                var sticky = $('.' + stickyClass);
                var stickyTopHeight = 50;
                $(window).on('scroll', function () {
                    var windowPosition = $(this).scrollTop();
                    var elementTop = element.offset().top;
                    //Set as sticky
                    if (windowPosition + stickyTopHeight >= elementTop) {
                        element.addClass(stickyClass);
                    }
                    //set as sticky bottom at product list
                    if (hasProductList &&
                        windowPosition + stickyTopHeight * 2 >= productListTop - elementHeight) {
                        element.removeClass(stickyClass);
                        element
                            .addClass(stickBottomClass)
                            .css({ 'top': productListTop - elementOriginalTop - elementHeight - stickyTopHeight });
                    }
                    //set sticky bottom if footer is reached
                    if (!hasProductList &&
                        windowPosition + stickyTopHeight * 2 >= footerTop - elementHeight) {
                        element.removeClass(stickyClass);
                        element
                            .addClass(stickBottomClass)
                            .css({ 'top': footerTop - elementOriginalTop - elementHeight - stickyTopHeight });
                    }
                    //set sticky and remove sticky buttom at productList
                    if (hasProductList &&
                        windowPosition + stickyTopHeight * 2 < productListTop - elementHeight &&
                        windowPosition + stickyTopHeight * 2 >= elementTop) {
                        element.addClass(stickyClass);
                        element.removeClass(stickBottomClass).css({ 'top': stickyTopHeight });
                    }
                    //set sticky and remove sticky buttom at footer
                    if (!hasProductList &&
                        windowPosition + stickyTopHeight * 2 < footerTop - elementHeight &&
                        windowPosition + stickyTopHeight * 2 >= elementTop) {
                        element.addClass(stickyClass);
                        element.removeClass(stickBottomClass).css({ 'top': stickyTopHeight });
                    }
                    //remove sticky
                    if (windowPosition + stickyTopHeight < elementOriginalTop) {
                        element.removeClass(stickyClass);
                    }
                });
            }
        };
        return SoMeShare;
    }());
    App.SoMeShare = SoMeShare;
})(App || (App = {}));
$(function () {
    var init = new App.SoMeShare();
});
//# sourceMappingURL=so-me-share.js.map