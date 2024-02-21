using System;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;



/*      config/config.json     */
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

/*      app.json        */
namespace AppJSON
{
    public class NetworkStats
    {
        public long difficulty { get; set; }
        public string? hash { get; set; }
        public int main_height { get; set; }
        public int height { get; set; }
        public long value { get; set; }
        public int ts { get; set; }
    }
    public class MinBlockRewards
    {
        [JsonPropertyName("18081")]
        public int data { get; set; }
    }
    public class Price
    {
        public double btc { get; set; }
        public double usd { get; set; }
        public double eur { get; set; }
    }
    public class CurrentEfforts
    {
        [JsonPropertyName("18081")]
        public double data { get; set; }
    }
    public class PplnsPortShares
    {
        [JsonPropertyName("18081")]
        public int data { get; set; }
    }
    public class PortHash
    {
    [JsonPropertyName("18081")]
        public double data { get; set; }
    }
    public class PortMinerCount
    {
    [JsonPropertyName("18081")]
        public int data { get; set; }
    }
    public class PortCoinAlgo
    {
    [JsonPropertyName("18081")]
        public string? data { get; set; }
    }
    public class PoolStatistics
    {
        public double hashRate { get; set; }
        public int miners { get; set; }
        public long totalHashes { get; set; }
        public int lastBlockFoundTime { get; set; }
        public int lastBlockFound { get; set; }
        public int totalBlocksFound { get; set; }
        public int totalMinersPaid { get; set; }
        public int totalPayments { get; set; }
        public double roundHashes { get; set; }
        public int totalAltBlocksFound { get; set; }
        public int activePort { get; set; }
        public IList<object>? activePorts { get; set; }
        public int activePortProfit { get; set; }
        public MinBlockRewards? minBlockRewards { get; set; }
        public int pending { get; set; }
        public Price? price { get; set; }
        public CurrentEfforts? currentEfforts { get; set; }
        public PplnsPortShares? pplnsPortShares { get; set; }
        public double pplnsWindowTime { get; set; }
        public PortHash? portHash { get; set; }
        public PortMinerCount? portMinerCount { get; set; }
        public PortCoinAlgo? portCoinAlgo { get; set; }
    }
    public class PoolStats
    {
        public IList<string>? pool_list { get; set; }
        public PoolStatistics? pool_statistics { get; set; }
        public int last_payment { get; set; }
    }
    public class PoolBlock
    {
        public object? ts { get; set; }
        public string? hash { get; set; }
        public object? diff { get; set; }
        public object? shares { get; set; }
        public int height { get; set; }
        public bool valid { get; set; }
        public bool unlocked { get; set; }
        public string? pool_type { get; set; }
        public object? value { get; set; }
    }
    public class PoolPayment
    {
        public int id { get; set; }
        public string? hash { get; set; }
        public int mixins { get; set; }
        public int payees { get; set; }
        public int fee { get; set; }
        public object? value { get; set; }
        public object? ts { get; set; }
        public string? pool_type { get; set; }
    }
    public class MinerStats
    {
        public double hash { get; set; }
        public double hash2 { get; set; }
        public string? identifier { get; set; }
        public int lastHash { get; set; }
        public double totalHashes { get; set; }
        public int validShares { get; set; }
        public int invalidShares { get; set; }
        public long amtPaid { get; set; }
        public long amtDue { get; set; }
        public int txnCount { get; set; }
    }
    public class Global
    {
        public int lts { get; set; }
        public string? identifer { get; set; }
        public double hash { get; set; }
        public double hash2 { get; set; }
        public double totalHash { get; set; }
        public int validShares { get; set; }
        public int invalidShares { get; set; }
    }
    public class MinerStatsAllworkers
    {
        public IDictionary<string, WorkerStats>? Workers { get; set; }
    }
    public class WorkerStats
    {
        public int lts { get; set; }
        public string? identifier { get; set; }
        public double hash { get; set; }
        public double hash2 { get; set; }
        public double totalHash { get; set; }
        public int validShares { get; set; }
        public int invalidShares { get; set; }
    }
    public class MinerPayment
    {
        public string? pt { get; set; }
        public int ts { get; set; }
        public long amount { get; set; }
        public string? txnHash { get; set; }
        public int mixin { get; set; }
    }
    public class Response
    {
        public NetworkStats? networkStats { get; set; }
        public IDictionary<string, PoolBlock>? poolBlocks { get; set; } 
        public IList<string>? minerIdentifiers { get; set; } 
        public PoolStats? poolStats { get; set; }
        public IList<PoolPayment>? poolPayments { get; set; }
        public MinerStats? minerStats { get; set; }
        public MinerStatsAllworkers? minerStatsAllworkers { get; set; }
        public IList<MinerPayment>? minerPayments { get; set; }
    }
    public class Monerodorg
    {
        public IList<string>? request { get; set; }
        public Response? response { get; set; }
    }
    public class APIs
    {
        public Monerodorg? monerodorg { get; set; }
    }
    public class App
    {
        public IList<string>? addresses { get; set; }
        public APIs? APIs { get; set; }
    }
}



class Program
{

    static class ConfigJSON
    {
        private readonly static string rigJsonPath = 
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Path.Combine("config", "config.json"));
        private readonly static string mineMateJson = 
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Path.Combine("app.json"));
        private readonly static string[] paths = {rigJsonPath, mineMateJson};
        public static T ReadAndDeserialize<T>(int n) 
        { 
            return JsonSerializer.Deserialize<T>(File.ReadAllText(paths[n]))!;   
        }
        public static void SerializeAndWrite<T>(int n, T instance)
        {
            var option = new JsonSerializerOptions { WriteIndented = true };
            File.WriteAllText(paths[n], JsonSerializer.Serialize(instance, option));
        }
    }
    
    static class Http
    {
        public static string Get(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = client.GetAsync(url).Result;
                    response.EnsureSuccessStatusCode(); 
                    return response.Content.ReadAsStringAsync().Result;
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                    throw;
                }
            }
        }
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
