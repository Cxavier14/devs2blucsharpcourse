/* # Confs */
const URL_API_CHARACTER = 'https://rickandmortyapi.com/api/character';

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