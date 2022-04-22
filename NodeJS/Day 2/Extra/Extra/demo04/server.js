const http=require('http');
const port=3000;//65535->0-1024 u can use >1024
//http=> listen http req ->respont by http response
function onRequest(req,resp){
    resp.write("Welcome to node server");
    resp.end();
}

const server=http.createServer(onRequest);//What to do when request comes 
server.listen(port,()=>{
    console.log(`http://localhost:${port} started listening`);
})

