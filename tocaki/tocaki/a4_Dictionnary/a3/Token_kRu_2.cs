using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_kRu : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "kRu"; }
    public override string DefinitionInTocaki { get => "kRu"; }
    public override string DefinitionInFrench { get => "puanteur"; }
    public override List<string> FrenchWordsAssociated { get => ["puanteur"]; }
}
