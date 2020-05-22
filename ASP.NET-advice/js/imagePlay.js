$(function () {
    // 轮播器的初始化
    var len = $("#banner img").length;
    var myul = "<ul>";
    for (var i = 0; i < len; ++i) {
        myul += "<li>*</li>"
    }
    myul += "</ul>"
    $(myul).appendTo($("#banner"));

    $("#banner img").css("opacity", 0).css("filter", 10);
    $("#banner img").eq(0).css("opacity", 1).css("filter", 10);

    var index = 0;
    var type = 1;    // 1 上下翻动  2 左右翻动
    var time = setInterval(fun, 2000)


    function banner(obj, prev) {
        if (type == 1) {
            $("#banner img").eq(prev).animate({
                opacity: '0',
                top: '150px'
            }, 2000).css("z-index", 1);

            $("#banner img").eq($(obj).index()).animate({
                opacity: '1',
                top: '0px'
            }, 2000).css("z-index", 2);
           // type = 2;
        }

        if (type == 2) {
            $("#banner img").eq(prev).animate({
                opacity: '0',
                left: '-900px'
            }, 2000).css("z-index", 1);

            $("#banner img").eq($(obj).index()).animate({
                opacity: '1',
                left: '0px'
            }, 2000).css("z-index", 2);
           // type = 1;
        }

    }

    function fun() {
        if (type == 1)
            type = 2;
        else
            type = 1;

        if (index >= len)
            index = 0;
        var x = (index == 0 ? len - 1 : index - 1);
    
        banner($("#banner ul li").eq(index), x);
        index++;
       
    }

});