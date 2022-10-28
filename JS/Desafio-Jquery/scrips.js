$(document).ready(()=>{
    console.log('Site loaded');
})

$('#intro-conteudo').click((e)=>{
    $.ajax({
        url: "conteudo.html",
        context: document.body,
        success: (data, textStatus, xhr)=>{
            $('#conteudo').html(data);
        }
    })
})

$('#intro-about').click((e)=>{
    $.ajax({
        url: "about.html",
        context: document.body,
        success: (data, textStatus, xhr)=>{
            $('#conteudo').html(data);
        }
    })
})