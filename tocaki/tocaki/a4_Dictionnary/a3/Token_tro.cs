using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_tro : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "tro"; }
    public override string DefinitionInTocaki { get => "32"; }
    public override string DefinitionInFrench { get => "32"; }
    public override List<string> FrenchWordsAssociated { get => ["32"]; }
}
