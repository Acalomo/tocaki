using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_plN : LexicalToken
{
    public override string Phonetics { get => "plN"; }
    public override string DefinitionInTocaki { get => "66"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => ["66"]; }

    public override List<Type> ParentConcepts { get => []; }
}
