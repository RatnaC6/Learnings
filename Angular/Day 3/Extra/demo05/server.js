const express=require('express');
const server=express();
const port=3000;
server.use(express.json());
server.use(express.urlencoded({extended:true}));
// ############################################
const contacts=[
    {"id":1,"firstName":"Sanjay"},
    {"id":2,"firstName":"Ajay"},
    {"id":3,"firstName":"Vijay"},
    {"id":4,"firstName":"Sujay"}
]
// ############################################
//default page
server.get('/',(req,resp)=>{
  resp.sendFile(__dirname+"/index.html");  
})
server.get('/jquery.min.js',(req,resp)=>{
    resp.sendFile(__dirname+"/node_modules/jquery/dist/jquery.min.js");  
  })
  server.get('/bootstrap.min.css',(req,resp)=>{
    resp.sendFile(__dirname+"/node_modules/bootstrap/dist/css/bootstrap.min.css");  
  })
  server.get('/bootstrap.min.js',(req,resp)=>{
    resp.sendFile(__dirname+"/node_modules/bootstrap/dist/js/bootstrap.min.js");  
  })
  server.get('/style.css',(req,resp)=>{
    resp.sendFile(__dirname+"/css/style.css");  
  })
  server.get('/app.js',(req,resp)=>{
      resp.sendFile(__dirname+'/js/app.js');
  })
// GET 	Show all Contacts   :/contacts
server.get("/contacts",(req,resp)=>{
    resp.setHeader("Content-Type","application/json");
    resp.send(contacts);
});  
// POST	Add New Contacts	:/add_contact
server.post("/add_contact",(req,resp)=>{
    resp.setHeader("Content-Type","application/json");
    //    {"id":1,"firstName":"Sanjay"}
    const firstName=req.body.firstName;
    const id=contacts[contacts.length-1].id+1;
    const new_contact={"id":id,"firstName":firstName};
    contacts.push(new_contact);
    resp.send(new_contact);
});
// PUT 	Update Old Conact  :/update_contact/:id
server.put("/update_contact/:id",(req,resp)=>{
    resp.setHeader("Content-Type","application/json");
    const id=parseInt(req.params.id);
    const firstName=req.body.firstName;    
    contacts.forEach(element=>{
        if(element.id===id){
            element.firstName=firstName
            resp.send(contacts);
        }
    });
    
});
// DELETE 	Delete Contact      :/delete_contact/:id
server.delete("/delete_contact/:id",(req,resp)=>{
    resp.setHeader("Content-Type","application/json");
    const id=parseInt(req.params.id);
    let contact={"id":0,"firstName":""};
    contacts.pop();
    resp.send({"message":id+"deleted"});
      
});

server.listen(port,()=>{
    console.log(`http://localhost:${port} started `);
})