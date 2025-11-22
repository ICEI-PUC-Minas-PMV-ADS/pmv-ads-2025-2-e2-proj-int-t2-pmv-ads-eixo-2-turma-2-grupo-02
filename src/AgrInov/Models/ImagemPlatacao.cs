using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace AgrInov.Models{
    [Table("ImagemPlantacao")]
    [PrimaryKey(nameof(PlantacaoId), nameof(ImagemId))]
    public class ImagemPlantacao
    {   

        public int PlantacaoId { get; set; }

        public int ImagemId { get; set; }

    }
}