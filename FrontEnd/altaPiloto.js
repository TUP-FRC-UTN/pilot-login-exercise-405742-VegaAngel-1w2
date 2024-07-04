var form = document.getElementById("form")
var btnEnviar = document.getElementById("enviar")

function enviar(){

     
    const data = {
        isbn : 0,
        titulo : titulo,
        id_Autor: idAutor,
      //  fechaPublicacion: new Date().toISOString(),
        id_Genero:idGenero
     }
     urlPost = "https://localhost:7295/PostBook";
     options = {
         method:"POST",
         headers: {
             "Content-Type": "application/json"
         },
         body: JSON.stringify(data)
     }
     fetch(urlPost,options)
     .then((response) =>{
         if (response.ok) {
             alert("Operacion realizada  exitosamente");
           } else {
             alert("No se pudo realizar la operacion");
           }
        })
}

$(document).ready(function(){
    $(form).validate({
     rules:{
      nombre:{
           required:true
        
      },
      cantHorasVuelo:{
          required:true,
          Number:true
      },
      Nacionalidad:{
        required:true
      },
      messages:{
          nombre:{
               required:"complete el nombre",
              
          },
          cantHorasVuelo:{
              required:"complete la Cantidad de horas vuelo",
              Number:"el campo deber ser de tipo number"
          },
          Nacionalidad:{
            required:"Seleccione la nacionalidad"
          }
      }},
      submitHandler: function(form) {
          alert("hola")
        }
    })
   }
  )