using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_gre : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "gre"; }
    public override string DefinitionInTocaki { get => "10"; }
    public override string DefinitionInFrench { get => "dix, 10"; }
    public override List<string> FrenchWordsAssociated { get => ["10"]; }
}
