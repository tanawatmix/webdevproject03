//alert('Hi.....')
//console.log("bbbb");console.log("1111")
//console.log(30 + 20);

//console.log(document.getElementById("num1").value)

//n1 = document.getElementById("num1").value
//n2 = document.getElementById("num2").value

//alert( parseInt(n1) + parseInt(n2) )

function showDti(){
    alert('Welcome to dti....')
}

let num1 = document.getElementById("num1")
let num2 = document.getElementById("num2")

btnSum =document.getElementById("btn-sum")
showSum =document.getElementById("show-sum")
btncancel =document.getElementById("btn-cancel")
btnRed =document.getElementById("btn-red")
btnGreen =document.getElementById("btn-green")
btnYellow =document.getElementById("btn-yellow")

btnSum.addEventListener("click", function(){
    let sum = parseFloat( num1.value ) + parseFloat(num2.value )
    showSum.innerHTML = sum
})



btncancel.addEventListener( "click", function(){
    num1.value = ""
    num2.value = ""
    showSum.innerHTML = "?????"
    document.body.style.backgroundColor = ""
})

btnRed.addEventListener("click", function(){
    
    document.body.style.backgroundColor = "red"
    
})

btnGreen.addEventListener("click", function(){
    
    document.body.style.backgroundColor = "green"

})

btnYellow.addEventListener("click", function(){
    
    document.body.style.backgroundColor = "yellow"

})