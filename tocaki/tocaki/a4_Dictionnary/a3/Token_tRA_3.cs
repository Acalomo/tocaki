using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_tRA : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "tRA"; }
    public override string DefinitionInTocaki { get => "∅∅∅"; }
    public override string DefinitionInFrench { get => "Collision phonétique avec \"trA\"."; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
