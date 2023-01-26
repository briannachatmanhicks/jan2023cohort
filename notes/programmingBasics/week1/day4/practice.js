var arr01 = ["Bear", "Abby", "Lucy", "Roxy","Copper"]
var arr02 = [1,2,3]
var arr03 = [-1, 3, 6,-6, 9, -24, 8, 6, -100, 5000]
var arr04 = [2,5,7,3,4,6,9]

// Create a function that can use any of the above arrays and prints each value
function arrPrint (arr){
    for (i = 0; i < arr.length; i++){
        console.log(arr[i])
         // can you put a return statement inside a for loop? no because it stops the whole function... will not go through whole array
    }
    return arr[i]
}

// arrPrint(arr03)




// Given 2 numbers create a function that adds, subtracts, multiplies, and divides them and pushes each result into an array.  Print the array of results
function aSMD (a, b){
    let array = []
    sum = a + b; array.push(sum)
    diff = a - b; array.push(diff)
    pro = a * b; array.push(pro)
    div = a / b; array.push(div)

    console.log(array)
    return array
}

// aSMD(10 , 3)

// Create a function that takes any negative numbers and puts them in a new array and replaces that negative number with the word "negative", print both arrays
function negNum (arr){
    let negNum = []
    for (i = 0; i < arr.length; i++ ){
        if (arr[i] < 0){
            negNum.push(arr[i])
            arr.splice( i , 1, 'negative')
        }
    }
    console.log(negNum)
    console.log(arr)
}
// negNum (arr03)

//why is my second array printing like this ['negative', 3,6, -6,'negative', -24, 8, 6, -100, 'negative']


// Create a function that replaces any even number with the word "even"
function evenNum (arr){
    for (i = 0; i < arr.length; i++){
        if (arr[i] % 2 == 0){
            // arr.splice( i, 1, 'even')
            arr[i] = 'even'
        }
    }
    // console.log(arr)
    return arr
}

// evenNum (arr03)
console.log (evenNum(arr03))

