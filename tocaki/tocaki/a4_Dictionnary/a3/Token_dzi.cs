﻿using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_dzi : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "dzi"; }
    public override string DefinitionInTocaki { get => "9"; }
    public override string DefinitionInFrench { get => "9∅"; }
    public override List<string> FrenchWordsAssociated { get => ["9", "neuf"]; }
}
