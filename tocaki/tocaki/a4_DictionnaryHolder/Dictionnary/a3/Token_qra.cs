using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_qra : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "qra"; }
    public override string DefinitionInTocaki { get => "qra"; }
    public override string DefinitionInFrench { get => "Pronom qui désigne un objet."; }
    public override List<string> FrenchWordsAssociated { get => ["ce", "cette"]; }
}
