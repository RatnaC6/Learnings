// Use req.method,req.url and json object with resp.setHeader("Content-type")
const http=require('http')
const port=3000;
const server=http.createServer((req,resp)=>{
    const method=req.method;//GET/PUT/POST/DELETE
    const url=req.url;
    // resp.setHeader('Content-Type','text/html');
    resp.setHeader('Content-Type','text/html');
    const message={"Method":method,"URL":url};//JSON object 
    resp.write("Welcome to html!<br/>")
    resp.write("Welcome to html!<br/>")
    resp.write("Welcome to html!<br/>")
    resp.write("<br/>message="+message);//[object Object]
    resp.write("<br/>message.Method ="+message.Method+" "+message.URL);//[object Object]
    resp.write("<br/>JSON.stringify(message) ="+JSON.stringify(message));//[object Object]
    resp.end();
});

server.listen(port,()=>{
    console.log(`Server Started  http://localhost:${port} `);
});