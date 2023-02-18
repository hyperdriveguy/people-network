using System.Collections.Generic;

public class PersonNode {
    public int id {get; set;}
    public PersonAttributes attributes {get; set;}
    public DateTime lastUpdated {get;}
    private Dictionary<string, List<PersonNode>> relationships;

    // Contructors for new and previously saved nodes
    public PersonNode() {
        this.id = 0;
        this.attributes = new PersonAttributes();
        this.relationships = new Dictionary<string, List<PersonNode>>();
    }
    public PersonNode(PersonAttributes attr) {
        this.id = 0;
        this.attributes = attr;
        this.relationships = new Dictionary<string, List<PersonNode>>();
    }

    public PersonNode(int ident) {
        this.id = ident;
        this.attributes = new PersonAttributes();
        this.relationships = new Dictionary<string, List<PersonNode>>();
    }

    public PersonNode(int ident, PersonAttributes attr) {
        this.id = ident;
        this.attributes = attr;
        this.relationships = new Dictionary<string, List<PersonNode>>();
    }

    public PersonNode(int ident, PersonAttributes attr, Dictionary<string, List<PersonNode>> relations) {
        this.id = ident;
        this.attributes = attr;
        this.relationships = relations;
    }

}

public class RelationshipGraph {
    private Dictionary<int, PersonNode> node_map;

    // Constructors for new and previously saved graphs
    public RelationshipGraph() {
        this.node_map = new Dictionary<int, PersonNode>();
    }

    public RelationshipGraph(List<PersonNode> people_list) {
        this.node_map = new Dictionary<int, PersonNode>();
        foreach (PersonNode person in people_list) {
            this.AddCreatedPerson(person);
        }
    }

    // Make a unique ID that doesn't already exist in the graph
    private int GenerateID() {
        Random rng = new Random();
        int new_id;
        do {
            new_id = rng.Next();
        } while (this.node_map.ContainsKey(new_id));
        return new_id;
    }

    // Add a new person with a random ID
    public void AddNewPerson(PersonNode person) {
        person.id = this.GenerateID();
        this.node_map.Add(person.id, person);

    }

    // Add a previously created person to the map
    public void AddCreatedPerson(PersonNode person) {
        this.node_map.Add(person.id, person);
    }

    // Remove a person from the map
    public void RemovePerson(int ident) {
        if (node_map.ContainsKey(ident)) {
            this.node_map.Remove(ident);
        }
    }

    public void PrintAllNodes() {
        foreach (PersonNode peop in this.node_map.Values) {
            Console.WriteLine(peop.id);
        }
    }

}
