using RestSharp;
using Sdk.Trello.ViewModels.Entitys;
using System.Collections.Generic;

namespace Sdk.Trello
{
    public class ListService : BaseService
    {
        public ListService(string key, string token) 
            : base(key, token)
        {
        }

        /// <summary>
        /// Get an array of Cards on a List
        /// GET /1/lists/[idList]/cards
        /// </summary>
        /// <param name="idList"></param>
        public List<CardEntity> GetCardsOnList(string idList)
        {
            var client = new RestClient(
                string.Format("{0}1/lists/{1}/cards?key={2}&token={3}",
                Config.ApiUri,
                idList,
                Config.Key,
                Config.Token));
            var request = new RestRequest(Method.GET);
            return ApiResponse(client.Execute<List<CardEntity>>(request));
        }

        /// <summary>
        /// Create a new Card on a List
        /// POST /1/cards
        /// </summary>
        /// <param name="idList"></param>
        /// <param name="card"></param>
        /// <returns></returns>
        public CardEntity CreateCardOnList(string idList, CardEntity card)
        {
            var client = new RestClient(
                string.Format("{0}1/cards?key={1}&token={2}",
                Config.ApiUri,
                Config.Key,
                Config.Token));
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json");
            card.idList = idList;
            request.AddParameter("application/json", card, ParameterType.RequestBody);
            return ApiResponse(client.Execute<CardEntity>(request));
        }
    }
}
