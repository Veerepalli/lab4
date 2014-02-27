var echo = function(dataPass) {
    $.ajax({
        type: "POST",
        url: "/echo/json/",
        data: dataPass,
        cache: false,
        success: function(json) {
            alert("Operation="+json.Operation+"\nResult="+json.Output);
        }
    });
};
$('.add').live('click', function() {
   var url="http://localhost/aspnet_client/restful/Service1.svc/addition/"+document.getElementById('v1').value+"/"+document.getElementById('v2').value ;
   
   $.get(url, function(data) {
        var json = {
            json: JSON.stringify(data),
            delay: 1
        };
        echo(json);
    });
});
$('.sub').live('click', function() {
   var url="http://localhost/aspnet_client/restful/Service1.svc/subtraction/"+document.getElementById('v1').value+"/"+document.getElementById('v2').value ;
   
   $.get(url, function(data) {
        var json = {
            json: JSON.stringify(data),
            delay: 1
        };
        echo(json);
    });
});
$('.mul').live('click', function() {
   var url="http://localhost/aspnet_client/restful/Service1.svc/multiplication/"+document.getElementById('v1').value+"/"+document.getElementById('v2').value ;
   
   $.get(url, function(data) {
        var json = {
            json: JSON.stringify(data),
            delay: 1
        };
        echo(json);
    });
});
$('.divi').live('click', function() {
   var url="http://localhost/aspnet_client/restful/Service1.svc/division/"+document.getElementById('v1').value+"/"+document.getElementById('v2').value ;
   
   $.get(url, function(data) {
        var json = {
            json: JSON.stringify(data),
            delay: 1
        };
        echo(json);
    });
});
