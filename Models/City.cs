using System;

namespace PruebaPNG.Models
{
    /// <summary>
    /// Encapsula las propiedades que definen una
    /// entidad ejemplo
    /// </summary>
    public class City 
    {
        #region Properties
        public string Id { get; set; }
        public string Name { get; set; }
        public bool State { get; set; }
        public Int16 Code { get; set; }

        #endregion
    }
}
