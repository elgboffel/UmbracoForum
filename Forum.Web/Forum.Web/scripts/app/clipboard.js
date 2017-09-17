$(function () {
    var clipboard = new Clipboard('#copy-link');
    $('.clipboard a').on('click', function (e) {
        e.preventDefault();
    });
});
