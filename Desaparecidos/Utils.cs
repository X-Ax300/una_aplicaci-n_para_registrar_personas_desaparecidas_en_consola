class Utils{
    public static void Error(string msg){
        Console.WriteLine(msg);
        var original = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(msg);
        Console.ForegroundColor = original;
    }

    public static string Input(string msg){
        string valor = null;
        Console.Write(msg);

        while(string.IsNullOrEmpty(valor)){
        valor = Console.ReadLine();
        }
        
        return valor;
    }

    public static string inputchange(string msg, string valor){
        Console.WriteLine(msg);

        string opt = "";
        while(opt != "s" && opt!="n"){
            Console.WriteLine("Desea modificar este campo? (s/n)");
            opt = Console.ReadLine();
        }
        

        return valor;

    }

    public static int Inputint(string msg){
        int valor  = 0;
        while(valor < 1){
            Console.Write(msg);
            int.TryParse(Console.ReadLine(), out valor);
        }
        return valor;
    }

        public static void Reproducir(string audio){
        audio = $"audio/{audio}";
        System.Diagnostics.Process.Start(@"powershell", $@"-c (New-Object Media.SoundPlayer '{audio}').PlaySync();");
    }
}