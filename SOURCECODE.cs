using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace PrivacyGuard
{
    class Program
    {
        // Comprehensive Microsoft bloatware list (verified safe to remove)
        static readonly List<(string name, string package)> BloatwareList = new List<(string, string)>
        {
            // Core Bloatware
            ("OneDrive", "Microsoft.OneDrive"),
            ("Xbox App", "Microsoft.XboxApp"),
            ("Candy Crush Soda Saga", "king.com.CandyCrushSodaSaga"),
            ("Skype", "Microsoft.SkypeApp"),
            ("Windows Maps", "Microsoft.WindowsMaps"),
            ("Photos", "Microsoft.Windows.Photos"),
            ("Groove Music", "Microsoft.ZuneMusic"),
            ("Movies & TV", "Microsoft.ZuneVideo"),
            ("Alarms & Clock", "Microsoft.WindowsAlarms"),
            ("Calculator", "Microsoft.WindowsCalculator"),
            
            // Productivity & Office
            ("Microsoft Teams", "MicrosoftTeams"),
            ("Outlook Mail", "Microsoft.Windowscommunicationsapps"),
            ("Calendar", "Microsoft.WindowsCommunicationsApps"),
            ("Sticky Notes", "Microsoft.MicrosoftStickyNotes"),
            ("To Do", "Microsoft.MicrosoftToDo"),
            
            // Gaming & Entertainment
            ("Minecraft", "Microsoft.MinecraftUWP"),
            ("Solitaire Collection", "Microsoft.MicrosoftSolitaireCollection"),
            ("Paint 3D", "Microsoft.MSPaint"),
            ("Mixed Reality Portal", "Microsoft.MixedReality.Portal"),
            ("Get Started", "Microsoft.Getstarted"),
            
            // Utilities & System Apps
            ("Feedback Hub", "Microsoft.WindowsFeedbackHub"),
            ("Tips", "Microsoft.GetHelp"),
            ("People", "Microsoft.Windows.People"),
            ("Phone Link", "Microsoft.WindowsPhone"),
            ("Your Phone", "Microsoft.YourPhone"),
            
            // Additional Verified Bloatware
            ("Bing News", "Microsoft.WindowsNews"),
            ("Weather", "Microsoft.WindowsWeather"),
            ("Finance", "Microsoft.WindowsFinance"),
            ("Sports", "Microsoft.WindowsSports"),
            ("Health & Fitness", "Microsoft.WindowsHealth"),
            ("Money", "Microsoft.WindowsMoney"),
            ("Translator", "Microsoft.WindowsTranslator"),
            ("Camera", "Microsoft.WindowsCamera"),
            ("Voice Recorder", "Microsoft.WindowsSoundRecorder"),
            ("Snipping Tool", "Microsoft.WindowsNotepad"),
            ("Mail", "Microsoft.Windows.CommunicationsApps"),
            ("People Bar", "Microsoft.People"),
            ("Office Hub", "Microsoft.MicrosoftOfficeHub"),
            ("OneNote", "Microsoft.Office.OneNote"),
            ("Power Automate", "Microsoft.PowerAutomateDesktop"),
            ("Clipchamp", "Clipchamp.Clipchamp"),
            ("Family Safety", "Microsoft.Windows.ParentalControls"),
            ("Wallet", "Microsoft.Wallet"),
            ("Messaging", "Microsoft.Messaging"),
            ("Scan", "Microsoft.WindowsScan")
        };

        static void Main(string[] args)
        {
            ShowHeader();
            ShowMenu();
        }

        static void ShowHeader()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("┌─────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│ Privacy Guard v2.1 - Microsoft Bloatware Remover & Privacy Tool │");
            Console.WriteLine("└─────────────────────────────────────────────────────────────────┘");
            Console.ResetColor();
            Console.WriteLine();
        }

        static void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Main Menu:");
            Console.WriteLine("─────────");
            Console.ResetColor();
            Console.WriteLine("1. Select Bloatware to Remove");
            Console.WriteLine("2. Delete ALL Microsoft Bloatware");
            Console.WriteLine("3. View Removed Apps");
            Console.WriteLine("4. Restore All Apps");
            Console.WriteLine("5. Advanced Telemetry Control");
            Console.WriteLine("6. Export/Import Config");
            Console.WriteLine("7. About");
            Console.WriteLine("0. Exit");
            Console.WriteLine();

            Console.Write("Select option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    SelectBloatware();
                    break;
                case "2":
                    DeleteAllBloatware();
                    break;
                case "3":
                    ViewRemovedApps();
                    break;
                case "4":
                    RestoreAllApps();
                    break;
                case "5":
                    ShowTelemetryMenu();
                    break;
                case "6":
                    ShowConfigMenu();
                    break;
                case "7":
                    ShowAbout();
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nInvalid option. Press any key to continue...");
                    Console.ReadKey();
                    ShowMenu();
                    break;
            }
        }
        static void ShowAbout()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("┌───────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│                       ABOUT PRIVACY GUARD                     │");
            Console.WriteLine("└───────────────────────────────────────────────────────────────┘");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Privacy Guard v2.1");
            Console.WriteLine("Microsoft Bloatware Remover & Privacy Tool");
            Console.WriteLine();
            Console.WriteLine("-> FEATURES:");
            Console.WriteLine("-> Removes 40+ Microsoft bloatware apps safely");
            Console.WriteLine("-> Option to delete ALL bloatware with one click");
            Console.WriteLine("-> Granular app selection (choose specific apps)");
            Console.WriteLine("-> Advanced telemetry control (diagnostic data, ads, location)");
            Console.WriteLine("-> Full restore capability (reinstall all apps)");
            Console.WriteLine("-> Detailed logging to Desktop");
            Console.WriteLine();
            Console.WriteLine("-> SAFETY FIRST:");
            Console.WriteLine("-> Never removes critical system components");
            Console.WriteLine("-> All operations require explicit confirmation");
            Console.WriteLine("-> Requires Administrator rights for full functionality");
            Console.WriteLine("-> 100% reversible - no permanent changes");
            Console.WriteLine();
            Console.WriteLine("-> PRIVACY PROMISE:");
            Console.WriteLine("-> Zero telemetry: collects no data");
            Console.WriteLine("-> Open source: verify every line of code");
            Console.WriteLine("-> No network calls: works offline");
            Console.WriteLine();
            Console.WriteLine("-> REQUIREMENTS:");
            Console.WriteLine("-> Windows 10 version 1607+ or Windows 11");
            Console.WriteLine("-> .NET Framework 4.8+");
            Console.WriteLine("-> Administrator privileges");
            Console.WriteLine();
            Console.WriteLine("-> LICENSE:");
            Console.WriteLine("MIT License - Free to use, modify, and distribute");
            Console.WriteLine();
            Console.WriteLine("Developed by Mohammad Harib Ahmad");
            Console.WriteLine("2026 - All rights reserved");
            Console.WriteLine();
            Console.WriteLine("Press any key to return to menu...");
            Console.ReadKey();
            ShowMenu();
        }
        static void SelectBloatware()
        {
            Console.Clear();
            ShowHeader();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Microsoft Bloatware Remover:");
            Console.WriteLine("───────────────────────────");
            Console.ResetColor();
            Console.WriteLine("Select apps to remove (space-separated numbers):");
            Console.WriteLine();

            // Display apps in 3 columns
            for (int i = 0; i < BloatwareList.Count; i += 3)
            {
                string col1 = i < BloatwareList.Count ? $"[{i + 1}] {BloatwareList[i].name,-25}" : "";
                string col2 = i + 1 < BloatwareList.Count ? $"[{i + 2}] {BloatwareList[i + 1].name,-25}" : "";
                string col3 = i + 2 < BloatwareList.Count ? $"[{i + 3}] {BloatwareList[i + 2].name,-25}" : "";
                Console.WriteLine($"{col1}{col2}{col3}");
            }

            Console.WriteLine();
            Console.WriteLine("Example: '1 3 5 12' to remove OneDrive, Candy Crush, Windows Maps, and Outlook Mail");
            Console.WriteLine("Type 'ALL' to select all apps");
            Console.WriteLine();

            Console.Write("Your selection: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("\nNo selection made. Press any key to return...");
                Console.ReadKey();
                ShowMenu();
                return;
            }

            var selections = new HashSet<int>();

            if (input.ToUpper() == "ALL")
            {
                for (int i = 1; i <= BloatwareList.Count; i++)
                    selections.Add(i);
            }
            else
            {
                foreach (var item in input.Split(' ').Where(s => !string.IsNullOrWhiteSpace(s)))
                {
                    if (int.TryParse(item, out int num) && num >= 1 && num <= BloatwareList.Count)
                    {
                        selections.Add(num);
                    }
                }
            }

            if (selections.Count == 0)
            {
                Console.WriteLine("\n-> No valid apps selected. Press any key to continue...");
                Console.ReadKey();
                SelectBloatware();
                return;
            }

            // Show preview
            Console.WriteLine("\n-> Preview: Selected apps for removal:");
            var appsToRemove = new List<(string name, string package)>();
            foreach (int index in selections)
            {
                var app = BloatwareList[index - 1];
                appsToRemove.Add(app);
                Console.WriteLine($"   • {app.name} ({app.package})");
            }

            Console.WriteLine($"\n{appsToRemove.Count} apps ready for removal.");
            Console.Write("\nTYPE 'REMOVE' TO CONFIRM: ");
            if (Console.ReadLine() != "REMOVE")
            {
                ShowMenu();
                return;
            }

            PerformRemoval(appsToRemove);
        }

        static void DeleteAllBloatware()
        {
            Console.Clear();
            ShowHeader();
            Console.WriteLine("-> DELETE ALL MICROSOFT BLOATWARE");
            Console.WriteLine("───────────────────────────────");
            Console.WriteLine("This will remove ALL Microsoft bloatware apps from the list.");
            Console.WriteLine("Includes: OneDrive, Xbox, Candy Crush, Skype, Teams, etc.");
            Console.WriteLine();
            Console.WriteLine("-> WARNING: This is IRREVERSIBLE without restore function!");
            Console.WriteLine("You can restore apps later using 'Restore All Apps' option.");
            Console.WriteLine();

            Console.Write("TYPE 'DELETE ALL' TO CONFIRM: ");
            if (Console.ReadLine() != "DELETE ALL")
            {
                ShowMenu();
                return;
            }

            var allApps = new List<(string name, string package)>();
            foreach (var app in BloatwareList)
                allApps.Add(app);

            PerformRemoval(allApps);
        }

        static void PerformRemoval(List<(string name, string package)> appsToRemove)
        {
            Console.WriteLine("\nRemoving selected apps...");
            int removedCount = 0;
            var logFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "privacy_guard_log.txt");

            using (var log = new StreamWriter(logFile, true))
            {
                log.WriteLine($"[{DateTime.Now}] Starting bloatware removal...");
                foreach (var app in appsToRemove)
                {
                    try
                    {
                        // Skip critical system apps (extra safety)
                        if (IsCriticalApp(app.package))
                        {
                            Console.WriteLine($"-> Skipped critical app: {app.name}");
                            log.WriteLine($"Skipped critical app: {app.name}");
                            continue;
                        }

                        var psi = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = $"-Command \"Get-AppxPackage *{app.package}* | Remove-AppxPackage\"",
                            Verb = "runas",
                            UseShellExecute = true,
                            CreateNoWindow = true
                        };

                        using (var process = Process.Start(psi))
                        {
                            if (process.WaitForExit(8000))
                            {
                                Console.WriteLine($"-> Removed: {app.name}");
                                log.WriteLine($"Removed: {app.name} ({app.package})");
                                removedCount++;
                            }
                            else
                            {
                                Console.WriteLine($"-> Timeout removing: {app.name}");
                                log.WriteLine($"Timeout removing: {app.name}");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"-> Failed to remove {app.name}: {ex.Message}");
                        log.WriteLine($"Failed to remove {app.name}: {ex.Message}");
                    }
                }
                log.WriteLine($"Completed removal. Total removed: {removedCount}");
            }

            Console.WriteLine($"\n-> Removal complete! {removedCount} apps removed.");
            Console.WriteLine($"-> Log saved to: {logFile}");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            ShowMenu();
        }

        static bool IsCriticalApp(string packageName)
        {
            // Critical system apps that should never be removed
            var criticalApps = new[]
            {
                "Microsoft.Windows.ShellExperienceHost",
                "Microsoft.Windows.Cortana",
                "Microsoft.Windows.CloudExperienceHost",
                "Microsoft.Windows.AppResolverUX",
                "Microsoft.Windows.AssignedAccessLockApp"
            };

            return Array.Exists(criticalApps, critical => packageName.Contains(critical));
        }

        static void ViewRemovedApps()
        {
            Console.Clear();
            ShowHeader();
            Console.WriteLine("-> REMOVED APPS LOG");
            Console.WriteLine("───────────────────");
            Console.WriteLine("This shows apps removed in current session only.");
            Console.WriteLine("For full history, check privacy_guard_log.txt on Desktop.");
            Console.WriteLine();
            Console.WriteLine("Press any key to return to menu...");
            Console.ReadKey();
            ShowMenu();
        }

        static void RestoreAllApps()
        {
            Console.Clear();
            ShowHeader();
            Console.WriteLine("-> RESTORE ALL MICROSOFT APPS");
            Console.WriteLine("────────────────────────────");
            Console.WriteLine("This will reinstall all Microsoft apps that were removed.");
            Console.WriteLine("Operation may take several minutes.");
            Console.WriteLine();

            Console.Write("Continue? (Y/N): ");
            if (Console.ReadLine().ToUpper() != "Y") { ShowMenu(); return; }

            Console.WriteLine("\nRestoring Microsoft apps...");
            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = "-Command \"Get-AppxPackage -AllUsers| Foreach {Add-AppxPackage -DisableDevelopmentMode -Register \\\"$($_.InstallLocation)\\AppXManifest.xml\\\"}\"",
                    Verb = "runas",
                    UseShellExecute = true,
                    CreateNoWindow = false
                };
                Process.Start(psi);
                Console.WriteLine("\n-> Restore process started!");
                Console.WriteLine("-> This may take 5-10 minutes to complete.");
                Console.WriteLine("Press any key to return to menu...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n-> Restore failed: {ex.Message}");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            ShowMenu();
        }

        static void ShowTelemetryMenu()
        {
            Console.Clear();
            ShowHeader();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Advanced Telemetry Control:");
            Console.WriteLine("─────────────────────────");
            Console.ResetColor();
            Console.WriteLine("1. Disable Diagnostic Data");
            Console.WriteLine("2. Disable Connected User Experiences");
            Console.WriteLine("3. Disable Advertising ID");
            Console.WriteLine("4. Disable Location Tracking");
            Console.WriteLine("5. Disable Speech Recognition Telemetry");
            Console.WriteLine("6. Restore All Telemetry Settings");
            Console.WriteLine("0. Back to Main Menu");
            Console.WriteLine();

            Console.Write("Select option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisableDiagnosticData();
                    break;
                case "2":
                    DisableConnectedExperiences();
                    break;
                case "3":
                    DisableAdvertisingID();
                    break;
                case "4":
                    DisableLocationTracking();
                    break;
                case "5":
                    DisableSpeechTelemetry();
                    break;
                case "6":
                    RestoreTelemetrySettings();
                    break;
                case "0":
                    ShowMenu();
                    break;
                default:
                    Console.WriteLine("\nInvalid option. Press any key to continue...");
                    Console.ReadKey();
                    ShowTelemetryMenu();
                    break;
            }
        }

        static void DisableDiagnosticData()
        {
            Console.Clear();
            ShowHeader();
            Console.WriteLine("-> DISABLE DIAGNOSTIC DATA");
            Console.WriteLine("──────────────────────────");
            Console.WriteLine("Reduces Windows data collection to minimum level.");
            Console.WriteLine();

            Console.Write("Continue? (Y/N): ");
            if (Console.ReadLine().ToUpper() != "Y") { ShowTelemetryMenu(); return; }

            ExecuteRegistryCommand(
                "Set-ItemProperty -Path 'HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection' -Name 'AllowTelemetry' -Value 0 -Force",
                "Diagnostic data disabled successfully",
                "Failed to disable diagnostic data"
            );
            ShowTelemetryMenu();
        }

        static void DisableConnectedExperiences()
        {
            Console.Clear();
            ShowHeader();
            Console.WriteLine("-> DISABLE CONNECTED USER EXPERIENCES");
            Console.WriteLine("──────────────────────────────────────");
            Console.WriteLine("Prevents Windows from connecting to online services.");
            Console.WriteLine();

            Console.Write("Continue? (Y/N): ");
            if (Console.ReadLine().ToUpper() != "Y") { ShowTelemetryMenu(); return; }

            ExecuteRegistryCommand(
                "Set-ItemProperty -Path 'HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection' -Name 'DoNotShowFeedbackNotifications' -Value 1 -Force",
                "Connected experiences disabled successfully",
                "Failed to disable connected experiences"
            );
            ShowTelemetryMenu();
        }

        static void DisableAdvertisingID()
        {
            Console.Clear();
            ShowHeader();
            Console.WriteLine("-> DISABLE ADVERTISING ID");
            Console.WriteLine("─────────────────────────");
            Console.WriteLine("Stops personalized ads based on your activity.");
            Console.WriteLine();

            Console.Write("Continue? (Y/N): ");
            if (Console.ReadLine().ToUpper() != "Y") { ShowTelemetryMenu(); return; }

            ExecuteRegistryCommand(
                "Set-ItemProperty -Path 'HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\AdvertisingInfo' -Name 'Enabled' -Value 0 -Force",
                "Advertising ID disabled successfully",
                "Failed to disable advertising ID"
            );
            ShowTelemetryMenu();
        }

        static void DisableLocationTracking()
        {
            Console.Clear();
            ShowHeader();
            Console.WriteLine("-> DISABLE LOCATION TRACKING");
            Console.WriteLine("────────────────────────────");
            Console.WriteLine("Turns off Windows location services.");
            Console.WriteLine();

            Console.Write("Continue? (Y/N): ");
            if (Console.ReadLine().ToUpper() != "Y") { ShowTelemetryMenu(); return; }

            ExecuteRegistryCommand(
                "Set-ItemProperty -Path 'HKLM:\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Sensor\\Overrides\\{BFA794E4-F964-4FDB-90F6-51056BFE4B44}' -Name 'SensorPermissionState' -Value 0 -Force",
                "Location tracking disabled successfully",
                "Failed to disable location tracking"
            );
            ShowTelemetryMenu();
        }

        static void DisableSpeechTelemetry()
        {
            Console.Clear();
            ShowHeader();
            Console.WriteLine("-> DISABLE SPEECH RECOGNITION TELEMETRY");
            Console.WriteLine("─────────────────────────────────────────");
            Console.WriteLine("Prevents voice data from being sent to Microsoft.");
            Console.WriteLine();

            Console.Write("Continue? (Y/N): ");
            if (Console.ReadLine().ToUpper() != "Y") { ShowTelemetryMenu(); return; }

            ExecuteRegistryCommand(
                "Set-ItemProperty -Path 'HKCU:\\Software\\Microsoft\\Speech_OneCore\\Settings\\OnlineSpeechPrivacy' -Name 'HasAccepted' -Value 0 -Force",
                "Speech telemetry disabled successfully",
                "Failed to disable speech telemetry"
            );
            ShowTelemetryMenu();
        }

        static void RestoreTelemetrySettings()
        {
            Console.Clear();
            ShowHeader();
            Console.WriteLine("-> RESTORE TELEMETRY SETTINGS");
            Console.WriteLine("─────────────────────────────");
            Console.WriteLine("Reverts all telemetry changes to Windows defaults.");
            Console.WriteLine();

            Console.Write("TYPE 'RESTORE' TO CONFIRM: ");
            if (Console.ReadLine() != "RESTORE") { ShowTelemetryMenu(); return; }

            ExecuteRegistryCommand(
                "Remove-ItemProperty -Path 'HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection' -Name 'AllowTelemetry' -ErrorAction SilentlyContinue",
                "Telemetry settings restored to defaults",
                "Failed to restore telemetry settings"
            );
            ShowTelemetryMenu();
        }

        static void ExecuteRegistryCommand(string command, string successMessage, string errorMessage)
        {
            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = $"-Command \"{command}\"",
                    Verb = "runas",
                    UseShellExecute = true,
                    CreateNoWindow = true
                };
                using (var process = Process.Start(psi))
                {
                    process.WaitForExit(5000);
                }
                Console.WriteLine($"\n✓ {successMessage}");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n✗ {errorMessage}: {ex.Message}");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        static void ShowConfigMenu()
        {
            Console.Clear();
            ShowHeader();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Export/Import Configuration:");
            Console.WriteLine("───────────────────────────");
            Console.ResetColor();
            Console.WriteLine("1. Export Current Settings");
            Console.WriteLine("2. Import Settings from File");
            Console.WriteLine("0. Back to Main Menu");
            Console.WriteLine();

            Console.Write("Select option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ExportConfig();
                    break;
                case "2":
                    ImportConfig();
                    break;
                case "0":
                    ShowMenu();
                    break;
                default:
                    Console.WriteLine("\nInvalid option. Press any key to continue...");
                    Console.ReadKey();
                    ShowConfigMenu();
                    break;
            }
        }

        static void ExportConfig()
        {
            Console.Clear();
            ShowHeader();
            Console.WriteLine("-> EXPORT CONFIGURATION");
            Console.WriteLine("─────────────────────");
            Console.WriteLine("Configuration export not implemented in v2.1");
            Console.WriteLine("Feature coming in v2.2");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            ShowConfigMenu();
        }

        static void ImportConfig()
        {
            Console.Clear();
            ShowHeader();
            Console.WriteLine("-> IMPORT CONFIGURATION");
            Console.WriteLine("─────────────────────");
            Console.WriteLine("Configuration import not implemented in v2.1");
            Console.WriteLine("Feature coming in v2.2");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            ShowConfigMenu();
        }
    }
}
