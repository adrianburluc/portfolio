function checkIfImputEquals0(){
  var numar = document.getElementById("input").textContent;
  if(numar.substr(numar.length - 1)=='0' && parseFloat(numar)==0){
      document.getElementById("input").innerHTML = "";
  }
}

function btn0(){
  if(parseFloat(document.getElementById("input").textContent)!=0){
    if(amFolositSemn==true)
    {
      document.getElementById("input").innerHTML = "";
      amFolositSemn=false;
    }
    if(amFolositEgal==true)
    {
      document.getElementById("input").innerHTML = "";
      document.getElementById("ecuatie").innerHTML = "";
      ecuatie=0;
      amFolositEgal=false;
    }
    document.getElementById("input").innerHTML += "0";
  }


}
function btn1(){
  checkIfImputEquals0();
  if(amFolositSemn==true)
  {
    document.getElementById("input").innerHTML = "";
    amFolositSemn=false;
  }
  if(amFolositEgal==true)
  {
    document.getElementById("input").innerHTML = "";
    document.getElementById("ecuatie").innerHTML = "";
    ecuatie=0;
    amFolositEgal=false;
  }
  document.getElementById("input").innerHTML += "1";
}

function btn2(){
  checkIfImputEquals0();
  if(amFolositSemn==true)
  {
    document.getElementById("input").innerHTML = "";
    amFolositSemn=false;
  }
  if(amFolositEgal==true)
  {
    document.getElementById("input").innerHTML = "";
    document.getElementById("ecuatie").innerHTML = "";
    ecuatie=0;
    amFolositEgal=false;
  }
  document.getElementById("input").innerHTML += "2";
}

function btn3(){
  checkIfImputEquals0();
  if(amFolositSemn==true)
  {
    document.getElementById("input").innerHTML = "";
    amFolositSemn=false;
  }
  if(amFolositEgal==true)
  {
    document.getElementById("input").innerHTML = "";
    document.getElementById("ecuatie").innerHTML = "";
    ecuatie=0;
    amFolositEgal=false;
  }
  document.getElementById("input").innerHTML += "3";
}

function btn4(){
  checkIfImputEquals0();
  if(amFolositSemn==true)
  {
    document.getElementById("input").innerHTML = "";
    amFolositSemn=false;
  }
  if(amFolositEgal==true)
  {
    document.getElementById("input").innerHTML = "";
    document.getElementById("ecuatie").innerHTML = "";
    ecuatie=0;
    amFolositEgal=false;
  }
  document.getElementById("input").innerHTML += "4";
}

function btn5(){
  checkIfImputEquals0();
  if(amFolositSemn==true)
  {
    document.getElementById("input").innerHTML = "";
    amFolositSemn=false;
  }
  if(amFolositEgal==true)
  {
    document.getElementById("input").innerHTML = "";
    document.getElementById("ecuatie").innerHTML = "";
    ecuatie=0;
    amFolositEgal=false;
  }
  document.getElementById("input").innerHTML += "5";
}

function btn6(){
  checkIfImputEquals0();
  if(amFolositSemn==true)
  {
    document.getElementById("input").innerHTML = "";
    amFolositSemn=false;
  }
  if(amFolositEgal==true)
  {
    document.getElementById("input").innerHTML = "";
    document.getElementById("ecuatie").innerHTML = "";
    ecuatie=0;
    amFolositEgal=false;
  }
  document.getElementById("input").innerHTML += "6";
}

function btn7(){
  checkIfImputEquals0();
  if(amFolositSemn==true)
  {
    document.getElementById("input").innerHTML = "";
    amFolositSemn=false;
  }
  if(amFolositEgal==true)
  {
    document.getElementById("input").innerHTML = "";
    document.getElementById("ecuatie").innerHTML = "";
    ecuatie=0;
    amFolositEgal=false;
  }
  document.getElementById("input").innerHTML += "7";
}

function btn8(){
  checkIfImputEquals0();
  if(amFolositSemn==true)
  {
    document.getElementById("input").innerHTML = "";
    amFolositSemn=false;
  }
  if(amFolositEgal==true)
  {
    document.getElementById("input").innerHTML = "";
    document.getElementById("ecuatie").innerHTML = "";
    ecuatie=0;
    amFolositEgal=false;
  }
  document.getElementById("input").innerHTML += "8";
}

function btn9(){
  checkIfImputEquals0();
  if(amFolositSemn==true)
  {
    document.getElementById("input").innerHTML = "";
    amFolositSemn=false;
  }
  if(amFolositEgal==true)
  {
    document.getElementById("input").innerHTML = "";
    document.getElementById("ecuatie").innerHTML = "";
    ecuatie=0;
    amFolositEgal=false;
  }
  document.getElementById("input").innerHTML += "9";
}

function btnPct(){
  var numar = document.getElementById("input").textContent;
  if(numar.includes(".")==false)
  {
    document.getElementById("input").innerHTML += ".";
  }
}

function clearC(){
  var numarString = document.getElementById("input").textContent;
  var numar = parseFloat(numarString);
  if(numar!=0 || numarString.substr(numarString.length - 1)=='.')
  {
    document.getElementById("input").innerHTML = numarString.slice(0, -1);
  }
  if(document.getElementById("input").innerHTML == "")
  {
    document.getElementById("input").innerHTML = "0";
  }
}

function clearCE(){
  document.getElementById("input").innerHTML = "0";
  document.getElementById("ecuatie").innerHTML = "";
  ecuatie=0;
}

function getNumber(){
  var numar = parseFloat(document.getElementById("input").textContent);
  return numar;
}

function aFolositSimbol(){
  if(semn!=""){
    return true;
  }
  return false;
}

var semn="+";
var ecuatie=0;
var amFolositSemn=false;
var amFolositEgal=false;
function btnPlus(){
  verificaSemn();
  document.getElementById("ecuatie").innerHTML+=" + ";
  semn="+";
}

function btnMinus(){
  verificaSemn();
  document.getElementById("ecuatie").innerHTML+=" - ";
  semn="-";
}

function btnInmultit(){
  verificaSemn();
  document.getElementById("ecuatie").innerHTML+=" * ";
  semn="*";
}

function btnImpartit(){
  verificaSemn();
  document.getElementById("ecuatie").innerHTML+=" / ";
  semn="/";
}

function verificaSemn(){
  if(amFolositEgal==false)
  {
    if(semn=="+"){
      ecuatie=ecuatie+getNumber();
    }
    else if(semn=="-"){
      ecuatie=ecuatie-getNumber();
    }
    else if(semn=="*"){
      ecuatie=ecuatie*getNumber();
    }
    else if(semn=="/"){
      ecuatie=ecuatie/getNumber();
    }
  }
  else {
      amFolositEgal=false;
  }
  document.getElementById("ecuatie").innerHTML+=getNumber();
  document.getElementById("input").innerHTML=ecuatie;
  amFolositSemn=true;
}

function btnEgal(){
  var lastnumber=getNumber();
  amFolositEgal=true;
  document.getElementById("ecuatie").innerHTML=ecuatie;
  if(semn=="+")
  {
    ecuatie=ecuatie+lastnumber;
    document.getElementById("ecuatie").innerHTML+=" + "+lastnumber+" = ";
  }
  if(semn=="-")
  {
    ecuatie=ecuatie-lastnumber;
    document.getElementById("ecuatie").innerHTML+=" - "+lastnumber+" = ";
  }
  if(semn=="*")
  {
    ecuatie=ecuatie*lastnumber;
    document.getElementById("ecuatie").innerHTML+=" * "+lastnumber+" = ";
  }
  if(semn=="/")
  {
    ecuatie=ecuatie/lastnumber;
    document.getElementById("ecuatie").innerHTML+=" / "+lastnumber+" = ";
  }
  document.getElementById("input").innerHTML = ecuatie;

}
