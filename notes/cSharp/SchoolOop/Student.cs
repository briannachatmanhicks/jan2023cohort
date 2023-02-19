class Student : Human {
    public string FavCode;

    public Student(string theFirst, string theLast, string theCode) : base (theFirst, theLast) {
        FavCode = theCode;
    }

    public string PrintStudent(){
        Console.WriteLine($"{FirstName} is a Student and likes {FavCode}");
        return FirstName + " is a student " + FavCode;
    }
}