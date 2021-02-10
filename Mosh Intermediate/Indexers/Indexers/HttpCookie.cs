using System;
using System.Collections.Generic;

namespace Indexers
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _cookieDictionary;
        public DateTime ExpiryDateTime { get; set; }

        public HttpCookie()
        {
            _cookieDictionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get => _cookieDictionary[key];
            set => _cookieDictionary[key] = value;
        }
    }
}