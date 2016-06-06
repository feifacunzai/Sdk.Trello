using Sdk.Trello.Services;
using Sdk.Trello.ViewModels;
using System.Collections.Generic;

namespace Sdk.Trello
{
    public class BoardInstance : BaseInstance
    {
        private ListsService ListsService { get; set; }

        public BoardInstance(string key, string token) 
            : base(key, token)
        {
            ListsService = new ListsService();
        }

        public List<ListsModel> Lists(string boardId)
        {
            return ListsService.Execute(boardId);
        }
    }
}
