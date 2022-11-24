/* # Confs */ 
const URL_API_CHARACTERS = 'https://www.breakingbadapi.com/api/characters';
const URL_API_SEARCH_BY_NAME = 'https://www.breakingbadapi.com/api/characters?name=';
const URL_API_QUOTE = 'https://breakingbadapi.com/api/quotes';
const URL_API_QUOTE_WALTER = 'https://breakingbadapi.com/api/quote?author=Walter+White';

/* # Functions */
const getElement = (q) => {
    return document.querySelector(q);
}

const getAPI = (url, funcCallback) => {
    fetch(url).then((response) => response.json(),
                    (error)=> console.error(error))
              .then(
                dataJson => funcCallback(dataJson),
                erro => console.error(erro));
}

const getPagina = (page, target) => {
    $.ajax({
      url: page,
      dataType: 'html',
      success: (pResponse) => {
        $(target).html(pResponse);
      },
    });
  };

  
const hasWhiteSpace = (name) => {
  // /\s/g.test(s); regex verifica espaços em branco como tbm tabs 
  return name.indexOf(' ');
};