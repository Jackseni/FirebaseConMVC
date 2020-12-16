using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Google.Cloud.Firestore;

namespace FirebaseConMVC.Models
{
    [FirestoreData]
    public class IntegranteModelo
    {
        public string Id { get; set; }

        [FirestoreProperty]
        public string Nombre { get; set; }
    }
}