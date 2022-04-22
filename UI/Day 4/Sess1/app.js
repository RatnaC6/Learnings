var canvas1 = document.getElementById("canvas1");

var context = canvas1.getContext("2d");

context.moveTo(400,300);

context.lineTo(520,400);

context.stroke();

context.moveTo(50,300);

context.lineTo(90,60);

context.lineTo(130,190);

context.stroke();

context.font = "20px Arial";
context.fillText("Hi from Viren",220,200);
