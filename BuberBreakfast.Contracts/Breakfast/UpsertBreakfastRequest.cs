namespace BuberBreakfast.Contracts.BuberBreakfast;

public record UpsertBreakfastRequest(
    string Name,
    string Description,
    DateTime StartEndDateTime,
    DateTime EndDateTime,
    List<string> Savory,
    List<string> Sweet
);
