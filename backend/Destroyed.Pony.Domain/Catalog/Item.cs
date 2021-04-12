using System;

namespace Destroyed.Pony.Domain.Catalog
{
    using System.Collections.Generic;
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public List<Rating> Ratings { get; set; }

        public Item(string name, string description, string brand, decimal price)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Item name cannot be null.");

            }
            if (string.IsNullOrEmpty(description))
            {
                throw new ArgumentException("Item tdescription cannot be null.");
            }
            if (string.IsNullOrEmpty(brand))
            {
                throw new ArgumentException("Item brand cannot be null.");
            }
            if (price < 0.00m || price > 1000.00m)
            {
                throw new ArgumentException("Item price must be a positive amount less than $1000.00.");
            }

            this.Name = name;
            this.Description = description;
            this.Brand = brand;
            this.Price = price;


        }
        public void AddRating(Rating rating)
        {
            this.Ratings.Add(rating);
        }
    }


    public class Rating
    {
        public int Id { get; set; }
        public int Star { get; set; }
        public string UserName { get; set; }
        public string Review { get; set; }

        public Rating(int stars, string userName, string review)
        {
            if (stars < 1 || stars > 5)
            {
                throw new ArgumentException("Star rating must be an integer: 1, 2, 3, 4, or 5.");
            }

            if (string.IsNullOrEmpty(userName))
            {
                throw new ArgumentException("UserName cannot be null.");
            }

            this.Star = stars;
            this.UserName = userName;
            this.Review = review;
        }

    }



}