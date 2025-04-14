using System.Runtime.Intrinsics.X86;

class FileManager
{
    private string _currentDirectory;
    private string[] _pages;
    public FileManager()
    {
        string pathToConfig = $"{Directory.GetCurrentDirectory()}\\config.txt"; // путь до конфигурационного файла
        if (File.Exists(pathToConfig))
        {
            string[] config = File.ReadAllLines(pathToConfig);
            _currentDirectory = config[0];
        }
        else
        {
            _currentDirectory = Directory.GetCurrentDirectory();
        }
    }

    public void printDirectory()
    {
        System.Console.WriteLine($"Текущая директория: {_currentDirectory}");
        string[] dirFiles = Directory.GetFiles(_currentDirectory);
        string[] dirDirectories = Directory.GetDirectories(_currentDirectory);
        int i = 1;
        foreach(string dir in dirDirectories)
        {
            System.Console.WriteLine($"{i}. {dir}");
            i++;
        }
        foreach(string file in dirFiles)
        {
            System.Console.WriteLine($"{i}. {file}");
            i++;
        }
    }
    
    public void changeDirectory(string newDirectory)
    {
        // if (newDirectory == "..")
        // {

        // }
        if (Directory.Exists(newDirectory) && newDirectory != ".")
        {
            _currentDirectory = newDirectory;
        }
    }

    public void saveLastDirectory()
    {
        string path = $"{Directory.GetCurrentDirectory()}\\config.txt";
        File.WriteAllText(path, _currentDirectory);
    }

    public void copy(string source, string destination)
    {
        if (Directory.Exists(source))
        {
            
            string[] dirFiles = Directory.GetFiles(source);
            foreach(string file in dirFiles)
            {
                FileInfo fileinfo = new FileInfo(file);
                File.Copy(file, $"{destination}\\{fileinfo.Name}", true);
            }
            string[] dirDirectories = Directory.GetDirectories(source);
            foreach(string directory in dirDirectories)
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(directory);
                string nextDestination = $"{source}\\{directoryInfo.Name}";
                System.Console.WriteLine(nextDestination);
                Directory.CreateDirectory(nextDestination);
                copy(directory, nextDestination);
            }
        }
        else if (File.Exists(source))
        {
            File.Copy(source, destination, true);
            System.Console.WriteLine("Скопирован файл");
        }
    }

    public void deletion(string source)
    {
        if (Directory.Exists(source))
        {
            Directory.Delete(source, true);
        }
        else if (File.Exists(source))
        {
            File.Delete(source);
        }
    }

    public void fullInfo()
    {
        // System.Console.WriteLine($"Текущая директория: {_currentDirectory}");
        string[] dirFiles = Directory.GetFiles(_currentDirectory);
        string[] dirDirectories = Directory.GetDirectories(_currentDirectory);
        int i = 1;
        foreach(string dir in dirDirectories)
        {
            DirectoryInfo dirinfo = new DirectoryInfo(dir);
            System.Console.WriteLine($"{i}. {dirinfo.FullName}\t\t\t Время создания: {dirinfo.CreationTime}\t Атрибуты: {dirinfo.UnixFileMode}");
            i++;
        }
        foreach(string file in dirFiles)
        {
            FileInfo fileInfo = new FileInfo(file);
            System.Console.WriteLine($"{i}. {fileInfo.FullName}\t\t Размер: {fileInfo.Length} B\t Время создания: {fileInfo.CreationTime}\t Атрибуты: {fileInfo.UnixFileMode}");
            i++;
        }
    }
}


class Program
{
    static void Main()
    {
        FileManager fm = new FileManager();
        string input = "";
        while (true)
        {
            string[] temp = input.Split(' ');
            if (temp[0] == "cd")
            {
                fm.changeDirectory(temp[1]);
            }
            else if (temp[0] == "cp")
            {
                fm.copy(temp[1], temp[2]);
            }
            else if (temp[0] == "rm")
            {
                fm.deletion(temp[1]);
            }
            else if (temp[0] == "l")
            {
                fm.fullInfo();
            }
            else if (temp[0] == "q")
            {
                break;
            }
            if (temp[0] != "l")
            {
                fm.printDirectory();
            }
            input = System.Console.ReadLine();
        }

        fm.saveLastDirectory();


        // int _Page = 1;

        // string[] data = getAllFilesnDirs;


        // for(int i = 0; i < 10; i++)
        // {
        //     if (_Page == 0)
        //     {
        //         System.Console.WriteLine(data[i]);
        //     }
        //     else
        //     {
        //         System.Console.WriteLine(data[_Page ^ 10 + i]);
        //     }
        // }

    }
}
        