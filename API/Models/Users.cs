namespace APi.Models
{
    using API.Models;
    using System;
    using System.Collections.Generic;

    public partial class Users
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public Nullable<int> edad { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }
        public string ciudad { get; set; }
        public List<Productos> Productos { get; set; }
    }
}
