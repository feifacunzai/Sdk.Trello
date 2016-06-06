using Sdk.Trello.ViewModels.Entitys;
using System.Collections.Generic;

namespace Sdk.Trello.ViewModels
{
    public class ListsModel
    {
        public string id { get; set; }

        public string name { get; set; }

        public List<CardEntity> cards { get; set; }
    }
}
