using System.Diagnostics;

class Functions{
    public static void add (){
        Console.Clear();
        var p = new People();

        ConsoleColor original = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine(@"
        WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWMWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW
        WWWWWWWNKOkddxdddxdddxdddxddxxddxxddxdddxxdddxddxxddxxxkKNWWWWWWWWWWWWWWWWWWWWWW
        WWWWKd:'.                                               .'ckNWWWWWWWWWWWWWWWWWWW
        WWXl.                                                       :KWWWWWWWWWWWWWWWWWW
        WK;      ..',,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,.      ;XWWWWWWWWWWWWWWWWW
        Wd     .o0XNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNx.    .xWWWWWWWWWWWWWWWWW
        Wl     :NWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWK;     dWWWWWWWWWWWWWWWWW
        Wl     :NWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWK;     dWWWWWWWWWWWWWWWWW
        Wl     :NMWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWX;     dWWWWWWWWWWWWWWWWW
        Wl     :NWWWWWWXOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOkOXWWWWWWX;     dWWWWWWWWWWWWWWWWW
        Wl     :NMWWWWO,                                ;KWWWWWX;     dWWN0o:,;:d0WWWWWW
        Wl     :NWWWWWKc'..'...'..........'........'...'lXWWWWWX;     dXd;.      .:0WWWW
        Wl     :NMWWWWWWNNNXNNXXNNXXNNXXNNXNNNXNNNNXNNXNWWWWWWWX;     ..    'oo,   .dNWW
        Wl     :NWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWMX;           ,OWXd.  .oNW
        Wl     :NMWWWWXxcccccccccccccccccccccccccccccccckNWWWWNk.     .co'   .dNWx.  .xW
        Wl     :NWWWWWk.                                '0MN0o,    .:xXWWKc    :KX;   lN
        Wl     :NMWWWWNkooolooolooooooooooloooloooolooook0d;.   .;dKWWWWWWNd.   .,.  .xW
        Wl     :NWWWWWWWWWWMWWWMWWWWWWWWWWMWWWMWWWWWWWKx;.   .;d0WWWWWWWWWWWk.     .;kNW
        Wl     :NMWWWWWWWMWWWMWWWMWWMMWWMMWWMWWWMMWKx:.   .,o0NWWWWWWWWWWN0o,    .l0NWWW
        Wl     :NWWWWWXkllllllllllllllllllllllllll:.    'lONWWWWWWWWWWW0d;.   .;dKWWWWWW
        Wl     :NMWWWWk.                               'OWWWWWWWWWWWKd;.   .;d0WWWWWWWWW
        Wl     :NWWWWWXklcclccclccclcclccccccc,         'kWWWWWWWXx:.   .,o0NWWWWWWWWWWW
        Wl     :NMWWWWWWWWWWWWWWWWWWWWWWWWWWWk'    :kl.  .lXMWXkc.    .lONWWWWWWWWWWWWWW
        Wl     :NWWWWWWWWWWMWWWMWWWMWWMWWWMNd.   .lXWNx.   ;dl'       dWWWWWWWWWWWWWWWWW
        Wl     :NMWWWWNOooooooooooooooooooo:.  .;dNWNKOl.             dWWWWWWWWWWWWWWWWW
        Wl     :NWWWWWk.                       ,lc:;'.       .:o'     dWWWWWWWWWWWWWWWWW
        Wl     :NWWWWWXxc:::::::::::::::.             ..,:loxKWX;     dWWWWWWWWWWWWWWWWW
        Wl     :NWWWWWWWWWWWWWWWWWWWWWWWo    ..,::ldxOKXWWWWWWWK;     dWWWWWWWWWWWWWWWWW
        Wl     :NWWWWWWWWWWWWWWWWWWWWWWWXkxkOKNWWWWWWWWWWWWWWWWK;     dWWWWWWWWWWWWWWWWW
        Wl     :NWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWX;     dWWWWWWWWWWWWWWWWW
        Wl     :NWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWK;     dWWWWWWWWWWWWWWWWW
        Wl     :NMWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWX;     dWWWWWWWWWWWWWWWWW
        Wl     :NWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWX;     dWWWWWWWWWWWWWWWWW
        Wl     :NMWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWX;     dWWWWWWWWWWWWWWWWW
        Wl     :NWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWK,     dWWWWWWWWWWWWWWWWW
        Wx.    .dNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWk.    .kMWWWWWWWWWWWWWWWW
        WXc      ,lxkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkxl.     :XWWWWWWWWWWWWWWWWW
        WWXo.                                                       ;0WWWWWWWWWWWWWWWWWW
        WWWW0l.                                                   'dXWWWWWWWWWWWWWWWWWWW
        WWWWWWXko:,''''''''''''''''''''''''''''''''''''''''''',:lkXWWWWWWWWWWWWWWWWWWWWW
        WWWWWWWWWWWNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNWWWWWWWWWWWWWWWWWWWWWWWWWW
        WWMWWWMWWWWWWMWWWMWWWMWWWMWWWWWWWWWWMWWWMMWWWMWWWWWWWWWWMWWWMWWWMWWWMWWMWWWMWWWM
        ");

        ConsoleColor originall = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("Agregar desaparecidos.");
        p.ID = Utils.Input("Ingrese la cedula: ");
        p.Name = Utils.Input("Ingrese el nombre: ");
        p.SurName = Utils.Input("Ingrese el apellido: ");
        p.DateofBirth = Utils.Input("Ingrese fecha de nacimiento: ");
        p.Outfit = Utils.Input("Ingrese Vestimenta al momento de desaparecer: ");
        p.Reporting_person = Utils.Input("Ingrese nombre de la persona que reporta: ");
        p.Last_seen = Utils.Input("Ingrese lugar donde se vio por ultima vez: ");
        p.Numbertelephonic = Utils.Input("Ingrese telefono de contacto: ");
        p.Lat = Utils.Input("Ingrese latitud donde reside: ");
        p.Lng = Utils.Input("Ingrese logitud donde reside: ");
        p.Ocupation = Utils.Input("Ingrese la ocupacion de la persona desaparecida: ");
        p.Descriptions = Utils.Input("Ingrese descripcion (que paso la ultima vez que la vieron?): ");
        p.Found = Utils.Input("ingrese si fue encontrada si o no?");
        Persistence.Add(p);
    }

    public static void Look(){
        Console.Clear();
        foreach(var p in Persistence.Datas){
            Console.WriteLine($@"
            Cedula: {p.ID}
            Nombre: {p.Name}
            Apellido: {p.SurName}
            Fecha de Nacimiento: {p.DateofBirth}
            Vestimenta que llevaba puesta: {p.Outfit}
            Persona que reporto: {p.Reporting_person}
            Lugar donde se vio por ultima vez: {p.Last_seen}
            Telefono de contacto: {p.Numbertelephonic}
            Direccion: {p.Address}
            Latitud: {p.Lat}
            Longitud: {p.Lng}
            Ocupacion: {p.Ocupation}
            Descripcion: {p.Descriptions}
            Encontrado: {p.Found}            
            ");
            
        }
        Console.WriteLine("Presione ENTER para continuar.");
        Console.ReadLine();
    }


    public static void change(){
        Console.Clear();

        Console.WriteLine("Modificar desaparecidos, digite el numero que desea modificar.");
        int i = 1;

        foreach(var p in Persistence.Datas){
        Console.WriteLine($@"{i} \v {p.Name} \v {p.SurName}");
        i++;
        }

        var options = Utils.Inputint("Ingrese una opcion: ");
        options = options -1;

        if( options < Persistence.Datas.Count){
            var p = Persistence.Datas[options];

            bool next = true;

            while(next){

                Console.WriteLine("Modificar desaparecido, selecciona el campo a modificar.");

                Console.WriteLine($@"
                    1- cedula: {p.ID}
                    2- Nombre: {p.Name}
                    3- Apellido: {p.SurName}
                    4- fecha de nacimiento: {p.DateofBirth}
                    5- Vestimenta que llevaba puesta: {p.Outfit}
                    6- Nombre de la persona que reporta: {p.Reporting_person}
                    7- Lugar donde se vio por ultima vez: {p.Last_seen}
                    8- Numero telefonico: {p.Numbertelephonic}
                    9- Direccion: {p.Address}
                    10- Latitud: {p.Lat}
                    11- Longitud: {p.Lng}
                    12- Ocupacion: {p.Ocupation}
                    13= Descripcion: {p.Descriptions}
                    14- Encontrado: {p.Found}
                    R- Regresar
                ");

                var opcion2 = Utils.Input("Ingresa una opcion: ");
                
                switch(opcion2.ToLower()){
                    
                    case "1":
                        p.ID = Utils.Input("Ingrese la cedula: ");
                    break;

                    case "2":
                        p.Name = Utils.Input("Ingrese el nombre: ");
                    break;

                    case "3":
                        p.SurName = Utils.Input("Ingrese apellido: ");
                    break;

                    case "4":
                        p.DateofBirth = Utils.Input("Ingrese telefono: ");
                    break;

                    case "5":
                        p.Outfit = Utils.Input("Ingrese la vestimenta que lelvaba puesta: ");
                    break;

                    case "6":
                        p.Reporting_person = Utils.Input("Ingrese el nombre de la persona que reporto el caso: ");
                    break;

                    case "7":
                        p.Last_seen = Utils.Input("Ingrese el lugar donde fue vista por ultima vez: ");
                    break;

                    case "8":
                        p.Numbertelephonic = Utils.Input("Ingrese el numero de telefono:");
                    break;

                    case "9":
                        p.Address = Utils.Input("Ingrese la direccion: ");
                    break;

                    case "10":
                        p.Lat = Utils.Input("Ingrese la latitud:");
                    break;

                    case "11":
                        p.Lng = Utils.Input("Ingrese la longitud: ");
                    break;

                    case "12":
                        p.Ocupation = Utils.Input("Ingrese la ocupacion: ");
                    break;

                    case "13":
                        p.Descriptions = Utils.Input("Ingrese la descripcion: ");
                    break;

                    case "14":
                        p.Found = Utils.Input("Ingrese si feu encontrada  si o no: ");
                    break;

                    case "r":
                        next = false;
                    break;

                    default:
                        Utils.Error("opcion invalido, presione ENTER para continuar.");
                        Console.ReadLine();
                    break;
                
                }

            }
            Persistence.Datas[options] = p;
            Persistence.Save();

            Console.WriteLine("Registro modificado, presiona ENTER para continuar.");
            Console.ReadLine();
        }else{
            Utils.Error("opcion invalida, presione ENTER para continuar.");
            Console.ReadLine();
        }
    }

    public static void Map(){

        Console.Clear();
        Console.WriteLine("Mapa de desaparecidos.");

        var codes = "";

        foreach(var p in Persistence.Datas){
            var messages = $@"
            Cedula: {p.ID} <br>
            Nombre: {p.Name} <br>
            Apellido: {p.SurName}
            Fecha de Nacimiento: {p.DateofBirth} <br>
            Vestimenta que llevaba puesta: {p.Outfit} <br>
            Persona que reporto: {p.Reporting_person} <br>
            Lugar donde se vio por ultima vez: {p.Last_seen} <br>
            Telefono de contacto: {p.Numbertelephonic}
            Direccion: {p.Address} <br>
            Latitud: {p.Lat} <br>
            Longitud: {p.Lng} <br>
            Ocupacion: {p.Ocupation} <br>
            Descripcion: {p.Descriptions} <br>
            Encontrado: {p.Found} <br>
            ";

            codes += $@"
            
            marker = L.marker([{p.Lat}, {p.Lng}]).addTo(map).bindPopup(`{messages}`);
            
            ";
        }


        var templates = File.ReadAllText("templates.html");
        templates = templates.Replace("//Cypher", codes);

        File.WriteAllText("Map_End.html", templates);

        var url = "Map_End.html";
        var psi = new ProcessStartInfo();
        psi.UseShellExecute = true;
        psi.FileName=url;
        
        Process.Start(psi);
        Console.WriteLine("Proceso finalizado");

        Console.WriteLine("Presiona ENTER para continuar.");
        Console.ReadLine();
    }

    public static void Export(){
        Console.Clear();

        Console.WriteLine("Modificar desaparecidos, digite el numero que desea modificar.");
        int i = 1;

        foreach(var p in Persistence.Datas){
        Console.WriteLine($@"{i} \v {p.Name} \v {p.SurName}");
        i++;
        }

        var options = Utils.Inputint("Ingrese una opcion: ");
        options = options -1;

        if( options < Persistence.Datas.Count){
            var p = Persistence.Datas[options];

            
            
            var html = $@"
                <html>
                    <head>
                        <title>Reporte de desaparecidos</title>
                    </head>
                    <body>
                        <img src = 'https://api.adamix.net/apec/foto2/{p.ID}'/>
                        <h1>Reportes de desaparecidos</h1>
                    <p>cedula: {p.ID}</p>
                    <p>Nombre: {p.Name}</p>
                    <p>Apellido: {p.SurName}</p>
                    <p>fecha de nacimiento: {p.DateofBirth}</p>
                    <p>Vestimenta que llevaba puesta: {p.Outfit}</p>
                    <p>Nombre de la persona que reporta: {p.Reporting_person}</p>
                    <p>Lugar donde se vio por ultima vez: {p.Last_seen}</p>
                    <p>Numero telefonico: {p.Numbertelephonic}</p>
                   <p>Direccion: {p.Address}</p> 
                    <p>Latitud: {p.Lat}</p> 
                    <p>Longitud: {p.Lng}</p> 
                    <p>Ocupacion: {p.Ocupation}</p> 
                    <p>Descripcion: {p.Descriptions}</p>
                    <p>Encontrado: {p.Found}</p> 
                    </body>  
                </html>
            ";
                File.WriteAllText("Export.html", html);

                var url =  "Export.html";
                var psi = new ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = url;
                Process.Start(psi);
                
                Console.WriteLine("Presione ENTER para continuar.");
                Console.ReadLine();


        }else{
            Utils.Error("Opcion invalida, presiona ENTER para continuar.");
            Console.ReadLine();
        }
    }
}