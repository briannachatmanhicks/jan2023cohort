// Class - Developer vs Website

//Class names
//Constructor Function
//Attributes
//Methods
//Create Instances/objects and use them

class Developer {
    constructor (name, email) {
        this.name = name
        this.skill= []
        this.email= email
        this.site = []
    }
    printNewDev() {
        console.log('Our Newest Developer is:', this.name, 'and their email is:', this.email)
    }
    addSkill (s) {
        console.log(`${this.name} has just learned the still of ${s}`)
        for (i = 0; i < this.skill.length; i++) {
        }
    }
}

class Website {

}

let brianna = new Developer('Brianna', 'briannahicks12345@gmail.com')
brianna.printNewDev()
