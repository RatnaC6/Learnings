$(document).ready(function(){
    //Run when the page has been loaded
 
    $("#loadButton").click(function(){
        
      $("#contentDiv").load("index2.html");

    //   jquery.get("index2.html",function(data){
    //     $("#contentDiv").html(data);
    //   });

    //   $.getJSON("data.json", function(data){
    //     alert(data);
    //   });

    //   $.ajax()
    });
});