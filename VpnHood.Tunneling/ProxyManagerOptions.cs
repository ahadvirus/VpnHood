﻿using System;
using VpnHood.Common.Logging;

namespace VpnHood.Tunneling;

public class ProxyManagerOptions
{
    public TimeSpan? UdpTimeout { get; set; }
    public TimeSpan? IcmpTimeout { get; set; }
    public int? MaxUdpWorkerCount { get; set; }
    public int? MaxIcmpWorkerCount { get; set; }
    public bool UseUdpProxy2 { get; set; }
    public LogScope? LogScope { get; set; }
}