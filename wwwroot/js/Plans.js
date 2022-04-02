let slideIndex = 1;
showSlides(slideIndex,1);
showSlides(slideIndex,2);
showSlides(slideIndex, 3);

function plusSlides(n,no) {
    showSlides(slideIndex += n,no);
}

function currentSlide(n,no) {
    showSlides(slideIndex = n,no);
}

function showSlides(n,no) {
    let i;
    let slides = document.getElementsByClassName("mySlides"+no);
    let dots = document.getElementsByClassName("dot"+no);
    if (n > slides.length) { slideIndex = 1 }
    if (n < 1) { slideIndex = slides.length }
    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    slides[slideIndex - 1].style.display = "block";
}



    function on() {
        document.getElementById("overlay").style.display = "block";
}

    function off() {
        document.getElementById("overlay").style.display = "none";
}
