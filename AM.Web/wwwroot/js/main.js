const hamburgerIcon = document.getElementById("hamburger");
const mainNav = document.getElementById("main-nav");
const closeBtn = document.getElementById("close-btn");

hamburgerIcon.addEventListener("click", () => {
    mainNav.classList.add("open-nav");
})

closeBtn.addEventListener("click", () => {
    mainNav.classList.remove("open-nav");
})