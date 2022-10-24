function cadastrar() {
    console.log("Ola Mundo")
}

function validaNome(divNome){

    if (divNome.value.trim().split(' ').length < 2) {
        divNome.style.border = 'solid'
        divNome.style.borderColor = 'red';
    }

    //TODO permitir apenas letras
}

function  resetInput(input){
    input.style.border = 0
    input.style.borderColor = 'black';

}

function validaCep(divCep){

    //https://viacep.com.br/ws/

    let cep = divCep.value;

    fetch('https://viacep.com.br/ws/ '+  divCep.value + '/json').then(x => x.json()).then(console.log(x)).then( x=>{

        document.getElementById('logradouro').value
    })

}

function confirmaPassowrd(divConfirma){

    if (document.getElementById('novo-password').value) {
        
    }

function validaPassword(divPassowrd){

}

}