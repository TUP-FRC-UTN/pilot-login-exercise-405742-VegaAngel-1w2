document.addEventListener('DOMContentLoaded',function(){

 
})

var form = document.getElementById("form")
var btnEnviar =document.getElementById("enviar")

btnEnviar.addEventListener('click',function(){
    validarUsuario();
})

function validarUsuario(){
    var email = document.getElementById("email").value;
    var contraseña = document.getElementById("contraseña").value
    
    const data = {
       email : email,
       contraseña: contraseña
    }
    urlPost = "https://localhost:7131/api/Usuario";
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
            cambiarPagina()
            console.log("se paso por aca")
           // alert("Operacion realizada  exitosamente")
          } else {
            alert("No se pudo realizar la operacion");
          }
        
    })
}
function cambiarPagina(){
    window.location.href= "altaPiloto.html"
}

$(document).ready(function(){
  $(form).validate({
   rules:{
    email:{
         required:true,
         email: true
    },
    contraseña:{
        required:true,
        minlength:5
    },
    messages:{
        email:{
             required:"complete el email",
             email:"el campo debe ser de tipo email"
        },
        contraseña:{
            required:"complete la contraseña",
             minlength:"la contraseña debe ser mas larga"
        }
    }},
    submitHandler: function(form) {
        this.validarUsuario();
      }
  })
 }
)


