var fs = require('fs');
function createFile(){
    
fs.writeFile('test.txt', 'Hello World!', function (err) { 
    if (err)
        console.log(err);
    else
        console.log('Write operation complete.');
});


}

module.exports=createFile;