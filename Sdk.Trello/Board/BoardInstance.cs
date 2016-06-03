using Sdk.Trello.Board.Models;
using System.Collections.Generic;

namespace Sdk.Trello.Board
{
    public class BoardInstance : AbstractTrello
    {
        private ListsService ListsService { get; set; }

        public BoardInstance(string key, string token, string boardId) 
            : base(key, token, boardId)
        {
            ListsService = new ListsService();
        }

        public List<CardModel> Lists()
        {
            return ListsService.Execute(Key, Token, BoardId);
        }
    }
}
