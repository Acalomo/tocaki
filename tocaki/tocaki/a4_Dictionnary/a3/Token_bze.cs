using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_bze : LexicalToken
{
    public override string Phonetics { get => "bze"; }
    public override string DefinitionInTocaki { get => "[]-vuma-*"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}