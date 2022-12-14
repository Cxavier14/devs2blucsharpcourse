const getView = (controller, viewName, target) => {
    let url = `/${controller}/${viewName}`;

    let ajaxConfig = {
        url: url,
        dataType: 'html',
        success: (response) => {
            $(target).html(response);
        }
    };
    $.ajax(ajaxConfig);
}

$(document).ready(() => {
    $('#btn-search').click((e) => {
        e.preventDefault();
        let nameInput = $('#input-search').val();
        $.ajax({
            url: `personagens/search/${nameInput}`,
            dataType: 'html',
            success: (htmlPartialView) => {
                $('#content-list').html(htmlPartialView);
                $('#input-search').val('');
            }
        });
    });
});

const randomNumberImg = (min, max) => {
    min = Math.ceil(min);
    max = Math.floor(max);
    rand = Math.floor(Math.random() * (max - min) + min);
    return `src="../img/hamburguer-cartoon_${rand}.jpeg"`;
}