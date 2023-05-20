using System.Collections.Generic;

namespace Apps.RemoteConfig
{
    public interface IConfigurator : IConfigServices
    {
        bool IsEnabled { get; set; }

        void UpdateConfig(IDictionary<string, string> values);

        void SetReadyConfig();
    }
}