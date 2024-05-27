namespace BoletasMonolitica.web.Data.Core
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            this.FechaCreacion = DateTime.Now;

        }
        
        public int? AsientosReservados { get; set; }

        public DateTime? FechaCreacion { get; set; 
        }
    }
}
