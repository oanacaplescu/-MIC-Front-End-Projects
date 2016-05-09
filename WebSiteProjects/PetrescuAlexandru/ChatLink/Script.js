// JavaScript source code
//Petrescu Alexandru 311CD

var mesaj = "<br>";
var user1;
var user2;

function nume_user1() {
    //var camp_nume = document.getElementById("NUME1");
    user1 = (document.getElementById("NUME1")).value;
}

function nume_user2() {
    //var camp_nume = document.getElementById("NUME2");
    user2 = (document.getElementById("NUME2")).value;
}

function mesaj1() {
    //var camp_nume = document.getElementById("MESAJ1");
    var camp_mesaj = document.getElementById("MESAJ");	  
    //var aux= camp_nume.value;
    mesaj += user1+ ": " + (document.getElementById("MESAJ1")).value + "<br>";
    camp_mesaj.innerHTML = mesaj;
}

function mesaj2(){
    //var camp_nume = document.getElementById("MESAJ2");
    var camp_mesaj = document.getElementById("MESAJ");
    //var aux = camp_nume.value;
    mesaj += user2 + ": " + (document.getElementById("MESAJ2")).value + "<br>";
    camp_mesaj.innerHTML = mesaj;
}

function clear() {
    mesaj = "<br>";
    camp_mesaj.innerHTML = mesaj;
}