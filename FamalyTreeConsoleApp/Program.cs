﻿namespace FamalyTreeConsoleApp;

internal class Program
    {
    static void Main(string[] args)
        {
        FamalyMamber GrandFather1 = new FamalyMamber()
            {
            Name = "Николай Иванов",
            Age = 65,
            Gender = Gender.male
            };
        FamalyMamber GrandFather2 = new FamalyMamber()
            {
            Name = "Петр",
            Surname = "Петров",
            Age = 55,
            Gender = Gender.male

            };
        FamalyMamber GrandMother1 = new FamalyMamber()
            {
            Name = "Любовь",
            Surname = "Иванова",
            Age = 60,
            Gender = Gender.female
            };
        FamalyMamber GrandMother2 = new FamalyMamber()
            {
            Name = "Лариса",
            Surname = "Петрова",
            Age = 54,
            Gender = Gender.female
            };
        FamalyMamber Father = new FamalyMamber()
            {
            Name = "Сергей",
            Surname = "Иванов",
            Age = 35,
            Gender = Gender.male,
            Father = GrandFather1,
            Mother = GrandMother1
            };
        FamalyMamber Mother = new FamalyMamber()
            {
            Name = "Татьяна",
            Surname = "Иванова",
            Age = 30,
            Gender = Gender.female,
            Mother = GrandMother2,
            Father = GrandFather2
            };
        FamalyMamber Son = new FamalyMamber()
            {
            Name = "Антон",
            Surname = "Иванов",
            Age = 19,
            Gender = Gender.male,
            Father = Father,
            Mother = Mother
            };
        var grandMa = Son.GetGrandMothers();
        var grandPa = Son.GetGrandFathers();
        Console.WriteLine(grandMa[0]?.Name + " " + grandMa[0]?.Surname + " \n" + grandPa[0]?.Name + grandPa[0]?.Surname + " \n");
        Console.WriteLine(grandMa[1]?.Name + " " + grandMa[1]?.Surname + " \n" + grandPa[1]?.Name + " " + grandPa[1]?.Surname);

        List<FamalyMamber> famalyMambers = new List<FamalyMamber>();
        famalyMambers.Add(Mother);
        famalyMambers.Add(Father);
        famalyMambers.Add(Son);
        foreach (var item in famalyMambers)
            {
            if (item.Married)
                {

                }
            }

        }



    }

