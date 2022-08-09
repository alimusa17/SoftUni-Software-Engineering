using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> courseSchedule = Console.ReadLine().Split(", ").ToList();

            string command;
            while ((command = Console.ReadLine()) != "course start")
            {
                string[] cmdArgs = command.Split(":");
                switch (cmdArgs[0])
                {
                    case "Add":
                        string lessonToAdd = cmdArgs[1];
                        if (!courseSchedule.Contains(lessonToAdd))
                        {
                            courseSchedule.Add(lessonToAdd);
                        }
                        break;

                    case "Insert":
                        string lessonToInsert = cmdArgs[1];
                        int indexToInsertAt = int.Parse(cmdArgs[2]);
                        if (!courseSchedule.Contains(lessonToInsert))
                        {
                            courseSchedule.Insert(indexToInsertAt, lessonToInsert);
                        }
                        break;

                    case "Remove":
                        string lessonToRemove = cmdArgs[1];
                        string exerciseToRemove = lessonToRemove + "-Exercise";
                        if (courseSchedule.Contains(lessonToRemove))
                        {
                            courseSchedule.Remove(lessonToRemove);
                            if (courseSchedule.Contains(exerciseToRemove))
                            {
                                courseSchedule.Remove(exerciseToRemove);
                            }
                        }
                        break;

                    case "Swap":
                        string lessonToSwap1 = cmdArgs[1];
                        string lessonToSwap2 = cmdArgs[2];
                        if (courseSchedule.Contains(lessonToSwap1) && courseSchedule.Contains(lessonToSwap2))
                        {
                            int index1 = courseSchedule.IndexOf(lessonToSwap1);
                            int index2 = courseSchedule.IndexOf(lessonToSwap2);
                            courseSchedule[index1] = lessonToSwap2;
                            courseSchedule[index2] = lessonToSwap1;

                            string exerciseTitleToSwap1 = lessonToSwap1 + "-Exercise";
                            string exerciseTitleToSwap2 = lessonToSwap2 + "-Exercise";
                            if (courseSchedule.Contains(exerciseTitleToSwap1) && courseSchedule.Contains(exerciseTitleToSwap2))
                            {
                                int exerciseIndex1 = courseSchedule.IndexOf(exerciseTitleToSwap1);
                                int exerciseIndex2 = courseSchedule.IndexOf(exerciseTitleToSwap2);
                                courseSchedule[exerciseIndex1] = exerciseTitleToSwap2;
                                courseSchedule[exerciseIndex2] = exerciseTitleToSwap1;
                            }
                            else if (courseSchedule.Contains(exerciseTitleToSwap1))
                            {
                                int exerciseIndex = courseSchedule.IndexOf(exerciseTitleToSwap1);
                                courseSchedule.RemoveAt(exerciseIndex);
                                courseSchedule.Insert((index2 + 1), exerciseTitleToSwap1);
                            }
                            else if (courseSchedule.Contains(exerciseTitleToSwap2))
                            {
                                int exerciseIndex = courseSchedule.IndexOf(exerciseTitleToSwap2);
                                courseSchedule.RemoveAt(exerciseIndex);
                                courseSchedule.Insert((index1 + 1), exerciseTitleToSwap2);
                            }
                        }
                        break;

                    case "Exercise":
                        //int trimIndex = cmdArgs[1].Length - "-Exercise".Length;
                        string lessonTitle = cmdArgs[1];/*.Remove(trimIndex);*/
                        string exerciseTitle = cmdArgs[1] + "-Exercise";
                        if (courseSchedule.Contains(lessonTitle))
                        {
                            int indexOfLesson = courseSchedule.IndexOf(lessonTitle);
                            indexOfLesson++;
                            courseSchedule.Insert(indexOfLesson, exerciseTitle);
                        }
                        else
                        {
                            courseSchedule.Add(lessonTitle);
                            courseSchedule.Add(exerciseTitle);
                        }
                        break;

                }
            }
            int listNumber = 1;
            for (int i = 0; i < courseSchedule.Count; i++)
            {
                Console.WriteLine($"{listNumber}.{courseSchedule[i]}");
                listNumber++;
            }
            // 88/100 Test #8
        }
    }
}

