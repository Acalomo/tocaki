using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_gna : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "gna"; }
    public override string DefinitionInTocaki { get => ""; }
    public override string DefinitionInFrench { get => "Balise qui indique un nombre n�gatif."; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
