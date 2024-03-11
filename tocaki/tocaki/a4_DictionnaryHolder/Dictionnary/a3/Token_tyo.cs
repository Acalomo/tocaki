using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_tyo : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "tyo"; }
    public override string DefinitionInTocaki { get => ""; }
    public override string DefinitionInFrench { get => "des"; }
    public override List<string> FrenchWordsAssociated { get => ["des"]; }
}

