using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_Rwe : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "Rwe"; }
    public override string DefinitionInTocaki { get => "R"; }
    public override string DefinitionInFrench { get => "La lettre R"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}