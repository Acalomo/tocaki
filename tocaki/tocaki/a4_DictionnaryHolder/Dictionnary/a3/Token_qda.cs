using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_qda : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "qda"; }
    public override string DefinitionInTocaki { get => "qda"; }
    public override string DefinitionInFrench { get => "�tre"; }
    public override List<string> FrenchWordsAssociated { get => ["�tre"]; }
}
