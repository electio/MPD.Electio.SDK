namespace MPD.Electio.SDK.Exceptions
{
    public class TimeZoneDataNotFoundException : ObjectNotFoundException
    {
        public TimeZoneDataNotFoundException(string timeZoneRef)
            : base("TimeZone", timeZoneRef) { }
    }
}