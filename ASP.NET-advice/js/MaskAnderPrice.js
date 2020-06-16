function showMask(goodId) {
    var scroll = $(window).scrollTop();
    $("#mask").css("height", document.body.clientHeight);
    $("#mask").css("width", document.body.clientWidth);

    $("#xiangcai").css({
        "display": "block",
        "margin-top": scroll + 50
    })

    $("body").css("overflow","hidden");
    $("#mask").show();


    var gn = $("#goodsName" + goodId).html();
    var gp = $("#goodsPrice" + goodId).html();
    var goodtu = $("#goodtu" + goodId).attr("src");
    var info = $("#goodtu" + goodId).attr("alt");

    $("#xiangtu").attr("src", goodtu);
    $("#foodname").text("菜名:"+gn);
    $("#foodprice").text("菜价:"+ gp);
    $("#foodinfo").text("介绍信息:"+info);

}


function showMenue(code) {
    $("#goods").html("");
    $.ajax({
        type: "get",
        url: "serverFile/showMenue.ashx",
        data: { "lei": code },
        erroe: function (request) {
            alert("连接失败");
        },
        success: function (data) {
            var str = data;
            var obj;

            obj = eval('(' + str + ')');
            for (var i = 0; i < obj.data.length; ++i) {
                var id = "'" + obj.data[i].cid + "'";
                var str2 = '<div id="goodlist">' +
                    '<div id="goodtu">' +
                    '<img id="goodtu' + obj.data[i].cid + '" src="images/' + obj.data[i].img + '" alt="' + obj.data[i].info + '"/>' +
                    '</div>' +
                    '<div id="jiacai" onclick="jiadan(' + id + ')">' +
                    '<img src="images/magnify.png" />' +
                    '</div>' +
                    '<div id="goodnei">' +
                    '<ul>' +
                    '<li><span id="goodsName' + obj.data[i].cid + '">' + obj.data[i].name + '</span></li>' +
                    '<li><span id="goodsPrice' + obj.data[i].cid + '">' + obj.data[i].price + '</span>元/份<a onclick="showMask(' + id + ')">详情>></a></li>' +
                    '</ul>' +
                    '</div>' +
                    '</div>';

                $("#goods").append(str2);
            }
            


        }

    })


}


