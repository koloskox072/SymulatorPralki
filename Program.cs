namespace ConsoleApp2
{
    class pralka
    {
        private int nrProgramu = 0;
        private int wirowanie = 300;
        public pralka(int nrProgramu, int wirowanie)
        {
            this.nrProgramu = nrProgramu;
            this.wirowanie = wirowanie;
        }
        public void programUp()
        {
            nrProgramu = (++nrProgramu)%6;
            Console.WriteLine($"Wybrany program: {nrProgramu}");
        }
        public void programDown() 
        {
            if (--nrProgramu < 0) nrProgramu = 5;
            Console.WriteLine($"Wybrany program: {nrProgramu}");
        }
        public void wirowanieUp()
        {
            wirowanie = (wirowanie + 100)%1000;
            Console.WriteLine($"Predkosc wirowania: {wirowanie}obr/min");
        }
        public void wirowanieDown()
        {
            if (wirowanie - 100 < 0)
                wirowanie = 1000;
            else wirowanie = wirowanie - 100;
            Console.WriteLine($"Predkosc wirowania: {wirowanie}obr/min");
        }
        public void start()
        {
            Console.WriteLine($"poczatek prania, program: {nrProgramu} predkosc wirowania: {wirowanie}obr/min");
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Symulator Pralki");
            int x=0, y=300;
            pralka p = new pralka(x, y);
            p.programUp();
            p.programUp();
            p.programDown();
            p.programUp();
            p.programUp();
            p.programDown();
            p.programDown();
            p.programUp();
            p.wirowanieDown();
            p.wirowanieDown();
            p.wirowanieDown(); p.wirowanieDown();
            p.wirowanieDown(); p.wirowanieDown();
            p.wirowanieDown();
            p.wirowanieDown();
            p.wirowanieDown();
            p.wirowanieUp();
            p.wirowanieUp();
            p.wirowanieUp();
            p.wirowanieUp();
            p.wirowanieUp();
            p.wirowanieUp();
            p.wirowanieUp();
            p.wirowanieDown();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            p.start();
            Console.WriteLine();

        }
    }
}