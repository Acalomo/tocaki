using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_kwe : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "kwe"; }
    public override string DefinitionInTocaki { get => "k"; }
    public override string DefinitionInFrench { get => "la lettre k"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
