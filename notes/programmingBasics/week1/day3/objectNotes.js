var dojo = {};                                 // creates an empty object
dojo = {
  name: 'Coding Dojo',                         // property can store a string
  number_of_students: 25,                      // property can store a number
  instructors: ['Andrew', 'Michael', 'Jay'],   // property can store arrays
  location: {                                  // property can even store another object!
    city: 'San Jose',
    state: 'CA',
    zipcode: 95112
    }
}                                              // access object properties with dot (.) notation
console.log(dojo.name, dojo.number_of_students, dojo.instructors, dojo.location);
console.log(dojo["name"]);                     // or bracket [] notation (note: specify key in quotes)


dojo.snacks = ['Fig Bars', 'Bagels', 'Popcorn', 'Apples'];

dojo.number_of_students = 40;         // we can reassign any of the properties
dojo.location.city = "Bellevue";
dojo.location.state = "Washington";
dojo.location.zipcode = "unknown";




var glazedDonuts = [
    {
    frosting: 'glazed',
    style: 'cake',
    type: 'old fashioned',
    age: '45',
    time: 'minutes'
    },
    {
    frosting: 'glazed',
    style: 'yeast raised',
    type: 'regular',
    age: '5',
    time: 'minutes'
    },
    {
    frosting: 'glazed',
    style: 'yeast raised',
    type: 'jelly filled',
    age: '1',
    time: 'seconds'
    }
];

var purchase;
//You
if((glazedDonuts[0].age < 25 && glazedDonuts[0].time == 'minutes') || glazedDonuts[0].time == 'seconds'){
  //shop owner
    purchase = glazedDonuts[0]; //ask about if the opposite is true!//
}
else {
    console.log('sorry it has been out a bit longer');
}  



var numPurchase = 0;
for (var donut in glazedDonuts){ //i have questions about this line
    console.log(glazedDonuts[donut].type);
    if((glazedDonuts[donut].age < 25 && glazedDonuts[donut].time == 'minutes') || glazedDonuts[donut].time == 'seconds'){
        numPurchase++;
    }
    else {
        console.log('not this donut...');
    }
}
console.log(numPurchase);



