using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_dza : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "dza"; }
    public override string DefinitionInTocaki { get => "91"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => ["91"]; }
}
