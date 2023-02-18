class Program {
    public PersonAttributes GetPersonAttributes() {
        Console.Write("The name of new person: ");
        string new_name = Console.ReadLine();
        Console.Write("Enter the age of the new person: ");
        int new_age = (int)Console.ReadLine();
        int new_age;
        string input = Console.ReadLine();
        if(Int32.TryParse(input, out new_age))
            Console.WriteLine("Correct number typed");
        else
            Console.WriteLine("The input is not a valid integer");
        string gender_string = "";
        do {
            Console.Write("Enter the gender of the new person: ");
            gender_string = Console.ReadLine();
        } while (!Enum.TryParse(gender_string, out Gender new_gender));
        return new PersonAttributes();
    }

    static void Main() {
        RelationshipGraph my_relations = new RelationshipGraph();


        PersonNode peep1 = new PersonNode();
        my_relations.AddNewPerson(peep1);

        PersonNode peep2 = new PersonNode();
        my_relations.AddNewPerson(peep2);

        PersonNode peep3 = new PersonNode();
        my_relations.AddNewPerson(peep3);

        my_relations.PrintAllNodes();
    }
}
