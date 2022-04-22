var Employees = {

    empList: ["abc","pqr","xyz","jkl"],
    findEmployee: function(empName, callBackFunction){
        let x = 0;
        let found = "Not Found";
        for(x=0; x<this.empList.length;x++){
            if(this.empList[x] == empName){
                //Employee was found
                found = this.empList[x];
                break;
            }                        
        }
       
        //What to do next
        //Check if the function was provided
        if(callBackFunction){
            //If the function was provided           
            callBackFunction(found);
        }
        else{
            //No callback - return the found variable as default
            return found;
        }            
    }
};

var ShowResult = function(result){
    alert(result);
}

// var ShowResult2 = function(result){
//     document.getElementById("resultLabel").innerHTML = result;
// }

function Search(){
    let toFind = "pqr";    
    //Employees.findEmployee(toFind, ShowResult2); 
    Employees.findEmployee(toFind),ShowResult;    
}

