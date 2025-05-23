using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Globalization;

namespace Dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        [DisplayName("Código de artículo")]
        public string CodigoArticulo { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        [DisplayName("Categoría")]
        public Categoria Categoria { get; set; }
        public string ImagenUrl { get; set; }

        private decimal _precio;
        [DisplayName("Precio sin formato")]
        public decimal Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        [DisplayName("Precio")]
        public string PrecioFormateado
        {
            get { return _precio.ToString("C", CultureInfo.CreateSpecificCulture("es-AR"));  }
        }

              

    }
}
