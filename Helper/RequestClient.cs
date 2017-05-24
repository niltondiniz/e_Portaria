﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using Plugin.Connectivity;
using System.Net.Http.Headers;
using System.Collections.Generic;

namespace ePortaria.Helper
{
	public static class RequestClient
	{
        public static string httpBase = "http://lucianofj.com/";
        public static string httpCompl = "portaobluetooth/index.php/api/v1/usuario/dados";

		public static async Task<string> GetRequest(string baseAddress, string complAddress, string email, string imei)
		{
			string dados = "";

            //if (CrossConnectivity.Current.IsConnected)
            //{

				var httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "Q1BBVVRPOjEyMzQ=");
				httpClient.BaseAddress = new Uri(baseAddress);

            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("json", "[{\"email\":\""+ email +"\", \"imei\": \""+ imei +"\"}]")
			    });

            var response = await httpClient.PostAsync(complAddress, content);
				dados = response.Content.ReadAsStringAsync().Result;
			//}
			return dados;
		}
	}
}
