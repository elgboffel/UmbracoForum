var App;
(function (App) {
    var Surface = (function () {
        function Surface(element) {
            this._element = element;
            this._url = window.location.href;
            this.visible();
        }
        Surface.prototype.visible = function () {
            //var body = $('body');
            //var hideClass = 'surface--hide-scroll';
            //var visibleClass = 'surface--visible';
            //var url = this._url;
            //$(this._element).on('click', function () {
            //    var guid = $(this).data().surface;
            //    var surface = $('.surface[data-surface="' + guid + '"]');
            //    body.toggleClass(hideClass);
            //    surface.toggleClass(visibleClass);
            //    document.location.hash = 'surface=visible';
            //});
            //$('.surface__close').on('click', function () {
            //    var surface = $(this).closest('.surface');
            //    body.toggleClass(hideClass);
            //    surface.toggleClass(visibleClass);
            //});
        };
        return Surface;
    }());
    App.Surface = Surface;
})(App || (App = {}));
$(function () {
    var elements = $('.surface-btn');
    for (var i = 0; i < elements.length; i++) {
        var inti = new App.Surface(elements[i]);
    }
});
//# sourceMappingURL=surface.js.map