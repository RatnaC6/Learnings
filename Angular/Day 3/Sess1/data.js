const promise = require('bluebird'); // or any other Promise/A+ compatible library;

const initOptions = {
    promiseLib: promise // overriding the default (ES6 Promise);
};

const pgp = require('pg-promise')(initOptions);
// See also: http://vitaly-t.github.io/pg-promise/module-pg-promise.html

// Database connection details;
const cn = {
    host: 'localhost', // 'localhost' is the default;
    port: 5432, // 5432 is the default;
    database: 'Northwind',
    user: 'postgres',
    password: 'root',

    // to auto-exit on idle, without having to shut-down the pool;
    // see https://github.com/vitaly-t/pg-promise#library-de-initialization
    allowExitOnIdle: true
};
// You can check for all default values in:
// https://github.com/brianc/node-postgres/blob/master/packages/pg/lib/defaults.js

const db = pgp(cn); // database instance;

var data = undefined;

db.any("SELECT Product_Name From Products;")
  .then((data) => {          
      for(let x = 0;x<data.length;x++){
        console.log(data[x].product_name);
      }
      this.data = data;
   })
  .catch((error) => {
    console.log('ERROR:', error);
  });

// function ShowDataInPage(data){
//     $.each(data, function(index, value){
//         $("#cardBody").append(value.product_name);
//     });
// }

// function ShowDataInConsole(data){
//     $.each(data, function(index, value){
//         console.log(value.product_name);
//     });
// }

const express = require("express");
const server = express();
const port = 3000;

server.get("/", (req,res) =>{
  res.send(data);
});

server.listen(port,()=> console.log("Server started"));