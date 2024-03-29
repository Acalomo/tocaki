using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a2;

public class Token_qu : LexicalToken
{
    public override string Phonetics { get => "qu"; }
    public override string DefinitionInTocaki { get => "tu⋃tu"; }
    public override string DefinitionInFrench { get => "désigne plusieurs « tu » à qui le locuteur parle, vous"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
