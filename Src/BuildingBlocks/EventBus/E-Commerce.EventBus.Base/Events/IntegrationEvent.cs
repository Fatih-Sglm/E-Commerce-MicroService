using Newtonsoft.Json;

namespace E_Commerce.EventBus.Base.Events
{
    public class IntegrationEvent
    {
        [JsonProperty]
        public Guid Id { get; private set; }
        [JsonProperty]
        public DateTime CreateDate { get; private set; }

        [JsonConstructor]
        public IntegrationEvent()
        {
            Id = Guid.NewGuid();
            CreateDate = DateTime.Now;
        }

        public IntegrationEvent(Guid id, DateTime createDate)
        {
            Id = id;
            CreateDate = createDate;
        }
    }
}
