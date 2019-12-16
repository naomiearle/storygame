using System;

namespace storygame
{
    class Program
    {
        static void Main(string[] args)
        {
            //getting name
            Console.WriteLine("Hello! What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Are you a BOY or a GIRL?");
            string answer = Console.ReadLine().ToUpper();
            string gender = "";
            if (answer == "BOY")
            {
                gender = "his";
            }
            else if (answer == "GIRL")
            {
                gender = "her";
            }
            else
            {
                Console.WriteLine("Please enter either BOY or GIRL.");
            }
            Console.WriteLine($"Hello, {name}. Welcome to the story.");

            Console.WriteLine("Our story begins on a dark night in the middle of winter...");
            Console.WriteLine($"{name} is lying in {gender} bed, trying to fall asleep.");
            Console.WriteLine("You hear a noise coming from outside the door.");
            Console.WriteLine("Do you investigate?");
            Console.WriteLine("Type YES or NO:");
            string answer_one = Console.ReadLine().ToUpper();
            if (answer_one == "NO")
            {
                Console.WriteLine("Where's your sense of adventure?");
                Console.WriteLine("THE END");
            }
            else if (answer_one == "YES")
            {
                Console.WriteLine("You get out of bed and open the door.");
                Console.WriteLine("It seems that there is some kind of portal in the hallway outside your room.");
                Console.WriteLine("Go through the portal?");
                Console.WriteLine("Type YES or NO:");
                string answer_two = Console.ReadLine().ToUpper();
                if (answer_two == "NO")
                {
                    Console.WriteLine("You freak out and run back to bed. Probably a wise decision.");
                    Console.WriteLine("THE END");
                }
                else if (answer_two == "YES")
                {
                    Console.WriteLine("You step through the portal.");
                    Console.WriteLine("You realise that you are still in the same hallway, but the walls are covered in black goo and it is much colder now.");
                    Console.WriteLine("You look behind you and realise the portal is gone. You're stuck here.");
                    Console.WriteLine("Do you go forward down the corridor, or back through the door into your room?");
                    Console.WriteLine("Type FORWARD or BACK");
                    string answer_three = Console.ReadLine().ToUpper();
                    if (answer_three == "BACK")
                    {
                        Console.WriteLine("You enter the door to your room and look around.");
                        Console.WriteLine("There is now a large painting of a clown on the wall of your room");
                        Console.WriteLine("You can see the eyes of the clown following you as you walk around the room, and after a few seconds he starts to speak...");
                        Console.WriteLine("\"Do you want to go home? Guess a number between 1 and 5, and if you guess correctly, I'll send you back. Otherwise you will be stuck here forever!\"");
                        Console.WriteLine("Type a whole number between 1 and 5:");
                        string answer_num = Console.ReadLine();
                        switch (answer_num)
                        {
                            case "1":
                                Console.WriteLine("You have guessed incorrectly. You will spend the rest of your days here.");
                                Console.WriteLine("THE END");
                                break;
                            case "2":
                                Console.WriteLine("You have guessed incorrectly. You will spend the rest of your days here.");
                                Console.WriteLine("THE END");
                                break;
                            case "3":
                                Console.WriteLine("You have guessed incorrectly. You will spend the rest of your days here.");
                                Console.WriteLine("THE END");
                                break;
                            case "4":
                                Console.WriteLine("You have guessed correctly!");
                                Console.WriteLine("The lights become brighter and brighter until everything is white.");
                                Console.WriteLine("As the lights go back to normal you realise that you are back in your old room, and the strange painting is gone.");
                                Console.WriteLine("You get back in bed and fall asleep immediately.");
                                Console.WriteLine("THE END");
                                break;
                            case "5":
                                Console.WriteLine("You have guessed incorrectly. You will spend the rest of your days here.");
                                Console.WriteLine("THE END");
                                break;
                            default:
                                Console.WriteLine("Guess either 1, 2, 3, 4 or 5.");
                                break;
                        }
                    }
                    else if (answer_three == "FORWARD")
                    {
                        Console.WriteLine("You walk forward down the corridor.");
                        Console.WriteLine("At the end of the corridor, you can either turn right or left.");
                        Console.WriteLine("The right path is dark and cold. The left path is well-lit and seems safe.");
                        Console.WriteLine("Which path will you take?");
                        Console.WriteLine("Type LEFT or RIGHT:");
                        string answer_four = Console.ReadLine().ToUpper();
                        if (answer_four == "LEFT")
                        {
                            Console.WriteLine("You chose the left path.");
                            Console.WriteLine("You look down and see that the floor is carpeted. As you walk down the hallway you start to hear beautiful music which is getting louder and louder. You are happy with your decision to take this path.");
                            Console.WriteLine("You reach the end of the path, and realise that you are now in a beautiful forest.");
                            Console.WriteLine("You are surrounded by fruit trees, and you can smell flowers.");
                            Console.WriteLine("Right in front of you is some kind of vegetable patch with colourful mushrooms growing in it.");
                            Console.WriteLine("There is a sign that reads: \"Eat the mushrooms and learn the meaning of existence\"");
                            Console.WriteLine("Eat the mushrooms?");
                            Console.WriteLine("Type YES or NO:");
                            string answer_shroom = Console.ReadLine().ToUpper();
                            if (answer_shroom == "YES")
                            {
                                Console.WriteLine("You bend down, pick one of the mushrooms and take a bite.");
                                Console.WriteLine("It tastes like chocolate milkshake.");
                                Console.WriteLine("You notice that all the colours in the forest are becoming more vivid, and everything is blurring together.");
                                Console.WriteLine("There is a fractal portal in front of you. You're pretty sure that once you go inside there's no coming back to this reality.");
                                Console.WriteLine("Go inside the portal?");
                                Console.WriteLine("Type YES (why wouldn't you?):");
                                string answer_fractal = Console.ReadLine().ToUpper();
                                if (answer_fractal == "YES")
                                {
                                    Console.WriteLine("You float through the portal.");
                                    Console.WriteLine("You are free from the prison that is your human body, and you now have a body made of bright white light");
                                    Console.WriteLine("You feel your soul expanding as all negative emotion and ties to your human existence fade away");
                                    Console.WriteLine("You realise that this was your destiny all along, and now you can finally be at peace.");
                                    Console.WriteLine("THE END");
                                }
                                else
                                {
                                    Console.WriteLine("Are you sure? (Type YES)");
                                    string second_chance = Console.ReadLine().ToUpper();
                                    if (second_chance == "YES")
                                    {
                                        Console.WriteLine("You float through the portal.");
                                        Console.WriteLine("You are free from the prison that is your human body, and you now have a body made of bright white light");
                                        Console.WriteLine("You feel your soul expanding as all negative emotion and ties to your human existence fade away");
                                        Console.WriteLine("You realise that this was your destiny all along, and now you can finally be at peace.");
                                        Console.WriteLine("THE END");
                                    }
                                    else
                                    {
                                        Console.WriteLine("You missed your chance. Everything returns to normal, and you realise that you are standing outside your house in your back garden.");
                                        Console.WriteLine("You go back inside the house, go to your room and get in bed. You can't help but feel like you made the wrong decision");
                                    }
                                }
                            }
                            else if (answer_shroom == "NO")
                            {
                                Console.WriteLine("You walk past the mushrooms and go deeper into the forest.");
                                Console.WriteLine("You look behind you and realise that the mushrooms have grown legs and they are now chasing you.");
                                Console.WriteLine("You run as fast as you can, but they catch up to you and eat you. You should have followed the sign...");
                                Console.WriteLine("THE END");
                            }
                        }
                        else if (answer_four == "RIGHT")
                        {
                            Console.WriteLine("You realise that the left path is too good to be true and is probably a trap, so you walk down the right path");
                            Console.WriteLine("As you walk, it becomes harder and harder to see as it is so dark.");
                            Console.WriteLine("After a while it is completely dark and you can't see a thing");
                            Console.WriteLine("There is a light in the distance and you walk towards it.");
                            Console.WriteLine("The light is coming from a staircase, with stairs going down. There is also a small door to your left.");
                            Console.WriteLine("Go through the door or down the stairs?");
                            Console.WriteLine("Type DOOR or STAIRS:");
                            string answer_five = Console.ReadLine().ToUpper();
                            if (answer_five == "DOOR")
                            {
                                Console.WriteLine("You open the door and walk into a dark room.");
                                Console.WriteLine("You walk around for a while and realise that the floor is very sticky, and it's becoming harder and harder to walk.");
                                Console.WriteLine("You are now stuck, and can't move at all");
                                Console.WriteLine("You hear a high-pitched voice: \"Hello! Thank you for coming into my feeding room! You will now be eaten!\"");
                                Console.WriteLine("You see the creepy smile of a large spider as she wraps you in sticky web.");
                                Console.WriteLine("THE END");
                            }
                            else if (answer_five == "STAIRS")
                            {
                                Console.WriteLine("You go down the stairs, turning corners every now and again.");
                                Console.WriteLine("After walking down the stairs for about 10 minutes, you start to worry.");
                                Console.WriteLine("When will you get to the bottom?");
                                Console.WriteLine("You are sure that this was the wrong decision, so you turn around and start walking up the stairs.");
                                Console.WriteLine("After ascending the stairs for about half an hour, you realise that you should have been at the top a while ago.");
                                Console.WriteLine("A sinking feeling builds in your chest as you realise that you may never leave this staircase.");
                                Console.WriteLine("Welcome to hell");
                                Console.WriteLine("THE END");
                            }
                        }
                    }
                }
            }
        }
    }
}
