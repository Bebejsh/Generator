using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class FIO
    {
        public  string[] nameM = { "Иван", "Алексей", "Максим", "Дмитрий", "Андрей", "Сергей", "Николай", "Владимир", "Павел", "Артём", "Михаил", "Юрий", "Олег", "Роман", "Евгений", "Виктор", "Игорь", "Антон", "Григорий", "Станислав" };
        public  string[] nameF = { "Анна", "Мария", "Екатерина", "Ольга", "Светлана", "Александра", "Татьяна", "Наталья", "Елена", "Ирина", "Ангелина", "Виктория", "Елизавета", "Надежда", "София", "Алена", "Марина", "Валерия", "Ксения", "Вера" };
        public  string[] surnameM = { "Иванов", "Петров", "Сидоров", "Смирнов", "Кузнецов", "Васильев", "Попов", "Соколов", "Лебедев", "Козлов", "Новиков", "Морозов", "Павлов", "Волков", "Соловьев", "Васильченко", "Захаров", "Андреев", "Орлов", "Макаров" };
        public  string[] surnameF = { "Иванова", "Петрова", "Сидорова", "Смирнова", "Кузнецова", "Васильева", "Попова", "Соколова", "Лебедева", "Козлова", "Новикова", "Морозова", "Павлова", "Волкова", "Соловьева", "Васильченко", "Захарова", "Андреева", "Орлова", "Макарова" };
        public  string[] OtchestvoM = { "Иванович", "Алексеевич", "Максимович", "Дмитриевич", "Андреевич", "Сергеевич", "Николаевич", "Владимирович", "Павлович", "Артёмович", "Михайлович", "Юрьевич", "Олегович", "Романович", "Евгеньевич", "Викторович", "Игоревич", "Антонович", "Григорьевич", "Станиславович" };
        public  string[] OtchestvoF = { "Ивановна", "Алексеевна", "Максимовна", "Дмитриевна", "Андреевна", "Сергеевна", "Николаевна", "Владимировна", "Павловна", "Артёмовна", "Михайловна", "Юрьевна", "Олеговна", "Романовна", "Евгеньевна", "Викторовна", "Игоревна", "Антоновна", "Григорьевна", "Станиславовна" };


        private Random random = new Random();
        public string GenMName()
        {
            int index = random.Next(nameM.Length);
                return nameM[index];
        }
        public string GenFName()
        {
            int index = random.Next(nameF.Length);
            return nameF[index];
        }
        public string GenMSur()
        {
            int index = random.Next(surnameM.Length);
            return surnameM[index];
        }
        public string GenFSur()
        {
            int index = random.Next(surnameF.Length);
            return surnameF[index];
        }
        public string GenMOtch()
        {
            int index = random.Next(OtchestvoM.Length);
            return OtchestvoM[index];
        }

        public string GenFOtch()
        {
            int index = random.Next(OtchestvoF.Length);
            return OtchestvoF[index];
        }



    






    }
}
