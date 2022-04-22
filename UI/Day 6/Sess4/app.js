function allowDrop(eventData){
    //Prevent the default functionality from happening for safety reasons
    eventData.preventDefault();
}

function drag(eventData){
    eventData.dataTransfer.setData("text",eventData.target.id);
}

function drop(eventData){
    //Stop the default behavior
    eventData.preventDefault();
    //Get the item to be moved
    var data = eventData.dataTransfer.getData("text");
    //Placing the item in the destination
    eventData.target.appendChild(document.getElementById(data));
}