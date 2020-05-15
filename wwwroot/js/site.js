// When the user clicks on <div>, open the popup
function funcaoTele() {
  var popup = document.getElementById("myPopup");
  popup.classList.toggle("show");
}

function funcaoPop() {
    var popup1 = document.getElementById("myPopup1");
    popup1.classList.toggle("show");
}

//Get the button:
mybutton = document.getElementById("myBtn");

// When the user scrolls down 20px from the top of the document, show the button
window.onscroll = function() {scrollFunction()};

function scrollFunction() {
  if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
    mybutton.style.display = "block";
  } else {
    mybutton.style.display = "none";
  }
}

// When the user clicks on the button, scroll to the top of the document
function topFunction() {
  document.body.scrollTop = 0; // For Safari
  document.documentElement.scrollTop = 0; // For Chrome, Firefox, IE and Opera
}