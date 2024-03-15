namespace Assets.Scripts.Helpers
{
    public static class TextFormatter
    {
        public static string FormatToTimerResult(this float timer)
        {
            if (timer <= 0 || timer > 99999)
                return "-- : -- : ---";

            var minutes = timer / 60;
            var seconds = timer % 60;
            var fractions = (timer * 100) % 100;

            return string.Format("{0:00} : {1:00} : {2:000}", minutes, seconds, fractions);
        }
    }
}
