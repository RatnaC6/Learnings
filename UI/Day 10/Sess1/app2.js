$(document).ready(function(){
    let url = "https://api.jquery.com/jQuery.get/";    

    $("#loadButton").click(function(){
        // $.get(url,function(data){
        //     $("#contentDiv").html(data);
        // });

        $(document).append("<h2>Data</h2>");

        $("#contentDiv").load(url);
    });    
});