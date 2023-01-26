let desk = [
    {'location': 'shelf#1', 
    'items': 
            [
            {'item': 'lego flower', 
            'count': 2, 
            'type': [
                    {'name': 'tulip', 
                    'colors': ['red', 'green', 'white' ]},
                    {'name': 'daisy', 
                    'colors': ['yellow', 'white', 'green'] }        ]
            },
            {'item': 'frog', 
            'count': 2, 
            'type': [
                    {'name': 'toy', 
                    'colors': ['green']}                            ]
            }
            ]
    },
    {'location': 'undershelf#1', 
    'items': 
            [
            {'item': 'beeSquishi', 
            'count': 1, 
            'type': [
                     {'name': 'Squishi toy', 
                    'colors': ['yellow', 'black', 'white', 'pink']}] //goal is to get to pink
            }
            ]
    },
    {'location': 'main desk', 
    'items': 
            [
            {'item': 'monitors', 
            'count': 2, 
            'type': [
                    {'name': 'viotek', 
                    'colors': ['black']},
                    {'name': 'imac', 
                    'colors': ['grey', 'mint green']} 
                    ]
            }
            ]
    }
]

//Print whole array
console.log('whole array', desk);

// Print 1 location
console.log('location', desk[1]);

// Print 1 location name
// for (let i = 0; i < desk.length; i++) 
// {console.log(desk[i].items)} 

console.log('location name', desk[1].location)

// Print 1 location items
console.log('location item', desk[1].items);

// Print item object
console.log('item object', desk[1].items[0]);

// print the item object count
console.log('object count', desk[1].items[0].count);

// print the item object name
console.log('object name', desk[1].items[0].type[0].name);

// print the colors of the object
console.log('object colors', desk[1].items[0].type[0].colors);

// print 1 color of the item
console.log('pink obj color', desk[1].items[0].type[0].colors[3])

console.log('**********************************************************')

// Print the names of all the locations
for (let i = 0; i < desk.length; i++) {
    // console.log(desk[i].items)
    for (let z = 0; z < desk[i].items.length; z++){
    // console.log(desk[i].items[z])
    } 
}

for (let i = 0; i < desk.length; i++) {
console.log(desk[i].location) }

console.log('**********************************************************')

// print the array of types for any item that has a count more than 1

for(let i = 0; i < desk.length; i++) {
//console.log('desk arr',desk[i])

    for(let z = 0; z < desk[i].items.length; z++) {
    //console.log(desk[i].items[z])
    
    if (desk[i].items[z].count > 1) {
    console.log ('final ans', desk[i].items[z].type)}
    }
}  


console.log('**********************************************************')

// Print all the item names if they have a color of white in the list of colors
for (let i = 0; i < desk.length; i++) {
// console.log('lo1', desk[i])

    for (let z = 0; z < desk[i].items.length; z++){
    // console.log('lo2',desk[i].items[z])

    // console.log ('lo2.5', desk[i].items[z].type)
    
    for (let x = 0; x < desk[i].items[z].type.length; x++){
    // console.log ('lo 3',desk[i].items[z].type[x])

    for (let y = 0; y < desk[i].items[z].type[x].colors.length; y++){
    // console.log ('lo 4',desk[i].items[z].type[x].colors[y])

    if (desk[i].items[z].type[x].colors[y] == 'white') {
    console.log ('final ans',desk[i].items[z].type[x].name)
    }
    }
    }
    }
}

