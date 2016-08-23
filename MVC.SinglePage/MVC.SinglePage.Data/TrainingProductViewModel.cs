using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.SinglePage.Data
{
    public class TrainingProductViewModel
    {
        public TrainingProductViewModel()
        {
            Init();

            Products = new List<TrainingProduct>();
            SearchEntity = new TrainingProduct();
        }
        public string EventCommand { get; set; }
        public List<TrainingProduct> Products { get; set; }
        public TrainingProduct SearchEntity { get; set; }
        public bool IsDetailAreVisible { get; set; }
        public bool IsListAreVisible { get; set; }
        public bool IsSearchAreVisible { get; set; }
        public void HandleRequest()
        {
            switch (EventCommand.ToLower())
            {
                case "list":
                case "search":
                    Get();
                    break;

                case "resetsearch":
                    ResetSearch();
                    Get();
                    break;

                case "save":
                    break;

                case "cancel":
                    ListMode();
                    Get();
                    break;

                case "add":
                    AddMode();
                    break;

                default:
                    break;

            }
        }

        private void Init()
        {
            EventCommand = "List";
            ListMode();
        }

        private void ListMode()
        {
            IsListAreVisible = true;
            IsSearchAreVisible = true;
            IsDetailAreVisible = false;
        }

        private void AddMode()
        {
            IsListAreVisible = false;
            IsSearchAreVisible = false;
            IsDetailAreVisible = true;
        }
        private void ResetSearch()
        {
            SearchEntity = new TrainingProduct();
        }
        private void Get()
        {
            TrainingProductManager mgr = new TrainingProductManager();
            Products = mgr.Get(SearchEntity);
        }
    }
}
