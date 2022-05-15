
$(document).ready(function () {
    

   
    var log = $('.form-log'),
        reg = $('.form-reg'),
        btn = $('.form-buttons');
    $('.form-buttons__reg').click(function (e) {
        e.preventDefault();
        if (reg.hasClass('form-reg_active') == 0) {
            btn.addClass('form-buttons_active');
            log.addClass('form-log_inactive');
            reg.addClass('form-reg_active');
        }
    });
    $('.form-buttons__log').click(function (e) {
        e.preventDefault();
        if (reg.hasClass('form-reg_active')) {
            btn.removeClass('form-buttons_active');
            log.removeClass('form-log_inactive');
            reg.removeClass('form-reg_active');
        }
    });

    var containers = $('header, section, footer');
    $('.login').click(function (e) {
        e.preventDefault();
        $('.modal').addClass('modal_active');
        containers.css({
            'filter': 'blur(6px)'
        })
    });

    $('.form-close').click(function (e) {
        e.preventDefault();
        $('.modal').removeClass('modal_active');
        containers.css({ 'filter': 'none' });
    });

});