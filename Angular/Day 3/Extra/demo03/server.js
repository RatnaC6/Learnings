const express=require('express');
const server=express();
const port= 3000;
const users=[
    {"id":1,"firstName":"abc"},
    {"id":2,"firstName":"pqr"},
    {"id":3,"firstName":"xyz"},
    {"id":4,"firstName":"jkl"}
]
server.get("/",(req,resp)=>{
    resp.sendFile(__dirname+"/index.html");
})
server.get('/users',(req,resp)=>{
    resp.setHeader("Content-Type","application/json");
    resp.send(users);
})

server.use(express.json());
server.use(express.urlencoded({extended:true}))

//http://localhost:3000/user/1 } direct link
server.get('/user/:id',(req,resp)=>{
    resp.setHeader("Content-Type","application/json");
    const id=parseInt(req.params.id);    
    users.forEach(element=>{
        if(element.id===id){
            resp.send(element);
        }
    })  
})
//http://localhost:3000/user?id=1->urlencoded data }Form
server.get('/user',(req,resp)=>{
    const id=parseInt(req.query.id);
    resp.setHeader("Content-Type","application/json");
    users.forEach(element=>{
        if(element.id===id){
            resp.send(element);
        }
    })      
})

// http://localhost:3000/add_user
server.post("/add_user",(req,resp)=>{
    const id=users.length+1;
    const firstName=req.body.firstName;
    const user={"id":id,"firstName":firstName};
    users.push(user);
    resp.setHeader("Content-Type","application/json");
    resp.send(users);
})

server.listen(port,()=>{
    console.log(`http://localhost:${port} Started`);
})
