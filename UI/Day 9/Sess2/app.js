$(document).ready(function(){
    //Run when the page has been loaded
    $("#resultCard").toggle();
    $("#okButton").click(function(){
        let pName = $("#nameTextBox").val();        
        let pLocation = $("#locationTextBox").val();

        $("#cardTitle").html("Person's Details");

        $("#namePara").html("Name : "+ pName);
        $("#locationPara").html("Based at : "+ pLocation);

        //$("#resultCard").css("visibility","visible");      
        $("#resultCard").toggle();
        //$("#resultCard").slideDown(10000);

        $("#resultCard").toggleClass("highlighted");
        $("#resultCardHeader").toggleClass("highlighted-heading");
    });
});