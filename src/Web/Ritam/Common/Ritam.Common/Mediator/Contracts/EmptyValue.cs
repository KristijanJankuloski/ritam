namespace Ritam.Common.Mediator.Contracts;

using System;
using System.Threading.Tasks;

public class EmptyValue
{
    private static readonly EmptyValue _value = new();

    public static ref readonly EmptyValue Value => ref _value;

    public static Task<EmptyValue> Task { get; } = System.Threading.Tasks.Task.FromResult(_value);

    public static bool operator ==(EmptyValue first, EmptyValue second)
    {
        return first.CompareTo(second) == 0;
    }

    public static bool operator !=(EmptyValue first, EmptyValue second)
    {
        return first.CompareTo(second) != 0;
    }

    public static bool operator <(EmptyValue left, EmptyValue right)
    {
        return left.CompareTo(right) < 0;
    }

    public static bool operator <=(EmptyValue left, EmptyValue right)
    {
        return left.CompareTo(right) <= 0;
    }

    public static bool operator >(EmptyValue left, EmptyValue right)
    {
        return left.CompareTo(right) > 0;
    }

    public static bool operator >=(EmptyValue left, EmptyValue right)
    {
        return left.CompareTo(right) >= 0;
    }

    public int CompareTo(EmptyValue other) => 0;

    public override int GetHashCode() => 0;

    public bool Equals(EmptyValue other) => true;

    public override bool Equals(object? obj) => obj is EmptyValue;

    public override string ToString() => string.Empty;
}
