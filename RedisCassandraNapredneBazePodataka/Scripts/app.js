$(document).ready(function () {
    $(window).scroll(function () {
        var scrollTop = $(window).scrollTop();
        if (scrollTop > 0)
            $('.navbar').addClass('fixed-top');
        else if (scrollTop <= 0)
            $('.navbar').removeClass('fixed-top');
    });
});