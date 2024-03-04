using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_dyA : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "dyA"; }
    public override string DefinitionInTocaki { get => "reglu-[]"; }
    public override string DefinitionInFrench { get => "Qui a un nom."; }
    public override List<string> FrenchWordsAssociated { get => ["nomm�"]; }
}
