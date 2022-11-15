const listQuotes = new Array();

addEventListener("load", () => {
    getAPI(URL_API_QUOTE_WALTER, getListQuotes);
  });

const getListQuotes = (data) => {
    let main = document.querySelector("main");
    listCharacters = new Array();
    main.innerHTML = '';
  
    data.forEach((character) => {
      let html = document.createElement("div");
      html.classList.add("card", "opacity-75", "swing","text-center", "my-4", "bg-dark", "ms-2");
      html.style.width = "18rem";
    //   html.addEventListener("click", () => showDetails(character));
  
      let htmlBody = 
      `   <div class="card-body">
            <h4 class="card-title text-white">Author: ${character.author}</h4>
            <p class="card-text text-white">${character.quote}</p>          
          </div>`;
  
      html.innerHTML = htmlBody;
      main.appendChild(html);
      listCharacters.push(character);
    });
  };
