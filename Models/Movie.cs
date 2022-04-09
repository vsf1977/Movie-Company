using System;

namespace PruebaPNG.Models
{
    /// <summary>
    /// Encapsula las propiedades que definen una
    /// entidad ejemplo
    /// </summary>
    public class Movie 
    {
        #region Properties
        public string Id { get; set; }
        public string Name { get; set; }
        public string Poster { get; set; }
        public string Trailer { get; set; }
        public string GenreId { get; set; }
        public bool State { get; set; }

        #endregion
    }
}
