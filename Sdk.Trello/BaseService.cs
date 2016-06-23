using RestSharp;
using System;
using System.Net;

namespace Sdk.Trello
{
    public abstract class BaseService
    {
        public BaseService(string key, string token)
        {
            Config.Key = key;
            Config.Token = token;
        }

        protected T ApiResponse<T>(IRestResponse<T> response)
        {
            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception(response.Content);
            return response.Data;
        }
    }
}
