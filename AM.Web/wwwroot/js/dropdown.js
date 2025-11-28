const dropdownLinks = document.querySelectorAll('.dropdown-content a');
const statusText = document.getElementById('status-text');
const statusValue = document.getElementById('order-status');

dropdownLinks.forEach(link => {
  link.addEventListener('click', function(e) {
      statusText.textContent = this.textContent;

      if (this.getAttribute("data-value") === "finished") {
          statusValue.checked = true;
      } else {
          statusValue.checked = false;
      }
  });
});