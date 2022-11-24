$(document).ready((e)=>{
    console.log('JQuery is loaded!');
    
    // Inicializa parametros do sistemas
    init();
});

const init = () => {
    // Carrega Views
    getView('home', 'main');    

    // Carrega Serviços
    initializeServices();
    
    // Carregar Eventos
    initializeEvents();
}

const initializeServices = () => {
    // Carregar/Armazenar Pokemons da API
    atualizarListaPKMNStorage();
    
    // * Destaques
    getAPI(URL_API_PKMN, fillDestaques);
}

const initializeEvents = () =>{
    // # Meus Pokemons
    $('#pag-meus-pokemons').click(()=>getView('meus-pokemons', '#root'));
    
    // Botão Pesquisar
    $('#btn-pesquisa').click((e)=>{
        e.preventDefault();
        let valorPesquisa = $('#input-pesquisa').val();
        // realiza pesquisa()
    });
}
