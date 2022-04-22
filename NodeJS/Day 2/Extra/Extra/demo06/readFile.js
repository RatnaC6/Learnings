const fs=require('fs');

function readData(){
    fs.readFileSync("test.txt",(err,data)=>{
        if(err){
            console.log("err:: "+err);
            return err;
        }
        console.log("data:: "+data);
        return data;
    })

}

module.exports=readData;
