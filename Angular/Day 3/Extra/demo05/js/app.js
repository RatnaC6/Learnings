// $(document).ready(function(){}) === $(function(){});
$(function(){
    $("#all_contact").on("click",function(){
        // $.get(action,what to do when received the response)
        $.get("contacts",function(data,status){
            console.log(data[0].id)
                // $("#result").text(JSON.stringify(data));
                alert(JSON.stringify(data))
        });
    });
    $("#update_contact").on("click",function(){
        alert("update called ");
        // make server call for put method 
        const id=$("#id").val();
        const firstName=$("#firstName").val();
        alert("id "+id);
        $.ajax({
            url:"update_contact/"+id,
            content:{"id":id,"firstName":firstName},
            type:"PUT",            
            success:function(result){
                $("#result").text(JSON.stringify(result));
            },
            error:function(result){
                $("#error").css("color","#ff0000");
                $("#error").text(JSON.stringify(result));                
            }
        })
    });
    $("#delete_contact").on("click",function(){
        alert("Delete Called !")
        $.ajax({
            url:"delete_contact/"+$("#id").val(),
            type:"DELETE",
            success:function(data){
                alert(JSON.stringify(data))
            },
            error:function(err){
                alert(JSON.stringify(err))
            }
        });

    });
});

