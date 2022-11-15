var listCharacters = new Array();

addEventListener("load", () => {
  getAPI(URL_API_CHARACTERS, getListCharacters);  
});

getElement('#cast').addEventListener('click', ()=>{
  document.getElementById('search').value = '';
  getAPI(URL_API_CHARACTERS, getListCharacters);  
})

getElement('#btn-search').addEventListener('click', (e)=>{
  e.preventDefault();
  let input = document.getElementById('search').value;
  searchCharacterByName(input);
})

const getListCharacters = (data) => {
  document.getElementById('search').value = '';
  let main = document.querySelector("main");
  listCharacters = new Array();
  main.innerHTML = '';

  data.forEach((character) => {
    let html = document.createElement("div");
    html.classList.add("card", "swing", "my-4", "bg-dark", "ms-2");
    html.style.width = "18rem";
    html.addEventListener("click", () => showDetails(character));

    let htmlBody = `<img src="${character.img}" class="card-img-top" alt="${character.name}">
        <div class="card-body">
          <h4 class="card-title text-white">${character.name}</h4>
          <p class="card-text text-white">Nickname: ${character.nickname}</p>              
          <p class="card-text text-white">Portrayed: ${character.portrayed}</p>              
        </div>`;

    html.innerHTML = htmlBody;
    main.appendChild(html);
    listCharacters.push(character);
  });
};

const showDetails = (character) => {
  console.log(character);
  let div = document.createElement("div");
  document.querySelector("#modal-body").innerHTML = "";
  div.classList.add("card", "col-12", "my-4", "bg-dark");
  div.style.fontWeight = "400";
  div.style.fontSize = "1.3em";
  let modalBody = `
    <img src="${character.img}" class="card-img-top" alt="${character.name}">
    <div class="card-body">
      <article>
          <ul class="list-group">
            <li class="list-group-item"><strong>Name: ${character.name}</strong></li>
            <li class="list-group-item">Birthday: ${character.birthday}</li>
            <li class="list-group-item">Occupation: ${character.occupation}</li>
            <li class="list-group-item">Status: ${character.status}</li>
            <li class="list-group-item">Nickname: ${character.nickname}</li>
            <li class="list-group-item">Portrayed: ${character.portrayed}</li>                
          </ul>
      </article>
    </div>
      `;
  div.innerHTML = modalBody;
  document.querySelector("#modal-body").appendChild(div);
  $("#detailsModal").modal("show");
};

const searchCharacterByName = (characterInput) => {
  let name;
  if (hasWhiteSpace(characterInput)) {
    console.log('tem espaço')
    name = characterInput.replace(' ','+');
  }
  let urlP = `https://www.breakingbadapi.com/api/characters?name=${name}`;
  console.log(urlP)
  getAPI(urlP, getCharacterByName);
};

const getCharacterByName = (data) => {
  document.getElementById('search').value = '';
  let main = document.querySelector("main");
  main.innerHTML = "";
  listCharacters = new Array();

  data.forEach((character) => {
    let html = document.createElement("div");
    html.classList.add("card", "swing", "my-4", "bg-dark", "ms-2");
    html.style.width = "18rem";
    html.addEventListener("click", () => showDetails(character));

    let htmlBody = `<img src="${character.img}" class="card-img-top" alt="${character.name}">
        <div class="card-body">
          <h4 class="card-title text-white">${character.name}</h4>
          <p class="card-text text-white">Nickname: ${character.nickname}</p>              
          <p class="card-text text-white">Portrayed: ${character.portrayed}</p>              
        </div>`;

    html.innerHTML = htmlBody;
    main.appendChild(html);
    listCharacters.push(character);
  });
};

const hasWhiteSpace = (name) => {
  // /\s/g.test(s); regex verifica espaços em branco como tbm tabs 
  return name.indexOf(' ');
};