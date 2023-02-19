class Program {
    // Static method (essentially a function) for making a new person
    static PersonAttributes MakeNewPersonAttributes() {
        Gender new_gender;
        int new_age;

        Console.Write("The name of new person: ");
        string new_name = Console.ReadLine();

        string new_age_string = "";
        do {
            Console.Write("Enter the age of the new person: ");
            new_age_string = Console.ReadLine();
        } while (!Int32.TryParse(new_age_string, out new_age));

        if (new_age > 1000) {
            // Rollback age to zero just in case this edge case happens
            new_age = 0;
        }

        string gender_string = "";
        do {
            Console.Write("Enter the gender of the new person: ");
            gender_string = Console.ReadLine();
        } while (!Enum.TryParse(gender_string, out new_gender));

        Console.Write("Enter additional notes you'd like to attach to this person: ");
        string more_info = Console.ReadLine();
        return new PersonAttributes(new_name, new_age, new_gender, more_info);
    }

    // Main program logic, only showcases basic functionality
    static void Main() {
        RelationshipGraph my_relations = new RelationshipGraph();

        Console.Write("Make person one:\n");
        PersonAttributes PersonOneAttrs = MakeNewPersonAttributes();
        PersonNode peep1 = new PersonNode(PersonOneAttrs);
        my_relations.AddNewPerson(peep1);

        Console.Write("Make person two:\n");
        PersonAttributes PersonTwoAttrs = MakeNewPersonAttributes();
        PersonNode peep2 = new PersonNode(PersonTwoAttrs);
        my_relations.AddNewPerson(peep2);

        Console.Write("Make person three:\n");
        PersonAttributes PersonThreeAttrs = MakeNewPersonAttributes();
        PersonNode peep3 = new PersonNode(PersonThreeAttrs);
        my_relations.AddNewPerson(peep3);

        Console.Write("\n\n\n");
        my_relations.PrintAllNodes();
    }
}
