namespace ResultApp
{
    public class Result
    {
        public bool IsOk { get; private set; }
        public bool IsFail => !IsOk;
        public string Log { get; private set; }

        protected Result(bool isOk, string log)
        {
            IsOk = isOk;
            Log = log;
        }

        public static Result Ok(string log = null) => new(true, log);
        public static Result Fail(string log = null) => new(false, log);
    }

    public class Result<T>
    {
        public T Value { get; private set; }
        public bool IsOk { get; private set; }
        public bool IsFail => !IsOk;
        public string Log { get; private set; }

        protected Result(bool isOk, T value, string log)
        {
            IsOk = isOk;
            Value = value;
            Log = log;
        }

        public static Result<T> Ok(T t, string log = null) => new(true, t, log);
        public static Result<T> Fail(T t, string log = null) => new(false, t, log);
    }

    public class Result<L, T>
    {
        public T Value { get; private set; }
        public bool IsOk { get; private set; }
        public bool IsFail => !IsOk;
        public L Log { get; private set; }

        protected Result(bool isOk, T value, L log)
        {
            IsOk = isOk;
            Value = value;
            Log = log;
        }

        public static Result<L, T> Ok(T t, L log = default) => new(true, t, log);
        public static Result<L, T> Fail(T t, L log = default) => new(false, t, log);
    }

}
