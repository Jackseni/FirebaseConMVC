using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Google.Cloud.Firestore;

namespace FirebaseConMVC.Models
{
    [FirestoreData]
    public class PacienteModelo
    {
        public string Id { get; set; }

        [FirestoreProperty]
        public string Nombre { get; set; }

        [FirestoreProperty]
        public string Identidad { get; set; }

        [FirestoreProperty]
        public string Sexo { get; set; }

        [FirestoreProperty]
        public string Telefono { get; set; }

        [FirestoreProperty]
        public string Sintomas { get; set; }

        [FirestoreProperty]
        public string Direccion { get; set; }

        [FirestoreProperty]
        public string Fecha { get; set; }

        [FirestoreProperty]
        public string CuentaAlumno { get; set; }
    }
}