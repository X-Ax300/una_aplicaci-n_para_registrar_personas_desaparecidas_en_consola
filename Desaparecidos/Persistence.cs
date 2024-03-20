using Newtonsoft.Json;

class Persistence{

    public static List<People> Datas = new List<People>();

        public static void Add(People p){
            Datas.Add(p);

            Persistence.Save();
        }
        
        public static void loadInicial(){
            if(File.Exists("Datas.Json")){
                var json = File.ReadAllText("Datas.Json");
                try{
                Datas = JsonConvert.DeserializeObject<List<People>>(json);
                    Console.WriteLine("Datos cargados correctamente, presiona ENTER para continuar.");
                    Console.ReadLine();
                }catch(Exception ax){
                    Utils.Error("Error al cargar los datos.");
                }
            }else{
                Utils.Error("No hay datos que cargar.");
            }
            Console.WriteLine("Presiona ENTER para continuar");
            Console.ReadLine();

        }

        public static void Save(){
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(Datas);
            File.WriteAllText("Datas.json", json);
        }
}

class People{

    public string ID { get; set;}
    public string Name {get; set;}
    public string SurName {get; set;}
    public string DateofBirth{get; set;}
    public string Outfit {get; set;}
    public string Reporting_person {get; set;}
    public string Last_seen {get; set;} 
    public string Numbertelephonic {get; set;}
    public string Address {get; set;}
    public string Lat {get; set;}
    public string Lng {get; set;}
    public string Ocupation {get; set;}
    public string Descriptions {get; set;}
    public string Found {get; set;}

}