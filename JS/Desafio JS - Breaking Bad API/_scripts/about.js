const LISTA_QUOTES = 'list_quotes';
var listQuotes = new Array();

addEventListener("load", () => {
    getAPI(URL_API_CHARACTERS, filterQuotes)
    console.log(listQuotes)
  });


const filterQuotes = (data) => {
  let dropdownUl = $('#lista-characterQ');
  data.forEach((character, i) => {
    let itemLi = document.createElement('li');
    let anchor = document.createElement('a');
    $(anchor).addClass('dropdown-item');
    $(anchor).attr('src', '#');
    $(anchor).attr('id', `character-${i}`);
    $(anchor).html(`${character.name}`)

    itemLi.addEventListener('click', ()=>{
      console.log(character.name);
      getQuotesByName(character.name);
    })

    $(itemLi).append(anchor);
    $(dropdownUl).append(itemLi);
  });
}

const getQuotesByName = (characterName) => {
  let name;
  if (hasWhiteSpace(characterName)) {
    console.log('tem espaço')
    name = characterName.replace(' ','+');
  }
  let urlP = `https://www.breakingbadapi.com/api/quote?author=${name}`;
  console.log(urlP)
  getAPI(urlP, getListQuotes);
}

const getListQuotes = (data) => {
    let main = document.querySelector("main");
    listQuotes = new Array();
    main.innerHTML = '';
  
    data.forEach((quote) => {
      let html = document.createElement("div");
      html.classList.add("card", "bg-opacity-75", "swing","text-center", "my-4", "bg-dark", "ms-2");
      html.style.width = "18rem";
      // html.addEventListener("click", () => favoritar(quote));
      
      let htmlBody = 
      `   <div class="card-body">
      <h4 class="card-title text-white">Author: ${quote.author}</h4>
      <p class="card-text text-white">${quote.quote}</p>
      <a id="btn-favoritar" href="#" class="btn btn-success">Favoritar</a>      
      </div>`;
      
      html.innerHTML = htmlBody;
      main.appendChild(html);
      $('#btn-favoritar').click(()=> favoritar(quote));
      listQuotes.push(quote);
    });
  };

  const favoritar = (quote) => {
    let fav = {
      id:'',
      author:'',
      quote:''
    }
    let idA = quote.quote_id;
    let authorA = quote.author;
    let quoteA = quote.quote;
    
    fav.id = idA;
    fav.author = authorA;
    fav.quote = quoteA;

    listFavoritos.push(fav);
    console.log(listFavoritos);
    setJsonItem(LIST_FAVORITOS, listFavoritos);
  }