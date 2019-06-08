using RexburgBarrio20.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RexburgBarrio20.Services
{
    public class Data
    {
        public static IEnumerable<Category> GetCategoriesData()
        {
            return new List<Category>
            {
               new Category
               {
                   Name = "Housing",
                   NumberOfVisits = 5464,
                   Suggestions = new List<Suggestion>
                    {
                        new Suggestion
                        {
                            Title = "Madison Park Apt",
                            LikesCounter = 1354,
                            Telephone = 3852010618
                        },
                         new Suggestion
                        {
                            Title = "Whagon Wheel Apt",
                            LikesCounter = 1456,
                            Telephone = 3852010617
                        },
                        new Suggestion
                        {
                            Title = "Westisbury Apt",
                            LikesCounter = 2154,
                            Telephone = 3852010619
                        }
                    }
                },
               new Category
               {
                   Name = "Food",
                   NumberOfVisits = 5466,
                   Suggestions = new List<Suggestion>
                    {
                        new Suggestion
                        {
                            Title = "Food Pantry 1",
                            LikesCounter = 1164,
                            Telephone = 3852010612
                        },
                         new Suggestion
                        {
                            Title = "Pantry food 2",
                            LikesCounter = 6546,
                            Telephone = 3852010665
                        },
                        new Suggestion
                        {
                            Title = "Pantry 3",
                            LikesCounter = 1321,
                            Telephone = 3852010645
                        }
                    }
               },
               new Category
               {
                   Name = "Health",
                   NumberOfVisits = 54,
                   Suggestions = new List<Suggestion>
                    {
                        new Suggestion
                        {
                            Title = "Grand Peaks",
                            LikesCounter = 1164,
                            Telephone = 3852010612
                        }
                    }
               },
               new Category
               {
                   Name = "Entertaintment",
                   NumberOfVisits = 68676,
                   Suggestions = new List<Suggestion>
                    {
                        new Suggestion
                        {
                            Title = "Paramount 5",
                            LikesCounter = 1164,
                            Telephone = 3852010612
                        },
                         new Suggestion
                        {
                            Title = "Fair 1",
                            LikesCounter = 6546,
                            Telephone = 3852010665
                        },
                        new Suggestion
                        {
                            Title = "Far 2",
                            LikesCounter = 1321,
                            Telephone = 3852010645
                        },
                        new Suggestion
                        {
                            Title = "Fair 3",
                            LikesCounter = 1321,
                            Telephone = 3852010645
                        }
                    }
               }
            };
        }
    }
}
