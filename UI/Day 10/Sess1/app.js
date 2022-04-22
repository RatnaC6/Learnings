$(document).ready(function(){
    //Run when the page has been loaded
 
    $("#addButton").click(function(){
        let item = $("#itemTextBox").val();        
        let qty = $("#qtyTextBox").val();

        let valueToAdd = "<p>"+qty+" of "+ item + "</p>";      

        //String Interpolation - ES6 Standard (2015)
        //let valueToAddAlso = "<p>${qty} of ${item}";

        $("#itemsToBuy").append(valueToAdd);         
        
        //Clear the Text Boxes
        $("#itemTextBox").val('');        
        $("#qtyTextBox").val('');
    });
});