SystemMonitor/
├── Controllers/
│ └── SystemStatsController.cs # Handles system statistics requests
├── Models/
│ └── SystemStats.cs # Data model for system statistics
├── Services/
│ ├── ISystemStatsService.cs # Service interface
│ └── SystemStatsService.cs # Service implementation
├── Views/
│ └── SystemStats/
│ └── Index.cshtml # Main dashboard view
└── Program.cs # Application entry point


## Features in Detail

### CPU Monitoring
- Real-time CPU usage percentage
- Visual progress bar
- Historical data chart

### Memory Monitoring
- Total system memory
- Used memory
- Available memory
- Visual representation

### System Uptime
- Time since last system boot
- Continuously updated

## Contributing

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License

This project is licensed under the MIT License - see the LICENSE file for details

## Author

Shailesh Gaikwad

## Acknowledgments

- ASP.NET Core team for the excellent framework
- Chart.js for the beautiful charts
- Bootstrap team for the responsive design framework
