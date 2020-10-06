using System;

namespace DatingProfile
{ 
  class Profile
  {

  private string name;
  private int age;
  private  string city;
  private  string country;
  private   string pronouns;
  private  string[] hobbies;

    public profile (
     string name,
     int age,
     string city,
      string  country,
     string pronouns = "they/them"
    )
    {
      this.name = name;
      this.age = age;
      this.cily = city;
      this.country = country;
      this.pronouns = pronouns;
      this.hobbies = new string[0];
    }

    public string viewProfile()
    {
      string bio = $"Name: {name}\nAge:{age}\nCity: {city}\nCountry: {country}\nPronouns: {pronouns}";

      bio += "\nHobbies:\n";
      foreach(string hobby in hobbies)
      {
        bio += $"- {hobby}\n";
      }

      return bio;

    }

    public void SetHobbies(string[] hobbies)
    {
      this.hobbies = hobbies;
    }

