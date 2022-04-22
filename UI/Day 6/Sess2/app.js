var Employees = {

    empList: ["abc","pqr","xyz","jkl"],
    findEmployee: function(empName){
        let x = 0;
        let found = "Not Found";
        for(x=0; x<this.empList.length;x++){
            if(this.empList[x] == empName){
                //Employee was found
                found = this.empList[x];
                break;
            }                        
        }      
        return found;                  
    }
};


function Search(){
    let toFind = "pqr";    
    processResult(Employees.findEmployee(toFind));
}

function processResult(result){
    if(result =="Not Found"){
        document.getElementById("resultLabel").innerHTML = "Sorry..not found";
    }
    else{
        document.getElementById("resultLabel").innerHTML = result;
    }
}


