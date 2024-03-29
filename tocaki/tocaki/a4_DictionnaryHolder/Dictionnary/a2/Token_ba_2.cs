﻿using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a2;

public class Token_ba : LexicalToken
{
    public override string Phonetics { get => "ba"; }
    public override string DefinitionInTocaki { get => "[]-vuma-*"; }
    public override string DefinitionInFrench { get => "mon, ma"; }
    public override List<string> FrenchWordsAssociated { get => ["mon", "ma"]; }

    public override List<Type> ParentConcepts { get => []; }
}
