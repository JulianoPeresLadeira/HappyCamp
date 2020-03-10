namespace HappyCamp.DataAccess.Converters
{
    interface IConverter
    {
        K Convert<T, K>(T from);
    }
}
