function SomeWork(){
    var x = 0;
    for(x=0;x<4190202;x++){
        //Some long running activity
    }
    
    alert("Ready");

    BackgroundWork();
    alert("Some work started in the background");
}

function BackgroundWork(){

    if(Worker){
        //Web Worker supported by the Web Browser
        //Create a Web Worker object to run the specified JavaScript file
        let w = new Worker("background.js");
        w.onmessage = function(event){
            //get the value of count and show it in the page
            document.getElementById("countLabel").innerHTML = event.data;
        };

        //When the worker's job is completed
        //w.terminate();

        //De-allocate the Web Worker
        //w = undefined;
    }
}