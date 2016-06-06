using RestSharp;
using Sdk.Trello.ViewModels;
using System.Collections.Generic;

namespace Sdk.Trello.Services
{
    /// <summary>
    /// 列出board中的lists
    /// </summary>
    public class ListsService
    {
        public List<ListsModel> Execute(string boardId)
        {
            var client = new RestClient(
                string.Format("{0}1/boards/{1}/lists?cards=open&card_fields=name&fields=name&key={2}&token={3}", 
                Config.ApiUri, 
                boardId, 
                Config.Key, 
                Config.Token));
            var request = new RestRequest(Method.GET);
            return client.Execute<List<ListsModel>>(request).Data;
        }
    }
}
