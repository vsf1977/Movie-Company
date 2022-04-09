using System;

namespace PruebaPNG.Models
{
    /// <summary>
    /// Encapsula las propiedades que definen una
    /// entidad ejemplo
    /// </summary>
    public class MovieByMultiplex
    {
        #region Properties
        public string MovieId { get; set; }
        public string MultiplexID { get; set; }
        public DateTime Schedule { get; set; }

        #endregion
    }
}
