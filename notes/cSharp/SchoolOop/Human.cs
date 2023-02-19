
class Human {
    public string FirstName;
    public string LastName;

    public Human(string theFirst, string theLast) {
        FirstName = theFirst;
        LastName = theLast;
    }

//Methods
    public string Introduction() {
        Console.WriteLine($"{FirstName} {LastName}");
        return FirstName + " " + LastName;
    }
}