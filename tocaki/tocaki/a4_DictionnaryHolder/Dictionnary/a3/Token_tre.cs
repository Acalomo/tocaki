using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_tre : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "tre"; }
    public override string DefinitionInTocaki { get => "30"; }
    public override string DefinitionInFrench { get => "30"; }
    public override List<string> FrenchWordsAssociated { get => ["30"]; }
}
