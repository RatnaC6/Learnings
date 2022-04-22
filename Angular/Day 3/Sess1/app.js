$(function(){
    $.getJSON("http://localhost:3000",function(data){
        $.each(data, function(index,value){
            $("#cardBody").append(value.product_name);
        });       
    });
});