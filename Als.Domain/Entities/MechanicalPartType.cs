namespace Als.Domain.Entities
{
    public abstract class MechanicalPartType
    {
        public byte Id { get; set; }

        /// <summary>
        /// Тип детали
        /// </summary>
        public string Name { get; set; }
    }
}
