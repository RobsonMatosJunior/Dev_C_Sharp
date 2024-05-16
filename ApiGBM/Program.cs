using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;

namespace ApiGBM
{
    public interface IwaginsApi
    {
        [Get("/api/GetAll")]
        Task<List<Wagon>> GetWagonsAsync();   
    }

    public class Wagon
    {
        public int Id {get; set; }
        public string Plate  {get; set; }
        public string Railroad  {get; set; }
        public string Product  {get; set; }
        public DateTime DownloadStartTime  {get; set; }
        public DateTime DownloadEndTime  {get; set; }
        public string Observation  {get; set; }
        public int weight {get; set; }
        public DateTime CreatedAt  {get; set; }
        public DateTime UpdatedAt  {get; set; }
        public object DeletedAt  {get; set; }       

    }
}

