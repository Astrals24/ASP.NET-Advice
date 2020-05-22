function register() {
    var name = $("#rg_name").val();
    var pwd = $("#rg_pwd").val();
    var sex = $("#rg_sex").val();
    var address = $("#rg_adress").val();
    var phone = $("#rg_phone").val();

    if (name == "" || pwd == "" || sex == "" || address == "")
        alert("不能为空");
    else {
        $.ajax({
            url: "serverFile/RegisterSev.ashx",
            method:"get",
            data: { "uname": name, "upwd": pwd, "uphone": phone, "usex": sex, "uadress": address },
            //error: function (request) {
            //    alert("DB 连接失败!")
           // },
            success: function (data) {
                alert(data);
                if (data ==name+ "注册成功")
                    window.location.href = "Login.html";
                else
                    alert(data);

            }

        })


    }

}