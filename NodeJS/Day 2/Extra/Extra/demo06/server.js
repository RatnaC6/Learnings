
// const cf=require('./createFile');
const rf=require('./readFile');
const http=require('http');
const port=3000;
const server=http.createServer((req,resp)=>{
    //cf();
    // resp.write("Welcome server created file ");
    const data=rf();
    console.log(data); //undefined data
    resp.write("Data on file is :"+data);
    resp.end();
});
server.listen(port,()=>{
    console.log(`Server Started : http://localhost:${port}`);
})
