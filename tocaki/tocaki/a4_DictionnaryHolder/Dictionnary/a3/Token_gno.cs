using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_gno : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "gno"; }
    public override string DefinitionInTocaki { get => ""; }
    public override string DefinitionInFrench { get => "Balise qui indique un nombre positif."; }
    public override List<string> FrenchWordsAssociated { get => ["plus"]; }
}
