using LiteDB;

namespace Modelos

public class Cortador
{
    [BsonId]
    public int id {get;set;}
    public string Nome {get;set;}
}