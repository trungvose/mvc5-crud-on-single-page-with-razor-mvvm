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
            Entity = new TrainingProduct();
        }

        public TrainingProduct Entity { get; set; }
        public string EventCommand { get; set; }
        public bool IsValid { get; set; }
        public string Mode { get; set; }
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
                    Save();
                    if (IsValid)
                    {
                        Get();
                    }
                    break;

                case "cancel":
                    ListMode();
                    Get();
                    break;

                case "add":
                    Add();
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
            IsValid = true;
            Mode = "List";
            IsListAreVisible = true;
            IsSearchAreVisible = true;
            IsDetailAreVisible = false;
        }
        
        private void Add() {
            IsValid = true;
            Entity = new TrainingProduct();
            Entity.IntroductionDate = DateTime.Now; ;
            Entity.Url = "http://";
            Entity.Price = 0;

            AddMode();
        }

        private void AddMode()
        {
            IsListAreVisible = false;
            IsSearchAreVisible = false;
            IsDetailAreVisible = true;

            Mode = "Add";
        }
        private void Save() { 
            if(IsValid)
            {
                if (Mode == "Add")
                {
                    //Add
                }
            }
            else
            {
                if (Mode =="Add")
                {
                    AddMode();
                }
            }
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
