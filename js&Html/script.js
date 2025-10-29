function alertMe() {
    alert("Hello World");
}

 
function LeapYear() {
   console.log(checkLeapYear());
}
function checkLeapYear() {
    
  const  year = document.getElementById("yearInput").value;
     if ((year % 4 === 0 && year % 100 !== 0) || (year % 400 === 0)) {
        return year + " is a leap year.";
    } else {
        return year + " is not a leap year.";
    }
    
}


