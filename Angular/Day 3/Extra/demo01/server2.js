//req.method.GET and req.url for specific output
const http=require('http');//to create server on http protocol
const fs=require('fs');//to read file and give data to response object
const port=3000;
const server=http.createServer((req,resp)=>{
    //Specific to GET method
    const url=req.url;
    resp.setHeader("Content-Type","text/html");
    switch(url){
        case "/": 
        //index.html
            fs.readFile("index.html",(err,data)=>{
                if(err){
                    resp.write(err);
                }
                resp.write(data);
                resp.end();
            });
            break;
        case "/aboutus": 
        case "/aboutus.html": 
        //aboutus.html
            fs.readFile("aboutus.html",(err,data)=>{
                if(err){
                    resp.write(err);
                }
                resp.write(data);
                resp.end();
            });
            break;
        case "/user": 
        case "/user.json": 
        //user.json
            fs.readFile("user.json",(err,data)=>{
                if(err){
                    resp.write(err);
                }
                resp.write(data);
                resp.end();
            });
            break;

    }
    // resp.end();

}).listen(port,()=>{
    console.log(`http://localhost:${port} Strated`);
})

//We will make call using GET method for below urls
// 1. url => / default home page of a website
// 2. url => /aboutus
// 3. url => /user
