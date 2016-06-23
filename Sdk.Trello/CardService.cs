using RestSharp;
using Sdk.Trello.ViewModels.Entitys;
using System;

namespace Sdk.Trello
{
    public class CardService : BaseService
    {
        public CardService(string key, string token) 
            : base(key, token)
        {
        }

        /// <summary>
        /// Create a new Card
        /// POST /1/cards
        /// </summary>
        /// <param name="idList"></param>
        /// <param name="card"></param>
        /// <returns></returns>
        public CardEntity Create(CardEntity card)
        {
            if (string.IsNullOrEmpty(card.idList))
                throw new Exception("屬性idList不得為空");

            var client = new RestClient(
                string.Format("{0}1/cards?key={1}&token={2}",
                Config.ApiUri,
                Config.Key,
                Config.Token));
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", card, ParameterType.RequestBody);
            return ApiResponse(client.Execute<CardEntity>(request));
        }

        /// <summary>
        /// Update the contents of a Card
        /// PUT /1/cards/[card id or shortlink]
        /// </summary>
        /// <param name="cardId"></param>
        /// <returns></returns>
        public CardEntity Update(string cardId, CardEntity card)
        {
            var client = new RestClient(
                string.Format("{0}1/cards/{1}?key={2}&token={3}",
                Config.ApiUri,
                cardId,
                Config.Key,
                Config.Token));
            var request = new RestRequest(Method.PUT);
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", card, ParameterType.RequestBody);
            return ApiResponse(client.Execute<CardEntity>(request));
        }

        /// <summary>
        /// Add a comment to a Card
        /// POST /1/cards/[card id or shortlink]/actions/comments
        /// </summary>
        /// <param name="cardId"></param>
        /// <param name="comment"></param>
        /// <returns></returns>
        public CardEntity Comments(string cardId, CommentEntity comment)
        {
            var client = new RestClient(
                string.Format("{0}1/cards/{1}/actions/comments?key={2}&token={3}",
                Config.ApiUri,
                cardId,
                Config.Key,
                Config.Token));
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", comment, ParameterType.RequestBody);
            return ApiResponse(client.Execute<CardEntity>(request));
        }

        /// <summary>
        /// Add a member to a Card
        /// POST /1/cards/[card id or shortlink]/idMembers
        /// </summary>
        /// <param name="cardId"></param>
        /// <param name="idMember"></param>
        /// <returns></returns>
        public CardEntity IdMembers(string cardId, IdMemberEntity idMember)
        {
            var client = new RestClient(
                string.Format("{0}1/cards/{1}/idMembers?key={2}&token={3}",
                Config.ApiUri,
                cardId,
                Config.Key,
                Config.Token));
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", idMember, ParameterType.RequestBody);
            return ApiResponse(client.Execute<CardEntity>(request));
        }
    }
}
