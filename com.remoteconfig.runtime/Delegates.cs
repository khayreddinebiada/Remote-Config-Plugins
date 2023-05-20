using System.Collections.Generic;

namespace Apps.RemoteConfig
{
    public class Delegates
    {
        public delegate void OnConfigured(IReadOnlyDictionary<string, string> values);
    }
}