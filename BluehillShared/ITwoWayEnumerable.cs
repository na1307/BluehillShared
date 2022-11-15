namespace BluehillShared;

public interface ITwoWayEnumerable<
#if !NETFRAMEWORK || NET40_OR_GREATER
    out
#endif
    T> : IEnumerable<T> {
    new ITwoWayEnumerator<T> GetEnumerator();
}