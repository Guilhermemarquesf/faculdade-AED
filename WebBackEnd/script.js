let numero = prompt("Digite um número:")

if (Number.isInteger(Number(numero))) {
    numero % 2 == 0 ? alert("é par") : alert("ímpar")
} else {
    alert("não é um número inteiro")
    
}