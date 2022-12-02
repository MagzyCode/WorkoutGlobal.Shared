namespace WorkoutGlobal.Shared.Messages
{
    public class CreateLogMessage
    {
        /// <summary>
        /// Log info.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Represents severity id for create relations.
        /// </summary>
        public string Severity { get; set; }
    }
}
