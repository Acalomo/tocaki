using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_blA : LexicalToken
{
    public override string Phonetics { get => "blA"; }
    public override string DefinitionInTocaki { get => "∅9"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => ["9", "neuf"]; }

    public override List<Type> ParentConcepts { get => []; }
}
