$(document).ready(function () {
    var rangePos = $("#range").offset();
    var rangeHeight = $("#range").height();
    var rangeWidth = $("#range").width();


    var isDraggingLeft = false;
    var isDraggingRight = false;
    var leftRangeHeight = $("#range-left").height();
    var leftRangeWidth = $("#range-left").width();
    var leftRangePos;
    var rightRangePos;

    $("#range")
        .mousedown(function (e) {
            leftRangePos = $("#range-left").offset();
            rightRangePos = $("#range-right").offset();
            if (e.pageX >= leftRangePos.left && e.pageX <= leftRangePos.left + leftRangeWidth &&
                    e.pageY >= leftRangePos.top && e.pageY <= leftRangePos.top + leftRangeHeight) {
                    isDraggingLeft = true;
                }

                if (e.pageX >= rightRangePos.left && e.pageX <= rightRangePos.left + leftRangeWidth &&
                    e.pageY >= rightRangePos.top && e.pageY <= rightRangePos.top + leftRangeHeight) {
    isDraggingRight = true;
                }
            })
            .mousemove(function (e) {
                if (e.pageX <= rangePos.left ||
                    e.pageX > (rightRangePos.left + leftRangeWidth / 2) ||
                    e.pageY < rangePos.top ||
                    e.pageY > rangePos.top + rangeHeight) {
    isDraggingLeft = false;
                }

                if (e.pageX <= leftRangePos.left + leftRangeWidth / 2 ||
                    e.pageX > rangePos.left + rangeWidth ||
                    e.pageY < rangePos.top ||
                    e.pageY > rangePos.top + rangeHeight) {
    isDraggingRight = false;
                }

                if (isDraggingLeft) {
    $("#range-left").offset({ left: e.pageX - leftRangeWidth / 2 });
                }

                if (isDraggingRight) {
                     $("#range-right").offset({ left: e.pageX - leftRangeWidth / 2 });
                }

                $("#val").offset({left: $("#range-left").offset().left + leftRangeWidth / 2 });
                $("#val").width($("#range-right").offset().left - $("#range-left").offset().left + leftRangeWidth / 2);


            })
    .mouseup(function () {
        isDraggingLeft = false;
        isDraggingRight = false;
    });


});

$(document).ready(function () {
    $('a.close').click(function (e) {
        $('.quick-view-section').css('display', 'none');
    });
    $('a.quick-view').click(function (e) {
        e.preventDefault();
        $('.quick-view-section').css('display', 'block');
    });
});
  