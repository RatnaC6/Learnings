//JavaScript Object Notation (JSON)
//PersonName is an Object
var Person = {
    FirstName : "abc",
    LastName : "pqr",

    GetName : function(){        
        return this.FirstName + " " + this.LastName;
    },
    Qualifications:{
        School:"Maharashtra State Board School",
        Graduation:"BE in IT",
        PostGraduation: "ME in IT"//,
        //Certifications:["HTML","SQL",".Net","Cloud"]
    },
    GetQualification : function(){
        let qualificationDetail = "School : " + this.Qualifications.School + ",\r\n"
                                    + "Graduation : " + this.Qualifications.Graduation + ",\r\n"
                                    + "Post Graduation : "+ this.Qualifications.PostGraduation;

        return qualificationDetail;
        // return this.Qualifications.School + "," + this.Qualifications.Graduation + ","
        //         +this.Qualifications.PostGraduation;      
    }
};

function TakeData(){
    Person.FirstName = document.getElementById("pFirstName").value;
    Person.LastName = document.getElementById("pLastName").value;

    ShowData();
}

function ShowData(){
    document.getElementById("resultDiv").className="visible";
    document.getElementById("personName").innerHTML = Person.GetName();
}

//Accessing members of PersonName object
// alert(Person.GetName());
// alert(Person.GetQualification());

//abcpqr //without space
//abc pqr //with space

