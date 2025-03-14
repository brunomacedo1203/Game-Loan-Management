using System.Text.Json.Serialization;

namespace Game_Loan_Management.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum GenreEnum
    {
        Action,
        Adventure,
        RPG,        
        Strategy,
        Puzzle,
        Simulation,
        Sports,
        Horror,
        Fighting,
        Racing
    }
}
