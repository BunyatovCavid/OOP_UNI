namespace OOP_UNI
{
    internal class Program
    {
        //field (deyisen) - istenilen seviyyede teyin oluna bilir.
        //Ekseriyyeten sadece teyin edildiyi klassda istifade olunacaq deyerleri isareleekucun istifade olunur
        int number;

        //property (deyisen) - sadece klasslar seviyyesinde istifade oluna bilir, Encaptulation ucun bire-birdir.
        public int numer0 { get; set; }

        static void Main(string[] args)
        {
            int num;

            Test test = new Test(5);
            while(true)
            {
                Test tester = new Test();
                Console.ReadLine();
            }

            //OOP

            //Encapsulation (Kapsullamaq / data gizletmek)
            ////https://medium.com/pragmatech/c-da-kapsullamaq-encapsulation-6848ee0115ef

            //Abstraction(mucerredlisdirme)
            ////https://medium.com/pragmatech/c-da-m%C3%BCc%C9%99rr%C9%99dl%C9%99%C5%9Fdirm%C9%99-abstraction-3dfc0a4d89eb

            //Inheritance (toreme / miras almaq)
            ////https://minafrzli.medium.com/c-oopnin-3-%C9%99sas-prinsipi-c3c396a7eb13


            //Polymorphism (polimorfizm / cox formaliliq) 
            ///https://minafrzli.medium.com/c-oopnin-3-%C9%99sas-prinsipi-c3c396a7eb13

        }

        //Metod - Kodumuzda yerine isdeyimiz kodlari yazmaq ucun istifade edilir.

        //Signature - imza
        //Access OutPut_Tip Ad (Inputs)
        public bool GetBool(int num1, int num2)
        {
            int sum = num1 + num2;


            //return - geri donustipi void olmayan metodlarda value'nu metoddan geri qaytarmaq (output) ucun istifade olunur. eyni scope daxilinde
            //return'dan sonra yazilan kodlar hec bir zaman ise dusmez. 
            return sum > 50 ? true : false;
        }

        //Access modifie qeyd olunmayanda default acces olarak private qebul olunur.
        int year;
        int Name { get; set; }
        void Get()
        {

        }

    }

    internal class Test
    {
        //Constructure - klassin obyekti yaradilarken ise dusen metoddur. 
        //Constructure'in geri donus tipi olmur ve metodun adi klassin adi ile eyni olmalidir.

        //biz yazmasaq bele her bir klassin hec bir input deyer qebul etmeyen ve bizlere gorunmeyen bir constructure olur.
        public Test()
        {
            Console.WriteLine("Test klassinin obyekti yaradildi");
        }

        //Constructure'dan klassin obyeti yaradilarken daxil edilmesi lazim olan inputlari teyin etmek ucun istifade edirik.
        //Eyni zamanda kodunuzun mentiqine uygun metodlari ve ya prosesleride Constructure'da istifade ede bilersiz.

        int num;
        public Test(int num)
        {
            //bu halda this keywordu num deyiseninin hal-hazirda daxil oldugu klassin field'i oludugunu teyin etmek ucun istifade olunub.
            this.num = num;
            Console.WriteLine("Number : " + num);
        }

        //Static Constructure'in access modifie'sin teyin ede bilmirik.
        //Static Constructure eyni runtime'da klass obyekti yaradilarken sadece ve sadece bir defe ise dusur,
        //diger Constructure'lar (konstruksiya) ise her defe ie dusmelidir.
        //Static Constructure input deyerler teyin etek qeyri-mumkundur.
        static Test()
        {
            Console.WriteLine("Ilk ve son defe.");
        }


    }


}