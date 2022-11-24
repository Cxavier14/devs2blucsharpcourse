/* Functions de apoio */
var listaPokemons = new Array();

const fillDestaques = (data) => {

    data.results.forEach((p,i) => {
        if(i > 3) return;
        
        let item = ` <div class="col-3">
            <div class="card">
            <div class="card-header bg-danger">
                <h4 class=text-white>${p.name}</h4>
            </div>
            <div class="card-body">${p.url}</div>
    </div></div>`;
        $('#destaque').append(item);
    });
}

const getView = (viewName, target) => {
    $.ajax({
        url: `_views/${viewName}.html`,
        dataType: 'html',
        success: (response) => {
            $(target).html(response);
        }
    });
}
// const getView = (viewName, target) => {
//     let ajaxConfig = {
//         url: `_views/${viewName}.html`,
//         dataType: 'html',
//         success: (response) => {
//             $(target).html(response);
//         }
//     };
//     $.ajax(ajaxConfig);
// }

const atualizarListaPKMNStorage = (force=false) => {
    if(!VerificaAtualizacaoLista() || !force) return;
    
    listaPokemons = new Array();
    getAPI(URL_API_PKMN, (data) => {
        // percorre lista de pokemins na propriedade results
        data.results.forEach((p)=>{
            getInfosAPIPromisse(p.url).then(objPokemon =>{
                let pkmn = {
                    id: objPokemon.id,
                    img: objPokemon.sprites.front_default,
                    name: objPokemon.name,
                    url:p.url
                }
                listaPokemons.push(pkmn);
                // atualiza lista storage
                stg.setJson(KEY_LISTA_PKMN, listaPokemons);
            });
        });
    });
}

const VerificaAtualizacaoLista = () => {
    let listaPkmn = stg.getJson(KEY_LISTA_PKMN);
    if(listaPkmn && listaPkmn.length > 0) 
        return true;
    else
        return false;
}