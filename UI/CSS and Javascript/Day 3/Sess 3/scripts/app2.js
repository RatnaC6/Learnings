//To be called when the button is clicked
function ShowMessage(){
    var x = 2, y = 3;
    //If declared in a function, message will be a global variable
    //messageText = "Hi from Viren";
    var messageHeading = "<h3>Greetings</h3>";
    var messageText = "Hi from Viren";

    // document.write(x+y);
    // document.write(messageText);
    //Show messageHeading variable's value inside the sectionHeading Div (Text format)
    //document.getElementById("sectionHeading").innerText = messageHeading;
    document.getElementById("sectionHeading").innerHTML = messageHeading;
    //Show messageText variable's value inside the message paragraph (HTML format)
    document.getElementById("message").innerHTML = messageText;
}