$(function () {

    var $el, leftPos;
    var hasActiveLink = $('.navbar__ancestor').length;

    if (hasActiveLink) {
        /* Add Magic Line markup via JavaScript, because it ain't gonna work without */
        $('.magic-hover .navbar__ancestor a').append('<div class="magic-hover__dot"></div>');

        var centerDot = $('.navbar__ancestor a').width() / 2;
        var originalLeft = $('.magic-hover .navbar__ancestor ').position().left;
        var originalDotPosition = originalLeft - centerDot;
        var dot = $('.magic-hover__dot');

        dot.css('left', centerDot);

        $('.magic-hover li').find('a').hover(function () {
            el = $(this);
            elementCenter = el.width() / 2;
            leftPos = el.position().left - originalLeft + elementCenter;

            dot.stop().animate({
                left: leftPos,

            });
        }, function () {
            dot.stop().animate({
                left: centerDot
            });
        });
    }
});