var names = ["abc","pqr","xyz","jkl"];

var x = 0;

//array.length is the number of items
for(x = 0;x < names.length; x++){
    
    let listItem = document.createElement("li"); //declare an <li> tag
    let itemValue = document.createTextNode(names[x]); //declare the value of <li> tag
    listItem.appendChild(itemValue); //put the value inside <li> tag
    document.getElementById("nameList").appendChild(listItem); //put the <li> tag inside the <ul> tag
}

//<li>abc</li>
//<ul id="nameList">
//  <li>abc</li>
//</ul>