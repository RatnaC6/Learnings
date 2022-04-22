function getLocation(){
    navigator.geolocation.getCurrentPosition(function(position){
        document.getElementById("errorLabel").style.visibility = "collapse";
        document.getElementById("latitudePara").innerHTML = "Latitude : " + position.coords.latitude;
        document.getElementById("longitudePara").innerHTML = "Longitude : " + position.coords.longitude;
    },
    function(err){
        document.getElementById("errorLabel").innerHTML = "Please allow Location Access to continue..";
    });
}