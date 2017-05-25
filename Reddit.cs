using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Earthpapers {
    public class Reddit {
        // Temporary storing of strings needed for interacting with Reddit API
        private const string _clientId = "3t_-WJLzczPgpA";
        private const string _clientSecret = "_JaZMwTVcjGpNoDialnkLecFoX8";
        private const string _userAgent = "Earthpapers by /u/Natalie_Supportman";
        private const string _retrieveAccessTokenUrl = "https://www.reddit.com/api/v1/access_token";

        // Static instance of HttpClient as per recommendations
        private static readonly HttpClient _client = new HttpClient();

        public Reddit() {
        }
    }
}