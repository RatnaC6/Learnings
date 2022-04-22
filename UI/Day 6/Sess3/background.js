var count = 0;

function DoSomething(){
    count++;
    //Send a message back to the main track
    postMessage(count);
    //Set the function to run once in 5000 milliseconds
    setTimeout("DoSomething()",5000);   
}

//Run the function 1st time
DoSomething();