/* Confs */ 
const scripts = $('#scripts').clone();

/* Functions */ 
const getPage = (url,target) => {
    $.ajax({
        url: `_views/${url}`,
        dataType: 'html',
        success: (page) => {
            $(target).html(page)
            // $("#scripts").html(scripts);            
        }
    });
}

