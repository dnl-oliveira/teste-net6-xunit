namespace ConversaoKmParaMilhas;

    public class ConversorDistancias
    {
        public static double MilhasParaKm(double milhas) =>
            milhas / 1.609; 

        public static double KmParaMilhas(double km) =>
            km * 1.609; 
    }
