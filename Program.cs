using System;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text.Json.Serialization;



/*      xmrig/config.json     */
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
        public double? diff { get; set; }
        public double? shares { get; set; }
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
    static class Menu
    {
        public static void Start()
        {
            GeneralOptions();
            bool exit = false;
            while (!exit)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true); 
                switch (keyInfo.KeyChar)
                {
                    case 'o':
                        GeneralOptions();
                        break;
                    case 'x':
                        if(ConfigJSON.IsXmrigRunning())
                            Display.WithDelayAndColor("XMRig running", Vars.secondaryColor);
                        else 
                            Display.WithDelayAndColor("XMRig not running", Vars.secondaryColor);
                        break;
                    case 'g':
                        //
                        break;
                    case 'n':
                        MoneroNetwork();
                        break;
                    case 'i':
                        PoolInformation();
                        break;
                    case 'w':
                        YourWorkers();
                        break;
                    case 'm':
                        
                        break;
                    case 'p':
                        
                        break;
                    case 's':
                        
                        break;
                    case 'u':
                        Update.GeneralStats();
                        Update.AddressSpecificStats(0);
                        break;
                    case 'q':
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again");
                        break;
                }
            }
        }
        private static void YourWorkers()
        {
            Display.WithDelayAndColor(Vars.workersTitle, Vars.secondaryColor, false, 0);
            Vars.mainApp = ConfigJSON.ReadAndDeserialize<AppJSON.App>(1);

            int number = Vars.mainApp!.APIs!.monerodorg!.response!.minerIdentifiers!.Count;

            Display.WithDelayAndColor($"Active workers: {number}", Vars.secondaryColor);
            Display.WithDelayAndColor($"Workers: \n", Vars.secondaryColor);
            foreach(var worker in Vars.mainApp!.APIs!.monerodorg!.response!.minerStatsAllworkers!.Workers!)
            {
                if (worker.Key == "global")
                    continue;

                double invalidShares = worker.Value.invalidShares, validShares = worker.Value.validShares;
                double minerHashrate = Vars.mainApp!.APIs!.monerodorg!.response!.minerStats!.hash!;

                Display.WithDelayAndColor($"{worker.Key} \t {Math.Round(worker.Value.hash / minerHashrate * 100, 4)} % of your hashrate", Vars.secondaryColor);
                Display.WithDelayAndColor($"Hashrate: \t {(int)worker.Value.hash} H/s \t {Math.Round(worker.Value.hash/Math.Pow(10, 3), 4)} kH/s", Vars.secondaryColor);
                Display.WithDelayAndColor($"Total hashes: {(ulong)worker.Value.totalHash} / {(ulong)worker.Value.totalHash/Math.Pow(10, 3)} kH / {(ulong)worker.Value.totalHash/Math.Pow(10, 6)} MH / {(ulong)worker.Value.totalHash/Math.Pow(10, 9)} GH", Vars.secondaryColor);
                Display.WithDelayAndColor($"Valid shares: {validShares} \t Success rate of {Math.Round((-1)*(invalidShares / validShares * 100 - 100), 4)}", Vars.secondaryColor);
                Display.WithDelayAndColor($"Invalid shares: {invalidShares}\n", Vars.secondaryColor);
            }
                
            ConfigJSON.SerializeAndWrite(1, Vars.mainApp);
        }
        private static void PoolInformation()
        {
            Display.WithDelayAndColor(Vars.poolTitle, Vars.secondaryColor, false, 0);
            Vars.mainApp = ConfigJSON.ReadAndDeserialize<AppJSON.App>(1);

            double lastBlockFound = Vars.mainApp!.APIs!.monerodorg!.response!.poolStats!.pool_statistics!.lastBlockFound;
            double mainHeight = Vars.mainApp!.APIs!.monerodorg!.response!.networkStats!.main_height;
            double difference = mainHeight - lastBlockFound;

            double averageEffort = 0;
            foreach (var block in Vars.mainApp!.APIs!.monerodorg!.response!.poolBlocks!)
            {
                double effort = (double) block.shares! / (double) block.diff!;
                averageEffort += effort;
            }
            averageEffort /= Vars.mainApp!.APIs!.monerodorg!.response!.poolBlocks!.Count; averageEffort *= 100;
            
            Display.WithDelayAndColor($"Pool Hashrate: {Vars.mainApp!.APIs!.monerodorg!.response!.poolStats!.pool_statistics!.hashRate}", Vars.secondaryColor);
            Display.WithDelayAndColor($"Current effort: {Math.Round(Vars.mainApp!.APIs!.monerodorg!.response!.poolStats!.pool_statistics!.roundHashes / Vars.mainApp!.APIs!.monerodorg!.response!.networkStats!.difficulty * 100, 4)} %", Vars.secondaryColor);
            Display.WithDelayAndColor($"Last block found: {Math.Round(difference * 2 / 60, 4)} hours ago  /  {Math.Round(difference * 2 / 60 / 24, 4)} days ago", Vars.secondaryColor);
            Display.WithDelayAndColor($"PPLNS Window: {Math.Round(Vars.mainApp!.APIs!.monerodorg!.response!.poolStats!.pool_statistics!.pplnsWindowTime / 3600, 4)} hours", Vars.secondaryColor);
            Display.WithDelayAndColor($"Miners: {Vars.mainApp!.APIs!.monerodorg!.response!.poolStats!.pool_statistics!.miners}", Vars.secondaryColor);
            Display.WithDelayAndColor($"Average effort, last 25 blocks: {Math.Round(averageEffort, 4)} %", Vars.secondaryColor);
            
            ConfigJSON.SerializeAndWrite(1, Vars.mainApp);
        }
        private static void MoneroNetwork()
        {
            Display.WithDelayAndColor(Vars.networkTitle, Vars.secondaryColor, false, 0);
            Vars.mainApp = ConfigJSON.ReadAndDeserialize<AppJSON.App>(1);

            double btcPrice = Vars.mainApp!.APIs!.monerodorg!.response!.poolStats!.pool_statistics!.price!.btc;
            double usdPrice = Vars.mainApp!.APIs!.monerodorg!.response!.poolStats!.pool_statistics!.price!.usd;
            double eurPrice = Vars.mainApp!.APIs!.monerodorg!.response!.poolStats!.pool_statistics!.price!.eur;
            double rewardXmr = double.Parse($"0.{Vars.mainApp!.APIs!.monerodorg!.response!.networkStats!.value}");

            Display.WithDelayAndColor($"Difficulty: {Vars.mainApp!.APIs!.monerodorg!.response!.networkStats!.difficulty}", Vars.secondaryColor);
            Display.WithDelayAndColor($"Block Height: {Vars.mainApp!.APIs!.monerodorg!.response!.networkStats!.main_height}", Vars.secondaryColor);
            Display.WithDelayAndColor($"Hash: {Vars.mainApp!.APIs!.monerodorg!.response!.networkStats!.hash}", Vars.secondaryColor);
            Display.WithDelayAndColor($"Reward: {rewardXmr} ~ ${Math.Round(usdPrice*rewardXmr, 4)}", Vars.secondaryColor);
            Display.WithDelayAndColor($"1 Monero: ${Math.Round(usdPrice, 4)}  /  €{Math.Round(eurPrice, 4)}  /  {Math.Round(btcPrice, 12)} btc", Vars.secondaryColor);            
            Display.WithDelayAndColor($"Time Stamp: {ConvertUnixTimestamp(Vars.mainApp!.APIs!.monerodorg!.response!.networkStats!.ts)}  GMT+0000", Vars.secondaryColor);
            ConfigJSON.SerializeAndWrite(1, Vars.mainApp);
        }
        private static void GeneralOptions()
        {
            Display.WithDelayAndColor("\t\tGeneral Menu\n", Vars.primaryColor, false);
                
            Display.WithDelayAndColor("show (o)ptions", Vars.primaryColor);
            Display.WithDelayAndColor("check (x)mrig status", Vars.primaryColor);
            Display.WithDelayAndColor("setup (g)uided", Vars.primaryColor); // guided setup of app.json and config.json


            Display.WithDelayAndColor("monero (n)etwork", Vars.primaryColor); // networkStats
            Display.WithDelayAndColor("pool (i)nformation", Vars.primaryColor); // poolStats, poolPayments, poolBlocks
            
            Display.WithDelayAndColor("your (w)orkers", Vars.primaryColor); // minerIdentifiers, minerStatsAllworkers
            Display.WithDelayAndColor("your (m)iner", Vars.primaryColor);   // minerStats
            Display.WithDelayAndColor("your (p)ayments", Vars.primaryColor); // minerPayments, minerBlockPayments

            Display.WithDelayAndColor("general (s)ummary", Vars.primaryColor);

            Display.WithDelayAndColor("data (u)pdate", Vars.primaryColor);
            

            Display.WithDelayAndColor("exit (q)uit", Vars.primaryColor);
        }
        private static DateTime ConvertUnixTimestamp(long timestamp)
        {
            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(timestamp);
            return dateTimeOffset.UtcDateTime;
        } 
    }
    static class Vars
    {
        public static DateTime lastGeneralAPICall = DateTime.Now.AddMinutes(-4);
        public static DateTime lastAddressSpecificAPICall = DateTime.Now.AddMinutes(-4);
        public static AppJSON.App? mainApp;  
        public static ConsoleColor primaryColor = ConsoleColor.Green;
        public static ConsoleColor secondaryColor = ConsoleColor.Red;
        public static void EnsureConfigFiles()
        {
            bool filesCreated = false; // Flag to track if files were newly created

            string configFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "xmrig");
            if (!Directory.Exists(configFolderPath))
            {
                Directory.CreateDirectory(configFolderPath);
                Console.WriteLine($"Created folder: {configFolderPath}");
                filesCreated = true; // Set flag to true if folder was newly created
            }

            string rigJsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Path.Combine("xmrig", "config.json"));
            string mineMateJson = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Path.Combine("app.json"));
            string[] paths = { rigJsonPath, mineMateJson };

            foreach (string path in paths)
            {
                if (!File.Exists(path))
                {
                    string defaultContent = "";

                    if (path.EndsWith("config.json"))
                    {
                        defaultContent = GenerateDefaultConfigContent();
                    }
                    else if (path.EndsWith("app.json"))
                    {
                        defaultContent = GenerateDefaultAppContent();
                    }
                    File.WriteAllText(path, defaultContent);
                    Console.WriteLine($"Created file: {path}");
                    filesCreated = true; 
                }
            }
            if (filesCreated)
            {
                Update.GeneralStats();
                Update.AddressSpecificStats(0);
            }
        }
        private static string GenerateDefaultConfigContent()
        {
            return @"{
            ""autosave"": true,
            ""background"": true,
            ""colors"": true,
            ""title"": ""Contributor"",
            ""randomx"": {
                ""init"": -1,
                ""init-avx2"": -1,
                ""mode"": ""auto"",
                ""1gb-pages"": false,
                ""rdmsr"": true,
                ""wrmsr"": true,
                ""cache_qos"": false,
                ""numa"": true,
                ""scratchpad_prefetch_mode"": 1
            },
            ""cpu"": {
                ""enabled"": true,
                ""huge-pages"": true,
                ""huge-pages-jit"": false,
                ""hw-aes"": null,
                ""priority"": null,
                ""memory-pool"": false,
                ""yield"": true,
                ""asm"": true,
                ""argon2-impl"": null,
                ""rx"": [
                    [
                        4,
                        0
                    ],
                    [
                        1,
                        1
                    ]
                ]
            },
            ""log-file"": null,
            ""donate-level"": 0,
            ""donate-over-proxy"": 1,
            ""pools"": [
                {
                    ""algo"": null,
                    ""coin"": null,
                    ""url"": ""mine.monerod.org:5555"",
                    ""user"": ""46GDH9iNBwv1X4BBbJzqWxNKJujbR6rK9SPeogNTcms6WjAKsd3Vgq8BUxkVxfQmxN21pQBcLC8HMjkRnwJFvhUiLd8dRic"",
                    ""pass"": ""HereIam"",
                    ""rig_id"": null,
                    ""nicehash"": false,
                    ""keepalive"": true,
                    ""enabled"": true,
                    ""tls"": false,
                    ""sni"": false,
                    ""tls-fingerprint"": null,
                    ""daemon"": false,
                    ""socks5"": null,
                    ""self-select"": null,
                    ""submit-to-origin"": false
                }
            ],
            ""retries"": 10,
            ""retry-pause"": 5,
            ""print-time"": 30,
            ""health-print-time"": 120,
            ""dmi"": true,
            ""syslog"": false,
            ""userAgent"": null,
            ""verbose"": 1,
            ""watch"": true,
            ""pause-on-battery"": false,
            ""pause-on-active"": false
        }";
        }
        private static string GenerateDefaultAppContent()
        {
            return @"{
            ""addresses"": [
                ""46GDH9iNBwv1X4BBbJzqWxNKJujbR6rK9SPeogNTcms6WjAKsd3Vgq8BUxkVxfQmxN21pQBcLC8HMjkRnwJFvhUiLd8dRic""
            ],
            ""APIs"": {
                ""monerodorg"": {
                ""request"": [
                    ""https://np-api.monerod.org/network/stats"",
                    ""https://np-api.monerod.org/pool/stats"",
                    ""https://np-api.monerod.org/pool/blocks"",
                    ""https://np-api.monerod.org/pool/payments"",
                    ""https://np-api.monerod.org/miner//stats"",
                    ""https://np-api.monerod.org/miner//stats/allworkers"",
                    ""https://np-api.monerod.org/miner//identifiers"",
                    ""https://np-api.monerod.org/miner//payments"",
                    ""https://np-api.monerod.org/miner//block_payments""
                ],
                ""response"": {
                    ""networkStats"": {},
                    ""poolBlocks"": [],
                    ""minerIdentifiers"": null,
                    ""poolStats"": {
                    ""pool_list"": []
                    },
                    ""poolPayments"": [],
                    ""minerStats"": null,
                    ""minerStatsAllworkers"": {
                    ""global"": {
                        ""lts"": 0,
                        ""identifier"": ""global"",
                        ""hash"": 0,
                        ""hash2"": 0,
                        ""totalHash"": 0,
                        ""validShares"": 0,
                        ""invalidShares"": 0
                    }
                    },
                    ""minerPayments"": [],
                    ""minerBlockPayments"": []
                }
                }
            }
            }";
        }
        public static string greetingTitle = @"
 _____ ______   ___  ________   _______   _____ ______   ________  _________  _______      
|\   _ \  _   \|\  \|\   ___  \|\  ___ \ |\   _ \  _   \|\   __  \|\___   ___\\  ___ \     
\ \  \\\__\ \  \ \  \ \  \\ \  \ \   __/|\ \  \\\__\ \  \ \  \|\  \|___ \  \_\ \   __/|    
 \ \  \\|__| \  \ \  \ \  \\ \  \ \  \_|/_\ \  \\|__| \  \ \   __  \   \ \  \ \ \  \_|/__  
  \ \  \    \ \  \ \  \ \  \\ \  \ \  \_|\ \ \  \    \ \  \ \  \ \  \   \ \  \ \ \  \_|\ \ 
   \ \__\    \ \__\ \__\ \__\\ \__\ \_______\ \__\    \ \__\ \__\ \__\   \ \__\ \ \_______\
    \|__|     \|__|\|__|\|__| \|__|\|_______|\|__|     \|__|\|__|\|__|    \|__|  \|_______|";
        public static string networkTitle = @"
 ________   _______  _________  ___       __   ________  ________  ___  __       
|\   ___  \|\  ___ \|\___   ___\\  \     |\  \|\   __  \|\   __  \|\  \|\  \     
\ \  \\ \  \ \   __/\|___ \  \_\ \  \    \ \  \ \  \|\  \ \  \|\  \ \  \/  /|_   
 \ \  \\ \  \ \  \_|/__  \ \  \ \ \  \  __\ \  \ \  \\\  \ \   _  _\ \   ___  \  
  \ \  \\ \  \ \  \_|\ \  \ \  \ \ \  \|\__\_\  \ \  \\\  \ \  \\  \\ \  \\ \  \ 
   \ \__\\ \__\ \_______\  \ \__\ \ \____________\ \_______\ \__\\ _\\ \__\\ \__\
    \|__| \|__|\|_______|   \|__|  \|____________|\|_______|\|__|\|__|\|__| \|__|";  
        public static string poolTitle = @"
 ________  ________  ________  ___          
|\   __  \|\   __  \|\   __  \|\  \         
\ \  \|\  \ \  \|\  \ \  \|\  \ \  \        
 \ \   ____\ \  \\\  \ \  \\\  \ \  \       
  \ \  \___|\ \  \\\  \ \  \\\  \ \  \____  
   \ \__\    \ \_______\ \_______\ \_______\
    \|__|     \|_______|\|_______|\|_______|"; 
        public static string workersTitle = @"
 ___       __   ________  ________  ___  __    _______   ________  ________      
|\  \     |\  \|\   __  \|\   __  \|\  \|\  \ |\  ___ \ |\   __  \|\   ____\     
\ \  \    \ \  \ \  \|\  \ \  \|\  \ \  \/  /|\ \   __/|\ \  \|\  \ \  \___|_    
 \ \  \  __\ \  \ \  \\\  \ \   _  _\ \   ___  \ \  \_|/_\ \   _  _\ \_____  \   
  \ \  \|\__\_\  \ \  \\\  \ \  \\  \\ \  \\ \  \ \  \_|\ \ \  \\  \\|____|\  \  
   \ \____________\ \_______\ \__\\ _\\ \__\\ \__\ \_______\ \__\\ _\ ____\_\  \ 
    \|____________|\|_______|\|__|\|__|\|__| \|__|\|_______|\|__|\|__|\_________\
                                                                     \|_________|";
    }
    static class Display
    {
        public static void WithDelayAndColor(string message, ConsoleColor color, bool timeBeforeMessage = true, int miliseconds = 5)
        {
            if(timeBeforeMessage)
                message = $"[{DateTime.Now}] {message}";
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
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Path.Combine("xmrig", "config.json"));
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
        public static bool IsXmrigRunning()
        {
            Process[] processes = Process.GetProcessesByName("xmrig");
            return processes.Length > 0;
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
        public static void GeneralStats()
        {
            DateTime currentTime = DateTime.Now;
            TimeSpan timeSinceLastCall = currentTime - Vars.lastGeneralAPICall;
            if (timeSinceLastCall < TimeSpan.FromMinutes(4))
            {
                TimeSpan cooldownRemaining = TimeSpan.FromMinutes(4) - timeSinceLastCall;
                Display.WithDelayAndColor($"Try again in {cooldownRemaining.TotalMinutes:F2} minutes", Vars.secondaryColor);
                return; 
            }
            Vars.lastGeneralAPICall = currentTime;

            Vars.mainApp = ConfigJSON.ReadAndDeserialize<AppJSON.App>(1);

            Display.WithDelayAndColor("Fetching information from the server. Please wait...", Vars.secondaryColor);
            string responseJsonNetStat = Http.Get(Vars.mainApp.APIs!.monerodorg!.request![0]); //network/stats request
            string responseJsonPoolStat = Http.Get(Vars.mainApp.APIs!.monerodorg!.request![1]); //pool/stats request
            //string responseJsonPoolBlock = Http.Get(Vars.mainApp.APIs!.monerodorg!.request![2]); //pool/block request
            //string responseJsonPoolPay = Http.Get(Vars.mainApp.APIs!.monerodorg!.request![3]); //pool/payment request

            AppJSON.NetworkStats responseDataNetStat = JsonSerializer.Deserialize<AppJSON.NetworkStats>(responseJsonNetStat)!; 
            AppJSON.PoolStats responseDataPoolStat = JsonSerializer.Deserialize<AppJSON.PoolStats>(responseJsonPoolStat)!; 
            //List<AppJSON.PoolBlock> responseDataPoolBlock = JsonSerializer.Deserialize<List<AppJSON.PoolBlock>>(responseJsonPoolBlock)!; 
            //List<AppJSON.PoolPayment> responseDataPoolPay = JsonSerializer.Deserialize<List<AppJSON.PoolPayment>>(responseJsonPoolPay)!; 

            Vars.mainApp.APIs.monerodorg.response!.networkStats = responseDataNetStat;
            Vars.mainApp.APIs.monerodorg.response!.poolStats = responseDataPoolStat;
            //Vars.mainApp.APIs.monerodorg.response!.poolBlocks = responseDataPoolBlock;
            //Vars.mainApp.APIs.monerodorg.response!.poolPayments = responseDataPoolPay;
            
            /*  Same data on API until new block is found and data redundancy. 
                These will be resolved later to not increase of website costs   */

            ConfigJSON.SerializeAndWrite(1, Vars.mainApp);
            Display.WithDelayAndColor("Information updated", Vars.secondaryColor);
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

        public static void AddressSpecificStats(int addressNumber)
        {
            DateTime currentTime = DateTime.Now;
            TimeSpan timeSinceLastCall = currentTime - Vars.lastAddressSpecificAPICall;
            if (timeSinceLastCall < TimeSpan.FromMinutes(4))
            {
                TimeSpan cooldownRemaining = TimeSpan.FromMinutes(4) - timeSinceLastCall;
                Display.WithDelayAndColor($"Try again in {cooldownRemaining.TotalMinutes:F2} minutes", Vars.secondaryColor);
                return; 
            }
            Vars.lastAddressSpecificAPICall = currentTime;

            Vars.mainApp = ConfigJSON.ReadAndDeserialize<AppJSON.App>(1);
            string address = Vars.mainApp.addresses![addressNumber];
            
            Display.WithDelayAndColor("Fetching information from the server. Please wait...", Vars.secondaryColor);
            string stats = Http.Get(IntegrateAddressIntoLink(Vars.mainApp.APIs!.monerodorg!.request![4], address));
            string statsAllWorkers = Http.Get(IntegrateAddressIntoLink(Vars.mainApp.APIs!.monerodorg!.request![5], address));
            string identifiers = Http.Get(IntegrateAddressIntoLink(Vars.mainApp.APIs!.monerodorg!.request![6], address));
            string payments = Http.Get(IntegrateAddressIntoLink(Vars.mainApp.APIs!.monerodorg!.request![7], address));
            string blockPayments = Http.Get(IntegrateAddressIntoLink(Vars.mainApp.APIs!.monerodorg!.request![8], address));

            AppJSON.MinerStats responseStats = JsonSerializer.Deserialize<AppJSON.MinerStats>(stats)!;
            Dictionary<string, AppJSON.WorkerStats> responseStatsAllWorkers = JsonSerializer.Deserialize<Dictionary<string, AppJSON.WorkerStats>>(statsAllWorkers)!;            List<string> responseIDs = JsonSerializer.Deserialize<List<string>>(identifiers)!;
            List<AppJSON.MinerPayment> responsePayments = JsonSerializer.Deserialize<List<AppJSON.MinerPayment>>(payments)!;
            List<AppJSON.MinerBlockPayment> responseBlockPayments = JsonSerializer.Deserialize<List<AppJSON.MinerBlockPayment>>(blockPayments)!;

            Vars.mainApp.APIs.monerodorg.response!.minerStats = responseStats;
            Vars.mainApp.APIs.monerodorg.response!.minerStatsAllworkers!.Workers = responseStatsAllWorkers;
            Vars.mainApp.APIs.monerodorg.response!.minerIdentifiers = responseIDs;
            Vars.mainApp.APIs.monerodorg.response!.minerPayments = AppendIfNotExists(Vars.mainApp.APIs.monerodorg.response!.minerPayments!, responsePayments);
            Vars.mainApp.APIs.monerodorg.response!.minerBlockPayments = AppendIfNotExists(Vars.mainApp.APIs.monerodorg.response!.minerBlockPayments!, responseBlockPayments);

            ConfigJSON.SerializeAndWrite(1, Vars.mainApp);
            Display.WithDelayAndColor("Information updated", Vars.secondaryColor);
        }
    }
    static void Main(string[] args)
    {
        Display.WithDelayAndColor(Vars.greetingTitle,Vars.primaryColor, false, 0);
        Vars.EnsureConfigFiles();  
        Menu.Start();
    }
}
