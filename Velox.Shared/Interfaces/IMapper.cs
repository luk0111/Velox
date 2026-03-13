namespace Velox.Shared.Interfaces
{
    public interface IMapper<TSource, TDest>
    {
        TDest Map(TSource source);
        TSource MapBack(TDest dest);
    }
}

