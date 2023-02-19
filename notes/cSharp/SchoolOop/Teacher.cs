class Teacher : Human {
    public string FavClass;

    public Teacher(string theFirst, string theLast, string theClass) : base (theFirst, theLast) {
        FavClass = theClass;
    }

    public string PrintTeacher(){
        Console.WriteLine($"{FirstName} is a Teacher and likes {FavClass} the most");
        return FirstName + " and loves " + FavClass;
    }
}