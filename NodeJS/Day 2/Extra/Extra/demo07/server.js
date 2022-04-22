const http=require('http');
const fs=require('fs');
const port=3000;

http.createServer((req,resp)=>{
    fs.readFile("test.txt",(err,data)=>{
        if(err){
            console.log("err:: "+err);
            resp.write(err);
        }
        resp.write("data:: "+data);
        resp.end();
    })
}).listen(port,()=>{
    console.log(`Server Started:: http://localhost:${port} `);
});