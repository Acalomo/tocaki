﻿using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_vni : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "vni"; }
    public override string DefinitionInTocaki { get => "7∅"; }
    public override string DefinitionInFrench { get => "sept, 7"; }
    public override List<string> FrenchWordsAssociated { get => ["7"]; }
}
