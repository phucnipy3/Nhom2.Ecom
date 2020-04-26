$(document).ready(function () {
    $('.selection').click(function () {
        $('.selection .option').toggleClass('open');
    });
    $('.selection .opt-item').click(function () {
        var val = $(this).children('span').text();
        $('.selection .select #value').text(val);
        // alert(val);
    });

    $('.cmt-info .rep').click(function (e) {
        e.preventDefault();
        $(this).parent().parent().children('.rep-cmt').toggleClass('active');
    });
});