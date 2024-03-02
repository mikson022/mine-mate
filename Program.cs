using System;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
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
        public List<List<int>>? rx { get; set; }
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
        public List<Pool>? pools { get; set; }
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
        public decimal hashRate { get; set; }
        public int miners { get; set; }
        public decimal totalHashes { get; set; }
        public int lastBlockFoundTime { get; set; }
        public int lastBlockFound { get; set; }
        public int totalBlocksFound { get; set; }
        public int totalMinersPaid { get; set; }
        public int totalPayments { get; set; }
        public double roundHashes { get; set; }
        public int totalAltBlocksFound { get; set; }
        public int activePort { get; set; }
        public List<object>? activePorts { get; set; }
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
        public List<string>? pool_list { get; set; }
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
    public class MinerStatsAllworkers
    {
        public Dictionary<string, WorkerStats>? Workers { get; set; }
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
    public class MinerBlockPayment
    {
        public int id { get; set; }
        public int ts { get; set; }
        public int ts_found { get; set; }
        public int port { get; set; }
        public string? hash { get; set; }
        public double value_percent { get; set; }
        public double value { get; set; }
    }
    public class Response
    {
        public NetworkStats? networkStats { get; set; }
        public List<PoolBlock>? poolBlocks { get; set; }
        public List<string>? minerIdentifiers { get; set; }
        public PoolStats? poolStats { get; set; }
        public List<PoolPayment>? poolPayments { get; set; }
        public MinerStats? minerStats { get; set; }
        public MinerStatsAllworkers? minerStatsAllworkers { get; set; }
        public List<MinerPayment>? minerPayments { get; set; }
        public List<MinerBlockPayment>? minerBlockPayments { get; set; }
    }
    public class Monerodorg
    {
        public List<string>? request { get; set; }
        public Response? response { get; set; }
    }
    public class APIs
    {
        public Monerodorg? monerodorg { get; set; }
    }
    public class App
    {
        public List<string>? addresses { get; set; }
        public APIs? APIs { get; set; }
    }
}



class Program
{
    static class Vars
    {
        public static ConsoleColor primaryColor = ConsoleColor.Green;
        public static ConsoleColor secondaryColor = ConsoleColor.Green;
        public static string greetingTitle = @"
 _____ ______   ________  ________   _______   ________  ________  ________      ________  ________  ________     
|\   _ \  _   \|\   __  \|\   ___  \|\  ___ \ |\   __  \|\   __  \|\   ___ \    |\   __  \|\   __  \|\   ____\    
\ \  \\\__\ \  \ \  \|\  \ \  \\ \  \ \   __/|\ \  \|\  \ \  \|\  \ \  \_|\ \   \ \  \|\  \ \  \|\  \ \  \___|    
 \ \  \\|__| \  \ \  \\\  \ \  \\ \  \ \  \_|/_\ \   _  _\ \  \\\  \ \  \ \\ \   \ \  \\\  \ \   _  _\ \  \  ___  
  \ \  \    \ \  \ \  \\\  \ \  \\ \  \ \  \_|\ \ \  \\  \\ \  \\\  \ \  \_\\ \ __\ \  \\\  \ \  \\  \\ \  \|\  \ 
   \ \__\    \ \__\ \_______\ \__\\ \__\ \_______\ \__\\ _\\ \_______\ \_______\\__\ \_______\ \__\\ _\\ \_______\
    \|__|     \|__|\|_______|\|__| \|__|\|_______|\|__|\|__|\|_______|\|_______\|__|\|_______|\|__|\|__|\|_______|
";
    }
    static class Display
    {
        public static void WithDelayAndColor(string message, int miliseconds, ConsoleColor color, bool timeBeforeMessage = true)
        {
            if(timeBeforeMessage)
                message = $"[{DateTime.Now}]   {message}";
            Console.ForegroundColor = color;
            foreach(char c in message)
            {
                Console.Write(c);
                Thread.Sleep(miliseconds);
            }
            Console.Write("\n");
        }
    }
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
    static class Update
    {
        public static void GeneralStats(AppJSON.App mainApp)
        {
            mainApp = ConfigJSON.ReadAndDeserialize<AppJSON.App>(1);

            string responseJsonNetStat = Http.Get(mainApp.APIs!.monerodorg!.request![0]); //network/stats request
            string responseJsonPoolStat = Http.Get(mainApp.APIs!.monerodorg!.request![1]); //pool/stats request
            string responseJsonPoolBlock = Http.Get(mainApp.APIs!.monerodorg!.request![2]); //pool/block request
            string responseJsonPoolPay = Http.Get(mainApp.APIs!.monerodorg!.request![3]); //pool/payment request

            AppJSON.NetworkStats responseDataNetStat = JsonSerializer.Deserialize<AppJSON.NetworkStats>(responseJsonNetStat)!; 
            AppJSON.PoolStats responseDataPoolStat = JsonSerializer.Deserialize<AppJSON.PoolStats>(responseJsonPoolStat)!; 
            List<AppJSON.PoolBlock> responseDataPoolBlock = JsonSerializer.Deserialize<List<AppJSON.PoolBlock>>(responseJsonPoolBlock)!; 
            List<AppJSON.PoolPayment> responseDataPoolPay = JsonSerializer.Deserialize<List<AppJSON.PoolPayment>>(responseJsonPoolPay)!; 

            mainApp.APIs.monerodorg.response!.networkStats = responseDataNetStat;
            mainApp.APIs.monerodorg.response!.poolStats = responseDataPoolStat;
            mainApp.APIs.monerodorg.response!.poolBlocks = responseDataPoolBlock;
            mainApp.APIs.monerodorg.response!.poolPayments = responseDataPoolPay;

            ConfigJSON.SerializeAndWrite(1, mainApp);
        }
        
        private static List<T> AppendIfNotExists<T>(List<T> existingList, List<T> newList)
        {
            foreach (var newEntry in newList)
            {
                bool isNew = true;
                foreach (var existingEntry in existingList)
                {
                    bool isEqual = true;
                    foreach (var property in typeof(T).GetProperties())
                    {
                        var newValue = property.GetValue(newEntry, null);
                        var existingValue = property.GetValue(existingEntry, null);

                        if (!newValue!.Equals(existingValue))
                        {
                            isEqual = false;
                            break;
                        }
                    }
                    if (isEqual)
                    {
                        isNew = false;
                        break;
                    }
                }
                if (isNew)
                {
                    existingList.Add(newEntry);
                }
            }
            return existingList;
        }

        private static string IntegrateAddressIntoLink(string link, string address)
        {
            string prefix = link.Substring(0, 27);
            string postfix = link.Substring(27).Replace("//", $"/{address}/");
            return prefix + postfix;
        }

        public static void AddressSpecificStats(AppJSON.App mainApp, int addressNumber)
        {
            mainApp = ConfigJSON.ReadAndDeserialize<AppJSON.App>(1);
            string address = mainApp.addresses![addressNumber];
            
            string stats = Http.Get(IntegrateAddressIntoLink(mainApp.APIs!.monerodorg!.request![4], address));
            string statsAllWorkers = Http.Get(IntegrateAddressIntoLink(mainApp.APIs!.monerodorg!.request![5], address));
            string identifiers = Http.Get(IntegrateAddressIntoLink(mainApp.APIs!.monerodorg!.request![6], address));
            string payments = Http.Get(IntegrateAddressIntoLink(mainApp.APIs!.monerodorg!.request![7], address));
            string blockPayments = Http.Get(IntegrateAddressIntoLink(mainApp.APIs!.monerodorg!.request![8], address));

            AppJSON.MinerStats responseStats = JsonSerializer.Deserialize<AppJSON.MinerStats>(stats)!;
            Dictionary<string, AppJSON.WorkerStats> responseStatsAllWorkers = JsonSerializer.Deserialize<Dictionary<string, AppJSON.WorkerStats>>(statsAllWorkers)!;            List<string> responseIDs = JsonSerializer.Deserialize<List<string>>(identifiers)!;
            List<AppJSON.MinerPayment> responsePayments = JsonSerializer.Deserialize<List<AppJSON.MinerPayment>>(payments)!;
            List<AppJSON.MinerBlockPayment> responseBlockPayments = JsonSerializer.Deserialize<List<AppJSON.MinerBlockPayment>>(blockPayments)!;

            mainApp.APIs.monerodorg.response!.minerStats = responseStats;
            mainApp.APIs.monerodorg.response!.minerStatsAllworkers!.Workers = responseStatsAllWorkers;
            mainApp.APIs.monerodorg.response!.minerIdentifiers = responseIDs;
            mainApp.APIs.monerodorg.response!.minerPayments = AppendIfNotExists(mainApp.APIs.monerodorg.response!.minerPayments!, responsePayments);
            mainApp.APIs.monerodorg.response!.minerBlockPayments = AppendIfNotExists(mainApp.APIs.monerodorg.response!.minerBlockPayments!, responseBlockPayments);

            ConfigJSON.SerializeAndWrite(1, mainApp);
        }
    }
    static void Main(string[] args)
    {
        AppJSON.App mainApp = new AppJSON.App();

        Display.WithDelayAndColor(Vars.greetingTitle, 0, Vars.primaryColor, false);
        
        Display.WithDelayAndColor("Fetching information from the server. Please wait...", 5, Vars.secondaryColor);
        Update.GeneralStats(mainApp); 
        Display.WithDelayAndColor("Information updated", 5, Vars.secondaryColor);

    }
}
