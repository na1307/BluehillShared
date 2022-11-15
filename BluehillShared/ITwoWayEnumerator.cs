namespace BluehillShared;

public interface ITwoWayEnumerator<
#if !NETFRAMEWORK || NET40_OR_GREATER
    out
#endif
    T> : IEnumerator<T> {
    bool MovePrevious();
}