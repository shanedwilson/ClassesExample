using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExamples
{
    class Candy
    {
        public string Flavor { get; }
        public int Rating { get; private set; }
        public string Review { get; private set; }
        public string Name { get; }
        public CandyType Type { get; }

        const int MinRatingValue = 1;
        const int MaxRatingValue = 10;



        public Candy (string flavor,string name, CandyType type)
        {
            Flavor = flavor;
            Name = name;
            Type = type;
        }

        public void SetRating(int userRating)
        {
            //Needs to be 1-10
            if (userRating >=MinRatingValue && userRating <= MaxRatingValue)
            {
                Rating = userRating;
            }
            else
            {
                throw new Exception($"You are dumb. Ratings are {MinRatingValue}-{MaxRatingValue}. You moron.");
            }

        }

        public void SetRating (int userRating, string review)
        {
            SetRating(userRating);
            Review = review;
        }

        public override string ToString()
        {
            return $"This is {Type} {Name} with a(n) {Flavor} rated {Rating} with a review of {Review}";
        }

    }

    enum CandyType
    {
        Chocolate,
        Caramel,
        HardCandy,
        Sour,
        Stretchy,
        Nuts
    }
}
