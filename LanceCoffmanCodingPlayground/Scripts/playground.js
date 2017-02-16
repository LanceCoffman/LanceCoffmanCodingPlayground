/* Code built by Lance Coffman for this websie*/

var jumboHeight = $('.jumbotron2').outerHeight();
function parallax() {
    var scrolled = $(window).scrollTop();
    $('.bg2').css('height', jumboHeight - scrolled + 'px');
}

$(window).scroll(function (e) {
    parallax();
});