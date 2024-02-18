using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;



namespace Rig
{
    public class Randomx
    {
        public int init { get; set; }
        [JsonPropertyName("init-avx2")]
        public int initAvx2 { get; set; }
        public string? mode { get; set; }
        [JsonPropertyName("1gb-pages")]
        public bool gbPages { get; set; }
        public bool rdmsr { get; set; }
        public bool wrmsr { get; set; }
        [JsonPropertyName("cache_qos")]
        public bool cacheQos { get; set; }
        public bool numa { get; set; }
        [JsonPropertyName("scratchpad_prefetch_mode")]
        public int scratchpadPrefetchMode { get; set; }
    }
    public class Cpu
    {      
        public bool? enabled { get; set; }
        [JsonPropertyName("huge-pages")]
        public bool? hugePages { get; set; }
        [JsonPropertyName("huge-pages-jit")]
        public bool? hugePagesJit { get; set; }
        [JsonPropertyName("hw-aes")]
        public object? hwAes { get; set; }
        public object? priority { get; set; }
        [JsonPropertyName("memory-pool")]
        public bool? memoryPool { get; set; }
        public bool? yield { get; set; }
        public bool? asm { get; set; }
        [JsonPropertyName("argon2-impl")]
        public object? argon2_impl { get; set; }
        public IList<IList<int>>? rx { get; set; }
    }
    public class Pool
    {
        public object? algo { get; set; }
        public object? coin { get; set; }
        public string? url { get; set; }
        public string? user { get; set; }
        public string? pass { get; set; }
        public object? rig_id { get; set; }
        public bool nicehash { get; set; }
        public bool keepalive { get; set; }
        public bool enabled { get; set; }
        public bool tls { get; set; }
        public bool sni { get; set; }
        [JsonPropertyName("tls-fingerprint")]
        public object? tlsFingerprint { get; set; }
        public bool daemon { get; set; }
        public object? socks5 { get; set; }
        [JsonPropertyName("self-select")]
        public object? selfSelect { get; set; }
        [JsonPropertyName("submit-to-origin")]
        public bool submitToOrigin { get; set; }
    }
    public class Xmrig
    {
        public bool autosave { get; set; }
        public bool background { get; set; }
        public bool colors { get; set; }
        public object? title { get; set; }
        public Randomx? randomx { get; set; }
        public Cpu? cpu { get; set; }
        [JsonPropertyName("log-file")]
        public int? logFile { get; set; }
        [JsonPropertyName("donate-level")]
        public int donateLevel { get; set; }
        [JsonPropertyName("donate-over-proxy")]
        public int donateOverProxy { get; set; }
        public IList<Pool>? pools { get; set; }
        public long retries { get; set; }
        [JsonPropertyName("retry-pause")]
        public int retryPause { get; set; }
        [JsonPropertyName("print-time")]
        public int printTime { get; set; }
        [JsonPropertyName("health-print-time")]
        public int healthPrintTime { get; set; }
        public bool dmi { get; set; }
        public bool syslog { get; set; }
        public object? userAgent { get; set; }
        public int verbose { get; set; }
        public bool watch { get; set; }
        [JsonPropertyName("pause-on-battery")]
        public bool pauseOnBattery { get; set; }
        [JsonPropertyName("pause-on-active")]
        public object? pauseOnActive { get; set; }
    }    
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
