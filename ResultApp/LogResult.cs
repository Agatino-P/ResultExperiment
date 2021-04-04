namespace ResultApp
{
    public class LogResult<T>
    {
        public T Value { get; private set; }
        public bool IsOk { get; private set; }
        public bool IsFail => !IsOk;
        public LogEntry Log { get; private set; }

        protected LogResult(bool isOk, T value, LogEntry log)
        {
            IsOk = isOk;
            Value = value;
            Log = log;
        }

        public static LogResult<T> Ok(T t, LogEntry log = null) => new(true, t, log);
        public static LogResult<T> Fail(T t, LogEntry log = null) => new(false, t, log);
    }

}
