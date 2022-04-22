var progressValue = 1;
var timer = undefined;
function StartWork()
{
    timer = setTimeout(Work,3000);
    //alert("timer started");
}

function Work()
{ 
    var progressBar = document.getElementById("progressBar");
    progressValue+=5;    
    progressBar.innerHTML = toString(progressValue) + "%";
    progressBar.style.width = progressValue; //TODO: convert to percentage (if it is 5, then set is as 5%)
    //TODO: Set the value of aria-valuenow through JavaScript
    //alert(progressValue);

    if(progressValue>=95){
        clearTimeout(timer);        
    }
    else{
        setTimeout(Work,500);
    }             
}