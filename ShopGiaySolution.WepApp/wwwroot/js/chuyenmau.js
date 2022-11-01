var checbox_toggle = document.getElementById('light-dark');
var container__note = document.querySelectorAll('.container__note');
var container__list_product_noboder = document.querySelectorAll('.container__list-product-noboder');
var container_banner = document.querySelector('.container-banner');
var container__news = document.querySelector('.container__news');
checbox_toggle.addEventListener('change', function () {
    document.body.classList.toggle('dark');
    for (let index = 0; index < container__note.length; index++) {
        container__note[index].classList.toggle('whitee')
    }

    for (let index = 0; index < container__list_product_noboder.length; index++) {
        container__list_product_noboder[index].classList.toggle('whitepro')
    }
    container_banner.classList.toggle('white_banner');
    container__news.classList.toggle('white_new');



})