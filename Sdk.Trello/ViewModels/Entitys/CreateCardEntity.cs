using System.Collections.Generic;

namespace Sdk.Trello.ViewModels.Entitys
{
    public class CreateCardEntity
    {
        public string name { get; set; }

        public string desc { get; set; }

        public float pos { get; set; }

        public string due { get; set; }

        public string idList { get; set; }

        public List<string> idLabels { get; set; }

        public string urlSource { get; set; }

        public string fileSource { get; set; }

        public string idCardSource { get; set; }

        public string keepFromSource { get; set; }

        public CreateCardEntity() {
        }

        public CreateCardEntity(string idList, string name)
        {
            this.idList = idList;
            this.name = name;
        }
    }
}
