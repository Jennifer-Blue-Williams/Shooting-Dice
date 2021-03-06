using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; set; }
        public SmackTalkingPlayer()
        {
            Taunt = "It's a shame you can't roll the dice correctly";
        }
        public override int Roll()
        {
            System.Console.WriteLine($"{Name} says '{Taunt}'");
            return new Random().Next(DiceSize) + 1;
        }
    }
}