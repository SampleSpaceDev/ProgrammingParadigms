using System.IO;
using System;

internal class Wizard {
    public string name { get;  set; }
    public string spell { get;  set; }
    public Spell[] knownSpells { get; set; }

    public Wizard(string name, string spell) {
        this.name = name;
        this.spell = spell;
        this.knownSpells = new Spell[0];
    }

    public void SayName() {
        Console.WriteLine("My name is " + name);
    }
    public void CastSpell() {
        Console.WriteLine("The spell I cast is " + spell);
    }
    public void ListKnownSpells()
    {
        Console.WriteLine($"I know these spells: {string.join(", ", this.knownSpells)}");
    }
}

internal class Spell
{
    public string name { get; set; }
    public Action<Wizard> spell { get; set; }

    public Spell(string name, Action<Wizard> spell)
    {
        this.name = name;
        this.spell = spell;
    }
}

internal class Program {
    static void Main() {
        var heWhoShallNotBeNamed = new Wizard("Voldemort", "Avada kedavra");
        heWhoShallNotBeNamed.SayName();
        heWhoShallNotBeNamed.CastSpell();
        heWhoShallNotBeNamed.ListKnownSpells();

        var noddingWizard = new Wizard("Gandalf", "YOU SHALL NOT PASS!");
        noddingWizard.SayName();
        noddingWizard.CastSpell();
        noddingWizard.ListKnownSpells();
    }
}