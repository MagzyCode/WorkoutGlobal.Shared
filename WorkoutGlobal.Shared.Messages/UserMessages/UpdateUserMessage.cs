namespace WorkoutGlobal.Shared.Messages
{
    public record UpdateUserMessage(Guid UpdationId, string FirstName, string LastName, string Patronymic);
}
