using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a2;

public class Token_ne : LexicalToken
{
    public override string Phonetics { get => "ne"; }
    public override string DefinitionInTocaki { get => "reglu-[]"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}