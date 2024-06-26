# Mine-Mate: Your Monero Mining Companion

Mine Mate is a utility designed to interact with [xmrig](https://xmrig.com/) and the pool mining website [monerod.org](https://monerod.org/home), offering users quick access to information about the Monero network and its pool statistics via APIs. This tool provides an intuitive console interface for viewing various statistics and adjusting settings in the xmrig mining software.

## Table of Contents

- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Screenshots](#screenshots)
- [Contributing](#contributing)
- [License](#license)
- [Known Issues](#known-issues)
- [Donations](#donations)

## Features

**WIP - Work In Progress** 

- Manage mining operations conveniently by clicking keys in the interactive console interface.
- Fetch general statistics about the Monero network and its prices.
- Monitor pool mining statistics.
- **WIP** View your miner and workers statistics and your (block) payments.
- **WIP** Easy xmrig + monerod.org mining configuration.
- **WIP** Adjust mining settings such as core allocations.

## Installation

```bash
$ git clone https://github.com/mikson022/mine-mate.git
$ cd mine-mate
$ dotnet build
```
Don't forget to paste the xmrig executable into /minemate/xmrig/

## Usage

**WIP - Work In Progress**

Launch Mine-Mate and navigate using the following keys:

- **O:** Display all options.
- **X:** Check if xmrig is running.
- **WIP** **G:** Guided interactive setup of config files.
- **N:** Monero network: current difficulty, block height, hash, reward, monero price, time stamp.
- **I:** Pool stats: hashrate, current effort, last block time, miners, average effort last 25 blocks. 
- **W:** Your workers' stats.
- **WIP** **M:** Your miner stats.
- **WIP** **P:** Your payments and block payments.
- **WIP** **S:** General summary.
- **U:** Update data through APIs. (once in 4 minutes)
- **Q:** Quit the application.

## Screenshots

![Start](screenshots/StartUp.png)

![Network](screenshots/Network.png)

![Pool](screenshots/Pool.png)

![Workers](screenshots/Workers.png)

## Contributing

Contributions are welcome. Submit pull requests or raise issues for any improvements or bug fixes.

## License

This project is licensed under the MIT License.

## Known Issues

- Update methods update data that is already present in the database. Such as entries of Pool Blocks and Payments. These are disabled until proper handling is implemented.

## Donations

If you find Mine-Mate helpful, consider supporting me/its development:
```
884Pjeq7L7n7cCciVnjZuS9dbXj86GqkCKKes4REg9RK2cvhjRNZVUXHsr7WWS3cCtWag48N9ASJe5QzRoyWJM4VJEG7Gje
```

