function login_btn() {
    var username = $("#name").val();
    var userpwd = $("#psw").val();
    //alert(username);
    if (username == "" || userpwd == "")
        alert("用户名或密码不能为空！");

    $.ajax({
        method:"get",
        url: "serverFile/LoginSev.ashx",
        data: { "name": username, "pwd": userpwd },
        //error: function (request) { alert("DB连接失败") },
        success: function (data) {
            console.log(data);
            if (data == "用户名或密码错误!")
                alert(data);
            else
                alert(data+"-登录成功!");
        }



        })



    
}