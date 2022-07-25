namespace LibrairieConversionNote
{
    public class ConversionAlphabetiquetoNote
    {
        public string transform()
        {
            string note = "";

            switch(note)

            {
                case "A": 
                    return "LA";
                        break;

                case "B":
                    return "SI";
                    break;

                case "C":
                    return "DO";
                    break;

                case "D":
                    return "RE";
                    break;

                case "E":
                    return "MI";
                    break;


                case "G":
                    return "FA";
                    break;


                case "H":
                    return "SOL";
                    break;





                default: 
                    return "error";
                    break;
            }
            
        
        }

    }
}