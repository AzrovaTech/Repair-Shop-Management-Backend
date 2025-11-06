const dropdownLinks = document.querySelectorAll('.dropdown-content a');
const statusText =  document.getElementById('status-text');

dropdownLinks.forEach(link => {
  link.addEventListener('click', function(e) {
    e.preventDefault();
    console.log(this.dataset.value);
    statusText.textContent = this.textContent;
  });
});