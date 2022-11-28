// See https://aka.ms/new-console-template for more information
//Data Type
using AVG5STUDENT;

Student student1 = new Student();
student1.name = "Jaruvit Sangkawesirikul";
student1.weight = 85.5f;

Student student2 = new Student();
student2.name = "Witchapon Yuenyong";
student2.weight = 70.0f;

Student student3 = new Student();
student3.name = "Natdanai Pakpoom";
student3.weight = 60.5f;

Student student4 = new Student();
student4.name = "Juntima Promwang";
student4.weight = 46.5f;

Student student5 = new Student();
student5.name = "Poommipat Wongpan";
student5.weight = 75.5f;

float avgWeight = (student1.weight + student2.weight + student3.weight + student4.weight + student5.weight) / 5;
Console.WriteLine("Weight avg of student: " + avgWeight);
Console.WriteLine(student1.name + student1.weight);
Console.WriteLine(student4.name + student4.weight);
Console.WriteLine(student1.name + " 653450086-7");