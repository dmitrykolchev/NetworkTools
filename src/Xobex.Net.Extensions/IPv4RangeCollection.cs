// <copyright file="IPv4RangeCollection.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Collections;
using System.Net;
using System.Numerics;

namespace Xobex.Net.Extensions;

public class IPv4RangeCollection : ICollection<IPv4Range>, IEnumerable<IPv4Range>
{
    private readonly List<IPv4Range> _ranges;
    private bool _sorted;

    public IPv4RangeCollection()
    {
        _ranges = [];
    }

    public IPv4RangeCollection(IPv4RangeCollection other)
    {
        _ranges = new(other._ranges.Count);
        _ranges.AddRange(other._ranges);
        _sorted = other._sorted;
    }

    public void Add(IPv4Range range)
    {
        _ranges.Add(range);
        _sorted = false;
    }

    public int Count => _ranges.Count;

    public bool IsReadOnly => false;

    public IPv4Range this[int index]
    {
        get => _ranges[index];
        set
        {
            _ranges[index] = value;
            _sorted = false;
        }
    }

    public void Sort()
    {
        _ranges.Sort((a, b) => a.Start.CompareTo(b.Start));
        _sorted = true;
    }

    public static IPv4RangeCollection Merge(IPv4RangeCollection source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return source.Merge();
    }

    public static List<IPNetwork> MergeToCidrList(IPv4RangeCollection source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return source.Merge().ToCidrList();
    }

    private IPv4RangeCollection Merge()
    {
        if (Count > 1)
        {
            IPv4RangeCollection result = [];
            IEnumerable<IPv4Range> sorted = _sorted ? _ranges : _ranges.OrderBy(t => t.Start);
            result.Add(sorted.First());
            foreach (var item in sorted.Skip(1))
            {
                var last = result[^1];
                if (item.Start - 1 <= last.End)
                {
                    if (last.End < item.End)
                    {
                        last.End = item.End;
                        result[^1] = last;
                    }
                }
                else
                {
                    result.Add(item);
                }
            }
            result._sorted = true;
            return result;
        }
        return [.. this];
    }

    public List<IPNetwork> ToCidrList()
    {
        List<IPNetwork> result = [];
        foreach (var item in _ranges)
        {
            IPv4Range range = new()
            {
                Start = item.Start
            };
            var count = BitOperations.TrailingZeroCount(range.Start);
            for (; range.Start <= item.End;)
            {
                var hostMask = ~(0xFFFFFFFFu << count);
                if (range.Start + hostMask <= item.End)
                {
                    range.End = range.Start + hostMask;
                    result.Add(new IPNetwork(range.StartAddress, 32 - count));
                    range.Start = range.End + 1;
                    count = BitOperations.TrailingZeroCount(range.Start);
                }
                else
                {
                    count--;
                }
            }
        }
        return result;
    }

    public IEnumerator<IPv4Range> GetEnumerator()
    {
        return _ranges.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Clear()
    {
        _ranges.Clear();
    }

    public bool Contains(IPv4Range item)
    {
        return _ranges.Contains(item);
    }

    public void CopyTo(IPv4Range[] array, int arrayIndex)
    {
        _ranges.CopyTo(array, arrayIndex);
    }

    public bool Remove(IPv4Range item)
    {
        return _ranges.Remove(item);
    }
}
