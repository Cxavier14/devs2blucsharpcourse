const URL_API = 'https://www.breakingbadapi.com/api/characters?limit=10&offset=0';

$(document).ready (() => {
    getPage('home.html', 'main')

})

const getElenco = () => {
    getPage('elenco.html', 'main');
    $.ajax({
        url: URL_API,
        dataType: 'json',
        success: (data) => {
            let listBB = document.createElement('div');
            $(listBB).addClass('row');
            $('#getElenco').html(listBB);
            
            console.log(data);
            
            data.forEach((p, i) => {
                let li = document.createElement('div');
                let card = document.createElement('div');
                let cardHeader = document.createElement('div');
                let cardBody = document.createElement('div');
                $(li).addClass('col-4');
                
                $(card).addClass('card');
                $(cardHeader).addClass('card-header');
                $(cardBody).addClass('card-body');
                
                $(cardHeader).attr('id', `ch-bb${i}`);
                getIMGBB(p.url, `#ch-bb${i}`);
                
                $(cardBody).html(`<h3>${p.name}</h3>`);
                
                $(card).append(cardHeader).append(cardBody);
                $(li).append(card);
                
                $(listBB).append(li);
            });
        }
    });
}

const getIMGBB = (url, target) => {
    return $.ajax({
        url: url,
        dataType: 'json',
        success: (data) => {
            console.log(data);
            let dataHtml = document.createElement('img');
            $(dataHtml).addClass('card-img-top');
            $(dataHtml).attr('src', data.img);
            $(target).append(dataHtml);
        }
    });
}