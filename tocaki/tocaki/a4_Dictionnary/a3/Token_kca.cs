using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_kca : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "kca"; }
    public override string DefinitionInTocaki { get => "kca"; }
    public override string DefinitionInFrench { get => "trop, excès"; }
    public override List<string> FrenchWordsAssociated { get => ["trop", "excès"]; }
}
