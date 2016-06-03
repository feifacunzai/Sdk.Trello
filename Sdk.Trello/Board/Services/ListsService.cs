using RestSharp;
using Sdk.Trello.Board.Models;
using System.Collections.Generic;

namespace Sdk.Trello.Board
{
    public class ListsService
    {
        public List<CardModel> Execute(string key, string token, string boardId)
        {
            var client = new RestClient(
                string.Format("{0}1/boards/{1}/lists?cards=open&card_fields=name&fields=name&key={2}&token={3}", 
                Config.ApiUri, 
                boardId, 
                key, 
                token));
            var request = new RestRequest(Method.GET);
            return client.Execute<List<CardModel>>(request).Data;
        }
    }
}
