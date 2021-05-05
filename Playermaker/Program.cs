using System;
using System.Collections.Generic;

namespace Playermaker
{
    class Program
    {
        public static void CheckD3Team(int choice2p, string space16, string space12, List<string> div3)
        {
            for (int isItThisTeam = 0; isItThisTeam < 20; isItThisTeam++)
            {
                if(div3.ToArray()[choice2p] == League.divTeam[2,isItThisTeam].name)
                {
                    System.Console.WriteLine(   "Team"            + space16   + League.divTeam[2,isItThisTeam].name         + "\n"
                    +                           "Division"        + space12   + League.divTeam[2,isItThisTeam].div          + "\n"
                    +                           "Currency"        + space12   + League.divTeam[2,isItThisTeam].currency     + "\n"
                    +                           "Squad" +  "\n");
                    for (int isItThisSquad = 0; isItThisSquad < 60; isItThisSquad++)
                    {
                        if (League.divTeam[2,isItThisTeam].name == Team.squad[isItThisSquad,1].tName)
                        {
                            for (int squadMembers = 0; squadMembers < League.divTeam[2,isItThisTeam].currentPlayers; squadMembers++)
                            {
                                if ((squadMembers + 1).ToString().Length == 1)
                                {
                                    System.Console.WriteLine(Team.squad[isItThisSquad,squadMembers].tName + " [" + (squadMembers + 1) + "]  " + Team.squad[isItThisSquad,squadMembers].name + " " + Team.squad[isItThisSquad,squadMembers].surname);
                                }
                                else if((squadMembers + 1).ToString().Length == 2)
                                {
                                    System.Console.WriteLine(Team.squad[isItThisSquad,squadMembers].tName + " [" + (squadMembers + 1) + "] " + Team.squad[isItThisSquad,squadMembers].name + " " + Team.squad[isItThisSquad,squadMembers].surname);
                                }
                            }
                        }
                    }
                }
            }
        }
        public static void CheckD2Team(int choice2p, string space16, string space12, List<string> div2)
        {
            for (int isItThisTeam = 0; isItThisTeam < 20; isItThisTeam++)
            {
                if(div2.ToArray()[choice2p] == League.divTeam[1,isItThisTeam].name)
                {
                    System.Console.WriteLine(   "Team"            + space16   + League.divTeam[1,isItThisTeam].name         + "\n"
                    +                           "Division"        + space12   + League.divTeam[1,isItThisTeam].div          + "\n"
                    +                           "Currency"        + space12   + League.divTeam[1,isItThisTeam].currency     + "\n"
                    +                           "Squad" +  "\n");
                    for (int isItThisSquad = 0; isItThisSquad < 60; isItThisSquad++)
                    {
                        if (League.divTeam[1,isItThisTeam].name == Team.squad[isItThisSquad,1].tName)
                        {
                            for (int squadMembers = 0; squadMembers < League.divTeam[1,isItThisTeam].currentPlayers; squadMembers++)
                            {
                                if ((squadMembers + 1).ToString().Length == 1)
                                {
                                    System.Console.WriteLine(Team.squad[isItThisSquad,squadMembers].tName + " [" + (squadMembers + 1) + "]  " + Team.squad[isItThisSquad,squadMembers].name + " " + Team.squad[isItThisSquad,squadMembers].surname);
                                }
                                else if((squadMembers + 1).ToString().Length == 2)
                                {
                                    System.Console.WriteLine(Team.squad[isItThisSquad,squadMembers].tName + " [" + (squadMembers + 1) + "] " + Team.squad[isItThisSquad,squadMembers].name + " " + Team.squad[isItThisSquad,squadMembers].surname);
                                }
                            }
                        }
                    }
                }
            }
        }
        public static void CheckD1Team(int choice2p, string space16, string space12, List<string> div1)
        {
            for (int isItThisTeam = 0; isItThisTeam < 20; isItThisTeam++)
            {
                if(div1.ToArray()[choice2p] == League.divTeam[0,isItThisTeam].name)
                {
                    System.Console.WriteLine(   "Team"            + space16   + League.divTeam[0,isItThisTeam].name         + "\n"
                    +                           "Division"        + space12   + League.divTeam[0,isItThisTeam].div          + "\n"
                    +                           "Currency"        + space12   + League.divTeam[0,isItThisTeam].currency     + "\n"
                    +                           "Squad" +  "\n");
                    for (int isItThisSquad = 0; isItThisSquad < 60; isItThisSquad++)
                    {
                        if (League.divTeam[0,isItThisTeam].name == Team.squad[isItThisSquad,1].tName)
                        {
                            for (int squadMembers = 0; squadMembers < League.divTeam[0,isItThisTeam].currentPlayers; squadMembers++)
                            {
                                if ((squadMembers + 1).ToString().Length == 1)
                                {
                                    System.Console.WriteLine(Team.squad[isItThisSquad,squadMembers].tName + " [" + (squadMembers + 1) + "]  " + Team.squad[isItThisSquad,squadMembers].name + " " + Team.squad[isItThisSquad,squadMembers].surname);
                                }
                                else if((squadMembers + 1).ToString().Length == 2)
                                {
                                    System.Console.WriteLine(Team.squad[isItThisSquad,squadMembers].tName + " [" + (squadMembers + 1) + "] " + Team.squad[isItThisSquad,squadMembers].name + " " + Team.squad[isItThisSquad,squadMembers].surname);
                                }
                            }
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Player.PlayersIntoTeams();
            Team.TeamsIntoDivisions();
            string space17 = "                 ";
            string space16 = "                ";
            string space15 = "               ";
            string space14 = "              ";
            string space13 = "             ";
            string space12 = "            ";
            string space11 = "           ";
            string space10 = "          ";
            string space7 = "       ";
            string space6 = "      ";
            string space5 = "     ";
            string space4 = "    ";
            string space3 = "   ";
            string space = " ";
            Console.Clear();
            System.Console.WriteLine("Check players or teams");
            string choice = Console.ReadLine();
            if (choice == "players" || choice == "1")
            {
                // Hur man lägger till personer i listan
                Player.playerData.Add(new Player("Boing boing", "Outside Hitter", "Kristoffer", "See", 69, 18, "righ", 182, 80, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99));
                Player.playerData.RemoveAt(Player.playerData.ToArray().Length -1);
                Player.playerData.Add(new Player("Test", "Outside Hitter", "Bertil", "Chemnitz", 69, 18, "righ", 182, 80, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99));
                Player.playerData.RemoveAt(Player.playerData.ToArray().Length -1);
                Console.Clear();
                for (int tellMeBoutYou = 0; tellMeBoutYou < Player.playerData.ToArray().Length; tellMeBoutYou++)
                {
                    Console.WriteLine("Name"            + space16   + Player.playerData[tellMeBoutYou].name           + space + Player.playerData[tellMeBoutYou].surname + "\n"
                                    + "Team"            + space16   + Player.playerData[tellMeBoutYou].tName          + "\n"
                                    + "Position"        + space12   + Player.playerData[tellMeBoutYou].position       + "\n"
                                    + "Favorite Number" + space5    + Player.playerData[tellMeBoutYou].number         + space5    + (tellMeBoutYou + 1) + "\n"
                                    + "Age"             + space17   + Player.playerData[tellMeBoutYou].age            + "\n"
                                    + "Height"          + space14   + Player.playerData[tellMeBoutYou].height         + "\n"
                                    + "Weight"          + space14   + Player.playerData[tellMeBoutYou].weight         + "\n"
                                    + "Attack Overall"  + space6    + Player.playerData[tellMeBoutYou].attackingStats + space5    + "Passing Overall" + space5    + Player.playerData[tellMeBoutYou].passingStats   + space5    +  "Pyhsic Overall"  + space6    + Player.playerData[tellMeBoutYou].physicStats    + space5    +  "Defense Overall" + space5    + Player.playerData[tellMeBoutYou].defenseStats   + space5    +  "Mentality Overall"   + space3    + Player.playerData[tellMeBoutYou].mentalityStats  + "\n"
                                    + "Power"           + space15   + Player.playerData[tellMeBoutYou].power          + space5    + "Sett"            + space16   + Player.playerData[tellMeBoutYou].sett           + space5    +  "Stamina"         + space13   + Player.playerData[tellMeBoutYou].stamina        + space5    +  "Marking"         + space13   + Player.playerData[tellMeBoutYou].marking        + space5    +  "Attack Position"     + space5    + Player.playerData[tellMeBoutYou].atkP            + "\n"
                                    + "Spike"           + space15   + Player.playerData[tellMeBoutYou].spike          + space5    + "Vision"          + space14   + Player.playerData[tellMeBoutYou].vision         + space5    +  "Balance"         + space13   + Player.playerData[tellMeBoutYou].balance        + space5    +  "Blocking"        + space12   + Player.playerData[tellMeBoutYou].blocking       + space5    +  "Defense Position"    + space4    + Player.playerData[tellMeBoutYou].defP            + "\n"
                                    + "Serve"           + space15   + Player.playerData[tellMeBoutYou].serve          + space5    + "Under Arm Pass"  + space6    + Player.playerData[tellMeBoutYou].uAPass         + space5    +  "Speed"           + space15   + Player.playerData[tellMeBoutYou].speed          + space5    +  "Reading"         + space13   + Player.playerData[tellMeBoutYou].reading        + space5    +  "Timing"              + space14   + Player.playerData[tellMeBoutYou].timing          + "\n"
                                    + "Direct"          + space14   + Player.playerData[tellMeBoutYou].direct         + space5    + "Over Arm Pass"   + space7    + Player.playerData[tellMeBoutYou].oAPass         + space5    +  "Mobility"        + space12   + Player.playerData[tellMeBoutYou].mobility       + space5    +  "Dig"             + space17   + Player.playerData[tellMeBoutYou].dig            + space5    +  "Composure"           + space11   + Player.playerData[tellMeBoutYou].coolness        + "\n"
                                    + "Backrow"         + space13   + Player.playerData[tellMeBoutYou].backrow        + space5    + "Ball Controll"   + space7    + Player.playerData[tellMeBoutYou].controll       + space5    +  "Elasticity"      + space10   + Player.playerData[tellMeBoutYou].elasticity     + space5    +  "Reaction"        + space12   + Player.playerData[tellMeBoutYou].reaction       + " \n");
                }
                Console.ReadLine();
            }
            while(choice == "team" || choice == "2")
            {
                Console.Clear();
                System.Console.WriteLine("What League?\n\n\tDivision 1\n\tDivision 2\n\tDivision 3");
                string choice2 = Console.ReadLine();
                List<String> div1 = new List<string>();
                List<String> div2 = new List<string>();
                List<String> div3 = new List<string>();
                bool lookingAtD1 = false;
                bool lookingAtD2 = false;
                bool lookingAtD3 = false;
                int choice2p;
                if(choice2 == "1" || choice2 == "div1")
                {
                    lookingAtD1 = true;
                    for (int div1Teams = 0; div1Teams < 20; div1Teams++)
                    {
                        div1.Add(League.divTeam[0,div1Teams].name);
                    }
                    div1.Sort();
                    lookingAtD1 = true;
                    while (lookingAtD1 == true)
                    {
                        Console.Clear();
                        for (int div1Teams = 0; div1Teams < div1.ToArray().Length; div1Teams++)
                        {
                            System.Console.WriteLine("["+ (div1Teams + 1) +"] " + div1.ToArray()[div1Teams]);
                        }
                        string Choice2p1 = Console.ReadLine();
                        if (Choice2p1 == "1" || Choice2p1 == div1.ToArray()[0].ToString())
                        {
                            Console.Clear();
                            choice2p = 0;
                            CheckD1Team(choice2p, space16, space12, div1);
                            Console.ReadLine();
                        }
                        else if (Choice2p1 == "2" || Choice2p1 == div1.ToArray()[1].ToString())
                        {
                            Console.Clear();
                            choice2p = 1;
                            CheckD1Team(choice2p, space16, space12, div1);
                            Console.ReadLine();
                        }
                        else if (Choice2p1 == "3" || Choice2p1 == div1.ToArray()[2].ToString())
                        {
                            Console.Clear();
                            choice2p = 2;
                            CheckD1Team(choice2p, space16, space12, div1);
                            Console.ReadLine();
                        }
                        else if (Choice2p1 == "4" || Choice2p1 == div1.ToArray()[3].ToString())
                        {
                            Console.Clear();
                            choice2p = 3;
                            CheckD1Team(choice2p, space16, space12, div1);
                            Console.ReadLine();
                        }
                        else if (Choice2p1 == "5" || Choice2p1 == div1.ToArray()[4].ToString())
                        {
                            Console.Clear();
                            choice2p = 4;
                            CheckD1Team(choice2p, space16, space12, div1);
                            Console.ReadLine();
                        }
                        else if (Choice2p1 == "6" || Choice2p1 == div1.ToArray()[5].ToString())
                        {
                            Console.Clear();
                            choice2p = 5;
                            CheckD1Team(choice2p, space16, space12, div1);
                            Console.ReadLine();
                        }
                        else if (Choice2p1 == "7" || Choice2p1 == div1.ToArray()[6].ToString())
                        {
                            Console.Clear();
                            choice2p = 6;
                            CheckD1Team(choice2p, space16, space12, div1);
                            Console.ReadLine();
                        }
                        else if (Choice2p1 == "8" || Choice2p1 == div1.ToArray()[7].ToString())
                        {
                            Console.Clear();
                            choice2p = 7;
                            CheckD1Team(choice2p, space16, space12, div1);
                            Console.ReadLine();
                        }
                        else if (Choice2p1 == "9" || Choice2p1 == div1.ToArray()[8].ToString())
                        {
                            Console.Clear();
                            choice2p = 8;
                            CheckD1Team(choice2p, space16, space12, div1);
                            Console.ReadLine();
                        }
                        else if (Choice2p1 == "10" || Choice2p1 == div1.ToArray()[9].ToString())
                        {
                            Console.Clear();
                            choice2p = 9;
                            CheckD1Team(choice2p, space16, space12, div1);
                            Console.ReadLine();
                        }
                        else if (Choice2p1 == "11" || Choice2p1 == div1.ToArray()[10].ToString())
                        {
                            Console.Clear();
                            choice2p = 10;
                            CheckD1Team(choice2p, space16, space12, div1);
                            Console.ReadLine();
                        }
                        else if (Choice2p1 == "12" || Choice2p1 == div1.ToArray()[11].ToString())
                        {
                            Console.Clear();
                            choice2p = 11;
                            CheckD1Team(choice2p, space16, space12, div1);
                            Console.ReadLine();
                        }
                        else if (Choice2p1 == "13" || Choice2p1 == div1.ToArray()[12].ToString())
                        {
                            Console.Clear();
                            choice2p = 12;
                            CheckD1Team(choice2p, space16, space12, div1);
                            Console.ReadLine();
                        }
                        else if (Choice2p1 == "14" || Choice2p1 == div1.ToArray()[13].ToString())
                        {
                            Console.Clear();
                            choice2p = 13;
                            CheckD1Team(choice2p, space16, space12, div1);
                            Console.ReadLine();
                        }
                        else if (Choice2p1 == "15" || Choice2p1 == div1.ToArray()[14].ToString())
                        {
                            Console.Clear();
                            choice2p = 14;
                            CheckD1Team(choice2p, space16, space12, div1);
                            Console.ReadLine();
                        }
                        else if (Choice2p1 == "16" || Choice2p1 == div1.ToArray()[15].ToString())
                        {
                            Console.Clear();
                            choice2p = 15;
                            CheckD1Team(choice2p, space16, space12, div1);
                            Console.ReadLine();
                        }
                        else if (Choice2p1 == "17" || Choice2p1 == div1.ToArray()[16].ToString())
                        {
                            Console.Clear();
                            choice2p = 16;
                            CheckD1Team(choice2p, space16, space12, div1);
                            Console.ReadLine();
                        }
                        else if (Choice2p1 == "18" || Choice2p1 == div1.ToArray()[17].ToString())
                        {
                            Console.Clear();
                            choice2p = 17;
                            CheckD1Team(choice2p, space16, space12, div1);
                            Console.ReadLine();
                        }
                        else if (Choice2p1 == "19" || Choice2p1 == div1.ToArray()[18].ToString())
                        {
                            Console.Clear();
                            choice2p = 18;
                            CheckD1Team(choice2p, space16, space12, div1);
                            Console.ReadLine();
                        }
                        else if (Choice2p1 == "20" || Choice2p1 == div1.ToArray()[19].ToString())
                        {
                            Console.Clear();
                            choice2p = 19;
                            CheckD1Team(choice2p, space16, space12, div1);
                            Console.ReadLine();
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else if(choice2 == "2" || choice2 == "div2")
                {
                    lookingAtD2 = true;
                    for (int div2Teams = 0; div2Teams < 20; div2Teams++)
                    {
                        div2.Add(League.divTeam[1,div2Teams].name);
                    }
                    div2.Sort();
                    lookingAtD2 = true;
                    while (lookingAtD2 == true)
                    {
                        Console.Clear();
                        for (int div2Teams = 0; div2Teams < div2.ToArray().Length; div2Teams++)
                        {
                            System.Console.WriteLine("["+ (div2Teams + 1) +"] " + div2.ToArray()[div2Teams]);
                        }
                        string Choice2p2 = Console.ReadLine();
                        if (Choice2p2 == "1" || Choice2p2 == div2.ToArray()[0].ToString())
                        {
                            Console.Clear();
                            choice2p = 0;
                            CheckD2Team(choice2p, space16, space12, div2);
                            Console.ReadLine();
                        }
                        else if (Choice2p2 == "2" || Choice2p2 == div2.ToArray()[1].ToString())
                        {
                            Console.Clear();
                            choice2p = 1;
                            CheckD2Team(choice2p, space16, space12, div2);
                            Console.ReadLine();
                        }
                        else if (Choice2p2 == "3" || Choice2p2 == div2.ToArray()[2].ToString())
                        {
                            Console.Clear();
                            choice2p = 2;
                            CheckD2Team(choice2p, space16, space12, div2);
                            Console.ReadLine();
                        }
                        else if (Choice2p2 == "4" || Choice2p2 == div2.ToArray()[3].ToString())
                        {
                            Console.Clear();
                            choice2p = 3;
                            CheckD2Team(choice2p, space16, space12, div2);
                            Console.ReadLine();
                        }
                        else if (Choice2p2 == "5" || Choice2p2 == div2.ToArray()[4].ToString())
                        {
                            Console.Clear();
                            choice2p = 4;
                            CheckD2Team(choice2p, space16, space12, div2);
                            Console.ReadLine();
                        }
                        else if (Choice2p2 == "6" || Choice2p2 == div2.ToArray()[5].ToString())
                        {
                            Console.Clear();
                            choice2p = 5;
                            CheckD2Team(choice2p, space16, space12, div2);
                            Console.ReadLine();
                        }
                        else if (Choice2p2 == "7" || Choice2p2 == div2.ToArray()[6].ToString())
                        {
                            Console.Clear();
                            choice2p = 6;
                            CheckD2Team(choice2p, space16, space12, div2);
                            Console.ReadLine();
                        }
                        else if (Choice2p2 == "8" || Choice2p2 == div2.ToArray()[7].ToString())
                        {
                            Console.Clear();
                            choice2p = 7;
                            CheckD2Team(choice2p, space16, space12, div2);
                            Console.ReadLine();
                        }
                        else if (Choice2p2 == "9" || Choice2p2 == div2.ToArray()[8].ToString())
                        {
                            Console.Clear();
                            choice2p = 8;
                            CheckD2Team(choice2p, space16, space12, div2);
                            Console.ReadLine();
                        }
                        else if (Choice2p2 == "10" || Choice2p2 == div2.ToArray()[9].ToString())
                        {
                            Console.Clear();
                            choice2p = 9;
                            CheckD2Team(choice2p, space16, space12, div2);
                            Console.ReadLine();
                        }
                        else if (Choice2p2 == "11" || Choice2p2 == div2.ToArray()[10].ToString())
                        {
                            Console.Clear();
                            choice2p = 10;
                            CheckD2Team(choice2p, space16, space12, div2);
                            Console.ReadLine();
                        }
                        else if (Choice2p2 == "12" || Choice2p2 == div2.ToArray()[11].ToString())
                        {
                            Console.Clear();
                            choice2p = 11;
                            CheckD2Team(choice2p, space16, space12, div2);
                            Console.ReadLine();
                        }
                        else if (Choice2p2 == "13" || Choice2p2 == div2.ToArray()[12].ToString())
                        {
                            Console.Clear();
                            choice2p = 12;
                            CheckD2Team(choice2p, space16, space12, div2);
                            Console.ReadLine();
                        }
                        else if (Choice2p2 == "14" || Choice2p2 == div2.ToArray()[13].ToString())
                        {
                            Console.Clear();
                            choice2p = 13;
                            CheckD2Team(choice2p, space16, space12, div2);
                            Console.ReadLine();
                        }
                        else if (Choice2p2 == "15" || Choice2p2 == div2.ToArray()[14].ToString())
                        {
                            Console.Clear();
                            choice2p = 14;
                            CheckD2Team(choice2p, space16, space12, div2);
                            Console.ReadLine();
                        }
                        else if (Choice2p2 == "16" || Choice2p2 == div2.ToArray()[15].ToString())
                        {
                            Console.Clear();
                            choice2p = 15;
                            CheckD2Team(choice2p, space16, space12, div2);
                            Console.ReadLine();
                        }
                        else if (Choice2p2 == "17" || Choice2p2 == div2.ToArray()[16].ToString())
                        {
                            Console.Clear();
                            choice2p = 16;
                            CheckD2Team(choice2p, space16, space12, div2);
                            Console.ReadLine();
                        }
                        else if (Choice2p2 == "18" || Choice2p2 == div2.ToArray()[17].ToString())
                        {
                            Console.Clear();
                            choice2p = 17;
                            CheckD2Team(choice2p, space16, space12, div2);
                            Console.ReadLine();
                        }
                        else if (Choice2p2 == "19" || Choice2p2 == div2.ToArray()[18].ToString())
                        {
                            Console.Clear();
                            choice2p = 18;
                            CheckD2Team(choice2p, space16, space12, div2);
                            Console.ReadLine();
                        }
                        else if (Choice2p2 == "20" || Choice2p2 == div2.ToArray()[19].ToString())
                        {
                            Console.Clear();
                            choice2p = 19;
                            CheckD2Team(choice2p, space16, space12, div2);
                            Console.ReadLine();
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else if(choice2 == "3" || choice2 == "div3")
                {
                    for (int div3Teams = 0; div3Teams < 20; div3Teams++)
                    {
                        div3.Add(League.divTeam[2,div3Teams].name);
                    }
                    div3.Sort();
                    lookingAtD3 = true;
                    while (lookingAtD3 == true)
                    {
                        Console.Clear();
                        for (int div3Teams = 0; div3Teams < div3.ToArray().Length; div3Teams++)
                        {
                            System.Console.WriteLine("["+ (div3Teams + 1) +"] " + div3.ToArray()[div3Teams]);
                        }
                        string Choice2p3 = Console.ReadLine();
                        if (Choice2p3 == "1" || Choice2p3 == div3.ToArray()[0].ToString())
                        {
                            Console.Clear();
                            choice2p = 0;
                            CheckD3Team(choice2p, space16, space12, div3);
                            Console.ReadLine();
                        }
                        else if (Choice2p3 == "2" || Choice2p3 == div3.ToArray()[1].ToString())
                        {
                            Console.Clear();
                            choice2p = 1;
                            CheckD3Team(choice2p, space16, space12, div3);
                            Console.ReadLine();
                        }
                        else if (Choice2p3 == "3" || Choice2p3 == div3.ToArray()[2].ToString())
                        {
                            Console.Clear();
                            choice2p = 2;
                            CheckD3Team(choice2p, space16, space12, div3);
                            Console.ReadLine();
                        }
                        else if (Choice2p3 == "4" || Choice2p3 == div3.ToArray()[3].ToString())
                        {
                            Console.Clear();
                            choice2p = 3;
                            CheckD3Team(choice2p, space16, space12, div3);
                            Console.ReadLine();
                        }
                        else if (Choice2p3 == "5" || Choice2p3 == div3.ToArray()[4].ToString())
                        {
                            Console.Clear();
                            choice2p = 4;
                            CheckD3Team(choice2p, space16, space12, div3);
                            Console.ReadLine();
                        }
                        else if (Choice2p3 == "6" || Choice2p3 == div3.ToArray()[5].ToString())
                        {
                            Console.Clear();
                            choice2p = 5;
                            CheckD3Team(choice2p, space16, space12, div3);
                            Console.ReadLine();
                        }
                        else if (Choice2p3 == "7" || Choice2p3 == div3.ToArray()[6].ToString())
                        {
                            Console.Clear();
                            choice2p = 6;
                            CheckD3Team(choice2p, space16, space12, div3);
                            Console.ReadLine();
                        }
                        else if (Choice2p3 == "8" || Choice2p3 == div3.ToArray()[7].ToString())
                        {
                            Console.Clear();
                            choice2p = 7;
                            CheckD3Team(choice2p, space16, space12, div3);
                            Console.ReadLine();
                        }
                        else if (Choice2p3 == "9" || Choice2p3 == div3.ToArray()[8].ToString())
                        {
                            Console.Clear();
                            choice2p = 8;
                            CheckD3Team(choice2p, space16, space12, div3);
                            Console.ReadLine();
                        }
                        else if (Choice2p3 == "10" || Choice2p3 == div3.ToArray()[9].ToString())
                        {
                            Console.Clear();
                            choice2p = 9;
                            CheckD3Team(choice2p, space16, space12, div3);
                            Console.ReadLine();
                        }
                        else if (Choice2p3 == "11" || Choice2p3 == div3.ToArray()[10].ToString())
                        {
                            Console.Clear();
                            choice2p = 10;
                            CheckD3Team(choice2p, space16, space12, div3);
                            Console.ReadLine();
                        }
                        else if (Choice2p3 == "12" || Choice2p3 == div3.ToArray()[11].ToString())
                        {
                            Console.Clear();
                            choice2p = 11;
                            CheckD3Team(choice2p, space16, space12, div3);
                            Console.ReadLine();
                        }
                        else if (Choice2p3 == "13" || Choice2p3 == div3.ToArray()[12].ToString())
                        {
                            Console.Clear();
                            choice2p = 12;
                            CheckD3Team(choice2p, space16, space12, div3);
                            Console.ReadLine();
                        }
                        else if (Choice2p3 == "14" || Choice2p3 == div3.ToArray()[13].ToString())
                        {
                            Console.Clear();
                            choice2p = 13;
                            CheckD3Team(choice2p, space16, space12, div3);
                            Console.ReadLine();
                        }
                        else if (Choice2p3 == "15" || Choice2p3 == div3.ToArray()[14].ToString())
                        {
                            Console.Clear();
                            choice2p = 14;
                            CheckD3Team(choice2p, space16, space12, div3);
                            Console.ReadLine();
                        }
                        else if (Choice2p3 == "16" || Choice2p3 == div3.ToArray()[15].ToString())
                        {
                            Console.Clear();
                            choice2p = 15;
                            CheckD3Team(choice2p, space16, space12, div3);
                            Console.ReadLine();
                        }
                        else if (Choice2p3 == "17" || Choice2p3 == div3.ToArray()[16].ToString())
                        {
                            Console.Clear();
                            choice2p = 16;
                            CheckD3Team(choice2p, space16, space12, div3);
                            Console.ReadLine();
                        }
                        else if (Choice2p3 == "18" || Choice2p3 == div3.ToArray()[17].ToString())
                        {
                            Console.Clear();
                            choice2p = 17;
                            CheckD3Team(choice2p, space16, space12, div3);
                            Console.ReadLine();
                        }
                        else if (Choice2p3 == "19" || Choice2p3 == div3.ToArray()[18].ToString())
                        {
                            Console.Clear();
                            choice2p = 18;
                            CheckD3Team(choice2p, space16, space12, div3);
                            Console.ReadLine();
                        }
                        else if (Choice2p3 == "20" || Choice2p3 == div3.ToArray()[19].ToString())
                        {
                            Console.Clear();
                            choice2p = 19;
                            CheckD3Team(choice2p, space16, space12, div3);
                            Console.ReadLine();
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
}
