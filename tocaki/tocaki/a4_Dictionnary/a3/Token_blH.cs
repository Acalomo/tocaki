using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_blH : LexicalToken
{
    public override string Phonetics { get => "blH"; }
    public override string DefinitionInTocaki { get => "∅8"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => ["8", "huit"]; }

    public override List<Type> ParentConcepts { get => []; }
}
