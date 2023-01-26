///////////////..///////////////////////////////Review////////////////////////////////////////////////////////////////
// Print odd number 1-2555

for (let i =1; i <= 255; i+=2){
    console.log('odd numbers', i)
}

for (let i=1; i<=255; i++){  //let is not global here because it is inside a for loop
    console.log ('odd numbers', i)
}



var hello = "Good Morning Jarrell" //This is not inside a for loop so it is global


// Using the numbers 0-200 print the values and sum if the number is even add to that if it is odd


let sum = 0

for(let i = 0; i < 200; i++)
    if (i % 0) {
        sum = sum + i
    }
    else{
        sum = sum -1
    }
    console.log('current value of i:', i, 'current sum:', sum)

//Line #19: start for loop, start at 0, end < 200, increase by 1
//Line #20: if i / 2 has no remainder
//Line #21: sum will now be equal the sum plus the value of i
//Line #22: 











///////////////////////Today's Lesson///////////////////////

//THE REST OF THIS LESSON CAN BE FOUND IN day2/mymain.js ////////

//let arr = []  //This is an array. It is a list of data.
//let obj = {'name': 'Brianna'} //This is an object. They contain key/value pairs. 

//Arrays can contain different data types

//let mixedArr = ['Brianna','is', 'feeling', 'young', 'under', 21 ]
    //console.log(mixedArr)


// push --> adding to the end of the array
// pop --> removes the last item in the array
// shift --> removes the first item of the array ... thus shifting the index
// unshift --> adds to the beginning of the array
// splice --> adds/replaces index

// let animals = ["Dog", "Cat", "Bird"];
// console.log ('**1', animals);

// animals.push ("Turtle");
// animals.push ("Fish");
// console.log ('**2', animals);

// animals.pop();
// console.log ('**3', animals);

//let classMates = ['hello', 'goodMorn', 'byeee'['chow', 'good-riddens']]
//console.log(classMates[2][1])

let newArr = ["Testing", "Testing123", ["Whats", "up", ["Good", "Questions", "Everyone"]], "Testing456"]
console.log(newArr) // Prints all of it
console.log(newArr[2]) // Prints just the array at index 2
console.log(newArr[2][1]) // Prints the word up located in the array in the array at index 1

console.log(newArr)
console.log(newArr[2])
console.log(newArr[2][2])
console.log(newArr[2][2][0])