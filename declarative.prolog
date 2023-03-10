male(homer).
male(bart).
male(grandpaS).
male(grandpaB).
female(marge).
female(lisa).
female(maggie).
female(grandmaS).
female(grandmaS).
parentOf(homer, grandpaS).
parentOf(homer, grandmaS).
parentOf(marge, grandpaB).
parentOf(marge, grandmaB).
parentOf(bart, homer).
parentOf(bart, marge).
parentOf(lisa, homer).
parentOf(lisa, marge).
parentOf(maggie, homer).
parentOf(maggie, marge).

grandParentOf(Grandchild, Grandparent) :-  parentOf(Grandchild, Parent), parentOf(Parent, Grandparent).
grandFatherOf(Grandchild, Grandparent) :- male(Grandparent), grandParentOf(Grandchild, Grandparent).
grandMotherOf(Grandchild, Grandparent) :- female(Grandparent), grandParentOf(Grandchild, Grandparent).

fatherOf(Child, Parent) :- male(Parent), parentOf(Child, Parent).
motherOf(Child, Parent) :- female(Parent), parentOf(Child, Parent).

childOf(Parent,Child) :- parentOf(Child,Parent).
sonOf(Parent,Child) :- male(Child), childOf(Parent,Child).
daughterOf(Parent,Child) :- female(Child), childOf(Parent, Child).