const http=require('http');
const port=3000;
// const server=http.createServer((req,resp)=>{
//     resp.write("Welcome to http module on node to create http server");
//     resp.end();
// });
// server.listen(port,()=>{
//     console.log(`http://localhost:${port} listening `);
// });

http.createServer((req,resp)=>{
    resp.write("Welcome to http module on node to create http server");
    resp.end();
}).listen(port,()=>{
    console.log(`http://localhost:${port} listening `);
});
//Arrow function  (req,resp)=>{}|()=>{}
// Function chaining: http.createServer((req,resp)=>{}).listen(port,()=>{});