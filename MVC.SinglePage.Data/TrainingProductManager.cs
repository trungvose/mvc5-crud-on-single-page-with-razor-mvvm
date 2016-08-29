using System;
using System.Collections.Generic;

namespace MVC.SinglePage.Data
{
    public class TrainingProductManager
    {
        public List<KeyValuePair<string, string>> ValidationErrors { get; set; }
        public bool Validate(TrainingProduct entity) {
            ValidationErrors.Clear();

            if (!string.IsNullOrEmpty(entity.ProductName))
            {
                if (entity.ProductName.ToLower() == entity.ProductName) {
                    ValidationErrors.Add(new KeyValuePair<string, string>("Product Name", "Product Name must not be all lower case."));
                }
            }

            return (ValidationErrors.Count == 0);
        }

        public bool Delete(TrainingProduct entity)
        {
            //TODO
            return true;
        }
        public TrainingProduct Get(int productId) {
            List<TrainingProduct> list = new List<TrainingProduct>();
            TrainingProduct result = new TrainingProduct();

            //TODO
            list = CreateMockData();

            result = list.Find(p => p.ProductId == productId);

            return result;
        }
        public bool Update(TrainingProduct entity)
        {
            bool result = false;

            result = Validate(entity);

            if (result)
            {
                //TODO
            }

            return result;
        }
        public bool Insert(TrainingProduct entity) {
            bool result = false;

            result = Validate(entity);
            if (result)
            {
                //TODO
            }

            return result;
        }
        public TrainingProductManager()
        {
            ValidationErrors = new List<KeyValuePair<string, string>>();
        }
        public List<TrainingProduct> Get(TrainingProduct entity)
        {
            List<TrainingProduct> result = new List<TrainingProduct>();

            result = CreateMockData();

            if (!string.IsNullOrEmpty(entity.ProductName))
            {
                result = result.FindAll(p => p.ProductName.ToLower().StartsWith(entity.ProductName, StringComparison.CurrentCultureIgnoreCase));
            }

            return result;
        }
        private List<TrainingProduct> CreateMockData()
        {
            List<TrainingProduct> result = new List<TrainingProduct>();
            result.Add(new TrainingProduct()
            {
                ProductId = 1,
                ProductName = "Extending Bootstrap with CSS, JavaScript and jQuery",
                IntroductionDate = Convert.ToDateTime("08/13/2012"),
                Url = "http://trungk18.github.io/",
                Price = Convert.ToDecimal(29.00)
            });

            result.Add(new TrainingProduct()
            {
                ProductId = 2,
                ProductName = "Build your own Bootstrap Business Application Template in MVC",
                IntroductionDate = Convert.ToDateTime("1/29/2015"),
                Url = "https://github.com/trungk18",
                Price = Convert.ToDecimal(29.00)
            });

            result.Add(new TrainingProduct()
            {
                ProductId = 3,
                ProductName = "Building Mobile Web Sites Using Web Forms, Bootstrap, and HTML5",
                IntroductionDate = Convert.ToDateTime("8/28/2014"),
                Url = "http://codepen.io/trungk18/",
                Price = Convert.ToDecimal(29.00)
            });

            result.Add(new TrainingProduct()
            {
                ProductId = 4,
                ProductName = "How to Start and Run A Consulting Business",
                IntroductionDate = Convert.ToDateTime("9/12/2013"),
                Url = "http://trungk18.github.io/",
                Price = Convert.ToDecimal(29.00)
            });

            result.Add(new TrainingProduct()
            {
                ProductId = 5,
                ProductName = "The Many Approaches to XML Processing in .NET Applications",
                IntroductionDate = Convert.ToDateTime("7/22/2013"),
                Url = "http://trungk18.github.io/",
                Price = Convert.ToDecimal(29.00)
            });

            result.Add(new TrainingProduct()
            {
                ProductId = 6,
                ProductName = "WPF for the Business Programmer",
                IntroductionDate = Convert.ToDateTime("6/12/2009"),
                Url = "http://codepen.io/trungk18/",
                Price = Convert.ToDecimal(29.00)
            });

            result.Add(new TrainingProduct()
            {
                ProductId = 7,
                ProductName = "WPF for the Visual Basic Programmer - Part 1",
                IntroductionDate = Convert.ToDateTime("12/16/2014"),
                Url = "https://github.com/trungk18",
                Price = Convert.ToDecimal(29.00)
            });

            result.Add(new TrainingProduct()
            {
                ProductId = 8,
                ProductName = "WPF for the Visual Basic Programmer - Part 2",
                IntroductionDate = Convert.ToDateTime("2/18/2014"),
                Url = "http://trungk18.github.io/",
                Price = Convert.ToDecimal(29.00)
            });


            return result;
        }
    }
}
