using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a2;

public class Token_Bi : LexicalToken
{
    public override string Phonetics { get => "Bi"; }
    public override string DefinitionInTocaki { get => "Bi"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => ["son", "sa"]; }

    public override List<Type> ParentConcepts { get => []; }
}
