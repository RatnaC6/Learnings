//Global
x = 1;
var message = "Hello";

function ShowMessage()
{
    //y is Global since "var" was not used
    y = 10;

    //Local
    var message2 = "Hello too";
    //alert(message2);

    if(y > 0)
    {
        //If result does not exist it will be created
        let result = SquareOf(y); //result is local to if block
        alert(result);
    }
    else
    {
        alert("Can't square 0");
    }   
    //alert(result);
}

var SquareOf = function(num)
{
    return num * num;
}

//ShowMessage(); //Call ShowMessage function

//alert(message2);
// alert(message);
// alert(y);
