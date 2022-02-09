// Resolução 1
// Terá um retorno nulo mas não acusara a excessão.
public Person GetFirst(List<Person> people) {
		return people.FirstOrDefault();
}

// Resolução 2
// Trará uma mensagem de para o ususario.
public Person GetFirst(List<Person> people){
         if (people == null){
                    Console.WriteLine("lista vazia");
                }else {
                    return people.First();
                }
}

-- A resolução 2 é a mais correta pois trará uma mensagem ao ususario.