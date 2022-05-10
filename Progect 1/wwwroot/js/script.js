let navbar = document.querySelector('.header .navbar');
let menuBtn = document.querySelector('#menu-btn');

menuBtn.onclick = () => {
    menuBtn.classList.toggle('fa-times');
    navbar.classList.toggle('active');
};

window.onscroll = () => {
    menuBtn.classList.remove('fa-times');
    navbar.classList.remove('active');
};


var swiper = new Swiper(".home-slider", {
    grabCursor: true,
    loop: true,
    centeredSlides: true,
    navigation: {
        nextEl: ".swiper-button-next",
        prevEl: ".swiper-button-prev",
    },
});

var swiper = new Swiper(".food-slider", {
    grabCursor: true,
    loop: true,
    centeredSlides: true,
    spaceBetween: 20,
    pagination: {
        el: ".swiper-pagination",
        clickable: true,
    },
    breakpoints: {
        0: {
            slidesPerView: 1,
        },
        700: {
            slidesPerView: 2,
        },
        1000: {
            slidesPerView: 3,
        },
    },
});

let previewContainer = document.querySelector('.food-preview-container');
let previewBox = previewContainer.querySelectorAll('.food-preview');

document.querySelectorAll('.food .slide').forEach(food => {
    food.onclick = () => {
        previewContainer.style.display = 'flex';
        let name = food.getAttribute('data-name');
        previewBox.forEach(preveiw => {
            let target = preveiw.getAttribute('data-target');
            if (name == target) {
                preveiw.classList.add('active');
            }
        });
    };
});


previewContainer.querySelector('#close-preview').onclick = () => {
    previewContainer.style.display = 'none';
    previewBox.forEach(close => {
        close.classList.remove('active');
    });
};

var swiper = new Swiper(".menu-slider", {
    grabCursor: true,
    loop: true,
    autoHeight: true,
    centeredSlides: true,
    spaceBetween: 20,
    pagination: {
        el: ".swiper-pagination",
        clickable: true,
    },
});

var swiper = new Swiper(".blogs-slider", {
    grabCursor: true,
    loop: true,
    centeredSlides: true,
    autoHeight: true,
    spaceBetween: 20,
    pagination: {
        el: ".swiper-pagination",
        clickable: true,
    },
    breakpoints: {
        0: {
            slidesPerView: 1,
        },
        700: {
            slidesPerView: 2,
        },
        1000: {
            slidesPerView: 3,
        },
    },
});

//var log = $('.form-log'),
//    reg = $('.form-reg'),
//    btn = $('.form-buttons');
//$('.form-buttons__reg').click(function (e) {
//    e.preventDefault();
//    if (reg.hasClass('form-reg_active') == 0) {
//        btn.addClass('form-buttons_active');
//        log.addClass('form-log_inactive');
//        reg.addClass('form-reg_active');
//    }
//});
//$('.form-buttons__log').click(function (e) {
//    e.preventDefault();
//    if (reg.hasClass('form-reg_active')) {
//        btn.removeClass('form-buttons_active');
//        log.removeClass('form-log_inactive');
//        reg.removeClass('form-reg_active');
//    }
//});

//var containers = $('header, section, footer');
//$('.login').click(function (e) {
//    e.preventDefault();
//    $('.modal').addClass('modal_active');
//    containers.css({
//        'filter': 'blur(6px)'
//    })
//});

//$('.form-close').click(function (e) {
//    e.preventDefault();
//    $('.modal').removeClass('modal_active');
//    containers.css({ 'filter': 'none' });
//});
