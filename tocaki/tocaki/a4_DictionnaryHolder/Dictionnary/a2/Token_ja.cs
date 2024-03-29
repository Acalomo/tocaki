using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a2;

public class Token_ja : LexicalToken
{
    public override string Phonetics { get => "ja"; }
    public override string DefinitionInTocaki { get => "ja"; }
    public override string DefinitionInFrench { get => "je, moi"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
