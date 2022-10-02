UPDATE pessoa
	SET datanascimento = '2000-05-15',
		idade = 24
WHERE id IN (4,5)
;

UPDATE pessoa
	SET idade = 150
WHERE id = 5
;

UPDATE pessoa
	SET idade = 35
WHERE nome like 'Legolas';