
namespace Symbol
{
    public class Symbol{
        public string path = @"symbols/symbols.txt";
        public List<string> arrayUndoubledTextSymbols;
        public Symbol(){
            readFileAsync();            
        }

        public async Task readFileAsync(){
            using (StreamReader reader = new StreamReader(this.path)){
                string textSymbols = await reader.ReadToEndAsync();
                char[] arrayTextSymbols = textSymbols.ToCharArray();
                this.arrayUndoubledTextSymbols = new List<string>();
                foreach(var symbol in arrayTextSymbols){
                    if(!arrayUndoubledTextSymbols.Contains(Convert.ToString(symbol))){
                        arrayUndoubledTextSymbols.Add(Convert.ToString(symbol));
                    }
                }
            }
        }
    }
}