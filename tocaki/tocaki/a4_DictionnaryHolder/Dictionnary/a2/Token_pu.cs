using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a2;

public class Token_pu72 : LexicalToken
{
    public override string Phonetics { get => "pu"; }
    public override string DefinitionInTocaki { get => "[]-vuma-*"; }
    public override string DefinitionInFrench { get => "absence de l'objet, de l'idée l’absence, intensité 0/10"; }
    public override List<string> FrenchWordsAssociated { get => new List<string>(); }

    public override List<Type> ParentConcepts { get => []; }
}
