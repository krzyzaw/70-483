namespace Types.Generic
{
    public class GenericSerializer
    {
        public string Serialize<T>(T objectToSerialize) where T : class
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(objectToSerialize);
        }
    }
}