using LiteDB;

namespace Modelos
{
public class Cortador
{
    [BsonId]
    public int Id {get;set;}
    public string Nome {get;set;}
}
}