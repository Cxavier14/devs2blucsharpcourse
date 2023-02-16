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
    e.preventDefault();
    $.ajax({
        url: "about.html",
        context: document.body,
        success: (data, textStatus, xhr)=>{
            $('#conteudo').html(data);
        }
    })
})


      $(document).ready(() => {
          $('#btn-delete').click(() => delete());
      });
  
      const deleteP = () => {
          $.ajax({
              url: `@Url.Action("Delete")`,
              method: 'POST',
              data: {
                  id: @Model.id,
                  healthInsurance: '@Model.healthInsurance',
                  name: '@Model.name',
                  identityDocument: '@Model.identityDocument',
                  birthDate: '@Model.birthDate',
                  phone: '@Model.phone',
                  address: '@Model.address',
                  city: '@Model.city'
              },
              success: (a) => {
                  if (a > 0) {
                      let alert = `<div class="alert alert-danger" role="alert">Patient deleted!</div>`;
  
                      $('#alert-delete').html(alert);
                      $('#modal').modal('toggle');
                      window.location.reload();
                  }
              }
          });
      }
  