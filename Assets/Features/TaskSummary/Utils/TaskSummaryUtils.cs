namespace Features.TaskSummary.Utils
{
    public static class TaskSummaryUtils
    {
        public static string FormatProgress(string text, int progress, int target) => $"{text} ({progress}/{target})";
    }
}