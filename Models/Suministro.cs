namespace app.Models
{
    public class Suministro
    {
        public string CodigoSuministro {get; set;}   
        public string CodigoRutaSuministro {get; set;}
        public string CodigoRutaReparto {get; set;}
        public string NombreSuministro {get; set;}
        public string DireccionPredio {get; set;}
        public string DireccionEntrega {get; set;}
        public int CodigoEstadoSuministro {get; set;}
        public string NombreEstadoSuministro {get; set;}
    }
}