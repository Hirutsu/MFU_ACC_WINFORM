namespace MFU_Accounting.Entities
{
    public class Model
    {
        public int ModelId { get; set; }
        public string? Name { get; set; }
        public int CountFueled { get; set; }
        public int CountEmpty { get; set; }
        public int CountBroken { get; set; }
    }
}