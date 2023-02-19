class Garden {
    public string GardenName;
    public int MaxPlants;
    public List<Plant> AllPlants;

//This states the attributes that our Garden class has and declares the data type for these attributes. The list is talking to the Plant class and because we can use the class name as the "data type" that is what we put in the <>

    public Garden(string theGarden){
        GardenName =theGarden;
        MaxPlants = 20;
        AllPlants = new List<Plant>();
    }

//This is our Constructor where we define what is required on Instance creation vs what is already predefined.


    public void PrintGardenName() {
        Console.WriteLine($"The new Garden is {GardenName}");
    }

    public void ShowPlants() {
        foreach(var plant in AllPlants) {
            Console.WriteLine($"{plant.PlantName} is in {GardenName}");
        }
    }
}