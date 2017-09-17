namespace App {
    export class Surface {
        private _element: HTMLElement;
        private _url: string

        constructor(element: HTMLElement) {
            this._element = element;
            this._url = window.location.href;
            this.visible();
        }

        visible() {
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
        }
    }
}

$(function () {
    var elements = $('.surface-btn');
    for (var i = 0; i < elements.length; i++) {
        var inti = new App.Surface(<HTMLElement>elements[i]);
    }
})