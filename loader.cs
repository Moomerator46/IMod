using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

class Program
{
    static Dictionary<string, IModPlugin> modMap = new Dictionary<string, IModPlugin>();

    static void Main()
    {
        string modFolder = "cfil";
        if (!Directory.Exists(modFolder))
        {
            Console.WriteLine("Creating mod folder: cfil");
            Directory.CreateDirectory(modFolder);
        }

        Console.WriteLine("Scanning for mods...");
        foreach (var file in Directory.GetFiles(modFolder, "*.dll"))
        {
            try
            {
                var asm = Assembly.LoadFrom(file);
                foreach (var type in asm.GetTypes())
                {
                    if (typeof(IModPlugin).IsAssignableFrom(type) && !type.IsInterface && !type.IsAbstract)
                    {
                        var plugin = (IModPlugin)Activator.CreateInstance(type);
                        string code = GenerateCode();
                        modMap[code] = plugin;
                        Console.WriteLine($"Detected mod: {Path.GetFileName(file)} -> Code: {code}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to load {file}: {ex.Message}");
            }
        }

        while (true)
        {
            Console.WriteLine("\nEnter a code to run a mod (or type 'exit' to quit):");
            string input = Console.ReadLine()?.Trim();

            if (input?.ToLower() == "exit")
                break;

            if (modMap.TryGetValue(input, out var selectedMod))
            {
                Console.WriteLine("Running mod...");
                selectedMod.Run();
            }
            else
            {
                Console.WriteLine("Invalid code.");
            }
        }
    }

    static string GenerateCode()
    {
        var rand = new Random();
        return rand.Next(1000, 9999).ToString();
    }
}
