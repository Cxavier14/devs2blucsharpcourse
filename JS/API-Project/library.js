const scripts = $('#scripts').clone();

const getPage = (url,target) => {
    $.ajax({
        url: `_views/${url}`,
        dataType: 'html',
        success: (page) => {
            $(target).html(page)
        }
    });
}