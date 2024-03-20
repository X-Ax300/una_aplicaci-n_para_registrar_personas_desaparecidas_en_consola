bool next = true;
Console.Clear();
Persistence.loadInicial();

while (next){
    Console.Clear();
    Utils.Reproducir("audio.wav");
    ConsoleColor originall = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(@"
=============================== Sistema de resgistro de personas desaparecidas. ============================

        wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww
        MWWWMMWWWMWWWMMWWWMWWWMMWWWMWWWMWWWMMWWWMWWWMMWWWMMWWNOc. .oNWWMMWWMMWWWMWWWMMWWWMWWWMMWWWMWWWMMWWWM
        WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWKOxl,.    .xWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW
        WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWO:.          '0WX0kddk0NWWWWWWWWWWWWWWWWWWWWWWWWWWWWW
        WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWl             .,'.    ..',,,;lOWWWWWWWWWWWWWWWWWWWWWW
        WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW0l,..                         cNWWWWWWWWWWWWWWWWWWWWW
        MWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNo.                      .oXWWWWWWWWWWWWWWWWWWWWWW
        WWWWWWWMWWWWWWWWWWWWMWWWWWWWWMWWWWWWWWMWWWWWWWWMWOo,                     .oXWWWWWWWWWWWWMWWWWWWWWWWW
        MWWWWMWWWMWWWWWWWWMWWWWWWWWMWWWMWWWWWWWWMWWWWWWXo.                       .oKNMWWWMWWWWWWWWMWWWWWWWWM
        WWWWWWWMWWWMWWWWMWWWMWWWWWWWWMWWWWWWWWMWWWWWWWXc                           .;dXWWWWWWWWWMWWWMWWWWWWW
        MWWWWWWWWMWWWWWWWWMWWWWWWWWMWWWWWWWWWWWWMWWWWXc                               ;KMWWWWWWWWWMWWWWWWWWM
        WWWWWWWWWWWWWWWWWWWWMWWWWWWWWMWWWWWWWWMWWWWWNo                                '0WWWWWWWWWWWWWWWWWWWW
        WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWx.                              .:OWWWWWWWWWWWWWWWWWWWWW
        WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWO'                                .'dNWWWWWWWWWWWWWWWWWWW
        WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW0'                                   ,KWWWWWWWWWWWWWWWWWWW
        WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNx.                                   ;OWWWWWWWWWWWWWWWWWWWW
        WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWXx,                                     :0NWWWWWWWWWWWWWWWWWWW
        MWWWWMWWWMWWWWWWWWMWWWWWWWWMWWWMWWWN0l'                                        .OMWWWMWWWWMWWWWWWWWM
        WWWWWWWMWWWMWWWWWWWWMWWWWWWWWWWWN0d;.                                          :KWWWWWWWWWWWMWWWWWWW
        MWWWWWWWWMWWWWWWWWMWWWWWWWWMWKkl,.                                           'dXWMWWWWWWWWMWWWWWWWWM
        WWWWWWWMWWWMWWWWMWWWMWWWWXOo;.                                               ,0MWWWWWWWWMWWWMWWWWWWW
        WWWWWWWWWMWWWWWWWWMWWXOd:'                                                    ,0WWWWWWWWWWMWWWWWWWWW
        WWWWWWWWWWWWWWWWWXOo:.                                                         ,0WWWWWWWWWWWWWWWWWWW
        WWWWWWWWWWWWNKko;.                                               .;c'           '0WWWWWWWWWWWWWWWWWW
        WWWWWWWWX0dc,.                                          ..',;:ldOXWW0,           'OWWWWWWWWWWWWWWWWW
        WWWWNOo:.                                           .;okKXNWWWWWWWWWWK;           'OWWWWWWWWWWWWWWWW
        WWWWX;                                        .':oxOXWWWWWWWWWWWWWWWWWK:           'OWWWWWWWWWWWWWWW
        WWMWWo                                    .'cd0NWWWWWWWWWWWWWMWWWWWWWWWXc           'OWWWWWWWWWWWWWW
        WWWWWO.                               .,lx0NWWWWWMWWWWWWWWWMWWWMWWWWWWWWNo.          'OWWWMWWWWWWWWM
        WWWWWX:                           .;okKNWWWWWWWMWWWWMWWWWMWWWMWWWWWWWWMWWNd.          .kWWWWMWWWWWWW
        MWWWWWd.                     .':dOXWMWWWMWWWWWWWWMMWWWWWWWWMWWWWWWWWMWWWWWNk.          .kWMWWWWWWWWM
        WWMWWW0'                 .,cx0NWWWWWWWMWWWWWWWWMWWWWMWWWWWWWWMWWWWWWWWMWWWWW0;          .kWWWWWWWWWW
        WWWWWMNc             .;lx0NMWWWWWWWWMWWWWWWWWWWWWMMWWWWWWWWMWWWWWWWWWWWWWWWWMNd'         .kWWWWWWWWW
        WWWWWWWx.        .;okKNWWWWWWMWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWXd,        .kWWWWWWWW
        WWWWWWWK,   .':dOXWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNkc.      .xWWWWWWW
        WWWWWWWWd,cx0NWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWXkl,.   .xWWWWWW
        WWWWWWWWWNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWN0xl,.'xWWWWW
        MWWWMMWWWMWWWMMWWWMWWWMMWWMMWWWMWWWMMWWWMWWWMMWWWMMWWWMMWWWMWWWMMWWMMWWWMMWWMMWWWMWNWMMWNWMN0dxNWWWM

=============================== Sistema de resgistro de personas desaparecidas. ============================

");



ConsoleColor original = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.Green;


    Console.WriteLine(@"
        1 - Registrar desaparecidos.
        2 - Ver desaparecidos.
        3 - Modificar desaparecidos.
        4 - Viusalizar mapa de desaparecidos.
        5 - Exportar desaparecidos.
        x - Salir.

");


    Console.WriteLine("Ingrese una opcion.");
    var options = Console.ReadLine();

    switch(options.ToLower()){

        case "1":
            Functions.add();
        break;

        case "2":
            Functions.Look();
        break;

        case "3":
            Functions.change();
            
        break;

        case "4":
            Functions.Map();
        break;

        case "5":
            Functions.Export();
        break;

        case "x":
            next = false;
            Console.WriteLine("Thanks for use the program.");
        break;

        default:
        Utils.Error("Opcion invalida, presione ENTER para continuar.");
            Console.ReadLine();
        break;
    }


}


