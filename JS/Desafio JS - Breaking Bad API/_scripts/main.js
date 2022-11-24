const LIST_NEWSLETTER = 'list_newsletter';
const LIST_FAVORITOS = 'list_favoritos';
var listNewsletter = new Array();
var listFavoritos = new Array();

$(document).ready(() => {
  console.log("Rodando");
  favoritos();
  $("#btn-assinar").click((e) => {
    e.preventDefault();
    assignNewsletter();
  });
});

const assignNewsletter = () => {
  let id = document.getElementById("newsid").value;
  let name = document.getElementById("newsname").value;
  let email = document.getElementById("newsemail").value;
  let tamLista = listNewsletter == null ? 0 : listNewsletter.length;
  let userNews;
  
  if(listNewsletter == null) listNewsletter = new Array();

  userNews = {
    id:0,
    name: name,
    email:email
  }
  
  if (id !== "") {
    var i = listNewsletter.findIndex((user) => Number(user.id) === Number(id));
    userNews.id = id;
    listNewsletter.splice(i,1,userNews);
  } else {
    let idInsert = tamLista + 1;
    userNews.id = idInsert;
    listNewsletter.push(userNews);
  }
  

  setJsonItem(LIST_NEWSLETTER, listNewsletter);
  cleanNews();
  console.log(`Newsletter assinada por ${userNews.name} com sucesso!`);
};

const cleanNews = () => {
    $('#newsname').val('');
    $('#newsemail').val('');
}

const regEventClick = () => {
  $('tr').click((e) => {
    let tr = $(e.target.parentElement);
    let regLinha = tr.find('td');
    let tdId = regLinha[0];
    $('#id').val($(tdId).html());
    $('#modelo').val($(regLinha[1]).html());
    $('#nome-personagem').val($(regLinha[2]).html());
    $('#descricao').val($(regLinha[3]).html());
  });
};

const favoritos = () => {
    var listaHTML = document.getElementById('lista-favoritos');
    $(listaHTML).html = "";
    listFavoritos = new Array();
    listFavoritos = getJsonItem(LIST_FAVORITOS);

    if(listFavoritos == null || listFavoritos.length <= 0) return;

    listFavoritos.forEach((f)=>{
        var linha  = document.createElement('tr');
        var colId  = document.createElement('td');
        var colAuthor  = document.createElement('td');
        var colQuote  = document.createElement('td');
        var colAction = document.createElement('td');
        
        $(colAction).html(`<div class="d-flex">
        <button onclick="removeItemList(${f.id});" 
        class="btn btn-danger">Remover</button>  
        </div>`);
        
        $(colId).html(f.id);
        $(colAuthor).html(f.author);
        $(colQuote).html(f.quote);
        $(linha).append(colId).append(colAuthor).append(colQuote).append(colAction);
        listaHTML.append(linha);
    });

    regEventClick();
}

const removeItemList = (id) => {
  var i = listFavoritos.findIndex((fav) => fav.id === id);
  listFavoritos.splice(i, 1);

  setJsonItem(LIST_FAVORITOS, listFavoritos);  
};