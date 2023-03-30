public class CompanyInfo{

    public string BotName {get; set;}
    public Company CompanyObj {get; set;}

    public CompanyInfo(String name, Company obj){
        this.CompanyObj = obj;
        this.BotName = name;
    }

    public Cofounder GetCofounderByName(string name){

        Cofounder? founder = null;

        foreach(Cofounder person in this.CompanyObj.Cofounders){
            if(person.Name == name){
                founder = person;
            }
        }

        return founder;
    }

    public int GetNumberOfEmployees(){
        return this.CompanyObj.Employees.Length;
    }


}