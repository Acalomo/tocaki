using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_trA : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "trA"; }
    public override string DefinitionInTocaki { get => "39"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => ["39"]; }
}
