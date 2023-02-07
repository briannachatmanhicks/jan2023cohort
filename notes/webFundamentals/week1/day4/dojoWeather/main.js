console.log ('js connected')
function alertMe(element) {
    alert('You are about to display the weather for a different city')
}

function AcceptCookie() {
    document.getElementById('hide').style.display = 'none'
}

function display() {
    var x = document.getElementById('languages').value;
    console.log(x);
    let farenArr=[]
    if (x == 'f') {
        var y= document.getElementById('red').value
        console.log(y)
        // farenArr.push(y)
        // console.log(farenArr)
        // for (i = 0; i < farenArr.length; i++) {
        //     console.log(farenArr[i].value)
        // }
    }

}
