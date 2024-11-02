document.addEventListener('DOMContentLoaded', function () {
    const decreaseButton = document.querySelector('.btn-decrease');
    const increaseButton = document.querySelector('.btn-increase');
    const quantityInput = document.querySelector('.quantity-input');
  
    decreaseButton.addEventListener('click', function () {
      let currentValue = parseInt(quantityInput.value);
      if (currentValue > 1) {
        quantityInput.value = currentValue - 1;
      }
    });
  
    increaseButton.addEventListener('click', function () {
      let currentValue = parseInt(quantityInput.value);
      quantityInput.value = currentValue + 1;
    });
  });