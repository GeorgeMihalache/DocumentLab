﻿namespace DocumentLab.Contracts.Contracts.PageInterpreter
{
  using System.Collections.Generic;
  using System.Linq;

  public class PatternResult
  {
    public Dictionary<string, string> Result { get; } = new Dictionary<string, string>();

    public string GetResultAt(int index)
    {
      return Result.ElementAt(index).Value;
    }

    public string GetResultByKey(string key)
    {
      if (!Result.ContainsKey(key))
        return null;

      return Result[key];
    }

    public void AddResult(string key, string value)
    {
      Result.Add(key ?? Result.Count.ToString(), value);
    }
  }
}