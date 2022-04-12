namespace Csproject.Entities
{
    public class YouFail
    {
        public YouFail()
        {
            string[] vect = new string[] {"Y","O","U"," ", "F","A","I","L","!"};
            foreach(string obj in vect)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(100);
                Console.Write(obj);
            }         
            
        }        
    }
}