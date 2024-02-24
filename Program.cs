using Binary_tree_attempt;

Tree albero = new(23);

albero.Add(24);
albero.Add(22);
albero.Add(27);
albero.Add(28);
albero.Add(29);
albero.Add(30);
albero.Add(21);
albero.Add(20);


albero.DFSVisits(1);

albero.Remove(27);
albero.Remove(22);
albero.Remove(22);