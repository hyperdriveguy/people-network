using System.Collections.Generic;

public enum Gender {
    Male,
    Female,
    Unknown
}

// Class for determining age of a person
// This is used for increased precision in determining dates
public class Age {
    public DateTime date_of_birth;
    public bool dob_approximated;
    public bool age_unknown;

    // Constructors for storing Date of Birth
    public Age() {
        this.date_of_birth = DateTime.Now;
        this.dob_approximated = true;
        this.age_unknown = true;
    }
    public Age(DateTime dob) {
        this.date_of_birth = dob;
        this.dob_approximated = false;
        this.age_unknown = false;
    }

    public Age(int age_years) {
        this.date_of_birth = DateTime.Now.AddYears(-age_years);
        this.dob_approximated = true;
        this.age_unknown = false;
    }

    // Most of this snippet comes from StackOverflow: https://stackoverflow.com/a/3055445
    public string GetAgeString() {
        if (this.age_unknown) {
            return "Age unknown";
        }

        DateTime today = DateTime.Today;

        int months = today.Month - this.date_of_birth.Month;
        int years = today.Year - this.date_of_birth.Year;

        if (today.Day < this.date_of_birth.Day) {
            months--;
        }

        if (months < 0) {
            years--;
            months += 12;
        }

        if (this.dob_approximated) {
            return string.Format("{0} year{1}, {2} month{3} (approx.)",
                                years, (years == 1) ? "" : "s",
                                months, (months == 1) ? "" : "s");
        }

        int days = (today - this.date_of_birth.AddMonths((years * 12) + months)).Days;

        return string.Format("{0} year{1}, {2} month{3} and {4} day{5}",
                            years, (years == 1) ? "" : "s",
                            months, (months == 1) ? "" : "s",
                            days, (days == 1) ? "" : "s");
    }
}

// For lack of a better alternative, this structure is used
public struct Location {
    public string country;
    public string stateProvince;
    public string locality;
    public string streetAddress;
    public string apartmentRoom;

    public Location() {
        this.country = "";
        this.stateProvince = "";
        this.locality = "";
        this.streetAddress = "";
        this.apartmentRoom = "";
    }

    public Location(string ctry, string state, string localArea, string street, string aptRoom) {
        this.country = ctry;
        this.stateProvince = state;
        this.locality = localArea;
        this.streetAddress = street;
        this.apartmentRoom = aptRoom;
    }

    public Location(string ctry, string state, string localArea) {
        this.country = ctry;
        this.stateProvince = state;
        this.locality = localArea;
        this.streetAddress = "";
        this.apartmentRoom = "";
    }
}

// Combine all of the attributes above into a single structure
public struct PersonAttributes {
    public string name;
    public Age age;
    public Gender gender;
    public Location origin;
    public Location residence;
    public string notes;

    public PersonAttributes() {
        name = "";
        age = new Age();
        gender = Gender.Unknown;
        origin = new Location();
        residence = new Location();
        notes = "";
    }

    public PersonAttributes(string nam, int age_years, Gender gen, string more_info) {
        name = nam;
        age = new Age(age_years);
        gender = gen;
        origin = new Location();
        residence = new Location();
        notes = more_info;
    }

    public PersonAttributes(string nam, Age how_old, Gender sex, Location hailsFrom, Location locatedAt, string info) {
        name = nam;
        age = how_old;
        gender = sex;
        origin = hailsFrom;
        residence = locatedAt;
        notes = info;
    }
}
