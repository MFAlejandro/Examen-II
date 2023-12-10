using Firebase.Auth.Providers;
using Firebase.Auth;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Google.Cloud.Firestore;
using Google.Type;
using static Google.Cloud.Firestore.V1.StructuredAggregationQuery.Types.Aggregation.Types;
using System.Xml.Linq;
using Exámen_II.Models;


namespace Exámen_II.DataBase
{
    public class FireBaseService : Controller
    {

        public static class FirebaseAuthHelper
        {
            public const string firebaseAppId = "my-tasks-4f64a";
            public const string firebaseApiKey = "AIzaSyDK6PNmKnxwP64K4POS2TD27uQsd3jRqk4";

            public static FirebaseAuthClient setFirebaseAuthClient()
            {
                var response = new FirebaseAuthClient(new FirebaseAuthConfig
                {
                    ApiKey = firebaseApiKey,
                    AuthDomain = $"{firebaseAppId}.firebaseapp.com",
                    Providers = new FirebaseAuthProvider[]
                        {
                        new EmailProvider()
                        }
                });

                return response;
            }
        }
        



        
    }
}
